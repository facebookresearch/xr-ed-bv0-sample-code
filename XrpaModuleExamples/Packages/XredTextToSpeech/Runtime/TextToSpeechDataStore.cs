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

namespace TextToSpeechDataStore {

public class TextRequestReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public TextRequestReader() {}

  public TextRequestReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // Text to convert to speech
  public string GetText() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Optional ID. If sent with a text request, the response will have the same ID.
  public int GetId() {
    return _memAccessor.ReadInt(_readOffset);
  }
}

public class TextRequestWriter : TextRequestReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public TextRequestWriter() {}

  public TextRequestWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetText(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetId(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }
}

public class TtsResponseReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public TtsResponseReader() {}

  public TtsResponseReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // Request ID that matches the original text request
  public int GetId() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Whether synthesis completed successfully
  public bool GetSuccess() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  // Error message if processing failed
  public string GetErrorMessage() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Timestamp when audio playback started
  public ulong GetPlaybackStartTimestamp() {
    return _memAccessor.ReadUlong(_readOffset);
  }
}

public class TtsResponseWriter : TtsResponseReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public TtsResponseWriter() {}

  public TtsResponseWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetId(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetSuccess(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetErrorMessage(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetPlaybackStartTimestamp(ulong value) {
    _memAccessor.WriteUlong(value, _writeOffset);
  }
}

public class TextToSpeechReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public TextToSpeechReader() {}

  public TextToSpeechReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }
}

public class TextToSpeechWriter : TextToSpeechReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public TextToSpeechWriter() {}

  public TextToSpeechWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static TextToSpeechWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new TextToSpeechWriter(changeEvent.AccessChangeData());
  }

  public static TextToSpeechWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new TextToSpeechWriter(changeEvent.AccessChangeData());
  }
}

// Reconciled Types
public class OutboundTextToSpeech : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<TextToSpeechReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  private System.Action<ulong, TtsResponseReader> _TtsResponseMessageHandler = null;
  private Xrpa.InboundSignalDataInterface _audioSignalHandler = null;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundTextToSpeech(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    TextToSpeechWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 0;
      _changeByteCount = 0;
      objAccessor = TextToSpeechWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = TextToSpeechWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
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

  public void ProcessDSUpdate(TextToSpeechReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public void SendTextRequest(string text, int id) {
    TextRequestWriter message = new(_collection.SendMessage(
        GetXrpaId(),
        0,
        Xrpa.MemoryAccessor.DynSizeOfString(text) + 8));
    message.SetText(text);
    message.SetId(id);
  }

  public void OnTtsResponse(System.Action<ulong, TtsResponseReader> handler) {
    _TtsResponseMessageHandler = handler;
  }

  public void OnAudio(Xrpa.InboundSignalDataInterface handler) {
    _audioSignalHandler = handler;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
    if (messageType == 2) {
      TtsResponseReader message = new(messageData);
      _TtsResponseMessageHandler?.Invoke(msgTimestamp, message);
    }
    if (messageType == 1) {
      _audioSignalHandler?.OnSignalData(msgTimestamp, messageData);
    }
  }
}

// Object Collections
public class OutboundTextToSpeechReaderCollection : Xrpa.ObjectCollection<TextToSpeechReader, OutboundTextToSpeech> {
  public OutboundTextToSpeechReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 0, 0, 0, true) {}

  public void AddObject(OutboundTextToSpeech obj) {
    AddObjectInternal(obj);
  }

  public OutboundTextToSpeech CreateObject() {
    var obj = new OutboundTextToSpeech(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

// Data Store Implementation
public class TextToSpeechDataStore : Xrpa.DataStoreReconciler {
  public TextToSpeechDataStore(Xrpa.TransportStream inboundTransport, Xrpa.TransportStream outboundTransport)
      : base(inboundTransport, outboundTransport, 1266112) {
    TextToSpeech = new OutboundTextToSpeechReaderCollection(this);
    RegisterCollection(TextToSpeech);
  }

  public OutboundTextToSpeechReaderCollection TextToSpeech;
}

} // namespace TextToSpeechDataStore
