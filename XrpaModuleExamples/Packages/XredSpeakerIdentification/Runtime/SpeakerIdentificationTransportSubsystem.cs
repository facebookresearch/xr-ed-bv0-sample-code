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

using UnityEngine;
using Xrpa;

[AddComponentMenu("")]
public class SpeakerIdentificationTransportSubsystem : MonoBehaviour {
  private static SpeakerIdentificationTransportSubsystem _Instance;

  public static SpeakerIdentificationTransportSubsystem MaybeInstance { get => _Instance; }

  public static SpeakerIdentificationTransportSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindAnyObjectByType<SpeakerIdentificationTransportSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(SpeakerIdentificationTransportSubsystem).Name };
        _Instance = obj.AddComponent<SpeakerIdentificationTransportSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      {
        var localSpeakerIdentificationInboundTransport = new Xrpa.SharedMemoryTransportStream("SpeakerIdentificationOutput", SpeakerIdentificationDataStore.SpeakerIdentificationDataStoreConfig.GenTransportConfig());
        SpeakerIdentificationInboundTransport = localSpeakerIdentificationInboundTransport;

        var localSpeakerIdentificationOutboundTransport = new Xrpa.SharedMemoryTransportStream("SpeakerIdentificationInput", SpeakerIdentificationDataStore.SpeakerIdentificationDataStoreConfig.GenTransportConfig());
        SpeakerIdentificationOutboundTransport = localSpeakerIdentificationOutboundTransport;
      }
    } else if (_Instance != this) {
      Destroy(gameObject);
    }
  }

  void OnDestroy() {
    SpeakerIdentificationDataStoreSubsystem.MaybeInstance?.Shutdown();
    SpeakerIdentificationOutboundTransport?.Dispose();
    SpeakerIdentificationOutboundTransport = null;
    SpeakerIdentificationInboundTransport?.Dispose();
    SpeakerIdentificationInboundTransport = null;
    if (_Instance == this) {
      _Instance = null;
    }
  }

  public Xrpa.TransportStream SpeakerIdentificationInboundTransport;
  public Xrpa.TransportStream SpeakerIdentificationOutboundTransport;
}
