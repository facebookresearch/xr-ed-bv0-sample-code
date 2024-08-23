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

using Xrpa;

namespace SignalProcessingDataStore {

public class TriggerEventMessage : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = -1;
  public const int DS_SIZE = 4;

  public TriggerEventMessage() {}

  public TriggerEventMessage(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public float GetPayload() {
    return DSScalar.ReadValue(_memAccessor, DSTriggerEventMessage.PayloadFieldOffset);
  }
}

public class TriggerEventMessageWrite : TriggerEventMessage {
  public TriggerEventMessageWrite() {}

  public TriggerEventMessageWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetPayload(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSTriggerEventMessage.PayloadFieldOffset);
  }
}

public class ReceiveEventMessage : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = -1;
  public const int DS_SIZE = 4;

  public ReceiveEventMessage() {}

  public ReceiveEventMessage(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public float GetPayload() {
    return DSScalar.ReadValue(_memAccessor, DSReceiveEventMessage.PayloadFieldOffset);
  }
}

public class ReceiveEventMessageWrite : ReceiveEventMessage {
  public ReceiveEventMessageWrite() {}

  public ReceiveEventMessageWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetPayload(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSReceiveEventMessage.PayloadFieldOffset);
  }
}

public class SignalEvent : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 0;
  public const int DS_SIZE = 0;

  public SignalEvent() {}

  public SignalEvent(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }
}

public class SignalEventWrite : SignalEvent {
  public SignalEventWrite() {}

  public SignalEventWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }
}

public class SignalEventCombiner : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 1;
  public const int DS_SIZE = 116;

  public SignalEventCombiner() {}

  public SignalEventCombiner(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public OutboundSignalEvent GetSrcEvent0(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalEventCombiner.SrcEvent0FieldOffset), out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcEvent0Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalEventCombiner.SrcEvent0FieldOffset);
  }

  public OutboundSignalEvent GetSrcEvent1(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalEventCombiner.SrcEvent1FieldOffset), out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcEvent1Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalEventCombiner.SrcEvent1FieldOffset);
  }

  public OutboundSignalEvent GetSrcEvent2(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalEventCombiner.SrcEvent2FieldOffset), out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcEvent2Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalEventCombiner.SrcEvent2FieldOffset);
  }

  public OutboundSignalEvent GetSrcEvent3(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalEventCombiner.SrcEvent3FieldOffset), out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcEvent3Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalEventCombiner.SrcEvent3FieldOffset);
  }

  public OutboundSignalEvent GetSrcEvent4(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalEventCombiner.SrcEvent4FieldOffset), out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcEvent4Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalEventCombiner.SrcEvent4FieldOffset);
  }

  public OutboundSignalEvent GetSrcEvent5(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalEventCombiner.SrcEvent5FieldOffset), out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcEvent5Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalEventCombiner.SrcEvent5FieldOffset);
  }

  public ParameterMode GetParameterMode() {
    return (ParameterMode)(uint)(_memAccessor.ReadUint(DSSignalEventCombiner.ParameterModeFieldOffset));
  }

  public OutboundSignalEvent GetOnEvent(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalEventCombiner.OnEventFieldOffset), out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetOnEventId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalEventCombiner.OnEventFieldOffset);
  }

  public bool CheckSrcEvent0Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalEventCombiner.SrcEvent0ChangedBit) != 0;
  }

  public bool CheckSrcEvent1Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalEventCombiner.SrcEvent1ChangedBit) != 0;
  }

  public bool CheckSrcEvent2Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalEventCombiner.SrcEvent2ChangedBit) != 0;
  }

  public bool CheckSrcEvent3Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalEventCombiner.SrcEvent3ChangedBit) != 0;
  }

  public bool CheckSrcEvent4Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalEventCombiner.SrcEvent4ChangedBit) != 0;
  }

  public bool CheckSrcEvent5Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalEventCombiner.SrcEvent5ChangedBit) != 0;
  }

  public bool CheckParameterModeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalEventCombiner.ParameterModeChangedBit) != 0;
  }

  public bool CheckOnEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalEventCombiner.OnEventChangedBit) != 0;
  }
}

public class SignalEventCombinerWrite : SignalEventCombiner {
  public SignalEventCombinerWrite() {}

  public SignalEventCombinerWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetSrcEvent0(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalEventCombiner.SrcEvent0FieldOffset);
  }

  public void SetSrcEvent1(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalEventCombiner.SrcEvent1FieldOffset);
  }

  public void SetSrcEvent2(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalEventCombiner.SrcEvent2FieldOffset);
  }

  public void SetSrcEvent3(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalEventCombiner.SrcEvent3FieldOffset);
  }

  public void SetSrcEvent4(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalEventCombiner.SrcEvent4FieldOffset);
  }

  public void SetSrcEvent5(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalEventCombiner.SrcEvent5FieldOffset);
  }

  public void SetParameterMode(ParameterMode value) {
    _memAccessor.WriteUint((uint)(value), DSSignalEventCombiner.ParameterModeFieldOffset);
  }

  public void SetOnEvent(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalEventCombiner.OnEventFieldOffset);
  }
}

public class SignalSource : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 2;
  public const int DS_SIZE = 4;

  public SignalSource() {}

  public SignalSource(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(DSSignalSource.NumOutputsFieldOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalSource.NumOutputsChangedBit) != 0;
  }
}

public class SignalSourceWrite : SignalSource {
  public SignalSourceWrite() {}

  public SignalSourceWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, DSSignalSource.NumOutputsFieldOffset);
  }
}

public class SignalSourceFile : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 3;
  public const int DS_SIZE = 268;

  public SignalSourceFile() {}

  public SignalSourceFile(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(DSSignalSourceFile.NumOutputsFieldOffset);
  }

  public string GetFilePath() {
    return _memAccessor.ReadString(DSSignalSourceFile.FilePathFieldOffset, 256);
  }

  public bool GetAutoPlay() {
    return (_memAccessor.ReadInt(DSSignalSourceFile.AutoPlayFieldOffset) == 1 ? true : false);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalSourceFile.NumOutputsChangedBit) != 0;
  }

  public bool CheckFilePathChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalSourceFile.FilePathChangedBit) != 0;
  }

  public bool CheckAutoPlayChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalSourceFile.AutoPlayChangedBit) != 0;
  }
}

public class SignalSourceFileWrite : SignalSourceFile {
  public SignalSourceFileWrite() {}

  public SignalSourceFileWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, DSSignalSourceFile.NumOutputsFieldOffset);
  }

  public void SetFilePath(string value) {
    _memAccessor.WriteString(value, DSSignalSourceFile.FilePathFieldOffset, 256);
  }

  public void SetAutoPlay(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), DSSignalSourceFile.AutoPlayFieldOffset);
  }
}

public class SignalOscillator : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 4;
  public const int DS_SIZE = 52;

  public SignalOscillator() {}

  public SignalOscillator(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(DSSignalOscillator.NumOutputsFieldOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(DSSignalOscillator.NumChannelsFieldOffset);
  }

  public WaveformType GetWaveformType() {
    return (WaveformType)(uint)(_memAccessor.ReadUint(DSSignalOscillator.WaveformTypeFieldOffset));
  }

  public float GetFrequency() {
    return DSScalar.ReadValue(_memAccessor, DSSignalOscillator.FrequencyFieldOffset);
  }

  public ISignalNode GetFrequencyNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetFrequencyNodeId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset);
  }

  public float GetPulseWidth() {
    return DSScalar.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthFieldOffset);
  }

  public ISignalNode GetPulseWidthNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetPulseWidthNodeId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOscillator.NumOutputsChangedBit) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOscillator.NumChannelsChangedBit) != 0;
  }

  public bool CheckWaveformTypeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOscillator.WaveformTypeChangedBit) != 0;
  }

  public bool CheckFrequencyChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOscillator.FrequencyChangedBit) != 0;
  }

  public bool CheckFrequencyNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOscillator.FrequencyNodeChangedBit) != 0;
  }

  public bool CheckPulseWidthChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOscillator.PulseWidthChangedBit) != 0;
  }

  public bool CheckPulseWidthNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOscillator.PulseWidthNodeChangedBit) != 0;
  }
}

public class SignalOscillatorWrite : SignalOscillator {
  public SignalOscillatorWrite() {}

  public SignalOscillatorWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, DSSignalOscillator.NumOutputsFieldOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, DSSignalOscillator.NumChannelsFieldOffset);
  }

  public void SetWaveformType(WaveformType value) {
    _memAccessor.WriteUint((uint)(value), DSSignalOscillator.WaveformTypeFieldOffset);
  }

  public void SetFrequency(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalOscillator.FrequencyFieldOffset);
  }

  public void SetFrequencyNode(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalOscillator.FrequencyNodeFieldOffset);
  }

  public void SetPulseWidth(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalOscillator.PulseWidthFieldOffset);
  }

  public void SetPulseWidthNode(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalOscillator.PulseWidthNodeFieldOffset);
  }
}

public class SignalChannelRouter : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 5;
  public const int DS_SIZE = 44;

  public SignalChannelRouter() {}

  public SignalChannelRouter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(DSSignalChannelRouter.NumOutputsFieldOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(DSSignalChannelRouter.NumChannelsFieldOffset);
  }

  public float GetChannelSelect() {
    return DSScalar.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectFieldOffset);
  }

  public ISignalNode GetChannelSelectNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetChannelSelectNodeId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset);
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelRouter.NumOutputsChangedBit) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelRouter.NumChannelsChangedBit) != 0;
  }

  public bool CheckChannelSelectChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelRouter.ChannelSelectChangedBit) != 0;
  }

  public bool CheckChannelSelectNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelRouter.ChannelSelectNodeChangedBit) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelRouter.SrcNodeChangedBit) != 0;
  }
}

public class SignalChannelRouterWrite : SignalChannelRouter {
  public SignalChannelRouterWrite() {}

  public SignalChannelRouterWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, DSSignalChannelRouter.NumOutputsFieldOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, DSSignalChannelRouter.NumChannelsFieldOffset);
  }

  public void SetChannelSelect(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalChannelRouter.ChannelSelectFieldOffset);
  }

  public void SetChannelSelectNode(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalChannelRouter.ChannelSelectNodeFieldOffset);
  }

  public void SetSrcNode(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalChannelRouter.SrcNodeFieldOffset);
  }
}

public class SignalChannelSelect : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 6;
  public const int DS_SIZE = 28;

  public SignalChannelSelect() {}

  public SignalChannelSelect(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(DSSignalChannelSelect.NumOutputsFieldOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(DSSignalChannelSelect.NumChannelsFieldOffset);
  }

  public int GetChannelIdx() {
    return _memAccessor.ReadInt(DSSignalChannelSelect.ChannelIdxFieldOffset);
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelSelect.NumOutputsChangedBit) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelSelect.NumChannelsChangedBit) != 0;
  }

  public bool CheckChannelIdxChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelSelect.ChannelIdxChangedBit) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelSelect.SrcNodeChangedBit) != 0;
  }
}

public class SignalChannelSelectWrite : SignalChannelSelect {
  public SignalChannelSelectWrite() {}

  public SignalChannelSelectWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, DSSignalChannelSelect.NumOutputsFieldOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, DSSignalChannelSelect.NumChannelsFieldOffset);
  }

  public void SetChannelIdx(int value) {
    _memAccessor.WriteInt(value, DSSignalChannelSelect.ChannelIdxFieldOffset);
  }

  public void SetSrcNode(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalChannelSelect.SrcNodeFieldOffset);
  }
}

public class SignalChannelStack : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 7;
  public const int DS_SIZE = 72;

  public SignalChannelStack() {}

  public SignalChannelStack(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(DSSignalChannelStack.NumOutputsFieldOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(DSSignalChannelStack.NumChannelsFieldOffset);
  }

  public ISignalNode GetSrcNode0(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode0Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode0FieldOffset);
  }

  public ISignalNode GetSrcNode1(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode1Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode1FieldOffset);
  }

  public ISignalNode GetSrcNode2(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode2Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode2FieldOffset);
  }

  public ISignalNode GetSrcNode3(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode3Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalChannelStack.SrcNode3FieldOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelStack.NumOutputsChangedBit) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelStack.NumChannelsChangedBit) != 0;
  }

  public bool CheckSrcNode0Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelStack.SrcNode0ChangedBit) != 0;
  }

  public bool CheckSrcNode1Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelStack.SrcNode1ChangedBit) != 0;
  }

  public bool CheckSrcNode2Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelStack.SrcNode2ChangedBit) != 0;
  }

  public bool CheckSrcNode3Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalChannelStack.SrcNode3ChangedBit) != 0;
  }
}

public class SignalChannelStackWrite : SignalChannelStack {
  public SignalChannelStackWrite() {}

  public SignalChannelStackWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, DSSignalChannelStack.NumOutputsFieldOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, DSSignalChannelStack.NumChannelsFieldOffset);
  }

  public void SetSrcNode0(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalChannelStack.SrcNode0FieldOffset);
  }

  public void SetSrcNode1(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalChannelStack.SrcNode1FieldOffset);
  }

  public void SetSrcNode2(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalChannelStack.SrcNode2FieldOffset);
  }

  public void SetSrcNode3(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalChannelStack.SrcNode3FieldOffset);
  }
}

public class SignalCurve : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 8;
  public const int DS_SIZE = 104;

  public SignalCurve() {}

  public SignalCurve(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(DSSignalCurve.NumOutputsFieldOffset);
  }

  public bool GetSoftCurve() {
    return (_memAccessor.ReadInt(DSSignalCurve.SoftCurveFieldOffset) == 1 ? true : false);
  }

  public int GetNumSegments() {
    return _memAccessor.ReadInt(DSSignalCurve.NumSegmentsFieldOffset);
  }

  public float GetStartValue() {
    return DSScalar.ReadValue(_memAccessor, DSSignalCurve.StartValueFieldOffset);
  }

  public float GetSegmentLength0() {
    return DSScalar.ReadValue(_memAccessor, DSSignalCurve.SegmentLength0FieldOffset);
  }

  public float GetSegmentEndValue0() {
    return DSScalar.ReadValue(_memAccessor, DSSignalCurve.SegmentEndValue0FieldOffset);
  }

  public float GetSegmentLength1() {
    return DSScalar.ReadValue(_memAccessor, DSSignalCurve.SegmentLength1FieldOffset);
  }

  public float GetSegmentEndValue1() {
    return DSScalar.ReadValue(_memAccessor, DSSignalCurve.SegmentEndValue1FieldOffset);
  }

  public float GetSegmentLength2() {
    return DSScalar.ReadValue(_memAccessor, DSSignalCurve.SegmentLength2FieldOffset);
  }

  public float GetSegmentEndValue2() {
    return DSScalar.ReadValue(_memAccessor, DSSignalCurve.SegmentEndValue2FieldOffset);
  }

  public float GetSegmentLength3() {
    return DSScalar.ReadValue(_memAccessor, DSSignalCurve.SegmentLength3FieldOffset);
  }

  public float GetSegmentEndValue3() {
    return DSScalar.ReadValue(_memAccessor, DSSignalCurve.SegmentEndValue3FieldOffset);
  }

  public float GetSegmentLength4() {
    return DSScalar.ReadValue(_memAccessor, DSSignalCurve.SegmentLength4FieldOffset);
  }

  public float GetSegmentEndValue4() {
    return DSScalar.ReadValue(_memAccessor, DSSignalCurve.SegmentEndValue4FieldOffset);
  }

  public float GetSegmentLength5() {
    return DSScalar.ReadValue(_memAccessor, DSSignalCurve.SegmentLength5FieldOffset);
  }

  public float GetSegmentEndValue5() {
    return DSScalar.ReadValue(_memAccessor, DSSignalCurve.SegmentEndValue5FieldOffset);
  }

  public OutboundSignalEvent GetStartEvent(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalCurve.StartEventFieldOffset), out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetStartEventId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalCurve.StartEventFieldOffset);
  }

  public bool GetAutoStart() {
    return (_memAccessor.ReadInt(DSSignalCurve.AutoStartFieldOffset) == 1 ? true : false);
  }

  public OutboundSignalEvent GetOnDoneEvent(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalCurve.OnDoneEventFieldOffset), out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetOnDoneEventId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalCurve.OnDoneEventFieldOffset);
  }

  public bool GetAutoLoop() {
    return (_memAccessor.ReadInt(DSSignalCurve.AutoLoopFieldOffset) == 1 ? true : false);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.NumOutputsChangedBit) != 0;
  }

  public bool CheckSoftCurveChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.SoftCurveChangedBit) != 0;
  }

  public bool CheckNumSegmentsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.NumSegmentsChangedBit) != 0;
  }

  public bool CheckStartValueChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.StartValueChangedBit) != 0;
  }

  public bool CheckSegmentLength0Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.SegmentLength0ChangedBit) != 0;
  }

  public bool CheckSegmentEndValue0Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.SegmentEndValue0ChangedBit) != 0;
  }

  public bool CheckSegmentLength1Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.SegmentLength1ChangedBit) != 0;
  }

  public bool CheckSegmentEndValue1Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.SegmentEndValue1ChangedBit) != 0;
  }

  public bool CheckSegmentLength2Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.SegmentLength2ChangedBit) != 0;
  }

  public bool CheckSegmentEndValue2Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.SegmentEndValue2ChangedBit) != 0;
  }

  public bool CheckSegmentLength3Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.SegmentLength3ChangedBit) != 0;
  }

  public bool CheckSegmentEndValue3Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.SegmentEndValue3ChangedBit) != 0;
  }

  public bool CheckSegmentLength4Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.SegmentLength4ChangedBit) != 0;
  }

  public bool CheckSegmentEndValue4Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.SegmentEndValue4ChangedBit) != 0;
  }

  public bool CheckSegmentLength5Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.SegmentLength5ChangedBit) != 0;
  }

  public bool CheckSegmentEndValue5Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.SegmentEndValue5ChangedBit) != 0;
  }

  public bool CheckStartEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.StartEventChangedBit) != 0;
  }

  public bool CheckAutoStartChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.AutoStartChangedBit) != 0;
  }

  public bool CheckOnDoneEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.OnDoneEventChangedBit) != 0;
  }

  public bool CheckAutoLoopChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalCurve.AutoLoopChangedBit) != 0;
  }
}

