/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  Multiply,
  OutputToDevice,
  SineWave,
  StackChannels,
  strContains,
} from "@xrpa/xred-signal-processing";
import { ProgramInput, Scalar, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";

export const BG_A = XrpaDataflowProgram("BG_A", () => {

  const gain0 = ProgramInput("Gain0", Scalar(1));
  const gain1 = ProgramInput("Gain1", Scalar(1));
  const gain2 = ProgramInput("Gain2", Scalar(1));
  const gain3 = ProgramInput("Gain3", Scalar(1));
  const gain4 = ProgramInput("Gain4", Scalar(1));

  // Construct the waveform
  const fundamental = SineWave({ frequency: 30, amplitude: 1 });
  const waveform = fundamental;

  OutputToDevice({
    deviceName: strContains("HDK-1"),
    source: StackChannels(
      Multiply(waveform, gain0),
      Multiply(waveform, gain1),
      Multiply(waveform, gain2),
      Multiply(waveform, gain3),
      Multiply(waveform, gain4),
    ),
  });
});
