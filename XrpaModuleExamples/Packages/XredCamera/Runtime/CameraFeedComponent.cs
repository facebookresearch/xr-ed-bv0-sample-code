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

using CameraDataStore;
using System;
using UnityEngine;
using Xrpa;

public class CameraFeedComponent : MonoBehaviour {
  [SerializeField]

  // pseudo-regex, with just $ and ^ supported for now
  private string _CameraName = "";

  public string CameraName {
    get => _CameraName;
    set {
      _CameraName = value;
      if (_xrpaObject != null) { _xrpaObject.SetCameraName(value); }
    }
  }

  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected CameraDataStore.OutboundCameraFeed _xrpaObject;
  public event System.Action<ulong, Xrpa.Image> OnCameraImage;
  protected bool _dsIsInitialized = false;

  void OnValidate() {
    if (_xrpaObject != null) { _xrpaObject.SetCameraName(_CameraName); }
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
  }

  void DispatchCameraImage(ulong msgTimestamp, CameraDataStore.CameraImageReader message) {
    OnCameraImage?.Invoke(msgTimestamp, message.GetImage());
  }

  public void InitializeDS() {
    if (_dsIsInitialized) {
      return;
    }
    _dsIsInitialized = true;
    _id = new Xrpa.ObjectUuid(System.Guid.NewGuid());

    _xrpaObject = new CameraDataStore.OutboundCameraFeed(_id);
    _xrpaObject.SetXrpaOwner(this);
    CameraDataStoreSubsystem.Instance.DataStore.CameraFeed.AddObject(_xrpaObject);
    _xrpaObject.SetCameraName(_CameraName);
    _xrpaObject.OnXrpaFieldsChanged(HandleXrpaFieldsChanged);
    _xrpaObject.OnCameraImage(DispatchCameraImage);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _xrpaObject.OnXrpaFieldsChanged(null);
    CameraDataStoreSubsystem.MaybeInstance?.DataStore.CameraFeed.RemoveObject(_id);
    _xrpaObject = null;
    _dsIsInitialized = false;
  }
}