public class SignalCurveWrite : SignalCurve {
  public SignalCurveWrite() {}

  public SignalCurveWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, DSSignalCurve.NumOutputsFieldOffset);
  }

  public void SetSoftCurve(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), DSSignalCurve.SoftCurveFieldOffset);
  }

  public void SetNumSegments(int value) {
    _memAccessor.WriteInt(value, DSSignalCurve.NumSegmentsFieldOffset);
  }

  public void SetStartValue(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalCurve.StartValueFieldOffset);
  }

  public void SetSegmentLength0(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalCurve.SegmentLength0FieldOffset);
  }

  public void SetSegmentEndValue0(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalCurve.SegmentEndValue0FieldOffset);
  }

  public void SetSegmentLength1(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalCurve.SegmentLength1FieldOffset);
  }

  public void SetSegmentEndValue1(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalCurve.SegmentEndValue1FieldOffset);
  }

  public void SetSegmentLength2(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalCurve.SegmentLength2FieldOffset);
  }

  public void SetSegmentEndValue2(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalCurve.SegmentEndValue2FieldOffset);
  }

  public void SetSegmentLength3(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalCurve.SegmentLength3FieldOffset);
  }

  public void SetSegmentEndValue3(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalCurve.SegmentEndValue3FieldOffset);
  }

  public void SetSegmentLength4(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalCurve.SegmentLength4FieldOffset);
  }

  public void SetSegmentEndValue4(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalCurve.SegmentEndValue4FieldOffset);
  }

  public void SetSegmentLength5(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalCurve.SegmentLength5FieldOffset);
  }

  public void SetSegmentEndValue5(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalCurve.SegmentEndValue5FieldOffset);
  }

  public void SetStartEvent(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalCurve.StartEventFieldOffset);
  }

  public void SetAutoStart(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), DSSignalCurve.AutoStartFieldOffset);
  }

  public void SetOnDoneEvent(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalCurve.OnDoneEventFieldOffset);
  }

  public void SetAutoLoop(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), DSSignalCurve.AutoLoopFieldOffset);
  }
}

public class SignalDelay : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 9;
  public const int DS_SIZE = 28;

  public SignalDelay() {}

  public SignalDelay(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(DSSignalDelay.NumOutputsFieldOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(DSSignalDelay.NumChannelsFieldOffset);
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalDelay.SrcNodeFieldOffset);
  }

  public float GetDelayTimeMs() {
    return DSScalar.ReadValue(_memAccessor, DSSignalDelay.DelayTimeMsFieldOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalDelay.NumOutputsChangedBit) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalDelay.NumChannelsChangedBit) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalDelay.SrcNodeChangedBit) != 0;
  }

  public bool CheckDelayTimeMsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalDelay.DelayTimeMsChangedBit) != 0;
  }
}

public class SignalDelayWrite : SignalDelay {
  public SignalDelayWrite() {}

  public SignalDelayWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, DSSignalDelay.NumOutputsFieldOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, DSSignalDelay.NumChannelsFieldOffset);
  }

  public void SetSrcNode(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalDelay.SrcNodeFieldOffset);
  }

  public void SetDelayTimeMs(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalDelay.DelayTimeMsFieldOffset);
  }
}

public class SignalFeedback : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 10;
  public const int DS_SIZE = 24;

  public SignalFeedback() {}

  public SignalFeedback(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(DSSignalFeedback.NumOutputsFieldOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(DSSignalFeedback.NumChannelsFieldOffset);
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalFeedback.SrcNodeFieldOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalFeedback.NumOutputsChangedBit) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalFeedback.NumChannelsChangedBit) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalFeedback.SrcNodeChangedBit) != 0;
  }
}

public class SignalFeedbackWrite : SignalFeedback {
  public SignalFeedbackWrite() {}

  public SignalFeedbackWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, DSSignalFeedback.NumOutputsFieldOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, DSSignalFeedback.NumChannelsFieldOffset);
  }

  public void SetSrcNode(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalFeedback.SrcNodeFieldOffset);
  }
}

public class SignalMathOp : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 11;
  public const int DS_SIZE = 52;

  public SignalMathOp() {}

  public SignalMathOp(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(DSSignalMathOp.NumOutputsFieldOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(DSSignalMathOp.NumChannelsFieldOffset);
  }

  public MathOperation GetOperation() {
    return (MathOperation)(uint)(_memAccessor.ReadUint(DSSignalMathOp.OperationFieldOffset));
  }

  public float GetOperandA() {
    return DSScalar.ReadValue(_memAccessor, DSSignalMathOp.OperandAFieldOffset);
  }

  public ISignalNode GetOperandANode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetOperandANodeId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandANodeFieldOffset);
  }

  public float GetOperandB() {
    return DSScalar.ReadValue(_memAccessor, DSSignalMathOp.OperandBFieldOffset);
  }

  public ISignalNode GetOperandBNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetOperandBNodeId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMathOp.OperandBNodeFieldOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMathOp.NumOutputsChangedBit) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMathOp.NumChannelsChangedBit) != 0;
  }

  public bool CheckOperationChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMathOp.OperationChangedBit) != 0;
  }

  public bool CheckOperandAChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMathOp.OperandAChangedBit) != 0;
  }

  public bool CheckOperandANodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMathOp.OperandANodeChangedBit) != 0;
  }

  public bool CheckOperandBChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMathOp.OperandBChangedBit) != 0;
  }

  public bool CheckOperandBNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMathOp.OperandBNodeChangedBit) != 0;
  }
}

public class SignalMathOpWrite : SignalMathOp {
  public SignalMathOpWrite() {}

  public SignalMathOpWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, DSSignalMathOp.NumOutputsFieldOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, DSSignalMathOp.NumChannelsFieldOffset);
  }

  public void SetOperation(MathOperation value) {
    _memAccessor.WriteUint((uint)(value), DSSignalMathOp.OperationFieldOffset);
  }

  public void SetOperandA(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalMathOp.OperandAFieldOffset);
  }

  public void SetOperandANode(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalMathOp.OperandANodeFieldOffset);
  }

  public void SetOperandB(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalMathOp.OperandBFieldOffset);
  }

  public void SetOperandBNode(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalMathOp.OperandBNodeFieldOffset);
  }
}

public class SignalMultiplexer : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 12;
  public const int DS_SIZE = 156;

  public SignalMultiplexer() {}

  public SignalMultiplexer(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(DSSignalMultiplexer.NumOutputsFieldOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(DSSignalMultiplexer.NumChannelsFieldOffset);
  }

  public ISignalNode GetSrcNode0(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode0Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset);
  }

  public ISignalNode GetSrcNode1(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode1Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset);
  }

  public ISignalNode GetSrcNode2(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode2Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset);
  }

  public ISignalNode GetSrcNode3(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode3Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset);
  }

  public ISignalNode GetSrcNode4(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode4Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset);
  }

  public ISignalNode GetSrcNode5(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode5Id() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset);
  }

  public OutboundSignalEvent GetIncrementEvent(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.IncrementEventFieldOffset), out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetIncrementEventId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.IncrementEventFieldOffset);
  }

  public OutboundSignalEvent GetStartEvent(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.StartEventFieldOffset), out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetStartEventId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.StartEventFieldOffset);
  }

  public bool GetAutoStart() {
    return (_memAccessor.ReadInt(DSSignalMultiplexer.AutoStartFieldOffset) == 1 ? true : false);
  }

  public OutboundSignalEvent GetOnDoneEvent(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.OnDoneEventFieldOffset), out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetOnDoneEventId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalMultiplexer.OnDoneEventFieldOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMultiplexer.NumOutputsChangedBit) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMultiplexer.NumChannelsChangedBit) != 0;
  }

  public bool CheckSrcNode0Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMultiplexer.SrcNode0ChangedBit) != 0;
  }

  public bool CheckSrcNode1Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMultiplexer.SrcNode1ChangedBit) != 0;
  }

  public bool CheckSrcNode2Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMultiplexer.SrcNode2ChangedBit) != 0;
  }

  public bool CheckSrcNode3Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMultiplexer.SrcNode3ChangedBit) != 0;
  }

  public bool CheckSrcNode4Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMultiplexer.SrcNode4ChangedBit) != 0;
  }

  public bool CheckSrcNode5Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMultiplexer.SrcNode5ChangedBit) != 0;
  }

  public bool CheckIncrementEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMultiplexer.IncrementEventChangedBit) != 0;
  }

  public bool CheckStartEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMultiplexer.StartEventChangedBit) != 0;
  }

  public bool CheckAutoStartChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMultiplexer.AutoStartChangedBit) != 0;
  }

  public bool CheckOnDoneEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalMultiplexer.OnDoneEventChangedBit) != 0;
  }
}

public class SignalMultiplexerWrite : SignalMultiplexer {
  public SignalMultiplexerWrite() {}

  public SignalMultiplexerWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, DSSignalMultiplexer.NumOutputsFieldOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, DSSignalMultiplexer.NumChannelsFieldOffset);
  }

  public void SetSrcNode0(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalMultiplexer.SrcNode0FieldOffset);
  }

  public void SetSrcNode1(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalMultiplexer.SrcNode1FieldOffset);
  }

  public void SetSrcNode2(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalMultiplexer.SrcNode2FieldOffset);
  }

  public void SetSrcNode3(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalMultiplexer.SrcNode3FieldOffset);
  }

  public void SetSrcNode4(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalMultiplexer.SrcNode4FieldOffset);
  }

  public void SetSrcNode5(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalMultiplexer.SrcNode5FieldOffset);
  }

  public void SetIncrementEvent(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalMultiplexer.IncrementEventFieldOffset);
  }

  public void SetStartEvent(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalMultiplexer.StartEventFieldOffset);
  }

  public void SetAutoStart(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), DSSignalMultiplexer.AutoStartFieldOffset);
  }

  public void SetOnDoneEvent(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalMultiplexer.OnDoneEventFieldOffset);
  }
}

public class SignalParametricEqualizer : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 13;
  public const int DS_SIZE = 108;

  public SignalParametricEqualizer() {}

  public SignalParametricEqualizer(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(DSSignalParametricEqualizer.NumOutputsFieldOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(DSSignalParametricEqualizer.NumChannelsFieldOffset);
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset);
  }

  public FilterType GetFilterType0() {
    return (FilterType)(uint)(_memAccessor.ReadUint(DSSignalParametricEqualizer.FilterType0FieldOffset));
  }

  public float GetFrequency0() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Frequency0FieldOffset);
  }

  public float GetQuality0() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Quality0FieldOffset);
  }

  public float GetGain0() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Gain0FieldOffset);
  }

  public FilterType GetFilterType1() {
    return (FilterType)(uint)(_memAccessor.ReadUint(DSSignalParametricEqualizer.FilterType1FieldOffset));
  }

  public float GetFrequency1() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Frequency1FieldOffset);
  }

  public float GetQuality1() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Quality1FieldOffset);
  }

  public float GetGain1() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Gain1FieldOffset);
  }

  public FilterType GetFilterType2() {
    return (FilterType)(uint)(_memAccessor.ReadUint(DSSignalParametricEqualizer.FilterType2FieldOffset));
  }

  public float GetFrequency2() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Frequency2FieldOffset);
  }

  public float GetQuality2() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Quality2FieldOffset);
  }

  public float GetGain2() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Gain2FieldOffset);
  }

  public FilterType GetFilterType3() {
    return (FilterType)(uint)(_memAccessor.ReadUint(DSSignalParametricEqualizer.FilterType3FieldOffset));
  }

  public float GetFrequency3() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Frequency3FieldOffset);
  }

  public float GetQuality3() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Quality3FieldOffset);
  }

  public float GetGain3() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Gain3FieldOffset);
  }

  public FilterType GetFilterType4() {
    return (FilterType)(uint)(_memAccessor.ReadUint(DSSignalParametricEqualizer.FilterType4FieldOffset));
  }

  public float GetFrequency4() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Frequency4FieldOffset);
  }

  public float GetQuality4() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Quality4FieldOffset);
  }

  public float GetGain4() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.Gain4FieldOffset);
  }

  public float GetGainAdjust() {
    return DSScalar.ReadValue(_memAccessor, DSSignalParametricEqualizer.GainAdjustFieldOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.NumOutputsChangedBit) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.NumChannelsChangedBit) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.SrcNodeChangedBit) != 0;
  }

  public bool CheckFilterType0Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.FilterType0ChangedBit) != 0;
  }

  public bool CheckFrequency0Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Frequency0ChangedBit) != 0;
  }

  public bool CheckQuality0Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Quality0ChangedBit) != 0;
  }

  public bool CheckGain0Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Gain0ChangedBit) != 0;
  }

  public bool CheckFilterType1Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.FilterType1ChangedBit) != 0;
  }

  public bool CheckFrequency1Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Frequency1ChangedBit) != 0;
  }

  public bool CheckQuality1Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Quality1ChangedBit) != 0;
  }

  public bool CheckGain1Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Gain1ChangedBit) != 0;
  }

  public bool CheckFilterType2Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.FilterType2ChangedBit) != 0;
  }

  public bool CheckFrequency2Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Frequency2ChangedBit) != 0;
  }

  public bool CheckQuality2Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Quality2ChangedBit) != 0;
  }

  public bool CheckGain2Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Gain2ChangedBit) != 0;
  }

  public bool CheckFilterType3Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.FilterType3ChangedBit) != 0;
  }

  public bool CheckFrequency3Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Frequency3ChangedBit) != 0;
  }

  public bool CheckQuality3Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Quality3ChangedBit) != 0;
  }

  public bool CheckGain3Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Gain3ChangedBit) != 0;
  }

  public bool CheckFilterType4Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.FilterType4ChangedBit) != 0;
  }

  public bool CheckFrequency4Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Frequency4ChangedBit) != 0;
  }

  public bool CheckQuality4Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Quality4ChangedBit) != 0;
  }

  public bool CheckGain4Changed(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.Gain4ChangedBit) != 0;
  }

  public bool CheckGainAdjustChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalParametricEqualizer.GainAdjustChangedBit) != 0;
  }
}

