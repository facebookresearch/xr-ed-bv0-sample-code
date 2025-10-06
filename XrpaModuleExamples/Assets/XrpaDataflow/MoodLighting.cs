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

using SmartControllerDataStore;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace XrpaDataflow {

public class MoodLighting : IDisposable {
  private SmartControllerDataStore.SmartControllerDataStore _datastoreSmartController;
  private System.Collections.Generic.List<UnityEngine.Color32> _paramBaseLightColors = new System.Collections.Generic.List<UnityEngine.Color32>{new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}};
  private string _paramIpAddress = "";
  private System.Collections.Generic.List<UnityEngine.Color32> _paramOverlayLightColors = new System.Collections.Generic.List<UnityEngine.Color32>{new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}, new UnityEngine.Color32{r = 255, g = 255, b = 255, a = 255}};
  private float _paramOverlayRotationSpeed = 0f;
  private SmartControllerDataStore.OutboundLightControl _objSmartControllerLightControl0;
  private SmartControllerDataStore.OutboundLightControl _objSmartControllerLightControl1;

  public MoodLighting(SmartControllerDataStore.SmartControllerDataStore datastoreSmartController) {
    _datastoreSmartController = datastoreSmartController;
    CreateObjects();
  }

  public void Dispose() {
    Dispose(true);
    GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    DestroyObjects();
  }

  ~MoodLighting() {
    Dispose(false);
  }

  public System.Collections.Generic.List<UnityEngine.Color32> GetBaseLightColors() {
    return _paramBaseLightColors;
  }

  public void SetBaseLightColors(System.Collections.Generic.List<UnityEngine.Color32> baseLightColors) {
    _paramBaseLightColors = baseLightColors;
    if (_objSmartControllerLightControl0 != null) {
      _objSmartControllerLightControl0.SetLightColors(baseLightColors);
    }
  }

  public string GetIpAddress() {
    return _paramIpAddress;
  }

  public void SetIpAddress(string ipAddress) {
    _paramIpAddress = ipAddress;
    if (_objSmartControllerLightControl0 != null) {
      _objSmartControllerLightControl0.SetIpAddress(ipAddress);
    }
    if (_objSmartControllerLightControl1 != null) {
      _objSmartControllerLightControl1.SetIpAddress(ipAddress);
    }
  }

  public System.Collections.Generic.List<UnityEngine.Color32> GetOverlayLightColors() {
    return _paramOverlayLightColors;
  }

  public void SetOverlayLightColors(System.Collections.Generic.List<UnityEngine.Color32> overlayLightColors) {
    _paramOverlayLightColors = overlayLightColors;
    if (_objSmartControllerLightControl1 != null) {
      _objSmartControllerLightControl1.SetLightColors(overlayLightColors);
    }
  }

  public float GetOverlayRotationSpeed() {
    return _paramOverlayRotationSpeed;
  }

  public void SetOverlayRotationSpeed(float overlayRotationSpeed) {
    _paramOverlayRotationSpeed = overlayRotationSpeed;
    if (_objSmartControllerLightControl1 != null) {
      _objSmartControllerLightControl1.SetRotationSpeed(overlayRotationSpeed);
    }
  }

  void CreateObjects() {
    _objSmartControllerLightControl0 = _datastoreSmartController.LightControl.CreateObject();
    _objSmartControllerLightControl1 = _datastoreSmartController.LightControl.CreateObject();
    _objSmartControllerLightControl0.SetIpAddress(_paramIpAddress);
    _objSmartControllerLightControl0.SetLightColors(_paramBaseLightColors);
    _objSmartControllerLightControl0.SetRotationOffset(0f);
    _objSmartControllerLightControl0.SetRotationSpeed(0f);
    _objSmartControllerLightControl0.SetPriority(0);
    _objSmartControllerLightControl1.SetIpAddress(_paramIpAddress);
    _objSmartControllerLightControl1.SetLightColors(_paramOverlayLightColors);
    _objSmartControllerLightControl1.SetRotationOffset(0f);
    _objSmartControllerLightControl1.SetRotationSpeed(_paramOverlayRotationSpeed);
    _objSmartControllerLightControl1.SetPriority(1);
  }

  void DestroyObjects() {
    if (_objSmartControllerLightControl1 != null) {
      _datastoreSmartController.LightControl.RemoveObject(_objSmartControllerLightControl1.GetXrpaId());
      _objSmartControllerLightControl1 = null;
    }
    if (_objSmartControllerLightControl0 != null) {
      _datastoreSmartController.LightControl.RemoveObject(_objSmartControllerLightControl0.GetXrpaId());
      _objSmartControllerLightControl0 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace XrpaDataflow
