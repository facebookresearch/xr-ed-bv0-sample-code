/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  Multiply,
  SquareWave,
  StackChannels,
  TrapezoidCurve,
  Sequence,
  strContains,
  OutputToDevice,
  DoneWhen,
} from "@xrpa/xred-signal-processing";
import { ProgramInput, Scalar, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";

export const Pulse_A = XrpaDataflowProgram("Pulse_A", () => {
  const gain0 = ProgramInput("Gain0", Scalar(1));
  const gain1 = ProgramInput("Gain1", Scalar(1));
  const gain2 = ProgramInput("Gain2", Scalar(1));
  const gain3 = ProgramInput("Gain3", Scalar(1));
  const gain4 = ProgramInput("Gain4", Scalar(1));

  // Construct the waveform
  const fundamentalFq = ProgramInput("FundamentalFq", Scalar(170));
  const fundamentalAmp = ProgramInput("FundamentalAmp", Scalar(1));
  const waveform = SquareWave({ frequency: fundamentalFq, amplitude: fundamentalAmp });

  const patternAmp = Sequence({
    elements: [
      TrapezoidCurve({
        softCurve: true,
        lowValue: 0,
        highValue: 1,
        highHoldTime: .01,
        rampUpTime: 0,
        rampDownTime: 0,
      }),
    ],
    loop: false
  });

  DoneWhen(patternAmp.onDone());

  OutputToDevice({
    deviceName: strContains("HDK-1"),
    source: StackChannels(
      Multiply(Multiply(waveform, gain0),patternAmp),
      Multiply(Multiply(waveform, gain1), patternAmp),
      Multiply(Multiply(waveform, gain2), patternAmp),
      Multiply(Multiply(waveform, gain3), patternAmp),
      Multiply(Multiply(waveform, gain4), patternAmp),
    ),
  });
});
