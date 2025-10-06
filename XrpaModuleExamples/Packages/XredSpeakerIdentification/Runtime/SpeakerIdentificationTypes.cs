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

using System.Runtime.InteropServices;
using Xrpa;

namespace SpeakerIdentificationDataStore {

public class SpeakerIdentificationDataStoreConfig {
  public static Xrpa.TransportConfig GenTransportConfig() {
    Xrpa.TransportConfig config = new();
    config.SchemaHash = new Xrpa.HashValue(0x01a9ad881e446398, 0x65fd2d18ba0ed542, 0xb2a967cc3d6e0741, 0x67a0a674163a1a34);
    config.ChangelogByteCount = 96376;
    return config;
  }
}

} // namespace SpeakerIdentificationDataStore
