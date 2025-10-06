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

using LlmHubDataStore;
using System;

namespace XrpaDataflow {

public class LlamaConversation : IDisposable {
  private LlmHubDataStore.LlmHubDataStore _datastoreLlmHub;
  private string _paramApiKey = "";
  private string _paramSystemPrompt = "";
  private System.Action<ulong, string, int> _paramResponse = null;
  private LlmHubDataStore.OutboundLlmConversation _objLlmHubLlmConversation0;

  public LlamaConversation(LlmHubDataStore.LlmHubDataStore datastoreLlmHub) {
    _datastoreLlmHub = datastoreLlmHub;
    CreateObjects();
  }

  public void Dispose() {
    Dispose(true);
    GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    DestroyObjects();
  }

  ~LlamaConversation() {
    Dispose(false);
  }

  public string GetApiKey() {
    return _paramApiKey;
  }

  public void SetApiKey(string apiKey) {
    _paramApiKey = apiKey;
    if (_objLlmHubLlmConversation0 != null) {
      _objLlmHubLlmConversation0.SetApiKey(apiKey);
    }
  }

  public void SendChatMessage(string data, byte[] jpegImageData, int id) {
    if (_objLlmHubLlmConversation0 != null) {
      _objLlmHubLlmConversation0.SendChatMessage(data, jpegImageData, id);
    }
  }

  public string GetSystemPrompt() {
    return _paramSystemPrompt;
  }

  public void SetSystemPrompt(string SystemPrompt) {
    _paramSystemPrompt = SystemPrompt;
    if (_objLlmHubLlmConversation0 != null) {
      _objLlmHubLlmConversation0.SetSysPrompt(SystemPrompt);
    }
  }

  public void OnResponse(System.Action<ulong, string, int> handler) {
    _paramResponse = handler;
  }

  void Dispatch_objLlmHubLlmConversation0ChatResponse(ulong msgTimestamp, LlmHubDataStore.LlmChatResponseReader msg) {
    var data = msg.GetData();
    var id = msg.GetId();
    _paramResponse?.Invoke(msgTimestamp, data, id);
  }

  void CreateObjects() {
    _objLlmHubLlmConversation0 = _datastoreLlmHub.LlmConversation.CreateObject();
    _objLlmHubLlmConversation0.SetApiKey(_paramApiKey);
    _objLlmHubLlmConversation0.SetApiProvider((LlmHubDataStore.ApiProvider)(uint)(1));
    _objLlmHubLlmConversation0.SetModelSize((LlmHubDataStore.ModelSizeHint)(uint)(1));
    _objLlmHubLlmConversation0.SetSysPrompt(_paramSystemPrompt);
    _objLlmHubLlmConversation0.OnChatResponse(Dispatch_objLlmHubLlmConversation0ChatResponse);
  }

  void DestroyObjects() {
    if (_objLlmHubLlmConversation0 != null) {
      _datastoreLlmHub.LlmConversation.RemoveObject(_objLlmHubLlmConversation0.GetXrpaId());
      _objLlmHubLlmConversation0 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace XrpaDataflow
