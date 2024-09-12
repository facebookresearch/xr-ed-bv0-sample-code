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
using Xrpa;

namespace XrpaDataflow {

public class BG_C : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramGain0 = 1f;
  private float _paramGain1 = 1f;
  private float _paramGain2 = 1f;
  private float _paramGain3 = 1f;
  private float _paramGain4 = 1f;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator0;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp1;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator2;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp3;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp4;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp5;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp6;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp7;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp8;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack9;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack10;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice11;

  public BG_C(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing) {
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

  ~BG_C() {
    Dispose(false);
  }

  public float GetGain0() {
    return _paramGain0;
  }

  public void SetGain0(float Gain0) {
    _paramGain0 = Gain0;
    if (_objSignalProcessingSignalMathOp4 != null) {
      _objSignalProcessingSignalMathOp4.SetOperandB(Gain0);
    }
  }

  public float GetGain1() {
    return _paramGain1;
  }

  public void SetGain1(float Gain1) {
    _paramGain1 = Gain1;
    if (_objSignalProcessingSignalMathOp5 != null) {
      _objSignalProcessingSignalMathOp5.SetOperandB(Gain1);
    }
  }

  public float GetGain2() {
    return _paramGain2;
  }

  public void SetGain2(float Gain2) {
    _paramGain2 = Gain2;
    if (_objSignalProcessingSignalMathOp6 != null) {
      _objSignalProcessingSignalMathOp6.SetOperandB(Gain2);
    }
  }

  public float GetGain3() {
    return _paramGain3;
  }

  public void SetGain3(float Gain3) {
    _paramGain3 = Gain3;
    if (_objSignalProcessingSignalMathOp7 != null) {
      _objSignalProcessingSignalMathOp7.SetOperandB(Gain3);
    }
  }

  public float GetGain4() {
    return _paramGain4;
  }

  public void SetGain4(float Gain4) {
    _paramGain4 = Gain4;
    if (_objSignalProcessingSignalMathOp8 != null) {
      _objSignalProcessingSignalMathOp8.SetOperandB(Gain4);
    }
  }

  void CreateObjects() {
    _objSignalProcessingSignalOscillator0 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalMathOp1 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalOscillator2 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator2);
    _objSignalProcessingSignalMathOp3 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalMathOp4 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp4);
    _objSignalProcessingSignalMathOp5 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp5);
    _objSignalProcessingSignalMathOp6 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp6);
    _objSignalProcessingSignalMathOp7 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp7);
    _objSignalProcessingSignalMathOp8 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp8);
    _objSignalProcessingSignalChannelStack9 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack9);
    _objSignalProcessingSignalChannelStack10 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack10);
    _objSignalProcessingSignalOutputDevice11 = new SignalProcessingDataStore.OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalProcessingSignalOutputDevice11);
    _objSignalProcessingSignalOscillator0.SetNumChannels(1);
    _objSignalProcessingSignalOscillator0.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(2));
    _objSignalProcessingSignalOscillator0.SetFrequency(350f);
    _objSignalProcessingSignalOscillator0.SetPulseWidth(0.5f);
    _objSignalProcessingSignalOscillator0.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp1.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp1.SetOperandANode(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalMathOp1.SetOperandB(0.2f);
    _objSignalProcessingSignalMathOp1.SetNumChannels(1);
    _objSignalProcessingSignalMathOp1.SetNumOutputs(1);
    _objSignalProcessingSignalOscillator2.SetNumChannels(1);
    _objSignalProcessingSignalOscillator2.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(3));
    _objSignalProcessingSignalOscillator2.SetFrequency(2f);
    _objSignalProcessingSignalOscillator2.SetPulseWidth(0.5f);
    _objSignalProcessingSignalOscillator2.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp3.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp3.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp3.SetOperandBNode(_objSignalProcessingSignalOscillator2);
    _objSignalProcessingSignalMathOp3.SetNumChannels(1);
    _objSignalProcessingSignalMathOp3.SetNumOutputs(5);
    _objSignalProcessingSignalMathOp4.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp4.SetOperandANode(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalMathOp4.SetOperandB(_paramGain0);
    _objSignalProcessingSignalMathOp4.SetNumChannels(1);
    _objSignalProcessingSignalMathOp4.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp5.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp5.SetOperandANode(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalMathOp5.SetOperandB(_paramGain1);
    _objSignalProcessingSignalMathOp5.SetNumChannels(1);
    _objSignalProcessingSignalMathOp5.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp6.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp6.SetOperandANode(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalMathOp6.SetOperandB(_paramGain2);
    _objSignalProcessingSignalMathOp6.SetNumChannels(1);
    _objSignalProcessingSignalMathOp6.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp7.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp7.SetOperandANode(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalMathOp7.SetOperandB(_paramGain3);
    _objSignalProcessingSignalMathOp7.SetNumChannels(1);
    _objSignalProcessingSignalMathOp7.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp8.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp8.SetOperandANode(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalMathOp8.SetOperandB(_paramGain4);
    _objSignalProcessingSignalMathOp8.SetNumChannels(1);
    _objSignalProcessingSignalMathOp8.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack9.SetSrcNode0(_objSignalProcessingSignalMathOp4);
    _objSignalProcessingSignalChannelStack9.SetSrcNode1(_objSignalProcessingSignalMathOp5);
    _objSignalProcessingSignalChannelStack9.SetSrcNode2(_objSignalProcessingSignalMathOp6);
    _objSignalProcessingSignalChannelStack9.SetSrcNode3(_objSignalProcessingSignalMathOp7);
    _objSignalProcessingSignalChannelStack9.SetNumChannels(4);
    _objSignalProcessingSignalChannelStack9.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack10.SetSrcNode0(_objSignalProcessingSignalChannelStack9);
    _objSignalProcessingSignalChannelStack10.SetSrcNode1(_objSignalProcessingSignalMathOp8);
    _objSignalProcessingSignalChannelStack10.SetNumChannels(5);
    _objSignalProcessingSignalChannelStack10.SetNumOutputs(1);
    _objSignalProcessingSignalOutputDevice11.SetSrcNode(_objSignalProcessingSignalChannelStack10);
    _objSignalProcessingSignalOutputDevice11.SetDeviceNameFilter("HDK-1");
    _objSignalProcessingSignalOutputDevice11.SetChannelOffset(0);
  }

  void DestroyObjects() {
    if (_objSignalProcessingSignalOutputDevice11 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalProcessingSignalOutputDevice11.GetXrpaId());
      _objSignalProcessingSignalOutputDevice11 = null;
    }
    if (_objSignalProcessingSignalChannelStack10 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack10.GetXrpaId());
      _objSignalProcessingSignalChannelStack10 = null;
    }
    if (_objSignalProcessingSignalChannelStack9 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack9.GetXrpaId());
      _objSignalProcessingSignalChannelStack9 = null;
    }
    if (_objSignalProcessingSignalMathOp8 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp8.GetXrpaId());
      _objSignalProcessingSignalMathOp8 = null;
    }
    if (_objSignalProcessingSignalMathOp7 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp7.GetXrpaId());
      _objSignalProcessingSignalMathOp7 = null;
    }
    if (_objSignalProcessingSignalMathOp6 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp6.GetXrpaId());
      _objSignalProcessingSignalMathOp6 = null;
    }
    if (_objSignalProcessingSignalMathOp5 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp5.GetXrpaId());
      _objSignalProcessingSignalMathOp5 = null;
    }
    if (_objSignalProcessingSignalMathOp4 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp4.GetXrpaId());
      _objSignalProcessingSignalMathOp4 = null;
    }
    if (_objSignalProcessingSignalMathOp3 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp3.GetXrpaId());
      _objSignalProcessingSignalMathOp3 = null;
    }
    if (_objSignalProcessingSignalOscillator2 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalProcessingSignalOscillator2.GetXrpaId());
      _objSignalProcessingSignalOscillator2 = null;
    }
    if (_objSignalProcessingSignalMathOp1 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp1.GetXrpaId());
      _objSignalProcessingSignalMathOp1 = null;
    }
    if (_objSignalProcessingSignalOscillator0 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalProcessingSignalOscillator0.GetXrpaId());
      _objSignalProcessingSignalOscillator0 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace XrpaDataflow
