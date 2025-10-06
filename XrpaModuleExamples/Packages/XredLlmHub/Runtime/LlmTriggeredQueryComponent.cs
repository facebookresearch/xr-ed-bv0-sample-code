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

using LlmHubDataStore;
using System;
using UnityEngine;
using Xrpa;

public class LlmTriggeredQueryComponent : MonoBehaviour {
  [SerializeField]
  private string _ApiKey = "";

  public string ApiKey {
    get => _ApiKey;
    set {
      _ApiKey = value;
      if (_xrpaObject != null) { _xrpaObject.SetApiKey(value); }
    }
  }

  [SerializeField]
  private LlmHubDataStore.ApiProvider _ApiProvider = LlmHubDataStore.ApiProvider.MetaGenProxy;

  public LlmHubDataStore.ApiProvider ApiProvider {
    get => _ApiProvider;
    set {
      _ApiProvider = value;
      if (_xrpaObject != null) { _xrpaObject.SetApiProvider(value); }
    }
  }

  [SerializeField]
  private LlmHubDataStore.ModelSizeHint _ModelSize = LlmHubDataStore.ModelSizeHint.Small;

  public LlmHubDataStore.ModelSizeHint ModelSize {
    get => _ModelSize;
    set {
      _ModelSize = value;
      if (_xrpaObject != null) { _xrpaObject.SetModelSize(value); }
    }
  }

  [SerializeField]
  private string _SysPrompt = "";

  public string SysPrompt {
    get => _SysPrompt;
    set {
      _SysPrompt = value;
      if (_xrpaObject != null) { _xrpaObject.SetSysPrompt(value); }
    }
  }

  [SerializeField]

  // Controls randomness: 0.0 = deterministic, 1.0 = creative
  private float _Temperature = 0.7f;

  public float Temperature {
    get => _Temperature;
    set {
      _Temperature = value;
      if (_xrpaObject != null) { _xrpaObject.SetTemperature(value); }
    }
  }

  [SerializeField]

  // Maximum number of tokens to generate
  private int _MaxTokens = 256;

  public int MaxTokens {
    get => _MaxTokens;
    set {
      _MaxTokens = value;
      if (_xrpaObject != null) { _xrpaObject.SetMaxTokens(value); }
    }
  }

  [SerializeField]

  // Maximum number of consecutive tool calls
  private int _MaxConsecutiveToolCalls = 20;

  public int MaxConsecutiveToolCalls {
    get => _MaxConsecutiveToolCalls;
    set {
      _MaxConsecutiveToolCalls = value;
      if (_xrpaObject != null) { _xrpaObject.SetMaxConsecutiveToolCalls(value); }
    }
  }

  private int _IsProcessing = 0;

  public int IsProcessing {
    get => _IsProcessing;
  }

  [SerializeField]

  // Optional JSON schema for the response.
  private string _JsonSchema = "";

  public string JsonSchema {
    get => _JsonSchema;
    set {
      _JsonSchema = value;
      if (_xrpaObject != null) { _xrpaObject.SetJsonSchema(value); }
    }
  }

