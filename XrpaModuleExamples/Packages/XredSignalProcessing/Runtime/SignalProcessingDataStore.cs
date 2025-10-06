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

using System;
using Xrpa;

namespace SignalProcessingDataStore {

public class TriggerEventMessageReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public TriggerEventMessageReader() {}

  public TriggerEventMessageReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public float GetPayload() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }
}

public class TriggerEventMessageWriter : TriggerEventMessageReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public TriggerEventMessageWriter() {}

  public TriggerEventMessageWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetPayload(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class ReceiveEventMessageReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public ReceiveEventMessageReader() {}

  public ReceiveEventMessageReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public float GetPayload() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }
}

public class ReceiveEventMessageWriter : ReceiveEventMessageReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public ReceiveEventMessageWriter() {}

  public ReceiveEventMessageWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetPayload(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class SignalEventReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalEventReader() {}

  public SignalEventReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }
}

public class SignalEventWriter : SignalEventReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalEventWriter() {}

  public SignalEventWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalEventWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalEventWriter(changeEvent.AccessChangeData());
  }

  public static SignalEventWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalEventWriter(changeEvent.AccessChangeData());
  }
}

public class SignalEventCombinerReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalEventCombinerReader() {}

  public SignalEventCombinerReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public Xrpa.ObjectUuid GetSrcEvent0() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetSrcEvent1() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetSrcEvent2() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetSrcEvent3() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetSrcEvent4() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetSrcEvent5() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public ParameterMode GetParameterMode() {
    return (ParameterMode)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public Xrpa.ObjectUuid GetOnEvent() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckSrcEvent0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckSrcEvent1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcEvent2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSrcEvent3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckSrcEvent4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckSrcEvent5Changed(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckParameterModeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckOnEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }
}

public class SignalEventCombinerWriter : SignalEventCombinerReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalEventCombinerWriter() {}

  public SignalEventCombinerWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalEventCombinerWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalEventCombinerWriter(changeEvent.AccessChangeData());
  }

  public static SignalEventCombinerWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalEventCombinerWriter(changeEvent.AccessChangeData());
  }

  public void SetSrcEvent0(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSrcEvent1(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSrcEvent2(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSrcEvent3(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSrcEvent4(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSrcEvent5(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetParameterMode(ParameterMode value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetOnEvent(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class SignalSourceReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalSourceReader() {}

  public SignalSourceReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }
}

public class SignalSourceWriter : SignalSourceReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalSourceWriter() {}

  public SignalSourceWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalSourceWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalSourceWriter(changeEvent.AccessChangeData());
  }

  public static SignalSourceWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalSourceWriter(changeEvent.AccessChangeData());
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }
}

public class SignalSourceFileReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalSourceFileReader() {}

  public SignalSourceFileReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public string GetFilePath() {
    return _memAccessor.ReadString(_readOffset);
  }

  public bool GetAutoPlay() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckFilePathChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckAutoPlayChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }
}

public class SignalSourceFileWriter : SignalSourceFileReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalSourceFileWriter() {}

  public SignalSourceFileWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalSourceFileWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalSourceFileWriter(changeEvent.AccessChangeData());
  }

  public static SignalSourceFileWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalSourceFileWriter(changeEvent.AccessChangeData());
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetFilePath(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetAutoPlay(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }
}

public class SignalOscillatorReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalOscillatorReader() {}

  public SignalOscillatorReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public WaveformType GetWaveformType() {
    return (WaveformType)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public float GetFrequency() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetFrequencyNode() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public float GetPulseWidth() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetPulseWidthNode() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckWaveformTypeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckFrequencyChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckFrequencyNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckPulseWidthChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckPulseWidthNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }
}

public class SignalOscillatorWriter : SignalOscillatorReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalOscillatorWriter() {}

  public SignalOscillatorWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalOscillatorWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalOscillatorWriter(changeEvent.AccessChangeData());
  }

  public static SignalOscillatorWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalOscillatorWriter(changeEvent.AccessChangeData());
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetWaveformType(WaveformType value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetFrequency(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetFrequencyNode(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetPulseWidth(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetPulseWidthNode(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class SignalChannelRouterReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalChannelRouterReader() {}

  public SignalChannelRouterReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public float GetChannelSelect() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetChannelSelectNode() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckChannelSelectChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckChannelSelectNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }
}

public class SignalChannelRouterWriter : SignalChannelRouterReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalChannelRouterWriter() {}

  public SignalChannelRouterWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalChannelRouterWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalChannelRouterWriter(changeEvent.AccessChangeData());
  }

  public static SignalChannelRouterWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalChannelRouterWriter(changeEvent.AccessChangeData());
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetChannelSelect(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetChannelSelectNode(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSrcNode(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class SignalChannelSelectReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalChannelSelectReader() {}

  public SignalChannelSelectReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetChannelIdx() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckChannelIdxChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }
}

public class SignalChannelSelectWriter : SignalChannelSelectReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalChannelSelectWriter() {}

  public SignalChannelSelectWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalChannelSelectWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalChannelSelectWriter(changeEvent.AccessChangeData());
  }

  public static SignalChannelSelectWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalChannelSelectWriter(changeEvent.AccessChangeData());
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetChannelIdx(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetSrcNode(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class SignalChannelStackReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalChannelStackReader() {}

  public SignalChannelStackReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode0() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode1() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode2() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode3() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcNode0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSrcNode1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckSrcNode2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckSrcNode3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }
}

public class SignalChannelStackWriter : SignalChannelStackReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalChannelStackWriter() {}

  public SignalChannelStackWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalChannelStackWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalChannelStackWriter(changeEvent.AccessChangeData());
  }

  public static SignalChannelStackWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalChannelStackWriter(changeEvent.AccessChangeData());
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetSrcNode0(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSrcNode1(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSrcNode2(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSrcNode3(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class SignalCurveReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalCurveReader() {}

  public SignalCurveReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public bool GetSoftCurve() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  public int GetNumSegments() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public float GetStartValue() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetSegmentLength0() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetSegmentEndValue0() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetSegmentLength1() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetSegmentEndValue1() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetSegmentLength2() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetSegmentEndValue2() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetSegmentLength3() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetSegmentEndValue3() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetSegmentLength4() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetSegmentEndValue4() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetSegmentLength5() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetSegmentEndValue5() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetStartEvent() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool GetAutoStart() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  public Xrpa.ObjectUuid GetOnDoneEvent() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool GetAutoLoop() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckSoftCurveChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckNumSegmentsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckStartValueChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckSegmentLength0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckSegmentEndValue0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckSegmentLength1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckSegmentEndValue1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckSegmentLength2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public bool CheckSegmentEndValue2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 512) != 0;
  }

  public bool CheckSegmentLength3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 1024) != 0;
  }

  public bool CheckSegmentEndValue3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 2048) != 0;
  }

  public bool CheckSegmentLength4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 4096) != 0;
  }

  public bool CheckSegmentEndValue4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 8192) != 0;
  }

  public bool CheckSegmentLength5Changed(ulong fieldsChanged) {
    return (fieldsChanged & 16384) != 0;
  }

  public bool CheckSegmentEndValue5Changed(ulong fieldsChanged) {
    return (fieldsChanged & 32768) != 0;
  }

  public bool CheckStartEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & 65536) != 0;
  }

  public bool CheckAutoStartChanged(ulong fieldsChanged) {
    return (fieldsChanged & 131072) != 0;
  }

  public bool CheckOnDoneEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & 262144) != 0;
  }

  public bool CheckAutoLoopChanged(ulong fieldsChanged) {
    return (fieldsChanged & 524288) != 0;
  }
}

