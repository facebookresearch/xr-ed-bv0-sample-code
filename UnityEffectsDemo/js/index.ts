/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import path from "path";
import { XredSignalOutputInterface } from "@xrpa/xred-signal-output";
import { UnityProject, bindExternalProgram } from "@xrpa/xrpa-orchestrator";

import { UnityEffects } from "./effects";

UnityProject(path.join(__dirname, ".."), "UnityEffectsDemo", () => {
  bindExternalProgram(XredSignalOutputInterface);

  for (const effect of UnityEffects) {
    bindExternalProgram(effect);
  }
}).catch((e) => {
  console.error(e);
  process.exit(1);
}).then(() => {
  process.exit(0);
});
