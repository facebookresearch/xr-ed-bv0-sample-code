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
using System.Collections.Generic;
using UnityEngine;
using Xrpa;

namespace SmartControllerDataStore {

public class InputEventReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public InputEventReader() {}

  public InputEventReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public InputEventType GetType() {
    return (InputEventType)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public int GetSource() {
    return _memAccessor.ReadInt(_readOffset);
  }
}

public class InputEventWriter : InputEventReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public InputEventWriter() {}

  public InputEventWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetType(InputEventType value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetSource(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }
}

public class PositionEventReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public PositionEventReader() {}

  public PositionEventReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public int GetPosition() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetAbsolutePosition() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetDetentPosition() {
    return _memAccessor.ReadInt(_readOffset);
  }
}

public class PositionEventWriter : PositionEventReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public PositionEventWriter() {}

  public PositionEventWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetPosition(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetAbsolutePosition(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetDetentPosition(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }
}

public class KnobControlReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public KnobControlReader() {}

  public KnobControlReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // IP address of the device to control
  public string GetIpAddress() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Whether the device is connected
  public bool GetIsConnected() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  public KnobControlMode GetControlMode() {
    return (KnobControlMode)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  // Position to set the knob to, when controlMode == Position
  public int GetPosition() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Number of detents to set the knob to, when controlMode == Detent
  public int GetDetentCount() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public bool CheckIpAddressChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckIsConnectedChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckControlModeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckPositionChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckDetentCountChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }
}

