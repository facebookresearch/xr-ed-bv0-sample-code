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
using System.Collections.Generic;
using UnityEngine;
using Xrpa;

public class LightControlComponent : MonoBehaviour {
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
  private System.Collections.Generic.List<UnityEngine.Color32> _LightColors = new System.Collections.Generic.List<UnityEngine.Color32>{new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}};

  public System.Collections.Generic.List<UnityEngine.Color32> LightColors {
    get => _LightColors;
    set {
      _LightColors = value;
      if (_xrpaObject != null) { _xrpaObject.SetLightColors(value); }
    }
  }

  [SerializeField]
  private float _RotationOffset = 0f;

  public float RotationOffset {
    get => _RotationOffset;
    set {
      _RotationOffset = value;
      if (_xrpaObject != null) { _xrpaObject.SetRotationOffset(value); }
    }
  }

  [SerializeField]
  private float _RotationSpeed = 0f;

  public float RotationSpeed {
    get => _RotationSpeed;
    set {
      _RotationSpeed = value;
      if (_xrpaObject != null) { _xrpaObject.SetRotationSpeed(value); }
    }
  }

  [SerializeField]

  // Priority of the light, lower values will be applied first, with higher values alpha-blended on top
  private int _Priority = 0;

  public int Priority {
    get => _Priority;
    set {
      _Priority = value;
      if (_xrpaObject != null) { _xrpaObject.SetPriority(value); }
    }
  }

  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected SmartControllerDataStore.OutboundLightControl _xrpaObject;
  protected bool _dsIsInitialized = false;

  void OnValidate() {
    if (_xrpaObject != null) { _xrpaObject.SetIpAddress(_IpAddress); }
    if (_xrpaObject != null) { _xrpaObject.SetLightColors(_LightColors); }
    if (_xrpaObject != null) { _xrpaObject.SetRotationOffset(_RotationOffset); }
    if (_xrpaObject != null) { _xrpaObject.SetRotationSpeed(_RotationSpeed); }
    if (_xrpaObject != null) { _xrpaObject.SetPriority(_Priority); }
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

  public void InitializeDS() {
    if (_dsIsInitialized) {
      return;
    }
    _dsIsInitialized = true;
    _id = new Xrpa.ObjectUuid(System.Guid.NewGuid());

    _IsConnected = false;

    _xrpaObject = new SmartControllerDataStore.OutboundLightControl(_id);
    _xrpaObject.SetXrpaOwner(this);
    SmartControllerDataStoreSubsystem.Instance.DataStore.LightControl.AddObject(_xrpaObject);
    _xrpaObject.SetIpAddress(_IpAddress);
    _xrpaObject.SetLightColors(_LightColors);
    _xrpaObject.SetRotationOffset(_RotationOffset);
    _xrpaObject.SetRotationSpeed(_RotationSpeed);
    _xrpaObject.SetPriority(_Priority);
    _xrpaObject.OnXrpaFieldsChanged(HandleXrpaFieldsChanged);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _xrpaObject.OnXrpaFieldsChanged(null);
    SmartControllerDataStoreSubsystem.MaybeInstance?.DataStore.LightControl.RemoveObject(_id);
    _xrpaObject = null;
    _dsIsInitialized = false;
  }
}
