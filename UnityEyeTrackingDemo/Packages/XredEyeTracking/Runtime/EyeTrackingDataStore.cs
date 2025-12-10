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
using UnityEngine;
using Xrpa;

namespace EyeTrackingDataStore {

public class SceneCameraReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public SceneCameraReader() {}

  public SceneCameraReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public Xrpa.Image GetImage() {
    return DSSceneImage.ReadValue(_memAccessor, _readOffset);
  }

  // Gaze position in scene camera pixels corresponding to this frame
  public UnityEngine.Vector2 GetGazePosition() {
    return DSScale2.ReadValue(_memAccessor, _readOffset);
  }
}

public class SceneCameraWriter : SceneCameraReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public SceneCameraWriter() {}

  public SceneCameraWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetImage(Xrpa.Image value) {
    DSSceneImage.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetGazePosition(UnityEngine.Vector2 value) {
    DSScale2.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class ImuDataReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public ImuDataReader() {}

  public ImuDataReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // Timestamp of the IMU sample
  public ulong GetTimestamp() {
    return _memAccessor.ReadUlong(_readOffset);
  }

  // Gyroscope data in deg/s (X-right, Y-forward, Z-up)
  public UnityEngine.Vector3 GetGyro() {
    return DSVector3.ReadValue(_memAccessor, _readOffset);
  }

  // Accelerometer data in m/s² (X-right, Y-forward, Z-up)
  public UnityEngine.Vector3 GetAccel() {
    return DSVector3.ReadValue(_memAccessor, _readOffset);
  }
}

public class ImuDataWriter : ImuDataReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public ImuDataWriter() {}

  public ImuDataWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetTimestamp(ulong value) {
    _memAccessor.WriteUlong(value, _writeOffset);
  }

  public void SetGyro(UnityEngine.Vector3 value) {
    DSVector3.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetAccel(UnityEngine.Vector3 value) {
    DSVector3.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class EyeEventReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public EyeEventReader() {}

  public EyeEventReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public EyeEventType GetEventType() {
    return (EyeEventType)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  // Event start timestamp
  public ulong GetStartTime() {
    return _memAccessor.ReadUlong(_readOffset);
  }

  // Event end timestamp
  public ulong GetEndTime() {
    return _memAccessor.ReadUlong(_readOffset);
  }

  // Mean gaze position in scene camera pixels
  public UnityEngine.Vector2 GetMeanGaze() {
    return DSScale2.ReadValue(_memAccessor, _readOffset);
  }

  // Event amplitude in degrees
  public float GetAmplitude() {
    return DSAngle.ReadValue(_memAccessor, _readOffset);
  }

  // Maximum velocity in pixels/degree
  public float GetMaxVelocity() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }
}

public class EyeEventWriter : EyeEventReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public EyeEventWriter() {}

  public EyeEventWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetEventType(EyeEventType value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetStartTime(ulong value) {
    _memAccessor.WriteUlong(value, _writeOffset);
  }

  public void SetEndTime(ulong value) {
    _memAccessor.WriteUlong(value, _writeOffset);
  }

  public void SetMeanGaze(UnityEngine.Vector2 value) {
    DSScale2.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetAmplitude(float value) {
    DSAngle.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetMaxVelocity(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class EyeTrackingDeviceReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public EyeTrackingDeviceReader() {}

  public EyeTrackingDeviceReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // Network address or device name for discovery
  public string GetDeviceAddress() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Enable gaze data streaming
  public bool GetStreamGaze() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  // Enable scene camera streaming
  public bool GetStreamSceneCamera() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  // Enable IMU data streaming
  public bool GetStreamImu() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  // Enable eye events (blinks, fixations, saccades)
  public bool GetStreamEyeEvents() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  // Enable audio streaming
  public bool GetStreamAudio() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  // Human-readable device name
  public string GetDeviceName() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Hardware version info
  public string GetHardwareVersion() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Device serial number
  public string GetSerialNumber() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Connection status
  public bool GetIsConnected() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  // Camera calibration data (JSON format)
  public string GetCalibrationJson() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Last data update timestamp
  public ulong GetLastUpdate() {
    return _memAccessor.ReadUlong(_readOffset);
  }

  // Head orientation (always updated)
  public UnityEngine.Quaternion GetHeadOrientation() {
    return DSQuaternion.ReadValue(_memAccessor, _readOffset);
  }

  // Gaze direction in world space
  public UnityEngine.Vector3 GetGazeDirection() {
    return DSUnitVector3.ReadValue(_memAccessor, _readOffset);
  }

  // Whether glasses are worn
  public bool GetWorn() {
    return (_memAccessor.ReadInt(_readOffset) == 1 ? true : false);
  }

  // Left pupil diameter
  public float GetPupilDiameterLeft() {
    return DSDistance.ReadValue(_memAccessor, _readOffset);
  }

  // Right pupil diameter
  public float GetPupilDiameterRight() {
    return DSDistance.ReadValue(_memAccessor, _readOffset);
  }

  // Current scene camera frame rate
  public int GetSceneCameraFrameRate() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public bool CheckDeviceAddressChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckStreamGazeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckStreamSceneCameraChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckStreamImuChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckStreamEyeEventsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckStreamAudioChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckDeviceNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckHardwareVersionChanged(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckSerialNumberChanged(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public bool CheckIsConnectedChanged(ulong fieldsChanged) {
    return (fieldsChanged & 512) != 0;
  }

  public bool CheckCalibrationJsonChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1024) != 0;
  }

  public bool CheckLastUpdateChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2048) != 0;
  }

  public bool CheckHeadOrientationChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4096) != 0;
  }

  public bool CheckGazeDirectionChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8192) != 0;
  }

  public bool CheckWornChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16384) != 0;
  }

  public bool CheckPupilDiameterLeftChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32768) != 0;
  }

  public bool CheckPupilDiameterRightChanged(ulong fieldsChanged) {
    return (fieldsChanged & 65536) != 0;
  }

  public bool CheckSceneCameraFrameRateChanged(ulong fieldsChanged) {
    return (fieldsChanged & 131072) != 0;
  }
}

