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

public class PulsePatternComponent : MonoBehaviour {
  [SerializeField]
  public bool AutoRun = false;

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

  [SerializeField]
  private float _SawAmp = 1f;

  public float SawAmp {
    get => _SawAmp;
    set {
      _SawAmp = value;
      if (_currentObj != null) {
        _currentObj.SetSawAmp(value);
      }
    }
  }

  [SerializeField]
  private float _SinAmp = 1f;

  public float SinAmp {
    get => _SinAmp;
    set {
      _SinAmp = value;
      if (_currentObj != null) {
        _currentObj.SetSinAmp(value);
      }
    }
  }

  [SerializeField]
  private float _SquareAmp = 1f;

  public float SquareAmp {
    get => _SquareAmp;
    set {
      _SquareAmp = value;
      if (_currentObj != null) {
        _currentObj.SetSquareAmp(value);
      }
    }
  }

  [SerializeField]
  private float _TriAmp = 1f;

  public float TriAmp {
    get => _TriAmp;
    set {
      _TriAmp = value;
      if (_currentObj != null) {
        _currentObj.SetTriAmp(value);
      }
    }
  }

  private XrpaDataflow.PulsePattern _currentObj;

  void OnValidate() {
    if (_currentObj != null) {
      if (!_currentObj.GetFq().Equals(_Fq)) {
        _currentObj.SetFq(_Fq);
      }
      if (!_currentObj.GetPauseDuration().Equals(_PauseDuration)) {
        _currentObj.SetPauseDuration(_PauseDuration);
      }
      if (!_currentObj.GetPulseDuration().Equals(_PulseDuration)) {
        _currentObj.SetPulseDuration(_PulseDuration);
      }
      if (!_currentObj.GetSawAmp().Equals(_SawAmp)) {
        _currentObj.SetSawAmp(_SawAmp);
      }
      if (!_currentObj.GetSinAmp().Equals(_SinAmp)) {
        _currentObj.SetSinAmp(_SinAmp);
      }
      if (!_currentObj.GetSquareAmp().Equals(_SquareAmp)) {
        _currentObj.SetSquareAmp(_SquareAmp);
      }
      if (!_currentObj.GetTriAmp().Equals(_TriAmp)) {
        _currentObj.SetTriAmp(_TriAmp);
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
    _currentObj = new XrpaDataflow.PulsePattern(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    _currentObj.SetFq(Fq);
    _currentObj.SetPauseDuration(PauseDuration);
    _currentObj.SetPulseDuration(PulseDuration);
    _currentObj.SetSawAmp(SawAmp);
    _currentObj.SetSinAmp(SinAmp);
    _currentObj.SetSquareAmp(SquareAmp);
    _currentObj.SetTriAmp(TriAmp);
  }

  public void Stop() {
    if (_currentObj != null) {
      _currentObj.Terminate();
    }
    _currentObj = null;
  }

  public XrpaDataflow.PulsePattern Spawn() {
    var ret = new XrpaDataflow.PulsePattern(SignalProcessingDataStoreSubsystem.Instance.DataStore);
    ret.SetFq(Fq);
    ret.SetPauseDuration(PauseDuration);
    ret.SetPulseDuration(PulseDuration);
    ret.SetSawAmp(SawAmp);
    ret.SetSinAmp(SinAmp);
    ret.SetSquareAmp(SquareAmp);
    ret.SetTriAmp(TriAmp);
    return ret;
  }
}
