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

namespace AudioInputDataStore {

public class AudioInputDeviceReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public AudioInputDeviceReader() {}

  public AudioInputDeviceReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // Human-readable device name
  public string GetDeviceName() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Number of channels available
  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Default frame rate for audio capture
  public int GetFrameRate() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Whether this is the default input device
  public bool GetIsSystemAudioInput() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  public bool CheckDeviceNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckFrameRateChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckIsSystemAudioInputChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }
}

public class AudioInputDeviceWriter : AudioInputDeviceReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public AudioInputDeviceWriter() {}

  public AudioInputDeviceWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static AudioInputDeviceWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new AudioInputDeviceWriter(changeEvent.AccessChangeData());
  }

  public static AudioInputDeviceWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new AudioInputDeviceWriter(changeEvent.AccessChangeData());
  }

  public void SetDeviceName(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetFrameRate(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetIsSystemAudioInput(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }
}

public class AudioInputSourceReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public AudioInputSourceReader() {}

  public AudioInputSourceReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public DeviceBindingType GetBindTo() {
    return (DeviceBindingType)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public Xrpa.ObjectUuid GetDevice() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public string GetDeviceName() {
    return _memAccessor.ReadString(_readOffset);
  }

  public string GetHostname() {
    return _memAccessor.ReadString(_readOffset);
  }

  public int GetPort() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Frame rate for audio capture
  public int GetFrameRate() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Number of channels for audio capture
  public int GetNumChannels() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Whether audio input is currently active
  public bool GetIsActive() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  // Error message if audio input failed
  public string GetErrorMessage() {
    return _memAccessor.ReadString(_readOffset);
  }

  public bool CheckBindToChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckDeviceChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckDeviceNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckHostnameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckPortChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckFrameRateChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckIsActiveChanged(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckErrorMessageChanged(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }
}

public class AudioInputSourceWriter : AudioInputSourceReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public AudioInputSourceWriter() {}

  public AudioInputSourceWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static AudioInputSourceWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new AudioInputSourceWriter(changeEvent.AccessChangeData());
  }

  public static AudioInputSourceWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new AudioInputSourceWriter(changeEvent.AccessChangeData());
  }

  public void SetBindTo(DeviceBindingType value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetDevice(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetDeviceName(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetHostname(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetPort(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetFrameRate(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetIsActive(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetErrorMessage(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }
}

// Reconciled Types
public class OutboundAudioInputSource : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<AudioInputSourceReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;

  // Whether audio input is currently active
  private bool _localIsActive = false;

  // Error message if audio input failed
  private string _localErrorMessage = "";
  private Xrpa.InboundSignalDataInterface _audioSignalSignalHandler = null;
  protected DeviceBindingType _localBindTo = DeviceBindingType.Device;
  protected Xrpa.ObjectUuid _localDevice = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected string _localDeviceName = "";
  protected string _localHostname = "";
  protected int _localPort = 0;

  // Frame rate for audio capture
  protected int _localFrameRate = 48000;

  // Number of channels for audio capture
  protected int _localNumChannels = 2;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundAudioInputSource(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public DeviceBindingType GetBindTo() {
    return _localBindTo;
  }

  public void SetBindTo(DeviceBindingType bindTo) {
    _localBindTo = bindTo;
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

  public Xrpa.ObjectUuid GetDevice() {
    return _localDevice;
  }

  public void SetDevice(Xrpa.ObjectUuid device) {
    _localDevice = device;
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

  public string GetDeviceName() {
    return _localDeviceName;
  }

  public void SetDeviceName(string deviceName) {
    _localDeviceName = deviceName;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localDeviceName);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public string GetHostname() {
    return _localHostname;
  }

  public void SetHostname(string hostname) {
    _localHostname = hostname;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localHostname);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public int GetPort() {
    return _localPort;
  }

  public void SetPort(int port) {
    _localPort = port;
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

  public int GetFrameRate() {
    return _localFrameRate;
  }

  public void SetFrameRate(int frameRate) {
    _localFrameRate = frameRate;
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

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public void SetNumChannels(int numChannels) {
    _localNumChannels = numChannels;
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

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    AudioInputSourceWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 127;
      _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localDeviceName) + Xrpa.MemoryAccessor.DynSizeOfString(_localHostname) + 40;
      objAccessor = AudioInputSourceWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = AudioInputSourceWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetBindTo(_localBindTo);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetDevice(_localDevice);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetDeviceName(_localDeviceName);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetHostname(_localHostname);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetPort(_localPort);
    }
    if ((_changeBits & 32) != 0) {
      objAccessor.SetFrameRate(_localFrameRate);
    }
    if ((_changeBits & 64) != 0) {
      objAccessor.SetNumChannels(_localNumChannels);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 127;
    _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localDeviceName) + Xrpa.MemoryAccessor.DynSizeOfString(_localHostname) + 40;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(AudioInputSourceReader value, ulong fieldsChanged) {
    if (value.CheckIsActiveChanged(fieldsChanged)) {
      _localIsActive = value.GetIsActive();
    }
    if (value.CheckErrorMessageChanged(fieldsChanged)) {
      _localErrorMessage = value.GetErrorMessage();
    }
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool GetIsActive() {
    return _localIsActive;
  }

  public string GetErrorMessage() {
    return _localErrorMessage;
  }

  public bool CheckBindToChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckDeviceChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckDeviceNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckHostnameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckPortChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckFrameRateChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckIsActiveChanged(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckErrorMessageChanged(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public void OnAudioSignal(Xrpa.InboundSignalDataInterface handler) {
    _audioSignalSignalHandler = handler;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
    if (messageType == 7) {
      _audioSignalSignalHandler?.OnSignalData(msgTimestamp, messageData);
    }
  }
}

public class ReconciledAudioInputDevice : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<AudioInputDeviceReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  private System.Action _xrpaDeleteHandler = null;

  // Human-readable device name
  private string _localDeviceName = "";

  // Number of channels available
  private int _localNumChannels = 2;

  // Default frame rate for audio capture
  private int _localFrameRate = 48000;

  // Whether this is the default input device
  private bool _localIsSystemAudioInput = false;

  public ReconciledAudioInputDevice(Xrpa.ObjectUuid id, Xrpa.IObjectCollection collection) : base(id, collection) {}

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

  public void ProcessDSUpdate(AudioInputDeviceReader value, ulong fieldsChanged) {
    if (value.CheckDeviceNameChanged(fieldsChanged)) {
      _localDeviceName = value.GetDeviceName();
    }
    if (value.CheckNumChannelsChanged(fieldsChanged)) {
      _localNumChannels = value.GetNumChannels();
    }
    if (value.CheckFrameRateChanged(fieldsChanged)) {
      _localFrameRate = value.GetFrameRate();
    }
    if (value.CheckIsSystemAudioInputChanged(fieldsChanged)) {
      _localIsSystemAudioInput = value.GetIsSystemAudioInput();
    }
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public static ReconciledAudioInputDevice Create(Xrpa.ObjectUuid id, AudioInputDeviceReader obj, Xrpa.IObjectCollection collection) {
    return new ReconciledAudioInputDevice(id, collection);
  }

  public string GetDeviceName() {
    return _localDeviceName;
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public int GetFrameRate() {
    return _localFrameRate;
  }

  public bool GetIsSystemAudioInput() {
    return _localIsSystemAudioInput;
  }

  public bool CheckDeviceNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckFrameRateChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckIsSystemAudioInputChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
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
public class InboundAudioInputDeviceReaderCollection : Xrpa.ObjectCollection<AudioInputDeviceReader, ReconciledAudioInputDevice> {
  public InboundAudioInputDeviceReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 0, 15, 0, false) {
    SetCreateDelegateInternal(ReconciledAudioInputDevice.Create);
  }

  public void SetCreateDelegate(CreateDelegateFunction createDelegate) {
    SetCreateDelegateInternal(createDelegate);
  }
}

public class OutboundAudioInputSourceReaderCollection : Xrpa.ObjectCollection<AudioInputSourceReader, OutboundAudioInputSource> {
  public OutboundAudioInputSourceReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 1, 384, 0, true) {}

  public void AddObject(OutboundAudioInputSource obj) {
    AddObjectInternal(obj);
  }

  public OutboundAudioInputSource CreateObject() {
    var obj = new OutboundAudioInputSource(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

// Data Store Implementation
public class AudioInputDataStore : Xrpa.DataStoreReconciler {
  public AudioInputDataStore(Xrpa.TransportStream inboundTransport, Xrpa.TransportStream outboundTransport)
      : base(inboundTransport, outboundTransport, 1237120) {
    AudioInputDevice = new InboundAudioInputDeviceReaderCollection(this);
    RegisterCollection(AudioInputDevice);
    AudioInputSource = new OutboundAudioInputSourceReaderCollection(this);
    RegisterCollection(AudioInputSource);
  }

  public InboundAudioInputDeviceReaderCollection AudioInputDevice;
  public OutboundAudioInputSourceReaderCollection AudioInputSource;
}

} // namespace AudioInputDataStore
