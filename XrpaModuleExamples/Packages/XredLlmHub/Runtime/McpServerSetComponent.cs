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

public class McpServerSetComponent : MonoBehaviour {
  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected LlmHubDataStore.OutboundMcpServerSet _xrpaObject;
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

  public void InitializeDS() {
    if (_dsIsInitialized) {
      return;
    }
    _dsIsInitialized = true;
    _id = new Xrpa.ObjectUuid(System.Guid.NewGuid());

    _xrpaObject = new LlmHubDataStore.OutboundMcpServerSet(_id);
    _xrpaObject.SetXrpaOwner(this);
    LlmHubDataStoreSubsystem.Instance.DataStore.McpServerSet.AddObject(_xrpaObject);
    _xrpaObject.OnXrpaFieldsChanged(HandleXrpaFieldsChanged);
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _xrpaObject.OnXrpaFieldsChanged(null);
    LlmHubDataStoreSubsystem.MaybeInstance?.DataStore.McpServerSet.RemoveObject(_id);
    _xrpaObject = null;
    _dsIsInitialized = false;
  }
}
