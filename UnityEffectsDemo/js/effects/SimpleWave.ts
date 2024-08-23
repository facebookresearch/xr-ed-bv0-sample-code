/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  OutputDevice,
  ScalarParam,
  SignalGraph,
  SineWave,
  strContains,
} from "@xrpa/xred-signal-processing";

export function SimpleWave(): SignalGraph {
    const fq = ScalarParam("Fq", 170);
    const amp = ScalarParam("Amp", 1);

  // create a sine wave with the trapezoid curve as the amplitude, so it pulses
    const wave = SineWave({ frequency: fq, amplitude: amp });

  return new SignalGraph({
    // output to the BuzzDuino the buzzSignal multiplied by the gain curve
    outputs: [
      OutputDevice({
        deviceName: strContains("HDK-1"),
        source: wave,
      }),
    ],
  });
}
