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

public class BG_CComponent : MonoBehaviour {
  [SerializeField]
  public bool AutoRun = false;

  [SerializeField]
  private float _Gain0 = 1f;

  public float Gain0 {
    get => _Gain0;
    set {
      _Gain0 = value;
      if (_currentObj != null) {
        _currentObj.SetGain0(value);
      }
    }
  }

  [SerializeField]
  private float _Gain1 = 1f;

  public float Gain1 {
    get => _Gain1;
    set {
      _Gain1 = value;
      if (_currentObj != null) {
        _currentObj.SetGain1(value);
      }
    }
  }

  [SerializeField]
  private float _Gain2 = 1f;

  public float Gain2 {
    get => _Gain2;
    set {
      _Gain2 = value;
      if (_currentObj != null) {
        _currentObj.SetGain2(value);
      }
    }
  }

  [SerializeField]
  private float _Gain3 = 1f;

  public float Gain3 {
    get => _Gain3;
    set {
      _Gain3 = value;
      if (_currentObj != null) {
        _currentObj.SetGain3(value);
      }
    }
  }

  [SerializeField]
  private float _Gain4 = 1f;

  public float Gain4 {
    get => _Gain4;
    set {
      _Gain4 = value;
      if (_currentObj != null) {
        _currentObj.SetGain4(value);
      }
    }
  }

  private XrpaDataflow.BG_C _currentObj;

  void OnValidate() {
    if (_currentObj != null) {
      if (!_currentObj.GetGain0().Equals(_Gain0)) {
        _currentObj.SetGain0(_Gain0);
      }
      if (!_currentObj.GetGain1().Equals(_Gain1)) {
        _currentObj.SetGain1(_Gain1);
      }
      if (!_currentObj.GetGain2().Equals(_Gain2)) {
        _currentObj.SetGain2(_Gain2);
      }
      if (!_currentObj.GetGain3().Equals(_Gain3)) {
        _currentObj.SetGain3(_Gain3);
      }
      if (!_currentObj.GetGain4().Equals(_Gain4)) {
        _currentObj.SetGain4(_Gain4);
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
    _currentObj = new XrpaDataflow.BG_C(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    _currentObj.SetGain0(Gain0);
    _currentObj.SetGain1(Gain1);
    _currentObj.SetGain2(Gain2);
    _currentObj.SetGain3(Gain3);
    _currentObj.SetGain4(Gain4);
  }

  public void Stop() {
    if (_currentObj != null) {
      _currentObj.Terminate();
    }
    _currentObj = null;
  }

  public XrpaDataflow.BG_C Spawn() {
    var ret = new XrpaDataflow.BG_C(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    ret.SetGain0(Gain0);
    ret.SetGain1(Gain1);
    ret.SetGain2(Gain2);
    ret.SetGain3(Gain3);
    ret.SetGain4(Gain4);
    return ret;
  }
}