public class EyeTrackingDeviceWriter : EyeTrackingDeviceReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public EyeTrackingDeviceWriter() {}

  public EyeTrackingDeviceWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static EyeTrackingDeviceWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new EyeTrackingDeviceWriter(changeEvent.AccessChangeData());
  }

  public static EyeTrackingDeviceWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new EyeTrackingDeviceWriter(changeEvent.AccessChangeData());
  }

  public void SetDeviceAddress(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetStreamGaze(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetStreamSceneCamera(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetStreamImu(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetStreamEyeEvents(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetStreamAudio(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetDeviceName(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetHardwareVersion(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetSerialNumber(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetIsConnected(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetCalibrationJson(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetLastUpdate(ulong value) {
    _memAccessor.WriteUlong(value, _writeOffset);
  }

  public void SetHeadOrientation(UnityEngine.Quaternion value) {
    DSQuaternion.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetGazeDirection(UnityEngine.Vector3 value) {
    DSUnitVector3.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetWorn(bool value) {
    _memAccessor.WriteInt((value ? 1 : 0), _writeOffset);
  }

  public void SetPupilDiameterLeft(float value) {
    DSDistance.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetPupilDiameterRight(float value) {
    DSDistance.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetSceneCameraFrameRate(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }
}

// Reconciled Types
public class OutboundEyeTrackingDevice : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<EyeTrackingDeviceReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;

  // Human-readable device name
  private string _localDeviceName = "";

  // Hardware version info
  private string _localHardwareVersion = "";

  // Device serial number
  private string _localSerialNumber = "";

  // Connection status
  private bool _localIsConnected = false;

  // Camera calibration data (JSON format)
  private string _localCalibrationJson = "";

  // Last data update timestamp
  private ulong _localLastUpdate = 0UL;

  // Head orientation (always updated)
  private UnityEngine.Quaternion _localHeadOrientation = new UnityEngine.Quaternion{x = 0f, y = 0f, z = 0f, w = 1f};

  // Gaze direction in world space
  private UnityEngine.Vector3 _localGazeDirection = new UnityEngine.Vector3{x = 0f, y = 0f, z = -1f};

  // Whether glasses are worn
  private bool _localWorn = false;

  // Left pupil diameter
  private float _localPupilDiameterLeft = 0f;

  // Right pupil diameter
  private float _localPupilDiameterRight = 0f;

  // Current scene camera frame rate
  private int _localSceneCameraFrameRate = 0;
  private System.Action<ulong, SceneCameraReader> _sceneCameraMessageHandler = null;
  private System.Action<ulong, ImuDataReader> _imuDataMessageHandler = null;
  private System.Action<ulong, EyeEventReader> _eyeEventMessageHandler = null;
  private Xrpa.InboundSignalDataInterface _audioSignalHandler = null;

  // Network address or device name for discovery
  protected string _localDeviceAddress = "";

  // Enable gaze data streaming
  protected bool _localStreamGaze = false;

  // Enable scene camera streaming
  protected bool _localStreamSceneCamera = false;

  // Enable IMU data streaming
  protected bool _localStreamImu = false;

  // Enable eye events (blinks, fixations, saccades)
  protected bool _localStreamEyeEvents = false;

  // Enable audio streaming
  protected bool _localStreamAudio = false;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundEyeTrackingDevice(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public string GetDeviceAddress() {
    return _localDeviceAddress;
  }

  public void SetDeviceAddress(string deviceAddress) {
    _localDeviceAddress = deviceAddress;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localDeviceAddress);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public bool GetStreamGaze() {
    return _localStreamGaze;
  }

  public void SetStreamGaze(bool streamGaze) {
    _localStreamGaze = streamGaze;
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

  public bool GetStreamSceneCamera() {
    return _localStreamSceneCamera;
  }

  public void SetStreamSceneCamera(bool streamSceneCamera) {
    _localStreamSceneCamera = streamSceneCamera;
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

  public bool GetStreamImu() {
    return _localStreamImu;
  }

  public void SetStreamImu(bool streamImu) {
    _localStreamImu = streamImu;
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

  public bool GetStreamEyeEvents() {
    return _localStreamEyeEvents;
  }

  public void SetStreamEyeEvents(bool streamEyeEvents) {
    _localStreamEyeEvents = streamEyeEvents;
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

  public bool GetStreamAudio() {
    return _localStreamAudio;
  }

  public void SetStreamAudio(bool streamAudio) {
    _localStreamAudio = streamAudio;
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
    EyeTrackingDeviceWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 63;
      _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localDeviceAddress) + 24;
      objAccessor = EyeTrackingDeviceWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = EyeTrackingDeviceWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetDeviceAddress(_localDeviceAddress);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetStreamGaze(_localStreamGaze);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetStreamSceneCamera(_localStreamSceneCamera);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetStreamImu(_localStreamImu);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetStreamEyeEvents(_localStreamEyeEvents);
    }
    if ((_changeBits & 32) != 0) {
      objAccessor.SetStreamAudio(_localStreamAudio);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 63;
    _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localDeviceAddress) + 24;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(EyeTrackingDeviceReader value, ulong fieldsChanged) {
    if (value.CheckDeviceNameChanged(fieldsChanged)) {
      _localDeviceName = value.GetDeviceName();
    }
    if (value.CheckHardwareVersionChanged(fieldsChanged)) {
      _localHardwareVersion = value.GetHardwareVersion();
    }
    if (value.CheckSerialNumberChanged(fieldsChanged)) {
      _localSerialNumber = value.GetSerialNumber();
    }
    if (value.CheckIsConnectedChanged(fieldsChanged)) {
      _localIsConnected = value.GetIsConnected();
    }
    if (value.CheckCalibrationJsonChanged(fieldsChanged)) {
      _localCalibrationJson = value.GetCalibrationJson();
    }
    if (value.CheckLastUpdateChanged(fieldsChanged)) {
      _localLastUpdate = value.GetLastUpdate();
    }
    if (value.CheckHeadOrientationChanged(fieldsChanged)) {
      _localHeadOrientation = value.GetHeadOrientation();
    }
    if (value.CheckGazeDirectionChanged(fieldsChanged)) {
      _localGazeDirection = value.GetGazeDirection();
    }
    if (value.CheckWornChanged(fieldsChanged)) {
      _localWorn = value.GetWorn();
    }
    if (value.CheckPupilDiameterLeftChanged(fieldsChanged)) {
      _localPupilDiameterLeft = value.GetPupilDiameterLeft();
    }
    if (value.CheckPupilDiameterRightChanged(fieldsChanged)) {
      _localPupilDiameterRight = value.GetPupilDiameterRight();
    }
    if (value.CheckSceneCameraFrameRateChanged(fieldsChanged)) {
      _localSceneCameraFrameRate = value.GetSceneCameraFrameRate();
    }
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public string GetDeviceName() {
    return _localDeviceName;
  }

  public string GetHardwareVersion() {
    return _localHardwareVersion;
  }

  public string GetSerialNumber() {
    return _localSerialNumber;
  }

  public bool GetIsConnected() {
    return _localIsConnected;
  }

  public string GetCalibrationJson() {
    return _localCalibrationJson;
  }

  public ulong GetLastUpdate() {
    return _localLastUpdate;
  }

  public UnityEngine.Quaternion GetHeadOrientation() {
    return _localHeadOrientation;
  }

  public UnityEngine.Vector3 GetGazeDirection() {
    return _localGazeDirection;
  }

  public bool GetWorn() {
    return _localWorn;
  }

  public float GetPupilDiameterLeft() {
    return _localPupilDiameterLeft;
  }

  public float GetPupilDiameterRight() {
    return _localPupilDiameterRight;
  }

  public int GetSceneCameraFrameRate() {
    return _localSceneCameraFrameRate;
  }

  public bool CheckDeviceAddressChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckStreamGazeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckStreamSceneCameraChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckStreamImuChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckStreamEyeEventsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckStreamAudioChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckDeviceNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckHardwareVersionChanged(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckSerialNumberChanged(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public bool CheckIsConnectedChanged(ulong fieldsChanged) {
    return (fieldsChanged & 512) != 0;
  }

  public bool CheckCalibrationJsonChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1024) != 0;
  }

  public bool CheckLastUpdateChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2048) != 0;
  }

  public bool CheckHeadOrientationChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4096) != 0;
  }

  public bool CheckGazeDirectionChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8192) != 0;
  }

  public bool CheckWornChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16384) != 0;
  }

  public bool CheckPupilDiameterLeftChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32768) != 0;
  }

  public bool CheckPupilDiameterRightChanged(ulong fieldsChanged) {
    return (fieldsChanged & 65536) != 0;
  }

  public bool CheckSceneCameraFrameRateChanged(ulong fieldsChanged) {
    return (fieldsChanged & 131072) != 0;
  }

  public void OnSceneCamera(System.Action<ulong, SceneCameraReader> handler) {
    _sceneCameraMessageHandler = handler;
  }

  public void OnImuData(System.Action<ulong, ImuDataReader> handler) {
    _imuDataMessageHandler = handler;
  }

  public void OnEyeEvent(System.Action<ulong, EyeEventReader> handler) {
    _eyeEventMessageHandler = handler;
  }

  public void OnAudio(Xrpa.InboundSignalDataInterface handler) {
    _audioSignalHandler = handler;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
    if (messageType == 17) {
      SceneCameraReader message = new(messageData);
      _sceneCameraMessageHandler?.Invoke(msgTimestamp, message);
    }
    if (messageType == 19) {
      ImuDataReader message = new(messageData);
      _imuDataMessageHandler?.Invoke(msgTimestamp, message);
    }
    if (messageType == 20) {
      EyeEventReader message = new(messageData);
      _eyeEventMessageHandler?.Invoke(msgTimestamp, message);
    }
    if (messageType == 21) {
      _audioSignalHandler?.OnSignalData(msgTimestamp, messageData);
    }
  }
}

// Object Collections
public class OutboundEyeTrackingDeviceReaderCollection : Xrpa.ObjectCollection<EyeTrackingDeviceReader, OutboundEyeTrackingDevice> {
  public OutboundEyeTrackingDeviceReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 0, 262080, 0, true) {}

  public void AddObject(OutboundEyeTrackingDevice obj) {
    AddObjectInternal(obj);
  }

  public OutboundEyeTrackingDevice CreateObject() {
    var obj = new OutboundEyeTrackingDevice(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

// Data Store Implementation
public class EyeTrackingDataStore : Xrpa.DataStoreReconciler {
  public EyeTrackingDataStore(Xrpa.TransportStream inboundTransport, Xrpa.TransportStream outboundTransport)
      : base(inboundTransport, outboundTransport, 34872064) {
    EyeTrackingDevice = new OutboundEyeTrackingDeviceReaderCollection(this);
    RegisterCollection(EyeTrackingDevice);
  }

  public OutboundEyeTrackingDeviceReaderCollection EyeTrackingDevice;
}

} // namespace EyeTrackingDataStore
