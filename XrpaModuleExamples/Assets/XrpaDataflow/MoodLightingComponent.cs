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

using System.Collections.Generic;
using UnityEngine;
using XrpaDataflow;

public class MoodLightingComponent : MonoBehaviour {
  [SerializeField]
  public bool AutoRun = false;

  [SerializeField]
  private System.Collections.Generic.List<UnityEngine.Color32> _BaseLightColors = new System.Collections.Generic.List<UnityEngine.Color32>{new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}};

  public System.Collections.Generic.List<UnityEngine.Color32> BaseLightColors {
    get => _BaseLightColors;
    set {
      _BaseLightColors = value;
      if (_currentObj != null) {
        _currentObj.SetBaseLightColors(value);
      }
    }
  }

  [SerializeField]
  private string _IpAddress = "";

  public string IpAddress {
    get => _IpAddress;
    set {
      _IpAddress = value;
      if (_currentObj != null) {
        _currentObj.SetIpAddress(value);
      }
    }
  }

  [SerializeField]
  private System.Collections.Generic.List<UnityEngine.Color32> _OverlayLightColors = new System.Collections.Generic.List<UnityEngine.Color32>{new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}};

  public System.Collections.Generic.List<UnityEngine.Color32> OverlayLightColors {
    get => _OverlayLightColors;
    set {
      _OverlayLightColors = value;
      if (_currentObj != null) {
        _currentObj.SetOverlayLightColors(value);
      }
    }
  }

  [SerializeField]
  private float _OverlayRotationSpeed = 0f;

  public float OverlayRotationSpeed {
    get => _OverlayRotationSpeed;
    set {
      _OverlayRotationSpeed = value;
      if (_currentObj != null) {
        _currentObj.SetOverlayRotationSpeed(value);
      }
    }
  }

  private XrpaDataflow.MoodLighting _currentObj;

  void OnValidate() {
    if (_currentObj != null) {
      if (!_currentObj.GetBaseLightColors().Equals(_BaseLightColors)) {
        _currentObj.SetBaseLightColors(_BaseLightColors);
      }
      if (!_currentObj.GetIpAddress().Equals(_IpAddress)) {
        _currentObj.SetIpAddress(_IpAddress);
      }
      if (!_currentObj.GetOverlayLightColors().Equals(_OverlayLightColors)) {
        _currentObj.SetOverlayLightColors(_OverlayLightColors);
      }
      if (!_currentObj.GetOverlayRotationSpeed().Equals(_OverlayRotationSpeed)) {
        _currentObj.SetOverlayRotationSpeed(_OverlayRotationSpeed);
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
    _currentObj = new XrpaDataflow.MoodLighting(SmartControllerDataStoreSubsystem.Instance.DataStore);
    _currentObj.SetBaseLightColors(BaseLightColors);
    _currentObj.SetIpAddress(IpAddress);
    _currentObj.SetOverlayLightColors(OverlayLightColors);
    _currentObj.SetOverlayRotationSpeed(OverlayRotationSpeed);
  }

  public void Stop() {
    if (_currentObj != null) {
      _currentObj.Terminate();
    }
    _currentObj = null;
  }

  public XrpaDataflow.MoodLighting Spawn() {
    var ret = new XrpaDataflow.MoodLighting(SmartControllerDataStoreSubsystem.Instance.DataStore);
    ret.SetBaseLightColors(BaseLightColors);
    ret.SetIpAddress(IpAddress);
    ret.SetOverlayLightColors(OverlayLightColors);
    ret.SetOverlayRotationSpeed(OverlayRotationSpeed);
    return ret;
  }
}
