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
import { XredSpeakerIdentificationInterface, SpeakerIdentifier } from "@xrpa/xred-speaker-identification";

export const IdentifySpeaker = XrpaDataflowProgram("IdentifySpeaker", () => {
  const audioInput = InputFromSystemAudio({ frameRate: 16000, numChannels: 1 });

  const speakerIdentifier = XredSpeakerIdentificationInterface({
    audioSignal: audioInput.audioSignal.signal,
  });

});
