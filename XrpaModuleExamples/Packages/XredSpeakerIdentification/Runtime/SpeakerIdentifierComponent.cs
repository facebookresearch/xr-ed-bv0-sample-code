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

public class SpeakerIdentifierComponent : MonoBehaviour {
  // ID of the identified speaker, empty if no match
  private string _IdentifiedSpeakerId = "";

  public string IdentifiedSpeakerId {
    get => _IdentifiedSpeakerId;
  }

  // Name of the identified speaker, empty if no match
  private string _IdentifiedSpeakerName = "";

  public string IdentifiedSpeakerName {
    get => _IdentifiedSpeakerName;
  }

  // Confidence score of the match (0-1)
  private int _ConfidenceScore = 0;

  public int ConfidenceScore {
    get => _ConfidenceScore;
  }

  // Error message if identification failed
  private string _ErrorMessage = "";

  public string ErrorMessage {
    get => _ErrorMessage;
  }

  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected SpeakerIdentificationDataStore.OutboundSpeakerIdentifier _xrpaObject;
  protected bool _dsIsInitialized = false;

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
    if (_xrpaObject.CheckIdentifiedSpeakerIdChanged(fieldsChanged)) {
      _IdentifiedSpeakerId = _xrpaObject.GetIdentifiedSpeakerId();
    }
    if (_xrpaObject.CheckIdentifiedSpeakerNameChanged(fieldsChanged)) {
      _IdentifiedSpeakerName = _xrpaObject.GetIdentifiedSpeakerName();
    }
    if (_xrpaObject.CheckConfidenceScoreChanged(fieldsChanged)) {
      _ConfidenceScore = _xrpaObject.GetConfidenceScore();
    }
    if (_xrpaObject.CheckErrorMessageChanged(fieldsChanged)) {
      _ErrorMessage = _xrpaObject.GetErrorMessage();
    }
  }

  public Xrpa.SignalPacket SendAudioSignal<SampleType>(int frameCount, int numChannels, int framesPerSecond) where SampleType : unmanaged  {
    return _xrpaObject.SendAudioSignal<SampleType>(frameCount, numChannels, framesPerSecond);
  }

  public void InitializeDS() {
    if (_dsIsInitialized) {
      return;
    }
    _dsIsInitialized = true;
    _id = new Xrpa.ObjectUuid(System.Guid.NewGuid());

    _IdentifiedSpeakerId = "";
    _IdentifiedSpeakerName = "";
    _ConfidenceScore = 0;
    _ErrorMessage = "";

    _xrpaObject = new SpeakerIdentificationDataStore.OutboundSpeakerIdentifier(_id);
    _xrpaObject.SetXrpaOwner(this);
    SpeakerIdentificationDataStoreSubsystem.Instance.DataStore.SpeakerIdentifier.AddObject(_xrpaObject);
    _xrpaObject.OnXrpaFieldsChanged(HandleXrpaFieldsChanged);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _xrpaObject.OnXrpaFieldsChanged(null);
    SpeakerIdentificationDataStoreSubsystem.MaybeInstance?.DataStore.SpeakerIdentifier.RemoveObject(_id);
    _xrpaObject = null;
    _dsIsInitialized = false;
  }
}
