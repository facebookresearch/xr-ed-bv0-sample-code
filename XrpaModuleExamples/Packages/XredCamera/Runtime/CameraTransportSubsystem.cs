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
public class CameraTransportSubsystem : MonoBehaviour {
  private static CameraTransportSubsystem _Instance;

  public static CameraTransportSubsystem MaybeInstance { get => _Instance; }

  public static CameraTransportSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindAnyObjectByType<CameraTransportSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(CameraTransportSubsystem).Name };
        _Instance = obj.AddComponent<CameraTransportSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      {
        var localCameraInboundTransport = new Xrpa.SharedMemoryTransportStream("CameraOutput", CameraDataStore.CameraDataStoreConfig.GenTransportConfig());
        CameraInboundTransport = localCameraInboundTransport;

        var localCameraOutboundTransport = new Xrpa.SharedMemoryTransportStream("CameraInput", CameraDataStore.CameraDataStoreConfig.GenTransportConfig());
        CameraOutboundTransport = localCameraOutboundTransport;
      }
    } else if (_Instance != this) {
      Destroy(gameObject);
    }
  }

  void OnDestroy() {
    CameraDataStoreSubsystem.MaybeInstance?.Shutdown();
    CameraOutboundTransport?.Dispose();
    CameraOutboundTransport = null;
    CameraInboundTransport?.Dispose();
    CameraInboundTransport = null;
    if (_Instance == this) {
      _Instance = null;
    }
  }

  public Xrpa.TransportStream CameraInboundTransport;
  public Xrpa.TransportStream CameraOutboundTransport;
}
