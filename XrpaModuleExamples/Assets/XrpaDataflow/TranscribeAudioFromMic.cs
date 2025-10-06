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

using AudioInputDataStore;
using AudioTranscriptionDataStore;
using System;
using Xrpa;

namespace XrpaDataflow {

public class TranscribeAudioFromMic : IDisposable {
  private AudioInputDataStore.AudioInputDataStore _datastoreAudioInput;
  private AudioTranscriptionDataStore.AudioTranscriptionDataStore _datastoreAudioTranscription;
  private System.Action<ulong, string, ulong, bool, string> _paramTranscriptionResult = null;
  private AudioInputDataStore.OutboundAudioInputSource _objAudioInputAudioInputSource0;
  private AudioTranscriptionDataStore.OutboundAudioTranscription _objAudioTranscriptionAudioTranscription1;
  private Xrpa.InboundSignalForwarder _objAudioInputAudioInputSource0AudioSignalForwarder;

  public TranscribeAudioFromMic(AudioInputDataStore.AudioInputDataStore datastoreAudioInput, AudioTranscriptionDataStore.AudioTranscriptionDataStore datastoreAudioTranscription) {
    _datastoreAudioInput = datastoreAudioInput;
    _datastoreAudioTranscription = datastoreAudioTranscription;
    CreateObjects();
  }

  public void Dispose() {
    Dispose(true);
    GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    DestroyObjects();
  }

  ~TranscribeAudioFromMic() {
    Dispose(false);
  }

  public void OnTranscriptionResult(System.Action<ulong, string, ulong, bool, string> handler) {
    _paramTranscriptionResult = handler;
  }

  void Dispatch_objAudioTranscriptionAudioTranscription1TranscriptionResult(ulong msgTimestamp, AudioTranscriptionDataStore.TranscriptionResultReader msg) {
    var text = msg.GetText();
    var timestamp = msg.GetTimestamp();
    var success = msg.GetSuccess();
    var errorMessage = msg.GetErrorMessage();
    _paramTranscriptionResult?.Invoke(msgTimestamp, text, timestamp, success, errorMessage);
  }

  void CreateObjects() {
    _objAudioInputAudioInputSource0 = _datastoreAudioInput.AudioInputSource.CreateObject();
    _objAudioTranscriptionAudioTranscription1 = _datastoreAudioTranscription.AudioTranscription.CreateObject();
    _objAudioInputAudioInputSource0.SetBindTo((AudioInputDataStore.DeviceBindingType)(uint)(2));
    _objAudioInputAudioInputSource0.SetFrameRate(16000);
    _objAudioInputAudioInputSource0.SetNumChannels(1);
    _objAudioInputAudioInputSource0AudioSignalForwarder = new Xrpa.InboundSignalForwarder();
    _objAudioInputAudioInputSource0.OnAudioSignal(_objAudioInputAudioInputSource0AudioSignalForwarder);
    _objAudioTranscriptionAudioTranscription1.SetAudioSignalForwarder<float>(_objAudioInputAudioInputSource0AudioSignalForwarder);
    _objAudioTranscriptionAudioTranscription1.OnTranscriptionResult(Dispatch_objAudioTranscriptionAudioTranscription1TranscriptionResult);
  }

  void DestroyObjects() {
    if (_objAudioTranscriptionAudioTranscription1 != null) {
      _datastoreAudioTranscription.AudioTranscription.RemoveObject(_objAudioTranscriptionAudioTranscription1.GetXrpaId());
      _objAudioTranscriptionAudioTranscription1 = null;
    }
    if (_objAudioInputAudioInputSource0 != null) {
      _datastoreAudioInput.AudioInputSource.RemoveObject(_objAudioInputAudioInputSource0.GetXrpaId());
      _objAudioInputAudioInputSource0 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace XrpaDataflow
