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

namespace SignalProcessingDataStore {

public class SignalProcessingDataStoreConfig {
  public static Xrpa.TransportConfig GenTransportConfig() {
    Xrpa.TransportConfig config = new();
    config.SchemaHash = new Xrpa.HashValue(0x02e109435c1e428d, 0x1d18f647535d29fe, 0x67efb3cde035009d, 0x0ba57b305e1640c2);
    config.ChangelogByteCount = 10615808;
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

public enum ParameterMode : uint {
  Passthrough = 0,
  SrcIndex = 1,
  Constant = 2,
}

public enum WaveformType : uint {
  Sawtooth = 0,
  Square = 1,
  Triangle = 2,
  Sine = 3,
  WhiteNoise = 4,
}

public enum MathOperation : uint {
  Add = 0,
  Multiply = 1,
  Subtract = 2,
}

public enum FilterType : uint {
  Bypass = 0,
  Peak = 1,
  LowShelf = 2,
  HighShelf = 3,
  LowPass = 4,
  HighPass = 5,
  BandPass = 6,
}

} // namespace SignalProcessingDataStore
