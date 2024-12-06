# Copyright (c) Meta Platforms, Inc. and affiliates.
#
# This source code is licensed under the MIT license found in the
# LICENSE file in the root directory of this source tree.

import asyncio
import logging
import sys
import threading

from itertools import count, takewhile
from typing import Iterator

from bleak import BleakClient, BleakScanner
from bleak.backends.characteristic import BleakGATTCharacteristic
from bleak.backends.device import BLEDevice
from bleak.backends.scanner import AdvertisementData
from bleak.backends.winrt.client import logger as bleak_log

from PySide6.QtCore import Qt, Signal, Slot
from PySide6.QtWidgets import (
    QApplication,
    QComboBox,
    QLabel,
    QLineEdit,
    QListWidget,
    QListWidgetItem,
    QPushButton,
    QSlider,
    QTabWidget,
    QVBoxLayout,
    QWidget,
)

# Global UUID definitions
UART_SERVICE_UUID = "6E400001-B5A3-F393-E0A9-E50E24DCCA9E"
UART_RX_UUID = "6E400002-B5A3-F393-E0A9-E50E24DCCA9E"
UART_TX_UUID = "6E400003-B5A3-F393-E0A9-E50E24DCCA9E"
CLIENT_CONFIG_DESCRIPTOR_UUID = "00002902-0000-1000-8000-00805f9b34fb"

BLE_DEBUG_LOG_ENABLE = 0


