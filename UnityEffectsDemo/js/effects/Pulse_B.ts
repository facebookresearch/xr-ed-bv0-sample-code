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
  TrapezoidCurve,
  Sequence,
  strContains,
} from "@xrpa/xred-signal-processing";

export function Pulse_B(): SignalGraph {

    const gain0 = ScalarParam("Gain0", 1);
    const gain1 = ScalarParam("Gain1", 1);
    const gain2 = ScalarParam("Gain2", 1);
    const gain3 = ScalarParam("Gain3", 1);
    const gain4 = ScalarParam("Gain4", 1);

    // Construct the waveform
    const fundamentalFq = ScalarParam("FundamentalFq", 250);
    const fundamentalAmp = ScalarParam("FundamentalAmp", 1);
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

  return new SignalGraph({
      done: patternAmp.onDone(),
      outputs: [
          OutputDevice({
              deviceName: strContains("HDK-1"),
              source: StackChannels(
                  Multiply(Multiply(waveform, gain0), patternAmp),
                  Multiply(Multiply(waveform, gain1), patternAmp),
                  Multiply(Multiply(waveform, gain2), patternAmp),
                  Multiply(Multiply(waveform, gain3), patternAmp),
                  Multiply(Multiply(waveform, gain4), patternAmp),
              ),
          }),
      ],
  });
}
