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

public class LlamaLargeConversationComponent : MonoBehaviour {
  [SerializeField]
  public bool AutoRun = false;

  [SerializeField]
  private string _ApiKey = "";

  public string ApiKey {
    get => _ApiKey;
    set {
      _ApiKey = value;
      if (_currentObj != null) {
        _currentObj.SetApiKey(value);
      }
    }
  }

  [SerializeField]
  private string _SystemPrompt = "";

  public string SystemPrompt {
    get => _SystemPrompt;
    set {
      _SystemPrompt = value;
      if (_currentObj != null) {
        _currentObj.SetSystemPrompt(value);
      }
    }
  }

  [SerializeField]
  private float _Temperature = 1f;

  public float Temperature {
    get => _Temperature;
    set {
      _Temperature = value;
      if (_currentObj != null) {
        _currentObj.SetTemperature(value);
      }
    }
  }

  public event System.Action<ulong, string, int> OnResponse;
  private XrpaDataflow.LlamaLargeConversation _currentObj;

  public void SendChatMessage(string data, byte[] jpegImageData, int id) {
    _currentObj?.SendChatMessage(data, jpegImageData, id);
  }

  void OnValidate() {
    if (_currentObj != null) {
      if (!_currentObj.GetApiKey().Equals(_ApiKey)) {
        _currentObj.SetApiKey(_ApiKey);
      }
      if (!_currentObj.GetSystemPrompt().Equals(_SystemPrompt)) {
        _currentObj.SetSystemPrompt(_SystemPrompt);
      }
      if (!_currentObj.GetTemperature().Equals(_Temperature)) {
        _currentObj.SetTemperature(_Temperature);
      }
    }
  }

  void DispatchResponse(ulong msgTimestamp, string data, int id) {
    OnResponse?.Invoke(msgTimestamp, data, id);
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
    _currentObj = new XrpaDataflow.LlamaLargeConversation(LlmHubDataStoreSubsystem.Instance.DataStore);
    _currentObj.SetApiKey(ApiKey);
    _currentObj.SetSystemPrompt(SystemPrompt);
    _currentObj.SetTemperature(Temperature);
    _currentObj.OnResponse(DispatchResponse);
  }

  public void Stop() {
    if (_currentObj != null) {
      _currentObj.Terminate();
    }
    _currentObj = null;
  }

  public XrpaDataflow.LlamaLargeConversation Spawn() {
    var ret = new XrpaDataflow.LlamaLargeConversation(LlmHubDataStoreSubsystem.Instance.DataStore);
    ret.SetApiKey(ApiKey);
    ret.SetSystemPrompt(SystemPrompt);
    ret.SetTemperature(Temperature);
    return ret;
  }
}
