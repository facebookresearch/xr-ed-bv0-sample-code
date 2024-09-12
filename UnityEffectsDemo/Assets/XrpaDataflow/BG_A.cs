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

public class BG_A : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
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
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack6;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack7;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice8;

  public BG_A(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing) {
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

  ~BG_A() {
    Dispose(false);
  }

  public float GetGain0() {
    return _paramGain0;
  }

  public void SetGain0(float Gain0) {
    _paramGain0 = Gain0;
    if (_objSignalProcessingSignalMathOp1 != null) {
      _objSignalProcessingSignalMathOp1.SetOperandB(Gain0);
    }
  }

  public float GetGain1() {
    return _paramGain1;
  }

  public void SetGain1(float Gain1) {
    _paramGain1 = Gain1;
    if (_objSignalProcessingSignalMathOp2 != null) {
      _objSignalProcessingSignalMathOp2.SetOperandB(Gain1);
    }
  }

  public float GetGain2() {
    return _paramGain2;
  }

  public void SetGain2(float Gain2) {
    _paramGain2 = Gain2;
    if (_objSignalProcessingSignalMathOp3 != null) {
      _objSignalProcessingSignalMathOp3.SetOperandB(Gain2);
    }
  }

  public float GetGain3() {
    return _paramGain3;
  }

  public void SetGain3(float Gain3) {
    _paramGain3 = Gain3;
    if (_objSignalProcessingSignalMathOp4 != null) {
      _objSignalProcessingSignalMathOp4.SetOperandB(Gain3);
    }
  }

  public float GetGain4() {
    return _paramGain4;
  }

  public void SetGain4(float Gain4) {
    _paramGain4 = Gain4;
    if (_objSignalProcessingSignalMathOp5 != null) {
      _objSignalProcessingSignalMathOp5.SetOperandB(Gain4);
    }
  }

  void CreateObjects() {
    _objSignalProcessingSignalOscillator0 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalMathOp1 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp2 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp2);
    _objSignalProcessingSignalMathOp3 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalMathOp4 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp4);
    _objSignalProcessingSignalMathOp5 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp5);
    _objSignalProcessingSignalChannelStack6 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack6);
    _objSignalProcessingSignalChannelStack7 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack7);
    _objSignalProcessingSignalOutputDevice8 = new SignalProcessingDataStore.OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalProcessingSignalOutputDevice8);
    _objSignalProcessingSignalOscillator0.SetNumChannels(1);
    _objSignalProcessingSignalOscillator0.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(3));
    _objSignalProcessingSignalOscillator0.SetFrequency(30f);
    _objSignalProcessingSignalOscillator0.SetPulseWidth(0.5f);
    _objSignalProcessingSignalOscillator0.SetNumOutputs(5);
    _objSignalProcessingSignalMathOp1.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp1.SetOperandANode(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalMathOp1.SetOperandB(_paramGain0);
    _objSignalProcessingSignalMathOp1.SetNumChannels(1);
    _objSignalProcessingSignalMathOp1.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp2.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp2.SetOperandANode(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalMathOp2.SetOperandB(_paramGain1);
    _objSignalProcessingSignalMathOp2.SetNumChannels(1);
    _objSignalProcessingSignalMathOp2.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp3.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp3.SetOperandANode(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalMathOp3.SetOperandB(_paramGain2);
    _objSignalProcessingSignalMathOp3.SetNumChannels(1);
    _objSignalProcessingSignalMathOp3.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp4.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp4.SetOperandANode(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalMathOp4.SetOperandB(_paramGain3);
    _objSignalProcessingSignalMathOp4.SetNumChannels(1);
    _objSignalProcessingSignalMathOp4.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp5.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp5.SetOperandANode(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalMathOp5.SetOperandB(_paramGain4);
    _objSignalProcessingSignalMathOp5.SetNumChannels(1);
    _objSignalProcessingSignalMathOp5.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack6.SetSrcNode0(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalChannelStack6.SetSrcNode1(_objSignalProcessingSignalMathOp2);
    _objSignalProcessingSignalChannelStack6.SetSrcNode2(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalChannelStack6.SetSrcNode3(_objSignalProcessingSignalMathOp4);
    _objSignalProcessingSignalChannelStack6.SetNumChannels(4);
    _objSignalProcessingSignalChannelStack6.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack7.SetSrcNode0(_objSignalProcessingSignalChannelStack6);
    _objSignalProcessingSignalChannelStack7.SetSrcNode1(_objSignalProcessingSignalMathOp5);
    _objSignalProcessingSignalChannelStack7.SetNumChannels(5);
    _objSignalProcessingSignalChannelStack7.SetNumOutputs(1);
    _objSignalProcessingSignalOutputDevice8.SetSrcNode(_objSignalProcessingSignalChannelStack7);
    _objSignalProcessingSignalOutputDevice8.SetDeviceNameFilter("HDK-1");
    _objSignalProcessingSignalOutputDevice8.SetChannelOffset(0);
  }

  void DestroyObjects() {
    if (_objSignalProcessingSignalOutputDevice8 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalProcessingSignalOutputDevice8.GetXrpaId());
      _objSignalProcessingSignalOutputDevice8 = null;
    }
    if (_objSignalProcessingSignalChannelStack7 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack7.GetXrpaId());
      _objSignalProcessingSignalChannelStack7 = null;
    }
    if (_objSignalProcessingSignalChannelStack6 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack6.GetXrpaId());
      _objSignalProcessingSignalChannelStack6 = null;
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
    if (_objSignalProcessingSignalMathOp2 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp2.GetXrpaId());
      _objSignalProcessingSignalMathOp2 = null;
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
