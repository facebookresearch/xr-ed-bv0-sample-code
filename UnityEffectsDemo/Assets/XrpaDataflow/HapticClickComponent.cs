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

using UnityEngine;
using XrpaDataflow;

public class HapticClickComponent : MonoBehaviour {
  [SerializeField]
  public bool AutoRun = false;

  [SerializeField]
  private float _GainChannel0 = 1f;

  public float GainChannel0 {
    get => _GainChannel0;
    set {
      _GainChannel0 = value;
      if (_currentObj != null) {
        _currentObj.SetGainChannel0(value);
      }
    }
  }

  [SerializeField]
  private float _GainChannel1 = 0f;

  public float GainChannel1 {
    get => _GainChannel1;
    set {
      _GainChannel1 = value;
      if (_currentObj != null) {
        _currentObj.SetGainChannel1(value);
      }
    }
  }

  private XrpaDataflow.HapticClick _currentObj;

  void OnValidate() {
    if (_currentObj != null) {
      if (!_currentObj.GetGainChannel0().Equals(_GainChannel0)) {
        _currentObj.SetGainChannel0(_GainChannel0);
      }
      if (!_currentObj.GetGainChannel1().Equals(_GainChannel1)) {
        _currentObj.SetGainChannel1(_GainChannel1);
      }
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
    _currentObj = new XrpaDataflow.HapticClick(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    _currentObj.SetGainChannel0(GainChannel0);
    _currentObj.SetGainChannel1(GainChannel1);
  }

  public void Stop() {
    if (_currentObj != null) {
      _currentObj.Terminate();
    }
    _currentObj = null;
  }

  public XrpaDataflow.HapticClick Spawn() {
    var ret = new XrpaDataflow.HapticClick(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    ret.SetGainChannel0(GainChannel0);
    ret.SetGainChannel1(GainChannel1);
    return ret;
  }
}
