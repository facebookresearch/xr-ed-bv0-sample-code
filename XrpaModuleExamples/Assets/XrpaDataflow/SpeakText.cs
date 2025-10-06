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

using SignalProcessingDataStore;
using System;
using TextToSpeechDataStore;
using Xrpa;

namespace XrpaDataflow {

public class SpeakText : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
  private TextToSpeechDataStore.TextToSpeechDataStore _datastoreTextToSpeech;
  private System.Action<ulong, int, bool, string, ulong> _paramTtsResponse = null;
  private TextToSpeechDataStore.OutboundTextToSpeech _objTextToSpeechTextToSpeech0;
  private SignalProcessingDataStore.OutboundSignalSource _objSignalProcessingSignalSource1;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack2;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice3;
  private Xrpa.InboundSignalForwarder _objTextToSpeechTextToSpeech0AudioForwarder;

  public SpeakText(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing, TextToSpeechDataStore.TextToSpeechDataStore datastoreTextToSpeech) {
    _datastoreSignalProcessing = datastoreSignalProcessing;
    _datastoreTextToSpeech = datastoreTextToSpeech;
    CreateObjects();
  }

  public void Dispose() {
    Dispose(true);
    GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    DestroyObjects();
  }

  ~SpeakText() {
    Dispose(false);
  }

  public void SendTextRequest(string text, int id) {
    if (_objTextToSpeechTextToSpeech0 != null) {
      _objTextToSpeechTextToSpeech0.SendTextRequest(text, id);
    }
  }

  public void OnTtsResponse(System.Action<ulong, int, bool, string, ulong> handler) {
    _paramTtsResponse = handler;
  }

  void Dispatch_objTextToSpeechTextToSpeech0TtsResponse(ulong msgTimestamp, TextToSpeechDataStore.TtsResponseReader msg) {
    var id = msg.GetId();
    var success = msg.GetSuccess();
    var errorMessage = msg.GetErrorMessage();
    var playbackStartTimestamp = msg.GetPlaybackStartTimestamp();
    _paramTtsResponse?.Invoke(msgTimestamp, id, success, errorMessage, playbackStartTimestamp);
  }

  void CreateObjects() {
    _objTextToSpeechTextToSpeech0 = _datastoreTextToSpeech.TextToSpeech.CreateObject();
    _objSignalProcessingSignalSource1 = _datastoreSignalProcessing.SignalSource.CreateObject();
    _objSignalProcessingSignalChannelStack2 = _datastoreSignalProcessing.SignalChannelStack.CreateObject();
    _objSignalProcessingSignalOutputDevice3 = _datastoreSignalProcessing.SignalOutputDevice.CreateObject();
    _objSignalProcessingSignalSource1.SetNumChannels(1);
    _objTextToSpeechTextToSpeech0AudioForwarder = new Xrpa.InboundSignalForwarder();
    _objTextToSpeechTextToSpeech0.OnAudio(_objTextToSpeechTextToSpeech0AudioForwarder);
    _objSignalProcessingSignalSource1.SetSrcDataForwarder<float>(_objTextToSpeechTextToSpeech0AudioForwarder);
    _objSignalProcessingSignalSource1.SetNumOutputs(2);
    _objSignalProcessingSignalChannelStack2.SetSrcNode0(_objSignalProcessingSignalSource1.GetXrpaId());
    _objSignalProcessingSignalChannelStack2.SetSrcNode1(_objSignalProcessingSignalSource1.GetXrpaId());
    _objSignalProcessingSignalChannelStack2.SetNumChannels(2);
    _objSignalProcessingSignalChannelStack2.SetNumOutputs(1);
    _objSignalProcessingSignalOutputDevice3.SetSrcNode(_objSignalProcessingSignalChannelStack2.GetXrpaId());
    _objSignalProcessingSignalOutputDevice3.SetOutputToSystemAudio(true);
    _objSignalProcessingSignalOutputDevice3.SetChannelOffset(0);
    _objTextToSpeechTextToSpeech0.OnTtsResponse(Dispatch_objTextToSpeechTextToSpeech0TtsResponse);
  }

  void DestroyObjects() {
    if (_objSignalProcessingSignalOutputDevice3 != null) {
      _datastoreSignalProcessing.SignalOutputDevice.RemoveObject(_objSignalProcessingSignalOutputDevice3.GetXrpaId());
      _objSignalProcessingSignalOutputDevice3 = null;
    }
    if (_objSignalProcessingSignalChannelStack2 != null) {
      _datastoreSignalProcessing.SignalChannelStack.RemoveObject(_objSignalProcessingSignalChannelStack2.GetXrpaId());
      _objSignalProcessingSignalChannelStack2 = null;
    }
    if (_objSignalProcessingSignalSource1 != null) {
      _datastoreSignalProcessing.SignalSource.RemoveObject(_objSignalProcessingSignalSource1.GetXrpaId());
      _objSignalProcessingSignalSource1 = null;
    }
    if (_objTextToSpeechTextToSpeech0 != null) {
      _datastoreTextToSpeech.TextToSpeech.RemoveObject(_objTextToSpeechTextToSpeech0.GetXrpaId());
      _objTextToSpeechTextToSpeech0 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace XrpaDataflow
