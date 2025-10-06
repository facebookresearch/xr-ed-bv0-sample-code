/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  SineWave,
  OutputToSystemAudio
} from "@xrpa/xred-signal-processing";
import { ProgramInput, Scalar, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";

export const BasicWave = XrpaDataflowProgram("BasicWave", () => {
  const fq = ProgramInput("Fq", Scalar(170));
  const amp = ProgramInput("Amp", Scalar(1));

  const wave = SineWave({ frequency: fq, amplitude: amp });

  OutputToSystemAudio({
    source: wave,
  });
});
