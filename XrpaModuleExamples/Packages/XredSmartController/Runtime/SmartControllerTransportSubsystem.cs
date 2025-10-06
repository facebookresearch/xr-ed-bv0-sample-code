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
public class SmartControllerTransportSubsystem : MonoBehaviour {
  private static SmartControllerTransportSubsystem _Instance;

  public static SmartControllerTransportSubsystem MaybeInstance { get => _Instance; }

  public static SmartControllerTransportSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindAnyObjectByType<SmartControllerTransportSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(SmartControllerTransportSubsystem).Name };
        _Instance = obj.AddComponent<SmartControllerTransportSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      {
        var localSmartControllerInboundTransport = new Xrpa.SharedMemoryTransportStream("SmartControllerOutput", SmartControllerDataStore.SmartControllerDataStoreConfig.GenTransportConfig());
        SmartControllerInboundTransport = localSmartControllerInboundTransport;

        var localSmartControllerOutboundTransport = new Xrpa.SharedMemoryTransportStream("SmartControllerInput", SmartControllerDataStore.SmartControllerDataStoreConfig.GenTransportConfig());
        SmartControllerOutboundTransport = localSmartControllerOutboundTransport;
      }
    } else if (_Instance != this) {
      Destroy(gameObject);
    }
  }

  void OnDestroy() {
    SmartControllerDataStoreSubsystem.MaybeInstance?.Shutdown();
    SmartControllerOutboundTransport?.Dispose();
    SmartControllerOutboundTransport = null;
    SmartControllerInboundTransport?.Dispose();
    SmartControllerInboundTransport = null;
    if (_Instance == this) {
      _Instance = null;
    }
  }

  public Xrpa.TransportStream SmartControllerInboundTransport;
  public Xrpa.TransportStream SmartControllerOutboundTransport;
}
