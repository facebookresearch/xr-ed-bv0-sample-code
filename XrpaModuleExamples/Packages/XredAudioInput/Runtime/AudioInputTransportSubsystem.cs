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
public class AudioInputTransportSubsystem : MonoBehaviour {
  private static AudioInputTransportSubsystem _Instance;

  public static AudioInputTransportSubsystem MaybeInstance { get => _Instance; }

  public static AudioInputTransportSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindAnyObjectByType<AudioInputTransportSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(AudioInputTransportSubsystem).Name };
        _Instance = obj.AddComponent<AudioInputTransportSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      {
        var localAudioInputInboundTransport = new Xrpa.SharedMemoryTransportStream("AudioInputOutput", AudioInputDataStore.AudioInputDataStoreConfig.GenTransportConfig());
        AudioInputInboundTransport = localAudioInputInboundTransport;

        var localAudioInputOutboundTransport = new Xrpa.SharedMemoryTransportStream("AudioInputInput", AudioInputDataStore.AudioInputDataStoreConfig.GenTransportConfig());
        AudioInputOutboundTransport = localAudioInputOutboundTransport;
      }
    } else if (_Instance != this) {
      Destroy(gameObject);
    }
  }

  void OnDestroy() {
    AudioInputDataStoreSubsystem.MaybeInstance?.Shutdown();
    AudioInputOutboundTransport?.Dispose();
    AudioInputOutboundTransport = null;
    AudioInputInboundTransport?.Dispose();
    AudioInputInboundTransport = null;
    if (_Instance == this) {
      _Instance = null;
    }
  }

  public Xrpa.TransportStream AudioInputInboundTransport;
  public Xrpa.TransportStream AudioInputOutboundTransport;
}
