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
public class SignalProcessingDataStoreSubsystem : MonoBehaviour {
  private static SignalProcessingDataStoreSubsystem _Instance;

  public static SignalProcessingDataStoreSubsystem MaybeInstance { get => _Instance; }

  public static SignalProcessingDataStoreSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindObjectOfType<SignalProcessingDataStoreSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(SignalProcessingDataStoreSubsystem).Name };
        _Instance = obj.AddComponent<SignalProcessingDataStoreSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      DataStore = new SignalProcessingDataStore.SignalProcessingDataStore(SignalProcessingTransportSubsystem.Instance.SignalProcessingDataset);
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

  void LateUpdate() {
    DataStore?.Tick();
  }

  public void Shutdown() {
    OnDestroy();
  }

  public SignalProcessingDataStore.SignalProcessingDataStore DataStore;
}
