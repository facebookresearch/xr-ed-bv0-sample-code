/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import path from "path";
import { XredSignalOutput } from "@xrpa/xred-signal-output";
import { XredSignalProcessing } from "@xrpa/xred-signal-processing";
import { UnityProject } from "@xrpa/xrpa-orchestrator";

import { UnityEffects } from "./effects";

UnityProject(path.join(__dirname, ".."), unity => {
  unity.addBindings(XredSignalOutput);
  unity.addBindings(XredSignalProcessing, { effects: UnityEffects });
}).catch((e) => {
  console.error(e);
  process.exit(1);
}).then(() => {
  process.exit(0);
});
