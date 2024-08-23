/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
    Multiply,
    Add,
    OutputDevice,
    ScalarParam,
    SineWave,
    SawtoothWave,
    TriangleWave,
    SquareWave,
    Sequence,
    SignalGraph,
    StackChannels,
    strContains,
    TrapezoidCurve,
} from "@xrpa/xred-signal-processing";

export function PulsePattern(): SignalGraph {
    // Construct the waveform by multiplying fundamental and LFO frequencies
    const fq = ScalarParam("Fq", 170);
    const sinAmp = ScalarParam("SinAmp", 1);
    const sawAmp = ScalarParam("SawAmp", 1);
    const triAmp = ScalarParam("TriAmp", 1);
    const squareAmp = ScalarParam("SquareAmp", 1);
    const sinWave = SineWave({ frequency: fq, amplitude: sinAmp });
    const sawWave = SawtoothWave({ frequency: fq, amplitude: sawAmp });
    const triWave = TriangleWave({ frequency: fq, amplitude: triAmp });
    const squareWave = SquareWave({ frequency: fq, amplitude: squareAmp });


    // Properties of the pattern
    const pulseDuration = ScalarParam("PulseDuration", .5);
    const pauseDuration = ScalarParam("PauseDuration", .25);

    // This is a dumb way to do this but it works for now
    const sinGain = Sequence({
        elements: [
            TrapezoidCurve({
                softCurve: true,
                lowValue: 0,
                highValue: sinAmp,
                highHoldTime: 60,
                rampUpTime: 0,
                rampDownTime: 0,
            }),
        ],
        loop: true
    });
    const sawGain = Sequence({
        elements: [
            TrapezoidCurve({
                softCurve: true,
                lowValue: 0,
                highValue: sawAmp,
                highHoldTime: 60,
                rampUpTime: 0,
                rampDownTime: 0,
            }),
        ],
        loop: true
    });
    const triGain = Sequence({
        elements: [
            TrapezoidCurve({
                softCurve: true,
                lowValue: 0,
                highValue: triAmp,
                highHoldTime: 60,
                rampUpTime: 0,
                rampDownTime: 0,
            }),
        ],
        loop: true
    });
    const squareGain = Sequence({
        elements: [
            TrapezoidCurve({
                softCurve: true,
                lowValue: 0,
                highValue: squareAmp,
                highHoldTime: 60,
                rampUpTime: 0,
                rampDownTime: 0,
            }),
        ],
        loop: true
    });

    //const waveform = Add(Multiply(sinWave, sinGain), Multiply(sawWave, sawGain), Multiply(triWave, triGain), Multiply(squareWave, squareGain));
    const sinWaveform = Multiply(sinWave, sinGain, 1);
    const sawWaveform = Multiply(sawWave, sawGain, 1);
    const triWaveform = Multiply(triWave, triGain, 1);
    const squareWaveform = Multiply(squareWave, squareGain, 1);
    const waveform = Multiply(squareWaveform, 1);//, triWaveform, squareWaveform);

    // todo divide by 4

    // This is the pattern that will be looped
    const patternAmp = Sequence({
    elements: [
          TrapezoidCurve({
              softCurve: true,
              lowValue: 0,
              highValue: 1,
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

  return new SignalGraph({

    // output to the BuzzDuino the buzzSignal multiplied by the gain curve
    outputs: [
      OutputDevice({
        deviceName: strContains("BuzzDuino"),
          source: StackChannels(
              Multiply(waveform, patternAmp),
              Multiply(waveform, patternAmp),
          ),
      }),
    ],
  });
}
