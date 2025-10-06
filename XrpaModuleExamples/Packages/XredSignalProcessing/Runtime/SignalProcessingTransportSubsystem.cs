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
public class SignalProcessingTransportSubsystem : MonoBehaviour {
  private static SignalProcessingTransportSubsystem _Instance;

  public static SignalProcessingTransportSubsystem MaybeInstance { get => _Instance; }

  public static SignalProcessingTransportSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindAnyObjectByType<SignalProcessingTransportSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(SignalProcessingTransportSubsystem).Name };
        _Instance = obj.AddComponent<SignalProcessingTransportSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      {
        var localSignalProcessingInboundTransport = new Xrpa.SharedMemoryTransportStream("SignalProcessingOutput", SignalProcessingDataStore.SignalProcessingDataStoreConfig.GenTransportConfig());
        SignalProcessingInboundTransport = localSignalProcessingInboundTransport;

        var localSignalProcessingOutboundTransport = new Xrpa.SharedMemoryTransportStream("SignalProcessingInput", SignalProcessingDataStore.SignalProcessingDataStoreConfig.GenTransportConfig());
        SignalProcessingOutboundTransport = localSignalProcessingOutboundTransport;
      }
    } else if (_Instance != this) {
      Destroy(gameObject);
    }
  }

  void OnDestroy() {
    SignalProcessingDataStoreSubsystem.MaybeInstance?.Shutdown();
    SignalProcessingOutboundTransport?.Dispose();
    SignalProcessingOutboundTransport = null;
    SignalProcessingInboundTransport?.Dispose();
    SignalProcessingInboundTransport = null;
    if (_Instance == this) {
      _Instance = null;
    }
  }

  public Xrpa.TransportStream SignalProcessingInboundTransport;
  public Xrpa.TransportStream SignalProcessingOutboundTransport;
}
