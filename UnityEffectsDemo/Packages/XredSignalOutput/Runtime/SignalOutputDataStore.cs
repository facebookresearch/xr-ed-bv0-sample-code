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

namespace SignalOutputDataStore {

public class InputEvent : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = -1;
  public const int DS_SIZE = 8;

  public InputEvent() {}

  public InputEvent(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public InputEventType GetType() {
    return (InputEventType)(uint)(_memAccessor.ReadUint(DSInputEvent.TypeFieldOffset));
  }

  public int GetSource() {
    return _memAccessor.ReadInt(DSInputEvent.SourceFieldOffset);
  }
}

public class InputEventWrite : InputEvent {
  public InputEventWrite() {}

  public InputEventWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetType(InputEventType value) {
    _memAccessor.WriteUint((uint)(value), DSInputEvent.TypeFieldOffset);
  }

  public void SetSource(int value) {
    _memAccessor.WriteInt(value, DSInputEvent.SourceFieldOffset);
  }
}

public class SignalOutputDevice : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 0;
  public const int DS_SIZE = 296;

  public SignalOutputDevice() {}

  public SignalOutputDevice(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public string GetName() {
    return _memAccessor.ReadString(DSSignalOutputDevice.NameFieldOffset, 64);
  }

  public string GetChannelName() {
    return _memAccessor.ReadString(DSSignalOutputDevice.ChannelNameFieldOffset, 64);
  }

  public string GetDriverIdentifier() {
    return _memAccessor.ReadString(DSSignalOutputDevice.DriverIdentifierFieldOffset, 64);
  }

  public string GetDriverPort() {
    return _memAccessor.ReadString(DSSignalOutputDevice.DriverPortFieldOffset, 64);
  }

  public DeviceHandedness GetHandedness() {
    return (DeviceHandedness)(uint)(_memAccessor.ReadUint(DSSignalOutputDevice.HandednessFieldOffset));
  }

  public int GetNumChannels() {
    return _memAccessor.ReadInt(DSSignalOutputDevice.NumChannelsFieldOffset);
  }

  public SampleType GetSampleType() {
    return (SampleType)(uint)(_memAccessor.ReadUint(DSSignalOutputDevice.SampleTypeFieldOffset));
  }

  public SampleSemantics GetSampleSemantics() {
    return (SampleSemantics)(uint)(_memAccessor.ReadUint(DSSignalOutputDevice.SampleSemanticsFieldOffset));
  }

  public int GetBytesPerSample() {
    return _memAccessor.ReadInt(DSSignalOutputDevice.BytesPerSampleFieldOffset);
  }

  public int GetSamplesPerChannelPerSec() {
    return _memAccessor.ReadInt(DSSignalOutputDevice.SamplesPerChannelPerSecFieldOffset);
  }

  public bool CheckNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.NameChangedBit) != 0;
  }

  public bool CheckChannelNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.ChannelNameChangedBit) != 0;
  }

  public bool CheckDriverIdentifierChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.DriverIdentifierChangedBit) != 0;
  }

  public bool CheckDriverPortChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.DriverPortChangedBit) != 0;
  }

  public bool CheckHandednessChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.HandednessChangedBit) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.NumChannelsChangedBit) != 0;
  }

  public bool CheckSampleTypeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.SampleTypeChangedBit) != 0;
  }

  public bool CheckSampleSemanticsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.SampleSemanticsChangedBit) != 0;
  }

  public bool CheckBytesPerSampleChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.BytesPerSampleChangedBit) != 0;
  }

  public bool CheckSamplesPerChannelPerSecChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.SamplesPerChannelPerSecChangedBit) != 0;
  }
}

public class SignalOutputDeviceWrite : SignalOutputDevice {
  public SignalOutputDeviceWrite() {}

  public SignalOutputDeviceWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetName(string value) {
    _memAccessor.WriteString(value, DSSignalOutputDevice.NameFieldOffset, 64);
  }

  public void SetChannelName(string value) {
    _memAccessor.WriteString(value, DSSignalOutputDevice.ChannelNameFieldOffset, 64);
  }

  public void SetDriverIdentifier(string value) {
    _memAccessor.WriteString(value, DSSignalOutputDevice.DriverIdentifierFieldOffset, 64);
  }

  public void SetDriverPort(string value) {
    _memAccessor.WriteString(value, DSSignalOutputDevice.DriverPortFieldOffset, 64);
  }

  public void SetHandedness(DeviceHandedness value) {
    _memAccessor.WriteUint((uint)(value), DSSignalOutputDevice.HandednessFieldOffset);
  }

