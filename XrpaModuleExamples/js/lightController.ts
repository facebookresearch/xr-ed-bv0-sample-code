/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
  ProgramInput,
  String,
  XrpaDataflowProgram,
} from "@xrpa/xrpa-orchestrator";

import { LightControl } from "@xrpa/xred-device-input";

export const MoodLighting = XrpaDataflowProgram("MoodLighting", () => {
  const ipAddress = ProgramInput("ipAddress", String());
  LightControl({
    ipAddress,
    priority: 0,
    lightColors: ProgramInput("baseLightColors"),
  });
  LightControl({
    ipAddress,
    priority: 1,
    lightColors: ProgramInput("overlayLightColors"),
    rotationSpeed: ProgramInput("overlayRotationSpeed"),
  });
});
