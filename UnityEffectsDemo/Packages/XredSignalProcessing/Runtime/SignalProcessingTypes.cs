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
  public static readonly Xrpa.DSHashValue SIGNALPROCESSING_SCHEMA_HASH = new(0x6260af1c9cea55f6, 0x5d6831327eb2314e, 0x084388bd3e2ceb2d, 0xa25b7310ed4233cd);

  public static Xrpa.DatasetConfig GenDatasetConfig() {
    Xrpa.DatasetConfig config = new();
    config.SchemaHash = SIGNALPROCESSING_SCHEMA_HASH;
    config.MaxObjectCount = 3392;
    config.MemPoolSize = 221952;
    config.ChangelogPoolSize = 868352;
    config.MessagePoolSize = 10008576;
    return config;
  }
}

public class DSScalar {
  public const int ValueFieldOffset = 0;

  public static float ReadValue(Xrpa.MemoryAccessor memAccessor, int offset) {
    float value = memAccessor.ReadFloat(offset + ValueFieldOffset);
    return value;
  }

  public static void WriteValue(float val, Xrpa.MemoryAccessor memAccessor, int offset) {
    memAccessor.WriteFloat(val, offset + ValueFieldOffset);
  }
}

public class DSTriggerEventMessage {
  public const int PayloadFieldOffset = 0;
}

public class DSReceiveEventMessage {
  public const int PayloadFieldOffset = 0;
}

public class DSSignalEvent {
}

public enum ParameterMode : uint {
  Passthrough = 0,
  SrcIndex = 1,
  Constant = 2,
}

public class DSSignalEventCombiner {
  public const int SrcEvent0FieldOffset = 0;
  public const int SrcEvent1FieldOffset = 16;
  public const int SrcEvent2FieldOffset = 32;
  public const int SrcEvent3FieldOffset = 48;
  public const int SrcEvent4FieldOffset = 64;
  public const int SrcEvent5FieldOffset = 80;
  public const int ParameterModeFieldOffset = 96;
  public const int OnEventFieldOffset = 100;
  public const ulong SrcEvent0ChangedBit = 1UL;
  public const ulong SrcEvent1ChangedBit = 2UL;
  public const ulong SrcEvent2ChangedBit = 4UL;
  public const ulong SrcEvent3ChangedBit = 8UL;
  public const ulong SrcEvent4ChangedBit = 16UL;
  public const ulong SrcEvent5ChangedBit = 32UL;
  public const ulong ParameterModeChangedBit = 64UL;
  public const ulong OnEventChangedBit = 128UL;
}

public class DSSignalSource {
  public const int NumOutputsFieldOffset = 0;
  public const ulong NumOutputsChangedBit = 1UL;
}

public class DSSignalSourceFile {
  public const int NumOutputsFieldOffset = 0;
  public const int FilePathFieldOffset = 4;
  public const int AutoPlayFieldOffset = 264;
  public const ulong NumOutputsChangedBit = 1UL;
  public const ulong FilePathChangedBit = 2UL;
  public const ulong AutoPlayChangedBit = 4UL;
}

public enum WaveformType : uint {
  Sawtooth = 0,
  Square = 1,
  Triangle = 2,
  Sine = 3,
  WhiteNoise = 4,
}

public class DSSignalOscillator {
  public const int NumOutputsFieldOffset = 0;
  public const int NumChannelsFieldOffset = 4;
  public const int WaveformTypeFieldOffset = 8;
  public const int FrequencyFieldOffset = 12;
  public const int FrequencyNodeFieldOffset = 16;
  public const int PulseWidthFieldOffset = 32;
  public const int PulseWidthNodeFieldOffset = 36;
  public const ulong NumOutputsChangedBit = 1UL;
  public const ulong NumChannelsChangedBit = 2UL;
  public const ulong WaveformTypeChangedBit = 4UL;
  public const ulong FrequencyChangedBit = 8UL;
  public const ulong FrequencyNodeChangedBit = 16UL;
  public const ulong PulseWidthChangedBit = 32UL;
  public const ulong PulseWidthNodeChangedBit = 64UL;
}

