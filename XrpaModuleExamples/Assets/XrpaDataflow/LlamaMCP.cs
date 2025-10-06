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

public class LlamaMCP : IDisposable {
  private LlmHubDataStore.LlmHubDataStore _datastoreLlmHub;
  private string _paramApiKey = "";
  private string _paramSystemPrompt = "";
  private System.Action<ulong, string, int> _paramResponse = null;
  private LlmHubDataStore.OutboundMcpServerSet _objLlmHubMcpServerSet0;
  private LlmHubDataStore.OutboundLlmConversation _objLlmHubLlmConversation2;
  private LlmHubDataStore.OutboundMcpServerConfig _objLlmHubMcpServerConfig1;

  public LlamaMCP(LlmHubDataStore.LlmHubDataStore datastoreLlmHub) {
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

  ~LlamaMCP() {
    Dispose(false);
  }

  public string GetApiKey() {
    return _paramApiKey;
  }

  public void SetApiKey(string apiKey) {
    _paramApiKey = apiKey;
    if (_objLlmHubLlmConversation2 != null) {
      _objLlmHubLlmConversation2.SetApiKey(apiKey);
    }
  }

  public void SendChatMessage(string data, byte[] jpegImageData, int id) {
    if (_objLlmHubLlmConversation2 != null) {
      _objLlmHubLlmConversation2.SendChatMessage(data, jpegImageData, id);
    }
  }

  public string GetSystemPrompt() {
    return _paramSystemPrompt;
  }

  public void SetSystemPrompt(string SystemPrompt) {
    _paramSystemPrompt = SystemPrompt;
    if (_objLlmHubLlmConversation2 != null) {
      _objLlmHubLlmConversation2.SetSysPrompt(SystemPrompt);
    }
  }

  public void OnResponse(System.Action<ulong, string, int> handler) {
    _paramResponse = handler;
  }

  void Dispatch_objLlmHubLlmConversation2ChatResponse(ulong msgTimestamp, LlmHubDataStore.LlmChatResponseReader msg) {
    var data = msg.GetData();
    var id = msg.GetId();
    _paramResponse?.Invoke(msgTimestamp, data, id);
  }

  void CreateObjects() {
    _objLlmHubMcpServerSet0 = _datastoreLlmHub.McpServerSet.CreateObject();
    _objLlmHubLlmConversation2 = _datastoreLlmHub.LlmConversation.CreateObject();
    _objLlmHubMcpServerConfig1 = _datastoreLlmHub.McpServerConfig.CreateObject();
    _objLlmHubLlmConversation2.SetApiKey(_paramApiKey);
    _objLlmHubLlmConversation2.SetApiProvider((LlmHubDataStore.ApiProvider)(uint)(1));
    _objLlmHubLlmConversation2.SetModelSize((LlmHubDataStore.ModelSizeHint)(uint)(1));
    _objLlmHubLlmConversation2.SetSysPrompt(_paramSystemPrompt);
    _objLlmHubLlmConversation2.SetMcpServerSet(_objLlmHubMcpServerSet0.GetXrpaId());
    _objLlmHubMcpServerConfig1.SetUrl("http://127.0.0.1:3120/mcp");
    _objLlmHubMcpServerConfig1.SetAuthToken("");
    _objLlmHubMcpServerConfig1.SetServerSet(_objLlmHubMcpServerSet0.GetXrpaId());
    _objLlmHubLlmConversation2.OnChatResponse(Dispatch_objLlmHubLlmConversation2ChatResponse);
  }

  void DestroyObjects() {
    if (_objLlmHubMcpServerConfig1 != null) {
      _datastoreLlmHub.McpServerConfig.RemoveObject(_objLlmHubMcpServerConfig1.GetXrpaId());
      _objLlmHubMcpServerConfig1 = null;
    }
    if (_objLlmHubLlmConversation2 != null) {
      _datastoreLlmHub.LlmConversation.RemoveObject(_objLlmHubLlmConversation2.GetXrpaId());
      _objLlmHubLlmConversation2 = null;
    }
    if (_objLlmHubMcpServerSet0 != null) {
      _datastoreLlmHub.McpServerSet.RemoveObject(_objLlmHubMcpServerSet0.GetXrpaId());
      _objLlmHubMcpServerSet0 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace XrpaDataflow
