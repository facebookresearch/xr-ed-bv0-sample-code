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

using System;
using Xrpa;

namespace LlmHubDataStore {

public class McpServerSetReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public McpServerSetReader() {}

  public McpServerSetReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }
}

public class McpServerSetWriter : McpServerSetReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public McpServerSetWriter() {}

  public McpServerSetWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static McpServerSetWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new McpServerSetWriter(changeEvent.AccessChangeData());
  }

  public static McpServerSetWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new McpServerSetWriter(changeEvent.AccessChangeData());
  }
}

public class McpServerConfigReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public McpServerConfigReader() {}

  public McpServerConfigReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  // URL of the MCP server
  public string GetUrl() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Authentication token for the MCP server
  public string GetAuthToken() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Reference back to the server set this config belongs to
  public Xrpa.ObjectUuid GetServerSet() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckUrlChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckAuthTokenChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckServerSetChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }
}

public class McpServerConfigWriter : McpServerConfigReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public McpServerConfigWriter() {}

  public McpServerConfigWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static McpServerConfigWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new McpServerConfigWriter(changeEvent.AccessChangeData());
  }

  public static McpServerConfigWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new McpServerConfigWriter(changeEvent.AccessChangeData());
  }

  public void SetUrl(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetAuthToken(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetServerSet(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class LlmChatMessageReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public LlmChatMessageReader() {}

  public LlmChatMessageReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public string GetData() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Optional JPEG image data.
  public byte[] GetJpegImageData() {
    return _memAccessor.ReadBytes(_readOffset);
  }

  // Optional ID. If sent with a chat message, the response will have the same ID.
  public int GetId() {
    return _memAccessor.ReadInt(_readOffset);
  }
}

public class LlmChatMessageWriter : LlmChatMessageReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public LlmChatMessageWriter() {}

  public LlmChatMessageWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetData(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetJpegImageData(byte[] value) {
    _memAccessor.WriteBytes(value, _writeOffset);
  }

  public void SetId(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }
}

public class LlmChatResponseReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public LlmChatResponseReader() {}

  public LlmChatResponseReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public string GetData() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Optional ID. If sent with a chat message, the response will have the same ID.
  public int GetId() {
    return _memAccessor.ReadInt(_readOffset);
  }
}

public class LlmChatResponseWriter : LlmChatResponseReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public LlmChatResponseWriter() {}

  public LlmChatResponseWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetData(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetId(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }
}

public class LlmQueryReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public LlmQueryReader() {}

  public LlmQueryReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public string GetApiKey() {
    return _memAccessor.ReadString(_readOffset);
  }

  public ApiProvider GetApiProvider() {
    return (ApiProvider)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public ModelSizeHint GetModelSize() {
    return (ModelSizeHint)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public string GetSysPrompt() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Controls randomness: 0.0 = deterministic, 1.0 = creative
  public float GetTemperature() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  // Maximum number of tokens to generate
  public int GetMaxTokens() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Maximum number of consecutive tool calls
  public int GetMaxConsecutiveToolCalls() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetIsProcessing() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Optional JSON schema for the response.
  public string GetJsonSchema() {
    return _memAccessor.ReadString(_readOffset);
  }

  public Xrpa.ObjectUuid GetMcpServerSet() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public string GetUserPrompt() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Optional JPEG image data.
  public byte[] GetJpegImageData() {
    return _memAccessor.ReadBytes(_readOffset);
  }

  public bool CheckApiKeyChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckApiProviderChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckModelSizeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSysPromptChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckTemperatureChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckMaxTokensChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckMaxConsecutiveToolCallsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckIsProcessingChanged(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckJsonSchemaChanged(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public bool CheckMcpServerSetChanged(ulong fieldsChanged) {
    return (fieldsChanged & 512) != 0;
  }

  public bool CheckUserPromptChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1024) != 0;
  }

  public bool CheckJpegImageDataChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2048) != 0;
  }
}