public class KnobControlWriter : KnobControlReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public KnobControlWriter() {}

  public KnobControlWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static KnobControlWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new KnobControlWriter(changeEvent.AccessChangeData());
  }

  public static KnobControlWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new KnobControlWriter(changeEvent.AccessChangeData());
  }

  public void SetIpAddress(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetIsConnected(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetControlMode(KnobControlMode value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetPosition(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetDetentCount(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }
}

public class LightControlReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public LightControlReader() {}

  public LightControlReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // IP address of the device to control
  public string GetIpAddress() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Whether the device is connected
  public bool GetIsConnected() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  public System.Collections.Generic.List<UnityEngine.Color32> GetLightColors() {
    return DSColorSRGBA_24.ReadValue(_memAccessor, _readOffset);
  }

  public float GetRotationOffset() {
    return DSAngle.ReadValue(_memAccessor, _readOffset);
  }

  public float GetRotationSpeed() {
    return DSAngle.ReadValue(_memAccessor, _readOffset);
  }

  // Priority of the light, lower values will be applied first, with higher values alpha-blended on top
  public int GetPriority() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public bool CheckIpAddressChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckIsConnectedChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckLightColorsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckRotationOffsetChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckRotationSpeedChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckPriorityChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }
}

public class LightControlWriter : LightControlReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public LightControlWriter() {}

  public LightControlWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static LightControlWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new LightControlWriter(changeEvent.AccessChangeData());
  }

  public static LightControlWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new LightControlWriter(changeEvent.AccessChangeData());
  }

  public void SetIpAddress(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetIsConnected(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetLightColors(System.Collections.Generic.List<UnityEngine.Color32> value) {
    DSColorSRGBA_24.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetRotationOffset(float value) {
    DSAngle.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetRotationSpeed(float value) {
    DSAngle.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetPriority(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }
}

// Reconciled Types
public class OutboundKnobControl : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<KnobControlReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;

  // Whether the device is connected
  private bool _localIsConnected = false;
  private System.Action<ulong, InputEventReader> _inputEventMessageHandler = null;
  private System.Action<ulong, PositionEventReader> _positionEventMessageHandler = null;

  // IP address of the device to control
  protected string _localIpAddress = "";
  protected KnobControlMode _localControlMode = KnobControlMode.Disabled;

  // Position to set the knob to, when controlMode == Position
  protected int _localPosition = 0;

  // Number of detents to set the knob to, when controlMode == Detent
  protected int _localDetentCount = 10;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundKnobControl(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public string GetIpAddress() {
    return _localIpAddress;
  }

  public void SetIpAddress(string ipAddress) {
    _localIpAddress = ipAddress;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localIpAddress);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public KnobControlMode GetControlMode() {
    return _localControlMode;
  }

  public void SetControlMode(KnobControlMode controlMode) {
    _localControlMode = controlMode;
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

  public int GetPosition() {
    return _localPosition;
  }

  public void SetPosition(int position) {
    _localPosition = position;
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

  public int GetDetentCount() {
    return _localDetentCount;
  }

  public void SetDetentCount(int detentCount) {
    _localDetentCount = detentCount;
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

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    KnobControlWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 29;
      _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localIpAddress) + 16;
      objAccessor = KnobControlWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = KnobControlWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetIpAddress(_localIpAddress);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetControlMode(_localControlMode);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetPosition(_localPosition);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetDetentCount(_localDetentCount);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 29;
    _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localIpAddress) + 16;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(KnobControlReader value, ulong fieldsChanged) {
    if (value.CheckIsConnectedChanged(fieldsChanged)) {
      _localIsConnected = value.GetIsConnected();
    }
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool GetIsConnected() {
    return _localIsConnected;
  }

  public bool CheckIpAddressChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckIsConnectedChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckControlModeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckPositionChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckDetentCountChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public void OnInputEvent(System.Action<ulong, InputEventReader> handler) {
    _inputEventMessageHandler = handler;
  }

  public void OnPositionEvent(System.Action<ulong, PositionEventReader> handler) {
    _positionEventMessageHandler = handler;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
    if (messageType == 5) {
      InputEventReader message = new(messageData);
      _inputEventMessageHandler?.Invoke(msgTimestamp, message);
    }
    if (messageType == 6) {
      PositionEventReader message = new(messageData);
      _positionEventMessageHandler?.Invoke(msgTimestamp, message);
    }
  }
}

public class OutboundLightControl : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<LightControlReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;

  // Whether the device is connected
  private bool _localIsConnected = false;

  // IP address of the device to control
  protected string _localIpAddress = "";
  protected System.Collections.Generic.List<UnityEngine.Color32> _localLightColors = new System.Collections.Generic.List<UnityEngine.Color32>{new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}};
  protected float _localRotationOffset = 0f;
  protected float _localRotationSpeed = 0f;

  // Priority of the light, lower values will be applied first, with higher values alpha-blended on top
  protected int _localPriority = 0;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundLightControl(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public string GetIpAddress() {
    return _localIpAddress;
  }

  public void SetIpAddress(string ipAddress) {
    _localIpAddress = ipAddress;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localIpAddress);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public System.Collections.Generic.List<UnityEngine.Color32> GetLightColors() {
    return _localLightColors;
  }

  public void SetLightColors(System.Collections.Generic.List<UnityEngine.Color32> lightColors) {
    _localLightColors = lightColors;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 384;
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

  public float GetRotationOffset() {
    return _localRotationOffset;
  }

  public void SetRotationOffset(float rotationOffset) {
    _localRotationOffset = rotationOffset;
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

  public float GetRotationSpeed() {
    return _localRotationSpeed;
  }

  public void SetRotationSpeed(float rotationSpeed) {
    _localRotationSpeed = rotationSpeed;
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

  public int GetPriority() {
    return _localPriority;
  }

  public void SetPriority(int priority) {
    _localPriority = priority;
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

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    LightControlWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 61;
      _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localIpAddress) + 400;
      objAccessor = LightControlWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = LightControlWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetIpAddress(_localIpAddress);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetLightColors(_localLightColors);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetRotationOffset(_localRotationOffset);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetRotationSpeed(_localRotationSpeed);
    }
    if ((_changeBits & 32) != 0) {
      objAccessor.SetPriority(_localPriority);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 61;
    _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localIpAddress) + 400;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(LightControlReader value, ulong fieldsChanged) {
    if (value.CheckIsConnectedChanged(fieldsChanged)) {
      _localIsConnected = value.GetIsConnected();
    }
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool GetIsConnected() {
    return _localIsConnected;
  }

  public bool CheckIpAddressChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckIsConnectedChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckLightColorsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckRotationOffsetChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckRotationSpeedChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckPriorityChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

// Object Collections
public class OutboundKnobControlReaderCollection : Xrpa.ObjectCollection<KnobControlReader, OutboundKnobControl> {
  public OutboundKnobControlReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 0, 2, 0, true) {}

  public void AddObject(OutboundKnobControl obj) {
    AddObjectInternal(obj);
  }

  public OutboundKnobControl CreateObject() {
    var obj = new OutboundKnobControl(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundLightControlReaderCollection : Xrpa.ObjectCollection<LightControlReader, OutboundLightControl> {
  public OutboundLightControlReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 1, 2, 0, true) {}

  public void AddObject(OutboundLightControl obj) {
    AddObjectInternal(obj);
  }

  public OutboundLightControl CreateObject() {
    var obj = new OutboundLightControl(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

// Data Store Implementation
public class SmartControllerDataStore : Xrpa.DataStoreReconciler {
  public SmartControllerDataStore(Xrpa.TransportStream inboundTransport, Xrpa.TransportStream outboundTransport)
      : base(inboundTransport, outboundTransport, 1104) {
    KnobControl = new OutboundKnobControlReaderCollection(this);
    RegisterCollection(KnobControl);
    LightControl = new OutboundLightControlReaderCollection(this);
    RegisterCollection(LightControl);
  }

  public OutboundKnobControlReaderCollection KnobControl;
  public OutboundLightControlReaderCollection LightControl;
}

} // namespace SmartControllerDataStore
