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

namespace SpeakerIdentificationDataStore {

public class SpeakerIdentifierReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SpeakerIdentifierReader() {}

  public SpeakerIdentifierReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // ID of the identified speaker, empty if no match
  public string GetIdentifiedSpeakerId() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Name of the identified speaker, empty if no match
  public string GetIdentifiedSpeakerName() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Confidence score of the match (0-1)
  public int GetConfidenceScore() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Error message if identification failed
  public string GetErrorMessage() {
    return _memAccessor.ReadString(_readOffset);
  }

  public bool CheckIdentifiedSpeakerIdChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckIdentifiedSpeakerNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckConfidenceScoreChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckErrorMessageChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }
}

public class SpeakerIdentifierWriter : SpeakerIdentifierReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SpeakerIdentifierWriter() {}

  public SpeakerIdentifierWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static SpeakerIdentifierWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new SpeakerIdentifierWriter(changeEvent.AccessChangeData());
  }

  public static SpeakerIdentifierWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new SpeakerIdentifierWriter(changeEvent.AccessChangeData());
  }

  public void SetIdentifiedSpeakerId(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetIdentifiedSpeakerName(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetConfidenceScore(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetErrorMessage(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }
}

public class ReferenceSpeakerReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public ReferenceSpeakerReader() {}

  public ReferenceSpeakerReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // Unique identifier for this speaker
  public string GetSpeakerId() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Human-readable name for this speaker
  public string GetSpeakerName() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Path to the audio file containing the speaker's voice sample
  public string GetFilePath() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Reference back to the SpeakerIdentifier that this config belongs to
  public Xrpa.ObjectUuid GetSpeakerIdentifier() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckSpeakerIdChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckSpeakerNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckFilePathChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSpeakerIdentifierChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }
}

public class ReferenceSpeakerWriter : ReferenceSpeakerReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public ReferenceSpeakerWriter() {}

  public ReferenceSpeakerWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static ReferenceSpeakerWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new ReferenceSpeakerWriter(changeEvent.AccessChangeData());
  }

  public static ReferenceSpeakerWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new ReferenceSpeakerWriter(changeEvent.AccessChangeData());
  }

  public void SetSpeakerId(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetSpeakerName(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetFilePath(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetSpeakerIdentifier(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class ReferenceSpeakerAudioFileReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public ReferenceSpeakerAudioFileReader() {}

  public ReferenceSpeakerAudioFileReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // Path to the audio file containing the speaker's voice sample
  public string GetFilePath() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Reference back to the speaker this audio file belongs to
  public Xrpa.ObjectUuid GetSpeaker() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckFilePathChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckSpeakerChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }
}

public class ReferenceSpeakerAudioFileWriter : ReferenceSpeakerAudioFileReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public ReferenceSpeakerAudioFileWriter() {}

  public ReferenceSpeakerAudioFileWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static ReferenceSpeakerAudioFileWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new ReferenceSpeakerAudioFileWriter(changeEvent.AccessChangeData());
  }

  public static ReferenceSpeakerAudioFileWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new ReferenceSpeakerAudioFileWriter(changeEvent.AccessChangeData());
  }

  public void SetFilePath(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetSpeaker(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }
}

