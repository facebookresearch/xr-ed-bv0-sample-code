/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

// @generated

using System.Runtime.InteropServices;
using UnityEngine;
using Xrpa;

namespace SensoryStimulusDataStore {

public class SensoryStimulusDataStoreConfig {
  public static Xrpa.TransportConfig GenTransportConfig() {
    Xrpa.TransportConfig config = new();
    config.SchemaHash = new Xrpa.HashValue(0xca3eb487614d2465, 0xb66cd98da96fe6ff, 0x9bb9f8e39e1365c7, 0xb2a7d062da38976d);
    config.ChangelogByteCount = 61952;
    return config;
  }
}

public class Pose {
  public UnityEngine.Vector3 position;
  public UnityEngine.Quaternion orientation;
}

public class DSVector3 {
  public static UnityEngine.Vector3 ReadValue(Xrpa.MemoryAccessor memAccessor, int offset) {
    float x = memAccessor.ReadFloat(offset + 0);
    float y = memAccessor.ReadFloat(offset + 4);
    float z = memAccessor.ReadFloat(offset + 8);
    return new UnityEngine.Vector3{x = x, y = y, z = z};
  }

  public static void WriteValue(UnityEngine.Vector3 val, Xrpa.MemoryAccessor memAccessor, int offset) {
    memAccessor.WriteFloat(val.x, offset + 0);
    memAccessor.WriteFloat(val.y, offset + 4);
    memAccessor.WriteFloat(val.z, offset + 8);
  }
}

public class DSQuaternion {
  public static UnityEngine.Quaternion ReadValue(Xrpa.MemoryAccessor memAccessor, int offset) {
    float x = memAccessor.ReadFloat(offset + 0);
    float y = memAccessor.ReadFloat(offset + 4);
    float z = memAccessor.ReadFloat(offset + 8);
    float w = memAccessor.ReadFloat(offset + 12);
    return new UnityEngine.Quaternion{x = x, y = y, z = z, w = w};
  }

  public static void WriteValue(UnityEngine.Quaternion val, Xrpa.MemoryAccessor memAccessor, int offset) {
    memAccessor.WriteFloat(val.x, offset + 0);
    memAccessor.WriteFloat(val.y, offset + 4);
    memAccessor.WriteFloat(val.z, offset + 8);
    memAccessor.WriteFloat(val.w, offset + 12);
  }
}

public class DSPose {
  public static Pose ReadValue(Xrpa.MemoryAccessor memAccessor, int offset) {
    UnityEngine.Vector3 position = DSVector3.ReadValue(memAccessor, offset + 0);
    UnityEngine.Quaternion orientation = DSQuaternion.ReadValue(memAccessor, offset + 12);
    return new Pose{position = position, orientation = orientation};
  }

  public static void WriteValue(Pose val, Xrpa.MemoryAccessor memAccessor, int offset) {
    DSVector3.WriteValue(val.position, memAccessor, offset + 0);
    DSQuaternion.WriteValue(val.orientation, memAccessor, offset + 12);
  }
}

public class DSScalar {
  public static float ReadValue(Xrpa.MemoryAccessor memAccessor, int offset) {
    float value = memAccessor.ReadFloat(offset + 0);
    return value;
  }

  public static void WriteValue(float val, Xrpa.MemoryAccessor memAccessor, int offset) {
    memAccessor.WriteFloat(val, offset + 0);
  }
}

} // namespace SensoryStimulusDataStore
