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

using UnityEngine;
using Xrpa;

[AddComponentMenu("")]
public class LlmHubTransportSubsystem : MonoBehaviour {
  private static LlmHubTransportSubsystem _Instance;

  public static LlmHubTransportSubsystem MaybeInstance { get => _Instance; }

  public static LlmHubTransportSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindAnyObjectByType<LlmHubTransportSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(LlmHubTransportSubsystem).Name };
        _Instance = obj.AddComponent<LlmHubTransportSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      {
        var localLlmHubInboundTransport = new Xrpa.SharedMemoryTransportStream("LlmHubOutput", LlmHubDataStore.LlmHubDataStoreConfig.GenTransportConfig());
        LlmHubInboundTransport = localLlmHubInboundTransport;

        var localLlmHubOutboundTransport = new Xrpa.SharedMemoryTransportStream("LlmHubInput", LlmHubDataStore.LlmHubDataStoreConfig.GenTransportConfig());
        LlmHubOutboundTransport = localLlmHubOutboundTransport;
      }
    } else if (_Instance != this) {
      Destroy(gameObject);
    }
  }

  void OnDestroy() {
    LlmHubDataStoreSubsystem.MaybeInstance?.Shutdown();
    LlmHubOutboundTransport?.Dispose();
    LlmHubOutboundTransport = null;
    LlmHubInboundTransport?.Dispose();
    LlmHubInboundTransport = null;
    if (_Instance == this) {
      _Instance = null;
    }
  }

  public Xrpa.TransportStream LlmHubInboundTransport;
  public Xrpa.TransportStream LlmHubOutboundTransport;
}
