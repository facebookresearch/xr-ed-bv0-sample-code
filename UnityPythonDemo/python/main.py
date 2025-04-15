# Copyright (c) Meta Platforms, Inc. and affiliates.
#
# This source code is licensed under the MIT license found in the
# LICENSE file in the root directory of this source tree.

import random
import sys
import uuid

from psychopy import visual
from PyQt5.QtCore import QTimer
from PyQt5.QtWidgets import (
    QApplication,
    QHBoxLayout,
    QLabel,
    QLineEdit,
    QPushButton,
    QVBoxLayout,
    QWidget,
)
from xrpa.sensory_stimulus_data_store import OutboundPsychoPyWindow, OutboundStimulus

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
        self.initPsychoPy()

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
        self._timer.stop()
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

    def initPsychoPy(self):
        self._win = visual.Window(size=(800, 600), color=[-1, -1, -1])
        self._circle_stim = visual.Circle(
            self._win, radius=0.2, pos=[-0.5, 0], lineColor=[1, 0, 0], fillColor=None
        )
        self._rect_stim = visual.Rect(
            self._win,
            width=0.4,
            height=0.2,
            pos=[0.5, 0],
            lineColor=[0, 1, 0],
            fillColor=None,
        )

        self._outbound_window = OutboundPsychoPyWindow(
            ObjectUuid.from_uuid(uuid.uuid4())
        )
        self._interface.sensory_stimulus_data_store.PsychoPyWindow.add_object(
            self._outbound_window
        )
        self._outbound_window.set_display_source(self._win)

        self._showing_circle = True

        self._timer = QTimer(self)
        self._timer.timeout.connect(self.psychopy_flip)
        self._timer.start(100)

    def psychopy_flip(self):
        if self._showing_circle:
            self._circle_stim.draw()
        else:
            self._rect_stim.draw()
        self._win.flip()
        self._showing_circle = not self._showing_circle


def main():
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec_())


if __name__ == "__main__":
    main()
