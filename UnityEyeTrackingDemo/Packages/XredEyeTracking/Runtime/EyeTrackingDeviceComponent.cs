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

#pragma warning disable CS0414

using EyeTrackingDataStore;
using System;
using UnityEngine;
using Xrpa;

public class EyeTrackingDeviceComponent : MonoBehaviour {
  [SerializeField]

  // Network address or device name for discovery
  private string _DeviceAddress = "";

  public string DeviceAddress {
    get => _DeviceAddress;
    set {
      _DeviceAddress = value;
      if (_xrpaObject != null) { _xrpaObject.SetDeviceAddress(value); }
    }
  }

  [SerializeField]

  // Enable gaze data streaming
  private bool _StreamGaze = false;

  public bool StreamGaze {
    get => _StreamGaze;
    set {
      _StreamGaze = value;
      if (_xrpaObject != null) { _xrpaObject.SetStreamGaze(value); }
    }
  }

  [SerializeField]

  // Enable scene camera streaming
  private bool _StreamSceneCamera = false;

  public bool StreamSceneCamera {
    get => _StreamSceneCamera;
    set {
      _StreamSceneCamera = value;
      if (_xrpaObject != null) { _xrpaObject.SetStreamSceneCamera(value); }
    }
  }

  [SerializeField]

  // Enable IMU data streaming
  private bool _StreamImu = false;

  public bool StreamImu {
    get => _StreamImu;
    set {
      _StreamImu = value;
      if (_xrpaObject != null) { _xrpaObject.SetStreamImu(value); }
    }
  }

  [SerializeField]

  // Enable eye events (blinks, fixations, saccades)
  private bool _StreamEyeEvents = false;

  public bool StreamEyeEvents {
    get => _StreamEyeEvents;
    set {
      _StreamEyeEvents = value;
      if (_xrpaObject != null) { _xrpaObject.SetStreamEyeEvents(value); }
    }
  }

  [SerializeField]

  // Enable audio streaming
  private bool _StreamAudio = false;

  public bool StreamAudio {
    get => _StreamAudio;
    set {
      _StreamAudio = value;
      if (_xrpaObject != null) { _xrpaObject.SetStreamAudio(value); }
    }
  }

  // Human-readable device name
  private string _DeviceName = "";

  public string DeviceName {
    get => _DeviceName;
  }

  // Hardware version info
  private string _HardwareVersion = "";

  public string HardwareVersion {
    get => _HardwareVersion;
  }

  // Device serial number
  private string _SerialNumber = "";

  public string SerialNumber {
    get => _SerialNumber;
  }

  // Connection status
  private bool _IsConnected = false;

  public bool IsConnected {
    get => _IsConnected;
  }

  // Camera calibration data (JSON format)
  private string _CalibrationJson = "";

  public string CalibrationJson {
    get => _CalibrationJson;
  }

  // Last data update timestamp
  private ulong _LastUpdate = 0UL;

  public ulong LastUpdate {
    get => _LastUpdate;
  }

  // Head orientation (always updated)
  private UnityEngine.Quaternion _HeadOrientation = new UnityEngine.Quaternion{x = 0f, y = 0f, z = 0f, w = 1f};

  public UnityEngine.Quaternion HeadOrientation {
    get => _HeadOrientation;
  }

  // Gaze direction in world space
  private UnityEngine.Vector3 _GazeDirection = new UnityEngine.Vector3{x = 0f, y = 0f, z = -1f};

  public UnityEngine.Vector3 GazeDirection {
    get => _GazeDirection;
  }

  // Whether glasses are worn
  private bool _Worn = false;

  public bool Worn {
    get => _Worn;
  }

  // Left pupil diameter
  private float _PupilDiameterLeft = 0f;

  public float PupilDiameterLeft {
    get => _PupilDiameterLeft;
  }

  // Right pupil diameter
  private float _PupilDiameterRight = 0f;

  public float PupilDiameterRight {
    get => _PupilDiameterRight;
  }

  // Current scene camera frame rate
  private int _SceneCameraFrameRate = 0;

  public int SceneCameraFrameRate {
    get => _SceneCameraFrameRate;
  }

  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected EyeTrackingDataStore.OutboundEyeTrackingDevice _xrpaObject;
  public event System.Action<ulong, Xrpa.Image, UnityEngine.Vector2> OnSceneCamera;
  public event System.Action<ulong, ulong, UnityEngine.Vector3, UnityEngine.Vector3> OnImuData;
  public event System.Action<ulong, EyeTrackingDataStore.EyeEventType, ulong, ulong, UnityEngine.Vector2, float, float> OnEyeEvent;
  private Xrpa.InboundSignalDataInterface _audioSignalHandler = null;
  protected bool _dsIsInitialized = false;

  void OnValidate() {
    if (_xrpaObject != null) { _xrpaObject.SetDeviceAddress(_DeviceAddress); }
    if (_xrpaObject != null) { _xrpaObject.SetStreamGaze(_StreamGaze); }
    if (_xrpaObject != null) { _xrpaObject.SetStreamSceneCamera(_StreamSceneCamera); }
    if (_xrpaObject != null) { _xrpaObject.SetStreamImu(_StreamImu); }
    if (_xrpaObject != null) { _xrpaObject.SetStreamEyeEvents(_StreamEyeEvents); }
    if (_xrpaObject != null) { _xrpaObject.SetStreamAudio(_StreamAudio); }
  }

  void Start() {
    InitializeDS();
  }

