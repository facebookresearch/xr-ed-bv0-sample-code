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
public class XredSignalOutputModuleSubsystem : MonoBehaviour {
  private static XredSignalOutputModuleSubsystem _Instance;

  public static XredSignalOutputModuleSubsystem MaybeInstance { get => _Instance; }

  public static XredSignalOutputModuleSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindObjectOfType<XredSignalOutputModuleSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(XredSignalOutputModuleSubsystem).Name };
        _Instance = obj.AddComponent<XredSignalOutputModuleSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      {
        var localXredSignalOutputSignalOutputDataset = new Xrpa.SharedDataset("SignalOutput", SignalOutputDataStore.SignalOutputDataStoreConfig.GenDatasetConfig());
        localXredSignalOutputSignalOutputDataset.Initialize();
        XredSignalOutputSignalOutputDataset = localXredSignalOutputSignalOutputDataset;
      }
    } else if (_Instance != this) {
      Destroy(gameObject);
    }
  }

  void OnDestroy() {
    SignalOutputDataStoreSubsystem.MaybeInstance?.Shutdown();
    XredSignalOutputSignalOutputDataset?.Dispose();
    XredSignalOutputSignalOutputDataset = null;
    if (_Instance == this) {
      _Instance = null;
    }
  }

  public Xrpa.DatasetInterface XredSignalOutputSignalOutputDataset;
}
