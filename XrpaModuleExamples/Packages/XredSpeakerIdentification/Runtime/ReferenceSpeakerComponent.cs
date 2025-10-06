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

public class ReferenceSpeakerComponent : MonoBehaviour {
  [SerializeField]

  // Unique identifier for this speaker
  private string _SpeakerId = "";

  public string SpeakerId {
    get => _SpeakerId;
    set {
      _SpeakerId = value;
      if (_xrpaObject != null) { _xrpaObject.SetSpeakerId(value); }
    }
  }

  [SerializeField]

  // Human-readable name for this speaker
  private string _SpeakerName = "";

  public string SpeakerName {
    get => _SpeakerName;
    set {
      _SpeakerName = value;
      if (_xrpaObject != null) { _xrpaObject.SetSpeakerName(value); }
    }
  }

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

  // Reference back to the SpeakerIdentifier that this config belongs to
  private Xrpa.ObjectUuid _SpeakerIdentifier = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};

  public Xrpa.ObjectUuid SpeakerIdentifier {
    get => _SpeakerIdentifier;
  }

  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected SpeakerIdentificationDataStore.OutboundReferenceSpeaker _xrpaObject;
  protected bool _dsIsInitialized = false;

  void OnValidate() {
    if (_xrpaObject != null) { _xrpaObject.SetSpeakerId(_SpeakerId); }
    if (_xrpaObject != null) { _xrpaObject.SetSpeakerName(_SpeakerName); }
    if (_xrpaObject != null) { _xrpaObject.SetFilePath(_FilePath); }
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

    _SpeakerIdentifier = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
    {
      var componentObj = gameObject.GetComponent<SpeakerIdentifierComponent>();
      if (componentObj != null) {
        componentObj.InitializeDS();
        _SpeakerIdentifier = componentObj.GetXrpaId();
      }
    }

    _xrpaObject = new SpeakerIdentificationDataStore.OutboundReferenceSpeaker(_id);
    _xrpaObject.SetXrpaOwner(this);
    SpeakerIdentificationDataStoreSubsystem.Instance.DataStore.ReferenceSpeaker.AddObject(_xrpaObject);
    _xrpaObject.SetSpeakerId(_SpeakerId);
    _xrpaObject.SetSpeakerName(_SpeakerName);
    _xrpaObject.SetFilePath(_FilePath);
    _xrpaObject.SetSpeakerIdentifier(_SpeakerIdentifier);
    _xrpaObject.OnXrpaFieldsChanged(HandleXrpaFieldsChanged);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _xrpaObject.OnXrpaFieldsChanged(null);
    SpeakerIdentificationDataStoreSubsystem.MaybeInstance?.DataStore.ReferenceSpeaker.RemoveObject(_id);
    _xrpaObject = null;
    _dsIsInitialized = false;
  }
}
