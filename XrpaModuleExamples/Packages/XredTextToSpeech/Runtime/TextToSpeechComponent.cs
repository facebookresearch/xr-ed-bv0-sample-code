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

using System;
using TextToSpeechDataStore;
using UnityEngine;
using Xrpa;

public class TextToSpeechComponent : MonoBehaviour {
  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected TextToSpeechDataStore.OutboundTextToSpeech _xrpaObject;
  public event System.Action<ulong, int, bool, string, ulong> OnTtsResponse;
  private Xrpa.InboundSignalDataInterface _audioSignalHandler = null;
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

  public void SendTextRequest(string text, int id) {
    _xrpaObject?.SendTextRequest(text, id);
  }

  void DispatchTtsResponse(ulong msgTimestamp, TextToSpeechDataStore.TtsResponseReader message) {
    OnTtsResponse?.Invoke(msgTimestamp, message.GetId(), message.GetSuccess(), message.GetErrorMessage(), message.GetPlaybackStartTimestamp());
  }

  public void OnAudio(Xrpa.InboundSignalDataInterface handler) {
    _audioSignalHandler = handler;
    if (_xrpaObject != null) {
      _xrpaObject.OnAudio(_audioSignalHandler);
    }
  }

  public void InitializeDS() {
    if (_dsIsInitialized) {
      return;
    }
    _dsIsInitialized = true;
    _id = new Xrpa.ObjectUuid(System.Guid.NewGuid());

    _xrpaObject = new TextToSpeechDataStore.OutboundTextToSpeech(_id);
    _xrpaObject.SetXrpaOwner(this);
    TextToSpeechDataStoreSubsystem.Instance.DataStore.TextToSpeech.AddObject(_xrpaObject);
    _xrpaObject.OnXrpaFieldsChanged(HandleXrpaFieldsChanged);
    _xrpaObject.OnTtsResponse(DispatchTtsResponse);
    _xrpaObject.OnAudio(_audioSignalHandler);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _xrpaObject.OnXrpaFieldsChanged(null);
    TextToSpeechDataStoreSubsystem.MaybeInstance?.DataStore.TextToSpeech.RemoveObject(_id);
    _xrpaObject = null;
    _dsIsInitialized = false;
  }
}