public class LlmQueryWriter : LlmQueryReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public LlmQueryWriter() {}

  public LlmQueryWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static LlmQueryWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new LlmQueryWriter(changeEvent.AccessChangeData());
  }

  public static LlmQueryWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new LlmQueryWriter(changeEvent.AccessChangeData());
  }

  public void SetApiKey(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetApiProvider(ApiProvider value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetModelSize(ModelSizeHint value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetSysPrompt(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetTemperature(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetMaxTokens(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetMaxConsecutiveToolCalls(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetIsProcessing(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetJsonSchema(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetMcpServerSet(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetUserPrompt(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetJpegImageData(byte[] value) {
    _memAccessor.WriteBytes(value, _writeOffset);
  }
}

public class RgbImageFeedReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public RgbImageFeedReader() {}

  public RgbImageFeedReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public Xrpa.Image GetImage() {
    return DSRgbImage.ReadValue(_memAccessor, _readOffset);
  }
}

public class RgbImageFeedWriter : RgbImageFeedReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public RgbImageFeedWriter() {}

  public RgbImageFeedWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public void SetImage(Xrpa.Image value) {
    DSRgbImage.WriteValue(value, _memAccessor, _writeOffset);
  }
}

public class LlmTriggeredQueryReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public LlmTriggeredQueryReader() {}

  public LlmTriggeredQueryReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public string GetApiKey() {
    return _memAccessor.ReadString(_readOffset);
  }

  public ApiProvider GetApiProvider() {
    return (ApiProvider)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public ModelSizeHint GetModelSize() {
    return (ModelSizeHint)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public string GetSysPrompt() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Controls randomness: 0.0 = deterministic, 1.0 = creative
  public float GetTemperature() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  // Maximum number of tokens to generate
  public int GetMaxTokens() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Maximum number of consecutive tool calls
  public int GetMaxConsecutiveToolCalls() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetIsProcessing() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Optional JSON schema for the response.
  public string GetJsonSchema() {
    return _memAccessor.ReadString(_readOffset);
  }

  public Xrpa.ObjectUuid GetMcpServerSet() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public string GetUserPrompt() {
    return _memAccessor.ReadString(_readOffset);
  }

  public int GetTriggerId() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public bool CheckApiKeyChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckApiProviderChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckModelSizeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSysPromptChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckTemperatureChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckMaxTokensChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckMaxConsecutiveToolCallsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckIsProcessingChanged(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckJsonSchemaChanged(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public bool CheckMcpServerSetChanged(ulong fieldsChanged) {
    return (fieldsChanged & 512) != 0;
  }

  public bool CheckUserPromptChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1024) != 0;
  }

  public bool CheckTriggerIdChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2048) != 0;
  }
}

public class LlmTriggeredQueryWriter : LlmTriggeredQueryReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public LlmTriggeredQueryWriter() {}

  public LlmTriggeredQueryWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static LlmTriggeredQueryWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new LlmTriggeredQueryWriter(changeEvent.AccessChangeData());
  }

  public static LlmTriggeredQueryWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new LlmTriggeredQueryWriter(changeEvent.AccessChangeData());
  }

  public void SetApiKey(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetApiProvider(ApiProvider value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetModelSize(ModelSizeHint value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetSysPrompt(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetTemperature(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetMaxTokens(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetMaxConsecutiveToolCalls(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetIsProcessing(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetJsonSchema(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetMcpServerSet(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetUserPrompt(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetTriggerId(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }
}

public class LlmConversationReader : Xrpa.ObjectAccessorInterface {
  private Xrpa.MemoryOffset _readOffset = new();

  public LlmConversationReader() {}

  public LlmConversationReader(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public string GetApiKey() {
    return _memAccessor.ReadString(_readOffset);
  }

  public ApiProvider GetApiProvider() {
    return (ApiProvider)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public ModelSizeHint GetModelSize() {
    return (ModelSizeHint)(uint)(_memAccessor.ReadUint(_readOffset));
  }

  public string GetSysPrompt() {
    return _memAccessor.ReadString(_readOffset);
  }

  // Controls randomness: 0.0 = deterministic, 1.0 = creative
  public float GetTemperature() {
    return DSScalar.ReadValue(_memAccessor, _readOffset);
  }

  // Maximum number of tokens to generate
  public int GetMaxTokens() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Maximum number of consecutive tool calls
  public int GetMaxConsecutiveToolCalls() {
    return _memAccessor.ReadInt(_readOffset);
  }

  public int GetIsProcessing() {
    return _memAccessor.ReadInt(_readOffset);
  }

  // Optional starter message for the conversation. Will be sent as an additional message between the system prompt and the user prompt.
  public string GetConversationStarter() {
    return _memAccessor.ReadString(_readOffset);
  }

  public Xrpa.ObjectUuid GetMcpServerSet() {
    return Xrpa.ObjectUuid.ReadValue(_memAccessor, _readOffset);
  }

  public bool CheckApiKeyChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckApiProviderChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckModelSizeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSysPromptChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckTemperatureChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckMaxTokensChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckMaxConsecutiveToolCallsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckIsProcessingChanged(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckConversationStarterChanged(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public bool CheckMcpServerSetChanged(ulong fieldsChanged) {
    return (fieldsChanged & 512) != 0;
  }
}

public class LlmConversationWriter : LlmConversationReader {
  private Xrpa.MemoryOffset _writeOffset = new();

  public LlmConversationWriter() {}

  public LlmConversationWriter(Xrpa.MemoryAccessor memAccessor) {
    SetAccessor(memAccessor);
  }

  public static LlmConversationWriter Create(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, int changeByteCount, ulong timestamp) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionChangeEventAccessor>((int)Xrpa.CollectionChangeType.CreateObject, changeByteCount, timestamp);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    return new LlmConversationWriter(changeEvent.AccessChangeData());
  }

  public static LlmConversationWriter Update(Xrpa.TransportStreamAccessor accessor, int collectionId, Xrpa.ObjectUuid id, ulong fieldsChanged, int changeByteCount) {
    var changeEvent = accessor.WriteChangeEvent<Xrpa.CollectionUpdateChangeEventAccessor>((int)Xrpa.CollectionChangeType.UpdateObject, changeByteCount);
    changeEvent.SetCollectionId(collectionId);
    changeEvent.SetObjectId(id);
    changeEvent.SetFieldsChanged(fieldsChanged);
    return new LlmConversationWriter(changeEvent.AccessChangeData());
  }

  public void SetApiKey(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetApiProvider(ApiProvider value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetModelSize(ModelSizeHint value) {
    _memAccessor.WriteUint((uint)(value), _writeOffset);
  }

  public void SetSysPrompt(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetTemperature(float value) {
    DSScalar.WriteValue(value, _memAccessor, _writeOffset);
  }

  public void SetMaxTokens(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetMaxConsecutiveToolCalls(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetIsProcessing(int value) {
    _memAccessor.WriteInt(value, _writeOffset);
  }

  public void SetConversationStarter(string value) {
    _memAccessor.WriteString(value, _writeOffset);
  }

  public void SetMcpServerSet(Xrpa.ObjectUuid value) {
    Xrpa.ObjectUuid.WriteValue(value, _memAccessor, _writeOffset);
  }
}

// Reconciled Types
public class OutboundMcpServerSet : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<McpServerSetReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundMcpServerSet(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    McpServerSetWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 0;
      _changeByteCount = 0;
      objAccessor = McpServerSetWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = McpServerSetWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 0;
    _changeByteCount = 0;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(McpServerSetReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundMcpServerConfig : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<McpServerConfigReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;

  // URL of the MCP server
  protected string _localUrl = "http://localhost:3000/mcp";

  // Authentication token for the MCP server
  protected string _localAuthToken = "";

  // Reference back to the server set this config belongs to
  protected Xrpa.ObjectUuid _localServerSet = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundMcpServerConfig(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public string GetUrl() {
    return _localUrl;
  }

  public void SetUrl(string url) {
    _localUrl = url;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localUrl);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public string GetAuthToken() {
    return _localAuthToken;
  }

  public void SetAuthToken(string authToken) {
    _localAuthToken = authToken;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localAuthToken);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public Xrpa.ObjectUuid GetServerSet() {
    return _localServerSet;
  }

  public void SetServerSet(Xrpa.ObjectUuid serverSet) {
    _localServerSet = serverSet;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    McpServerConfigWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 7;
      _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localUrl) + Xrpa.MemoryAccessor.DynSizeOfString(_localAuthToken) + 24;
      objAccessor = McpServerConfigWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = McpServerConfigWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetUrl(_localUrl);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetAuthToken(_localAuthToken);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetServerSet(_localServerSet);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 7;
    _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localUrl) + Xrpa.MemoryAccessor.DynSizeOfString(_localAuthToken) + 24;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(McpServerConfigReader value, ulong fieldsChanged) {
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public bool CheckUrlChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckAuthTokenChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckServerSetChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
  }
}

public class OutboundLlmQuery : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<LlmQueryReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  private int _localIsProcessing = 0;
  private System.Action<ulong, LlmChatResponseReader> _ResponseMessageHandler = null;
  private System.Action<ulong, LlmChatResponseReader> _ResponseStreamMessageHandler = null;
  protected string _localApiKey = "";
  protected ApiProvider _localApiProvider = ApiProvider.MetaGenProxy;
  protected ModelSizeHint _localModelSize = ModelSizeHint.Small;
  protected string _localSysPrompt = "";

  // Controls randomness: 0.0 = deterministic, 1.0 = creative
  protected float _localTemperature = 0.7f;

  // Maximum number of tokens to generate
  protected int _localMaxTokens = 256;

  // Maximum number of consecutive tool calls
  protected int _localMaxConsecutiveToolCalls = 20;

  // Optional JSON schema for the response.
  protected string _localJsonSchema = "";
  protected Xrpa.ObjectUuid _localMcpServerSet = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected string _localUserPrompt = "";

  // Optional JPEG image data.
  protected byte[] _localJpegImageData;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundLlmQuery(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public string GetApiKey() {
    return _localApiKey;
  }

  public void SetApiKey(string apiKey) {
    _localApiKey = apiKey;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localApiKey);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public ApiProvider GetApiProvider() {
    return _localApiProvider;
  }

  public void SetApiProvider(ApiProvider apiProvider) {
    _localApiProvider = apiProvider;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public ModelSizeHint GetModelSize() {
    return _localModelSize;
  }

  public void SetModelSize(ModelSizeHint modelSize) {
    _localModelSize = modelSize;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public string GetSysPrompt() {
    return _localSysPrompt;
  }

  public void SetSysPrompt(string sysPrompt) {
    _localSysPrompt = sysPrompt;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localSysPrompt);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public float GetTemperature() {
    return _localTemperature;
  }

  public void SetTemperature(float temperature) {
    _localTemperature = temperature;
    if ((_changeBits & 16) == 0) {
      _changeBits |= 16;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 16);
    }
  }

  public int GetMaxTokens() {
    return _localMaxTokens;
  }

  public void SetMaxTokens(int maxTokens) {
    _localMaxTokens = maxTokens;
    if ((_changeBits & 32) == 0) {
      _changeBits |= 32;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 32);
    }
  }

  public int GetMaxConsecutiveToolCalls() {
    return _localMaxConsecutiveToolCalls;
  }

  public void SetMaxConsecutiveToolCalls(int maxConsecutiveToolCalls) {
    _localMaxConsecutiveToolCalls = maxConsecutiveToolCalls;
    if ((_changeBits & 64) == 0) {
      _changeBits |= 64;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 64);
    }
  }

  public string GetJsonSchema() {
    return _localJsonSchema;
  }

  public void SetJsonSchema(string jsonSchema) {
    _localJsonSchema = jsonSchema;
    if ((_changeBits & 256) == 0) {
      _changeBits |= 256;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localJsonSchema);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 256);
    }
  }

  public Xrpa.ObjectUuid GetMcpServerSet() {
    return _localMcpServerSet;
  }

  public void SetMcpServerSet(Xrpa.ObjectUuid mcpServerSet) {
    _localMcpServerSet = mcpServerSet;
    if ((_changeBits & 512) == 0) {
      _changeBits |= 512;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 512);
    }
  }

  public string GetUserPrompt() {
    return _localUserPrompt;
  }

  public void SetUserPrompt(string userPrompt) {
    _localUserPrompt = userPrompt;
    if ((_changeBits & 1024) == 0) {
      _changeBits |= 1024;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localUserPrompt);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1024);
    }
  }

  public byte[] GetJpegImageData() {
    return _localJpegImageData;
  }

  public void SetJpegImageData(byte[] jpegImageData) {
    _localJpegImageData = jpegImageData;
    if ((_changeBits & 2048) == 0) {
      _changeBits |= 2048;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfBytes(_localJpegImageData);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2048);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    LlmQueryWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 3967;
      _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localApiKey) + Xrpa.MemoryAccessor.DynSizeOfString(_localSysPrompt) + Xrpa.MemoryAccessor.DynSizeOfString(_localJsonSchema) + Xrpa.MemoryAccessor.DynSizeOfString(_localUserPrompt) + Xrpa.MemoryAccessor.DynSizeOfBytes(_localJpegImageData) + 56;
      objAccessor = LlmQueryWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = LlmQueryWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetApiKey(_localApiKey);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetApiProvider(_localApiProvider);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetModelSize(_localModelSize);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetSysPrompt(_localSysPrompt);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetTemperature(_localTemperature);
    }
    if ((_changeBits & 32) != 0) {
      objAccessor.SetMaxTokens(_localMaxTokens);
    }
    if ((_changeBits & 64) != 0) {
      objAccessor.SetMaxConsecutiveToolCalls(_localMaxConsecutiveToolCalls);
    }
    if ((_changeBits & 256) != 0) {
      objAccessor.SetJsonSchema(_localJsonSchema);
    }
    if ((_changeBits & 512) != 0) {
      objAccessor.SetMcpServerSet(_localMcpServerSet);
    }
    if ((_changeBits & 1024) != 0) {
      objAccessor.SetUserPrompt(_localUserPrompt);
    }
    if ((_changeBits & 2048) != 0) {
      objAccessor.SetJpegImageData(_localJpegImageData);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 3967;
    _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localApiKey) + Xrpa.MemoryAccessor.DynSizeOfString(_localSysPrompt) + Xrpa.MemoryAccessor.DynSizeOfString(_localJsonSchema) + Xrpa.MemoryAccessor.DynSizeOfString(_localUserPrompt) + Xrpa.MemoryAccessor.DynSizeOfBytes(_localJpegImageData) + 56;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(LlmQueryReader value, ulong fieldsChanged) {
    if (value.CheckIsProcessingChanged(fieldsChanged)) {
      _localIsProcessing = value.GetIsProcessing();
    }
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public int GetIsProcessing() {
    return _localIsProcessing;
  }

  public bool CheckApiKeyChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckApiProviderChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckModelSizeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSysPromptChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckTemperatureChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckMaxTokensChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckMaxConsecutiveToolCallsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckIsProcessingChanged(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckJsonSchemaChanged(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public bool CheckMcpServerSetChanged(ulong fieldsChanged) {
    return (fieldsChanged & 512) != 0;
  }

  public bool CheckUserPromptChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1024) != 0;
  }

  public bool CheckJpegImageDataChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2048) != 0;
  }

  public void SendQuery(string data, byte[] jpegImageData, int id) {
    LlmChatMessageWriter message = new(_collection.SendMessage(
        GetXrpaId(),
        10,
        Xrpa.MemoryAccessor.DynSizeOfString(data) + Xrpa.MemoryAccessor.DynSizeOfBytes(jpegImageData) + 12));
    message.SetData(data);
    message.SetJpegImageData(jpegImageData);
    message.SetId(id);
  }

  public void OnResponse(System.Action<ulong, LlmChatResponseReader> handler) {
    _ResponseMessageHandler = handler;
  }

  public void OnResponseStream(System.Action<ulong, LlmChatResponseReader> handler) {
    _ResponseStreamMessageHandler = handler;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
    if (messageType == 13) {
      LlmChatResponseReader message = new(messageData);
      _ResponseMessageHandler?.Invoke(msgTimestamp, message);
    }
    if (messageType == 14) {
      LlmChatResponseReader message = new(messageData);
      _ResponseStreamMessageHandler?.Invoke(msgTimestamp, message);
    }
  }
}

public class OutboundLlmTriggeredQuery : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<LlmTriggeredQueryReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  private int _localIsProcessing = 0;
  private System.Action<ulong, LlmChatResponseReader> _ResponseMessageHandler = null;
  private System.Action<ulong, LlmChatResponseReader> _ResponseStreamMessageHandler = null;
  protected string _localApiKey = "";
  protected ApiProvider _localApiProvider = ApiProvider.MetaGenProxy;
  protected ModelSizeHint _localModelSize = ModelSizeHint.Small;
  protected string _localSysPrompt = "";

  // Controls randomness: 0.0 = deterministic, 1.0 = creative
  protected float _localTemperature = 0.7f;

  // Maximum number of tokens to generate
  protected int _localMaxTokens = 256;

  // Maximum number of consecutive tool calls
  protected int _localMaxConsecutiveToolCalls = 20;

  // Optional JSON schema for the response.
  protected string _localJsonSchema = "";
  protected Xrpa.ObjectUuid _localMcpServerSet = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected string _localUserPrompt = "";
  protected int _localTriggerId = 0;
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundLlmTriggeredQuery(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public string GetApiKey() {
    return _localApiKey;
  }

  public void SetApiKey(string apiKey) {
    _localApiKey = apiKey;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localApiKey);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public ApiProvider GetApiProvider() {
    return _localApiProvider;
  }

  public void SetApiProvider(ApiProvider apiProvider) {
    _localApiProvider = apiProvider;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public ModelSizeHint GetModelSize() {
    return _localModelSize;
  }

  public void SetModelSize(ModelSizeHint modelSize) {
    _localModelSize = modelSize;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public string GetSysPrompt() {
    return _localSysPrompt;
  }

  public void SetSysPrompt(string sysPrompt) {
    _localSysPrompt = sysPrompt;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localSysPrompt);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public float GetTemperature() {
    return _localTemperature;
  }

  public void SetTemperature(float temperature) {
    _localTemperature = temperature;
    if ((_changeBits & 16) == 0) {
      _changeBits |= 16;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 16);
    }
  }

  public int GetMaxTokens() {
    return _localMaxTokens;
  }

  public void SetMaxTokens(int maxTokens) {
    _localMaxTokens = maxTokens;
    if ((_changeBits & 32) == 0) {
      _changeBits |= 32;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 32);
    }
  }

  public int GetMaxConsecutiveToolCalls() {
    return _localMaxConsecutiveToolCalls;
  }

  public void SetMaxConsecutiveToolCalls(int maxConsecutiveToolCalls) {
    _localMaxConsecutiveToolCalls = maxConsecutiveToolCalls;
    if ((_changeBits & 64) == 0) {
      _changeBits |= 64;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 64);
    }
  }

  public string GetJsonSchema() {
    return _localJsonSchema;
  }

  public void SetJsonSchema(string jsonSchema) {
    _localJsonSchema = jsonSchema;
    if ((_changeBits & 256) == 0) {
      _changeBits |= 256;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localJsonSchema);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 256);
    }
  }

  public Xrpa.ObjectUuid GetMcpServerSet() {
    return _localMcpServerSet;
  }

  public void SetMcpServerSet(Xrpa.ObjectUuid mcpServerSet) {
    _localMcpServerSet = mcpServerSet;
    if ((_changeBits & 512) == 0) {
      _changeBits |= 512;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 512);
    }
  }

  public string GetUserPrompt() {
    return _localUserPrompt;
  }

  public void SetUserPrompt(string userPrompt) {
    _localUserPrompt = userPrompt;
    if ((_changeBits & 1024) == 0) {
      _changeBits |= 1024;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localUserPrompt);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1024);
    }
  }

  public int GetTriggerId() {
    return _localTriggerId;
  }

  public void SetTriggerId(int triggerId) {
    _localTriggerId = triggerId;
    if ((_changeBits & 2048) == 0) {
      _changeBits |= 2048;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2048);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    LlmTriggeredQueryWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 3967;
      _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localApiKey) + Xrpa.MemoryAccessor.DynSizeOfString(_localSysPrompt) + Xrpa.MemoryAccessor.DynSizeOfString(_localJsonSchema) + Xrpa.MemoryAccessor.DynSizeOfString(_localUserPrompt) + 56;
      objAccessor = LlmTriggeredQueryWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = LlmTriggeredQueryWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetApiKey(_localApiKey);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetApiProvider(_localApiProvider);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetModelSize(_localModelSize);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetSysPrompt(_localSysPrompt);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetTemperature(_localTemperature);
    }
    if ((_changeBits & 32) != 0) {
      objAccessor.SetMaxTokens(_localMaxTokens);
    }
    if ((_changeBits & 64) != 0) {
      objAccessor.SetMaxConsecutiveToolCalls(_localMaxConsecutiveToolCalls);
    }
    if ((_changeBits & 256) != 0) {
      objAccessor.SetJsonSchema(_localJsonSchema);
    }
    if ((_changeBits & 512) != 0) {
      objAccessor.SetMcpServerSet(_localMcpServerSet);
    }
    if ((_changeBits & 1024) != 0) {
      objAccessor.SetUserPrompt(_localUserPrompt);
    }
    if ((_changeBits & 2048) != 0) {
      objAccessor.SetTriggerId(_localTriggerId);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 3967;
    _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localApiKey) + Xrpa.MemoryAccessor.DynSizeOfString(_localSysPrompt) + Xrpa.MemoryAccessor.DynSizeOfString(_localJsonSchema) + Xrpa.MemoryAccessor.DynSizeOfString(_localUserPrompt) + 56;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(LlmTriggeredQueryReader value, ulong fieldsChanged) {
    if (value.CheckIsProcessingChanged(fieldsChanged)) {
      _localIsProcessing = value.GetIsProcessing();
    }
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public int GetIsProcessing() {
    return _localIsProcessing;
  }

  public bool CheckApiKeyChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckApiProviderChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckModelSizeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSysPromptChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckTemperatureChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckMaxTokensChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckMaxConsecutiveToolCallsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckIsProcessingChanged(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckJsonSchemaChanged(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public bool CheckMcpServerSetChanged(ulong fieldsChanged) {
    return (fieldsChanged & 512) != 0;
  }

  public bool CheckUserPromptChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1024) != 0;
  }

  public bool CheckTriggerIdChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2048) != 0;
  }

  public void SendRgbImageFeed(Xrpa.Image image) {
    RgbImageFeedWriter message = new(_collection.SendMessage(
        GetXrpaId(),
        11,
        DSRgbImage.DynSizeOfValue(image) + 48));
    message.SetImage(image);
  }

  public void OnResponse(System.Action<ulong, LlmChatResponseReader> handler) {
    _ResponseMessageHandler = handler;
  }

  public void OnResponseStream(System.Action<ulong, LlmChatResponseReader> handler) {
    _ResponseStreamMessageHandler = handler;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
    if (messageType == 13) {
      LlmChatResponseReader message = new(messageData);
      _ResponseMessageHandler?.Invoke(msgTimestamp, message);
    }
    if (messageType == 14) {
      LlmChatResponseReader message = new(messageData);
      _ResponseStreamMessageHandler?.Invoke(msgTimestamp, message);
    }
  }
}

public class OutboundLlmConversation : Xrpa.DataStoreObject, Xrpa.IDataStoreObjectAccessor<LlmConversationReader> {
  private System.Action<ulong> _xrpaFieldsChangedHandler = null;
  private int _localIsProcessing = 0;
  private System.Action<ulong, LlmChatResponseReader> _ChatResponseMessageHandler = null;
  private System.Action<ulong, LlmChatResponseReader> _ChatResponseStreamMessageHandler = null;
  protected string _localApiKey = "";
  protected ApiProvider _localApiProvider = ApiProvider.MetaGenProxy;
  protected ModelSizeHint _localModelSize = ModelSizeHint.Small;
  protected string _localSysPrompt = "";

  // Controls randomness: 0.0 = deterministic, 1.0 = creative
  protected float _localTemperature = 0.7f;

  // Maximum number of tokens to generate
  protected int _localMaxTokens = 256;

  // Maximum number of consecutive tool calls
  protected int _localMaxConsecutiveToolCalls = 20;

  // Optional starter message for the conversation. Will be sent as an additional message between the system prompt and the user prompt.
  protected string _localConversationStarter = "";
  protected Xrpa.ObjectUuid _localMcpServerSet = new Xrpa.ObjectUuid{ID0 = 0UL, ID1 = 0UL};
  protected ulong _createTimestamp;
  protected ulong _changeBits = 0;
  protected int _changeByteCount = 0;
  protected bool _createWritten = false;

  public OutboundLlmConversation(Xrpa.ObjectUuid id) : base(id, null) {
    _createTimestamp = Xrpa.TimeUtils.GetCurrentClockTimeMicroseconds();
  }

  protected virtual void HandleXrpaFieldsChanged(ulong fieldsChanged) {
    _xrpaFieldsChangedHandler?.Invoke(fieldsChanged);
  }

  public void OnXrpaFieldsChanged(System.Action<ulong> handler) {
    _xrpaFieldsChangedHandler = handler;
  }

  public string GetApiKey() {
    return _localApiKey;
  }

  public void SetApiKey(string apiKey) {
    _localApiKey = apiKey;
    if ((_changeBits & 1) == 0) {
      _changeBits |= 1;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localApiKey);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 1);
    }
  }

  public ApiProvider GetApiProvider() {
    return _localApiProvider;
  }

  public void SetApiProvider(ApiProvider apiProvider) {
    _localApiProvider = apiProvider;
    if ((_changeBits & 2) == 0) {
      _changeBits |= 2;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 2);
    }
  }

  public ModelSizeHint GetModelSize() {
    return _localModelSize;
  }

  public void SetModelSize(ModelSizeHint modelSize) {
    _localModelSize = modelSize;
    if ((_changeBits & 4) == 0) {
      _changeBits |= 4;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 4);
    }
  }

  public string GetSysPrompt() {
    return _localSysPrompt;
  }

  public void SetSysPrompt(string sysPrompt) {
    _localSysPrompt = sysPrompt;
    if ((_changeBits & 8) == 0) {
      _changeBits |= 8;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localSysPrompt);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 8);
    }
  }

  public float GetTemperature() {
    return _localTemperature;
  }

  public void SetTemperature(float temperature) {
    _localTemperature = temperature;
    if ((_changeBits & 16) == 0) {
      _changeBits |= 16;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 16);
    }
  }

  public int GetMaxTokens() {
    return _localMaxTokens;
  }

  public void SetMaxTokens(int maxTokens) {
    _localMaxTokens = maxTokens;
    if ((_changeBits & 32) == 0) {
      _changeBits |= 32;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 32);
    }
  }

  public int GetMaxConsecutiveToolCalls() {
    return _localMaxConsecutiveToolCalls;
  }

  public void SetMaxConsecutiveToolCalls(int maxConsecutiveToolCalls) {
    _localMaxConsecutiveToolCalls = maxConsecutiveToolCalls;
    if ((_changeBits & 64) == 0) {
      _changeBits |= 64;
      _changeByteCount += 4;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 64);
    }
  }

  public string GetConversationStarter() {
    return _localConversationStarter;
  }

  public void SetConversationStarter(string conversationStarter) {
    _localConversationStarter = conversationStarter;
    if ((_changeBits & 256) == 0) {
      _changeBits |= 256;
      _changeByteCount += 4;
    }
    _changeByteCount += Xrpa.MemoryAccessor.DynSizeOfString(_localConversationStarter);
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 256);
    }
  }

  public Xrpa.ObjectUuid GetMcpServerSet() {
    return _localMcpServerSet;
  }

  public void SetMcpServerSet(Xrpa.ObjectUuid mcpServerSet) {
    _localMcpServerSet = mcpServerSet;
    if ((_changeBits & 512) == 0) {
      _changeBits |= 512;
      _changeByteCount += 16;
    }
    if (_collection != null) {
      if (!_hasNotifiedNeedsWrite)
      {
        _collection.NotifyObjectNeedsWrite(GetXrpaId());
        _hasNotifiedNeedsWrite = true;
      }
      _collection.SetDirty(GetXrpaId(), 512);
    }
  }

  public void WriteDSChanges(Xrpa.TransportStreamAccessor accessor) {
    LlmConversationWriter objAccessor = new();
    if (!_createWritten) {
      _changeBits = 895;
      _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localApiKey) + Xrpa.MemoryAccessor.DynSizeOfString(_localSysPrompt) + Xrpa.MemoryAccessor.DynSizeOfString(_localConversationStarter) + 48;
      objAccessor = LlmConversationWriter.Create(accessor, GetCollectionId(), GetXrpaId(), _changeByteCount, _createTimestamp);
      _createWritten = true;
    } else if (_changeBits != 0) {
      objAccessor = LlmConversationWriter.Update(accessor, GetCollectionId(), GetXrpaId(), _changeBits, _changeByteCount);
    }
    if (objAccessor.IsNull()) {
      return;
    }
    if ((_changeBits & 1) != 0) {
      objAccessor.SetApiKey(_localApiKey);
    }
    if ((_changeBits & 2) != 0) {
      objAccessor.SetApiProvider(_localApiProvider);
    }
    if ((_changeBits & 4) != 0) {
      objAccessor.SetModelSize(_localModelSize);
    }
    if ((_changeBits & 8) != 0) {
      objAccessor.SetSysPrompt(_localSysPrompt);
    }
    if ((_changeBits & 16) != 0) {
      objAccessor.SetTemperature(_localTemperature);
    }
    if ((_changeBits & 32) != 0) {
      objAccessor.SetMaxTokens(_localMaxTokens);
    }
    if ((_changeBits & 64) != 0) {
      objAccessor.SetMaxConsecutiveToolCalls(_localMaxConsecutiveToolCalls);
    }
    if ((_changeBits & 256) != 0) {
      objAccessor.SetConversationStarter(_localConversationStarter);
    }
    if ((_changeBits & 512) != 0) {
      objAccessor.SetMcpServerSet(_localMcpServerSet);
    }
    _changeBits = 0;
    _changeByteCount = 0;
    _hasNotifiedNeedsWrite = false;
  }

  public ulong PrepDSFullUpdate() {
    _createWritten = false;
    _changeBits = 895;
    _changeByteCount = Xrpa.MemoryAccessor.DynSizeOfString(_localApiKey) + Xrpa.MemoryAccessor.DynSizeOfString(_localSysPrompt) + Xrpa.MemoryAccessor.DynSizeOfString(_localConversationStarter) + 48;
    return _createTimestamp;
  }

  public void ProcessDSUpdate(LlmConversationReader value, ulong fieldsChanged) {
    if (value.CheckIsProcessingChanged(fieldsChanged)) {
      _localIsProcessing = value.GetIsProcessing();
    }
    HandleXrpaFieldsChanged(fieldsChanged);
  }

  public int GetIsProcessing() {
    return _localIsProcessing;
  }

  public bool CheckApiKeyChanged(ulong fieldsChanged) {
    return (fieldsChanged & 1) != 0;
  }

  public bool CheckApiProviderChanged(ulong fieldsChanged) {
    return (fieldsChanged & 2) != 0;
  }

  public bool CheckModelSizeChanged(ulong fieldsChanged) {
    return (fieldsChanged & 4) != 0;
  }

  public bool CheckSysPromptChanged(ulong fieldsChanged) {
    return (fieldsChanged & 8) != 0;
  }

  public bool CheckTemperatureChanged(ulong fieldsChanged) {
    return (fieldsChanged & 16) != 0;
  }

  public bool CheckMaxTokensChanged(ulong fieldsChanged) {
    return (fieldsChanged & 32) != 0;
  }

  public bool CheckMaxConsecutiveToolCallsChanged(ulong fieldsChanged) {
    return (fieldsChanged & 64) != 0;
  }

  public bool CheckIsProcessingChanged(ulong fieldsChanged) {
    return (fieldsChanged & 128) != 0;
  }

  public bool CheckConversationStarterChanged(ulong fieldsChanged) {
    return (fieldsChanged & 256) != 0;
  }

  public bool CheckMcpServerSetChanged(ulong fieldsChanged) {
    return (fieldsChanged & 512) != 0;
  }

  public void SendChatMessage(string data, byte[] jpegImageData, int id) {
    LlmChatMessageWriter message = new(_collection.SendMessage(
        GetXrpaId(),
        10,
        Xrpa.MemoryAccessor.DynSizeOfString(data) + Xrpa.MemoryAccessor.DynSizeOfBytes(jpegImageData) + 12));
    message.SetData(data);
    message.SetJpegImageData(jpegImageData);
    message.SetId(id);
  }

  public void OnChatResponse(System.Action<ulong, LlmChatResponseReader> handler) {
    _ChatResponseMessageHandler = handler;
  }

  public void OnChatResponseStream(System.Action<ulong, LlmChatResponseReader> handler) {
    _ChatResponseStreamMessageHandler = handler;
  }

  public void ProcessDSMessage(int messageType, ulong msgTimestamp, Xrpa.MemoryAccessor messageData) {
    if (messageType == 11) {
      LlmChatResponseReader message = new(messageData);
      _ChatResponseMessageHandler?.Invoke(msgTimestamp, message);
    }
    if (messageType == 12) {
      LlmChatResponseReader message = new(messageData);
      _ChatResponseStreamMessageHandler?.Invoke(msgTimestamp, message);
    }
  }
}

