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
public class EyeTrackingTransportSubsystem : MonoBehaviour {
  private static EyeTrackingTransportSubsystem _Instance;

  public static EyeTrackingTransportSubsystem MaybeInstance { get => _Instance; }

  public static EyeTrackingTransportSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindAnyObjectByType<EyeTrackingTransportSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(EyeTrackingTransportSubsystem).Name };
        _Instance = obj.AddComponent<EyeTrackingTransportSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      {
        var localEyeTrackingInboundTransport = new Xrpa.SharedMemoryTransportStream("EyeTrackingOutput", EyeTrackingDataStore.EyeTrackingDataStoreConfig.GenTransportConfig());
        EyeTrackingInboundTransport = localEyeTrackingInboundTransport;

        var localEyeTrackingOutboundTransport = new Xrpa.SharedMemoryTransportStream("EyeTrackingInput", EyeTrackingDataStore.EyeTrackingDataStoreConfig.GenTransportConfig());
        EyeTrackingOutboundTransport = localEyeTrackingOutboundTransport;
      }
    } else if (_Instance != this) {
      Destroy(gameObject);
    }
  }

  void OnDestroy() {
    EyeTrackingDataStoreSubsystem.MaybeInstance?.Shutdown();
    EyeTrackingOutboundTransport?.Dispose();
    EyeTrackingOutboundTransport = null;
    EyeTrackingInboundTransport?.Dispose();
    EyeTrackingInboundTransport = null;
    if (_Instance == this) {
      _Instance = null;
    }
  }

  public Xrpa.TransportStream EyeTrackingInboundTransport;
  public Xrpa.TransportStream EyeTrackingOutboundTransport;
}