  void OnDestroy() {
    DeinitializeDS();
  }

  public Xrpa.ObjectUuid GetXrpaId() {
    return _id;
  }

  public void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    if (_xrpaObject.CheckDeviceNameChanged(fieldsChanged)) {
      _DeviceName = _xrpaObject.GetDeviceName();
    }
    if (_xrpaObject.CheckHardwareVersionChanged(fieldsChanged)) {
      _HardwareVersion = _xrpaObject.GetHardwareVersion();
    }
    if (_xrpaObject.CheckSerialNumberChanged(fieldsChanged)) {
      _SerialNumber = _xrpaObject.GetSerialNumber();
    }
    if (_xrpaObject.CheckIsConnectedChanged(fieldsChanged)) {
      _IsConnected = _xrpaObject.GetIsConnected();
    }
    if (_xrpaObject.CheckCalibrationJsonChanged(fieldsChanged)) {
      _CalibrationJson = _xrpaObject.GetCalibrationJson();
    }
    if (_xrpaObject.CheckLastUpdateChanged(fieldsChanged)) {
      _LastUpdate = _xrpaObject.GetLastUpdate();
    }
    if (_xrpaObject.CheckHeadOrientationChanged(fieldsChanged)) {
      _HeadOrientation = _xrpaObject.GetHeadOrientation();
    }
    if (_xrpaObject.CheckGazeDirectionChanged(fieldsChanged)) {
      _GazeDirection = _xrpaObject.GetGazeDirection();
    }
    if (_xrpaObject.CheckWornChanged(fieldsChanged)) {
      _Worn = _xrpaObject.GetWorn();
    }
    if (_xrpaObject.CheckPupilDiameterLeftChanged(fieldsChanged)) {
      _PupilDiameterLeft = _xrpaObject.GetPupilDiameterLeft();
    }
    if (_xrpaObject.CheckPupilDiameterRightChanged(fieldsChanged)) {
      _PupilDiameterRight = _xrpaObject.GetPupilDiameterRight();
    }
    if (_xrpaObject.CheckSceneCameraFrameRateChanged(fieldsChanged)) {
      _SceneCameraFrameRate = _xrpaObject.GetSceneCameraFrameRate();
    }
  }

  void DispatchSceneCamera(ulong msgTimestamp, EyeTrackingDataStore.SceneCameraReader message) {
    OnSceneCamera?.Invoke(msgTimestamp, message.GetImage(), message.GetGazePosition());
  }

  void DispatchImuData(ulong msgTimestamp, EyeTrackingDataStore.ImuDataReader message) {
    OnImuData?.Invoke(msgTimestamp, message.GetTimestamp(), message.GetGyro(), message.GetAccel());
  }

  void DispatchEyeEvent(ulong msgTimestamp, EyeTrackingDataStore.EyeEventReader message) {
    OnEyeEvent?.Invoke(msgTimestamp, message.GetEventType(), message.GetStartTime(), message.GetEndTime(), message.GetMeanGaze(), message.GetAmplitude(), message.GetMaxVelocity());
  }

  public void OnAudio(Xrpa.InboundSignalDataInterface handler) {
    _audioSignalHandler = handler;
    if (_xrpaObject != null) {
      _xrpaObject.OnAudio(_audioSignalHandler);
    }
  }

  public void InitializeDS() {
    if (_dsIsInitialized) {
      return;
    }
    _dsIsInitialized = true;
    _id = new Xrpa.ObjectUuid(System.Guid.NewGuid());

    _DeviceName = "";
    _HardwareVersion = "";
    _SerialNumber = "";
    _IsConnected = false;
    _CalibrationJson = "";
    _LastUpdate = 0UL;
    _HeadOrientation = new UnityEngine.Quaternion{x = 0f, y = 0f, z = 0f, w = 1f};
    _GazeDirection = new UnityEngine.Vector3{x = 0f, y = 0f, z = -1f};
    _Worn = false;
    _PupilDiameterLeft = 0f;
    _PupilDiameterRight = 0f;
    _SceneCameraFrameRate = 0;

    _xrpaObject = new EyeTrackingDataStore.OutboundEyeTrackingDevice(_id);
    _xrpaObject.SetXrpaOwner(this);
    EyeTrackingDataStoreSubsystem.Instance.DataStore.EyeTrackingDevice.AddObject(_xrpaObject);
    _xrpaObject.SetDeviceAddress(_DeviceAddress);
    _xrpaObject.SetStreamGaze(_StreamGaze);
    _xrpaObject.SetStreamSceneCamera(_StreamSceneCamera);
    _xrpaObject.SetStreamImu(_StreamImu);
    _xrpaObject.SetStreamEyeEvents(_StreamEyeEvents);
    _xrpaObject.SetStreamAudio(_StreamAudio);
    _xrpaObject.OnXrpaFieldsChanged(HandleXrpaFieldsChanged);
    _xrpaObject.OnSceneCamera(DispatchSceneCamera);
    _xrpaObject.OnImuData(DispatchImuData);
    _xrpaObject.OnEyeEvent(DispatchEyeEvent);
    _xrpaObject.OnAudio(_audioSignalHandler);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _xrpaObject.OnXrpaFieldsChanged(null);
    EyeTrackingDataStoreSubsystem.MaybeInstance?.DataStore.EyeTrackingDevice.RemoveObject(_id);
    _xrpaObject = null;
    _dsIsInitialized = false;
  }
}
