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

public class ContinuousWaveComponent : MonoBehaviour {
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
  private float _GainChannel1 = 1f;

  public float GainChannel1 {
    get => _GainChannel1;
    set {
      _GainChannel1 = value;
      if (_currentObj != null) {
        _currentObj.SetGainChannel1(value);
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

  private XrpaDataflow.ContinuousWave _currentObj;

  void OnValidate() {
    if (_currentObj != null) {
      if (!_currentObj.GetFundamentalAmp().Equals(_FundamentalAmp)) {
        _currentObj.SetFundamentalAmp(_FundamentalAmp);
      }
      if (!_currentObj.GetFundamentalFq().Equals(_FundamentalFq)) {
        _currentObj.SetFundamentalFq(_FundamentalFq);
      }
      if (!_currentObj.GetGainChannel0().Equals(_GainChannel0)) {
        _currentObj.SetGainChannel0(_GainChannel0);
      }
      if (!_currentObj.GetGainChannel1().Equals(_GainChannel1)) {
        _currentObj.SetGainChannel1(_GainChannel1);
      }
      if (!_currentObj.GetLFOAmp().Equals(_LFOAmp)) {
        _currentObj.SetLFOAmp(_LFOAmp);
      }
      if (!_currentObj.GetLFOFq().Equals(_LFOFq)) {
        _currentObj.SetLFOFq(_LFOFq);
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
    _currentObj = new XrpaDataflow.ContinuousWave(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    _currentObj.SetFundamentalAmp(FundamentalAmp);
    _currentObj.SetFundamentalFq(FundamentalFq);
    _currentObj.SetGainChannel0(GainChannel0);
    _currentObj.SetGainChannel1(GainChannel1);
    _currentObj.SetLFOAmp(LFOAmp);
    _currentObj.SetLFOFq(LFOFq);
  }

  public void Stop() {
    if (_currentObj != null) {
      _currentObj.Terminate();
    }
    _currentObj = null;
  }

  public XrpaDataflow.ContinuousWave Spawn() {
    var ret = new XrpaDataflow.ContinuousWave(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    ret.SetFundamentalAmp(FundamentalAmp);
    ret.SetFundamentalFq(FundamentalFq);
    ret.SetGainChannel0(GainChannel0);
    ret.SetGainChannel1(GainChannel1);
    ret.SetLFOAmp(LFOAmp);
    ret.SetLFOFq(LFOFq);
    return ret;
  }
}
