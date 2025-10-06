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
public class TextToSpeechTransportSubsystem : MonoBehaviour {
  private static TextToSpeechTransportSubsystem _Instance;

  public static TextToSpeechTransportSubsystem MaybeInstance { get => _Instance; }

  public static TextToSpeechTransportSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindAnyObjectByType<TextToSpeechTransportSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(TextToSpeechTransportSubsystem).Name };
        _Instance = obj.AddComponent<TextToSpeechTransportSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      {
        var localTextToSpeechInboundTransport = new Xrpa.SharedMemoryTransportStream("TextToSpeechOutput", TextToSpeechDataStore.TextToSpeechDataStoreConfig.GenTransportConfig());
        TextToSpeechInboundTransport = localTextToSpeechInboundTransport;

        var localTextToSpeechOutboundTransport = new Xrpa.SharedMemoryTransportStream("TextToSpeechInput", TextToSpeechDataStore.TextToSpeechDataStoreConfig.GenTransportConfig());
        TextToSpeechOutboundTransport = localTextToSpeechOutboundTransport;
      }
    } else if (_Instance != this) {
      Destroy(gameObject);
    }
  }

  void OnDestroy() {
    TextToSpeechDataStoreSubsystem.MaybeInstance?.Shutdown();
    TextToSpeechOutboundTransport?.Dispose();
    TextToSpeechOutboundTransport = null;
    TextToSpeechInboundTransport?.Dispose();
    TextToSpeechInboundTransport = null;
    if (_Instance == this) {
      _Instance = null;
    }
  }

  public Xrpa.TransportStream TextToSpeechInboundTransport;
  public Xrpa.TransportStream TextToSpeechOutboundTransport;
}
