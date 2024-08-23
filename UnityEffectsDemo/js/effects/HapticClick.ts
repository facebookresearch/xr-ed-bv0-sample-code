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

export function HapticClick(): SignalGraph {
  const gainChannel0 = ScalarParam("GainChannel0", 1);
  const gainChannel1 = ScalarParam("GainChannel1", 0);

  const amplitudeCurve = TrapezoidCurve({
    softCurve: true,
    lowValue: 0,
    highValue: 0.5,
    highHoldTime: 0.05,
    rampUpTime: 0.05,
    rampDownTime: 0.05,
  });

  // create a sine wave with the trapezoid curve as the amplitude, so it pulses
  const sinePulse = SineWave({frequency: 170, amplitude: amplitudeCurve});

  return new SignalGraph({
    // kill the graph when the pulse is done
    done: amplitudeCurve.onDone(),

    // output to the BuzzDuino the buzzSignal multiplied by the gain curve
    outputs: [
      OutputDevice({
        deviceName: strContains("BuzzDuino"),
        source: StackChannels(
          Multiply(sinePulse, gainChannel0),
          Multiply(sinePulse, gainChannel1),
        ),
      }),
    ],
  });
}