public class SignalParametricEqualizerWrite : SignalParametricEqualizer {
  public SignalParametricEqualizerWrite() {}

  public SignalParametricEqualizerWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, DSSignalParametricEqualizer.NumOutputsFieldOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, DSSignalParametricEqualizer.NumChannelsFieldOffset);
  }

  public void SetSrcNode(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.SrcNodeFieldOffset);
  }

  public void SetFilterType0(FilterType value) {
    _memAccessor.WriteUint((uint)(value), DSSignalParametricEqualizer.FilterType0FieldOffset);
  }

  public void SetFrequency0(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Frequency0FieldOffset);
  }

  public void SetQuality0(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Quality0FieldOffset);
  }

  public void SetGain0(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Gain0FieldOffset);
  }

  public void SetFilterType1(FilterType value) {
    _memAccessor.WriteUint((uint)(value), DSSignalParametricEqualizer.FilterType1FieldOffset);
  }

  public void SetFrequency1(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Frequency1FieldOffset);
  }

  public void SetQuality1(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Quality1FieldOffset);
  }

  public void SetGain1(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Gain1FieldOffset);
  }

  public void SetFilterType2(FilterType value) {
    _memAccessor.WriteUint((uint)(value), DSSignalParametricEqualizer.FilterType2FieldOffset);
  }

  public void SetFrequency2(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Frequency2FieldOffset);
  }

  public void SetQuality2(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Quality2FieldOffset);
  }

  public void SetGain2(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Gain2FieldOffset);
  }

  public void SetFilterType3(FilterType value) {
    _memAccessor.WriteUint((uint)(value), DSSignalParametricEqualizer.FilterType3FieldOffset);
  }

  public void SetFrequency3(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Frequency3FieldOffset);
  }

  public void SetQuality3(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Quality3FieldOffset);
  }

  public void SetGain3(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Gain3FieldOffset);
  }

  public void SetFilterType4(FilterType value) {
    _memAccessor.WriteUint((uint)(value), DSSignalParametricEqualizer.FilterType4FieldOffset);
  }

  public void SetFrequency4(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Frequency4FieldOffset);
  }

  public void SetQuality4(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Quality4FieldOffset);
  }

  public void SetGain4(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.Gain4FieldOffset);
  }

  public void SetGainAdjust(float value) {
    DSScalar.WriteValue(value, _memAccessor, DSSignalParametricEqualizer.GainAdjustFieldOffset);
  }
}

public class SignalPitchShift : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 14;
  public const int DS_SIZE = 28;

  public SignalPitchShift() {}

  public SignalPitchShift(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(DSSignalPitchShift.NumOutputsFieldOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(DSSignalPitchShift.NumChannelsFieldOffset);
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalPitchShift.SrcNodeFieldOffset);
  }

  public int GetPitchShiftSemitones() {
    return _memAccessor.ReadInt(DSSignalPitchShift.PitchShiftSemitonesFieldOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalPitchShift.NumOutputsChangedBit) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalPitchShift.NumChannelsChangedBit) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalPitchShift.SrcNodeChangedBit) != 0;
  }

  public bool CheckPitchShiftSemitonesChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalPitchShift.PitchShiftSemitonesChangedBit) != 0;
  }
}

public class SignalPitchShiftWrite : SignalPitchShift {
  public SignalPitchShiftWrite() {}

  public SignalPitchShiftWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, DSSignalPitchShift.NumOutputsFieldOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, DSSignalPitchShift.NumChannelsFieldOffset);
  }

  public void SetSrcNode(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalPitchShift.SrcNodeFieldOffset);
  }

  public void SetPitchShiftSemitones(int value) {
    _memAccessor.WriteInt(value, DSSignalPitchShift.PitchShiftSemitonesFieldOffset);
  }
}

public class SignalSoftClip : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 15;
  public const int DS_SIZE = 24;

  public SignalSoftClip() {}

  public SignalSoftClip(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(DSSignalSoftClip.NumOutputsFieldOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(DSSignalSoftClip.NumChannelsFieldOffset);
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalSoftClip.SrcNodeFieldOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalSoftClip.NumOutputsChangedBit) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalSoftClip.NumChannelsChangedBit) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalSoftClip.SrcNodeChangedBit) != 0;
  }
}

public class SignalSoftClipWrite : SignalSoftClip {
  public SignalSoftClipWrite() {}

  public SignalSoftClipWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, DSSignalSoftClip.NumOutputsFieldOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, DSSignalSoftClip.NumChannelsFieldOffset);
  }

  public void SetSrcNode(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalSoftClip.SrcNodeFieldOffset);
  }
}

public class SignalOutputData : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 16;
  public const int DS_SIZE = 28;

  public SignalOutputData() {}

  public SignalOutputData(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputData.SrcNodeFieldOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(DSSignalOutputData.NumChannelsFieldOffset);
  }

  public SampleType GetSampleType() {
    return (SampleType)(uint)(_memAccessor.ReadUint(DSSignalOutputData.SampleTypeFieldOffset));
  }

  public int GetSamplesPerChannelPerSec() {
    return _memAccessor.ReadInt(DSSignalOutputData.SamplesPerChannelPerSecFieldOffset);
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputData.SrcNodeChangedBit) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputData.NumChannelsChangedBit) != 0;
  }

  public bool CheckSampleTypeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputData.SampleTypeChangedBit) != 0;
  }

  public bool CheckSamplesPerChannelPerSecChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputData.SamplesPerChannelPerSecChangedBit) != 0;
  }
}

public class SignalOutputDataWrite : SignalOutputData {
  public SignalOutputDataWrite() {}

  public SignalOutputDataWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetSrcNode(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalOutputData.SrcNodeFieldOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, DSSignalOutputData.NumChannelsFieldOffset);
  }

  public void SetSampleType(SampleType value) {
    _memAccessor.WriteUint((uint)(value), DSSignalOutputData.SampleTypeFieldOffset);
  }

  public void SetSamplesPerChannelPerSec(int value) {
    _memAccessor.WriteInt(value, DSSignalOutputData.SamplesPerChannelPerSecFieldOffset);
  }
}

public class SignalOutputDevice : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 17;
  public const int DS_SIZE = 160;

  public SignalOutputDevice() {}

  public SignalOutputDevice(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset), out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset), out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset), out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset), out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset), out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset), out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset), out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset), out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset), out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset), out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset), out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset), out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset), out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset), out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset);
  }

  public int GetChannelOffset() {
    return _memAccessor.ReadInt(DSSignalOutputDevice.ChannelOffsetFieldOffset);
  }

  // pseudo-regex, with just $ and ^ supported for now
  public string GetDeviceNameFilter() {
    return _memAccessor.ReadString(DSSignalOutputDevice.DeviceNameFilterFieldOffset, 128);
  }

  public DeviceHandednessFilter GetDeviceHandednessFilter() {
    return (DeviceHandednessFilter)(uint)(_memAccessor.ReadUint(DSSignalOutputDevice.DeviceHandednessFilterFieldOffset));
  }

  // Set to true if a matching device was found
  public bool GetFoundMatch() {
    return (_memAccessor.ReadInt(DSSignalOutputDevice.FoundMatchFieldOffset) == 1 ? true : false);
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.SrcNodeChangedBit) != 0;
  }

  public bool CheckChannelOffsetChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.ChannelOffsetChangedBit) != 0;
  }

  public bool CheckDeviceNameFilterChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.DeviceNameFilterChangedBit) != 0;
  }

  public bool CheckDeviceHandednessFilterChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.DeviceHandednessFilterChangedBit) != 0;
  }

  public bool CheckFoundMatchChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.FoundMatchChangedBit) != 0;
  }
}

public class SignalOutputDeviceWrite : SignalOutputDevice {
  public SignalOutputDeviceWrite() {}

  public SignalOutputDeviceWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetSrcNode(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalOutputDevice.SrcNodeFieldOffset);
  }

  public void SetChannelOffset(int value) {
    _memAccessor.WriteInt(value, DSSignalOutputDevice.ChannelOffsetFieldOffset);
  }

  public void SetDeviceNameFilter(string value) {
    _memAccessor.WriteString(value, DSSignalOutputDevice.DeviceNameFilterFieldOffset, 128);
  }

  public void SetDeviceHandednessFilter(DeviceHandednessFilter value) {
    _memAccessor.WriteUint((uint)(value), DSSignalOutputDevice.DeviceHandednessFilterFieldOffset);
  }

  public void SetFoundMatch(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), DSSignalOutputDevice.FoundMatchFieldOffset);
  }
}

// Reconciled Types
public abstract class ISignalNode : Xrpa.DataStoreObject, Xrpa.IDataStoreObject {
  public ISignalNode(Xrpa.DSIdentifier id, Xrpa.CollectionInterface collection) : base(id, collection) {}
}

public class OutboundSignalEvent : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<SignalEvent> {
  private System.Action<int, ReceiveEventMessage> _receiveEventMessageHandler = null;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;

  public OutboundSignalEvent(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalEventWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalEventWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalEventWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalEvent value, ulong fieldsChanged) {
  }

  public void SendtriggerEvent(float payload) {
    TriggerEventMessageWrite message = new(_collection.SendMessage(
        GetXrpaId(),
        0,
        TriggerEventMessageWrite.DS_SIZE));
    message.SetPayload(payload);
  }

  public void OnReceiveEvent(System.Action<int, ReceiveEventMessage> handler) {
    _receiveEventMessageHandler = handler;
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
    if (messageType == 1 && _receiveEventMessageHandler != null) {
      ReceiveEventMessage message = new(messageData);
      _receiveEventMessageHandler(timestamp, message);
    }
  }
}

public class OutboundSignalEventCombiner : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<SignalEventCombiner> {
  protected Xrpa.DSIdentifier _localSrcEvent0 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localSrcEvent1 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localSrcEvent2 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localSrcEvent3 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localSrcEvent4 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localSrcEvent5 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected ParameterMode _localParameterMode = ParameterMode.Passthrough;
  protected Xrpa.DSIdentifier _localOnEvent = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 255;

  public OutboundSignalEventCombiner(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public OutboundSignalEvent GetSrcEvent0(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcEvent0, out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcEvent0Id() {
    return _localSrcEvent0;
  }

  public void SetSrcEvent0(OutboundSignalEvent srcEvent0) {
    _localSrcEvent0 = srcEvent0?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalEventCombiner.SrcEvent0ChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.SrcEvent0ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.SrcEvent0ChangedBit);
    }
  }

  public void SetSrcEvent0Id(Xrpa.DSIdentifier srcEvent0) {
    _localSrcEvent0 = srcEvent0;
    if (_collection != null && (_changeBits & DSSignalEventCombiner.SrcEvent0ChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.SrcEvent0ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.SrcEvent0ChangedBit);
    }
  }

