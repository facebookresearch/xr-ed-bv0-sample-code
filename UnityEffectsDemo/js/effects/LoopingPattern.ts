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
    SineWave,
    Sequence,
    SignalGraph,
    StackChannels,
    strContains,
    TrapezoidCurve,
} from "@xrpa/xred-signal-processing";

export function LoopingPattern(): SignalGraph {
    // Overall gain on the 2 VTs
    const gain0 = ScalarParam("Gain0", 1);
    const gain1 = ScalarParam("Gain1", 1);

    // Construct the waveform by multiplying fundamental and LFO frequencies
    const fundamentalFq = ScalarParam("FundamentalFq", 170);
    const fundamentalAmp = ScalarParam("FundamentalAmp", 1);
    const lfoFq = ScalarParam("LFOFq", 5);
    const lfoAmp = ScalarParam("LFOAmp", 1);
    const fundamental = SineWave({ frequency: fundamentalFq, amplitude: fundamentalAmp });
    const lfo = SineWave({ frequency: lfoFq, amplitude: lfoAmp });
    const waveform = Multiply(fundamental, lfo);

    // Properties of the pattern
    const pulseDuration = ScalarParam("PulseDuration", .5);
    const pauseDuration = ScalarParam("PauseDuration", .25);

    // this appears necessary at the moment because you have to declare
    // a 'done' function or Unity hangs on stop. You might think it would
    // stop the whole thing after 1s, but it does not -- I'm guessing this
    // is because the sequence itself loops and/or the fact that this
    // curve just isn't used anywhwere so it's never started
    const overallEnvelope = TrapezoidCurve({
        softCurve: true,
        lowValue: 0,
        highValue: 1,
        highHoldTime: 0,
        rampUpTime: 0,
        rampDownTime: 0,
    });

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

  return new SignalGraph({
    // kill the graph when the gain curve is done
      done: overallEnvelope.onDone(),

    // output to the BuzzDuino the buzzSignal multiplied by the gain curve
    outputs: [
      OutputDevice({
        deviceName: strContains("BuzzDuino"),
          source: StackChannels(
              Multiply(Multiply(waveform, patternAmp), gain0),
              Multiply(Multiply(waveform, patternAmp), gain1),
          ),
      }),
    ],
  });
}
