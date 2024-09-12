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
public class SignalOutputTransportSubsystem : MonoBehaviour {
  private static SignalOutputTransportSubsystem _Instance;

  public static SignalOutputTransportSubsystem MaybeInstance { get => _Instance; }

  public static SignalOutputTransportSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindObjectOfType<SignalOutputTransportSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(SignalOutputTransportSubsystem).Name };
        _Instance = obj.AddComponent<SignalOutputTransportSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      {
        var localSignalOutputDataset = new Xrpa.SharedDataset("SignalOutput", SignalOutputDataStore.SignalOutputDataStoreConfig.GenDatasetConfig());
        localSignalOutputDataset.Initialize();
        SignalOutputDataset = localSignalOutputDataset;
      }
    } else if (_Instance != this) {
      Destroy(gameObject);
    }
  }

  void OnDestroy() {
    SignalOutputDataStoreSubsystem.MaybeInstance?.Shutdown();
    SignalOutputDataset?.Dispose();
    SignalOutputDataset = null;
    if (_Instance == this) {
      _Instance = null;
    }
  }

  public Xrpa.DatasetInterface SignalOutputDataset;
}
