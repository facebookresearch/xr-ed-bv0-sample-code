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

namespace CameraDataStore {

public class CameraDeviceReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public CameraDeviceReader() {}

  public CameraDeviceReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public string GetName() {
    return _memAccessor.ReadString(_readOffset);
  }

  public bool CheckNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }
}

public class CameraDeviceWriter : CameraDeviceReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public CameraDeviceWriter() {}

  public CameraDeviceWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static CameraDeviceWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new CameraDeviceWriter(changeEvent.AccessChangeData());
  }

  public static CameraDeviceWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new CameraDeviceWriter(changeEvent.AccessChangeData());
  }

  public void SetName(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }
}

public class CameraImageReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public CameraImageReader() {}

  public CameraImageReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public Xrpa.Image GetImage() {
    return DSRgbImage.ReadValue(_memAccessor, _readOffset);
  }
}

public class CameraImageWriter : CameraImageReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public CameraImageWriter() {}

  public CameraImageWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetImage(Xrpa.Image value) {
    DSRgbImage.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class CameraFeedReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public CameraFeedReader() {}

  public CameraFeedReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // pseudo-regex, with just $ and ^ supported for now
  public string GetCameraName() {
    return _memAccessor.ReadString(_readOffset);
  }

  public bool CheckCameraNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }
}

public class CameraFeedWriter : CameraFeedReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public CameraFeedWriter() {}

  public CameraFeedWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static CameraFeedWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new CameraFeedWriter(changeEvent.AccessChangeData());
  }

  public static CameraFeedWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new CameraFeedWriter(changeEvent.AccessChangeData());
  }

  public void SetCameraName(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }
}

// Reconciled Types
public class OutboundCameraFeed : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<CameraFeedReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  private System.Action<ulong, CameraImageReader> _cameraImageMessageHandler = null;

  // pseudo-regex, with just $ and ^ supported for now
  protected string _localCameraName = "";
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundCameraFeed(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public string GetCameraName() {
    return _localCameraName;
  }

  public void SetCameraName(string cameraName) {
    _localCameraName = cameraName;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localCameraName);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    CameraFeedWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 1;
      _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localCameraName) + 4;
      objAccessor = CameraFeedWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = CameraFeedWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetCameraName(_localCameraName);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 1;
    _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localCameraName) + 4;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(CameraFeedReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckCameraNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public void OnCameraImage(System.Action<ulong, CameraImageReader> handler) {
    _cameraImageMessageHandler = handler;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
    if (messageType == 1) {
      CameraImageReader message = new(messageData);
      _cameraImageMessageHandler?.Invoke(msgTimestamp, message);
    }
  }
}

public class ReconciledCameraDevice : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<CameraDeviceReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  private System.Action _xrpaDeleteHandler = null;
  private string _localName = "";

  public ReconciledCameraDevice(Xrpa.ObjectUuid id, Xrpa.IObjectCollection collection) : base(id, collection) {}

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public virtual void HandleXrpaDelete() {
    _xrpaDeleteHandler?.Invoke();
  }

  public void OnXrpaDelete(System.Action handler) {
    _xrpaDeleteHandler = handler;
  }

  public void ProcessDSUpdate(CameraDeviceReader value, ulong fieldsChanged) {
    if (value.CheckNameChanged(fieldsChanged)) {
      _localName = value.GetName();
    }
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public static ReconciledCameraDevice Create(Xrpa.ObjectUuid id, CameraDeviceReader obj, Xrpa.IObjectCollection collection) {
    return new ReconciledCameraDevice(id, collection);
  }

  public string GetName() {
    return _localName;
  }

  public bool CheckNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }

  public virtual void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
  }

  public ulong PrepDSFullUpdate() {
    return 0;
  }
}

// Object Collections
public class InboundCameraDeviceReaderCollection : Xrpa.ObjectCollection<CameraDeviceReader, ReconciledCameraDevice> {
  public InboundCameraDeviceReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 0, 1, 0, false) {
    SetCreateDelegateInternal(ReconciledCameraDevice.Create);
  }

  public void SetCreateDelegate(CreateDelegateFunction createDelegate) {
    SetCreateDelegateInternal(createDelegate);
  }
}

public class OutboundCameraFeedReaderCollection : Xrpa.ObjectCollection<CameraFeedReader, OutboundCameraFeed> {
  public OutboundCameraFeedReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 1, 0, 0, true) {}

  public void AddObject(OutboundCameraFeed obj) {
    AddObjectInternal(obj);
  }

  public OutboundCameraFeed CreateObject() {
    var obj = new OutboundCameraFeed(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

// Data Store Implementation
public class CameraDataStore : Xrpa.DataStoreReconciler {
  public CameraDataStore(Xrpa.TransportStream inboundTransport, Xrpa.TransportStream outboundTransport)
      : base(inboundTransport, outboundTransport, 11895120) {
    CameraDevice = new InboundCameraDeviceReaderCollection(this);
    RegisterCollection(CameraDevice);
    CameraFeed = new OutboundCameraFeedReaderCollection(this);
    RegisterCollection(CameraFeed);
  }

  public InboundCameraDeviceReaderCollection CameraDevice;
  public OutboundCameraFeedReaderCollection CameraFeed;
}

} // namespace CameraDataStore
