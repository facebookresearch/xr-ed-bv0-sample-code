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
} from "@xrpa/xred-signal-processing";

export function BG_A(): SignalGraph {

    const gain0 = ScalarParam("Gain0", 1);
    const gain1 = ScalarParam("Gain1", 1);
    const gain2 = ScalarParam("Gain2", 1);
    const gain3 = ScalarParam("Gain3", 1);
    const gain4 = ScalarParam("Gain4", 1);

    // Construct the waveform
    const fundamental = SineWave({ frequency: 30, amplitude: 1 });
    const waveform = fundamental;

  return new SignalGraph({
      outputs: [
          OutputDevice({
              deviceName: strContains("HDK-1"),
              source: StackChannels(
                  Multiply(waveform, gain0),
                  Multiply(waveform, gain1),
                  Multiply(waveform, gain2),
                  Multiply(waveform, gain3),
                  Multiply(waveform, gain4),
              ),
          }),
      ],
  });
}
