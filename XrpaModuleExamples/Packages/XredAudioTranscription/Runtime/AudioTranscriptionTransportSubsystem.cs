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
public class AudioTranscriptionTransportSubsystem : MonoBehaviour {
  private static AudioTranscriptionTransportSubsystem _Instance;

  public static AudioTranscriptionTransportSubsystem MaybeInstance { get => _Instance; }

  public static AudioTranscriptionTransportSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindAnyObjectByType<AudioTranscriptionTransportSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(AudioTranscriptionTransportSubsystem).Name };
        _Instance = obj.AddComponent<AudioTranscriptionTransportSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      {
        var localAudioTranscriptionInboundTransport = new Xrpa.SharedMemoryTransportStream("AudioTranscriptionOutput", AudioTranscriptionDataStore.AudioTranscriptionDataStoreConfig.GenTransportConfig());
        AudioTranscriptionInboundTransport = localAudioTranscriptionInboundTransport;

        var localAudioTranscriptionOutboundTransport = new Xrpa.SharedMemoryTransportStream("AudioTranscriptionInput", AudioTranscriptionDataStore.AudioTranscriptionDataStoreConfig.GenTransportConfig());
        AudioTranscriptionOutboundTransport = localAudioTranscriptionOutboundTransport;
      }
    } else if (_Instance != this) {
      Destroy(gameObject);
    }
  }

  void OnDestroy() {
    AudioTranscriptionDataStoreSubsystem.MaybeInstance?.Shutdown();
    AudioTranscriptionOutboundTransport?.Dispose();
    AudioTranscriptionOutboundTransport = null;
    AudioTranscriptionInboundTransport?.Dispose();
    AudioTranscriptionInboundTransport = null;
    if (_Instance == this) {
      _Instance = null;
    }
  }

  public Xrpa.TransportStream AudioTranscriptionInboundTransport;
  public Xrpa.TransportStream AudioTranscriptionOutboundTransport;
}
