/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  Delay,
  Feedback,
  MultiplyAdd,
  OutputToDevice,
  SineWave,
  StackChannels,
  strContains,
  TrapezoidCurve,
} from "@xrpa/xred-signal-processing";
import { XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";

export const TestEffect2 = XrpaDataflowProgram("TestEffect2", () => {
  // create a trapezoid curve with a long low hold at the end
  const amplitudeCurve = TrapezoidCurve({
    softCurve: true,
    lowValue: 0,
    highValue: 1,
    rampUpTime: 0.25,
    rampDownTime: 0.25,
    finalHoldTime: 4,
  });

  // loop the amplitude curve
  amplitudeCurve.setStartEvent(amplitudeCurve.onDone(), true);

  // create a sine wave with the trapezoid curve as the amplitude, so it pulses
  const sinePulse = SineWave({ frequency: 170, amplitude: amplitudeCurve });

  // create a feedback-delay loop for echo
  const feedback = Feedback();
  const outputSignal = MultiplyAdd(feedback, 0.25, sinePulse);
  feedback.setSource(Delay(outputSignal, 500));

  OutputToDevice({
    deviceName: strContains("BuzzDuino"),
    source: StackChannels(outputSignal, sinePulse),
  });
});