// Object Collections
public class OutboundMcpServerSetReaderCollection : Xrpa.ObjectCollection<McpServerSetReader, OutboundMcpServerSet> {
  public OutboundMcpServerSetReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 0, 0, 0, true) {}

  public void AddObject(OutboundMcpServerSet obj) {
    AddObjectInternal(obj);
  }

  public OutboundMcpServerSet CreateObject() {
    var obj = new OutboundMcpServerSet(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundMcpServerConfigReaderCollection : Xrpa.ObjectCollection<McpServerConfigReader, OutboundMcpServerConfig> {
  public Xrpa.ObjectCollectionIndex<McpServerConfigReader, OutboundMcpServerConfig, Xrpa.ObjectUuid> ServerSetIndex = new();

  public OutboundMcpServerConfigReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 1, 0, 4, true) {}

  public void AddObject(OutboundMcpServerConfig obj) {
    AddObjectInternal(obj);
  }

  public OutboundMcpServerConfig CreateObject() {
    var obj = new OutboundMcpServerConfig(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }

  protected override void IndexNotifyCreate(OutboundMcpServerConfig obj) {
    ServerSetIndex.OnCreate(obj, obj.GetServerSet());
  }

  protected override void IndexNotifyUpdate(OutboundMcpServerConfig obj, ulong fieldsChanged) {
    if ((fieldsChanged & 4) != 0) {
      ServerSetIndex.OnUpdate(obj, obj.GetServerSet());
    }
  }

  protected override void IndexNotifyDelete(OutboundMcpServerConfig obj) {
    ServerSetIndex.OnDelete(obj, obj.GetServerSet());
  }
}

public class OutboundLlmQueryReaderCollection : Xrpa.ObjectCollection<LlmQueryReader, OutboundLlmQuery> {
  public OutboundLlmQueryReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 2, 128, 0, true) {}

  public void AddObject(OutboundLlmQuery obj) {
    AddObjectInternal(obj);
  }

  public OutboundLlmQuery CreateObject() {
    var obj = new OutboundLlmQuery(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundLlmTriggeredQueryReaderCollection : Xrpa.ObjectCollection<LlmTriggeredQueryReader, OutboundLlmTriggeredQuery> {
  public OutboundLlmTriggeredQueryReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 3, 128, 0, true) {}

  public void AddObject(OutboundLlmTriggeredQuery obj) {
    AddObjectInternal(obj);
  }

  public OutboundLlmTriggeredQuery CreateObject() {
    var obj = new OutboundLlmTriggeredQuery(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

public class OutboundLlmConversationReaderCollection : Xrpa.ObjectCollection<LlmConversationReader, OutboundLlmConversation> {
  public OutboundLlmConversationReaderCollection(Xrpa.DataStoreReconciler reconciler) : base(reconciler, 4, 128, 0, true) {}

  public void AddObject(OutboundLlmConversation obj) {
    AddObjectInternal(obj);
  }

  public OutboundLlmConversation CreateObject() {
    var obj = new OutboundLlmConversation(new Xrpa.ObjectUuid(System.Guid.NewGuid()));
    AddObjectInternal(obj);
    return obj;
  }

  public void RemoveObject(Xrpa.ObjectUuid id) {
    RemoveObjectInternal(id);
  }
}

// Data Store Implementation
public class LlmHubDataStore : Xrpa.DataStoreReconciler {
  public LlmHubDataStore(Xrpa.TransportStream inboundTransport, Xrpa.TransportStream outboundTransport)
      : base(inboundTransport, outboundTransport, 388727552) {
    McpServerSet = new OutboundMcpServerSetReaderCollection(this);
    RegisterCollection(McpServerSet);
    McpServerConfig = new OutboundMcpServerConfigReaderCollection(this);
    RegisterCollection(McpServerConfig);
    LlmQuery = new OutboundLlmQueryReaderCollection(this);
    RegisterCollection(LlmQuery);
    LlmTriggeredQuery = new OutboundLlmTriggeredQueryReaderCollection(this);
    RegisterCollection(LlmTriggeredQuery);
    LlmConversation = new OutboundLlmConversationReaderCollection(this);
    RegisterCollection(LlmConversation);
  }

  public OutboundMcpServerSetReaderCollection McpServerSet;
  public OutboundMcpServerConfigReaderCollection McpServerConfig;
  public OutboundLlmQueryReaderCollection LlmQuery;
  public OutboundLlmTriggeredQueryReaderCollection LlmTriggeredQuery;
  public OutboundLlmConversationReaderCollection LlmConversation;
}

} // namespace LlmHubDataStore
