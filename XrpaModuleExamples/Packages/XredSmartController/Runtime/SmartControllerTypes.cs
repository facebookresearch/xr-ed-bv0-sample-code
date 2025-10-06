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

using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using Xrpa;

namespace SmartControllerDataStore {

public class SmartControllerDataStoreConfig {
  public static Xrpa.TransportConfig GenTransportConfig() {
    Xrpa.TransportConfig config = new();
    config.SchemaHash = new Xrpa.HashValue(0x4480c388d74b0802, 0xffe72f0db7b3cba2, 0x9d29c9f5dfff0151, 0xbe2b2e4700b4be6a);
    config.ChangelogByteCount = 92144;
    return config;
  }
}

public enum KnobControlMode : uint {
  Disabled = 0,
  Position = 1,
  Detent = 2,
}

public enum InputEventType : uint {
  Release = 0,
  Press = 1,
}

public class DSColorSRGBA {
  public static UnityEngine.Color32 ReadValue(Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    byte r = memAccessor.ReadByte(offset);
    byte g = memAccessor.ReadByte(offset);
    byte b = memAccessor.ReadByte(offset);
    byte a = memAccessor.ReadByte(offset);
    return new UnityEngine.Color32{r = r, g = g, b = b, a = a};
  }

  public static void WriteValue(UnityEngine.Color32 val, Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    memAccessor.WriteByte(val.r, offset);
    memAccessor.WriteByte(val.g, offset);
    memAccessor.WriteByte(val.b, offset);
    memAccessor.WriteByte(val.a, offset);
  }
}

public class DSColorSRGBA_24 {
  public static System.Collections.Generic.List<UnityEngine.Color32> ReadValue(Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    UnityEngine.Color32 value0 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value1 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value2 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value3 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value4 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value5 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value6 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value7 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value8 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value9 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value10 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value11 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value12 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value13 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value14 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value15 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value16 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value17 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value18 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value19 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value20 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value21 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value22 = DSColorSRGBA.ReadValue(memAccessor, offset);
    UnityEngine.Color32 value23 = DSColorSRGBA.ReadValue(memAccessor, offset);
    return new System.Collections.Generic.List<UnityEngine.Color32>{value0, value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16, value17, value18, value19, value20, value21, value22, value23};
  }

  public static void WriteValue(System.Collections.Generic.List<UnityEngine.Color32> val, Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    DSColorSRGBA.WriteValue(val[0], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[1], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[2], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[3], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[4], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[5], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[6], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[7], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[8], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[9], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[10], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[11], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[12], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[13], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[14], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[15], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[16], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[17], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[18], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[19], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[20], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[21], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[22], memAccessor, offset);
    DSColorSRGBA.WriteValue(val[23], memAccessor, offset);
  }
}

public class DSAngle {
  public static float ReadValue(Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    float value = memAccessor.ReadFloat(offset);
    return value * 180f / ((float)System.Math.PI);
  }

  public static void WriteValue(float val, Xrpa.MemoryAccessor memAccessor, Xrpa.MemoryOffset offset) {
    memAccessor.WriteFloat(val * ((float)System.Math.PI) / 180f, offset);
  }
}

} // namespace SmartControllerDataStore
