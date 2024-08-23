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
public class SignalOutputDataStoreSubsystem : MonoBehaviour {
  private static SignalOutputDataStoreSubsystem _Instance;

  public static SignalOutputDataStoreSubsystem MaybeInstance { get => _Instance; }

  public static SignalOutputDataStoreSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindObjectOfType<SignalOutputDataStoreSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(SignalOutputDataStoreSubsystem).Name };
        _Instance = obj.AddComponent<SignalOutputDataStoreSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      DataStore = new SignalOutputDataStore.SignalOutputDataStore(XredSignalOutputModuleSubsystem.Instance.XredSignalOutputSignalOutputDataset);
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

  public SignalOutputDataStore.SignalOutputDataStore DataStore;
}