// Reconciled Types
public class OutboundSpeakerIdentifier : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<SpeakerIdentifierReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;

  // ID of the identified speaker, empty if no match
  private string _localIdentifiedSpeakerId = "";

  // Name of the identified speaker, empty if no match
  private string _localIdentifiedSpeakerName = "";

  // Confidence score of the match (0-1)
  private int _localConfidenceScore = 0;

  // Error message if identification failed
  private string _localErrorMessage = "";
  private Xrpa.OutboundSignalData _localAudioSignal = new Xrpa.OutboundSignalData();
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundSpeakerIdentifier(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    SpeakerIdentifierWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 0;
      _changeByteCount = 0;
      objAccessor = SpeakerIdentifierWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = SpeakerIdentifierWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
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

  public void ProcessDSUpdate(SpeakerIdentifierReader value, ulong fieldsChanged) {
    if (value.CheckIdentifiedSpeakerIdChanged(fieldsChanged)) {
      _localIdentifiedSpeakerId = value.GetIdentifiedSpeakerId();
    }
    if (value.CheckIdentifiedSpeakerNameChanged(fieldsChanged)) {
      _localIdentifiedSpeakerName = value.GetIdentifiedSpeakerName();
    }
    if (value.CheckConfidenceScoreChanged(fieldsChanged)) {
      _localConfidenceScore = value.GetConfidenceScore();
    }
    if (value.CheckErrorMessageChanged(fieldsChanged)) {
      _localErrorMessage = value.GetErrorMessage();
    }
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public string GetIdentifiedSpeakerId() {
    return _localIdentifiedSpeakerId;
  }

  public string GetIdentifiedSpeakerName() {
    return _localIdentifiedSpeakerName;
  }

  public int GetConfidenceScore() {
    return _localConfidenceScore;
  }

  public string GetErrorMessage() {
    return _localErrorMessage;
  }

  public bool CheckIdentifiedSpeakerIdChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckIdentifiedSpeakerNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckConfidenceScoreChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckErrorMessageChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public void SetAudioSignalCallback<SampleType>(Xrpa.SignalProducerCallback<SampleType> signalCallback, int numChannels, int framesPerSecond, int framesPerPacket) where SampleType : unmanaged  {
    _localAudioSignal.SetSignalSource(signalCallback, numChannels, framesPerSecond, framesPerPacket);
  }

  public void SetAudioSignalRingBuffer<SampleType>(Xrpa.SignalRingBuffer<SampleType> signalRingBuffer, int numChannels, int framesPerSecond, int framesPerPacket) where SampleType : unmanaged  {
    _localAudioSignal.SetSignalSource(signalRingBuffer, numChannels, framesPerSecond, framesPerPacket);
  }

  public void SetAudioSignalForwarder<SampleType>(Xrpa.InboundSignalForwarder signalForwarder) where SampleType : unmanaged  {
    _localAudioSignal.SetRecipient(GetXrpaId(), _collection, 0);
    signalForwarder.AddRecipient(_localAudioSignal);
  }

  public Xrpa.SignalPacket SendAudioSignal<SampleType>(int frameCount, int numChannels, int framesPerSecond) where SampleType : unmanaged  {
    int sampleType = Xrpa.SignalTypeInference.InferSampleType<SampleType>();
    _localAudioSignal.SetRecipient(GetXrpaId(), _collection, 0);
    return _localAudioSignal.SendSignalPacket(Xrpa.MemoryUtils.GetTypeSize<SampleType>(), frameCount, sampleType, numChannels, framesPerSecond);
  }

  public void TickXrpa() {
    var id = GetXrpaId();
    _localAudioSignal.SetRecipient(id, _collection, 0);
    _localAudioSignal.Tick();
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundReferenceSpeaker : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<ReferenceSpeakerReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;

  // Unique identifier for this speaker
  protected string _localSpeakerId = "";

  // Human-readable name for this speaker
  protected string _localSpeakerName = "";

  // Path to the audio file containing the speaker's voice sample
  protected string _localFilePath = "";

  // Reference back to the SpeakerIdentifier that this config belongs to
  protected Xrpa.ObjectUuid _localSpeakerIdentifier = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundReferenceSpeaker(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public string GetSpeakerId() {
    return _localSpeakerId;
  }

  public void SetSpeakerId(string speakerId) {
    _localSpeakerId = speakerId;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localSpeakerId);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public string GetSpeakerName() {
    return _localSpeakerName;
  }

  public void SetSpeakerName(string speakerName) {
    _localSpeakerName = speakerName;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localSpeakerName);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public string GetFilePath() {
    return _localFilePath;
  }

  public void SetFilePath(string filePath) {
    _localFilePath = filePath;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localFilePath);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public Xrpa.ObjectUuid GetSpeakerIdentifier() {
    return _localSpeakerIdentifier;
  }

  public void SetSpeakerIdentifier(Xrpa.ObjectUuid speakerIdentifier) {
    _localSpeakerIdentifier = speakerIdentifier;
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
    ReferenceSpeakerWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 15;
      _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localSpeakerId) + Xrpa.MemoryAccessor.DynSizeOfString(_localSpeakerName) + Xrpa.MemoryAccessor.DynSizeOfString(_localFilePath) + 28;
      objAccessor = ReferenceSpeakerWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = ReferenceSpeakerWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetSpeakerId(_localSpeakerId);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetSpeakerName(_localSpeakerName);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetFilePath(_localFilePath);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetSpeakerIdentifier(_localSpeakerIdentifier);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 15;
    _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localSpeakerId) + Xrpa.MemoryAccessor.DynSizeOfString(_localSpeakerName) + Xrpa.MemoryAccessor.DynSizeOfString(_localFilePath) + 28;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(ReferenceSpeakerReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckSpeakerIdChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckSpeakerNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckFilePathChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSpeakerIdentifierChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundReferenceSpeakerAudioFile : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<ReferenceSpeakerAudioFileReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;

  // Path to the audio file containing the speaker's voice sample
  protected string _localFilePath = "";

  // Reference back to the speaker this audio file belongs to
  protected Xrpa.ObjectUuid _localSpeaker = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundReferenceSpeakerAudioFile(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public string GetFilePath() {
    return _localFilePath;
  }

  public void SetFilePath(string filePath) {
    _localFilePath = filePath;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localFilePath);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public Xrpa.ObjectUuid GetSpeaker() {
    return _localSpeaker;
  }

  public void SetSpeaker(Xrpa.ObjectUuid speaker) {
    _localSpeaker = speaker;
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

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    ReferenceSpeakerAudioFileWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 3;
      _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localFilePath) + 20;
      objAccessor = ReferenceSpeakerAudioFileWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = ReferenceSpeakerAudioFileWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetFilePath(_localFilePath);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetSpeaker(_localSpeaker);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 3;
    _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localFilePath) + 20;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(ReferenceSpeakerAudioFileReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckFilePathChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckSpeakerChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

// Object Collections
public class OutboundSpeakerIdentifierReaderCollection : Xrpa.ObjectCollection<SpeakerIdentifierReader, OutboundSpeakerIdentifier> {
  public OutboundSpeakerIdentifierReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 0, 15, 0, true) {}

  public void AddObject(OutboundSpeakerIdentifier obj) {
    AddObjectInternal(obj);
  }

  public OutboundSpeakerIdentifier CreateObject() {
    var obj = new OutboundSpeakerIdentifier(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundReferenceSpeakerReaderCollection : Xrpa.ObjectCollection<ReferenceSpeakerReader, OutboundReferenceSpeaker> {
  public OutboundReferenceSpeakerReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 1, 0, 0, true) {}

  public void AddObject(OutboundReferenceSpeaker obj) {
    AddObjectInternal(obj);
  }

  public OutboundReferenceSpeaker CreateObject() {
    var obj = new OutboundReferenceSpeaker(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundReferenceSpeakerAudioFileReaderCollection : Xrpa.ObjectCollection<ReferenceSpeakerAudioFileReader, OutboundReferenceSpeakerAudioFile> {
  public OutboundReferenceSpeakerAudioFileReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 2, 0, 0, true) {}

  public void AddObject(OutboundReferenceSpeakerAudioFile obj) {
    AddObjectInternal(obj);
  }

  public OutboundReferenceSpeakerAudioFile CreateObject() {
    var obj = new OutboundReferenceSpeakerAudioFile(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

// Data Store Implementation
public class SpeakerIdentificationDataStore : Xrpa.DataStoreReconciler {
  public SpeakerIdentificationDataStore(Xrpa.TransportStream inboundTransport, Xrpa.TransportStream outboundTransport)
      : base(inboundTransport, outboundTransport, 77320) {
    SpeakerIdentifier = new OutboundSpeakerIdentifierReaderCollection(this);
    RegisterCollection(SpeakerIdentifier);
    ReferenceSpeaker = new OutboundReferenceSpeakerReaderCollection(this);
    RegisterCollection(ReferenceSpeaker);
    ReferenceSpeakerAudioFile = new OutboundReferenceSpeakerAudioFileReaderCollection(this);
    RegisterCollection(ReferenceSpeakerAudioFile);
  }

  public OutboundSpeakerIdentifierReaderCollection SpeakerIdentifier;
  public OutboundReferenceSpeakerReaderCollection ReferenceSpeaker;
  public OutboundReferenceSpeakerAudioFileReaderCollection ReferenceSpeakerAudioFile;
}

} // namespace SpeakerIdentificationDataStore
