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

using SmartControllerDataStore;
using System;
using UnityEngine;
using Xrpa;

public class KnobControlComponent : MonoBehaviour {
  [SerializeField]

  // IP address of the device to control
  private string _IpAddress = "";

  public string IpAddress {
    get => _IpAddress;
    set {
      _IpAddress = value;
      if (_xrpaObject != null) { _xrpaObject.SetIpAddress(value); }
    }
  }

  // Whether the device is connected
  private bool _IsConnected = false;

  public bool IsConnected {
    get => _IsConnected;
  }

  [SerializeField]
  private SmartControllerDataStore.KnobControlMode _ControlMode = SmartControllerDataStore.KnobControlMode.Disabled;

  public SmartControllerDataStore.KnobControlMode ControlMode {
    get => _ControlMode;
    set {
      _ControlMode = value;
      if (_xrpaObject != null) { _xrpaObject.SetControlMode(value); }
    }
  }

  [SerializeField]

  // Position to set the knob to, when controlMode == Position
  private int _Position = 0;

  public int Position {
    get => _Position;
    set {
      _Position = value;
      if (_xrpaObject != null) { _xrpaObject.SetPosition(value); }
    }
  }

  [SerializeField]

  // Number of detents to set the knob to, when controlMode == Detent
  private int _DetentCount = 10;

  public int DetentCount {
    get => _DetentCount;
    set {
      _DetentCount = value;
      if (_xrpaObject != null) { _xrpaObject.SetDetentCount(value); }
    }
  }

  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected SmartControllerDataStore.OutboundKnobControl _xrpaObject;
  public event System.Action<ulong, SmartControllerDataStore.InputEventType, int> OnInputEvent;
  public event System.Action<ulong, int, int, int> OnPositionEvent;
  protected bool _dsIsInitialized = false;

  void OnValidate() {
    if (_xrpaObject != null) { _xrpaObject.SetIpAddress(_IpAddress); }
    if (_xrpaObject != null) { _xrpaObject.SetControlMode(_ControlMode); }
    if (_xrpaObject != null) { _xrpaObject.SetPosition(_Position); }
    if (_xrpaObject != null) { _xrpaObject.SetDetentCount(_DetentCount); }
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
    if (_xrpaObject.CheckIsConnectedChanged(fieldsChanged)) {
      _IsConnected = _xrpaObject.GetIsConnected();
    }
  }

  void DispatchInputEvent(ulong msgTimestamp, SmartControllerDataStore.InputEventReader message) {
    OnInputEvent?.Invoke(msgTimestamp, message.GetType(), message.GetSource());
  }

  void DispatchPositionEvent(ulong msgTimestamp, SmartControllerDataStore.PositionEventReader message) {
    OnPositionEvent?.Invoke(msgTimestamp, message.GetPosition(), message.GetAbsolutePosition(), message.GetDetentPosition());
  }

  public void InitializeDS() {
    if (_dsIsInitialized) {
      return;
    }
    _dsIsInitialized = true;
    _id = new Xrpa.ObjectUuid(System.Guid.NewGuid());

    _IsConnected = false;

    _xrpaObject = new SmartControllerDataStore.OutboundKnobControl(_id);
    _xrpaObject.SetXrpaOwner(this);
    SmartControllerDataStoreSubsystem.Instance.DataStore.KnobControl.AddObject(_xrpaObject);
    _xrpaObject.SetIpAddress(_IpAddress);
    _xrpaObject.SetControlMode(_ControlMode);
    _xrpaObject.SetPosition(_Position);
    _xrpaObject.SetDetentCount(_DetentCount);
    _xrpaObject.OnXrpaFieldsChanged(HandleXrpaFieldsChanged);
    _xrpaObject.OnInputEvent(DispatchInputEvent);
    _xrpaObject.OnPositionEvent(DispatchPositionEvent);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _xrpaObject.OnXrpaFieldsChanged(null);
    SmartControllerDataStoreSubsystem.MaybeInstance?.DataStore.KnobControl.RemoveObject(_id);
    _xrpaObject = null;
    _dsIsInitialized = false;
  }
}