public class DSSignalChannelRouter {
  public const int NumOutputsFieldOffset = 0;
  public const int NumChannelsFieldOffset = 4;
  public const int ChannelSelectFieldOffset = 8;
  public const int ChannelSelectNodeFieldOffset = 12;
  public const int SrcNodeFieldOffset = 28;
  public const ulong NumOutputsChangedBit = 1UL;
  public const ulong NumChannelsChangedBit = 2UL;
  public const ulong ChannelSelectChangedBit = 4UL;
  public const ulong ChannelSelectNodeChangedBit = 8UL;
  public const ulong SrcNodeChangedBit = 16UL;
}

public class DSSignalChannelSelect {
  public const int NumOutputsFieldOffset = 0;
  public const int NumChannelsFieldOffset = 4;
  public const int ChannelIdxFieldOffset = 8;
  public const int SrcNodeFieldOffset = 12;
  public const ulong NumOutputsChangedBit = 1UL;
  public const ulong NumChannelsChangedBit = 2UL;
  public const ulong ChannelIdxChangedBit = 4UL;
  public const ulong SrcNodeChangedBit = 8UL;
}

public class DSSignalChannelStack {
  public const int NumOutputsFieldOffset = 0;
  public const int NumChannelsFieldOffset = 4;
  public const int SrcNode0FieldOffset = 8;
  public const int SrcNode1FieldOffset = 24;
  public const int SrcNode2FieldOffset = 40;
  public const int SrcNode3FieldOffset = 56;
  public const ulong NumOutputsChangedBit = 1UL;
  public const ulong NumChannelsChangedBit = 2UL;
  public const ulong SrcNode0ChangedBit = 4UL;
  public const ulong SrcNode1ChangedBit = 8UL;
  public const ulong SrcNode2ChangedBit = 16UL;
  public const ulong SrcNode3ChangedBit = 32UL;
}

public class DSSignalCurve {
  public const int NumOutputsFieldOffset = 0;
  public const int SoftCurveFieldOffset = 4;
  public const int NumSegmentsFieldOffset = 8;
  public const int StartValueFieldOffset = 12;
  public const int SegmentLength0FieldOffset = 16;
  public const int SegmentEndValue0FieldOffset = 20;
  public const int SegmentLength1FieldOffset = 24;
  public const int SegmentEndValue1FieldOffset = 28;
  public const int SegmentLength2FieldOffset = 32;
  public const int SegmentEndValue2FieldOffset = 36;
  public const int SegmentLength3FieldOffset = 40;
  public const int SegmentEndValue3FieldOffset = 44;
  public const int SegmentLength4FieldOffset = 48;
  public const int SegmentEndValue4FieldOffset = 52;
  public const int SegmentLength5FieldOffset = 56;
  public const int SegmentEndValue5FieldOffset = 60;
  public const int StartEventFieldOffset = 64;
  public const int AutoStartFieldOffset = 80;
  public const int OnDoneEventFieldOffset = 84;
  public const int AutoLoopFieldOffset = 100;
  public const ulong NumOutputsChangedBit = 1UL;
  public const ulong SoftCurveChangedBit = 2UL;
  public const ulong NumSegmentsChangedBit = 4UL;
  public const ulong StartValueChangedBit = 8UL;
  public const ulong SegmentLength0ChangedBit = 16UL;
  public const ulong SegmentEndValue0ChangedBit = 32UL;
  public const ulong SegmentLength1ChangedBit = 64UL;
  public const ulong SegmentEndValue1ChangedBit = 128UL;
  public const ulong SegmentLength2ChangedBit = 256UL;
  public const ulong SegmentEndValue2ChangedBit = 512UL;
  public const ulong SegmentLength3ChangedBit = 1024UL;
  public const ulong SegmentEndValue3ChangedBit = 2048UL;
  public const ulong SegmentLength4ChangedBit = 4096UL;
  public const ulong SegmentEndValue4ChangedBit = 8192UL;
  public const ulong SegmentLength5ChangedBit = 16384UL;
  public const ulong SegmentEndValue5ChangedBit = 32768UL;
  public const ulong StartEventChangedBit = 65536UL;
  public const ulong AutoStartChangedBit = 131072UL;
  public const ulong OnDoneEventChangedBit = 262144UL;
  public const ulong AutoLoopChangedBit = 524288UL;
}

