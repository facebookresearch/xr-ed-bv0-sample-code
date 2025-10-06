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

public class McpServerConfigComponent : MonoBehaviour {
  [SerializeField]

  // URL of the MCP server
  private string _Url = "http://localhost:3000/mcp";

  public string Url {
    get => _Url;
    set {
      _Url = value;
      if (_xrpaObject != null) { _xrpaObject.SetUrl(value); }
    }
  }

  [SerializeField]

  // Authentication token for the MCP server
  private string _AuthToken = "";

  public string AuthToken {
    get => _AuthToken;
    set {
      _AuthToken = value;
      if (_xrpaObject != null) { _xrpaObject.SetAuthToken(value); }
    }
  }

  [SerializeField]

  // Reference back to the server set this config belongs to
  private Xrpa.ObjectUuid _ServerSet = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};

  public Xrpa.ObjectUuid ServerSet {
    get => _ServerSet;
    set {
      _ServerSet = value;
      if (_xrpaObject != null) { _xrpaObject.SetServerSet(value); }
    }
  }

  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected LlmHubDataStore.OutboundMcpServerConfig _xrpaObject;
  protected bool _dsIsInitialized = false;

  public Xrpa.ObjectUuid GetServerSet() {
    return ServerSet;
  }

  void OnValidate() {
    if (_xrpaObject != null) { _xrpaObject.SetUrl(_Url); }
    if (_xrpaObject != null) { _xrpaObject.SetAuthToken(_AuthToken); }
    if (_xrpaObject != null) { _xrpaObject.SetServerSet(_ServerSet); }
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

    _xrpaObject = new LlmHubDataStore.OutboundMcpServerConfig(_id);
    _xrpaObject.SetXrpaOwner(this);
    LlmHubDataStoreSubsystem.Instance.DataStore.McpServerConfig.AddObject(_xrpaObject);
    _xrpaObject.SetUrl(_Url);
    _xrpaObject.SetAuthToken(_AuthToken);
    _xrpaObject.SetServerSet(_ServerSet);
    _xrpaObject.OnXrpaFieldsChanged(HandleXrpaFieldsChanged);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _xrpaObject.OnXrpaFieldsChanged(null);
    LlmHubDataStoreSubsystem.MaybeInstance?.DataStore.McpServerConfig.RemoveObject(_id);
    _xrpaObject = null;
    _dsIsInitialized = false;
  }
}
