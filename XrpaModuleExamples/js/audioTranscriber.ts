/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  ProgramInput,
  ProgramOutput,
  XrpaDataflowProgram,
} from "@xrpa/xrpa-orchestrator";

import { InputFromSystemAudio } from "@xrpa/xred-audio-input";
import { AudioTranscription } from "@xrpa/xred-audio-transcription";
import { InputFromSmartMicrophone, LightControl } from "@xrpa/xred-device-input";

const AUDIO_FROM_SMART_MICROPHONE = false;

export const TranscribeAudioFromMic = XrpaDataflowProgram("TranscribeAudioFromMic", () => {
  const audioInput = AUDIO_FROM_SMART_MICROPHONE ? InputFromSmartMicrophone({
    ipAddress: ProgramInput("ipAddress"),
  }) : InputFromSystemAudio({ frameRate: 16000, numChannels: 1 });

  const transcription = AudioTranscription({
    audioSignal: audioInput.audioSignal.signal,
  });

  ProgramOutput("transcriptionResult", transcription.transcriptionResult);
});