  public OutboundSignalEvent GetSrcEvent1(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcEvent1, out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcEvent1Id() {
    return _localSrcEvent1;
  }

  public void SetSrcEvent1(OutboundSignalEvent srcEvent1) {
    _localSrcEvent1 = srcEvent1?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalEventCombiner.SrcEvent1ChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.SrcEvent1ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.SrcEvent1ChangedBit);
    }
  }

  public void SetSrcEvent1Id(Xrpa.DSIdentifier srcEvent1) {
    _localSrcEvent1 = srcEvent1;
    if (_collection != null && (_changeBits & DSSignalEventCombiner.SrcEvent1ChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.SrcEvent1ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.SrcEvent1ChangedBit);
    }
  }

  public OutboundSignalEvent GetSrcEvent2(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcEvent2, out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcEvent2Id() {
    return _localSrcEvent2;
  }

  public void SetSrcEvent2(OutboundSignalEvent srcEvent2) {
    _localSrcEvent2 = srcEvent2?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalEventCombiner.SrcEvent2ChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.SrcEvent2ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.SrcEvent2ChangedBit);
    }
  }

  public void SetSrcEvent2Id(Xrpa.DSIdentifier srcEvent2) {
    _localSrcEvent2 = srcEvent2;
    if (_collection != null && (_changeBits & DSSignalEventCombiner.SrcEvent2ChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.SrcEvent2ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.SrcEvent2ChangedBit);
    }
  }

  public OutboundSignalEvent GetSrcEvent3(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcEvent3, out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcEvent3Id() {
    return _localSrcEvent3;
  }

  public void SetSrcEvent3(OutboundSignalEvent srcEvent3) {
    _localSrcEvent3 = srcEvent3?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalEventCombiner.SrcEvent3ChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.SrcEvent3ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.SrcEvent3ChangedBit);
    }
  }

  public void SetSrcEvent3Id(Xrpa.DSIdentifier srcEvent3) {
    _localSrcEvent3 = srcEvent3;
    if (_collection != null && (_changeBits & DSSignalEventCombiner.SrcEvent3ChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.SrcEvent3ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.SrcEvent3ChangedBit);
    }
  }

  public OutboundSignalEvent GetSrcEvent4(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcEvent4, out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcEvent4Id() {
    return _localSrcEvent4;
  }

  public void SetSrcEvent4(OutboundSignalEvent srcEvent4) {
    _localSrcEvent4 = srcEvent4?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalEventCombiner.SrcEvent4ChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.SrcEvent4ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.SrcEvent4ChangedBit);
    }
  }

  public void SetSrcEvent4Id(Xrpa.DSIdentifier srcEvent4) {
    _localSrcEvent4 = srcEvent4;
    if (_collection != null && (_changeBits & DSSignalEventCombiner.SrcEvent4ChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.SrcEvent4ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.SrcEvent4ChangedBit);
    }
  }

  public OutboundSignalEvent GetSrcEvent5(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcEvent5, out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcEvent5Id() {
    return _localSrcEvent5;
  }

  public void SetSrcEvent5(OutboundSignalEvent srcEvent5) {
    _localSrcEvent5 = srcEvent5?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalEventCombiner.SrcEvent5ChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.SrcEvent5ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.SrcEvent5ChangedBit);
    }
  }

  public void SetSrcEvent5Id(Xrpa.DSIdentifier srcEvent5) {
    _localSrcEvent5 = srcEvent5;
    if (_collection != null && (_changeBits & DSSignalEventCombiner.SrcEvent5ChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.SrcEvent5ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.SrcEvent5ChangedBit);
    }
  }

  public ParameterMode GetParameterMode() {
    return _localParameterMode;
  }

  public void SetParameterMode(ParameterMode parameterMode) {
    _localParameterMode = parameterMode;
    if (_collection != null && (_changeBits & DSSignalEventCombiner.ParameterModeChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.ParameterModeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.ParameterModeChangedBit);
    }
  }

  public OutboundSignalEvent GetOnEvent(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localOnEvent, out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetOnEventId() {
    return _localOnEvent;
  }

  public void SetOnEvent(OutboundSignalEvent onEvent) {
    _localOnEvent = onEvent?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalEventCombiner.OnEventChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.OnEventChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.OnEventChangedBit);
    }
  }

  public void SetOnEventId(Xrpa.DSIdentifier onEvent) {
    _localOnEvent = onEvent;
    if (_collection != null && (_changeBits & DSSignalEventCombiner.OnEventChangedBit) == 0) {
      _changeBits |= DSSignalEventCombiner.OnEventChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalEventCombiner.OnEventChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalEventCombinerWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalEventCombinerWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalEventCombinerWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalEventCombiner.SrcEvent0ChangedBit) != 0) {
      objAccessor.SetSrcEvent0(_localSrcEvent0);
    }
    if ((_changeBits & DSSignalEventCombiner.SrcEvent1ChangedBit) != 0) {
      objAccessor.SetSrcEvent1(_localSrcEvent1);
    }
    if ((_changeBits & DSSignalEventCombiner.SrcEvent2ChangedBit) != 0) {
      objAccessor.SetSrcEvent2(_localSrcEvent2);
    }
    if ((_changeBits & DSSignalEventCombiner.SrcEvent3ChangedBit) != 0) {
      objAccessor.SetSrcEvent3(_localSrcEvent3);
    }
    if ((_changeBits & DSSignalEventCombiner.SrcEvent4ChangedBit) != 0) {
      objAccessor.SetSrcEvent4(_localSrcEvent4);
    }
    if ((_changeBits & DSSignalEventCombiner.SrcEvent5ChangedBit) != 0) {
      objAccessor.SetSrcEvent5(_localSrcEvent5);
    }
    if ((_changeBits & DSSignalEventCombiner.ParameterModeChangedBit) != 0) {
      objAccessor.SetParameterMode(_localParameterMode);
    }
    if ((_changeBits & DSSignalEventCombiner.OnEventChangedBit) != 0) {
      objAccessor.SetOnEvent(_localOnEvent);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalEventCombiner value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalSource : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalSource> {
  protected int _localNumOutputs = 1;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 1;

  public OutboundSignalSource(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if (_collection != null && (_changeBits & DSSignalSource.NumOutputsChangedBit) == 0) {
      _changeBits |= DSSignalSource.NumOutputsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalSource.NumOutputsChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalSourceWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalSourceWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalSourceWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalSource.NumOutputsChangedBit) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalSource value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalSourceFile : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalSourceFile> {
  protected int _localNumOutputs = 1;
  protected string _localFilePath = "";
  protected bool _localAutoPlay = true;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 7;

  public OutboundSignalSourceFile(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if (_collection != null && (_changeBits & DSSignalSourceFile.NumOutputsChangedBit) == 0) {
      _changeBits |= DSSignalSourceFile.NumOutputsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalSourceFile.NumOutputsChangedBit);
    }
  }

  public string GetFilePath() {
    return _localFilePath;
  }

  public void SetFilePath(string filePath) {
    _localFilePath = filePath;
    if (_collection != null && (_changeBits & DSSignalSourceFile.FilePathChangedBit) == 0) {
      _changeBits |= DSSignalSourceFile.FilePathChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalSourceFile.FilePathChangedBit);
    }
  }

  public bool GetAutoPlay() {
    return _localAutoPlay;
  }

  public void SetAutoPlay(bool autoPlay) {
    _localAutoPlay = autoPlay;
    if (_collection != null && (_changeBits & DSSignalSourceFile.AutoPlayChangedBit) == 0) {
      _changeBits |= DSSignalSourceFile.AutoPlayChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalSourceFile.AutoPlayChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalSourceFileWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalSourceFileWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalSourceFileWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalSourceFile.NumOutputsChangedBit) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & DSSignalSourceFile.FilePathChangedBit) != 0) {
      objAccessor.SetFilePath(_localFilePath);
    }
    if ((_changeBits & DSSignalSourceFile.AutoPlayChangedBit) != 0) {
      objAccessor.SetAutoPlay(_localAutoPlay);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalSourceFile value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalChannelRouter : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalChannelRouter> {
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected float _localChannelSelect = 0.5f;
  protected Xrpa.DSIdentifier _localChannelSelectNode = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localSrcNode = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 31;

  public OutboundSignalChannelRouter(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if (_collection != null && (_changeBits & DSSignalChannelRouter.NumOutputsChangedBit) == 0) {
      _changeBits |= DSSignalChannelRouter.NumOutputsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelRouter.NumOutputsChangedBit);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if (_collection != null && (_changeBits & DSSignalChannelRouter.NumChannelsChangedBit) == 0) {
      _changeBits |= DSSignalChannelRouter.NumChannelsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelRouter.NumChannelsChangedBit);
    }
  }

  public float GetChannelSelect() {
    return _localChannelSelect;
  }

  public void SetChannelSelect(float channelSelect) {
    _localChannelSelect = channelSelect;
    if (_collection != null && (_changeBits & DSSignalChannelRouter.ChannelSelectChangedBit) == 0) {
      _changeBits |= DSSignalChannelRouter.ChannelSelectChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelRouter.ChannelSelectChangedBit);
    }
  }

  public ISignalNode GetChannelSelectNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localChannelSelectNode, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localChannelSelectNode, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localChannelSelectNode, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localChannelSelectNode, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localChannelSelectNode, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localChannelSelectNode, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localChannelSelectNode, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localChannelSelectNode, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localChannelSelectNode, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localChannelSelectNode, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localChannelSelectNode, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localChannelSelectNode, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localChannelSelectNode, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localChannelSelectNode, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetChannelSelectNodeId() {
    return _localChannelSelectNode;
  }

  public void SetChannelSelectNode(ISignalNode channelSelectNode) {
    _localChannelSelectNode = channelSelectNode?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalChannelRouter.ChannelSelectNodeChangedBit) == 0) {
      _changeBits |= DSSignalChannelRouter.ChannelSelectNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelRouter.ChannelSelectNodeChangedBit);
    }
  }

  public void SetChannelSelectNodeId(Xrpa.DSIdentifier channelSelectNode) {
    _localChannelSelectNode = channelSelectNode;
    if (_collection != null && (_changeBits & DSSignalChannelRouter.ChannelSelectNodeChangedBit) == 0) {
      _changeBits |= DSSignalChannelRouter.ChannelSelectNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelRouter.ChannelSelectNodeChangedBit);
    }
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return _localSrcNode;
  }

  public void SetSrcNode(ISignalNode srcNode) {
    _localSrcNode = srcNode?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalChannelRouter.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalChannelRouter.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelRouter.SrcNodeChangedBit);
    }
  }

  public void SetSrcNodeId(Xrpa.DSIdentifier srcNode) {
    _localSrcNode = srcNode;
    if (_collection != null && (_changeBits & DSSignalChannelRouter.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalChannelRouter.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelRouter.SrcNodeChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalChannelRouterWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalChannelRouterWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalChannelRouterWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalChannelRouter.NumOutputsChangedBit) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & DSSignalChannelRouter.NumChannelsChangedBit) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & DSSignalChannelRouter.ChannelSelectChangedBit) != 0) {
      objAccessor.SetChannelSelect(_localChannelSelect);
    }
    if ((_changeBits & DSSignalChannelRouter.ChannelSelectNodeChangedBit) != 0) {
      objAccessor.SetChannelSelectNode(_localChannelSelectNode);
    }
    if ((_changeBits & DSSignalChannelRouter.SrcNodeChangedBit) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalChannelRouter value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalChannelSelect : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalChannelSelect> {
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected int _localChannelIdx = 0;
  protected Xrpa.DSIdentifier _localSrcNode = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 15;

  public OutboundSignalChannelSelect(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if (_collection != null && (_changeBits & DSSignalChannelSelect.NumOutputsChangedBit) == 0) {
      _changeBits |= DSSignalChannelSelect.NumOutputsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelSelect.NumOutputsChangedBit);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if (_collection != null && (_changeBits & DSSignalChannelSelect.NumChannelsChangedBit) == 0) {
      _changeBits |= DSSignalChannelSelect.NumChannelsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelSelect.NumChannelsChangedBit);
    }
  }

  public int GetChannelIdx() {
    return _localChannelIdx;
  }

  public void SetChannelIdx(int channelIdx) {
    _localChannelIdx = channelIdx;
    if (_collection != null && (_changeBits & DSSignalChannelSelect.ChannelIdxChangedBit) == 0) {
      _changeBits |= DSSignalChannelSelect.ChannelIdxChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelSelect.ChannelIdxChangedBit);
    }
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return _localSrcNode;
  }

  public void SetSrcNode(ISignalNode srcNode) {
    _localSrcNode = srcNode?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalChannelSelect.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalChannelSelect.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelSelect.SrcNodeChangedBit);
    }
  }

  public void SetSrcNodeId(Xrpa.DSIdentifier srcNode) {
    _localSrcNode = srcNode;
    if (_collection != null && (_changeBits & DSSignalChannelSelect.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalChannelSelect.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelSelect.SrcNodeChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalChannelSelectWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalChannelSelectWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalChannelSelectWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalChannelSelect.NumOutputsChangedBit) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & DSSignalChannelSelect.NumChannelsChangedBit) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & DSSignalChannelSelect.ChannelIdxChangedBit) != 0) {
      objAccessor.SetChannelIdx(_localChannelIdx);
    }
    if ((_changeBits & DSSignalChannelSelect.SrcNodeChangedBit) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalChannelSelect value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalChannelStack : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalChannelStack> {
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected Xrpa.DSIdentifier _localSrcNode0 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localSrcNode1 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localSrcNode2 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localSrcNode3 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 63;

  public OutboundSignalChannelStack(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if (_collection != null && (_changeBits & DSSignalChannelStack.NumOutputsChangedBit) == 0) {
      _changeBits |= DSSignalChannelStack.NumOutputsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelStack.NumOutputsChangedBit);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if (_collection != null && (_changeBits & DSSignalChannelStack.NumChannelsChangedBit) == 0) {
      _changeBits |= DSSignalChannelStack.NumChannelsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelStack.NumChannelsChangedBit);
    }
  }

  public ISignalNode GetSrcNode0(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode0Id() {
    return _localSrcNode0;
  }

  public void SetSrcNode0(ISignalNode srcNode0) {
    _localSrcNode0 = srcNode0?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalChannelStack.SrcNode0ChangedBit) == 0) {
      _changeBits |= DSSignalChannelStack.SrcNode0ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelStack.SrcNode0ChangedBit);
    }
  }

  public void SetSrcNode0Id(Xrpa.DSIdentifier srcNode0) {
    _localSrcNode0 = srcNode0;
    if (_collection != null && (_changeBits & DSSignalChannelStack.SrcNode0ChangedBit) == 0) {
      _changeBits |= DSSignalChannelStack.SrcNode0ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelStack.SrcNode0ChangedBit);
    }
  }

  public ISignalNode GetSrcNode1(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode1Id() {
    return _localSrcNode1;
  }

  public void SetSrcNode1(ISignalNode srcNode1) {
    _localSrcNode1 = srcNode1?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalChannelStack.SrcNode1ChangedBit) == 0) {
      _changeBits |= DSSignalChannelStack.SrcNode1ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelStack.SrcNode1ChangedBit);
    }
  }

  public void SetSrcNode1Id(Xrpa.DSIdentifier srcNode1) {
    _localSrcNode1 = srcNode1;
    if (_collection != null && (_changeBits & DSSignalChannelStack.SrcNode1ChangedBit) == 0) {
      _changeBits |= DSSignalChannelStack.SrcNode1ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelStack.SrcNode1ChangedBit);
    }
  }

  public ISignalNode GetSrcNode2(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode2Id() {
    return _localSrcNode2;
  }

  public void SetSrcNode2(ISignalNode srcNode2) {
    _localSrcNode2 = srcNode2?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalChannelStack.SrcNode2ChangedBit) == 0) {
      _changeBits |= DSSignalChannelStack.SrcNode2ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelStack.SrcNode2ChangedBit);
    }
  }

  public void SetSrcNode2Id(Xrpa.DSIdentifier srcNode2) {
    _localSrcNode2 = srcNode2;
    if (_collection != null && (_changeBits & DSSignalChannelStack.SrcNode2ChangedBit) == 0) {
      _changeBits |= DSSignalChannelStack.SrcNode2ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelStack.SrcNode2ChangedBit);
    }
  }

  public ISignalNode GetSrcNode3(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode3Id() {
    return _localSrcNode3;
  }

  public void SetSrcNode3(ISignalNode srcNode3) {
    _localSrcNode3 = srcNode3?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalChannelStack.SrcNode3ChangedBit) == 0) {
      _changeBits |= DSSignalChannelStack.SrcNode3ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelStack.SrcNode3ChangedBit);
    }
  }

  public void SetSrcNode3Id(Xrpa.DSIdentifier srcNode3) {
    _localSrcNode3 = srcNode3;
    if (_collection != null && (_changeBits & DSSignalChannelStack.SrcNode3ChangedBit) == 0) {
      _changeBits |= DSSignalChannelStack.SrcNode3ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalChannelStack.SrcNode3ChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalChannelStackWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalChannelStackWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalChannelStackWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalChannelStack.NumOutputsChangedBit) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & DSSignalChannelStack.NumChannelsChangedBit) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & DSSignalChannelStack.SrcNode0ChangedBit) != 0) {
      objAccessor.SetSrcNode0(_localSrcNode0);
    }
    if ((_changeBits & DSSignalChannelStack.SrcNode1ChangedBit) != 0) {
      objAccessor.SetSrcNode1(_localSrcNode1);
    }
    if ((_changeBits & DSSignalChannelStack.SrcNode2ChangedBit) != 0) {
      objAccessor.SetSrcNode2(_localSrcNode2);
    }
    if ((_changeBits & DSSignalChannelStack.SrcNode3ChangedBit) != 0) {
      objAccessor.SetSrcNode3(_localSrcNode3);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalChannelStack value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalCurve : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalCurve> {
  protected int _localNumOutputs = 1;
  protected bool _localSoftCurve = false;
  protected int _localNumSegments = 1;
  protected float _localStartValue = 1f;
  protected float _localSegmentLength0 = 1f;
  protected float _localSegmentEndValue0 = 1f;
  protected float _localSegmentLength1 = 1f;
  protected float _localSegmentEndValue1 = 1f;
  protected float _localSegmentLength2 = 1f;
  protected float _localSegmentEndValue2 = 1f;
  protected float _localSegmentLength3 = 1f;
  protected float _localSegmentEndValue3 = 1f;
  protected float _localSegmentLength4 = 1f;
  protected float _localSegmentEndValue4 = 1f;
  protected float _localSegmentLength5 = 1f;
  protected float _localSegmentEndValue5 = 1f;
  protected Xrpa.DSIdentifier _localStartEvent = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected bool _localAutoStart = true;
  protected Xrpa.DSIdentifier _localOnDoneEvent = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected bool _localAutoLoop = false;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 1048575;

  public OutboundSignalCurve(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if (_collection != null && (_changeBits & DSSignalCurve.NumOutputsChangedBit) == 0) {
      _changeBits |= DSSignalCurve.NumOutputsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.NumOutputsChangedBit);
    }
  }

  public bool GetSoftCurve() {
    return _localSoftCurve;
  }

  public void SetSoftCurve(bool softCurve) {
    _localSoftCurve = softCurve;
    if (_collection != null && (_changeBits & DSSignalCurve.SoftCurveChangedBit) == 0) {
      _changeBits |= DSSignalCurve.SoftCurveChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.SoftCurveChangedBit);
    }
  }

  public int GetNumSegments() {
    return _localNumSegments;
  }

  public void SetNumSegments(int numSegments) {
    _localNumSegments = numSegments;
    if (_collection != null && (_changeBits & DSSignalCurve.NumSegmentsChangedBit) == 0) {
      _changeBits |= DSSignalCurve.NumSegmentsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.NumSegmentsChangedBit);
    }
  }

  public float GetStartValue() {
    return _localStartValue;
  }

  public void SetStartValue(float startValue) {
    _localStartValue = startValue;
    if (_collection != null && (_changeBits & DSSignalCurve.StartValueChangedBit) == 0) {
      _changeBits |= DSSignalCurve.StartValueChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.StartValueChangedBit);
    }
  }

  public float GetSegmentLength0() {
    return _localSegmentLength0;
  }

  public void SetSegmentLength0(float segmentLength0) {
    _localSegmentLength0 = segmentLength0;
    if (_collection != null && (_changeBits & DSSignalCurve.SegmentLength0ChangedBit) == 0) {
      _changeBits |= DSSignalCurve.SegmentLength0ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.SegmentLength0ChangedBit);
    }
  }

  public float GetSegmentEndValue0() {
    return _localSegmentEndValue0;
  }

  public void SetSegmentEndValue0(float segmentEndValue0) {
    _localSegmentEndValue0 = segmentEndValue0;
    if (_collection != null && (_changeBits & DSSignalCurve.SegmentEndValue0ChangedBit) == 0) {
      _changeBits |= DSSignalCurve.SegmentEndValue0ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.SegmentEndValue0ChangedBit);
    }
  }

  public float GetSegmentLength1() {
    return _localSegmentLength1;
  }

  public void SetSegmentLength1(float segmentLength1) {
    _localSegmentLength1 = segmentLength1;
    if (_collection != null && (_changeBits & DSSignalCurve.SegmentLength1ChangedBit) == 0) {
      _changeBits |= DSSignalCurve.SegmentLength1ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.SegmentLength1ChangedBit);
    }
  }

  public float GetSegmentEndValue1() {
    return _localSegmentEndValue1;
  }

  public void SetSegmentEndValue1(float segmentEndValue1) {
    _localSegmentEndValue1 = segmentEndValue1;
    if (_collection != null && (_changeBits & DSSignalCurve.SegmentEndValue1ChangedBit) == 0) {
      _changeBits |= DSSignalCurve.SegmentEndValue1ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.SegmentEndValue1ChangedBit);
    }
  }

  public float GetSegmentLength2() {
    return _localSegmentLength2;
  }

  public void SetSegmentLength2(float segmentLength2) {
    _localSegmentLength2 = segmentLength2;
    if (_collection != null && (_changeBits & DSSignalCurve.SegmentLength2ChangedBit) == 0) {
      _changeBits |= DSSignalCurve.SegmentLength2ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.SegmentLength2ChangedBit);
    }
  }

  public float GetSegmentEndValue2() {
    return _localSegmentEndValue2;
  }

  public void SetSegmentEndValue2(float segmentEndValue2) {
    _localSegmentEndValue2 = segmentEndValue2;
    if (_collection != null && (_changeBits & DSSignalCurve.SegmentEndValue2ChangedBit) == 0) {
      _changeBits |= DSSignalCurve.SegmentEndValue2ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.SegmentEndValue2ChangedBit);
    }
  }

  public float GetSegmentLength3() {
    return _localSegmentLength3;
  }

  public void SetSegmentLength3(float segmentLength3) {
    _localSegmentLength3 = segmentLength3;
    if (_collection != null && (_changeBits & DSSignalCurve.SegmentLength3ChangedBit) == 0) {
      _changeBits |= DSSignalCurve.SegmentLength3ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.SegmentLength3ChangedBit);
    }
  }

  public float GetSegmentEndValue3() {
    return _localSegmentEndValue3;
  }

  public void SetSegmentEndValue3(float segmentEndValue3) {
    _localSegmentEndValue3 = segmentEndValue3;
    if (_collection != null && (_changeBits & DSSignalCurve.SegmentEndValue3ChangedBit) == 0) {
      _changeBits |= DSSignalCurve.SegmentEndValue3ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.SegmentEndValue3ChangedBit);
    }
  }

  public float GetSegmentLength4() {
    return _localSegmentLength4;
  }

  public void SetSegmentLength4(float segmentLength4) {
    _localSegmentLength4 = segmentLength4;
    if (_collection != null && (_changeBits & DSSignalCurve.SegmentLength4ChangedBit) == 0) {
      _changeBits |= DSSignalCurve.SegmentLength4ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.SegmentLength4ChangedBit);
    }
  }

  public float GetSegmentEndValue4() {
    return _localSegmentEndValue4;
  }

  public void SetSegmentEndValue4(float segmentEndValue4) {
    _localSegmentEndValue4 = segmentEndValue4;
    if (_collection != null && (_changeBits & DSSignalCurve.SegmentEndValue4ChangedBit) == 0) {
      _changeBits |= DSSignalCurve.SegmentEndValue4ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.SegmentEndValue4ChangedBit);
    }
  }

  public float GetSegmentLength5() {
    return _localSegmentLength5;
  }

  public void SetSegmentLength5(float segmentLength5) {
    _localSegmentLength5 = segmentLength5;
    if (_collection != null && (_changeBits & DSSignalCurve.SegmentLength5ChangedBit) == 0) {
      _changeBits |= DSSignalCurve.SegmentLength5ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.SegmentLength5ChangedBit);
    }
  }

  public float GetSegmentEndValue5() {
    return _localSegmentEndValue5;
  }

  public void SetSegmentEndValue5(float segmentEndValue5) {
    _localSegmentEndValue5 = segmentEndValue5;
    if (_collection != null && (_changeBits & DSSignalCurve.SegmentEndValue5ChangedBit) == 0) {
      _changeBits |= DSSignalCurve.SegmentEndValue5ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.SegmentEndValue5ChangedBit);
    }
  }

  public OutboundSignalEvent GetStartEvent(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localStartEvent, out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetStartEventId() {
    return _localStartEvent;
  }

  public void SetStartEvent(OutboundSignalEvent startEvent) {
    _localStartEvent = startEvent?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalCurve.StartEventChangedBit) == 0) {
      _changeBits |= DSSignalCurve.StartEventChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.StartEventChangedBit);
    }
  }

  public void SetStartEventId(Xrpa.DSIdentifier startEvent) {
    _localStartEvent = startEvent;
    if (_collection != null && (_changeBits & DSSignalCurve.StartEventChangedBit) == 0) {
      _changeBits |= DSSignalCurve.StartEventChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.StartEventChangedBit);
    }
  }

  public bool GetAutoStart() {
    return _localAutoStart;
  }

  public void SetAutoStart(bool autoStart) {
    _localAutoStart = autoStart;
    if (_collection != null && (_changeBits & DSSignalCurve.AutoStartChangedBit) == 0) {
      _changeBits |= DSSignalCurve.AutoStartChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.AutoStartChangedBit);
    }
  }

  public OutboundSignalEvent GetOnDoneEvent(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localOnDoneEvent, out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetOnDoneEventId() {
    return _localOnDoneEvent;
  }

  public void SetOnDoneEvent(OutboundSignalEvent onDoneEvent) {
    _localOnDoneEvent = onDoneEvent?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalCurve.OnDoneEventChangedBit) == 0) {
      _changeBits |= DSSignalCurve.OnDoneEventChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.OnDoneEventChangedBit);
    }
  }

  public void SetOnDoneEventId(Xrpa.DSIdentifier onDoneEvent) {
    _localOnDoneEvent = onDoneEvent;
    if (_collection != null && (_changeBits & DSSignalCurve.OnDoneEventChangedBit) == 0) {
      _changeBits |= DSSignalCurve.OnDoneEventChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.OnDoneEventChangedBit);
    }
  }

  public bool GetAutoLoop() {
    return _localAutoLoop;
  }

  public void SetAutoLoop(bool autoLoop) {
    _localAutoLoop = autoLoop;
    if (_collection != null && (_changeBits & DSSignalCurve.AutoLoopChangedBit) == 0) {
      _changeBits |= DSSignalCurve.AutoLoopChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalCurve.AutoLoopChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalCurveWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalCurveWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalCurveWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalCurve.NumOutputsChangedBit) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & DSSignalCurve.SoftCurveChangedBit) != 0) {
      objAccessor.SetSoftCurve(_localSoftCurve);
    }
    if ((_changeBits & DSSignalCurve.NumSegmentsChangedBit) != 0) {
      objAccessor.SetNumSegments(_localNumSegments);
    }
    if ((_changeBits & DSSignalCurve.StartValueChangedBit) != 0) {
      objAccessor.SetStartValue(_localStartValue);
    }
    if ((_changeBits & DSSignalCurve.SegmentLength0ChangedBit) != 0) {
      objAccessor.SetSegmentLength0(_localSegmentLength0);
    }
    if ((_changeBits & DSSignalCurve.SegmentEndValue0ChangedBit) != 0) {
      objAccessor.SetSegmentEndValue0(_localSegmentEndValue0);
    }
    if ((_changeBits & DSSignalCurve.SegmentLength1ChangedBit) != 0) {
      objAccessor.SetSegmentLength1(_localSegmentLength1);
    }
    if ((_changeBits & DSSignalCurve.SegmentEndValue1ChangedBit) != 0) {
      objAccessor.SetSegmentEndValue1(_localSegmentEndValue1);
    }
    if ((_changeBits & DSSignalCurve.SegmentLength2ChangedBit) != 0) {
      objAccessor.SetSegmentLength2(_localSegmentLength2);
    }
    if ((_changeBits & DSSignalCurve.SegmentEndValue2ChangedBit) != 0) {
      objAccessor.SetSegmentEndValue2(_localSegmentEndValue2);
    }
    if ((_changeBits & DSSignalCurve.SegmentLength3ChangedBit) != 0) {
      objAccessor.SetSegmentLength3(_localSegmentLength3);
    }
    if ((_changeBits & DSSignalCurve.SegmentEndValue3ChangedBit) != 0) {
      objAccessor.SetSegmentEndValue3(_localSegmentEndValue3);
    }
    if ((_changeBits & DSSignalCurve.SegmentLength4ChangedBit) != 0) {
      objAccessor.SetSegmentLength4(_localSegmentLength4);
    }
    if ((_changeBits & DSSignalCurve.SegmentEndValue4ChangedBit) != 0) {
      objAccessor.SetSegmentEndValue4(_localSegmentEndValue4);
    }
    if ((_changeBits & DSSignalCurve.SegmentLength5ChangedBit) != 0) {
      objAccessor.SetSegmentLength5(_localSegmentLength5);
    }
    if ((_changeBits & DSSignalCurve.SegmentEndValue5ChangedBit) != 0) {
      objAccessor.SetSegmentEndValue5(_localSegmentEndValue5);
    }
    if ((_changeBits & DSSignalCurve.StartEventChangedBit) != 0) {
      objAccessor.SetStartEvent(_localStartEvent);
    }
    if ((_changeBits & DSSignalCurve.AutoStartChangedBit) != 0) {
      objAccessor.SetAutoStart(_localAutoStart);
    }
    if ((_changeBits & DSSignalCurve.OnDoneEventChangedBit) != 0) {
      objAccessor.SetOnDoneEvent(_localOnDoneEvent);
    }
    if ((_changeBits & DSSignalCurve.AutoLoopChangedBit) != 0) {
      objAccessor.SetAutoLoop(_localAutoLoop);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalCurve value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalDelay : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalDelay> {
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected Xrpa.DSIdentifier _localSrcNode = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected float _localDelayTimeMs = 1f;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 15;

  public OutboundSignalDelay(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if (_collection != null && (_changeBits & DSSignalDelay.NumOutputsChangedBit) == 0) {
      _changeBits |= DSSignalDelay.NumOutputsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalDelay.NumOutputsChangedBit);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if (_collection != null && (_changeBits & DSSignalDelay.NumChannelsChangedBit) == 0) {
      _changeBits |= DSSignalDelay.NumChannelsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalDelay.NumChannelsChangedBit);
    }
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return _localSrcNode;
  }

  public void SetSrcNode(ISignalNode srcNode) {
    _localSrcNode = srcNode?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalDelay.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalDelay.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalDelay.SrcNodeChangedBit);
    }
  }

  public void SetSrcNodeId(Xrpa.DSIdentifier srcNode) {
    _localSrcNode = srcNode;
    if (_collection != null && (_changeBits & DSSignalDelay.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalDelay.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalDelay.SrcNodeChangedBit);
    }
  }

  public float GetDelayTimeMs() {
    return _localDelayTimeMs;
  }

  public void SetDelayTimeMs(float delayTimeMs) {
    _localDelayTimeMs = delayTimeMs;
    if (_collection != null && (_changeBits & DSSignalDelay.DelayTimeMsChangedBit) == 0) {
      _changeBits |= DSSignalDelay.DelayTimeMsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalDelay.DelayTimeMsChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalDelayWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalDelayWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalDelayWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalDelay.NumOutputsChangedBit) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & DSSignalDelay.NumChannelsChangedBit) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & DSSignalDelay.SrcNodeChangedBit) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    if ((_changeBits & DSSignalDelay.DelayTimeMsChangedBit) != 0) {
      objAccessor.SetDelayTimeMs(_localDelayTimeMs);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalDelay value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalFeedback : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalFeedback> {
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected Xrpa.DSIdentifier _localSrcNode = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 7;

  public OutboundSignalFeedback(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if (_collection != null && (_changeBits & DSSignalFeedback.NumOutputsChangedBit) == 0) {
      _changeBits |= DSSignalFeedback.NumOutputsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalFeedback.NumOutputsChangedBit);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if (_collection != null && (_changeBits & DSSignalFeedback.NumChannelsChangedBit) == 0) {
      _changeBits |= DSSignalFeedback.NumChannelsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalFeedback.NumChannelsChangedBit);
    }
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return _localSrcNode;
  }

  public void SetSrcNode(ISignalNode srcNode) {
    _localSrcNode = srcNode?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalFeedback.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalFeedback.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalFeedback.SrcNodeChangedBit);
    }
  }

  public void SetSrcNodeId(Xrpa.DSIdentifier srcNode) {
    _localSrcNode = srcNode;
    if (_collection != null && (_changeBits & DSSignalFeedback.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalFeedback.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalFeedback.SrcNodeChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalFeedbackWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalFeedbackWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalFeedbackWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalFeedback.NumOutputsChangedBit) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & DSSignalFeedback.NumChannelsChangedBit) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & DSSignalFeedback.SrcNodeChangedBit) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalFeedback value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalMathOp : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalMathOp> {
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected MathOperation _localOperation = MathOperation.Add;
  protected float _localOperandA = 1f;
  protected Xrpa.DSIdentifier _localOperandANode = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected float _localOperandB = 1f;
  protected Xrpa.DSIdentifier _localOperandBNode = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 127;

  public OutboundSignalMathOp(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if (_collection != null && (_changeBits & DSSignalMathOp.NumOutputsChangedBit) == 0) {
      _changeBits |= DSSignalMathOp.NumOutputsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMathOp.NumOutputsChangedBit);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if (_collection != null && (_changeBits & DSSignalMathOp.NumChannelsChangedBit) == 0) {
      _changeBits |= DSSignalMathOp.NumChannelsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMathOp.NumChannelsChangedBit);
    }
  }

  public MathOperation GetOperation() {
    return _localOperation;
  }

  public void SetOperation(MathOperation operation) {
    _localOperation = operation;
    if (_collection != null && (_changeBits & DSSignalMathOp.OperationChangedBit) == 0) {
      _changeBits |= DSSignalMathOp.OperationChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMathOp.OperationChangedBit);
    }
  }

  public float GetOperandA() {
    return _localOperandA;
  }

  public void SetOperandA(float operandA) {
    _localOperandA = operandA;
    if (_collection != null && (_changeBits & DSSignalMathOp.OperandAChangedBit) == 0) {
      _changeBits |= DSSignalMathOp.OperandAChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMathOp.OperandAChangedBit);
    }
  }

  public ISignalNode GetOperandANode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localOperandANode, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localOperandANode, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localOperandANode, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localOperandANode, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localOperandANode, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localOperandANode, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localOperandANode, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localOperandANode, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localOperandANode, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localOperandANode, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localOperandANode, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localOperandANode, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localOperandANode, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localOperandANode, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetOperandANodeId() {
    return _localOperandANode;
  }

  public void SetOperandANode(ISignalNode operandANode) {
    _localOperandANode = operandANode?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalMathOp.OperandANodeChangedBit) == 0) {
      _changeBits |= DSSignalMathOp.OperandANodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMathOp.OperandANodeChangedBit);
    }
  }

  public void SetOperandANodeId(Xrpa.DSIdentifier operandANode) {
    _localOperandANode = operandANode;
    if (_collection != null && (_changeBits & DSSignalMathOp.OperandANodeChangedBit) == 0) {
      _changeBits |= DSSignalMathOp.OperandANodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMathOp.OperandANodeChangedBit);
    }
  }

  public float GetOperandB() {
    return _localOperandB;
  }

  public void SetOperandB(float operandB) {
    _localOperandB = operandB;
    if (_collection != null && (_changeBits & DSSignalMathOp.OperandBChangedBit) == 0) {
      _changeBits |= DSSignalMathOp.OperandBChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMathOp.OperandBChangedBit);
    }
  }

  public ISignalNode GetOperandBNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localOperandBNode, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localOperandBNode, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localOperandBNode, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localOperandBNode, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localOperandBNode, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localOperandBNode, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localOperandBNode, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localOperandBNode, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localOperandBNode, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localOperandBNode, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localOperandBNode, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localOperandBNode, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localOperandBNode, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localOperandBNode, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetOperandBNodeId() {
    return _localOperandBNode;
  }

  public void SetOperandBNode(ISignalNode operandBNode) {
    _localOperandBNode = operandBNode?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalMathOp.OperandBNodeChangedBit) == 0) {
      _changeBits |= DSSignalMathOp.OperandBNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMathOp.OperandBNodeChangedBit);
    }
  }

  public void SetOperandBNodeId(Xrpa.DSIdentifier operandBNode) {
    _localOperandBNode = operandBNode;
    if (_collection != null && (_changeBits & DSSignalMathOp.OperandBNodeChangedBit) == 0) {
      _changeBits |= DSSignalMathOp.OperandBNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMathOp.OperandBNodeChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalMathOpWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalMathOpWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalMathOpWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalMathOp.NumOutputsChangedBit) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & DSSignalMathOp.NumChannelsChangedBit) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & DSSignalMathOp.OperationChangedBit) != 0) {
      objAccessor.SetOperation(_localOperation);
    }
    if ((_changeBits & DSSignalMathOp.OperandAChangedBit) != 0) {
      objAccessor.SetOperandA(_localOperandA);
    }
    if ((_changeBits & DSSignalMathOp.OperandANodeChangedBit) != 0) {
      objAccessor.SetOperandANode(_localOperandANode);
    }
    if ((_changeBits & DSSignalMathOp.OperandBChangedBit) != 0) {
      objAccessor.SetOperandB(_localOperandB);
    }
    if ((_changeBits & DSSignalMathOp.OperandBNodeChangedBit) != 0) {
      objAccessor.SetOperandBNode(_localOperandBNode);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalMathOp value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalMultiplexer : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalMultiplexer> {
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected Xrpa.DSIdentifier _localSrcNode0 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localSrcNode1 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localSrcNode2 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localSrcNode3 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localSrcNode4 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localSrcNode5 = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localIncrementEvent = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.DSIdentifier _localStartEvent = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected bool _localAutoStart = true;
  protected Xrpa.DSIdentifier _localOnDoneEvent = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 4095;

  public OutboundSignalMultiplexer(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if (_collection != null && (_changeBits & DSSignalMultiplexer.NumOutputsChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.NumOutputsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.NumOutputsChangedBit);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if (_collection != null && (_changeBits & DSSignalMultiplexer.NumChannelsChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.NumChannelsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.NumChannelsChangedBit);
    }
  }

  public ISignalNode GetSrcNode0(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode0, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode0Id() {
    return _localSrcNode0;
  }

  public void SetSrcNode0(ISignalNode srcNode0) {
    _localSrcNode0 = srcNode0?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalMultiplexer.SrcNode0ChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.SrcNode0ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.SrcNode0ChangedBit);
    }
  }

  public void SetSrcNode0Id(Xrpa.DSIdentifier srcNode0) {
    _localSrcNode0 = srcNode0;
    if (_collection != null && (_changeBits & DSSignalMultiplexer.SrcNode0ChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.SrcNode0ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.SrcNode0ChangedBit);
    }
  }

  public ISignalNode GetSrcNode1(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode1, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode1Id() {
    return _localSrcNode1;
  }

  public void SetSrcNode1(ISignalNode srcNode1) {
    _localSrcNode1 = srcNode1?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalMultiplexer.SrcNode1ChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.SrcNode1ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.SrcNode1ChangedBit);
    }
  }

  public void SetSrcNode1Id(Xrpa.DSIdentifier srcNode1) {
    _localSrcNode1 = srcNode1;
    if (_collection != null && (_changeBits & DSSignalMultiplexer.SrcNode1ChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.SrcNode1ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.SrcNode1ChangedBit);
    }
  }

  public ISignalNode GetSrcNode2(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode2, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode2Id() {
    return _localSrcNode2;
  }

  public void SetSrcNode2(ISignalNode srcNode2) {
    _localSrcNode2 = srcNode2?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalMultiplexer.SrcNode2ChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.SrcNode2ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.SrcNode2ChangedBit);
    }
  }

  public void SetSrcNode2Id(Xrpa.DSIdentifier srcNode2) {
    _localSrcNode2 = srcNode2;
    if (_collection != null && (_changeBits & DSSignalMultiplexer.SrcNode2ChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.SrcNode2ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.SrcNode2ChangedBit);
    }
  }

  public ISignalNode GetSrcNode3(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode3, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode3Id() {
    return _localSrcNode3;
  }

  public void SetSrcNode3(ISignalNode srcNode3) {
    _localSrcNode3 = srcNode3?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalMultiplexer.SrcNode3ChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.SrcNode3ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.SrcNode3ChangedBit);
    }
  }

  public void SetSrcNode3Id(Xrpa.DSIdentifier srcNode3) {
    _localSrcNode3 = srcNode3;
    if (_collection != null && (_changeBits & DSSignalMultiplexer.SrcNode3ChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.SrcNode3ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.SrcNode3ChangedBit);
    }
  }

  public ISignalNode GetSrcNode4(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode4, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode4, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode4, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode4, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode4, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode4, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode4, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode4, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode4, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode4, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode4, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode4, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode4, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode4, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode4Id() {
    return _localSrcNode4;
  }

  public void SetSrcNode4(ISignalNode srcNode4) {
    _localSrcNode4 = srcNode4?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalMultiplexer.SrcNode4ChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.SrcNode4ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.SrcNode4ChangedBit);
    }
  }

  public void SetSrcNode4Id(Xrpa.DSIdentifier srcNode4) {
    _localSrcNode4 = srcNode4;
    if (_collection != null && (_changeBits & DSSignalMultiplexer.SrcNode4ChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.SrcNode4ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.SrcNode4ChangedBit);
    }
  }

  public ISignalNode GetSrcNode5(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode5, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode5, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode5, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode5, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode5, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode5, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode5, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode5, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode5, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode5, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode5, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode5, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode5, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode5, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNode5Id() {
    return _localSrcNode5;
  }

  public void SetSrcNode5(ISignalNode srcNode5) {
    _localSrcNode5 = srcNode5?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalMultiplexer.SrcNode5ChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.SrcNode5ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.SrcNode5ChangedBit);
    }
  }

  public void SetSrcNode5Id(Xrpa.DSIdentifier srcNode5) {
    _localSrcNode5 = srcNode5;
    if (_collection != null && (_changeBits & DSSignalMultiplexer.SrcNode5ChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.SrcNode5ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.SrcNode5ChangedBit);
    }
  }

  public OutboundSignalEvent GetIncrementEvent(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localIncrementEvent, out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetIncrementEventId() {
    return _localIncrementEvent;
  }

  public void SetIncrementEvent(OutboundSignalEvent incrementEvent) {
    _localIncrementEvent = incrementEvent?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalMultiplexer.IncrementEventChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.IncrementEventChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.IncrementEventChangedBit);
    }
  }

  public void SetIncrementEventId(Xrpa.DSIdentifier incrementEvent) {
    _localIncrementEvent = incrementEvent;
    if (_collection != null && (_changeBits & DSSignalMultiplexer.IncrementEventChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.IncrementEventChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.IncrementEventChangedBit);
    }
  }

  public OutboundSignalEvent GetStartEvent(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localStartEvent, out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetStartEventId() {
    return _localStartEvent;
  }

  public void SetStartEvent(OutboundSignalEvent startEvent) {
    _localStartEvent = startEvent?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalMultiplexer.StartEventChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.StartEventChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.StartEventChangedBit);
    }
  }

  public void SetStartEventId(Xrpa.DSIdentifier startEvent) {
    _localStartEvent = startEvent;
    if (_collection != null && (_changeBits & DSSignalMultiplexer.StartEventChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.StartEventChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.StartEventChangedBit);
    }
  }

  public bool GetAutoStart() {
    return _localAutoStart;
  }

  public void SetAutoStart(bool autoStart) {
    _localAutoStart = autoStart;
    if (_collection != null && (_changeBits & DSSignalMultiplexer.AutoStartChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.AutoStartChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.AutoStartChangedBit);
    }
  }

  public OutboundSignalEvent GetOnDoneEvent(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localOnDoneEvent, out OutboundSignalEvent OutboundSignalEventVal);
    if (OutboundSignalEventVal != null) {
      return OutboundSignalEventVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetOnDoneEventId() {
    return _localOnDoneEvent;
  }

  public void SetOnDoneEvent(OutboundSignalEvent onDoneEvent) {
    _localOnDoneEvent = onDoneEvent?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalMultiplexer.OnDoneEventChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.OnDoneEventChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.OnDoneEventChangedBit);
    }
  }

  public void SetOnDoneEventId(Xrpa.DSIdentifier onDoneEvent) {
    _localOnDoneEvent = onDoneEvent;
    if (_collection != null && (_changeBits & DSSignalMultiplexer.OnDoneEventChangedBit) == 0) {
      _changeBits |= DSSignalMultiplexer.OnDoneEventChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalMultiplexer.OnDoneEventChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalMultiplexerWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalMultiplexerWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalMultiplexerWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalMultiplexer.NumOutputsChangedBit) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & DSSignalMultiplexer.NumChannelsChangedBit) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & DSSignalMultiplexer.SrcNode0ChangedBit) != 0) {
      objAccessor.SetSrcNode0(_localSrcNode0);
    }
    if ((_changeBits & DSSignalMultiplexer.SrcNode1ChangedBit) != 0) {
      objAccessor.SetSrcNode1(_localSrcNode1);
    }
    if ((_changeBits & DSSignalMultiplexer.SrcNode2ChangedBit) != 0) {
      objAccessor.SetSrcNode2(_localSrcNode2);
    }
    if ((_changeBits & DSSignalMultiplexer.SrcNode3ChangedBit) != 0) {
      objAccessor.SetSrcNode3(_localSrcNode3);
    }
    if ((_changeBits & DSSignalMultiplexer.SrcNode4ChangedBit) != 0) {
      objAccessor.SetSrcNode4(_localSrcNode4);
    }
    if ((_changeBits & DSSignalMultiplexer.SrcNode5ChangedBit) != 0) {
      objAccessor.SetSrcNode5(_localSrcNode5);
    }
    if ((_changeBits & DSSignalMultiplexer.IncrementEventChangedBit) != 0) {
      objAccessor.SetIncrementEvent(_localIncrementEvent);
    }
    if ((_changeBits & DSSignalMultiplexer.StartEventChangedBit) != 0) {
      objAccessor.SetStartEvent(_localStartEvent);
    }
    if ((_changeBits & DSSignalMultiplexer.AutoStartChangedBit) != 0) {
      objAccessor.SetAutoStart(_localAutoStart);
    }
    if ((_changeBits & DSSignalMultiplexer.OnDoneEventChangedBit) != 0) {
      objAccessor.SetOnDoneEvent(_localOnDoneEvent);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalMultiplexer value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalOscillator : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalOscillator> {
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected WaveformType _localWaveformType = WaveformType.Sawtooth;
  protected float _localFrequency = 440f;
  protected Xrpa.DSIdentifier _localFrequencyNode = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected float _localPulseWidth = 0.5f;
  protected Xrpa.DSIdentifier _localPulseWidthNode = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 127;

  public OutboundSignalOscillator(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if (_collection != null && (_changeBits & DSSignalOscillator.NumOutputsChangedBit) == 0) {
      _changeBits |= DSSignalOscillator.NumOutputsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOscillator.NumOutputsChangedBit);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if (_collection != null && (_changeBits & DSSignalOscillator.NumChannelsChangedBit) == 0) {
      _changeBits |= DSSignalOscillator.NumChannelsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOscillator.NumChannelsChangedBit);
    }
  }

  public WaveformType GetWaveformType() {
    return _localWaveformType;
  }

  public void SetWaveformType(WaveformType waveformType) {
    _localWaveformType = waveformType;
    if (_collection != null && (_changeBits & DSSignalOscillator.WaveformTypeChangedBit) == 0) {
      _changeBits |= DSSignalOscillator.WaveformTypeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOscillator.WaveformTypeChangedBit);
    }
  }

  public float GetFrequency() {
    return _localFrequency;
  }

  public void SetFrequency(float frequency) {
    _localFrequency = frequency;
    if (_collection != null && (_changeBits & DSSignalOscillator.FrequencyChangedBit) == 0) {
      _changeBits |= DSSignalOscillator.FrequencyChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOscillator.FrequencyChangedBit);
    }
  }

  public ISignalNode GetFrequencyNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localFrequencyNode, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localFrequencyNode, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localFrequencyNode, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localFrequencyNode, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localFrequencyNode, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localFrequencyNode, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localFrequencyNode, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localFrequencyNode, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localFrequencyNode, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localFrequencyNode, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localFrequencyNode, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localFrequencyNode, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localFrequencyNode, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localFrequencyNode, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetFrequencyNodeId() {
    return _localFrequencyNode;
  }

  public void SetFrequencyNode(ISignalNode frequencyNode) {
    _localFrequencyNode = frequencyNode?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalOscillator.FrequencyNodeChangedBit) == 0) {
      _changeBits |= DSSignalOscillator.FrequencyNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOscillator.FrequencyNodeChangedBit);
    }
  }

  public void SetFrequencyNodeId(Xrpa.DSIdentifier frequencyNode) {
    _localFrequencyNode = frequencyNode;
    if (_collection != null && (_changeBits & DSSignalOscillator.FrequencyNodeChangedBit) == 0) {
      _changeBits |= DSSignalOscillator.FrequencyNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOscillator.FrequencyNodeChangedBit);
    }
  }

  public float GetPulseWidth() {
    return _localPulseWidth;
  }

  public void SetPulseWidth(float pulseWidth) {
    _localPulseWidth = pulseWidth;
    if (_collection != null && (_changeBits & DSSignalOscillator.PulseWidthChangedBit) == 0) {
      _changeBits |= DSSignalOscillator.PulseWidthChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOscillator.PulseWidthChangedBit);
    }
  }

  public ISignalNode GetPulseWidthNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localPulseWidthNode, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localPulseWidthNode, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localPulseWidthNode, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localPulseWidthNode, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localPulseWidthNode, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localPulseWidthNode, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localPulseWidthNode, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localPulseWidthNode, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localPulseWidthNode, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localPulseWidthNode, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localPulseWidthNode, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localPulseWidthNode, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localPulseWidthNode, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localPulseWidthNode, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetPulseWidthNodeId() {
    return _localPulseWidthNode;
  }

  public void SetPulseWidthNode(ISignalNode pulseWidthNode) {
    _localPulseWidthNode = pulseWidthNode?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalOscillator.PulseWidthNodeChangedBit) == 0) {
      _changeBits |= DSSignalOscillator.PulseWidthNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOscillator.PulseWidthNodeChangedBit);
    }
  }

  public void SetPulseWidthNodeId(Xrpa.DSIdentifier pulseWidthNode) {
    _localPulseWidthNode = pulseWidthNode;
    if (_collection != null && (_changeBits & DSSignalOscillator.PulseWidthNodeChangedBit) == 0) {
      _changeBits |= DSSignalOscillator.PulseWidthNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOscillator.PulseWidthNodeChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalOscillatorWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalOscillatorWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalOscillatorWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalOscillator.NumOutputsChangedBit) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & DSSignalOscillator.NumChannelsChangedBit) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & DSSignalOscillator.WaveformTypeChangedBit) != 0) {
      objAccessor.SetWaveformType(_localWaveformType);
    }
    if ((_changeBits & DSSignalOscillator.FrequencyChangedBit) != 0) {
      objAccessor.SetFrequency(_localFrequency);
    }
    if ((_changeBits & DSSignalOscillator.FrequencyNodeChangedBit) != 0) {
      objAccessor.SetFrequencyNode(_localFrequencyNode);
    }
    if ((_changeBits & DSSignalOscillator.PulseWidthChangedBit) != 0) {
      objAccessor.SetPulseWidth(_localPulseWidth);
    }
    if ((_changeBits & DSSignalOscillator.PulseWidthNodeChangedBit) != 0) {
      objAccessor.SetPulseWidthNode(_localPulseWidthNode);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalOscillator value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalParametricEqualizer : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalParametricEqualizer> {
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected Xrpa.DSIdentifier _localSrcNode = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected FilterType _localFilterType0 = FilterType.Bypass;
  protected float _localFrequency0 = 50f;
  protected float _localQuality0 = 0.707106f;
  protected float _localGain0 = 0f;
  protected FilterType _localFilterType1 = FilterType.Bypass;
  protected float _localFrequency1 = 50f;
  protected float _localQuality1 = 0.707106f;
  protected float _localGain1 = 0f;
  protected FilterType _localFilterType2 = FilterType.Bypass;
  protected float _localFrequency2 = 50f;
  protected float _localQuality2 = 0.707106f;
  protected float _localGain2 = 0f;
  protected FilterType _localFilterType3 = FilterType.Bypass;
  protected float _localFrequency3 = 50f;
  protected float _localQuality3 = 0.707106f;
  protected float _localGain3 = 0f;
  protected FilterType _localFilterType4 = FilterType.Bypass;
  protected float _localFrequency4 = 50f;
  protected float _localQuality4 = 0.707106f;
  protected float _localGain4 = 0f;
  protected float _localGainAdjust = 0f;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 16777215;

  public OutboundSignalParametricEqualizer(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.NumOutputsChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.NumOutputsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.NumOutputsChangedBit);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.NumChannelsChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.NumChannelsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.NumChannelsChangedBit);
    }
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return _localSrcNode;
  }

  public void SetSrcNode(ISignalNode srcNode) {
    _localSrcNode = srcNode?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.SrcNodeChangedBit);
    }
  }

  public void SetSrcNodeId(Xrpa.DSIdentifier srcNode) {
    _localSrcNode = srcNode;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.SrcNodeChangedBit);
    }
  }

  public FilterType GetFilterType0() {
    return _localFilterType0;
  }

  public void SetFilterType0(FilterType filterType0) {
    _localFilterType0 = filterType0;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.FilterType0ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.FilterType0ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.FilterType0ChangedBit);
    }
  }

  public float GetFrequency0() {
    return _localFrequency0;
  }

  public void SetFrequency0(float frequency0) {
    _localFrequency0 = frequency0;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Frequency0ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Frequency0ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Frequency0ChangedBit);
    }
  }

  public float GetQuality0() {
    return _localQuality0;
  }

  public void SetQuality0(float quality0) {
    _localQuality0 = quality0;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Quality0ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Quality0ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Quality0ChangedBit);
    }
  }

  public float GetGain0() {
    return _localGain0;
  }

  public void SetGain0(float gain0) {
    _localGain0 = gain0;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Gain0ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Gain0ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Gain0ChangedBit);
    }
  }

  public FilterType GetFilterType1() {
    return _localFilterType1;
  }

  public void SetFilterType1(FilterType filterType1) {
    _localFilterType1 = filterType1;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.FilterType1ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.FilterType1ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.FilterType1ChangedBit);
    }
  }

  public float GetFrequency1() {
    return _localFrequency1;
  }

  public void SetFrequency1(float frequency1) {
    _localFrequency1 = frequency1;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Frequency1ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Frequency1ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Frequency1ChangedBit);
    }
  }

  public float GetQuality1() {
    return _localQuality1;
  }

  public void SetQuality1(float quality1) {
    _localQuality1 = quality1;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Quality1ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Quality1ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Quality1ChangedBit);
    }
  }

  public float GetGain1() {
    return _localGain1;
  }

  public void SetGain1(float gain1) {
    _localGain1 = gain1;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Gain1ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Gain1ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Gain1ChangedBit);
    }
  }

  public FilterType GetFilterType2() {
    return _localFilterType2;
  }

  public void SetFilterType2(FilterType filterType2) {
    _localFilterType2 = filterType2;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.FilterType2ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.FilterType2ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.FilterType2ChangedBit);
    }
  }

  public float GetFrequency2() {
    return _localFrequency2;
  }

  public void SetFrequency2(float frequency2) {
    _localFrequency2 = frequency2;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Frequency2ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Frequency2ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Frequency2ChangedBit);
    }
  }

  public float GetQuality2() {
    return _localQuality2;
  }

  public void SetQuality2(float quality2) {
    _localQuality2 = quality2;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Quality2ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Quality2ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Quality2ChangedBit);
    }
  }

  public float GetGain2() {
    return _localGain2;
  }

  public void SetGain2(float gain2) {
    _localGain2 = gain2;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Gain2ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Gain2ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Gain2ChangedBit);
    }
  }

  public FilterType GetFilterType3() {
    return _localFilterType3;
  }

  public void SetFilterType3(FilterType filterType3) {
    _localFilterType3 = filterType3;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.FilterType3ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.FilterType3ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.FilterType3ChangedBit);
    }
  }

  public float GetFrequency3() {
    return _localFrequency3;
  }

  public void SetFrequency3(float frequency3) {
    _localFrequency3 = frequency3;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Frequency3ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Frequency3ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Frequency3ChangedBit);
    }
  }

  public float GetQuality3() {
    return _localQuality3;
  }

  public void SetQuality3(float quality3) {
    _localQuality3 = quality3;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Quality3ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Quality3ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Quality3ChangedBit);
    }
  }

  public float GetGain3() {
    return _localGain3;
  }

  public void SetGain3(float gain3) {
    _localGain3 = gain3;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Gain3ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Gain3ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Gain3ChangedBit);
    }
  }

  public FilterType GetFilterType4() {
    return _localFilterType4;
  }

  public void SetFilterType4(FilterType filterType4) {
    _localFilterType4 = filterType4;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.FilterType4ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.FilterType4ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.FilterType4ChangedBit);
    }
  }

  public float GetFrequency4() {
    return _localFrequency4;
  }

  public void SetFrequency4(float frequency4) {
    _localFrequency4 = frequency4;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Frequency4ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Frequency4ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Frequency4ChangedBit);
    }
  }

  public float GetQuality4() {
    return _localQuality4;
  }

  public void SetQuality4(float quality4) {
    _localQuality4 = quality4;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Quality4ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Quality4ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Quality4ChangedBit);
    }
  }

  public float GetGain4() {
    return _localGain4;
  }

  public void SetGain4(float gain4) {
    _localGain4 = gain4;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.Gain4ChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.Gain4ChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.Gain4ChangedBit);
    }
  }

  public float GetGainAdjust() {
    return _localGainAdjust;
  }

  public void SetGainAdjust(float gainAdjust) {
    _localGainAdjust = gainAdjust;
    if (_collection != null && (_changeBits & DSSignalParametricEqualizer.GainAdjustChangedBit) == 0) {
      _changeBits |= DSSignalParametricEqualizer.GainAdjustChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalParametricEqualizer.GainAdjustChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalParametricEqualizerWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalParametricEqualizerWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalParametricEqualizerWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalParametricEqualizer.NumOutputsChangedBit) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & DSSignalParametricEqualizer.NumChannelsChangedBit) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & DSSignalParametricEqualizer.SrcNodeChangedBit) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    if ((_changeBits & DSSignalParametricEqualizer.FilterType0ChangedBit) != 0) {
      objAccessor.SetFilterType0(_localFilterType0);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Frequency0ChangedBit) != 0) {
      objAccessor.SetFrequency0(_localFrequency0);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Quality0ChangedBit) != 0) {
      objAccessor.SetQuality0(_localQuality0);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Gain0ChangedBit) != 0) {
      objAccessor.SetGain0(_localGain0);
    }
    if ((_changeBits & DSSignalParametricEqualizer.FilterType1ChangedBit) != 0) {
      objAccessor.SetFilterType1(_localFilterType1);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Frequency1ChangedBit) != 0) {
      objAccessor.SetFrequency1(_localFrequency1);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Quality1ChangedBit) != 0) {
      objAccessor.SetQuality1(_localQuality1);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Gain1ChangedBit) != 0) {
      objAccessor.SetGain1(_localGain1);
    }
    if ((_changeBits & DSSignalParametricEqualizer.FilterType2ChangedBit) != 0) {
      objAccessor.SetFilterType2(_localFilterType2);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Frequency2ChangedBit) != 0) {
      objAccessor.SetFrequency2(_localFrequency2);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Quality2ChangedBit) != 0) {
      objAccessor.SetQuality2(_localQuality2);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Gain2ChangedBit) != 0) {
      objAccessor.SetGain2(_localGain2);
    }
    if ((_changeBits & DSSignalParametricEqualizer.FilterType3ChangedBit) != 0) {
      objAccessor.SetFilterType3(_localFilterType3);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Frequency3ChangedBit) != 0) {
      objAccessor.SetFrequency3(_localFrequency3);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Quality3ChangedBit) != 0) {
      objAccessor.SetQuality3(_localQuality3);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Gain3ChangedBit) != 0) {
      objAccessor.SetGain3(_localGain3);
    }
    if ((_changeBits & DSSignalParametricEqualizer.FilterType4ChangedBit) != 0) {
      objAccessor.SetFilterType4(_localFilterType4);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Frequency4ChangedBit) != 0) {
      objAccessor.SetFrequency4(_localFrequency4);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Quality4ChangedBit) != 0) {
      objAccessor.SetQuality4(_localQuality4);
    }
    if ((_changeBits & DSSignalParametricEqualizer.Gain4ChangedBit) != 0) {
      objAccessor.SetGain4(_localGain4);
    }
    if ((_changeBits & DSSignalParametricEqualizer.GainAdjustChangedBit) != 0) {
      objAccessor.SetGainAdjust(_localGainAdjust);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalParametricEqualizer value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalPitchShift : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalPitchShift> {
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected Xrpa.DSIdentifier _localSrcNode = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected int _localPitchShiftSemitones = 0;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 15;

  public OutboundSignalPitchShift(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if (_collection != null && (_changeBits & DSSignalPitchShift.NumOutputsChangedBit) == 0) {
      _changeBits |= DSSignalPitchShift.NumOutputsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalPitchShift.NumOutputsChangedBit);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if (_collection != null && (_changeBits & DSSignalPitchShift.NumChannelsChangedBit) == 0) {
      _changeBits |= DSSignalPitchShift.NumChannelsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalPitchShift.NumChannelsChangedBit);
    }
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return _localSrcNode;
  }

  public void SetSrcNode(ISignalNode srcNode) {
    _localSrcNode = srcNode?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalPitchShift.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalPitchShift.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalPitchShift.SrcNodeChangedBit);
    }
  }

  public void SetSrcNodeId(Xrpa.DSIdentifier srcNode) {
    _localSrcNode = srcNode;
    if (_collection != null && (_changeBits & DSSignalPitchShift.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalPitchShift.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalPitchShift.SrcNodeChangedBit);
    }
  }

  public int GetPitchShiftSemitones() {
    return _localPitchShiftSemitones;
  }

  public void SetPitchShiftSemitones(int pitchShiftSemitones) {
    _localPitchShiftSemitones = pitchShiftSemitones;
    if (_collection != null && (_changeBits & DSSignalPitchShift.PitchShiftSemitonesChangedBit) == 0) {
      _changeBits |= DSSignalPitchShift.PitchShiftSemitonesChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalPitchShift.PitchShiftSemitonesChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalPitchShiftWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalPitchShiftWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalPitchShiftWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalPitchShift.NumOutputsChangedBit) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & DSSignalPitchShift.NumChannelsChangedBit) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & DSSignalPitchShift.SrcNodeChangedBit) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    if ((_changeBits & DSSignalPitchShift.PitchShiftSemitonesChangedBit) != 0) {
      objAccessor.SetPitchShiftSemitones(_localPitchShiftSemitones);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalPitchShift value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalSoftClip : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalSoftClip> {
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected Xrpa.DSIdentifier _localSrcNode = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 7;

  public OutboundSignalSoftClip(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if (_collection != null && (_changeBits & DSSignalSoftClip.NumOutputsChangedBit) == 0) {
      _changeBits |= DSSignalSoftClip.NumOutputsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalSoftClip.NumOutputsChangedBit);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if (_collection != null && (_changeBits & DSSignalSoftClip.NumChannelsChangedBit) == 0) {
      _changeBits |= DSSignalSoftClip.NumChannelsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalSoftClip.NumChannelsChangedBit);
    }
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return _localSrcNode;
  }

  public void SetSrcNode(ISignalNode srcNode) {
    _localSrcNode = srcNode?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalSoftClip.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalSoftClip.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalSoftClip.SrcNodeChangedBit);
    }
  }

  public void SetSrcNodeId(Xrpa.DSIdentifier srcNode) {
    _localSrcNode = srcNode;
    if (_collection != null && (_changeBits & DSSignalSoftClip.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalSoftClip.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalSoftClip.SrcNodeChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalSoftClipWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalSoftClipWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalSoftClipWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalSoftClip.NumOutputsChangedBit) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & DSSignalSoftClip.NumChannelsChangedBit) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & DSSignalSoftClip.SrcNodeChangedBit) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalSoftClip value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalOutputData : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<SignalOutputData> {
  protected Xrpa.DSIdentifier _localSrcNode = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected int _localNumChannels = 1;
  protected SampleType _localSampleType = SampleType.Float;
  protected int _localSamplesPerChannelPerSec = 0;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 15;

  public OutboundSignalOutputData(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return _localSrcNode;
  }

  public void SetSrcNode(ISignalNode srcNode) {
    _localSrcNode = srcNode?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalOutputData.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalOutputData.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOutputData.SrcNodeChangedBit);
    }
  }

  public void SetSrcNodeId(Xrpa.DSIdentifier srcNode) {
    _localSrcNode = srcNode;
    if (_collection != null && (_changeBits & DSSignalOutputData.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalOutputData.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOutputData.SrcNodeChangedBit);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if (_collection != null && (_changeBits & DSSignalOutputData.NumChannelsChangedBit) == 0) {
      _changeBits |= DSSignalOutputData.NumChannelsChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOutputData.NumChannelsChangedBit);
    }
  }

  public SampleType GetSampleType() {
    return _localSampleType;
  }

  public void SetSampleType(SampleType sampleType) {
    _localSampleType = sampleType;
    if (_collection != null && (_changeBits & DSSignalOutputData.SampleTypeChangedBit) == 0) {
      _changeBits |= DSSignalOutputData.SampleTypeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOutputData.SampleTypeChangedBit);
    }
  }

  public int GetSamplesPerChannelPerSec() {
    return _localSamplesPerChannelPerSec;
  }

  public void SetSamplesPerChannelPerSec(int samplesPerChannelPerSec) {
    _localSamplesPerChannelPerSec = samplesPerChannelPerSec;
    if (_collection != null && (_changeBits & DSSignalOutputData.SamplesPerChannelPerSecChangedBit) == 0) {
      _changeBits |= DSSignalOutputData.SamplesPerChannelPerSecChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOutputData.SamplesPerChannelPerSecChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalOutputDataWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalOutputDataWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalOutputDataWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalOutputData.SrcNodeChangedBit) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    if ((_changeBits & DSSignalOutputData.NumChannelsChangedBit) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & DSSignalOutputData.SampleTypeChangedBit) != 0) {
      objAccessor.SetSampleType(_localSampleType);
    }
    if ((_changeBits & DSSignalOutputData.SamplesPerChannelPerSecChangedBit) != 0) {
      objAccessor.SetSamplesPerChannelPerSec(_localSamplesPerChannelPerSec);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalOutputData value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalOutputDevice : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<SignalOutputDevice> {
  protected Xrpa.DSIdentifier _localSrcNode = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected int _localChannelOffset = 0;

  // pseudo-regex, with just $ and ^ supported for now
  protected string _localDeviceNameFilter = "";
  protected DeviceHandednessFilter _localDeviceHandednessFilter = DeviceHandednessFilter.Any;

  // Set to true if a matching device was found
  protected bool _localFoundMatch = false;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 31;

  public OutboundSignalOutputDevice(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public ISignalNode GetSrcNode(SignalProcessingDataStore datastore) {
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelRouter OutboundSignalChannelRouterVal);
    if (OutboundSignalChannelRouterVal != null) {
      return OutboundSignalChannelRouterVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelSelect OutboundSignalChannelSelectVal);
    if (OutboundSignalChannelSelectVal != null) {
      return OutboundSignalChannelSelectVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalChannelStack OutboundSignalChannelStackVal);
    if (OutboundSignalChannelStackVal != null) {
      return OutboundSignalChannelStackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalCurve OutboundSignalCurveVal);
    if (OutboundSignalCurveVal != null) {
      return OutboundSignalCurveVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalDelay OutboundSignalDelayVal);
    if (OutboundSignalDelayVal != null) {
      return OutboundSignalDelayVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalFeedback OutboundSignalFeedbackVal);
    if (OutboundSignalFeedbackVal != null) {
      return OutboundSignalFeedbackVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMathOp OutboundSignalMathOpVal);
    if (OutboundSignalMathOpVal != null) {
      return OutboundSignalMathOpVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalMultiplexer OutboundSignalMultiplexerVal);
    if (OutboundSignalMultiplexerVal != null) {
      return OutboundSignalMultiplexerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalOscillator OutboundSignalOscillatorVal);
    if (OutboundSignalOscillatorVal != null) {
      return OutboundSignalOscillatorVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalParametricEqualizer OutboundSignalParametricEqualizerVal);
    if (OutboundSignalParametricEqualizerVal != null) {
      return OutboundSignalParametricEqualizerVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalPitchShift OutboundSignalPitchShiftVal);
    if (OutboundSignalPitchShiftVal != null) {
      return OutboundSignalPitchShiftVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSoftClip OutboundSignalSoftClipVal);
    if (OutboundSignalSoftClipVal != null) {
      return OutboundSignalSoftClipVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSource OutboundSignalSourceVal);
    if (OutboundSignalSourceVal != null) {
      return OutboundSignalSourceVal;
    }
    datastore.GetObjectByID(_localSrcNode, out OutboundSignalSourceFile OutboundSignalSourceFileVal);
    if (OutboundSignalSourceFileVal != null) {
      return OutboundSignalSourceFileVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetSrcNodeId() {
    return _localSrcNode;
  }

  public void SetSrcNode(ISignalNode srcNode) {
    _localSrcNode = srcNode?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalOutputDevice.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalOutputDevice.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOutputDevice.SrcNodeChangedBit);
    }
  }

  public void SetSrcNodeId(Xrpa.DSIdentifier srcNode) {
    _localSrcNode = srcNode;
    if (_collection != null && (_changeBits & DSSignalOutputDevice.SrcNodeChangedBit) == 0) {
      _changeBits |= DSSignalOutputDevice.SrcNodeChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOutputDevice.SrcNodeChangedBit);
    }
  }

  public int GetChannelOffset() {
    return _localChannelOffset;
  }

  public void SetChannelOffset(int channelOffset) {
    _localChannelOffset = channelOffset;
    if (_collection != null && (_changeBits & DSSignalOutputDevice.ChannelOffsetChangedBit) == 0) {
      _changeBits |= DSSignalOutputDevice.ChannelOffsetChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOutputDevice.ChannelOffsetChangedBit);
    }
  }

  public string GetDeviceNameFilter() {
    return _localDeviceNameFilter;
  }

  public void SetDeviceNameFilter(string deviceNameFilter) {
    _localDeviceNameFilter = deviceNameFilter;
    if (_collection != null && (_changeBits & DSSignalOutputDevice.DeviceNameFilterChangedBit) == 0) {
      _changeBits |= DSSignalOutputDevice.DeviceNameFilterChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOutputDevice.DeviceNameFilterChangedBit);
    }
  }

  public DeviceHandednessFilter GetDeviceHandednessFilter() {
    return _localDeviceHandednessFilter;
  }

  public void SetDeviceHandednessFilter(DeviceHandednessFilter deviceHandednessFilter) {
    _localDeviceHandednessFilter = deviceHandednessFilter;
    if (_collection != null && (_changeBits & DSSignalOutputDevice.DeviceHandednessFilterChangedBit) == 0) {
      _changeBits |= DSSignalOutputDevice.DeviceHandednessFilterChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOutputDevice.DeviceHandednessFilterChangedBit);
    }
  }

  public bool GetFoundMatch() {
    return _localFoundMatch;
  }

  public void SetFoundMatch(bool foundMatch) {
    _localFoundMatch = foundMatch;
    if (_collection != null && (_changeBits & DSSignalOutputDevice.FoundMatchChangedBit) == 0) {
      _changeBits |= DSSignalOutputDevice.FoundMatchChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOutputDevice.FoundMatchChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalOutputDeviceWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalOutputDeviceWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalOutputDeviceWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalOutputDevice.SrcNodeChangedBit) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    if ((_changeBits & DSSignalOutputDevice.ChannelOffsetChangedBit) != 0) {
      objAccessor.SetChannelOffset(_localChannelOffset);
    }
    if ((_changeBits & DSSignalOutputDevice.DeviceNameFilterChangedBit) != 0) {
      objAccessor.SetDeviceNameFilter(_localDeviceNameFilter);
    }
    if ((_changeBits & DSSignalOutputDevice.DeviceHandednessFilterChangedBit) != 0) {
      objAccessor.SetDeviceHandednessFilter(_localDeviceHandednessFilter);
    }
    if ((_changeBits & DSSignalOutputDevice.FoundMatchChangedBit) != 0) {
      objAccessor.SetFoundMatch(_localFoundMatch);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalOutputDevice value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

// Object Collections
public class OutboundSignalEventCollection : Xrpa.ObjectCollection<SignalEvent, OutboundSignalEvent> {
  public OutboundSignalEventCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalEvent.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalEvent obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalEventCombinerCollection : Xrpa.ObjectCollection<SignalEventCombiner, OutboundSignalEventCombiner> {
  public OutboundSignalEventCombinerCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalEventCombiner.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalEventCombiner obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalSourceCollection : Xrpa.ObjectCollection<SignalSource, OutboundSignalSource> {
  public OutboundSignalSourceCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalSource.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalSource obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalSourceFileCollection : Xrpa.ObjectCollection<SignalSourceFile, OutboundSignalSourceFile> {
  public OutboundSignalSourceFileCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalSourceFile.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalSourceFile obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalChannelRouterCollection : Xrpa.ObjectCollection<SignalChannelRouter, OutboundSignalChannelRouter> {
  public OutboundSignalChannelRouterCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalChannelRouter.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalChannelRouter obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalChannelSelectCollection : Xrpa.ObjectCollection<SignalChannelSelect, OutboundSignalChannelSelect> {
  public OutboundSignalChannelSelectCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalChannelSelect.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalChannelSelect obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalChannelStackCollection : Xrpa.ObjectCollection<SignalChannelStack, OutboundSignalChannelStack> {
  public OutboundSignalChannelStackCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalChannelStack.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalChannelStack obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalCurveCollection : Xrpa.ObjectCollection<SignalCurve, OutboundSignalCurve> {
  public OutboundSignalCurveCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalCurve.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalCurve obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalDelayCollection : Xrpa.ObjectCollection<SignalDelay, OutboundSignalDelay> {
  public OutboundSignalDelayCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalDelay.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalDelay obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalFeedbackCollection : Xrpa.ObjectCollection<SignalFeedback, OutboundSignalFeedback> {
  public OutboundSignalFeedbackCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalFeedback.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalFeedback obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalMathOpCollection : Xrpa.ObjectCollection<SignalMathOp, OutboundSignalMathOp> {
  public OutboundSignalMathOpCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalMathOp.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalMathOp obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalMultiplexerCollection : Xrpa.ObjectCollection<SignalMultiplexer, OutboundSignalMultiplexer> {
  public OutboundSignalMultiplexerCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalMultiplexer.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalMultiplexer obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalOscillatorCollection : Xrpa.ObjectCollection<SignalOscillator, OutboundSignalOscillator> {
  public OutboundSignalOscillatorCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalOscillator.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalOscillator obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalParametricEqualizerCollection : Xrpa.ObjectCollection<SignalParametricEqualizer, OutboundSignalParametricEqualizer> {
  public OutboundSignalParametricEqualizerCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalParametricEqualizer.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalParametricEqualizer obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalPitchShiftCollection : Xrpa.ObjectCollection<SignalPitchShift, OutboundSignalPitchShift> {
  public OutboundSignalPitchShiftCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalPitchShift.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalPitchShift obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalSoftClipCollection : Xrpa.ObjectCollection<SignalSoftClip, OutboundSignalSoftClip> {
  public OutboundSignalSoftClipCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalSoftClip.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalSoftClip obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalOutputDataCollection : Xrpa.ObjectCollection<SignalOutputData, OutboundSignalOutputData> {
  public OutboundSignalOutputDataCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalOutputData.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalOutputData obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalOutputDeviceCollection : Xrpa.ObjectCollection<SignalOutputDevice, OutboundSignalOutputDevice> {
  public OutboundSignalOutputDeviceCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalOutputDevice.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalOutputDevice obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

// Data Store Implementation
public class SignalProcessingDataStore : Xrpa.DatasetReconciler {
  public SignalProcessingDataStore(Xrpa.DatasetInterface dataset)
      : base(dataset, SignalProcessingDataStoreConfig.SIGNALPROCESSING_SCHEMA_HASH, 10008576) {
    SignalEventOut = new OutboundSignalEventCollection(this);
    RegisterCollection(SignalEventOut);
    SignalEventCombinerOut = new OutboundSignalEventCombinerCollection(this);
    RegisterCollection(SignalEventCombinerOut);
    SignalSourceOut = new OutboundSignalSourceCollection(this);
    RegisterCollection(SignalSourceOut);
    SignalSourceFileOut = new OutboundSignalSourceFileCollection(this);
    RegisterCollection(SignalSourceFileOut);
    SignalChannelRouterOut = new OutboundSignalChannelRouterCollection(this);
    RegisterCollection(SignalChannelRouterOut);
    SignalChannelSelectOut = new OutboundSignalChannelSelectCollection(this);
    RegisterCollection(SignalChannelSelectOut);
    SignalChannelStackOut = new OutboundSignalChannelStackCollection(this);
    RegisterCollection(SignalChannelStackOut);
    SignalCurveOut = new OutboundSignalCurveCollection(this);
    RegisterCollection(SignalCurveOut);
    SignalDelayOut = new OutboundSignalDelayCollection(this);
    RegisterCollection(SignalDelayOut);
    SignalFeedbackOut = new OutboundSignalFeedbackCollection(this);
    RegisterCollection(SignalFeedbackOut);
    SignalMathOpOut = new OutboundSignalMathOpCollection(this);
    RegisterCollection(SignalMathOpOut);
    SignalMultiplexerOut = new OutboundSignalMultiplexerCollection(this);
    RegisterCollection(SignalMultiplexerOut);
    SignalOscillatorOut = new OutboundSignalOscillatorCollection(this);
    RegisterCollection(SignalOscillatorOut);
    SignalParametricEqualizerOut = new OutboundSignalParametricEqualizerCollection(this);
    RegisterCollection(SignalParametricEqualizerOut);
    SignalPitchShiftOut = new OutboundSignalPitchShiftCollection(this);
    RegisterCollection(SignalPitchShiftOut);
    SignalSoftClipOut = new OutboundSignalSoftClipCollection(this);
    RegisterCollection(SignalSoftClipOut);
    SignalOutputDataOut = new OutboundSignalOutputDataCollection(this);
    RegisterCollection(SignalOutputDataOut);
    SignalOutputDeviceOut = new OutboundSignalOutputDeviceCollection(this);
    RegisterCollection(SignalOutputDeviceOut);
  }

  public OutboundSignalEventCollection SignalEventOut;
  public OutboundSignalEventCombinerCollection SignalEventCombinerOut;
  public OutboundSignalSourceCollection SignalSourceOut;
  public OutboundSignalSourceFileCollection SignalSourceFileOut;
  public OutboundSignalChannelRouterCollection SignalChannelRouterOut;
  public OutboundSignalChannelSelectCollection SignalChannelSelectOut;
  public OutboundSignalChannelStackCollection SignalChannelStackOut;
  public OutboundSignalCurveCollection SignalCurveOut;
  public OutboundSignalDelayCollection SignalDelayOut;
  public OutboundSignalFeedbackCollection SignalFeedbackOut;
  public OutboundSignalMathOpCollection SignalMathOpOut;
  public OutboundSignalMultiplexerCollection SignalMultiplexerOut;
  public OutboundSignalOscillatorCollection SignalOscillatorOut;
  public OutboundSignalParametricEqualizerCollection SignalParametricEqualizerOut;
  public OutboundSignalPitchShiftCollection SignalPitchShiftOut;
  public OutboundSignalSoftClipCollection SignalSoftClipOut;
  public OutboundSignalOutputDataCollection SignalOutputDataOut;
  public OutboundSignalOutputDeviceCollection SignalOutputDeviceOut;

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalEvent obj) {
    obj = SignalEventOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalEventCombiner obj) {
    obj = SignalEventCombinerOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalSource obj) {
    obj = SignalSourceOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalSourceFile obj) {
    obj = SignalSourceFileOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalChannelRouter obj) {
    obj = SignalChannelRouterOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalChannelSelect obj) {
    obj = SignalChannelSelectOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalChannelStack obj) {
    obj = SignalChannelStackOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalCurve obj) {
    obj = SignalCurveOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalDelay obj) {
    obj = SignalDelayOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalFeedback obj) {
    obj = SignalFeedbackOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalMathOp obj) {
    obj = SignalMathOpOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalMultiplexer obj) {
    obj = SignalMultiplexerOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalOscillator obj) {
    obj = SignalOscillatorOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalParametricEqualizer obj) {
    obj = SignalParametricEqualizerOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalPitchShift obj) {
    obj = SignalPitchShiftOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalSoftClip obj) {
    obj = SignalSoftClipOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalOutputData obj) {
    obj = SignalOutputDataOut.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalOutputDevice obj) {
    obj = SignalOutputDeviceOut.GetObject(id);
  }
}

} // namespace SignalProcessingDataStore