public class SignalCurveWriter : SignalCurveReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalCurveWriter() {}

  public SignalCurveWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalCurveWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalCurveWriter(changeEvent.AccessChangeData());
  }

  public static SignalCurveWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalCurveWriter(changeEvent.AccessChangeData());
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetSoftCurve(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetNumSegments(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetStartValue(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSegmentLength0(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSegmentEndValue0(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSegmentLength1(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSegmentEndValue1(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSegmentLength2(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSegmentEndValue2(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSegmentLength3(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSegmentEndValue3(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSegmentLength4(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSegmentEndValue4(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSegmentLength5(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSegmentEndValue5(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetStartEvent(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetAutoStart(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetOnDoneEvent(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetAutoLoop(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }
}

public class SignalDelayReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalDelayReader() {}

  public SignalDelayReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public float GetDelayTimeMs() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckDelayTimeMsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }
}

public class SignalDelayWriter : SignalDelayReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalDelayWriter() {}

  public SignalDelayWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalDelayWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalDelayWriter(changeEvent.AccessChangeData());
  }

  public static SignalDelayWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalDelayWriter(changeEvent.AccessChangeData());
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetSrcNode(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetDelayTimeMs(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class SignalFeedbackReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalFeedbackReader() {}

  public SignalFeedbackReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }
}

public class SignalFeedbackWriter : SignalFeedbackReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalFeedbackWriter() {}

  public SignalFeedbackWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalFeedbackWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalFeedbackWriter(changeEvent.AccessChangeData());
  }

  public static SignalFeedbackWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalFeedbackWriter(changeEvent.AccessChangeData());
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetSrcNode(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class SignalMathOpReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalMathOpReader() {}

  public SignalMathOpReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public MathOperation GetOperation() {
    return (MathOperation)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public float GetOperandA() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetOperandANode() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public float GetOperandB() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetOperandBNode() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckOperationChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckOperandAChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckOperandANodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckOperandBChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckOperandBNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }
}

public class SignalMathOpWriter : SignalMathOpReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalMathOpWriter() {}

  public SignalMathOpWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalMathOpWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalMathOpWriter(changeEvent.AccessChangeData());
  }

  public static SignalMathOpWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalMathOpWriter(changeEvent.AccessChangeData());
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetOperation(MathOperation value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetOperandA(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetOperandANode(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetOperandB(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetOperandBNode(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class SignalMultiplexerReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalMultiplexerReader() {}

  public SignalMultiplexerReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode0() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode1() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode2() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode3() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode4() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode5() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetIncrementEvent() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public Xrpa.ObjectUuid GetStartEvent() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool GetAutoStart() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  public Xrpa.ObjectUuid GetOnDoneEvent() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcNode0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSrcNode1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckSrcNode2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckSrcNode3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckSrcNode4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckSrcNode5Changed(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckIncrementEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public bool CheckStartEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & 512) != 0;
  }

  public bool CheckAutoStartChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1024) != 0;
  }

  public bool CheckOnDoneEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2048) != 0;
  }
}

public class SignalMultiplexerWriter : SignalMultiplexerReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalMultiplexerWriter() {}

  public SignalMultiplexerWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalMultiplexerWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalMultiplexerWriter(changeEvent.AccessChangeData());
  }

  public static SignalMultiplexerWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalMultiplexerWriter(changeEvent.AccessChangeData());
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetSrcNode0(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSrcNode1(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSrcNode2(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSrcNode3(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSrcNode4(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSrcNode5(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetIncrementEvent(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetStartEvent(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetAutoStart(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetOnDoneEvent(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class SignalParametricEqualizerReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalParametricEqualizerReader() {}

  public SignalParametricEqualizerReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public FilterType GetFilterType0() {
    return (FilterType)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public float GetFrequency0() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetQuality0() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetGain0() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public FilterType GetFilterType1() {
    return (FilterType)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public float GetFrequency1() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetQuality1() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetGain1() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public FilterType GetFilterType2() {
    return (FilterType)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public float GetFrequency2() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetQuality2() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetGain2() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public FilterType GetFilterType3() {
    return (FilterType)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public float GetFrequency3() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetQuality3() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetGain3() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public FilterType GetFilterType4() {
    return (FilterType)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public float GetFrequency4() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetQuality4() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetGain4() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public float GetGainAdjust() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckFilterType0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckFrequency0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckQuality0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckGain0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckFilterType1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckFrequency1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public bool CheckQuality1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 512) != 0;
  }

  public bool CheckGain1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 1024) != 0;
  }

  public bool CheckFilterType2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 2048) != 0;
  }

  public bool CheckFrequency2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 4096) != 0;
  }

  public bool CheckQuality2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 8192) != 0;
  }

  public bool CheckGain2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 16384) != 0;
  }

  public bool CheckFilterType3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 32768) != 0;
  }

  public bool CheckFrequency3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 65536) != 0;
  }

  public bool CheckQuality3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 131072) != 0;
  }

  public bool CheckGain3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 262144) != 0;
  }

  public bool CheckFilterType4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 524288) != 0;
  }

  public bool CheckFrequency4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 1048576) != 0;
  }

  public bool CheckQuality4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 2097152) != 0;
  }

  public bool CheckGain4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 4194304) != 0;
  }

  public bool CheckGainAdjustChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8388608) != 0;
  }
}