  public void SetNumChannels(int value) {
    _memAccessor.WriteInt(value, DSSignalOutputDevice.NumChannelsFieldOffset);
  }

  public void SetSampleType(SampleType value) {
    _memAccessor.WriteUint((uint)(value), DSSignalOutputDevice.SampleTypeFieldOffset);
  }

  public void SetSampleSemantics(SampleSemantics value) {
    _memAccessor.WriteUint((uint)(value), DSSignalOutputDevice.SampleSemanticsFieldOffset);
  }

  public void SetBytesPerSample(int value) {
    _memAccessor.WriteInt(value, DSSignalOutputDevice.BytesPerSampleFieldOffset);
  }

  public void SetSamplesPerChannelPerSec(int value) {
    _memAccessor.WriteInt(value, DSSignalOutputDevice.SamplesPerChannelPerSecFieldOffset);
  }
}

public class SignalOutputSource : Xrpa.ObjectAccessorInterface {
  public const int DS_TYPE = 1;
  public const int DS_SIZE = 16;

  public SignalOutputSource() {}

  public SignalOutputSource(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public override int GetDSType() {
    return DS_TYPE;
  }

  public override int GetByteCount() {
    return DS_SIZE;
  }

  public ReconciledSignalOutputDevice GetDevice(SignalOutputDataStore datastore) {
    datastore.GetObjectByID(Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputSource.DeviceFieldOffset), out ReconciledSignalOutputDevice ReconciledSignalOutputDeviceVal);
    if (ReconciledSignalOutputDeviceVal != null) {
      return ReconciledSignalOutputDeviceVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetDeviceId() {
    return Xrpa.DSIdentifier.ReadValue(_memAccessor, DSSignalOutputSource.DeviceFieldOffset);
  }

  public bool CheckDeviceChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputSource.DeviceChangedBit) != 0;
  }
}

public class SignalOutputSourceWrite : SignalOutputSource {
  public SignalOutputSourceWrite() {}

  public SignalOutputSourceWrite(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetDevice(Xrpa.DSIdentifier value) {
    Xrpa.DSIdentifier.WriteValue(value, _memAccessor, DSSignalOutputSource.DeviceFieldOffset);
  }
}

// Reconciled Types
public class OutboundSignalOutputSource : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<SignalOutputSource> {
  protected Xrpa.DSIdentifier _localDevice = new Xrpa.DSIdentifier{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 1;

  public OutboundSignalOutputSource(Xrpa.DSIdentifier id) : base(id, null) {
    _createTimestamp = Xrpa.DatasetAccessor.GetCurrentClockTimeMicroseconds();
  }

  public ReconciledSignalOutputDevice GetDevice(SignalOutputDataStore datastore) {
    datastore.GetObjectByID(_localDevice, out ReconciledSignalOutputDevice ReconciledSignalOutputDeviceVal);
    if (ReconciledSignalOutputDeviceVal != null) {
      return ReconciledSignalOutputDeviceVal;
    }
    return null;
  }

  public Xrpa.DSIdentifier GetDeviceId() {
    return _localDevice;
  }

  public void SetDevice(ReconciledSignalOutputDevice device) {
    _localDevice = device?.GetXrpaId() ?? new Xrpa.DSIdentifier();
    if (_collection != null && (_changeBits & DSSignalOutputSource.DeviceChangedBit) == 0) {
      _changeBits |= DSSignalOutputSource.DeviceChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOutputSource.DeviceChangedBit);
    }
  }

  public void SetDeviceId(Xrpa.DSIdentifier device) {
    _localDevice = device;
    if (_collection != null && (_changeBits & DSSignalOutputSource.DeviceChangedBit) == 0) {
      _changeBits |= DSSignalOutputSource.DeviceChangedBit;
      _collection.SetDirty(GetXrpaId(), DSSignalOutputSource.DeviceChangedBit);
    }
  }

