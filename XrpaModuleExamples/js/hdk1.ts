/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  SineWave,
  Multiply,
  StackChannels,
  strContains,
  OutputToDevice,
} from "@xrpa/xred-signal-processing";
import { ProgramInput, Scalar, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";

export const GainWave = XrpaDataflowProgram("GainWave", () => {
  const fq = ProgramInput("Fq", Scalar(170));
  const amp = ProgramInput("Amp", Scalar(1));

  const gain0 = ProgramInput("Gain0", Scalar(1));
  const gain1 = ProgramInput("Gain1", Scalar(1));
  const gain2 = ProgramInput("Gain2", Scalar(1));
  const gain3 = ProgramInput("Gain3", Scalar(1));
  const gain4 = ProgramInput("Gain4", Scalar(1));

  // create a sine wave with the trapezoid curve as the amplitude, so it pulses
  const wave = SineWave({ frequency: fq, amplitude: amp });

  OutputToDevice({
    deviceName: strContains("HDK-1"),
    source: StackChannels(
      Multiply(wave, gain0),
      Multiply(wave, gain1),
      Multiply(wave, gain2),
      Multiply(wave, gain3),
      Multiply(wave, gain4),
    ),
  });
});
