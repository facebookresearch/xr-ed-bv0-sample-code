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

public class LlamaSmallQuery : IDisposable {
  private LlmHubDataStore.LlmHubDataStore _datastoreLlmHub;
  private string _paramApiKey = "";
  private string _paramChatMessage = "";
  private string _paramSystemPrompt = "";
  private System.Action<ulong, string, int> _paramResponse = null;
  private LlmHubDataStore.OutboundLlmQuery _objLlmHubLlmQuery0;

  public LlamaSmallQuery(LlmHubDataStore.LlmHubDataStore datastoreLlmHub) {
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

  ~LlamaSmallQuery() {
    Dispose(false);
  }

  public string GetApiKey() {
    return _paramApiKey;
  }

  public void SetApiKey(string apiKey) {
    _paramApiKey = apiKey;
    if (_objLlmHubLlmQuery0 != null) {
      _objLlmHubLlmQuery0.SetApiKey(apiKey);
    }
  }

  public string GetChatMessage() {
    return _paramChatMessage;
  }

  public void SetChatMessage(string ChatMessage) {
    _paramChatMessage = ChatMessage;
    if (_objLlmHubLlmQuery0 != null) {
      _objLlmHubLlmQuery0.SetUserPrompt(ChatMessage);
    }
  }

  public string GetSystemPrompt() {
    return _paramSystemPrompt;
  }

  public void SetSystemPrompt(string SystemPrompt) {
    _paramSystemPrompt = SystemPrompt;
    if (_objLlmHubLlmQuery0 != null) {
      _objLlmHubLlmQuery0.SetSysPrompt(SystemPrompt);
    }
  }

  public void OnResponse(System.Action<ulong, string, int> handler) {
    _paramResponse = handler;
  }

  void Dispatch_objLlmHubLlmQuery0Response(ulong msgTimestamp, LlmHubDataStore.LlmChatResponseReader msg) {
    var data = msg.GetData();
    var id = msg.GetId();
    _paramResponse?.Invoke(msgTimestamp, data, id);
  }

  void CreateObjects() {
    _objLlmHubLlmQuery0 = _datastoreLlmHub.LlmQuery.CreateObject();
    _objLlmHubLlmQuery0.SetApiKey(_paramApiKey);
    _objLlmHubLlmQuery0.SetApiProvider((LlmHubDataStore.ApiProvider)(uint)(1));
    _objLlmHubLlmQuery0.SetModelSize((LlmHubDataStore.ModelSizeHint)(uint)(0));
    _objLlmHubLlmQuery0.SetSysPrompt(_paramSystemPrompt);
    _objLlmHubLlmQuery0.SetUserPrompt(_paramChatMessage);
    _objLlmHubLlmQuery0.OnResponse(Dispatch_objLlmHubLlmQuery0Response);
  }

  void DestroyObjects() {
    if (_objLlmHubLlmQuery0 != null) {
      _datastoreLlmHub.LlmQuery.RemoveObject(_objLlmHubLlmQuery0.GetXrpaId());
      _objLlmHubLlmQuery0 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace XrpaDataflow
