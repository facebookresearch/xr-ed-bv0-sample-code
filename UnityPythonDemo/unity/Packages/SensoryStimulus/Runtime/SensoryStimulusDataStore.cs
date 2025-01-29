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

using Xrpa;

namespace SensoryStimulusDataStore {

public class StimulusReader : Xrpa.ObjectAccessorInterface {
  public StimulusReader() {}

  public StimulusReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public Pose GetPose() {
    return DSPose.ReadValue(_memAccessor, AdvanceReadPos(28));
  }

  public float GetVisualDelay() {
    return DSScalar.ReadValue(_memAccessor, AdvanceReadPos(4));
  }

  public float GetAudioDelay() {
    return DSScalar.ReadValue(_memAccessor, AdvanceReadPos(4));
  }

  public bool CheckPoseChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckVisualDelayChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckAudioDelayChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }
}

public class StimulusWriter : StimulusReader {
  public StimulusWriter() {}

  public StimulusWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static StimulusWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new StimulusWriter(changeEvent.AccessChangeData());
  }

  public static StimulusWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new StimulusWriter(changeEvent.AccessChangeData());
  }

  public void SetPose(Pose value) {
    DSPose.WriteValue(value, _memAccessor, AdvanceWritePos(28));
  }

  public void SetVisualDelay(float value) {
    DSScalar.WriteValue(value, _memAccessor, AdvanceWritePos(4));
  }

  public void SetAudioDelay(float value) {
    DSScalar.WriteValue(value, _memAccessor, AdvanceWritePos(4));
  }
}

// Reconciled Types

// Object Collections
public class InboundStimulusReaderCollection : Xrpa.ObjectCollection<StimulusReader, StimulusComponent> {
  public InboundStimulusReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 0, 7, 0, false) {}

  public void SetCreateDelegate(CreateDelegateFunction createDelegate) {
    SetCreateDelegateInternal(createDelegate);
  }
}

// Data Store Implementation
public class SensoryStimulusDataStore : Xrpa.DataStoreReconciler {
  public SensoryStimulusDataStore(Xrpa.TransportStream inboundTransport, Xrpa.TransportStream outboundTransport)
      : base(inboundTransport, outboundTransport, 57344) {
    Stimulus = new InboundStimulusReaderCollection(this);
    RegisterCollection(Stimulus);
  }

  public InboundStimulusReaderCollection Stimulus;
}

} // namespace SensoryStimulusDataStore
