/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  Multiply,
  SineWave,
  StackChannels,
  TrapezoidCurve,
  Sequence,
  strContains,
  DoneWhen,
  OutputToDevice,
} from "@xrpa/xred-signal-processing";
import { ProgramInput, Scalar, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";

export const Pulse_B = XrpaDataflowProgram("Pulse_B", () => {
  const gain0 = ProgramInput("Gain0", Scalar(1));
  const gain1 = ProgramInput("Gain1", Scalar(1));
  const gain2 = ProgramInput("Gain2", Scalar(1));
  const gain3 = ProgramInput("Gain3", Scalar(1));
  const gain4 = ProgramInput("Gain4", Scalar(1));

  // Construct the waveform
  const fundamentalFq = ProgramInput("FundamentalFq", Scalar(250));
  const fundamentalAmp = ProgramInput("FundamentalAmp", Scalar(1));
  const waveform = SineWave({ frequency: fundamentalFq, amplitude: fundamentalAmp });

  const patternAmp = Sequence({
    elements: [
      TrapezoidCurve({
        softCurve: true,
        lowValue: 0,
        highValue: .25,
        highHoldTime: .02,
        rampUpTime: 0,
        rampDownTime: 0,
      }),
      TrapezoidCurve({
        softCurve: true,
        lowValue: 0,
        highValue: 0,
        highHoldTime: .08,
        rampUpTime: 0,
        rampDownTime: 0,
      }),
      TrapezoidCurve({
        softCurve: true,
        lowValue: 0,
        highValue: 1,
        highHoldTime: .01,
        rampUpTime: 0,
        rampDownTime: .02,
      }),
    ],
    loop: false
  });

  DoneWhen(patternAmp.onDone());

  OutputToDevice({
    deviceName: strContains("HDK-1"),
    source: StackChannels(
      Multiply(Multiply(waveform, gain0), patternAmp),
      Multiply(Multiply(waveform, gain1), patternAmp),
      Multiply(Multiply(waveform, gain2), patternAmp),
      Multiply(Multiply(waveform, gain3), patternAmp),
      Multiply(Multiply(waveform, gain4), patternAmp),
    ),
  });
});
