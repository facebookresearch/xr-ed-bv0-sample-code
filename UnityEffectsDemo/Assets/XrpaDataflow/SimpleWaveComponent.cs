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

public class SimpleWaveComponent : MonoBehaviour {
  [SerializeField]
  public bool AutoRun = false;

  [SerializeField]
  private float _Amp = 1f;

  public float Amp {
    get => _Amp;
    set {
      _Amp = value;
      if (_currentObj != null) {
        _currentObj.SetAmp(value);
      }
    }
  }

  [SerializeField]
  private float _Fq = 170f;

  public float Fq {
    get => _Fq;
    set {
      _Fq = value;
      if (_currentObj != null) {
        _currentObj.SetFq(value);
      }
    }
  }

  private XrpaDataflow.SimpleWave _currentObj;

  void OnValidate() {
    if (_currentObj != null) {
      if (!_currentObj.GetAmp().Equals(_Amp)) {
        _currentObj.SetAmp(_Amp);
      }
      if (!_currentObj.GetFq().Equals(_Fq)) {
        _currentObj.SetFq(_Fq);
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
    _currentObj = new XrpaDataflow.SimpleWave(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    _currentObj.SetAmp(Amp);
    _currentObj.SetFq(Fq);
  }

  public void Stop() {
    if (_currentObj != null) {
      _currentObj.Terminate();
    }
    _currentObj = null;
  }

  public XrpaDataflow.SimpleWave Spawn() {
    var ret = new XrpaDataflow.SimpleWave(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    ret.SetAmp(Amp);
    ret.SetFq(Fq);
    return ret;
  }
}
