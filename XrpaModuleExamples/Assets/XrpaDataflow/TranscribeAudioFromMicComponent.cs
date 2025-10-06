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
using UnityEngine;
using XrpaDataflow;

public class TranscribeAudioFromMicComponent : MonoBehaviour {
  [SerializeField]
  public bool AutoRun = false;
  public event System.Action<ulong, string, ulong, bool, string> OnTranscriptionResult;
  private XrpaDataflow.TranscribeAudioFromMic _currentObj;

  void OnValidate() {
    if (_currentObj != null) {
    }
  }

  void DispatchTranscriptionResult(ulong msgTimestamp, string text, ulong timestamp, bool success, string errorMessage) {
    OnTranscriptionResult?.Invoke(msgTimestamp, text, timestamp, success, errorMessage);
  }

  void Start() {
    if (AutoRun) {
      Run();
    }
  }

  void OnDestroy() {
    Stop();
  }

  public void Run() {
    Stop();
    _currentObj = new XrpaDataflow.TranscribeAudioFromMic(AudioInputDataStoreSubsystem.Instance.DataStore, AudioTranscriptionDataStoreSubsystem.Instance.DataStore);
    _currentObj.OnTranscriptionResult(DispatchTranscriptionResult);
  }

  public void Stop() {
    if (_currentObj != null) {
      _currentObj.Terminate();
    }
    _currentObj = null;
  }

  public XrpaDataflow.TranscribeAudioFromMic Spawn() {
    var ret = new XrpaDataflow.TranscribeAudioFromMic(AudioInputDataStoreSubsystem.Instance.DataStore, AudioTranscriptionDataStoreSubsystem.Instance.DataStore);
    return ret;
  }
}
