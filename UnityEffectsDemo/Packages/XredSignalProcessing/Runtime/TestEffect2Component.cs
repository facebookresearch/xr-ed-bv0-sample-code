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

#pragma warning disable CS0414

using SignalProcessingDataStore;
using UnityEngine;

public class TestEffect2Component : MonoBehaviour {
  [SerializeField]
  public bool AutoRun = false;
  private SignalProcessingDataStore.TestEffect2 _currentObj;

  void OnValidate() {
    if (_currentObj != null) {
    }
  }

  void Start() {
    if (AutoRun) {
      Run();
    }
  }

  void OnDestroy() {
    Stop();
  }

  public void Run() {
    Stop();
    _currentObj = new SignalProcessingDataStore.TestEffect2(SignalProcessingDataStoreSubsystem.Instance.DataStore);
  }

  public void Stop() {
    if (_currentObj != null) {
      _currentObj.Terminate();
    }
    _currentObj = null;
  }

  public SignalProcessingDataStore.TestEffect2 Spawn() {
    var ret = new SignalProcessingDataStore.TestEffect2(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    return ret;
  }
}
