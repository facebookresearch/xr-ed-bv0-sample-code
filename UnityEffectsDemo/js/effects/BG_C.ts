/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  Multiply,
  SineWave,
  TriangleWave,
  StackChannels,
  strContains,
  OutputToDevice,
} from "@xrpa/xred-signal-processing";
import { ProgramInput, Scalar, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";

export const BG_C = XrpaDataflowProgram("BG_C", () => {

  const gain0 = ProgramInput("Gain0", Scalar(1));
  const gain1 = ProgramInput("Gain1", Scalar(1));
  const gain2 = ProgramInput("Gain2", Scalar(1));
  const gain3 = ProgramInput("Gain3", Scalar(1));
  const gain4 = ProgramInput("Gain4", Scalar(1));

  // Construct the waveform by multiplying fundamental and LFO frequencies
  const fundamental = TriangleWave({ frequency: 350, amplitude: .2 });
  const lfo = SineWave({ frequency: 2, amplitude: 1 });
  const waveform = Multiply(fundamental, lfo);

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
