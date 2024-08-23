/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import path from "path";

import {
  AudioStream,
  Delay,
  Feedback,
  HighPassFilter,
  LowPassFilter,
  MultiplyAdd,
  OutputDevice,
  SignalGraph,
  strContains,
} from "@xrpa/xred-signal-processing";

// NOTE: this effect will not do anything at the moment, as XredOutput does not support audio devices yet.
// Also the test.wav file is not included in the repo, so this will not work.
// I am leaving this here anyway, as it is a good example of how to use the AudioStream and filter nodes.

export function TestEffect3(): SignalGraph {
  // load the audio file
  const audioWaveform = AudioStream(
    path.resolve(__dirname, ".", "test.wav"),
    {
      numChannels: 2,
    },
  );

  // create a feedback loop, with a delay and a low pass filter for the echo and a high pass filter for the dry signal
  const feedback = Feedback();
  const outputSignal = MultiplyAdd(feedback, 0.25, HighPassFilter(audioWaveform, 1000));
  feedback.setSource(Delay(LowPassFilter(outputSignal, 500), 250));

  return new SignalGraph({
    // output the signal to the headphones (does not currently work with XredOutput)
    outputs: [
      OutputDevice({
        deviceName: strContains("Headphones"),
        source: outputSignal,
      }),
    ],
  });
}