public class DSSignalDelay {
  public const int NumOutputsFieldOffset = 0;
  public const int NumChannelsFieldOffset = 4;
  public const int SrcNodeFieldOffset = 8;
  public const int DelayTimeMsFieldOffset = 24;
  public const ulong NumOutputsChangedBit = 1UL;
  public const ulong NumChannelsChangedBit = 2UL;
  public const ulong SrcNodeChangedBit = 4UL;
  public const ulong DelayTimeMsChangedBit = 8UL;
}

public class DSSignalFeedback {
  public const int NumOutputsFieldOffset = 0;
  public const int NumChannelsFieldOffset = 4;
  public const int SrcNodeFieldOffset = 8;
  public const ulong NumOutputsChangedBit = 1UL;
  public const ulong NumChannelsChangedBit = 2UL;
  public const ulong SrcNodeChangedBit = 4UL;
}

public enum MathOperation : uint {
  Add = 0,
  Multiply = 1,
  Subtract = 2,
}

public class DSSignalMathOp {
  public const int NumOutputsFieldOffset = 0;
  public const int NumChannelsFieldOffset = 4;
  public const int OperationFieldOffset = 8;
  public const int OperandAFieldOffset = 12;
  public const int OperandANodeFieldOffset = 16;
  public const int OperandBFieldOffset = 32;
  public const int OperandBNodeFieldOffset = 36;
  public const ulong NumOutputsChangedBit = 1UL;
  public const ulong NumChannelsChangedBit = 2UL;
  public const ulong OperationChangedBit = 4UL;
  public const ulong OperandAChangedBit = 8UL;
  public const ulong OperandANodeChangedBit = 16UL;
  public const ulong OperandBChangedBit = 32UL;
  public const ulong OperandBNodeChangedBit = 64UL;
}

