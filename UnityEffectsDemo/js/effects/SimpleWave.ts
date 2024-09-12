/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  OutputToDevice,
  SineWave,
  strContains,
} from "@xrpa/xred-signal-processing";
import { ProgramInput, Scalar, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";

export const SimpleWave = XrpaDataflowProgram("SimpleWave", () => {
  const fq = ProgramInput("Fq", Scalar(170));
  const amp = ProgramInput("Amp", Scalar(1));

  // create a sine wave with the trapezoid curve as the amplitude, so it pulses
  const wave = SineWave({ frequency: fq, amplitude: amp });

  OutputToDevice({
    deviceName: strContains("HDK-1"),
    source: wave,
  });
});
