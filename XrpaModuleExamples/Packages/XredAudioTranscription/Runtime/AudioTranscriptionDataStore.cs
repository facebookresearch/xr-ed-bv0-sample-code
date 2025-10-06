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

namespace AudioTranscriptionDataStore {

public class TranscriptionResultReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public TranscriptionResultReader() {}

  public TranscriptionResultReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // Transcribed text from audio
  public string GetText() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Timestamp of the start of the audio segment from which the transcription is generated
  public ulong GetTimestamp() {
    return _memAccessor.ReadUlong(_readOffset);
  }

  // Whether transcription completed successfully
  public bool GetSuccess() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  // Error message if transcription failed
  public string GetErrorMessage() {
    return _memAccessor.ReadString(_readOffset);
  }
}

public class TranscriptionResultWriter : TranscriptionResultReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public TranscriptionResultWriter() {}

  public TranscriptionResultWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetText(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetTimestamp(ulong value) {
    _memAccessor.WriteUlong(value, _writeOffset);
  }

  public void SetSuccess(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetErrorMessage(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }
}

public class AudioTranscriptionReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public AudioTranscriptionReader() {}

  public AudioTranscriptionReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }
}

public class AudioTranscriptionWriter : AudioTranscriptionReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public AudioTranscriptionWriter() {}

  public AudioTranscriptionWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static AudioTranscriptionWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new AudioTranscriptionWriter(changeEvent.AccessChangeData());
  }

  public static AudioTranscriptionWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new AudioTranscriptionWriter(changeEvent.AccessChangeData());
  }
}

// Reconciled Types
public class OutboundAudioTranscription : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<AudioTranscriptionReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  private System.Action<ulong, TranscriptionResultReader> _transcriptionResultMessageHandler = null;
  private Xrpa.OutboundSignalData _localAudioSignal = new Xrpa.OutboundSignalData();
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundAudioTranscription(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    AudioTranscriptionWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 0;
      _changeByteCount = 0;
      objAccessor = AudioTranscriptionWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = AudioTranscriptionWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
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

  public void ProcessDSUpdate(AudioTranscriptionReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public void OnTranscriptionResult(System.Action<ulong, TranscriptionResultReader> handler) {
    _transcriptionResultMessageHandler = handler;
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
    if (messageType == 1) {
      TranscriptionResultReader message = new(messageData);
      _transcriptionResultMessageHandler?.Invoke(msgTimestamp, message);
    }
  }
}

// Object Collections
public class OutboundAudioTranscriptionReaderCollection : Xrpa.ObjectCollection<AudioTranscriptionReader, OutboundAudioTranscription> {
  public OutboundAudioTranscriptionReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 0, 0, 0, true) {}

  public void AddObject(OutboundAudioTranscription obj) {
    AddObjectInternal(obj);
  }

  public OutboundAudioTranscription CreateObject() {
    var obj = new OutboundAudioTranscription(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

// Data Store Implementation
public class AudioTranscriptionDataStore : Xrpa.DataStoreReconciler {
  public AudioTranscriptionDataStore(Xrpa.TransportStream inboundTransport, Xrpa.TransportStream outboundTransport)
      : base(inboundTransport, outboundTransport, 316000) {
    AudioTranscription = new OutboundAudioTranscriptionReaderCollection(this);
    RegisterCollection(AudioTranscription);
  }

  public OutboundAudioTranscriptionReaderCollection AudioTranscription;
}

} // namespace AudioTranscriptionDataStore
