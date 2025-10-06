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
using Xrpa;

namespace OpticalCharacterRecognitionDataStore {

public class OpticalCharacterRecognitionDataStoreConfig {
  public static Xrpa.TransportConfig GenTransportConfig() {
    Xrpa.TransportConfig config = new();
    config.SchemaHash = new Xrpa.HashValue(0xddc12e3e60abf442, 0xa6eb3a6d1cbfa21c, 0x7581888cd74823c5, 0xb39ff02010f6b0c6);
    config.ChangelogByteCount = 5316500;
    return config;
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

public class DSOcrImage {
  public static Xrpa.Image ReadValue(Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    int width = memAccessor.ReadInt(offset);
    int height = memAccessor.ReadInt(offset);
    uint format = memAccessor.ReadUint(offset);
    uint encoding = memAccessor.ReadUint(offset);
    uint orientation = memAccessor.ReadUint(offset);
    float gain = DSScalar.ReadValue(memAccessor, offset);
    ulong exposureDuration = memAccessor.ReadUlong(offset);
    ulong timestamp = memAccessor.ReadUlong(offset);
    float captureFrameRate = DSScalar.ReadValue(memAccessor, offset);
    byte[] data = memAccessor.ReadBytes(offset);
    return new Xrpa.Image{width = width, height = height, format = (Xrpa.ImageFormat)(uint)(format), encoding = (Xrpa.ImageEncoding)(uint)(encoding), orientation = (Xrpa.ImageOrientation)(uint)(orientation), gain = gain, exposureDuration = exposureDuration, timestamp = timestamp, captureFrameRate = captureFrameRate, data = data};
  }

  public static void WriteValue(Xrpa.Image val, Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    memAccessor.WriteInt(val.width, offset);
    memAccessor.WriteInt(val.height, offset);
    memAccessor.WriteUint((uint)(val.format), offset);
    memAccessor.WriteUint((uint)(val.encoding), offset);
    memAccessor.WriteUint((uint)(val.orientation), offset);
    DSScalar.WriteValue(val.gain, memAccessor, offset);
    memAccessor.WriteUlong(val.exposureDuration, offset);
    memAccessor.WriteUlong(val.timestamp, offset);
    DSScalar.WriteValue(val.captureFrameRate, memAccessor, offset);
    memAccessor.WriteBytes(val.data, offset);
  }

  public static int DynSizeOfValue(Xrpa.Image val) {
    return Xrpa.MemoryAccessor.DynSizeOfBytes(val.data);
  }
}

} // namespace OpticalCharacterRecognitionDataStore
