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

public class LoopingPatternComponent : MonoBehaviour {
  [SerializeField]
  public bool AutoRun = false;

  [SerializeField]
  private float _FundamentalAmp = 1f;

  public float FundamentalAmp {
    get => _FundamentalAmp;
    set {
      _FundamentalAmp = value;
      if (_currentObj != null) {
        _currentObj.SetFundamentalAmp(value);
      }
    }
  }

  [SerializeField]
  private float _FundamentalFq = 170f;

  public float FundamentalFq {
    get => _FundamentalFq;
    set {
      _FundamentalFq = value;
      if (_currentObj != null) {
        _currentObj.SetFundamentalFq(value);
      }
    }
  }

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
  private float _LFOAmp = 1f;

  public float LFOAmp {
    get => _LFOAmp;
    set {
      _LFOAmp = value;
      if (_currentObj != null) {
        _currentObj.SetLFOAmp(value);
      }
    }
  }

  [SerializeField]
  private float _LFOFq = 5f;

  public float LFOFq {
    get => _LFOFq;
    set {
      _LFOFq = value;
      if (_currentObj != null) {
        _currentObj.SetLFOFq(value);
      }
    }
  }

  [SerializeField]
  private float _PauseDuration = 0.25f;

  public float PauseDuration {
    get => _PauseDuration;
    set {
      _PauseDuration = value;
      if (_currentObj != null) {
        _currentObj.SetPauseDuration(value);
      }
    }
  }

  [SerializeField]
  private float _PulseDuration = 0.5f;

  public float PulseDuration {
    get => _PulseDuration;
    set {
      _PulseDuration = value;
      if (_currentObj != null) {
        _currentObj.SetPulseDuration(value);
      }
    }
  }

  private SignalProcessingDataStore.LoopingPattern _currentObj;

  void OnValidate() {
    if (_currentObj != null) {
      if (!_currentObj.GetFundamentalAmp().Equals(_FundamentalAmp)) {
        _currentObj.SetFundamentalAmp(_FundamentalAmp);
      }
      if (!_currentObj.GetFundamentalFq().Equals(_FundamentalFq)) {
        _currentObj.SetFundamentalFq(_FundamentalFq);
      }
      if (!_currentObj.GetGain0().Equals(_Gain0)) {
        _currentObj.SetGain0(_Gain0);
      }
      if (!_currentObj.GetGain1().Equals(_Gain1)) {
        _currentObj.SetGain1(_Gain1);
      }
      if (!_currentObj.GetLFOAmp().Equals(_LFOAmp)) {
        _currentObj.SetLFOAmp(_LFOAmp);
      }
      if (!_currentObj.GetLFOFq().Equals(_LFOFq)) {
        _currentObj.SetLFOFq(_LFOFq);
      }
      if (!_currentObj.GetPauseDuration().Equals(_PauseDuration)) {
        _currentObj.SetPauseDuration(_PauseDuration);
      }
      if (!_currentObj.GetPulseDuration().Equals(_PulseDuration)) {
        _currentObj.SetPulseDuration(_PulseDuration);
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
    _currentObj = new SignalProcessingDataStore.LoopingPattern(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    _currentObj.SetFundamentalAmp(FundamentalAmp);
    _currentObj.SetFundamentalFq(FundamentalFq);
    _currentObj.SetGain0(Gain0);
    _currentObj.SetGain1(Gain1);
    _currentObj.SetLFOAmp(LFOAmp);
    _currentObj.SetLFOFq(LFOFq);
    _currentObj.SetPauseDuration(PauseDuration);
    _currentObj.SetPulseDuration(PulseDuration);
  }

  public void Stop() {
    if (_currentObj != null) {
      _currentObj.Terminate();
    }
    _currentObj = null;
  }

  public SignalProcessingDataStore.LoopingPattern Spawn() {
    var ret = new SignalProcessingDataStore.LoopingPattern(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    ret.SetFundamentalAmp(FundamentalAmp);
    ret.SetFundamentalFq(FundamentalFq);
    ret.SetGain0(Gain0);
    ret.SetGain1(Gain1);
    ret.SetLFOAmp(LFOAmp);
    ret.SetLFOFq(LFOFq);
    ret.SetPauseDuration(PauseDuration);
    ret.SetPulseDuration(PulseDuration);
    return ret;
  }
}
