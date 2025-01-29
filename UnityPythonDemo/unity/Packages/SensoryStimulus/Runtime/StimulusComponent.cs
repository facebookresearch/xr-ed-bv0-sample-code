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

using SensoryStimulusDataStore;
using UnityEngine;
using Xrpa;

[AddComponentMenu("")]
public class StimulusComponent : MonoBehaviour, Xrpa.IDataStoreObjectAccessor<SensoryStimulusDataStore.StimulusReader> {
  private SensoryStimulusDataStore.Pose _Pose = new SensoryStimulusDataStore.Pose{position = new UnityEngine.Vector3{x = 0f, y = 0f, z = 0f}, orientation = new UnityEngine.Quaternion{x = 0f, y = 0f, z = 0f, w = 1f}};

  public SensoryStimulusDataStore.Pose Pose {
    get => _Pose;
  }

  private float _VisualDelay = 1f;

  public float VisualDelay {
    get => _VisualDelay;
  }

  private float _AudioDelay = 1f;

  public float AudioDelay {
    get => _AudioDelay;
  }

  protected Xrpa.ObjectUuid _id = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected bool _hasNotifiedNeedsWrite = false;
  protected Xrpa.IObjectCollection _collection;
  private ulong _changeBits = 0;
  private int _changeByteCount = 0;
  protected bool _dsIsInitialized = false;

  void Start() {
    InitializeDS();
  }

  void OnDestroy() {
    DeinitializeDS();
  }

  public void SetXrpaId(Xrpa.ObjectUuid id) {
    _id = id;
  }

  public Xrpa.ObjectUuid GetXrpaId() {
    return _id;
  }

  public void SetXrpaCollection(Xrpa.IObjectCollection collection) {
    if (collection == null && _collection != null && !_hasNotifiedNeedsWrite) {
      // object removed from collection
      _collection.NotifyObjectNeedsWrite(_id);
      _hasNotifiedNeedsWrite = true;
    }

    _collection = collection;

    if (_collection != null && !_hasNotifiedNeedsWrite) {
      // object added to collection
      _collection.NotifyObjectNeedsWrite(_id);
      _hasNotifiedNeedsWrite = true;
    }
  }

  public int GetCollectionId() {
    return _collection == null ? -1 : _collection.GetId();
  }

  public void ProcessDSDelete() {
    Destroy(gameObject);
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
  }

  public void ProcessDSUpdate(SensoryStimulusDataStore.StimulusReader value, ulong fieldsChanged) {
    if (value.CheckPoseChanged(fieldsChanged)) {
      _Pose = value.GetPose();
      transform.localPosition = Pose.position;
      transform.localRotation = Pose.orientation;
    }
    if (value.CheckVisualDelayChanged(fieldsChanged)) {
      _VisualDelay = value.GetVisualDelay();
    }
    if (value.CheckAudioDelayChanged(fieldsChanged)) {
      _AudioDelay = value.GetAudioDelay();
    }
  }

  public void SendUserResponse() {
    _collection.SendMessage(
        GetXrpaId(),
        3,
        0);
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }

  public void InitializeDS() {
    if (_dsIsInitialized) {
      return;
    }
    _dsIsInitialized = true;
    _changeBits = 0;
    _hasNotifiedNeedsWrite = false;

    _VisualDelay = 1f;
    _AudioDelay = 1f;
  }

  void DeinitializeDS() {
    if (!_dsIsInitialized) {
      return;
    }
    _dsIsInitialized = false;
  }
}
