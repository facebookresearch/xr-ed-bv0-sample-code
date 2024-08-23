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

namespace SignalProcessingDataStore {

public class SimpleWave : IDisposable {
  private SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramAmp = 1f;
  private float _paramFq = 170f;
  private OutboundSignalOscillator _objSignalOscillator197;
  private OutboundSignalMathOp _objSignalMathOp198;
  private OutboundSignalOutputDevice _objSignalOutputDevice199;

  public SimpleWave(SignalProcessingDataStore datastore) {
    _datastoreSignalProcessing = datastore;
    CreateObjects();
  }

  public void Dispose() {
    Dispose(true);
    GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    DestroyObjects();
  }

  ~SimpleWave() {
    Dispose(false);
  }

  public float GetAmp() {
    return _paramAmp;
  }

  public void SetAmp(float Amp) {
    _paramAmp = Amp;
    if (_objSignalMathOp198 != null) {
      _objSignalMathOp198.SetOperandB(Amp);
    }
  }

  public float GetFq() {
    return _paramFq;
  }

  public void SetFq(float Fq) {
    _paramFq = Fq;
    if (_objSignalOscillator197 != null) {
      _objSignalOscillator197.SetFrequency(Fq);
    }
  }

  void CreateObjects() {
    _objSignalOscillator197 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator197);
    _objSignalMathOp198 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp198);
    _objSignalOutputDevice199 = new OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalOutputDevice199);
    _objSignalOscillator197.SetNumChannels(1);
    _objSignalOscillator197.SetWaveformType((WaveformType)(uint)(3));
    _objSignalOscillator197.SetFrequency(_paramFq);
    _objSignalOscillator197.SetPulseWidth(0.5f);
    _objSignalOscillator197.SetNumOutputs(1);
    _objSignalMathOp198.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp198.SetOperandANode(_objSignalOscillator197);
    _objSignalMathOp198.SetOperandB(_paramAmp);
    _objSignalMathOp198.SetNumChannels(1);
    _objSignalMathOp198.SetNumOutputs(1);
    _objSignalOutputDevice199.SetSrcNode(_objSignalMathOp198);
    _objSignalOutputDevice199.SetDeviceNameFilter("HDK-1");
    _objSignalOutputDevice199.SetChannelOffset(0);
  }

  void DestroyObjects() {
    if (_objSignalOutputDevice199 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalOutputDevice199.GetXrpaId());
      _objSignalOutputDevice199 = null;
    }
    if (_objSignalMathOp198 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp198.GetXrpaId());
      _objSignalMathOp198 = null;
    }
    if (_objSignalOscillator197 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator197.GetXrpaId());
      _objSignalOscillator197 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace SignalProcessingDataStore
