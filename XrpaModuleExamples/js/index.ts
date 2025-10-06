/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import path from "path";
import { UnityProject, bindExternalProgram } from "@xrpa/xrpa-orchestrator";
import { XredCameraInterface } from "@xrpa/xred-sensor-input";
import { XredOpticalCharacterRecognitionInterface } from "@xrpa/xred-optical-character-recognition";

import { LlmPrograms } from "./llm";
import { DspPrograms } from "./dsp";
import { MoodLighting } from "./lightController";
import { TranscribeAudioFromMic } from "./audioTranscriber";
import { SpeakText } from "./tts";
import { DetectEmotion } from "./visualEmotionDetection";
import { IdentifySpeaker } from "./speakerIdentifier";
import { GainWave } from "./hdk1";

UnityProject(path.join(__dirname, ".."), "UnityEffectsDemo", () => {
  bindExternalProgram(XredCameraInterface);
  bindExternalProgram(XredOpticalCharacterRecognitionInterface);
  bindExternalProgram(MoodLighting);
  bindExternalProgram(TranscribeAudioFromMic);
  bindExternalProgram(SpeakText);
  bindExternalProgram(DetectEmotion);
  bindExternalProgram(IdentifySpeaker);
  bindExternalProgram(GainWave);
  LlmPrograms.forEach(bindExternalProgram);
  DspPrograms.forEach(bindExternalProgram);
}).catch((e) => {
  console.error(e);
  process.exit(1);
}).then(() => {
  process.exit(0);
});
