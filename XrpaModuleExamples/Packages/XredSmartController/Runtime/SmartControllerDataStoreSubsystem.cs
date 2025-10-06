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
public class SmartControllerDataStoreSubsystem : MonoBehaviour {
  private static SmartControllerDataStoreSubsystem _Instance;

  public static SmartControllerDataStoreSubsystem MaybeInstance { get => _Instance; }

  public static SmartControllerDataStoreSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindAnyObjectByType<SmartControllerDataStoreSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(SmartControllerDataStoreSubsystem).Name };
        _Instance = obj.AddComponent<SmartControllerDataStoreSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      var transportSubsystem = SmartControllerTransportSubsystem.Instance;
      DataStore = new SmartControllerDataStore.SmartControllerDataStore(transportSubsystem.SmartControllerInboundTransport, transportSubsystem.SmartControllerOutboundTransport);
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

  public SmartControllerDataStore.SmartControllerDataStore DataStore;
}
