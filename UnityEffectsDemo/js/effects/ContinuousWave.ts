/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  DoneWhen,
  Multiply,
  OutputToDevice,
  SineWave,
  StackChannels,
  strContains,
  TrapezoidCurve,
} from "@xrpa/xred-signal-processing";
import { ProgramInput, Scalar, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";

export const ContinuousWave = XrpaDataflowProgram("ContinuousWave", () => {
  const gainChannel0 = ProgramInput("GainChannel0", Scalar(1));
  const gainChannel1 = ProgramInput("GainChannel1", Scalar(1));
  const fundamentalFq = ProgramInput("FundamentalFq", Scalar(170));
  const fundamentalAmp = ProgramInput("FundamentalAmp", Scalar(1));
  const lfoFq = ProgramInput("LFOFq", Scalar(5));
  const lfoAmp = ProgramInput("LFOAmp", Scalar(1));

  // create a sine wave with the trapezoid curve as the amplitude, so it pulses
  const fundamental = SineWave({ frequency: fundamentalFq, amplitude: fundamentalAmp });
  const lfo = SineWave({ frequency: lfoFq, amplitude: lfoAmp });

  const overallEnvelope = TrapezoidCurve({
    softCurve: true,
    lowValue: 0,
    highValue: fundamentalAmp,
    highHoldTime: 100,
    rampUpTime: 0.005,
    rampDownTime: 0.005,
  });

  // kill the graph when the pulse is done
  DoneWhen(overallEnvelope.onDone());

  // output to the BuzzDuino the buzzSignal multiplied by the gain curve
  OutputToDevice({
    deviceName: strContains("BuzzDuino"),
    source: StackChannels(
      Multiply(Multiply(fundamental, lfo), overallEnvelope),
      Multiply(Multiply(fundamental, lfo), overallEnvelope),
    ),
  });
});