public class SignalParametricEqualizerWriter : SignalParametricEqualizerReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalParametricEqualizerWriter() {}

  public SignalParametricEqualizerWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalParametricEqualizerWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalParametricEqualizerWriter(changeEvent.AccessChangeData());
  }

  public static SignalParametricEqualizerWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalParametricEqualizerWriter(changeEvent.AccessChangeData());
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetSrcNode(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetFilterType0(FilterType value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetFrequency0(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetQuality0(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetGain0(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetFilterType1(FilterType value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetFrequency1(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetQuality1(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetGain1(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetFilterType2(FilterType value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetFrequency2(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetQuality2(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetGain2(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetFilterType3(FilterType value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetFrequency3(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetQuality3(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetGain3(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetFilterType4(FilterType value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetFrequency4(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetQuality4(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetGain4(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetGainAdjust(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class SignalPitchShiftReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalPitchShiftReader() {}

  public SignalPitchShiftReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public int GetPitchShiftSemitones() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckPitchShiftSemitonesChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }
}

public class SignalPitchShiftWriter : SignalPitchShiftReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalPitchShiftWriter() {}

  public SignalPitchShiftWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalPitchShiftWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalPitchShiftWriter(changeEvent.AccessChangeData());
  }

  public static SignalPitchShiftWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalPitchShiftWriter(changeEvent.AccessChangeData());
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetSrcNode(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetPitchShiftSemitones(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }
}

public class SignalSoftClipReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalSoftClipReader() {}

  public SignalSoftClipReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetNumOutputs() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }
}

public class SignalSoftClipWriter : SignalSoftClipReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalSoftClipWriter() {}

  public SignalSoftClipWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalSoftClipWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalSoftClipWriter(changeEvent.AccessChangeData());
  }

  public static SignalSoftClipWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalSoftClipWriter(changeEvent.AccessChangeData());
  }

  public void SetNumOutputs(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetSrcNode(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class SignalOutputDataReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalOutputDataReader() {}

  public SignalOutputDataReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetFrameRate() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckFrameRateChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }
}

public class SignalOutputDataWriter : SignalOutputDataReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalOutputDataWriter() {}

  public SignalOutputDataWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalOutputDataWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalOutputDataWriter(changeEvent.AccessChangeData());
  }

  public static SignalOutputDataWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalOutputDataWriter(changeEvent.AccessChangeData());
  }

  public void SetSrcNode(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetFrameRate(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }
}

public class SignalOutputDeviceReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SignalOutputDeviceReader() {}

  public SignalOutputDeviceReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public int GetChannelOffset() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // pseudo-regex, with just $ and ^ supported for now
  public string GetDeviceNameFilter() {
    return _memAccessor.ReadString(_readOffset);
  }

  public bool GetOutputToSystemAudio() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  // Set to true if a matching device was found
  public bool GetFoundMatch() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckChannelOffsetChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckDeviceNameFilterChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckOutputToSystemAudioChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckFoundMatchChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }
}

public class SignalOutputDeviceWriter : SignalOutputDeviceReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SignalOutputDeviceWriter() {}

  public SignalOutputDeviceWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SignalOutputDeviceWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SignalOutputDeviceWriter(changeEvent.AccessChangeData());
  }

  public static SignalOutputDeviceWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SignalOutputDeviceWriter(changeEvent.AccessChangeData());
  }

  public void SetSrcNode(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetChannelOffset(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetDeviceNameFilter(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetOutputToSystemAudio(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetFoundMatch(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }
}

// Reconciled Types
public abstract class ISignalNode : Xrpa.DataStoreObject, Xrpa.IDataStoreObject {
  public ISignalNode(Xrpa.ObjectUuid id, Xrpa.IObjectCollection collection) : base(id, collection) {}
}

public class OutboundSignalEvent : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<SignalEventReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  private System.Action<ulong, ReceiveEventMessageReader> _receiveEventMessageHandler = null;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalEvent(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalEventWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 0;
      _changeByteCount = 0;
      objAccessor = SignalEventWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalEventWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 0;
    _changeByteCount = 0;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalEventReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public void SendTriggerEvent(float payload) {
    TriggerEventMessageWriter message = new(_collection.SendMessage(
        GetXrpaId(),
        0,
        4));
    message.SetPayload(payload);
  }

  public void OnReceiveEvent(System.Action<ulong, ReceiveEventMessageReader> handler) {
    _receiveEventMessageHandler = handler;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
    if (messageType == 1) {
      ReceiveEventMessageReader message = new(messageData);
      _receiveEventMessageHandler?.Invoke(msgTimestamp, message);
    }
  }
}

public class OutboundSignalEventCombiner : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<SignalEventCombinerReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  protected Xrpa.ObjectUuid _localSrcEvent0 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localSrcEvent1 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localSrcEvent2 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localSrcEvent3 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localSrcEvent4 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localSrcEvent5 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected ParameterMode _localParameterMode = ParameterMode.Passthrough;
  protected Xrpa.ObjectUuid _localOnEvent = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalEventCombiner(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public Xrpa.ObjectUuid GetSrcEvent0() {
    return _localSrcEvent0;
  }

  public void SetSrcEvent0(Xrpa.ObjectUuid srcEvent0) {
    _localSrcEvent0 = srcEvent0;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public Xrpa.ObjectUuid GetSrcEvent1() {
    return _localSrcEvent1;
  }

  public void SetSrcEvent1(Xrpa.ObjectUuid srcEvent1) {
    _localSrcEvent1 = srcEvent1;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public Xrpa.ObjectUuid GetSrcEvent2() {
    return _localSrcEvent2;
  }

  public void SetSrcEvent2(Xrpa.ObjectUuid srcEvent2) {
    _localSrcEvent2 = srcEvent2;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public Xrpa.ObjectUuid GetSrcEvent3() {
    return _localSrcEvent3;
  }

  public void SetSrcEvent3(Xrpa.ObjectUuid srcEvent3) {
    _localSrcEvent3 = srcEvent3;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public Xrpa.ObjectUuid GetSrcEvent4() {
    return _localSrcEvent4;
  }

  public void SetSrcEvent4(Xrpa.ObjectUuid srcEvent4) {
    _localSrcEvent4 = srcEvent4;
    if ((_changeBits & 16) == 0) {
      _changeBits |= 16;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 16);
    }
  }

  public Xrpa.ObjectUuid GetSrcEvent5() {
    return _localSrcEvent5;
  }

  public void SetSrcEvent5(Xrpa.ObjectUuid srcEvent5) {
    _localSrcEvent5 = srcEvent5;
    if ((_changeBits & 32) == 0) {
      _changeBits |= 32;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 32);
    }
  }

  public ParameterMode GetParameterMode() {
    return _localParameterMode;
  }

  public void SetParameterMode(ParameterMode parameterMode) {
    _localParameterMode = parameterMode;
    if ((_changeBits & 64) == 0) {
      _changeBits |= 64;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 64);
    }
  }

  public Xrpa.ObjectUuid GetOnEvent() {
    return _localOnEvent;
  }

  public void SetOnEvent(Xrpa.ObjectUuid onEvent) {
    _localOnEvent = onEvent;
    if ((_changeBits & 128) == 0) {
      _changeBits |= 128;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 128);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalEventCombinerWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 255;
      _changeByteCount = 116;
      objAccessor = SignalEventCombinerWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalEventCombinerWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetSrcEvent0(_localSrcEvent0);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetSrcEvent1(_localSrcEvent1);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetSrcEvent2(_localSrcEvent2);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetSrcEvent3(_localSrcEvent3);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetSrcEvent4(_localSrcEvent4);
    }
    if ((_changeBits & 32) != 0) {
      objAccessor.SetSrcEvent5(_localSrcEvent5);
    }
    if ((_changeBits & 64) != 0) {
      objAccessor.SetParameterMode(_localParameterMode);
    }
    if ((_changeBits & 128) != 0) {
      objAccessor.SetOnEvent(_localOnEvent);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 255;
    _changeByteCount = 116;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalEventCombinerReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckSrcEvent0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckSrcEvent1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcEvent2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSrcEvent3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckSrcEvent4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckSrcEvent5Changed(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckParameterModeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckOnEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalSource : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalSourceReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  private Xrpa.OutboundSignalData _localSrcData = new Xrpa.OutboundSignalData();
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalSource(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalSourceWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 3;
      _changeByteCount = 8;
      objAccessor = SignalSourceWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalSourceWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 3;
    _changeByteCount = 8;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalSourceReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public void SetSrcDataCallback<SampleType>(Xrpa.SignalProducerCallback<SampleType> signalCallback, int numChannels, int framesPerSecond, int framesPerPacket) where SampleType : unmanaged  {
    _localSrcData.SetSignalSource(signalCallback, numChannels, framesPerSecond, framesPerPacket);
  }

  public void SetSrcDataRingBuffer<SampleType>(Xrpa.SignalRingBuffer<SampleType> signalRingBuffer, int numChannels, int framesPerSecond, int framesPerPacket) where SampleType : unmanaged  {
    _localSrcData.SetSignalSource(signalRingBuffer, numChannels, framesPerSecond, framesPerPacket);
  }

  public void SetSrcDataForwarder<SampleType>(Xrpa.InboundSignalForwarder signalForwarder) where SampleType : unmanaged  {
    _localSrcData.SetRecipient(GetXrpaId(), _collection, 2);
    signalForwarder.AddRecipient(_localSrcData);
  }

  public Xrpa.SignalPacket SendSrcData<SampleType>(int frameCount, int numChannels, int framesPerSecond) where SampleType : unmanaged  {
    int sampleType = Xrpa.SignalTypeInference.InferSampleType<SampleType>();
    _localSrcData.SetRecipient(GetXrpaId(), _collection, 2);
    return _localSrcData.SendSignalPacket(Xrpa.MemoryUtils.GetTypeSize<SampleType>(), frameCount, sampleType, numChannels, framesPerSecond);
  }

  public void TickXrpa() {
    var id = GetXrpaId();
    _localSrcData.SetRecipient(id, _collection, 2);
    _localSrcData.Tick();
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalSourceFile : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalSourceFileReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  protected int _localNumOutputs = 1;
  protected string _localFilePath = "";
  protected bool _localAutoPlay = true;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalSourceFile(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public string GetFilePath() {
    return _localFilePath;
  }

  public void SetFilePath(string filePath) {
    _localFilePath = filePath;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localFilePath);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public bool GetAutoPlay() {
    return _localAutoPlay;
  }

  public void SetAutoPlay(bool autoPlay) {
    _localAutoPlay = autoPlay;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalSourceFileWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 7;
      _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localFilePath) + 12;
      objAccessor = SignalSourceFileWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalSourceFileWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetFilePath(_localFilePath);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetAutoPlay(_localAutoPlay);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 7;
    _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localFilePath) + 12;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalSourceFileReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckFilePathChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckAutoPlayChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalOscillator : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalOscillatorReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected WaveformType _localWaveformType = WaveformType.Sawtooth;
  protected float _localFrequency = 440f;
  protected Xrpa.ObjectUuid _localFrequencyNode = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected float _localPulseWidth = 0.5f;
  protected Xrpa.ObjectUuid _localPulseWidthNode = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalOscillator(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public WaveformType GetWaveformType() {
    return _localWaveformType;
  }

  public void SetWaveformType(WaveformType waveformType) {
    _localWaveformType = waveformType;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public float GetFrequency() {
    return _localFrequency;
  }

  public void SetFrequency(float frequency) {
    _localFrequency = frequency;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public Xrpa.ObjectUuid GetFrequencyNode() {
    return _localFrequencyNode;
  }

  public void SetFrequencyNode(Xrpa.ObjectUuid frequencyNode) {
    _localFrequencyNode = frequencyNode;
    if ((_changeBits & 16) == 0) {
      _changeBits |= 16;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 16);
    }
  }

  public float GetPulseWidth() {
    return _localPulseWidth;
  }

  public void SetPulseWidth(float pulseWidth) {
    _localPulseWidth = pulseWidth;
    if ((_changeBits & 32) == 0) {
      _changeBits |= 32;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 32);
    }
  }

  public Xrpa.ObjectUuid GetPulseWidthNode() {
    return _localPulseWidthNode;
  }

  public void SetPulseWidthNode(Xrpa.ObjectUuid pulseWidthNode) {
    _localPulseWidthNode = pulseWidthNode;
    if ((_changeBits & 64) == 0) {
      _changeBits |= 64;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 64);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalOscillatorWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 127;
      _changeByteCount = 52;
      objAccessor = SignalOscillatorWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalOscillatorWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetWaveformType(_localWaveformType);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetFrequency(_localFrequency);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetFrequencyNode(_localFrequencyNode);
    }
    if ((_changeBits & 32) != 0) {
      objAccessor.SetPulseWidth(_localPulseWidth);
    }
    if ((_changeBits & 64) != 0) {
      objAccessor.SetPulseWidthNode(_localPulseWidthNode);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 127;
    _changeByteCount = 52;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalOscillatorReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckWaveformTypeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckFrequencyChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckFrequencyNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckPulseWidthChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckPulseWidthNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalChannelRouter : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalChannelRouterReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected float _localChannelSelect = 0.5f;
  protected Xrpa.ObjectUuid _localChannelSelectNode = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localSrcNode = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalChannelRouter(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public float GetChannelSelect() {
    return _localChannelSelect;
  }

  public void SetChannelSelect(float channelSelect) {
    _localChannelSelect = channelSelect;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public Xrpa.ObjectUuid GetChannelSelectNode() {
    return _localChannelSelectNode;
  }

  public void SetChannelSelectNode(Xrpa.ObjectUuid channelSelectNode) {
    _localChannelSelectNode = channelSelectNode;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return _localSrcNode;
  }

  public void SetSrcNode(Xrpa.ObjectUuid srcNode) {
    _localSrcNode = srcNode;
    if ((_changeBits & 16) == 0) {
      _changeBits |= 16;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 16);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalChannelRouterWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 31;
      _changeByteCount = 44;
      objAccessor = SignalChannelRouterWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalChannelRouterWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetChannelSelect(_localChannelSelect);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetChannelSelectNode(_localChannelSelectNode);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 31;
    _changeByteCount = 44;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalChannelRouterReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckChannelSelectChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckChannelSelectNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalChannelSelect : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalChannelSelectReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected int _localChannelIdx = 0;
  protected Xrpa.ObjectUuid _localSrcNode = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalChannelSelect(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public int GetChannelIdx() {
    return _localChannelIdx;
  }

  public void SetChannelIdx(int channelIdx) {
    _localChannelIdx = channelIdx;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return _localSrcNode;
  }

  public void SetSrcNode(Xrpa.ObjectUuid srcNode) {
    _localSrcNode = srcNode;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalChannelSelectWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 15;
      _changeByteCount = 28;
      objAccessor = SignalChannelSelectWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalChannelSelectWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetChannelIdx(_localChannelIdx);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 15;
    _changeByteCount = 28;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalChannelSelectReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckChannelIdxChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalChannelStack : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalChannelStackReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected Xrpa.ObjectUuid _localSrcNode0 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localSrcNode1 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localSrcNode2 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localSrcNode3 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalChannelStack(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode0() {
    return _localSrcNode0;
  }

  public void SetSrcNode0(Xrpa.ObjectUuid srcNode0) {
    _localSrcNode0 = srcNode0;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode1() {
    return _localSrcNode1;
  }

  public void SetSrcNode1(Xrpa.ObjectUuid srcNode1) {
    _localSrcNode1 = srcNode1;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode2() {
    return _localSrcNode2;
  }

  public void SetSrcNode2(Xrpa.ObjectUuid srcNode2) {
    _localSrcNode2 = srcNode2;
    if ((_changeBits & 16) == 0) {
      _changeBits |= 16;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 16);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode3() {
    return _localSrcNode3;
  }

  public void SetSrcNode3(Xrpa.ObjectUuid srcNode3) {
    _localSrcNode3 = srcNode3;
    if ((_changeBits & 32) == 0) {
      _changeBits |= 32;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 32);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalChannelStackWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 63;
      _changeByteCount = 72;
      objAccessor = SignalChannelStackWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalChannelStackWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetSrcNode0(_localSrcNode0);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetSrcNode1(_localSrcNode1);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetSrcNode2(_localSrcNode2);
    }
    if ((_changeBits & 32) != 0) {
      objAccessor.SetSrcNode3(_localSrcNode3);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 63;
    _changeByteCount = 72;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalChannelStackReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcNode0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSrcNode1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckSrcNode2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckSrcNode3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalCurve : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalCurveReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
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
  protected Xrpa.ObjectUuid _localStartEvent = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected bool _localAutoStart = true;
  protected Xrpa.ObjectUuid _localOnDoneEvent = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected bool _localAutoLoop = false;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalCurve(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public bool GetSoftCurve() {
    return _localSoftCurve;
  }

  public void SetSoftCurve(bool softCurve) {
    _localSoftCurve = softCurve;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public int GetNumSegments() {
    return _localNumSegments;
  }

  public void SetNumSegments(int numSegments) {
    _localNumSegments = numSegments;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public float GetStartValue() {
    return _localStartValue;
  }

  public void SetStartValue(float startValue) {
    _localStartValue = startValue;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public float GetSegmentLength0() {
    return _localSegmentLength0;
  }

  public void SetSegmentLength0(float segmentLength0) {
    _localSegmentLength0 = segmentLength0;
    if ((_changeBits & 16) == 0) {
      _changeBits |= 16;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 16);
    }
  }

  public float GetSegmentEndValue0() {
    return _localSegmentEndValue0;
  }

  public void SetSegmentEndValue0(float segmentEndValue0) {
    _localSegmentEndValue0 = segmentEndValue0;
    if ((_changeBits & 32) == 0) {
      _changeBits |= 32;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 32);
    }
  }

  public float GetSegmentLength1() {
    return _localSegmentLength1;
  }

  public void SetSegmentLength1(float segmentLength1) {
    _localSegmentLength1 = segmentLength1;
    if ((_changeBits & 64) == 0) {
      _changeBits |= 64;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 64);
    }
  }

  public float GetSegmentEndValue1() {
    return _localSegmentEndValue1;
  }

  public void SetSegmentEndValue1(float segmentEndValue1) {
    _localSegmentEndValue1 = segmentEndValue1;
    if ((_changeBits & 128) == 0) {
      _changeBits |= 128;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 128);
    }
  }

  public float GetSegmentLength2() {
    return _localSegmentLength2;
  }

  public void SetSegmentLength2(float segmentLength2) {
    _localSegmentLength2 = segmentLength2;
    if ((_changeBits & 256) == 0) {
      _changeBits |= 256;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 256);
    }
  }

  public float GetSegmentEndValue2() {
    return _localSegmentEndValue2;
  }

  public void SetSegmentEndValue2(float segmentEndValue2) {
    _localSegmentEndValue2 = segmentEndValue2;
    if ((_changeBits & 512) == 0) {
      _changeBits |= 512;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 512);
    }
  }

  public float GetSegmentLength3() {
    return _localSegmentLength3;
  }

  public void SetSegmentLength3(float segmentLength3) {
    _localSegmentLength3 = segmentLength3;
    if ((_changeBits & 1024) == 0) {
      _changeBits |= 1024;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1024);
    }
  }

  public float GetSegmentEndValue3() {
    return _localSegmentEndValue3;
  }

  public void SetSegmentEndValue3(float segmentEndValue3) {
    _localSegmentEndValue3 = segmentEndValue3;
    if ((_changeBits & 2048) == 0) {
      _changeBits |= 2048;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2048);
    }
  }

  public float GetSegmentLength4() {
    return _localSegmentLength4;
  }

  public void SetSegmentLength4(float segmentLength4) {
    _localSegmentLength4 = segmentLength4;
    if ((_changeBits & 4096) == 0) {
      _changeBits |= 4096;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4096);
    }
  }

  public float GetSegmentEndValue4() {
    return _localSegmentEndValue4;
  }

  public void SetSegmentEndValue4(float segmentEndValue4) {
    _localSegmentEndValue4 = segmentEndValue4;
    if ((_changeBits & 8192) == 0) {
      _changeBits |= 8192;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8192);
    }
  }

  public float GetSegmentLength5() {
    return _localSegmentLength5;
  }

  public void SetSegmentLength5(float segmentLength5) {
    _localSegmentLength5 = segmentLength5;
    if ((_changeBits & 16384) == 0) {
      _changeBits |= 16384;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 16384);
    }
  }

  public float GetSegmentEndValue5() {
    return _localSegmentEndValue5;
  }

  public void SetSegmentEndValue5(float segmentEndValue5) {
    _localSegmentEndValue5 = segmentEndValue5;
    if ((_changeBits & 32768) == 0) {
      _changeBits |= 32768;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 32768);
    }
  }

  public Xrpa.ObjectUuid GetStartEvent() {
    return _localStartEvent;
  }

  public void SetStartEvent(Xrpa.ObjectUuid startEvent) {
    _localStartEvent = startEvent;
    if ((_changeBits & 65536) == 0) {
      _changeBits |= 65536;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 65536);
    }
  }

  public bool GetAutoStart() {
    return _localAutoStart;
  }

  public void SetAutoStart(bool autoStart) {
    _localAutoStart = autoStart;
    if ((_changeBits & 131072) == 0) {
      _changeBits |= 131072;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 131072);
    }
  }

  public Xrpa.ObjectUuid GetOnDoneEvent() {
    return _localOnDoneEvent;
  }

  public void SetOnDoneEvent(Xrpa.ObjectUuid onDoneEvent) {
    _localOnDoneEvent = onDoneEvent;
    if ((_changeBits & 262144) == 0) {
      _changeBits |= 262144;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 262144);
    }
  }

  public bool GetAutoLoop() {
    return _localAutoLoop;
  }

  public void SetAutoLoop(bool autoLoop) {
    _localAutoLoop = autoLoop;
    if ((_changeBits & 524288) == 0) {
      _changeBits |= 524288;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 524288);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalCurveWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 1048575;
      _changeByteCount = 104;
      objAccessor = SignalCurveWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalCurveWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetSoftCurve(_localSoftCurve);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetNumSegments(_localNumSegments);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetStartValue(_localStartValue);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetSegmentLength0(_localSegmentLength0);
    }
    if ((_changeBits & 32) != 0) {
      objAccessor.SetSegmentEndValue0(_localSegmentEndValue0);
    }
    if ((_changeBits & 64) != 0) {
      objAccessor.SetSegmentLength1(_localSegmentLength1);
    }
    if ((_changeBits & 128) != 0) {
      objAccessor.SetSegmentEndValue1(_localSegmentEndValue1);
    }
    if ((_changeBits & 256) != 0) {
      objAccessor.SetSegmentLength2(_localSegmentLength2);
    }
    if ((_changeBits & 512) != 0) {
      objAccessor.SetSegmentEndValue2(_localSegmentEndValue2);
    }
    if ((_changeBits & 1024) != 0) {
      objAccessor.SetSegmentLength3(_localSegmentLength3);
    }
    if ((_changeBits & 2048) != 0) {
      objAccessor.SetSegmentEndValue3(_localSegmentEndValue3);
    }
    if ((_changeBits & 4096) != 0) {
      objAccessor.SetSegmentLength4(_localSegmentLength4);
    }
    if ((_changeBits & 8192) != 0) {
      objAccessor.SetSegmentEndValue4(_localSegmentEndValue4);
    }
    if ((_changeBits & 16384) != 0) {
      objAccessor.SetSegmentLength5(_localSegmentLength5);
    }
    if ((_changeBits & 32768) != 0) {
      objAccessor.SetSegmentEndValue5(_localSegmentEndValue5);
    }
    if ((_changeBits & 65536) != 0) {
      objAccessor.SetStartEvent(_localStartEvent);
    }
    if ((_changeBits & 131072) != 0) {
      objAccessor.SetAutoStart(_localAutoStart);
    }
    if ((_changeBits & 262144) != 0) {
      objAccessor.SetOnDoneEvent(_localOnDoneEvent);
    }
    if ((_changeBits & 524288) != 0) {
      objAccessor.SetAutoLoop(_localAutoLoop);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 1048575;
    _changeByteCount = 104;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalCurveReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckSoftCurveChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckNumSegmentsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckStartValueChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckSegmentLength0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckSegmentEndValue0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckSegmentLength1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckSegmentEndValue1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckSegmentLength2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public bool CheckSegmentEndValue2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 512) != 0;
  }

  public bool CheckSegmentLength3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 1024) != 0;
  }

  public bool CheckSegmentEndValue3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 2048) != 0;
  }

  public bool CheckSegmentLength4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 4096) != 0;
  }

  public bool CheckSegmentEndValue4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 8192) != 0;
  }

  public bool CheckSegmentLength5Changed(ulong fieldsChanged) {
    return (fieldsChanged & 16384) != 0;
  }

  public bool CheckSegmentEndValue5Changed(ulong fieldsChanged) {
    return (fieldsChanged & 32768) != 0;
  }

  public bool CheckStartEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & 65536) != 0;
  }

  public bool CheckAutoStartChanged(ulong fieldsChanged) {
    return (fieldsChanged & 131072) != 0;
  }

  public bool CheckOnDoneEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & 262144) != 0;
  }

  public bool CheckAutoLoopChanged(ulong fieldsChanged) {
    return (fieldsChanged & 524288) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalDelay : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalDelayReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected Xrpa.ObjectUuid _localSrcNode = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected float _localDelayTimeMs = 1f;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalDelay(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return _localSrcNode;
  }

  public void SetSrcNode(Xrpa.ObjectUuid srcNode) {
    _localSrcNode = srcNode;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public float GetDelayTimeMs() {
    return _localDelayTimeMs;
  }

  public void SetDelayTimeMs(float delayTimeMs) {
    _localDelayTimeMs = delayTimeMs;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalDelayWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 15;
      _changeByteCount = 28;
      objAccessor = SignalDelayWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalDelayWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetDelayTimeMs(_localDelayTimeMs);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 15;
    _changeByteCount = 28;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalDelayReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckDelayTimeMsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalFeedback : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalFeedbackReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected Xrpa.ObjectUuid _localSrcNode = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalFeedback(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return _localSrcNode;
  }

  public void SetSrcNode(Xrpa.ObjectUuid srcNode) {
    _localSrcNode = srcNode;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalFeedbackWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 7;
      _changeByteCount = 24;
      objAccessor = SignalFeedbackWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalFeedbackWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 7;
    _changeByteCount = 24;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalFeedbackReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalMathOp : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalMathOpReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected MathOperation _localOperation = MathOperation.Add;
  protected float _localOperandA = 1f;
  protected Xrpa.ObjectUuid _localOperandANode = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected float _localOperandB = 1f;
  protected Xrpa.ObjectUuid _localOperandBNode = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalMathOp(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public MathOperation GetOperation() {
    return _localOperation;
  }

  public void SetOperation(MathOperation operation) {
    _localOperation = operation;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public float GetOperandA() {
    return _localOperandA;
  }

  public void SetOperandA(float operandA) {
    _localOperandA = operandA;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public Xrpa.ObjectUuid GetOperandANode() {
    return _localOperandANode;
  }

  public void SetOperandANode(Xrpa.ObjectUuid operandANode) {
    _localOperandANode = operandANode;
    if ((_changeBits & 16) == 0) {
      _changeBits |= 16;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 16);
    }
  }

  public float GetOperandB() {
    return _localOperandB;
  }

  public void SetOperandB(float operandB) {
    _localOperandB = operandB;
    if ((_changeBits & 32) == 0) {
      _changeBits |= 32;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 32);
    }
  }

  public Xrpa.ObjectUuid GetOperandBNode() {
    return _localOperandBNode;
  }

  public void SetOperandBNode(Xrpa.ObjectUuid operandBNode) {
    _localOperandBNode = operandBNode;
    if ((_changeBits & 64) == 0) {
      _changeBits |= 64;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 64);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalMathOpWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 127;
      _changeByteCount = 52;
      objAccessor = SignalMathOpWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalMathOpWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetOperation(_localOperation);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetOperandA(_localOperandA);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetOperandANode(_localOperandANode);
    }
    if ((_changeBits & 32) != 0) {
      objAccessor.SetOperandB(_localOperandB);
    }
    if ((_changeBits & 64) != 0) {
      objAccessor.SetOperandBNode(_localOperandBNode);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 127;
    _changeByteCount = 52;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalMathOpReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckOperationChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckOperandAChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckOperandANodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckOperandBChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckOperandBNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalMultiplexer : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalMultiplexerReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected Xrpa.ObjectUuid _localSrcNode0 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localSrcNode1 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localSrcNode2 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localSrcNode3 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localSrcNode4 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localSrcNode5 = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localIncrementEvent = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected Xrpa.ObjectUuid _localStartEvent = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected bool _localAutoStart = true;
  protected Xrpa.ObjectUuid _localOnDoneEvent = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalMultiplexer(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode0() {
    return _localSrcNode0;
  }

  public void SetSrcNode0(Xrpa.ObjectUuid srcNode0) {
    _localSrcNode0 = srcNode0;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode1() {
    return _localSrcNode1;
  }

  public void SetSrcNode1(Xrpa.ObjectUuid srcNode1) {
    _localSrcNode1 = srcNode1;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode2() {
    return _localSrcNode2;
  }

  public void SetSrcNode2(Xrpa.ObjectUuid srcNode2) {
    _localSrcNode2 = srcNode2;
    if ((_changeBits & 16) == 0) {
      _changeBits |= 16;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 16);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode3() {
    return _localSrcNode3;
  }

  public void SetSrcNode3(Xrpa.ObjectUuid srcNode3) {
    _localSrcNode3 = srcNode3;
    if ((_changeBits & 32) == 0) {
      _changeBits |= 32;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 32);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode4() {
    return _localSrcNode4;
  }

  public void SetSrcNode4(Xrpa.ObjectUuid srcNode4) {
    _localSrcNode4 = srcNode4;
    if ((_changeBits & 64) == 0) {
      _changeBits |= 64;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 64);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode5() {
    return _localSrcNode5;
  }

  public void SetSrcNode5(Xrpa.ObjectUuid srcNode5) {
    _localSrcNode5 = srcNode5;
    if ((_changeBits & 128) == 0) {
      _changeBits |= 128;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 128);
    }
  }

  public Xrpa.ObjectUuid GetIncrementEvent() {
    return _localIncrementEvent;
  }

  public void SetIncrementEvent(Xrpa.ObjectUuid incrementEvent) {
    _localIncrementEvent = incrementEvent;
    if ((_changeBits & 256) == 0) {
      _changeBits |= 256;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 256);
    }
  }

  public Xrpa.ObjectUuid GetStartEvent() {
    return _localStartEvent;
  }

  public void SetStartEvent(Xrpa.ObjectUuid startEvent) {
    _localStartEvent = startEvent;
    if ((_changeBits & 512) == 0) {
      _changeBits |= 512;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 512);
    }
  }

  public bool GetAutoStart() {
    return _localAutoStart;
  }

  public void SetAutoStart(bool autoStart) {
    _localAutoStart = autoStart;
    if ((_changeBits & 1024) == 0) {
      _changeBits |= 1024;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1024);
    }
  }

  public Xrpa.ObjectUuid GetOnDoneEvent() {
    return _localOnDoneEvent;
  }

  public void SetOnDoneEvent(Xrpa.ObjectUuid onDoneEvent) {
    _localOnDoneEvent = onDoneEvent;
    if ((_changeBits & 2048) == 0) {
      _changeBits |= 2048;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2048);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalMultiplexerWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 4095;
      _changeByteCount = 156;
      objAccessor = SignalMultiplexerWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalMultiplexerWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetSrcNode0(_localSrcNode0);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetSrcNode1(_localSrcNode1);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetSrcNode2(_localSrcNode2);
    }
    if ((_changeBits & 32) != 0) {
      objAccessor.SetSrcNode3(_localSrcNode3);
    }
    if ((_changeBits & 64) != 0) {
      objAccessor.SetSrcNode4(_localSrcNode4);
    }
    if ((_changeBits & 128) != 0) {
      objAccessor.SetSrcNode5(_localSrcNode5);
    }
    if ((_changeBits & 256) != 0) {
      objAccessor.SetIncrementEvent(_localIncrementEvent);
    }
    if ((_changeBits & 512) != 0) {
      objAccessor.SetStartEvent(_localStartEvent);
    }
    if ((_changeBits & 1024) != 0) {
      objAccessor.SetAutoStart(_localAutoStart);
    }
    if ((_changeBits & 2048) != 0) {
      objAccessor.SetOnDoneEvent(_localOnDoneEvent);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 4095;
    _changeByteCount = 156;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalMultiplexerReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcNode0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSrcNode1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckSrcNode2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckSrcNode3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckSrcNode4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckSrcNode5Changed(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckIncrementEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public bool CheckStartEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & 512) != 0;
  }

  public bool CheckAutoStartChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1024) != 0;
  }

  public bool CheckOnDoneEventChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2048) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalParametricEqualizer : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalParametricEqualizerReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected Xrpa.ObjectUuid _localSrcNode = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
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
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalParametricEqualizer(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return _localSrcNode;
  }

  public void SetSrcNode(Xrpa.ObjectUuid srcNode) {
    _localSrcNode = srcNode;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public FilterType GetFilterType0() {
    return _localFilterType0;
  }

  public void SetFilterType0(FilterType filterType0) {
    _localFilterType0 = filterType0;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public float GetFrequency0() {
    return _localFrequency0;
  }

  public void SetFrequency0(float frequency0) {
    _localFrequency0 = frequency0;
    if ((_changeBits & 16) == 0) {
      _changeBits |= 16;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 16);
    }
  }

  public float GetQuality0() {
    return _localQuality0;
  }

  public void SetQuality0(float quality0) {
    _localQuality0 = quality0;
    if ((_changeBits & 32) == 0) {
      _changeBits |= 32;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 32);
    }
  }

  public float GetGain0() {
    return _localGain0;
  }

  public void SetGain0(float gain0) {
    _localGain0 = gain0;
    if ((_changeBits & 64) == 0) {
      _changeBits |= 64;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 64);
    }
  }

  public FilterType GetFilterType1() {
    return _localFilterType1;
  }

  public void SetFilterType1(FilterType filterType1) {
    _localFilterType1 = filterType1;
    if ((_changeBits & 128) == 0) {
      _changeBits |= 128;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 128);
    }
  }

  public float GetFrequency1() {
    return _localFrequency1;
  }

  public void SetFrequency1(float frequency1) {
    _localFrequency1 = frequency1;
    if ((_changeBits & 256) == 0) {
      _changeBits |= 256;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 256);
    }
  }

  public float GetQuality1() {
    return _localQuality1;
  }

  public void SetQuality1(float quality1) {
    _localQuality1 = quality1;
    if ((_changeBits & 512) == 0) {
      _changeBits |= 512;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 512);
    }
  }

  public float GetGain1() {
    return _localGain1;
  }

  public void SetGain1(float gain1) {
    _localGain1 = gain1;
    if ((_changeBits & 1024) == 0) {
      _changeBits |= 1024;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1024);
    }
  }

  public FilterType GetFilterType2() {
    return _localFilterType2;
  }

  public void SetFilterType2(FilterType filterType2) {
    _localFilterType2 = filterType2;
    if ((_changeBits & 2048) == 0) {
      _changeBits |= 2048;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2048);
    }
  }

  public float GetFrequency2() {
    return _localFrequency2;
  }

  public void SetFrequency2(float frequency2) {
    _localFrequency2 = frequency2;
    if ((_changeBits & 4096) == 0) {
      _changeBits |= 4096;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4096);
    }
  }

  public float GetQuality2() {
    return _localQuality2;
  }

  public void SetQuality2(float quality2) {
    _localQuality2 = quality2;
    if ((_changeBits & 8192) == 0) {
      _changeBits |= 8192;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8192);
    }
  }

  public float GetGain2() {
    return _localGain2;
  }

  public void SetGain2(float gain2) {
    _localGain2 = gain2;
    if ((_changeBits & 16384) == 0) {
      _changeBits |= 16384;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 16384);
    }
  }

  public FilterType GetFilterType3() {
    return _localFilterType3;
  }

  public void SetFilterType3(FilterType filterType3) {
    _localFilterType3 = filterType3;
    if ((_changeBits & 32768) == 0) {
      _changeBits |= 32768;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 32768);
    }
  }

  public float GetFrequency3() {
    return _localFrequency3;
  }

  public void SetFrequency3(float frequency3) {
    _localFrequency3 = frequency3;
    if ((_changeBits & 65536) == 0) {
      _changeBits |= 65536;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 65536);
    }
  }

  public float GetQuality3() {
    return _localQuality3;
  }

  public void SetQuality3(float quality3) {
    _localQuality3 = quality3;
    if ((_changeBits & 131072) == 0) {
      _changeBits |= 131072;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 131072);
    }
  }

  public float GetGain3() {
    return _localGain3;
  }

  public void SetGain3(float gain3) {
    _localGain3 = gain3;
    if ((_changeBits & 262144) == 0) {
      _changeBits |= 262144;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 262144);
    }
  }

  public FilterType GetFilterType4() {
    return _localFilterType4;
  }

  public void SetFilterType4(FilterType filterType4) {
    _localFilterType4 = filterType4;
    if ((_changeBits & 524288) == 0) {
      _changeBits |= 524288;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 524288);
    }
  }

  public float GetFrequency4() {
    return _localFrequency4;
  }

  public void SetFrequency4(float frequency4) {
    _localFrequency4 = frequency4;
    if ((_changeBits & 1048576) == 0) {
      _changeBits |= 1048576;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1048576);
    }
  }

  public float GetQuality4() {
    return _localQuality4;
  }

  public void SetQuality4(float quality4) {
    _localQuality4 = quality4;
    if ((_changeBits & 2097152) == 0) {
      _changeBits |= 2097152;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2097152);
    }
  }

  public float GetGain4() {
    return _localGain4;
  }

  public void SetGain4(float gain4) {
    _localGain4 = gain4;
    if ((_changeBits & 4194304) == 0) {
      _changeBits |= 4194304;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4194304);
    }
  }

  public float GetGainAdjust() {
    return _localGainAdjust;
  }

  public void SetGainAdjust(float gainAdjust) {
    _localGainAdjust = gainAdjust;
    if ((_changeBits & 8388608) == 0) {
      _changeBits |= 8388608;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8388608);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalParametricEqualizerWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 16777215;
      _changeByteCount = 108;
      objAccessor = SignalParametricEqualizerWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalParametricEqualizerWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetFilterType0(_localFilterType0);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetFrequency0(_localFrequency0);
    }
    if ((_changeBits & 32) != 0) {
      objAccessor.SetQuality0(_localQuality0);
    }
    if ((_changeBits & 64) != 0) {
      objAccessor.SetGain0(_localGain0);
    }
    if ((_changeBits & 128) != 0) {
      objAccessor.SetFilterType1(_localFilterType1);
    }
    if ((_changeBits & 256) != 0) {
      objAccessor.SetFrequency1(_localFrequency1);
    }
    if ((_changeBits & 512) != 0) {
      objAccessor.SetQuality1(_localQuality1);
    }
    if ((_changeBits & 1024) != 0) {
      objAccessor.SetGain1(_localGain1);
    }
    if ((_changeBits & 2048) != 0) {
      objAccessor.SetFilterType2(_localFilterType2);
    }
    if ((_changeBits & 4096) != 0) {
      objAccessor.SetFrequency2(_localFrequency2);
    }
    if ((_changeBits & 8192) != 0) {
      objAccessor.SetQuality2(_localQuality2);
    }
    if ((_changeBits & 16384) != 0) {
      objAccessor.SetGain2(_localGain2);
    }
    if ((_changeBits & 32768) != 0) {
      objAccessor.SetFilterType3(_localFilterType3);
    }
    if ((_changeBits & 65536) != 0) {
      objAccessor.SetFrequency3(_localFrequency3);
    }
    if ((_changeBits & 131072) != 0) {
      objAccessor.SetQuality3(_localQuality3);
    }
    if ((_changeBits & 262144) != 0) {
      objAccessor.SetGain3(_localGain3);
    }
    if ((_changeBits & 524288) != 0) {
      objAccessor.SetFilterType4(_localFilterType4);
    }
    if ((_changeBits & 1048576) != 0) {
      objAccessor.SetFrequency4(_localFrequency4);
    }
    if ((_changeBits & 2097152) != 0) {
      objAccessor.SetQuality4(_localQuality4);
    }
    if ((_changeBits & 4194304) != 0) {
      objAccessor.SetGain4(_localGain4);
    }
    if ((_changeBits & 8388608) != 0) {
      objAccessor.SetGainAdjust(_localGainAdjust);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 16777215;
    _changeByteCount = 108;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalParametricEqualizerReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckFilterType0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckFrequency0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckQuality0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckGain0Changed(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckFilterType1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckFrequency1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public bool CheckQuality1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 512) != 0;
  }

  public bool CheckGain1Changed(ulong fieldsChanged) {
    return (fieldsChanged & 1024) != 0;
  }

  public bool CheckFilterType2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 2048) != 0;
  }

  public bool CheckFrequency2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 4096) != 0;
  }

  public bool CheckQuality2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 8192) != 0;
  }

  public bool CheckGain2Changed(ulong fieldsChanged) {
    return (fieldsChanged & 16384) != 0;
  }

  public bool CheckFilterType3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 32768) != 0;
  }

  public bool CheckFrequency3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 65536) != 0;
  }

  public bool CheckQuality3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 131072) != 0;
  }

  public bool CheckGain3Changed(ulong fieldsChanged) {
    return (fieldsChanged & 262144) != 0;
  }

  public bool CheckFilterType4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 524288) != 0;
  }

  public bool CheckFrequency4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 1048576) != 0;
  }

  public bool CheckQuality4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 2097152) != 0;
  }

  public bool CheckGain4Changed(ulong fieldsChanged) {
    return (fieldsChanged & 4194304) != 0;
  }

  public bool CheckGainAdjustChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8388608) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalPitchShift : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalPitchShiftReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected Xrpa.ObjectUuid _localSrcNode = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected int _localPitchShiftSemitones = 0;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalPitchShift(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return _localSrcNode;
  }

  public void SetSrcNode(Xrpa.ObjectUuid srcNode) {
    _localSrcNode = srcNode;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public int GetPitchShiftSemitones() {
    return _localPitchShiftSemitones;
  }

  public void SetPitchShiftSemitones(int pitchShiftSemitones) {
    _localPitchShiftSemitones = pitchShiftSemitones;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalPitchShiftWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 15;
      _changeByteCount = 28;
      objAccessor = SignalPitchShiftWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalPitchShiftWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetPitchShiftSemitones(_localPitchShiftSemitones);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 15;
    _changeByteCount = 28;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalPitchShiftReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckPitchShiftSemitonesChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalSoftClip : ISignalNode, Xrpa.IDataStoreObjectAccessor<SignalSoftClipReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  protected int _localNumOutputs = 1;
  protected int _localNumChannels = 1;
  protected Xrpa.ObjectUuid _localSrcNode = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalSoftClip(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetNumOutputs() {
    return _localNumOutputs;
  }

  public void SetNumOutputs(int numOutputs) {
    _localNumOutputs = numOutputs;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return _localSrcNode;
  }

  public void SetSrcNode(Xrpa.ObjectUuid srcNode) {
    _localSrcNode = srcNode;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalSoftClipWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 7;
      _changeByteCount = 24;
      objAccessor = SignalSoftClipWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalSoftClipWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetNumOutputs(_localNumOutputs);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 7;
    _changeByteCount = 24;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalSoftClipReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckNumOutputsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundSignalOutputData : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<SignalOutputDataReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  private Xrpa.InboundSignalDataInterface _dataSignalHandler = null;
  protected Xrpa.ObjectUuid _localSrcNode = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected int _localNumChannels = 1;
  protected int _localFrameRate = 0;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalOutputData(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return _localSrcNode;
  }

  public void SetSrcNode(Xrpa.ObjectUuid srcNode) {
    _localSrcNode = srcNode;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public int GetFrameRate() {
    return _localFrameRate;
  }

  public void SetFrameRate(int frameRate) {
    _localFrameRate = frameRate;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalOutputDataWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 7;
      _changeByteCount = 24;
      objAccessor = SignalOutputDataWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalOutputDataWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetFrameRate(_localFrameRate);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 7;
    _changeByteCount = 24;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalOutputDataReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckFrameRateChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public void OnData(Xrpa.InboundSignalDataInterface handler) {
    _dataSignalHandler = handler;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
    if (messageType == 3) {
      _dataSignalHandler?.OnSignalData(msgTimestamp, messageData);
    }
  }
}

public class OutboundSignalOutputDevice : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<SignalOutputDeviceReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;

  // Set to true if a matching device was found
  private bool _localFoundMatch = false;
  protected Xrpa.ObjectUuid _localSrcNode = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected int _localChannelOffset = 0;

  // pseudo-regex, with just $ and ^ supported for now
  protected string _localDeviceNameFilter = "";
  protected bool _localOutputToSystemAudio = false;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSignalOutputDevice(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public Xrpa.ObjectUuid GetSrcNode() {
    return _localSrcNode;
  }

  public void SetSrcNode(Xrpa.ObjectUuid srcNode) {
    _localSrcNode = srcNode;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public int GetChannelOffset() {
    return _localChannelOffset;
  }

  public void SetChannelOffset(int channelOffset) {
    _localChannelOffset = channelOffset;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public string GetDeviceNameFilter() {
    return _localDeviceNameFilter;
  }

  public void SetDeviceNameFilter(string deviceNameFilter) {
    _localDeviceNameFilter = deviceNameFilter;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localDeviceNameFilter);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public bool GetOutputToSystemAudio() {
    return _localOutputToSystemAudio;
  }

  public void SetOutputToSystemAudio(bool outputToSystemAudio) {
    _localOutputToSystemAudio = outputToSystemAudio;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SignalOutputDeviceWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 15;
      _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localDeviceNameFilter) + 28;
      objAccessor = SignalOutputDeviceWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SignalOutputDeviceWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetSrcNode(_localSrcNode);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetChannelOffset(_localChannelOffset);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetDeviceNameFilter(_localDeviceNameFilter);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetOutputToSystemAudio(_localOutputToSystemAudio);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 15;
    _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localDeviceNameFilter) + 28;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(SignalOutputDeviceReader value, ulong fieldsChanged) {
    if (value.CheckFoundMatchChanged(fieldsChanged)) {
      _localFoundMatch = value.GetFoundMatch();
    }
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool GetFoundMatch() {
    return _localFoundMatch;
  }

  public bool CheckSrcNodeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckChannelOffsetChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckDeviceNameFilterChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckOutputToSystemAudioChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckFoundMatchChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

// Object Collections
public class OutboundSignalEventReaderCollection : Xrpa.ObjectCollection<SignalEventReader, OutboundSignalEvent> {
  public OutboundSignalEventReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 0, 0, 0, true) {}

  public void AddObject(OutboundSignalEvent obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalEvent CreateObject() {
    var obj = new OutboundSignalEvent(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalEventCombinerReaderCollection : Xrpa.ObjectCollection<SignalEventCombinerReader, OutboundSignalEventCombiner> {
  public OutboundSignalEventCombinerReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 1, 0, 0, true) {}

  public void AddObject(OutboundSignalEventCombiner obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalEventCombiner CreateObject() {
    var obj = new OutboundSignalEventCombiner(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalSourceReaderCollection : Xrpa.ObjectCollection<SignalSourceReader, OutboundSignalSource> {
  public OutboundSignalSourceReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 2, 0, 0, true) {}

  public void AddObject(OutboundSignalSource obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalSource CreateObject() {
    var obj = new OutboundSignalSource(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalSourceFileReaderCollection : Xrpa.ObjectCollection<SignalSourceFileReader, OutboundSignalSourceFile> {
  public OutboundSignalSourceFileReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 3, 0, 0, true) {}

  public void AddObject(OutboundSignalSourceFile obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalSourceFile CreateObject() {
    var obj = new OutboundSignalSourceFile(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalOscillatorReaderCollection : Xrpa.ObjectCollection<SignalOscillatorReader, OutboundSignalOscillator> {
  public OutboundSignalOscillatorReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 4, 0, 0, true) {}

  public void AddObject(OutboundSignalOscillator obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalOscillator CreateObject() {
    var obj = new OutboundSignalOscillator(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalChannelRouterReaderCollection : Xrpa.ObjectCollection<SignalChannelRouterReader, OutboundSignalChannelRouter> {
  public OutboundSignalChannelRouterReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 5, 0, 0, true) {}

  public void AddObject(OutboundSignalChannelRouter obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalChannelRouter CreateObject() {
    var obj = new OutboundSignalChannelRouter(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalChannelSelectReaderCollection : Xrpa.ObjectCollection<SignalChannelSelectReader, OutboundSignalChannelSelect> {
  public OutboundSignalChannelSelectReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 6, 0, 0, true) {}

  public void AddObject(OutboundSignalChannelSelect obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalChannelSelect CreateObject() {
    var obj = new OutboundSignalChannelSelect(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalChannelStackReaderCollection : Xrpa.ObjectCollection<SignalChannelStackReader, OutboundSignalChannelStack> {
  public OutboundSignalChannelStackReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 7, 0, 0, true) {}

  public void AddObject(OutboundSignalChannelStack obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalChannelStack CreateObject() {
    var obj = new OutboundSignalChannelStack(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalCurveReaderCollection : Xrpa.ObjectCollection<SignalCurveReader, OutboundSignalCurve> {
  public OutboundSignalCurveReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 8, 0, 0, true) {}

  public void AddObject(OutboundSignalCurve obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalCurve CreateObject() {
    var obj = new OutboundSignalCurve(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalDelayReaderCollection : Xrpa.ObjectCollection<SignalDelayReader, OutboundSignalDelay> {
  public OutboundSignalDelayReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 9, 0, 0, true) {}

  public void AddObject(OutboundSignalDelay obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalDelay CreateObject() {
    var obj = new OutboundSignalDelay(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalFeedbackReaderCollection : Xrpa.ObjectCollection<SignalFeedbackReader, OutboundSignalFeedback> {
  public OutboundSignalFeedbackReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 10, 0, 0, true) {}

  public void AddObject(OutboundSignalFeedback obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalFeedback CreateObject() {
    var obj = new OutboundSignalFeedback(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalMathOpReaderCollection : Xrpa.ObjectCollection<SignalMathOpReader, OutboundSignalMathOp> {
  public OutboundSignalMathOpReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 11, 0, 0, true) {}

  public void AddObject(OutboundSignalMathOp obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalMathOp CreateObject() {
    var obj = new OutboundSignalMathOp(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalMultiplexerReaderCollection : Xrpa.ObjectCollection<SignalMultiplexerReader, OutboundSignalMultiplexer> {
  public OutboundSignalMultiplexerReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 12, 0, 0, true) {}

  public void AddObject(OutboundSignalMultiplexer obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalMultiplexer CreateObject() {
    var obj = new OutboundSignalMultiplexer(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalParametricEqualizerReaderCollection : Xrpa.ObjectCollection<SignalParametricEqualizerReader, OutboundSignalParametricEqualizer> {
  public OutboundSignalParametricEqualizerReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 13, 0, 0, true) {}

  public void AddObject(OutboundSignalParametricEqualizer obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalParametricEqualizer CreateObject() {
    var obj = new OutboundSignalParametricEqualizer(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalPitchShiftReaderCollection : Xrpa.ObjectCollection<SignalPitchShiftReader, OutboundSignalPitchShift> {
  public OutboundSignalPitchShiftReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 14, 0, 0, true) {}

  public void AddObject(OutboundSignalPitchShift obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalPitchShift CreateObject() {
    var obj = new OutboundSignalPitchShift(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalSoftClipReaderCollection : Xrpa.ObjectCollection<SignalSoftClipReader, OutboundSignalSoftClip> {
  public OutboundSignalSoftClipReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 15, 0, 0, true) {}

  public void AddObject(OutboundSignalSoftClip obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalSoftClip CreateObject() {
    var obj = new OutboundSignalSoftClip(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalOutputDataReaderCollection : Xrpa.ObjectCollection<SignalOutputDataReader, OutboundSignalOutputData> {
  public OutboundSignalOutputDataReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 16, 0, 0, true) {}

  public void AddObject(OutboundSignalOutputData obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalOutputData CreateObject() {
    var obj = new OutboundSignalOutputData(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundSignalOutputDeviceReaderCollection : Xrpa.ObjectCollection<SignalOutputDeviceReader, OutboundSignalOutputDevice> {
  public OutboundSignalOutputDeviceReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 17, 16, 0, true) {}

  public void AddObject(OutboundSignalOutputDevice obj) {
    AddObjectInternal(obj);
  }

  public OutboundSignalOutputDevice CreateObject() {
    var obj = new OutboundSignalOutputDevice(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

// Data Store Implementation
public class SignalProcessingDataStore : Xrpa.DataStoreReconciler {
  public SignalProcessingDataStore(Xrpa.TransportStream inboundTransport, Xrpa.TransportStream outboundTransport)
      : base(inboundTransport, outboundTransport, 9912320) {
    SignalEvent = new OutboundSignalEventReaderCollection(this);
    RegisterCollection(SignalEvent);
    SignalEventCombiner = new OutboundSignalEventCombinerReaderCollection(this);
    RegisterCollection(SignalEventCombiner);
    SignalSource = new OutboundSignalSourceReaderCollection(this);
    RegisterCollection(SignalSource);
    SignalSourceFile = new OutboundSignalSourceFileReaderCollection(this);
    RegisterCollection(SignalSourceFile);
    SignalOscillator = new OutboundSignalOscillatorReaderCollection(this);
    RegisterCollection(SignalOscillator);
    SignalChannelRouter = new OutboundSignalChannelRouterReaderCollection(this);
    RegisterCollection(SignalChannelRouter);
    SignalChannelSelect = new OutboundSignalChannelSelectReaderCollection(this);
    RegisterCollection(SignalChannelSelect);
    SignalChannelStack = new OutboundSignalChannelStackReaderCollection(this);
    RegisterCollection(SignalChannelStack);
    SignalCurve = new OutboundSignalCurveReaderCollection(this);
    RegisterCollection(SignalCurve);
    SignalDelay = new OutboundSignalDelayReaderCollection(this);
    RegisterCollection(SignalDelay);
    SignalFeedback = new OutboundSignalFeedbackReaderCollection(this);
    RegisterCollection(SignalFeedback);
    SignalMathOp = new OutboundSignalMathOpReaderCollection(this);
    RegisterCollection(SignalMathOp);
    SignalMultiplexer = new OutboundSignalMultiplexerReaderCollection(this);
    RegisterCollection(SignalMultiplexer);
    SignalParametricEqualizer = new OutboundSignalParametricEqualizerReaderCollection(this);
    RegisterCollection(SignalParametricEqualizer);
    SignalPitchShift = new OutboundSignalPitchShiftReaderCollection(this);
    RegisterCollection(SignalPitchShift);
    SignalSoftClip = new OutboundSignalSoftClipReaderCollection(this);
    RegisterCollection(SignalSoftClip);
    SignalOutputData = new OutboundSignalOutputDataReaderCollection(this);
    RegisterCollection(SignalOutputData);
    SignalOutputDevice = new OutboundSignalOutputDeviceReaderCollection(this);
    RegisterCollection(SignalOutputDevice);
  }

  public OutboundSignalEventReaderCollection SignalEvent;
  public OutboundSignalEventCombinerReaderCollection SignalEventCombiner;
  public OutboundSignalSourceReaderCollection SignalSource;
  public OutboundSignalSourceFileReaderCollection SignalSourceFile;
  public OutboundSignalOscillatorReaderCollection SignalOscillator;
  public OutboundSignalChannelRouterReaderCollection SignalChannelRouter;
  public OutboundSignalChannelSelectReaderCollection SignalChannelSelect;
  public OutboundSignalChannelStackReaderCollection SignalChannelStack;
  public OutboundSignalCurveReaderCollection SignalCurve;
  public OutboundSignalDelayReaderCollection SignalDelay;
  public OutboundSignalFeedbackReaderCollection SignalFeedback;
  public OutboundSignalMathOpReaderCollection SignalMathOp;
  public OutboundSignalMultiplexerReaderCollection SignalMultiplexer;
  public OutboundSignalParametricEqualizerReaderCollection SignalParametricEqualizer;
  public OutboundSignalPitchShiftReaderCollection SignalPitchShift;
  public OutboundSignalSoftClipReaderCollection SignalSoftClip;
  public OutboundSignalOutputDataReaderCollection SignalOutputData;
  public OutboundSignalOutputDeviceReaderCollection SignalOutputDevice;
}

} // namespace SignalProcessingDataStore
