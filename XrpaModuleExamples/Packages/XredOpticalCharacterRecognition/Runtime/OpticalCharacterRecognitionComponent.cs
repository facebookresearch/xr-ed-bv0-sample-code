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

using OpticalCharacterRecognitionDataStore;
using System;
using UnityEngine;
using Xrpa;

public class OpticalCharacterRecognitionComponent : MonoBehaviour {
  [SerializeField]

  // Increment this value to trigger OCR processing
  private int _TriggerId = 0;

  public int TriggerId {
    get => _TriggerId;
    set {
      _TriggerId = value;
      if (_xrpaObject != null) { _xrpaObject.SetTriggerId(value); }
    }
  }

  [SerializeField]

  // Whether to use immediate mode (true) or triggered mode (false)
  private bool _ImmediateMode = false;

  public bool ImmediateMode {
    get => _ImmediateMode;
    set {
      _ImmediateMode = value;
      if (_xrpaObject != null) { _xrpaObject.SetImmediateMode(value); }
    }
  }

  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected OpticalCharacterRecognitionDataStore.OutboundOpticalCharacterRecognition _xrpaObject;
  public event System.Action<ulong, string, ulong, bool, string> OnOcrResult;
  protected bool _dsIsInitialized = false;

  void OnValidate() {
    if (_xrpaObject != null) { _xrpaObject.SetTriggerId(_TriggerId); }
    if (_xrpaObject != null) { _xrpaObject.SetImmediateMode(_ImmediateMode); }
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

  public void SendImageInput(Xrpa.Image image) {
    _xrpaObject?.SendImageInput(image);
  }

  void DispatchOcrResult(ulong msgTimestamp, OpticalCharacterRecognitionDataStore.OcrResultReader message) {
    OnOcrResult?.Invoke(msgTimestamp, message.GetText(), message.GetTimestamp(), message.GetSuccess(), message.GetErrorMessage());
  }

  public void InitializeDS() {
    if (_dsIsInitialized) {
      return;
    }
    _dsIsInitialized = true;
    _id = new Xrpa.ObjectUuid(System.Guid.NewGuid());

    _xrpaObject = new OpticalCharacterRecognitionDataStore.OutboundOpticalCharacterRecognition(_id);
    _xrpaObject.SetXrpaOwner(this);
    OpticalCharacterRecognitionDataStoreSubsystem.Instance.DataStore.OpticalCharacterRecognition.AddObject(_xrpaObject);
    _xrpaObject.SetTriggerId(_TriggerId);
    _xrpaObject.SetImmediateMode(_ImmediateMode);
    _xrpaObject.OnXrpaFieldsChanged(HandleXrpaFieldsChanged);
    _xrpaObject.OnOcrResult(DispatchOcrResult);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _xrpaObject.OnXrpaFieldsChanged(null);
    OpticalCharacterRecognitionDataStoreSubsystem.MaybeInstance?.DataStore.OpticalCharacterRecognition.RemoveObject(_id);
    _xrpaObject = null;
    _dsIsInitialized = false;
  }
}
