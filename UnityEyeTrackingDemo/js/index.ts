/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import path from "path";
import { XredEyeTrackingInterface } from "@xrpa/xred-eye-tracking";
import { bindExternalProgram, UnityProject } from "@xrpa/xrpa-orchestrator";

UnityProject(path.join(__dirname, ".."), "EyeTrackingDemo", () => {
  bindExternalProgram(XredEyeTrackingInterface);
}).catch((e) => {
  console.error(e);
  process.exit(1);
}).then(() => {
  process.exit(0);
});
