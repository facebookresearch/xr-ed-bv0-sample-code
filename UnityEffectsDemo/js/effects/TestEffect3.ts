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
  OutputToDevice,
  strContains,
} from "@xrpa/xred-signal-processing";
import { XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";

// NOTE: this effect will not do anything at the moment, as the test.wav file is not included in the repo.
// I am leaving this here anyway, as it is a good example of how to use the AudioStream and filter nodes.

export const TestEffect3 = XrpaDataflowProgram("TestEffect3", () => {
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

  OutputToDevice({
    deviceName: strContains("Headphones"),
    source: outputSignal,
  });
});
