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

namespace SignalOutputDataStore {

public class SignalOutputDataStoreConfig {
  public static readonly Xrpa.DSHashValue SIGNALOUTPUT_SCHEMA_HASH = new(0xdb2faf89c3126a67, 0x14a589ce2d71326b, 0x51aa5835b03fa40b, 0x869cfdb8675eb699);

  public static Xrpa.DatasetConfig GenDatasetConfig() {
    Xrpa.DatasetConfig config = new();
    config.SchemaHash = SIGNALOUTPUT_SCHEMA_HASH;
    config.MaxObjectCount = 192;
    config.MemPoolSize = 20992;
    config.ChangelogPoolSize = 49152;
    config.MessagePoolSize = 9979904;
    return config;
  }
}

public enum DeviceHandedness : uint {
  None = 0,
  Left = 1,
  Right = 2,
}

public enum SampleType : uint {
  Float = 0,
  SignedInt = 1,
  UnsignedInt = 2,
}

public enum SampleSemantics : uint {
  PCM = 0,
  Intensity = 1,
}

public enum InputEventType : uint {
  Release = 0,
  Press = 1,
}

public class DSInputEvent {
  public const int TypeFieldOffset = 0;
  public const int SourceFieldOffset = 4;
}

public class DSSignalOutputDevice {
  public const int NameFieldOffset = 0;
  public const int ChannelNameFieldOffset = 68;
  public const int DriverIdentifierFieldOffset = 136;
  public const int DriverPortFieldOffset = 204;
  public const int HandednessFieldOffset = 272;
  public const int NumChannelsFieldOffset = 276;
  public const int SampleTypeFieldOffset = 280;
  public const int SampleSemanticsFieldOffset = 284;
  public const int BytesPerSampleFieldOffset = 288;
  public const int SamplesPerChannelPerSecFieldOffset = 292;
  public const ulong NameChangedBit = 1UL;
  public const ulong ChannelNameChangedBit = 2UL;
  public const ulong DriverIdentifierChangedBit = 4UL;
  public const ulong DriverPortChangedBit = 8UL;
  public const ulong HandednessChangedBit = 16UL;
  public const ulong NumChannelsChangedBit = 32UL;
  public const ulong SampleTypeChangedBit = 64UL;
  public const ulong SampleSemanticsChangedBit = 128UL;
  public const ulong BytesPerSampleChangedBit = 256UL;
  public const ulong SamplesPerChannelPerSecChangedBit = 512UL;
}

public class DSSignalOutputSource {
  public const int DeviceFieldOffset = 0;
  public const ulong DeviceChangedBit = 1UL;
}

} // namespace SignalOutputDataStore
