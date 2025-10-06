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

using AudioTranscriptionDataStore;
using System;
using UnityEngine;
using Xrpa;

public class AudioTranscriptionComponent : MonoBehaviour {
  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected AudioTranscriptionDataStore.OutboundAudioTranscription _xrpaObject;
  public event System.Action<ulong, string, ulong, bool, string> OnTranscriptionResult;
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
  }

  void DispatchTranscriptionResult(ulong msgTimestamp, AudioTranscriptionDataStore.TranscriptionResultReader message) {
    OnTranscriptionResult?.Invoke(msgTimestamp, message.GetText(), message.GetTimestamp(), message.GetSuccess(), message.GetErrorMessage());
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

    _xrpaObject = new AudioTranscriptionDataStore.OutboundAudioTranscription(_id);
    _xrpaObject.SetXrpaOwner(this);
    AudioTranscriptionDataStoreSubsystem.Instance.DataStore.AudioTranscription.AddObject(_xrpaObject);
    _xrpaObject.OnXrpaFieldsChanged(HandleXrpaFieldsChanged);
    _xrpaObject.OnTranscriptionResult(DispatchTranscriptionResult);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _xrpaObject.OnXrpaFieldsChanged(null);
    AudioTranscriptionDataStoreSubsystem.MaybeInstance?.DataStore.AudioTranscription.RemoveObject(_id);
    _xrpaObject = null;
    _dsIsInitialized = false;
  }
}
