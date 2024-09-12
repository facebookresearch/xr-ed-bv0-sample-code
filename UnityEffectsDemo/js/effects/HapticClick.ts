/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  DoneWhen,
  Multiply,
  OutputToDevice,
  SineWave,
  StackChannels,
  strContains,
  TrapezoidCurve,
} from "@xrpa/xred-signal-processing";
import { ProgramInput, Scalar, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";

export const HapticClick = XrpaDataflowProgram("HapticClick", () => {
  const gainChannel0 = ProgramInput("GainChannel0", Scalar(1));
  const gainChannel1 = ProgramInput("GainChannel1", Scalar(0));

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

  // kill the graph when the pulse is done
  DoneWhen(amplitudeCurve.onDone());

  // output to the BuzzDuino the buzzSignal multiplied by the gain curve
  OutputToDevice({
    deviceName: strContains("BuzzDuino"),
    source: StackChannels(
      Multiply(sinePulse, gainChannel0),
      Multiply(sinePulse, gainChannel1),
    ),
  });
});
