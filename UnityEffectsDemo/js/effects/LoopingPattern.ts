/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  Multiply,
  SineWave,
  Sequence,
  StackChannels,
  strContains,
  TrapezoidCurve,
  OutputToDevice,
} from "@xrpa/xred-signal-processing";
import { ProgramInput, Scalar, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";

export const LoopingPattern = XrpaDataflowProgram("LoopingPattern", () => {
  // Overall gain on the 2 VTs
  const gain0 = ProgramInput("Gain0", Scalar(1));
  const gain1 = ProgramInput("Gain1", Scalar(1));

  // Construct the waveform by multiplying fundamental and LFO frequencies
  const fundamentalFq = ProgramInput("FundamentalFq", Scalar(170));
  const fundamentalAmp = ProgramInput("FundamentalAmp", Scalar(1));
  const lfoFq = ProgramInput("LFOFq", Scalar(5));
  const lfoAmp = ProgramInput("LFOAmp", Scalar(1));
  const fundamental = SineWave({ frequency: fundamentalFq, amplitude: fundamentalAmp });
  const lfo = SineWave({ frequency: lfoFq, amplitude: lfoAmp });
  const waveform = Multiply(fundamental, lfo);

  // Properties of the pattern
  const pulseDuration = ProgramInput("PulseDuration", Scalar(0.5));
  const pauseDuration = ProgramInput("PauseDuration", Scalar(0.25));

  // This is the pattern that will be looped
  const patternAmp = Sequence({
    elements: [
      TrapezoidCurve({
        softCurve: true,
        lowValue: 0,
        highValue: fundamentalAmp,
        highHoldTime: pulseDuration,
        rampUpTime: 0,
        rampDownTime: 0,
      }),
      TrapezoidCurve({
        softCurve: true,
        lowValue: 0,
        highValue: 0,
        highHoldTime: pauseDuration,
        rampUpTime: 0,
        rampDownTime: 0,
      }),
    ],
    loop: true
  });

  OutputToDevice({
    deviceName: strContains("BuzzDuino"),
    source: StackChannels(
      Multiply(Multiply(waveform, patternAmp), gain0),
      Multiply(Multiply(waveform, patternAmp), gain1),
    ),
  });
});