  public void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
    SignalOutputSourceWrite objAccessor = new();
    if (_createTimestamp != 0) {
      objAccessor = accessor.CreateObject<SignalOutputSourceWrite>(GetXrpaId(), _createTimestamp);
      _createTimestamp = 0;
    } else if (_changeBits != 0) {
      objAccessor = accessor.UpdateObject<SignalOutputSourceWrite>(GetXrpaId(), _changeBits);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & DSSignalOutputSource.DeviceChangedBit) != 0) {
      objAccessor.SetDevice(_localDevice);
    }
    _changeBits = 0;
  }

  public void ProcessDSUpdate(SignalOutputSource value, ulong fieldsChanged) {
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class ReconciledSignalOutputDevice : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<SignalOutputDevice> {
  private string _localName = "";
  private string _localChannelName = "";
  private string _localDriverIdentifier = "";
  private string _localDriverPort = "";
  private DeviceHandedness _localHandedness = DeviceHandedness.None;
  private int _localNumChannels = 0;
  private SampleType _localSampleType = SampleType.Float;
  private SampleSemantics _localSampleSemantics = SampleSemantics.PCM;
  private int _localBytesPerSample = 0;
  private int _localSamplesPerChannelPerSec = 0;
  private System.Action<int, InputEvent> _inputEventMessageHandler = null;

  public ReconciledSignalOutputDevice(Xrpa.DSIdentifier id, Xrpa.CollectionInterface collection) : base(id, collection) {}

  public virtual void ProcessDSUpdate(SignalOutputDevice value, ulong fieldsChanged) {
    if (value.CheckNameChanged(fieldsChanged)) {
      _localName = value.GetName();
    }
    if (value.CheckChannelNameChanged(fieldsChanged)) {
      _localChannelName = value.GetChannelName();
    }
    if (value.CheckDriverIdentifierChanged(fieldsChanged)) {
      _localDriverIdentifier = value.GetDriverIdentifier();
    }
    if (value.CheckDriverPortChanged(fieldsChanged)) {
      _localDriverPort = value.GetDriverPort();
    }
    if (value.CheckHandednessChanged(fieldsChanged)) {
      _localHandedness = value.GetHandedness();
    }
    if (value.CheckNumChannelsChanged(fieldsChanged)) {
      _localNumChannels = value.GetNumChannels();
    }
    if (value.CheckSampleTypeChanged(fieldsChanged)) {
      _localSampleType = value.GetSampleType();
    }
    if (value.CheckSampleSemanticsChanged(fieldsChanged)) {
      _localSampleSemantics = value.GetSampleSemantics();
    }
    if (value.CheckBytesPerSampleChanged(fieldsChanged)) {
      _localBytesPerSample = value.GetBytesPerSample();
    }
    if (value.CheckSamplesPerChannelPerSecChanged(fieldsChanged)) {
      _localSamplesPerChannelPerSec = value.GetSamplesPerChannelPerSec();
    }
  }

  public static ReconciledSignalOutputDevice Create(Xrpa.DSIdentifier id, SignalOutputDevice obj, Xrpa.CollectionInterface collection) {
    return new ReconciledSignalOutputDevice(id, collection);
  }

  public string GetName() {
    return _localName;
  }

  public string GetChannelName() {
    return _localChannelName;
  }

  public string GetDriverIdentifier() {
    return _localDriverIdentifier;
  }

  public string GetDriverPort() {
    return _localDriverPort;
  }

  public DeviceHandedness GetHandedness() {
    return _localHandedness;
  }

  public int GetNumChannels() {
    return _localNumChannels;
  }

  public SampleType GetSampleType() {
    return _localSampleType;
  }

  public SampleSemantics GetSampleSemantics() {
    return _localSampleSemantics;
  }

  public int GetBytesPerSample() {
    return _localBytesPerSample;
  }

  public int GetSamplesPerChannelPerSec() {
    return _localSamplesPerChannelPerSec;
  }

  public bool CheckNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.NameChangedBit) != 0;
  }

  public bool CheckChannelNameChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.ChannelNameChangedBit) != 0;
  }

  public bool CheckDriverIdentifierChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.DriverIdentifierChangedBit) != 0;
  }

  public bool CheckDriverPortChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.DriverPortChangedBit) != 0;
  }

  public bool CheckHandednessChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.HandednessChangedBit) != 0;
  }

  public bool CheckNumChannelsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.NumChannelsChangedBit) != 0;
  }

  public bool CheckSampleTypeChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.SampleTypeChangedBit) != 0;
  }

  public bool CheckSampleSemanticsChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.SampleSemanticsChangedBit) != 0;
  }

  public bool CheckBytesPerSampleChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.BytesPerSampleChangedBit) != 0;
  }

  public bool CheckSamplesPerChannelPerSecChanged(ulong fieldsChanged) {
    return (fieldsChanged & DSSignalOutputDevice.SamplesPerChannelPerSecChangedBit) != 0;
  }

  public virtual void ProcessDSDelete() {
  }

  public void OnInputEvent(System.Action<int, InputEvent> handler) {
    _inputEventMessageHandler = handler;
  }

  public void ProcessDSMessage(int messageType, int timestamp, Xrpa.MemoryAccessor messageData) {
    if (messageType == 10 && _inputEventMessageHandler != null) {
      InputEvent message = new(messageData);
      _inputEventMessageHandler(timestamp, message);
    }
  }

  public virtual void WriteDSChanges(Xrpa.DatasetAccessor accessor) {
  }
}

