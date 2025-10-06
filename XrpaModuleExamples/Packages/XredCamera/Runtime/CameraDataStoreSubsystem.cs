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

[AddComponentMenu("")]
public class CameraDataStoreSubsystem : MonoBehaviour {
  private static CameraDataStoreSubsystem _Instance;

  public static CameraDataStoreSubsystem MaybeInstance { get => _Instance; }

  public static CameraDataStoreSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindAnyObjectByType<CameraDataStoreSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(CameraDataStoreSubsystem).Name };
        _Instance = obj.AddComponent<CameraDataStoreSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      var transportSubsystem = CameraTransportSubsystem.Instance;
      DataStore = new CameraDataStore.CameraDataStore(transportSubsystem.CameraInboundTransport, transportSubsystem.CameraOutboundTransport);
    } else if (_Instance != this) {
      Destroy(gameObject);
    }
  }

  void OnDestroy() {
    DataStore?.Shutdown();
    DataStore = null;
    if (_Instance == this) {
      _Instance = null;
    }
  }

  void Update() {
    DataStore?.TickInbound();
  }

  void LateUpdate() {
    DataStore?.TickOutbound();
  }

  public void Shutdown() {
    OnDestroy();
  }

  public CameraDataStore.CameraDataStore DataStore;
}
