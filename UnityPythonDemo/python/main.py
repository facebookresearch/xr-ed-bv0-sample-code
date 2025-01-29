# Copyright (c) Meta Platforms, Inc. and affiliates.
#
# This source code is licensed under the MIT license found in the
# LICENSE file in the root directory of this source tree.

import random
import sys
import uuid

from PyQt5.QtWidgets import (
    QApplication,
    QHBoxLayout,
    QLabel,
    QLineEdit,
    QPushButton,
    QVBoxLayout,
    QWidget,
)
from xrpa.sensory_stimulus_data_store import OutboundStimulus

from xrpa.sensory_stimulus_types import Pose, Quaternion, Vector3
from xrpa.unity_python_demo_application_interface import (
    UnityPythonDemoApplicationInterface,
)
from xrpa_runtime.utils.xrpa_types import ObjectUuid


class MainWindow(QWidget):
    def __init__(self):
        super().__init__()

        self._interface = UnityPythonDemoApplicationInterface()

        self.initUI()

    def initUI(self):
        self.setGeometry(100, 100, 300, 150)
        self.setWindowTitle("Unity+Python Demo")

        layout = QVBoxLayout()
        self.setLayout(layout)

        audio_delay_layout = QHBoxLayout()
        audio_delay_label = QLabel("Audio Delay (s):")
        self.audio_delay_input = QLineEdit("0.0")
        audio_delay_layout.addWidget(audio_delay_label)
        audio_delay_layout.addWidget(self.audio_delay_input)
        layout.addLayout(audio_delay_layout)

        visual_delay_layout = QHBoxLayout()
        visual_delay_label = QLabel("Visual Delay (s):")
        self.visual_delay_input = QLineEdit("0.0")
        visual_delay_layout.addWidget(visual_delay_label)
        visual_delay_layout.addWidget(self.visual_delay_input)
        layout.addLayout(visual_delay_layout)

        run_button = QPushButton("Run")
        run_button.clicked.connect(self.run_stimulus)
        layout.addWidget(run_button)

    def closeEvent(self, event):
        self._interface.shutdown()
        event.accept()

    def run_stimulus(self):
        stimulus = None

        def handle_stimulus_response(timestamp: int):
            nonlocal stimulus
            self._interface.sensory_stimulus_data_store.Stimulus.remove_object(
                stimulus.get_xrpa_id()
            )
            print("Received stimulus response")

        def create_stimulus():
            nonlocal stimulus
            stimulus = OutboundStimulus(ObjectUuid.from_uuid(uuid.uuid4()))
            try:
                stimulus.set_audio_delay(float(self.audio_delay_input.text()))
                stimulus.set_visual_delay(float(self.visual_delay_input.text()))
            except ValueError:
                print("Invalid input. Please enter a valid number.")
                return

            # randomize position from -1 to 1
            position = Vector3(
                2 * (0.5 - random.random()),
                2 * (0.5 - random.random()),
                2 * (0.5 - random.random()),
            )
            stimulus.set_pose(Pose(position, Quaternion(0, 0, 0, 1)))
            stimulus.on_user_response(handle_stimulus_response)
            self._interface.sensory_stimulus_data_store.Stimulus.add_object(stimulus)

        self._interface.transact(create_stimulus)


def main():
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())


if __name__ == "__main__":
    main()
