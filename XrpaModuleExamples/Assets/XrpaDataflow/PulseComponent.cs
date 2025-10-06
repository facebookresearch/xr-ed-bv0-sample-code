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

public class PulseComponent : MonoBehaviour {
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
  private float _HoldTime = 0.2f;

  public float HoldTime {
    get => _HoldTime;
    set {
      _HoldTime = value;
      if (_currentObj != null) {
        _currentObj.SetHoldTime(value);
      }
    }
  }

  [SerializeField]
  private float _RampDownTime = 0.2f;

  public float RampDownTime {
    get => _RampDownTime;
    set {
      _RampDownTime = value;
      if (_currentObj != null) {
        _currentObj.SetRampDownTime(value);
      }
    }
  }

  [SerializeField]
  private float _RampUpTime = 0.2f;

  public float RampUpTime {
    get => _RampUpTime;
    set {
      _RampUpTime = value;
      if (_currentObj != null) {
        _currentObj.SetRampUpTime(value);
      }
    }
  }

  private XrpaDataflow.Pulse _currentObj;

  void OnValidate() {
    if (_currentObj != null) {
      if (!_currentObj.GetFundamentalAmp().Equals(_FundamentalAmp)) {
        _currentObj.SetFundamentalAmp(_FundamentalAmp);
      }
      if (!_currentObj.GetFundamentalFq().Equals(_FundamentalFq)) {
        _currentObj.SetFundamentalFq(_FundamentalFq);
      }
      if (!_currentObj.GetHoldTime().Equals(_HoldTime)) {
        _currentObj.SetHoldTime(_HoldTime);
      }
      if (!_currentObj.GetRampDownTime().Equals(_RampDownTime)) {
        _currentObj.SetRampDownTime(_RampDownTime);
      }
      if (!_currentObj.GetRampUpTime().Equals(_RampUpTime)) {
        _currentObj.SetRampUpTime(_RampUpTime);
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
    _currentObj = new XrpaDataflow.Pulse(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    _currentObj.SetFundamentalAmp(FundamentalAmp);
    _currentObj.SetFundamentalFq(FundamentalFq);
    _currentObj.SetHoldTime(HoldTime);
    _currentObj.SetRampDownTime(RampDownTime);
    _currentObj.SetRampUpTime(RampUpTime);
  }

  public void Stop() {
    if (_currentObj != null) {
      _currentObj.Terminate();
    }
    _currentObj = null;
  }

  public XrpaDataflow.Pulse Spawn() {
    var ret = new XrpaDataflow.Pulse(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    ret.SetFundamentalAmp(FundamentalAmp);
    ret.SetFundamentalFq(FundamentalFq);
    ret.SetHoldTime(HoldTime);
    ret.SetRampDownTime(RampDownTime);
    ret.SetRampUpTime(RampUpTime);
    return ret;
  }
}