public class DSSignalMultiplexer {
  public const int NumOutputsFieldOffset = 0;
  public const int NumChannelsFieldOffset = 4;
  public const int SrcNode0FieldOffset = 8;
  public const int SrcNode1FieldOffset = 24;
  public const int SrcNode2FieldOffset = 40;
  public const int SrcNode3FieldOffset = 56;
  public const int SrcNode4FieldOffset = 72;
  public const int SrcNode5FieldOffset = 88;
  public const int IncrementEventFieldOffset = 104;
  public const int StartEventFieldOffset = 120;
  public const int AutoStartFieldOffset = 136;
  public const int OnDoneEventFieldOffset = 140;
  public const ulong NumOutputsChangedBit = 1UL;
  public const ulong NumChannelsChangedBit = 2UL;
  public const ulong SrcNode0ChangedBit = 4UL;
  public const ulong SrcNode1ChangedBit = 8UL;
  public const ulong SrcNode2ChangedBit = 16UL;
  public const ulong SrcNode3ChangedBit = 32UL;
  public const ulong SrcNode4ChangedBit = 64UL;
  public const ulong SrcNode5ChangedBit = 128UL;
  public const ulong IncrementEventChangedBit = 256UL;
  public const ulong StartEventChangedBit = 512UL;
  public const ulong AutoStartChangedBit = 1024UL;
  public const ulong OnDoneEventChangedBit = 2048UL;
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

public class DSSignalParametricEqualizer {
  public const int NumOutputsFieldOffset = 0;
  public const int NumChannelsFieldOffset = 4;
  public const int SrcNodeFieldOffset = 8;
  public const int FilterType0FieldOffset = 24;
  public const int Frequency0FieldOffset = 28;
  public const int Quality0FieldOffset = 32;
  public const int Gain0FieldOffset = 36;
  public const int FilterType1FieldOffset = 40;
  public const int Frequency1FieldOffset = 44;
  public const int Quality1FieldOffset = 48;
  public const int Gain1FieldOffset = 52;
  public const int FilterType2FieldOffset = 56;
  public const int Frequency2FieldOffset = 60;
  public const int Quality2FieldOffset = 64;
  public const int Gain2FieldOffset = 68;
  public const int FilterType3FieldOffset = 72;
  public const int Frequency3FieldOffset = 76;
  public const int Quality3FieldOffset = 80;
  public const int Gain3FieldOffset = 84;
  public const int FilterType4FieldOffset = 88;
  public const int Frequency4FieldOffset = 92;
  public const int Quality4FieldOffset = 96;
  public const int Gain4FieldOffset = 100;
  public const int GainAdjustFieldOffset = 104;
  public const ulong NumOutputsChangedBit = 1UL;
  public const ulong NumChannelsChangedBit = 2UL;
  public const ulong SrcNodeChangedBit = 4UL;
  public const ulong FilterType0ChangedBit = 8UL;
  public const ulong Frequency0ChangedBit = 16UL;
  public const ulong Quality0ChangedBit = 32UL;
  public const ulong Gain0ChangedBit = 64UL;
  public const ulong FilterType1ChangedBit = 128UL;
  public const ulong Frequency1ChangedBit = 256UL;
  public const ulong Quality1ChangedBit = 512UL;
  public const ulong Gain1ChangedBit = 1024UL;
  public const ulong FilterType2ChangedBit = 2048UL;
  public const ulong Frequency2ChangedBit = 4096UL;
  public const ulong Quality2ChangedBit = 8192UL;
  public const ulong Gain2ChangedBit = 16384UL;
  public const ulong FilterType3ChangedBit = 32768UL;
  public const ulong Frequency3ChangedBit = 65536UL;
  public const ulong Quality3ChangedBit = 131072UL;
  public const ulong Gain3ChangedBit = 262144UL;
  public const ulong FilterType4ChangedBit = 524288UL;
  public const ulong Frequency4ChangedBit = 1048576UL;
  public const ulong Quality4ChangedBit = 2097152UL;
  public const ulong Gain4ChangedBit = 4194304UL;
  public const ulong GainAdjustChangedBit = 8388608UL;
}

public class DSSignalPitchShift {
  public const int NumOutputsFieldOffset = 0;
  public const int NumChannelsFieldOffset = 4;
  public const int SrcNodeFieldOffset = 8;
  public const int PitchShiftSemitonesFieldOffset = 24;
  public const ulong NumOutputsChangedBit = 1UL;
  public const ulong NumChannelsChangedBit = 2UL;
  public const ulong SrcNodeChangedBit = 4UL;
  public const ulong PitchShiftSemitonesChangedBit = 8UL;
}

public class DSSignalSoftClip {
  public const int NumOutputsFieldOffset = 0;
  public const int NumChannelsFieldOffset = 4;
  public const int SrcNodeFieldOffset = 8;
  public const ulong NumOutputsChangedBit = 1UL;
  public const ulong NumChannelsChangedBit = 2UL;
  public const ulong SrcNodeChangedBit = 4UL;
}

public enum SampleType : uint {
  Float = 0,
  SignedInt32 = 1,
  UnsignedInt32 = 2,
}

public class DSSignalOutputData {
  public const int SrcNodeFieldOffset = 0;
  public const int NumChannelsFieldOffset = 16;
  public const int SampleTypeFieldOffset = 20;
  public const int SamplesPerChannelPerSecFieldOffset = 24;
  public const ulong SrcNodeChangedBit = 1UL;
  public const ulong NumChannelsChangedBit = 2UL;
  public const ulong SampleTypeChangedBit = 4UL;
  public const ulong SamplesPerChannelPerSecChangedBit = 8UL;
}

public enum DeviceHandednessFilter : uint {
  Any = 0,
  None = 1,
  Left = 2,
  Right = 3,
}

public class DSSignalOutputDevice {
  public const int SrcNodeFieldOffset = 0;
  public const int ChannelOffsetFieldOffset = 16;
  public const int DeviceNameFilterFieldOffset = 20;
  public const int DeviceHandednessFilterFieldOffset = 152;
  public const int FoundMatchFieldOffset = 156;
  public const ulong SrcNodeChangedBit = 1UL;
  public const ulong ChannelOffsetChangedBit = 2UL;
  public const ulong DeviceNameFilterChangedBit = 4UL;
  public const ulong DeviceHandednessFilterChangedBit = 8UL;
  public const ulong FoundMatchChangedBit = 16UL;
}

} // namespace SignalProcessingDataStore
