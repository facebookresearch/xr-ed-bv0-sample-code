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
public class OpticalCharacterRecognitionTransportSubsystem : MonoBehaviour {
  private static OpticalCharacterRecognitionTransportSubsystem _Instance;

  public static OpticalCharacterRecognitionTransportSubsystem MaybeInstance { get => _Instance; }

  public static OpticalCharacterRecognitionTransportSubsystem Instance {
    get {
      if (_Instance == null) {
        _Instance = FindAnyObjectByType<OpticalCharacterRecognitionTransportSubsystem>();
      }
      if (_Instance == null) {
        GameObject obj = new() { name = typeof(OpticalCharacterRecognitionTransportSubsystem).Name };
        _Instance = obj.AddComponent<OpticalCharacterRecognitionTransportSubsystem>();
      }
      return _Instance;
    }
  }

  void Awake() {
    if (_Instance == null) {
      _Instance = this;
      DontDestroyOnLoad(gameObject);
      {
        var localOpticalCharacterRecognitionInboundTransport = new Xrpa.SharedMemoryTransportStream("OpticalCharacterRecognitionOutput", OpticalCharacterRecognitionDataStore.OpticalCharacterRecognitionDataStoreConfig.GenTransportConfig());
        OpticalCharacterRecognitionInboundTransport = localOpticalCharacterRecognitionInboundTransport;

        var localOpticalCharacterRecognitionOutboundTransport = new Xrpa.SharedMemoryTransportStream("OpticalCharacterRecognitionInput", OpticalCharacterRecognitionDataStore.OpticalCharacterRecognitionDataStoreConfig.GenTransportConfig());
        OpticalCharacterRecognitionOutboundTransport = localOpticalCharacterRecognitionOutboundTransport;
      }
    } else if (_Instance != this) {
      Destroy(gameObject);
    }
  }

  void OnDestroy() {
    OpticalCharacterRecognitionDataStoreSubsystem.MaybeInstance?.Shutdown();
    OpticalCharacterRecognitionOutboundTransport?.Dispose();
    OpticalCharacterRecognitionOutboundTransport = null;
    OpticalCharacterRecognitionInboundTransport?.Dispose();
    OpticalCharacterRecognitionInboundTransport = null;
    if (_Instance == this) {
      _Instance = null;
    }
  }

  public Xrpa.TransportStream OpticalCharacterRecognitionInboundTransport;
  public Xrpa.TransportStream OpticalCharacterRecognitionOutboundTransport;
}
