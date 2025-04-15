/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import path from "path";

import {
  bindExternalProgram,
  Collection,
  Image,
  Message,
  ObjectTransform,
  Output,
  OvrCoordinateSystem,
  ProgramInput,
  Quaternion,
  Scalar,
  setProgramInterface,
  Spawnable,
  Struct,
  UnityCoordinateSystem,
  useCoordinateSystem,
  Vector3,
  XrpaNativeUnityProgram,
  XrpaProgramInterface,
  XrpaPythonApplication,
} from "@xrpa/xrpa-orchestrator";

const rootdir = path.join(__dirname, "..");

const SensoryStimulusInterface = XrpaProgramInterface("MSI.SensoryStimulus", () => {
  useCoordinateSystem(UnityCoordinateSystem);

  const Pose = Struct("Pose", {
    position: Vector3,
    orientation: Quaternion,
  });

  ProgramInput("Stimulus", Spawnable(Collection({
    maxCount: 128,
    fields: {
      pose: ObjectTransform({
        position: "position",
        rotation: "orientation",
      }, Pose),

      visualDelay: Scalar,
      audioDelay: Scalar,

      // TODO - add audio and visual stimulus types

      UserResponse: Output(Message("UserResponse")),
    },
  })));

  ProgramInput("PsychoPyWindow", Spawnable(Collection({
    maxCount: 4,
    fields: {
      display: Message({
        image: Image({
          expectedWidth: 800,
          expectedHeight: 600,
          expectedBytesPerPixel: 3,
        }),
      }),
    },
  })));
});

const UnityPackage = XrpaNativeUnityProgram("SensoryStimulus", path.join(rootdir, "unity"), () => {
  setProgramInterface(SensoryStimulusInterface);
});

const PythonApplication = XrpaPythonApplication("UnityPythonDemo", path.join(rootdir, "python"), () => {
  useCoordinateSystem(OvrCoordinateSystem);
  bindExternalProgram(SensoryStimulusInterface);
});

async function main() {
  const filesToWrite = UnityPackage.doCodeGen();
  filesToWrite.merge(PythonApplication.doCodeGen());
  await filesToWrite.finalize(path.join(__dirname, ".", "manifest.gen.json"));
}

main().catch((e) => {
  console.error(e);
  process.exit(1);
}).then(() => {
  process.exit(0);
});
