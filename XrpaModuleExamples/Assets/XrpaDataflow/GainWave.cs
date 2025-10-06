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

namespace XrpaDataflow {

public class GainWave : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramAmp = 1f;
  private float _paramFq = 170f;
  private float _paramGain0 = 1f;
  private float _paramGain1 = 1f;
  private float _paramGain2 = 1f;
  private float _paramGain3 = 1f;
  private float _paramGain4 = 1f;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator0;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp1;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp2;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp3;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp4;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp5;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp6;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack7;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack8;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice9;

  public GainWave(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing) {
    _datastoreSignalProcessing = datastoreSignalProcessing;
    CreateObjects();
  }

  public void Dispose() {
    Dispose(true);
    GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    DestroyObjects();
  }

  ~GainWave() {
    Dispose(false);
  }

  public float GetAmp() {
    return _paramAmp;
  }

  public void SetAmp(float Amp) {
    _paramAmp = Amp;
    if (_objSignalProcessingSignalMathOp1 != null) {
      _objSignalProcessingSignalMathOp1.SetOperandB(Amp);
    }
  }

  public float GetFq() {
    return _paramFq;
  }

  public void SetFq(float Fq) {
    _paramFq = Fq;
    if (_objSignalProcessingSignalOscillator0 != null) {
      _objSignalProcessingSignalOscillator0.SetFrequency(Fq);
    }
  }

  public float GetGain0() {
    return _paramGain0;
  }

  public void SetGain0(float Gain0) {
    _paramGain0 = Gain0;
    if (_objSignalProcessingSignalMathOp2 != null) {
      _objSignalProcessingSignalMathOp2.SetOperandB(Gain0);
    }
  }

  public float GetGain1() {
    return _paramGain1;
  }

  public void SetGain1(float Gain1) {
    _paramGain1 = Gain1;
    if (_objSignalProcessingSignalMathOp3 != null) {
      _objSignalProcessingSignalMathOp3.SetOperandB(Gain1);
    }
  }

  public float GetGain2() {
    return _paramGain2;
  }

  public void SetGain2(float Gain2) {
    _paramGain2 = Gain2;
    if (_objSignalProcessingSignalMathOp4 != null) {
      _objSignalProcessingSignalMathOp4.SetOperandB(Gain2);
    }
  }

  public float GetGain3() {
    return _paramGain3;
  }

  public void SetGain3(float Gain3) {
    _paramGain3 = Gain3;
    if (_objSignalProcessingSignalMathOp5 != null) {
      _objSignalProcessingSignalMathOp5.SetOperandB(Gain3);
    }
  }

  public float GetGain4() {
    return _paramGain4;
  }

  public void SetGain4(float Gain4) {
    _paramGain4 = Gain4;
    if (_objSignalProcessingSignalMathOp6 != null) {
      _objSignalProcessingSignalMathOp6.SetOperandB(Gain4);
    }
  }

