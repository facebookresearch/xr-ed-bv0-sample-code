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

using AudioInputDataStore;
using System;
using UnityEngine;
using Xrpa;

public class AudioInputSourceComponent : MonoBehaviour {
  [SerializeField]
  private AudioInputDataStore.DeviceBindingType _BindTo = AudioInputDataStore.DeviceBindingType.Device;

  public AudioInputDataStore.DeviceBindingType BindTo {
    get => _BindTo;
    set {
      _BindTo = value;
      if (_xrpaObject != null) { _xrpaObject.SetBindTo(value); }
    }
  }

  [SerializeField]
  private Xrpa.ObjectUuid _Device = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};

  public Xrpa.ObjectUuid Device {
    get => _Device;
    set {
      _Device = value;
      if (_xrpaObject != null) { _xrpaObject.SetDevice(value); }
    }
  }

  [SerializeField]
  private string _DeviceName = "";

  public string DeviceName {
    get => _DeviceName;
    set {
      _DeviceName = value;
      if (_xrpaObject != null) { _xrpaObject.SetDeviceName(value); }
    }
  }

  [SerializeField]
  private string _Hostname = "";

  public string Hostname {
    get => _Hostname;
    set {
      _Hostname = value;
      if (_xrpaObject != null) { _xrpaObject.SetHostname(value); }
    }
  }

  [SerializeField]
  private int _Port = 0;

  public int Port {
    get => _Port;
    set {
      _Port = value;
      if (_xrpaObject != null) { _xrpaObject.SetPort(value); }
    }
  }

  [SerializeField]

  // Frame rate for audio capture
  private int _FrameRate = 48000;

  public int FrameRate {
    get => _FrameRate;
    set {
      _FrameRate = value;
      if (_xrpaObject != null) { _xrpaObject.SetFrameRate(value); }
    }
  }

  [SerializeField]

  // Number of channels for audio capture
  private int _NumChannels = 2;

  public int NumChannels {
    get => _NumChannels;
    set {
      _NumChannels = value;
      if (_xrpaObject != null) { _xrpaObject.SetNumChannels(value); }
    }
  }

  // Whether audio input is currently active
  private bool _IsActive = false;

  public bool IsActive {
    get => _IsActive;
  }

  // Error message if audio input failed
  private string _ErrorMessage = "";

  public string ErrorMessage {
    get => _ErrorMessage;
  }

  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected AudioInputDataStore.OutboundAudioInputSource _xrpaObject;
  private Xrpa.InboundSignalDataInterface _audioSignalSignalHandler = null;
  protected bool _dsIsInitialized = false;

  void OnValidate() {
    if (_xrpaObject != null) { _xrpaObject.SetBindTo(_BindTo); }
    if (_xrpaObject != null) { _xrpaObject.SetDevice(_Device); }
    if (_xrpaObject != null) { _xrpaObject.SetDeviceName(_DeviceName); }
    if (_xrpaObject != null) { _xrpaObject.SetHostname(_Hostname); }
    if (_xrpaObject != null) { _xrpaObject.SetPort(_Port); }
    if (_xrpaObject != null) { _xrpaObject.SetFrameRate(_FrameRate); }
    if (_xrpaObject != null) { _xrpaObject.SetNumChannels(_NumChannels); }
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
    if (_xrpaObject.CheckIsActiveChanged(fieldsChanged)) {
      _IsActive = _xrpaObject.GetIsActive();
    }
    if (_xrpaObject.CheckErrorMessageChanged(fieldsChanged)) {
      _ErrorMessage = _xrpaObject.GetErrorMessage();
    }
  }

  public void OnAudioSignal(Xrpa.InboundSignalDataInterface handler) {
    _audioSignalSignalHandler = handler;
    if (_xrpaObject != null) {
      _xrpaObject.OnAudioSignal(_audioSignalSignalHandler);
    }
  }

  public void InitializeDS() {
    if (_dsIsInitialized) {
      return;
    }
    _dsIsInitialized = true;
    _id = new Xrpa.ObjectUuid(System.Guid.NewGuid());

    _IsActive = false;
    _ErrorMessage = "";

    _xrpaObject = new AudioInputDataStore.OutboundAudioInputSource(_id);
    _xrpaObject.SetXrpaOwner(this);
    AudioInputDataStoreSubsystem.Instance.DataStore.AudioInputSource.AddObject(_xrpaObject);
    _xrpaObject.SetBindTo(_BindTo);
    _xrpaObject.SetDevice(_Device);
    _xrpaObject.SetDeviceName(_DeviceName);
    _xrpaObject.SetHostname(_Hostname);
    _xrpaObject.SetPort(_Port);
    _xrpaObject.SetFrameRate(_FrameRate);
    _xrpaObject.SetNumChannels(_NumChannels);
    _xrpaObject.OnXrpaFieldsChanged(HandleXrpaFieldsChanged);
    _xrpaObject.OnAudioSignal(_audioSignalSignalHandler);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _xrpaObject.OnXrpaFieldsChanged(null);
    AudioInputDataStoreSubsystem.MaybeInstance?.DataStore.AudioInputSource.RemoveObject(_id);
    _xrpaObject = null;
    _dsIsInitialized = false;
  }
}
