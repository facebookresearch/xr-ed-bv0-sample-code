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
    config.SchemaHash = new Xrpa.HashValue(0x5c95c9c23ce14d61, 0x452966073cfc52ca, 0x9c767f4025d0c625, 0xe977f1d7fb58761b);
    config.ChangelogByteCount = 17313504;
    return config;
  }
}

public class Pose {
  public UnityEngine.Vector3 position;
  public UnityEngine.Quaternion orientation;
}

public class Image {
  // Image width
  public int width;

  // Image height
  public int height;
  public ImageFormat format;
  public ImageEncoding encoding;
  public ImageOrientation orientation;

  // Image gain
  public float gain;

  // Image exposure duration, if available
  public ulong exposureDuration;

  // Capture timestamp, if available
  public ulong timestamp;

  // Image data
  public byte[] data;
}

public class DSVector3 {
  public static UnityEngine.Vector3 ReadValue(Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    float x = memAccessor.ReadFloat(offset);
    float y = memAccessor.ReadFloat(offset);
    float z = memAccessor.ReadFloat(offset);
    return new UnityEngine.Vector3{x = x, y = y, z = z};
  }

  public static void WriteValue(UnityEngine.Vector3 val, Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    memAccessor.WriteFloat(val.x, offset);
    memAccessor.WriteFloat(val.y, offset);
    memAccessor.WriteFloat(val.z, offset);
  }
}

public class DSQuaternion {
  public static UnityEngine.Quaternion ReadValue(Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    float x = memAccessor.ReadFloat(offset);
    float y = memAccessor.ReadFloat(offset);
    float z = memAccessor.ReadFloat(offset);
    float w = memAccessor.ReadFloat(offset);
    return new UnityEngine.Quaternion{x = x, y = y, z = z, w = w};
  }

  public static void WriteValue(UnityEngine.Quaternion val, Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    memAccessor.WriteFloat(val.x, offset);
    memAccessor.WriteFloat(val.y, offset);
    memAccessor.WriteFloat(val.z, offset);
    memAccessor.WriteFloat(val.w, offset);
  }
}

public class DSPose {
  public static Pose ReadValue(Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    UnityEngine.Vector3 position = DSVector3.ReadValue(memAccessor, offset);
    UnityEngine.Quaternion orientation = DSQuaternion.ReadValue(memAccessor, offset);
    return new Pose{position = position, orientation = orientation};
  }

  public static void WriteValue(Pose val, Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    DSVector3.WriteValue(val.position, memAccessor, offset);
    DSQuaternion.WriteValue(val.orientation, memAccessor, offset);
  }
}

public class DSScalar {
  public static float ReadValue(Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    float value = memAccessor.ReadFloat(offset);
    return value;
  }

  public static void WriteValue(float val, Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    memAccessor.WriteFloat(val, offset);
  }
}

public enum ImageFormat : uint {
  RGB8 = 0,
  BGR8 = 1,
  RGBA8 = 2,
  Y8 = 3,
}

public enum ImageEncoding : uint {
  Raw = 0,
  Jpeg = 1,
}

public enum ImageOrientation : uint {
  Oriented = 0,
  RotatedCW = 1,
  RotatedCCW = 2,
  Rotated180 = 3,
}

public class DSImage {
  public static Image ReadValue(Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    int width = memAccessor.ReadInt(offset);
    int height = memAccessor.ReadInt(offset);
    uint format = memAccessor.ReadUint(offset);
    uint encoding = memAccessor.ReadUint(offset);
    uint orientation = memAccessor.ReadUint(offset);
    float gain = DSScalar.ReadValue(memAccessor, offset);
    ulong exposureDuration = memAccessor.ReadUlong(offset);
    ulong timestamp = memAccessor.ReadUlong(offset);
    byte[] data = memAccessor.ReadBytes(offset);
    return new Image{width = width, height = height, format = (ImageFormat)(uint)(format), encoding = (ImageEncoding)(uint)(encoding), orientation = (ImageOrientation)(uint)(orientation), gain = gain, exposureDuration = exposureDuration, timestamp = timestamp, data = data};
  }

  public static void WriteValue(Image val, Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    memAccessor.WriteInt(val.width, offset);
    memAccessor.WriteInt(val.height, offset);
    memAccessor.WriteUint((uint)(val.format), offset);
    memAccessor.WriteUint((uint)(val.encoding), offset);
    memAccessor.WriteUint((uint)(val.orientation), offset);
    DSScalar.WriteValue(val.gain, memAccessor, offset);
    memAccessor.WriteUlong(val.exposureDuration, offset);
    memAccessor.WriteUlong(val.timestamp, offset);
    memAccessor.WriteBytes(val.data, offset);
  }

  public static int DynSizeOfValue(Image val) {
    return Xrpa.MemoryAccessor.DynSizeOfBytes(val.data);
  }
}

} // namespace SensoryStimulusDataStore
