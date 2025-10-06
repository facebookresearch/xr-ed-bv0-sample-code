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

namespace OpticalCharacterRecognitionDataStore {

public class ImageInputReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public ImageInputReader() {}

  public ImageInputReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public Xrpa.Image GetImage() {
    return DSOcrImage.ReadValue(_memAccessor, _readOffset);
  }
}

public class ImageInputWriter : ImageInputReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public ImageInputWriter() {}

  public ImageInputWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetImage(Xrpa.Image value) {
    DSOcrImage.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class OcrResultReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public OcrResultReader() {}

  public OcrResultReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // Transcribed text from the image
  public string GetText() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Timestamp of when input image was captured
  public ulong GetTimestamp() {
    return _memAccessor.ReadUlong(_readOffset);
  }

  // Whether OCR processing completed successfully
  public bool GetSuccess() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  // Error message if OCR processing failed
  public string GetErrorMessage() {
    return _memAccessor.ReadString(_readOffset);
  }
}

public class OcrResultWriter : OcrResultReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public OcrResultWriter() {}

  public OcrResultWriter(Xrpa.MemoryAccessor memAccessor) {
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

public class OpticalCharacterRecognitionReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public OpticalCharacterRecognitionReader() {}

  public OpticalCharacterRecognitionReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // Increment this value to trigger OCR processing
  public int GetTriggerId() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Whether to use immediate mode (true) or triggered mode (false)
  public bool GetImmediateMode() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  public bool CheckTriggerIdChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckImmediateModeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }
}

public class OpticalCharacterRecognitionWriter : OpticalCharacterRecognitionReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public OpticalCharacterRecognitionWriter() {}

  public OpticalCharacterRecognitionWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static OpticalCharacterRecognitionWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new OpticalCharacterRecognitionWriter(changeEvent.AccessChangeData());
  }

  public static OpticalCharacterRecognitionWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new OpticalCharacterRecognitionWriter(changeEvent.AccessChangeData());
  }

  public void SetTriggerId(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetImmediateMode(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }
}

// Reconciled Types
public class OutboundOpticalCharacterRecognition : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<OpticalCharacterRecognitionReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  private System.Action<ulong, OcrResultReader> _ocrResultMessageHandler = null;

  // Increment this value to trigger OCR processing
  protected int _localTriggerId = 0;

  // Whether to use immediate mode (true) or triggered mode (false)
  protected bool _localImmediateMode = false;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundOpticalCharacterRecognition(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public int GetTriggerId() {
    return _localTriggerId;
  }

  public void SetTriggerId(int triggerId) {
    _localTriggerId = triggerId;
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

  public bool GetImmediateMode() {
    return _localImmediateMode;
  }

  public void SetImmediateMode(bool immediateMode) {
    _localImmediateMode = immediateMode;
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
    OpticalCharacterRecognitionWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 3;
      _changeByteCount = 8;
      objAccessor = OpticalCharacterRecognitionWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = OpticalCharacterRecognitionWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetTriggerId(_localTriggerId);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetImmediateMode(_localImmediateMode);
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

  public void ProcessDSUpdate(OpticalCharacterRecognitionReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckTriggerIdChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckImmediateModeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public void SendImageInput(Xrpa.Image image) {
    ImageInputWriter message = new(_collection.SendMessage(
        GetXrpaId(),
        0,
        DSOcrImage.DynSizeOfValue(image) + 48));
    message.SetImage(image);
  }

  public void OnOcrResult(System.Action<ulong, OcrResultReader> handler) {
    _ocrResultMessageHandler = handler;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
    if (messageType == 3) {
      OcrResultReader message = new(messageData);
      _ocrResultMessageHandler?.Invoke(msgTimestamp, message);
    }
  }
}

// Object Collections
public class OutboundOpticalCharacterRecognitionReaderCollection : Xrpa.ObjectCollection<OpticalCharacterRecognitionReader, OutboundOpticalCharacterRecognition> {
  public OutboundOpticalCharacterRecognitionReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 0, 0, 0, true) {}

  public void AddObject(OutboundOpticalCharacterRecognition obj) {
    AddObjectInternal(obj);
  }

  public OutboundOpticalCharacterRecognition CreateObject() {
    var obj = new OutboundOpticalCharacterRecognition(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

// Data Store Implementation
public class OpticalCharacterRecognitionDataStore : Xrpa.DataStoreReconciler {
  public OpticalCharacterRecognitionDataStore(Xrpa.TransportStream inboundTransport, Xrpa.TransportStream outboundTransport)
      : base(inboundTransport, outboundTransport, 5316148) {
    OpticalCharacterRecognition = new OutboundOpticalCharacterRecognitionReaderCollection(this);
    RegisterCollection(OpticalCharacterRecognition);
  }

  public OutboundOpticalCharacterRecognitionReaderCollection OpticalCharacterRecognition;
}

} // namespace OpticalCharacterRecognitionDataStore
