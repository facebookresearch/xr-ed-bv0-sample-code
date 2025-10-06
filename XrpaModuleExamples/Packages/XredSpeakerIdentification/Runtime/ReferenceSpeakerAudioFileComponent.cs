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

using SpeakerIdentificationDataStore;
using System;
using UnityEngine;
using Xrpa;

public class ReferenceSpeakerAudioFileComponent : MonoBehaviour {
  [SerializeField]

  // Path to the audio file containing the speaker's voice sample
  private string _FilePath = "";

  public string FilePath {
    get => _FilePath;
    set {
      _FilePath = value;
      if (_xrpaObject != null) { _xrpaObject.SetFilePath(value); }
    }
  }

  [SerializeField]

  // Reference back to the speaker this audio file belongs to
  private Xrpa.ObjectUuid _Speaker = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};

  public Xrpa.ObjectUuid Speaker {
    get => _Speaker;
    set {
      _Speaker = value;
      if (_xrpaObject != null) { _xrpaObject.SetSpeaker(value); }
    }
  }

  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected SpeakerIdentificationDataStore.OutboundReferenceSpeakerAudioFile _xrpaObject;
  protected bool _dsIsInitialized = false;

  void OnValidate() {
    if (_xrpaObject != null) { _xrpaObject.SetFilePath(_FilePath); }
    if (_xrpaObject != null) { _xrpaObject.SetSpeaker(_Speaker); }
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

  public void InitializeDS() {
    if (_dsIsInitialized) {
      return;
    }
    _dsIsInitialized = true;
    _id = new Xrpa.ObjectUuid(System.Guid.NewGuid());

    _xrpaObject = new SpeakerIdentificationDataStore.OutboundReferenceSpeakerAudioFile(_id);
    _xrpaObject.SetXrpaOwner(this);
    SpeakerIdentificationDataStoreSubsystem.Instance.DataStore.ReferenceSpeakerAudioFile.AddObject(_xrpaObject);
    _xrpaObject.SetFilePath(_FilePath);
    _xrpaObject.SetSpeaker(_Speaker);
    _xrpaObject.OnXrpaFieldsChanged(HandleXrpaFieldsChanged);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _xrpaObject.OnXrpaFieldsChanged(null);
    SpeakerIdentificationDataStoreSubsystem.MaybeInstance?.DataStore.ReferenceSpeakerAudioFile.RemoveObject(_id);
    _xrpaObject = null;
    _dsIsInitialized = false;
  }
}