  [SerializeField]
  private Xrpa.ObjectUuid _McpServerSet = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};

  public Xrpa.ObjectUuid McpServerSet {
    get => _McpServerSet;
    set {
      _McpServerSet = value;
      if (_xrpaObject != null) { _xrpaObject.SetMcpServerSet(value); }
    }
  }

  [SerializeField]
  private string _UserPrompt = "";

  public string UserPrompt {
    get => _UserPrompt;
    set {
      _UserPrompt = value;
      if (_xrpaObject != null) { _xrpaObject.SetUserPrompt(value); }
    }
  }

  [SerializeField]
  private int _TriggerId = 0;

  public int TriggerId {
    get => _TriggerId;
    set {
      _TriggerId = value;
      if (_xrpaObject != null) { _xrpaObject.SetTriggerId(value); }
    }
  }

  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected LlmHubDataStore.OutboundLlmTriggeredQuery _xrpaObject;
  public event System.Action<ulong, string, int> OnResponse;
  public event System.Action<ulong, string, int> OnResponseStream;
  protected bool _dsIsInitialized = false;

  void OnValidate() {
    if (_xrpaObject != null) { _xrpaObject.SetApiKey(_ApiKey); }
    if (_xrpaObject != null) { _xrpaObject.SetApiProvider(_ApiProvider); }
    if (_xrpaObject != null) { _xrpaObject.SetModelSize(_ModelSize); }
    if (_xrpaObject != null) { _xrpaObject.SetSysPrompt(_SysPrompt); }
    if (_xrpaObject != null) { _xrpaObject.SetTemperature(_Temperature); }
    if (_xrpaObject != null) { _xrpaObject.SetMaxTokens(_MaxTokens); }
    if (_xrpaObject != null) { _xrpaObject.SetMaxConsecutiveToolCalls(_MaxConsecutiveToolCalls); }
    if (_xrpaObject != null) { _xrpaObject.SetJsonSchema(_JsonSchema); }
    if (_xrpaObject != null) { _xrpaObject.SetMcpServerSet(_McpServerSet); }
    if (_xrpaObject != null) { _xrpaObject.SetUserPrompt(_UserPrompt); }
    if (_xrpaObject != null) { _xrpaObject.SetTriggerId(_TriggerId); }
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
    if (_xrpaObject.CheckIsProcessingChanged(fieldsChanged)) {
      _IsProcessing = _xrpaObject.GetIsProcessing();
    }
  }

  public void SendRgbImageFeed(Xrpa.Image image) {
    _xrpaObject?.SendRgbImageFeed(image);
  }

  void DispatchResponse(ulong msgTimestamp, LlmHubDataStore.LlmChatResponseReader message) {
    OnResponse?.Invoke(msgTimestamp, message.GetData(), message.GetId());
  }

  void DispatchResponseStream(ulong msgTimestamp, LlmHubDataStore.LlmChatResponseReader message) {
    OnResponseStream?.Invoke(msgTimestamp, message.GetData(), message.GetId());
  }

  public void InitializeDS() {
    if (_dsIsInitialized) {
      return;
    }
    _dsIsInitialized = true;
    _id = new Xrpa.ObjectUuid(System.Guid.NewGuid());

    _IsProcessing = 0;

    _xrpaObject = new LlmHubDataStore.OutboundLlmTriggeredQuery(_id);
    _xrpaObject.SetXrpaOwner(this);
    LlmHubDataStoreSubsystem.Instance.DataStore.LlmTriggeredQuery.AddObject(_xrpaObject);
    _xrpaObject.SetApiKey(_ApiKey);
    _xrpaObject.SetApiProvider(_ApiProvider);
    _xrpaObject.SetModelSize(_ModelSize);
    _xrpaObject.SetSysPrompt(_SysPrompt);
    _xrpaObject.SetTemperature(_Temperature);
    _xrpaObject.SetMaxTokens(_MaxTokens);
    _xrpaObject.SetMaxConsecutiveToolCalls(_MaxConsecutiveToolCalls);
    _xrpaObject.SetJsonSchema(_JsonSchema);
    _xrpaObject.SetMcpServerSet(_McpServerSet);
    _xrpaObject.SetUserPrompt(_UserPrompt);
    _xrpaObject.SetTriggerId(_TriggerId);
    _xrpaObject.OnXrpaFieldsChanged(HandleXrpaFieldsChanged);
    _xrpaObject.OnResponse(DispatchResponse);
    _xrpaObject.OnResponseStream(DispatchResponseStream);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _xrpaObject.OnXrpaFieldsChanged(null);
    LlmHubDataStoreSubsystem.MaybeInstance?.DataStore.LlmTriggeredQuery.RemoveObject(_id);
    _xrpaObject = null;
    _dsIsInitialized = false;
  }
}