// Object Collections
public class InboundSignalOutputDeviceCollection : Xrpa.ObjectCollection<SignalOutputDevice, ReconciledSignalOutputDevice> {
  private Xrpa.ObjectCollectionIndexedBinding<SignalOutputDevice, ReconciledSignalOutputDevice, string, SignalOutputDeviceComponent> _bindingSignalOutputDeviceComponentToName = new(1023);

  public InboundSignalOutputDeviceCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalOutputDevice.DS_TYPE, 1023, 1023, false) {
    SetCreateDelegateInternal(ReconciledSignalOutputDevice.Create);
  }

  public void AddNameBinding(string indexValue, SignalOutputDeviceComponent localObj) {
    _bindingSignalOutputDeviceComponentToName.AddLocalObject(indexValue, localObj);
  }

  public void RemoveNameBinding(string indexValue, SignalOutputDeviceComponent localObj) {
    _bindingSignalOutputDeviceComponentToName.RemoveLocalObject(indexValue, localObj);
  }

  protected override void BindingTick() {
    _bindingSignalOutputDeviceComponentToName.Tick();
  }

  protected override void BindingWriteChanges(Xrpa.DSIdentifier id) {
    _bindingSignalOutputDeviceComponentToName.WriteChanges(id);
  }

  protected override void BindingProcessMessage(Xrpa.DSIdentifier id, int messageType, int timestamp, Xrpa.MemoryAccessor msgAccessor) {
    _bindingSignalOutputDeviceComponentToName.ProcessMessage(id, messageType, timestamp, msgAccessor);
  }

  protected override void IndexNotifyCreate(ReconciledSignalOutputDevice obj) {
    _bindingSignalOutputDeviceComponentToName.OnCreate(obj, obj.GetName());
  }

  protected override void IndexNotifyUpdate(ReconciledSignalOutputDevice obj, ulong fieldsChanged) {
    if ((fieldsChanged & 1) != 0) {
      _bindingSignalOutputDeviceComponentToName.OnUpdate(obj, obj.GetName());
    }
    _bindingSignalOutputDeviceComponentToName.ProcessUpdate(obj.GetXrpaId(), fieldsChanged);
  }

  protected override void IndexNotifyDelete(ReconciledSignalOutputDevice obj) {
    _bindingSignalOutputDeviceComponentToName.OnDelete(obj, obj.GetName());
  }
}

public class OutboundSignalOutputSourceCollection : Xrpa.ObjectCollection<SignalOutputSource, OutboundSignalOutputSource> {
  public OutboundSignalOutputSourceCollection(Xrpa.DatasetReconciler reconciler) : base(reconciler, SignalOutputSource.DS_TYPE, 0, 0, true) {}

  public void AddObject(OutboundSignalOutputSource obj) {
    AddObjectInternal(obj);
  }

  public void RemoveObject(Xrpa.DSIdentifier id) {
    RemoveObjectInternal(id);
  }
}

// Data Store Implementation
public class SignalOutputDataStore : Xrpa.DatasetReconciler {
  public SignalOutputDataStore(Xrpa.DatasetInterface dataset)
      : base(dataset, SignalOutputDataStoreConfig.SIGNALOUTPUT_SCHEMA_HASH, 9979904) {
    SignalOutputDeviceIn = new InboundSignalOutputDeviceCollection(this);
    RegisterCollection(SignalOutputDeviceIn);
    SignalOutputSourceOut = new OutboundSignalOutputSourceCollection(this);
    RegisterCollection(SignalOutputSourceOut);
  }

  public InboundSignalOutputDeviceCollection SignalOutputDeviceIn;
  public OutboundSignalOutputSourceCollection SignalOutputSourceOut;

  public void GetObjectByID(Xrpa.DSIdentifier id, out ReconciledSignalOutputDevice obj) {
    obj = SignalOutputDeviceIn.GetObject(id);
  }

  public void GetObjectByID(Xrpa.DSIdentifier id, out OutboundSignalOutputSource obj) {
    obj = SignalOutputSourceOut.GetObject(id);
  }
}

} // namespace SignalOutputDataStore