  void CreateObjects() {
    _objSignalProcessingSignalOscillator0 = _datastoreSignalProcessing.SignalOscillator.CreateObject();
    _objSignalProcessingSignalMathOp1 = _datastoreSignalProcessing.SignalMathOp.CreateObject();
    _objSignalProcessingSignalMathOp2 = _datastoreSignalProcessing.SignalMathOp.CreateObject();
    _objSignalProcessingSignalMathOp3 = _datastoreSignalProcessing.SignalMathOp.CreateObject();
    _objSignalProcessingSignalMathOp4 = _datastoreSignalProcessing.SignalMathOp.CreateObject();
    _objSignalProcessingSignalMathOp5 = _datastoreSignalProcessing.SignalMathOp.CreateObject();
    _objSignalProcessingSignalMathOp6 = _datastoreSignalProcessing.SignalMathOp.CreateObject();
    _objSignalProcessingSignalChannelStack7 = _datastoreSignalProcessing.SignalChannelStack.CreateObject();
    _objSignalProcessingSignalChannelStack8 = _datastoreSignalProcessing.SignalChannelStack.CreateObject();
    _objSignalProcessingSignalOutputDevice9 = _datastoreSignalProcessing.SignalOutputDevice.CreateObject();
    _objSignalProcessingSignalOscillator0.SetNumChannels(1);
    _objSignalProcessingSignalOscillator0.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(3));
    _objSignalProcessingSignalOscillator0.SetFrequency(_paramFq);
    _objSignalProcessingSignalOscillator0.SetPulseWidth(0.5f);
    _objSignalProcessingSignalOscillator0.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp1.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp1.SetOperandANode(_objSignalProcessingSignalOscillator0.GetXrpaId());
    _objSignalProcessingSignalMathOp1.SetOperandB(_paramAmp);
    _objSignalProcessingSignalMathOp1.SetNumChannels(1);
    _objSignalProcessingSignalMathOp1.SetNumOutputs(5);
    _objSignalProcessingSignalMathOp2.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp2.SetOperandANode(_objSignalProcessingSignalMathOp1.GetXrpaId());
    _objSignalProcessingSignalMathOp2.SetOperandB(_paramGain0);
    _objSignalProcessingSignalMathOp2.SetNumChannels(1);
    _objSignalProcessingSignalMathOp2.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp3.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp3.SetOperandANode(_objSignalProcessingSignalMathOp1.GetXrpaId());
    _objSignalProcessingSignalMathOp3.SetOperandB(_paramGain1);
    _objSignalProcessingSignalMathOp3.SetNumChannels(1);
    _objSignalProcessingSignalMathOp3.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp4.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp4.SetOperandANode(_objSignalProcessingSignalMathOp1.GetXrpaId());
    _objSignalProcessingSignalMathOp4.SetOperandB(_paramGain2);
    _objSignalProcessingSignalMathOp4.SetNumChannels(1);
    _objSignalProcessingSignalMathOp4.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp5.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp5.SetOperandANode(_objSignalProcessingSignalMathOp1.GetXrpaId());
    _objSignalProcessingSignalMathOp5.SetOperandB(_paramGain3);
    _objSignalProcessingSignalMathOp5.SetNumChannels(1);
    _objSignalProcessingSignalMathOp5.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp6.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp6.SetOperandANode(_objSignalProcessingSignalMathOp1.GetXrpaId());
    _objSignalProcessingSignalMathOp6.SetOperandB(_paramGain4);
    _objSignalProcessingSignalMathOp6.SetNumChannels(1);
    _objSignalProcessingSignalMathOp6.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack7.SetSrcNode0(_objSignalProcessingSignalMathOp2.GetXrpaId());
    _objSignalProcessingSignalChannelStack7.SetSrcNode1(_objSignalProcessingSignalMathOp3.GetXrpaId());
    _objSignalProcessingSignalChannelStack7.SetSrcNode2(_objSignalProcessingSignalMathOp4.GetXrpaId());
    _objSignalProcessingSignalChannelStack7.SetSrcNode3(_objSignalProcessingSignalMathOp5.GetXrpaId());
    _objSignalProcessingSignalChannelStack7.SetNumChannels(4);
    _objSignalProcessingSignalChannelStack7.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack8.SetSrcNode0(_objSignalProcessingSignalChannelStack7.GetXrpaId());
    _objSignalProcessingSignalChannelStack8.SetSrcNode1(_objSignalProcessingSignalMathOp6.GetXrpaId());
    _objSignalProcessingSignalChannelStack8.SetNumChannels(5);
    _objSignalProcessingSignalChannelStack8.SetNumOutputs(1);
    _objSignalProcessingSignalOutputDevice9.SetSrcNode(_objSignalProcessingSignalChannelStack8.GetXrpaId());
    _objSignalProcessingSignalOutputDevice9.SetDeviceNameFilter("HDK-1");
    _objSignalProcessingSignalOutputDevice9.SetChannelOffset(0);
  }

  void DestroyObjects() {
    if (_objSignalProcessingSignalOutputDevice9 != null) {
      _datastoreSignalProcessing.SignalOutputDevice.RemoveObject(_objSignalProcessingSignalOutputDevice9.GetXrpaId());
      _objSignalProcessingSignalOutputDevice9 = null;
    }
    if (_objSignalProcessingSignalChannelStack8 != null) {
      _datastoreSignalProcessing.SignalChannelStack.RemoveObject(_objSignalProcessingSignalChannelStack8.GetXrpaId());
      _objSignalProcessingSignalChannelStack8 = null;
    }
    if (_objSignalProcessingSignalChannelStack7 != null) {
      _datastoreSignalProcessing.SignalChannelStack.RemoveObject(_objSignalProcessingSignalChannelStack7.GetXrpaId());
      _objSignalProcessingSignalChannelStack7 = null;
    }
    if (_objSignalProcessingSignalMathOp6 != null) {
      _datastoreSignalProcessing.SignalMathOp.RemoveObject(_objSignalProcessingSignalMathOp6.GetXrpaId());
      _objSignalProcessingSignalMathOp6 = null;
    }
    if (_objSignalProcessingSignalMathOp5 != null) {
      _datastoreSignalProcessing.SignalMathOp.RemoveObject(_objSignalProcessingSignalMathOp5.GetXrpaId());
      _objSignalProcessingSignalMathOp5 = null;
    }
    if (_objSignalProcessingSignalMathOp4 != null) {
      _datastoreSignalProcessing.SignalMathOp.RemoveObject(_objSignalProcessingSignalMathOp4.GetXrpaId());
      _objSignalProcessingSignalMathOp4 = null;
    }
    if (_objSignalProcessingSignalMathOp3 != null) {
      _datastoreSignalProcessing.SignalMathOp.RemoveObject(_objSignalProcessingSignalMathOp3.GetXrpaId());
      _objSignalProcessingSignalMathOp3 = null;
    }
    if (_objSignalProcessingSignalMathOp2 != null) {
      _datastoreSignalProcessing.SignalMathOp.RemoveObject(_objSignalProcessingSignalMathOp2.GetXrpaId());
      _objSignalProcessingSignalMathOp2 = null;
    }
    if (_objSignalProcessingSignalMathOp1 != null) {
      _datastoreSignalProcessing.SignalMathOp.RemoveObject(_objSignalProcessingSignalMathOp1.GetXrpaId());
      _objSignalProcessingSignalMathOp1 = null;
    }
    if (_objSignalProcessingSignalOscillator0 != null) {
      _datastoreSignalProcessing.SignalOscillator.RemoveObject(_objSignalProcessingSignalOscillator0.GetXrpaId());
      _objSignalProcessingSignalOscillator0 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace XrpaDataflow