class App(QWidget):
    signal_ble_scan_done = Signal()
    signal_ble_connected = Signal()
    signal_ble_disconnected = Signal()

    def __init__(self):
        super(App, self).__init__()
        self.lastCommand = ""
        self.title = "Vibe Bluetooth UART Control Demo - V1.1"
        self.left = 100
        self.top = 100
        self.width = 480
        self.height = 320
        self.initUI()

        # Initialze tab screen
        self
        self.tabs.bluetooth = QWidget()
        self.tabs.pwm = QWidget()
        self.tab_effects = QWidget()

        # enable detailed log output for the BLE library by setting this define to 1
        if BLE_DEBUG_LOG_ENABLE:
            bleak_log.setLevel(logging.DEBUG)
            ch = logging.StreamHandler()
            ch.setLevel(logging.DEBUG)
            ch.setFormatter(logging.Formatter("---BLEAK:%(levelname)s %(message)s"))
            bleak_log.addHandler(ch)
            bleak_log.disabled = False

        # make a new scanner that will be used with asynch functions
        self.scanner = BleakScanner(
            detection_callback=self.deviceDiscovered,
            allow_duplicates=False,
            service_uuids=[UART_SERVICE_UUID],
        )

        # make a global ble client for use across the various functions
        self.ble_client = None
        self.nus = None
        self.rx_char = None

        # make some ui to async interaction signal functions (since UI cannot be updated directly from other threads)
        self.signal_ble_scan_done.connect(self.bleScanDone)
        self.signal_ble_connected.connect(self.deviceConnected)
        self.signal_ble_disconnected.connect(self.deviceDisconnected)

        # make a new thread that will start the asynchio loop
        async_thread = threading.Thread(target=self.async_setup)
        async_thread.start()

    async def async_test_function(self, *args):
        # Perform async tasks
        print("test async button clicked!")

    def closeEvent(self, event):
        QApplication.quit()

    # This function creates an event loop for use with the asyncio system
    async_loop = None

    def async_setup(self):
        global async_loop
        async_loop = asyncio.new_event_loop()
        async_loop.run_forever()

    def initUI(self):
        self.setWindowTitle(self.title)
        self.setGeometry(self.left, self.top, self.width, self.height)

        # Initialize tab screen
        self.tabs = QTabWidget()
        self.tab_bluetooth = QWidget()
        self.tab_pwm = QWidget()
        self.tab_effects = QWidget()

        # Add tabs
        self.tabs.addTab(self.tab_bluetooth, "Bluetooth")
        self.tabs.addTab(self.tab_pwm, "PWM Driving")
        self.tabs.addTab(self.tab_effects, "Effect Sequencing")

        # Create first tab layout
        self.tab_bluetooth.layout = QVBoxLayout()
        self.createBluetoothTab()
        self.tab_bluetooth.setLayout(self.tab_bluetooth.layout)

        # Create second tab layout
        self.tab_pwm.layout = QVBoxLayout()
        self.createPWMTab()
        self.tab_pwm.setLayout(self.tab_pwm.layout)

        # Create third tab layout
        self.tab_effects.layout = QVBoxLayout()
        self.createEffectsTab()
        self.tab_effects.setLayout(self.tab_effects.layout)

        # Add tabs to widget
        self.layout = QVBoxLayout(self)

        self.layout.addWidget(self.tabs)
        self.setLayout(self.layout)

        # Serial Monitor
        # self.serialMonitor = QPlainTextEdit(self)
        # self.serialMonitor.setReadOnly(True)  # Make the serial monitor read-only
        # self.serialMonitor.ensureCursorVisible()  # Ensure the latest text is visible
        # self.layout.addWidget(self.serialMonitor)

        # Add a text input box
        self.serialCommandInput = QLineEdit(self)
        self.serialCommandInput.setPlaceholderText("Enter a serial command manually...")
        self.serialCommandInput.returnPressed.connect(self.sendSerialCommand)
        self.layout.addWidget(self.serialCommandInput)
        # Add a button to send the command
        self.sendCommandButton = QPushButton("Send Command", self)
        self.sendCommandButton.clicked.connect(self.sendSerialCommand)
        self.layout.addWidget(self.sendCommandButton)

        # Add a label to show connection status
        self.connectionStatus = QLabel("Status: Not Connected")
        self.layout.addWidget(self.connectionStatus)
        # battery voltage display
        self.batteryLabel = QLabel("Battery Voltage: -- V")
        self.layout.addWidget(self.batteryLabel)

        self.setLayout(self.layout)

        self.show()

    def createBluetoothTab(self):
        # Add Bluetooth related widgets to the tab layout
        label = QLabel("Available Devices:")
        self.tab_bluetooth.layout.addWidget(label)
        self.listwidget = QListWidget(self)
        self.listwidget.itemSelectionChanged.connect(
            lambda: self.connectButton.setEnabled(True)
        )
        self.listwidget.itemDoubleClicked.connect(
            lambda item: self.connectToDevice(item.data(Qt.UserRole))
        )
        self.tab_bluetooth.layout.addWidget(self.listwidget)

        self.scanButton = QPushButton("Scan", self)
        self.scanButton.clicked.connect(self.scan)
        self.tab_bluetooth.layout.addWidget(self.scanButton)

        # Add a connection button
        self.connectButton = QPushButton("Connect", self)
        self.connectButton.setEnabled(
            False
        )  # Disable the button until a device is selected
        self.connectButton.clicked.connect(self.attemptConnect)
        self.tab_bluetooth.layout.addWidget(self.connectButton)

    def createPWMTab(self):
        # Add PWM related widgets to the tab layout
        label = QLabel("PWM Driving:")
        self.tab_pwm.layout.addWidget(label)

        # Add motor on/off buttons
        self.motorOnButton = QPushButton("Motor 1 On", self)
        self.motorOnButton.setEnabled(
            False
        )  # Disable the button until a device is selected
        self.motorOnButton.clicked.connect(self.motorOn)
        self.tab_pwm.layout.addWidget(self.motorOnButton)

        self.motorOffButton = QPushButton("Motor 1 Off", self)
        self.motorOffButton.setEnabled(
            False
        )  # Disable the button until a device is selected
        self.motorOffButton.clicked.connect(self.motorOff)
        self.tab_pwm.layout.addWidget(self.motorOffButton)

        # SLIDER FOR AMPLITUDE
        self.slider = QSlider(Qt.Horizontal)
        self.slider.setMinimum(0)
        self.slider.setMaximum(100)
        self.slider.setValue(50)
        self.slider.setEnabled(False)  # Disable the slider until a device is connected
        self.tab_pwm.layout.addWidget(self.slider)

        # slider label value
        self.value_label = QLabel(f"Amplitude: {self.slider.value()}")
        self.slider.sliderReleased.connect(self.on_slider_released)
        self.slider.valueChanged.connect(self.on_slider_value_changed)
        self.tab_pwm.layout.addWidget(self.value_label, alignment=Qt.AlignCenter)

        # SLIDER FOR FREQUENCY
        self.slider2 = QSlider(Qt.Horizontal)
        self.slider2.setMinimum(0)
        self.slider2.setMaximum(300)
        self.slider2.setValue(170)
        self.slider2.setEnabled(False)  # Disable the slider until a device is connected
        self.tab_pwm.layout.addWidget(self.slider2)

        # slider2 label value
        self.value_label2 = QLabel(f"Frequency: {self.slider2.value()}")
        self.slider2.sliderReleased.connect(self.on_slider2_released)
        self.slider2.valueChanged.connect(self.on_slider2_value_changed)
        self.tab_pwm.layout.addWidget(self.value_label2, alignment=Qt.AlignCenter)

    def createEffectsTab(self):
        # Add Effect related widgets to the tab layout
        label = QLabel("Effect Sequencing:")
        self.tab_effects.layout.addWidget(label)
        # make a list of the dropdown values for each dropdown
        self.dropdown_options = [
            "0 − NONE",
            "1 − Strong Click - 100%",
            "2 − Strong Click - 60%",
            "3 − Strong Click - 30%",
            "4 − Sharp Click - 100%",
            "5 − Sharp Click - 60%",
            "6 − Sharp Click - 30%",
            "7 − Soft Bump - 100%",
            "8 − Soft Bump - 60%",
            "9 − Soft Bump - 30%",
            "10 − Double Click - 100%",
            "11 − Double Click - 60%",
            "12 − Triple Click - 100%",
            "13 − Soft Fuzz - 60%",
            "14 − Strong Buzz - 100%",
            "15 − 750 ms Alert 100%",
            "16 − 1000 ms Alert 100%",
            "17 − Strong Click 1 - 100%",
            "18 − Strong Click 2 - 80%",
            "19 − Strong Click 3 - 60%",
            "20 − Strong Click 4 - 30%",
            "21 − Medium Click 1 - 100%",
            "22 − Medium Click 2 - 80%",
            "23 − Medium Click 3 - 60%",
            "24 − Sharp Tick 1 - 100%",
            "25 − Sharp Tick 2 - 80%",
            "26 − Sharp Tick 3 – 60%",
            "27 − Short Double Click Strong 1 – 100%",
            "28 − Short Double Click Strong 2 – 80%",
            "29 − Short Double Click Strong 3 – 60%",
            "30 − Short Double Click Strong 4 – 30%",
            "31 − Short Double Click Medium 1 – 100%",
            "32 − Short Double Click Medium 2 – 80%",
            "33 − Short Double Click Medium 3 – 60%",
            "34 − Short Double Sharp Tick 1 – 100%",
            "35 − Short Double Sharp Tick 2 – 80%",
            "36 − Short Double Sharp Tick 3 – 60%",
            "37 − Long Double Sharp Click Strong 1 – 100%",
            "38 − Long Double Sharp Click Strong 2 – 80%",
            "39 − Long Double Sharp Click Strong 3 – 60%",
            "40 − Long Double Sharp Click Strong 4 – 30%",
            "41 − Long Double Sharp Click Medium 1 – 100%",
            "42 − Long Double Sharp Click Medium 2 – 80%",
            "43 − Long Double Sharp Click Medium 3 – 60%",
            "44 − Long Double Sharp Tick 1 – 100%",
            "45 − Long Double Sharp Tick 2 – 80%",
            "46 − Long Double Sharp Tick 3 – 60%",
            "47 − Buzz 1 – 100%",
            "48 − Buzz 2 – 80%",
            "49 − Buzz 3 – 60%",
            "50 − Buzz 4 – 40%",
            "51 − Buzz 5 – 20%",
            "52 − Pulsing Strong 1 – 100%",
            "53 − Pulsing Strong 2 – 60%",
            "54 − Pulsing Medium 1 – 100%",
            "55 − Pulsing Medium 2 – 60%",
            "56 − Pulsing Sharp 1 – 100%",
            "57 − Pulsing Sharp 2 – 60%",
            "58 − Transition Click 1 – 100%",
            "59 − Transition Click 2 – 80%",
            "60 − Transition Click 3 – 60%",
            "61 − Transition Click 4 – 40%",
            "62 − Transition Click 5 – 20%",
            "63 − Transition Click 6 – 10%",
            "64 − Transition Hum 1 – 100%",
            "65 − Transition Hum 2 – 80%",
            "66 − Transition Hum 3 – 60%",
            "67 − Transition Hum 4 – 40%",
            "68 − Transition Hum 5 – 20%",
            "69 − Transition Hum 6 – 10%",
            "70 − Transition Ramp Down Long Smooth 1 – 100 to 0%",
            "71 − Transition Ramp Down Long Smooth 2 – 100 to 0%",
            "72 − Transition Ramp Down Medium Smooth 1 – 100 to 0%",
            "73 − Transition Ramp Down Medium Smooth 2 – 100 to 0%",
            "74 − Transition Ramp Down Short Smooth 1 – 100 to 0%",
            "75 − Transition Ramp Down Short Smooth 2 – 100 to 0%",
            "76 − Transition Ramp Down Long Sharp 1 – 100 to 0%",
            "77 − Transition Ramp Down Long Sharp 2 – 100 to 0%",
            "78 − Transition Ramp Down Medium Sharp 1 – 100 to 0%",
            "79 − Transition Ramp Down Medium Sharp 2 – 100 to 0%",
            "80 − Transition Ramp Down Short Sharp 1 – 100 to 0%",
            "81 − Transition Ramp Down Short Sharp 2 – 100 to 0%",
            "82 − Transition Ramp Up Long Smooth 1 – 0 to 100%",
            "83 − Transition Ramp Up Long Smooth 2 – 0 to 100%",
            "84 − Transition Ramp Up Medium Smooth 1 – 0 to 100%",
            "85 − Transition Ramp Up Medium Smooth 2 – 0 to 100%",
            "86 − Transition Ramp Up Short Smooth 1 – 0 to 100%",
            "87 − Transition Ramp Up Short Smooth 2 – 0 to 100%",
            "88 − Transition Ramp Up Long Sharp 1 – 0 to 100%",
            "89 − Transition Ramp Up Long Sharp 2 – 0 to 100%",
            "90 − Transition Ramp Up Medium Sharp 1 – 0 to 100%",
            "91 − Transition Ramp Up Medium Sharp 2 – 0 to 100%",
            "92 − Transition Ramp Up Short Sharp 1 – 0 to 100%",
            "93 − Transition Ramp Up Short Sharp 2 – 0 to 100%",
            "94 − Transition Ramp Down Long Smooth 1 – 50 to 0%",
            "95 − Transition Ramp Down Long Smooth 2 – 50 to 0%",
            "96 − Transition Ramp Down Medium Smooth 1 – 50 to 0%",
            "97 − Transition Ramp Down Medium Smooth 2 – 50 to 0%",
            "98 − Transition Ramp Down Short Smooth 1 – 50 to 0%",
            "99 − Transition Ramp Down Short Smooth 2 – 50 to 0%",
            "100 − Transition Ramp Down Long Sharp 1 – 50 to 0%",
            "101 − Transition Ramp Down Long Sharp 2 – 50 to 0%",
            "102 − Transition Ramp Down Medium Sharp 1 – 50 to 0%",
            "103 − Transition Ramp Down Medium Sharp 2 – 50 to 0%",
            "104 − Transition Ramp Down Short Sharp 1 – 50 to 0%",
            "105 − Transition Ramp Down Short Sharp 2 – 50 to 0%",
            "106 − Transition Ramp Up Long Smooth 1 – 0 to 50%",
            "107 − Transition Ramp Up Long Smooth 2 – 0 to 50%",
            "108 − Transition Ramp Up Medium Smooth 1 – 0 to 50%",
            "109 − Transition Ramp Up Medium Smooth 2 – 0 to 50%",
            "110 − Transition Ramp Up Short Smooth 1 – 0 to 50%",
            "111 − Transition Ramp Up Short Smooth 2 – 0 to 50%",
            "112 − Transition Ramp Up Long Sharp 1 – 0 to 50%",
            "113 − Transition Ramp Up Long Sharp 2 – 0 to 50%",
            "114 − Transition Ramp Up Medium Sharp 1 – 0 to 50%",
            "115 − Transition Ramp Up Medium Sharp 2 – 0 to 50%",
            "116 − Transition Ramp Up Short Sharp 1 – 0 to 50%",
            "117 − Transition Ramp Up Short Sharp 2 – 0 to 50%",
            "118 − Long buzz for programmatic stopping - 100%",
            "119 − Smooth Hum 1 (No kick or brake pulse) - 50%",
            "120 − Smooth Hum 2 (No kick or brake pulse) - 40%",
            "121 − Smooth Hum 3 (No kick or brake pulse) - 30%",
            "122 − Smooth Hum 4 (No kick or brake pulse) - 20%",
            "123 − Smooth Hum 5 (No kick or brake pulse) - 10%",
        ]

        self.comboboxes = []
        for _i in range(6):
            combobox = QComboBox()
            combobox.addItems(
                self.dropdown_options
            )  # Use the same options for each combobox
            self.comboboxes.append(combobox)
            self.tab_effects.layout.addWidget(combobox)

        # Send constructed command button
        self.sendConstructedCommandButton = QPushButton(
            "Send Constructed Command", self
        )
        self.sendConstructedCommandButton.clicked.connect(self.sendConstructedCommand)
        self.tab_effects.layout.addWidget(self.sendConstructedCommandButton)

    def sendConstructedCommand(self):
        # Extract the index + 1 of each selected option in the combo boxes
        selected_indices = [
            str(combobox.currentIndex()) for combobox in self.comboboxes
        ]
        # Format the command with the selected indices
        command = f"MOTOR 1 EFFECT ({','.join(selected_indices)})"
        print(f"Sending command: {command}")
        asyncio.run_coroutine_threadsafe(self.send_text(command + "\n"), async_loop)

    def sendSerialCommand(self):
        command = self.serialCommandInput.text()  # Grab the text from input
        if command:  # If there's something to send
            # Here you would add your code to send the command over serial
            print(f"Sending command: {command}")
            asyncio.run_coroutine_threadsafe(self.send_text(command + "\n"), async_loop)
            # Clear the input box after sending the command
            self.serialCommandInput.clear()

    def on_slider_released(self):
        print(f"Amplitude: {self.slider.value()}")
        self.setAmplitude()  # idx set to 0 for MOTOR 1

    def on_slider_value_changed(self):
        self.value_label.setText(f"Amplitude: {self.slider.value()}")

    def on_slider2_released(self):
        print(f"Frequency: {self.slider2.value()}")
        self.setFrequency()

    def on_slider2_value_changed(self):
        self.value_label2.setText(f"Frequency: {self.slider2.value()}\n")

    def setFrequency(self):
        cmd = f"MOTOR 1 FREQ {self.slider2.value()}\n"
        asyncio.run_coroutine_threadsafe(self.send_text(cmd), async_loop)

    def setAmplitude(self):
        cmd = f"MOTOR 1 AMP {self.slider.value()}\n"
        asyncio.run_coroutine_threadsafe(self.send_text(cmd), async_loop)

    def motorOn(self):
        cmd = "MOTOR 1 ON\n"
        asyncio.run_coroutine_threadsafe(self.send_text(cmd), async_loop)

    def motorOff(self):
        cmd = "MOTOR 1 OFF\n"
        asyncio.run_coroutine_threadsafe(self.send_text(cmd), async_loop)

    def are_uuids_equal(self, uuid_a, uuid_b):
        clean_a = "".join(e for e in uuid_a if e.isalnum()).lower()
        clean_b = "".join(e for e in uuid_b if e.isalnum()).lower()
        return clean_a == clean_b

    def match_nus_uuid(self, device: BLEDevice, adv: AdvertisementData):
        # This assumes that the device includes the UART service UUID in the
        # advertising data. This may need to be adjusted depending on the
        # actual advertising data supplied by the device.
        if UART_SERVICE_UUID.lower() in adv.service_uuids:
            return True

        return False

    def scan(self):
        self.listwidget.clear()
        self.scanButton.setEnabled(False)
        asyncio.run_coroutine_threadsafe(self.scan_async(), async_loop)

    async def scan_async(self, *args):
        await self.scanner.start()
        await asyncio.sleep(5.0)  # scan for x seconds
        await self.scanner.stop()
        self.signal_ble_scan_done.emit()

    def handle_disconnect(self, device):
        self.signal_ble_disconnected.emit()
        return

    def deviceDiscovered(self, device, advertisement_data):
        # Sometimes devices show up without a name - return if so
        if device.name == "" or device.name is None:
            return

        item_to_add = QListWidgetItem(f"{device.name} - {device.address}")
        item_to_add.setData(Qt.UserRole, device)

        # Check if the device is already in the list
        for i in range(self.listwidget.count()):
            name_s = self.listwidget.item(i).text()
            if name_s.find(device.address) != -1:
                # Device is already in the list, so return
                return

        # Device is not in the list, so add it
        self.listwidget.addItem(item_to_add)

    def attemptConnect(self):
        # if already connected, disconnect
        if self.ble_client and self.ble_client.is_connected:
            self.deviceDisconnecting()
            asyncio.run_coroutine_threadsafe(self.disconnectDevice(), async_loop)
            return

        # not connected, attempt connect
        item = self.listwidget.currentItem()
        if item:
            deviceInfo = item.data(Qt.UserRole)
            if not isinstance(deviceInfo, BLEDevice):
                print("Attempting connection to wrong object type")
                return
            self.deviceConnecting()
            asyncio.run_coroutine_threadsafe(
                self.connectToDevice(deviceInfo), async_loop
            )

    def handle_rx(self, characteristic: BleakGATTCharacteristic, data: bytearray):
        if not self.are_uuids_equal(characteristic.uuid, UART_TX_UUID):
            print("Wrong characteristic uuid for rx")
            return

        # Handle characteristic value changes, this is where you'll receive data
        try:
            # Convert QByteArray to bytes and then decode it to string
            voltage_str = bytes(data).decode("utf-8")

            # Split the string to extract the voltage part
            voltage_parts = voltage_str.split(": ")

            # Check if the string was split into two parts as expected
            if len(voltage_parts) == 2:
                voltage = voltage_parts[
                    1
                ].strip()  # Get the second part and remove leading/trailing spaces
                self.batteryLabel.setText(f"Battery Voltage: {voltage}")
            else:
                print("Invalid voltage data format.")
        except Exception as e:
            print(f"Error parsing voltage: {e}")

    # TIP: you can get this function and more from the ``more-itertools`` package.
    def sliced(self, data: bytes, n: int) -> Iterator[bytes]:
        """
        Slices *data* into chunks of size *n*. The last slice may be smaller than
        *n*.
        """
        return takewhile(len, (data[i : i + n] for i in count(0, n)))

    async def connectToDevice(self, deviceInfo):
        self.ble_client = BleakClient(deviceInfo, self.handle_disconnect)
        await self.ble_client.connect()
        if not self.ble_client.is_connected:
            print("Error connecting to " + self.ble_client.address)
            return

        # signal connection
        print("Connected to " + self.ble_client.address)
        self.signal_ble_connected.emit()

        # start notifications for RX from device (TX UUID)
        await self.ble_client.start_notify(UART_TX_UUID, self.handle_rx)

        # assign the service and write characteristic global vars
        self.nus = self.ble_client.services.get_service(UART_SERVICE_UUID)
        self.rx_char = self.nus.get_characteristic(UART_RX_UUID)

    async def disconnectDevice(self):
        await self.ble_client.disconnect()
        print("Device was disconnected")
        self.signal_ble_disconnected.emit()

    @Slot()
    def bleScanDone(self):
        self.scanButton.setEnabled(True)

    @Slot()
    def deviceConnected(self):
        self.motorOnButton.setEnabled(True)
        self.slider.setEnabled(True)
        self.slider2.setEnabled(True)
        self.motorOffButton.setEnabled(True)
        self.connectButton.setText("Disconnect")
        self.connectButton.setEnabled(True)
        self.connectionStatus.setText("Status: Connected")
        self.connectionStatus.setStyleSheet("color: green")

    def deviceConnecting(self):
        self.motorOnButton.setEnabled(False)
        self.slider.setEnabled(False)
        self.slider2.setEnabled(False)
        self.motorOffButton.setEnabled(False)
        self.connectButton.setEnabled(False)
        self.connectionStatus.setText("Status: Connecting...")
        self.connectionStatus.setStyleSheet("color: blue")

    @Slot()
    def deviceDisconnected(self):
        self.motorOnButton.setEnabled(False)
        self.slider.setEnabled(False)
        self.slider2.setEnabled(False)
        self.motorOffButton.setEnabled(False)
        self.connectButton.setText("Connect")
        self.connectButton.setEnabled(True)
        self.connectionStatus.setText("Status: Disconnected")
        self.connectionStatus.setStyleSheet("color: red")

    def deviceDisconnecting(self):
        self.motorOnButton.setEnabled(False)
        self.slider.setEnabled(False)
        self.slider2.setEnabled(False)
        self.motorOffButton.setEnabled(False)
        self.connectButton.setEnabled(False)
        self.connectionStatus.setText("Status: Disconnecting...")
        self.connectionStatus.setStyleSheet("color: orange")

    async def send_text(self, text):
        # if it exists and is connected, send it
        if self.ble_client and self.ble_client.is_connected:
            await self.ble_client.write_gatt_char(
                self.rx_char, text.encode(), response=False
            )


if __name__ == "__main__":
    # startup the Qt system
    app = QApplication(sys.argv)
    ex = App()
    sys.exit(app.exec())
