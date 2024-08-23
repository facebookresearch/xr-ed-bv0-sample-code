/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  Multiply,
  OutputDevice,
  ScalarParam,
  SignalGraph,
  SineWave,
  StackChannels,
  strContains,
  TrapezoidCurve,
} from "@xrpa/xred-signal-processing";

export function ContinuousWave(): SignalGraph {
    const gainChannel0 = ScalarParam("GainChannel0", 1);
    const gainChannel1 = ScalarParam("GainChannel1", 1);
    const fundamentalFq = ScalarParam("FundamentalFq", 170);
    const fundamentalAmp = ScalarParam("FundamentalAmp", 1);
    const lfoFq = ScalarParam("LFOFq", 5);
    const lfoAmp = ScalarParam("LFOAmp", 1);

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

  return new SignalGraph({
    // kill the graph when the pulse is done
      done: overallEnvelope.onDone(),

    // output to the BuzzDuino the buzzSignal multiplied by the gain curve
    outputs: [
      OutputDevice({
        deviceName: strContains("BuzzDuino"),
        source: StackChannels(
            Multiply(Multiply(fundamental, lfo), overallEnvelope),
            Multiply(Multiply(fundamental, lfo), overallEnvelope),
        ),
      }),
    ],
  });
}
