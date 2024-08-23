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

using SignalOutputDataStore;
using UnityEngine;
using Xrpa;

public class SignalOutputDeviceComponent : MonoBehaviour, Xrpa.IIndexBoundType<SignalOutputDataStore.SignalOutputDevice, SignalOutputDataStore.ReconciledSignalOutputDevice> {
  [SerializeField]
  private string _Name = "";

  public string Name {
    get => _Name;
    set {
      SignalOutputDataStoreSubsystem.Instance.DataStore.SignalOutputDeviceIn.RemoveNameBinding(_Name, this);
      _Name = value;
      SignalOutputDataStoreSubsystem.Instance.DataStore.SignalOutputDeviceIn.AddNameBinding(_Name, this);
    }
  }

  private string _ChannelName = "";

  public string ChannelName {
    get => _ChannelName;
  }

  private string _DriverIdentifier = "";

  public string DriverIdentifier {
    get => _DriverIdentifier;
  }

  private string _DriverPort = "";

  public string DriverPort {
    get => _DriverPort;
  }

  private SignalOutputDataStore.DeviceHandedness _Handedness = SignalOutputDataStore.DeviceHandedness.None;

  public SignalOutputDataStore.DeviceHandedness Handedness {
    get => _Handedness;
  }

  private int _NumChannels = 0;

  public int NumChannels {
    get => _NumChannels;
  }

  private SignalOutputDataStore.SampleType _SampleType = SignalOutputDataStore.SampleType.Float;

  public SignalOutputDataStore.SampleType SampleType {
    get => _SampleType;
  }

  private SignalOutputDataStore.SampleSemantics _SampleSemantics = SignalOutputDataStore.SampleSemantics.PCM;

  public SignalOutputDataStore.SampleSemantics SampleSemantics {
    get => _SampleSemantics;
  }

  private int _BytesPerSample = 0;

  public int BytesPerSample {
    get => _BytesPerSample;
  }

  private int _SamplesPerChannelPerSec = 0;

  public int SamplesPerChannelPerSec {
    get => _SamplesPerChannelPerSec;
  }

  public event System.Action<int, SignalOutputDataStore.InputEventType, int> OnInputEvent;
  private SignalOutputDataStore.ReconciledSignalOutputDevice _reconciledObj;
  private ulong _changeBits = 0;
  protected bool _dsIsInitialized = false;

  public string GetName() {
    return Name;
  }

  void Start() {
    InitializeDS();
  }

  void OnDestroy() {
    DeinitializeDS();
  }

  public bool AddXrpaBinding(SignalOutputDataStore.ReconciledSignalOutputDevice reconciledObj) {
    if (_reconciledObj != null) {
      return false;
    }
    _reconciledObj = reconciledObj;
    return true;
  }

  public void RemoveXrpaBinding(SignalOutputDataStore.ReconciledSignalOutputDevice reconciledObj) {
    if (_reconciledObj == reconciledObj) {
      _reconciledObj = null;
    }
  }

  public void WriteDSChanges() {
  }

  public void ProcessDSUpdate(ulong fieldsChanged) {
    if (_reconciledObj.CheckChannelNameChanged(fieldsChanged)) {
      _ChannelName = _reconciledObj.GetChannelName();
    }
    if (_reconciledObj.CheckDriverIdentifierChanged(fieldsChanged)) {
      _DriverIdentifier = _reconciledObj.GetDriverIdentifier();
    }
    if (_reconciledObj.CheckDriverPortChanged(fieldsChanged)) {
      _DriverPort = _reconciledObj.GetDriverPort();
    }
    if (_reconciledObj.CheckHandednessChanged(fieldsChanged)) {
      _Handedness = _reconciledObj.GetHandedness();
    }
    if (_reconciledObj.CheckNumChannelsChanged(fieldsChanged)) {
      _NumChannels = _reconciledObj.GetNumChannels();
    }
    if (_reconciledObj.CheckSampleTypeChanged(fieldsChanged)) {
      _SampleType = _reconciledObj.GetSampleType();
    }
    if (_reconciledObj.CheckSampleSemanticsChanged(fieldsChanged)) {
      _SampleSemantics = _reconciledObj.GetSampleSemantics();
    }
    if (_reconciledObj.CheckBytesPerSampleChanged(fieldsChanged)) {
      _BytesPerSample = _reconciledObj.GetBytesPerSample();
    }
    if (_reconciledObj.CheckSamplesPerChannelPerSecChanged(fieldsChanged)) {
      _SamplesPerChannelPerSec = _reconciledObj.GetSamplesPerChannelPerSec();
    }
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
    if (messageType == 10) {
      SignalOutputDataStore.InputEvent message = new(messageData);
      OnInputEvent?.Invoke(timestamp, message.GetType(), message.GetSource());
    }
  }

  public void InitializeDS() {
    if (_dsIsInitialized) {
      return;
    }
    _dsIsInitialized = true;
    _changeBits = 0;

    _ChannelName = "";
    _DriverIdentifier = "";
    _DriverPort = "";
    _Handedness = SignalOutputDataStore.DeviceHandedness.None;
    _NumChannels = 0;
    _SampleType = SignalOutputDataStore.SampleType.Float;
    _SampleSemantics = SignalOutputDataStore.SampleSemantics.PCM;
    _BytesPerSample = 0;
    _SamplesPerChannelPerSec = 0;

    SignalOutputDataStoreSubsystem.Instance.DataStore.SignalOutputDeviceIn.AddNameBinding(Name, this);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    SignalOutputDataStoreSubsystem.MaybeInstance?.DataStore.SignalOutputDeviceIn.RemoveNameBinding(Name, this);
    _dsIsInitialized = false;
  }
}
