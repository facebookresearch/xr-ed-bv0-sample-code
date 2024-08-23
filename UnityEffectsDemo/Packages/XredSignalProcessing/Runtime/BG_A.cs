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

public class BG_A : IDisposable {
  private SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramGain0 = 1f;
  private float _paramGain1 = 1f;
  private float _paramGain2 = 1f;
  private float _paramGain3 = 1f;
  private float _paramGain4 = 1f;
  private OutboundSignalOscillator _objSignalOscillator0;
  private OutboundSignalMathOp _objSignalMathOp1;
  private OutboundSignalMathOp _objSignalMathOp2;
  private OutboundSignalMathOp _objSignalMathOp3;
  private OutboundSignalMathOp _objSignalMathOp4;
  private OutboundSignalChannelStack _objSignalChannelStack6;
  private OutboundSignalMathOp _objSignalMathOp5;
  private OutboundSignalChannelStack _objSignalChannelStack7;
  private OutboundSignalOutputDevice _objSignalOutputDevice8;

  public BG_A(SignalProcessingDataStore datastore) {
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

  ~BG_A() {
    Dispose(false);
  }

  public float GetGain0() {
    return _paramGain0;
  }

  public void SetGain0(float Gain0) {
    _paramGain0 = Gain0;
    if (_objSignalMathOp1 != null) {
      _objSignalMathOp1.SetOperandB(Gain0);
    }
  }

  public float GetGain1() {
    return _paramGain1;
  }

  public void SetGain1(float Gain1) {
    _paramGain1 = Gain1;
    if (_objSignalMathOp2 != null) {
      _objSignalMathOp2.SetOperandB(Gain1);
    }
  }

  public float GetGain2() {
    return _paramGain2;
  }

  public void SetGain2(float Gain2) {
    _paramGain2 = Gain2;
    if (_objSignalMathOp3 != null) {
      _objSignalMathOp3.SetOperandB(Gain2);
    }
  }

  public float GetGain3() {
    return _paramGain3;
  }

  public void SetGain3(float Gain3) {
    _paramGain3 = Gain3;
    if (_objSignalMathOp4 != null) {
      _objSignalMathOp4.SetOperandB(Gain3);
    }
  }

  public float GetGain4() {
    return _paramGain4;
  }

  public void SetGain4(float Gain4) {
    _paramGain4 = Gain4;
    if (_objSignalMathOp5 != null) {
      _objSignalMathOp5.SetOperandB(Gain4);
    }
  }

  void CreateObjects() {
    _objSignalOscillator0 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator0);
    _objSignalMathOp1 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp1);
    _objSignalMathOp2 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp2);
    _objSignalMathOp3 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp3);
    _objSignalMathOp4 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp4);
    _objSignalChannelStack6 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack6);
    _objSignalMathOp5 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp5);
    _objSignalChannelStack7 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack7);
    _objSignalOutputDevice8 = new OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalOutputDevice8);
    _objSignalOscillator0.SetNumChannels(1);
    _objSignalOscillator0.SetWaveformType((WaveformType)(uint)(3));
    _objSignalOscillator0.SetFrequency(30f);
    _objSignalOscillator0.SetPulseWidth(0.5f);
    _objSignalOscillator0.SetNumOutputs(5);
    _objSignalMathOp1.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp1.SetOperandANode(_objSignalOscillator0);
    _objSignalMathOp1.SetOperandB(_paramGain0);
    _objSignalMathOp1.SetNumChannels(1);
    _objSignalMathOp1.SetNumOutputs(1);
    _objSignalMathOp2.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp2.SetOperandANode(_objSignalOscillator0);
    _objSignalMathOp2.SetOperandB(_paramGain1);
    _objSignalMathOp2.SetNumChannels(1);
    _objSignalMathOp2.SetNumOutputs(1);
    _objSignalMathOp3.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp3.SetOperandANode(_objSignalOscillator0);
    _objSignalMathOp3.SetOperandB(_paramGain2);
    _objSignalMathOp3.SetNumChannels(1);
    _objSignalMathOp3.SetNumOutputs(1);
    _objSignalMathOp4.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp4.SetOperandANode(_objSignalOscillator0);
    _objSignalMathOp4.SetOperandB(_paramGain3);
    _objSignalMathOp4.SetNumChannels(1);
    _objSignalMathOp4.SetNumOutputs(1);
    _objSignalChannelStack6.SetSrcNode0(_objSignalMathOp1);
    _objSignalChannelStack6.SetSrcNode1(_objSignalMathOp2);
    _objSignalChannelStack6.SetSrcNode2(_objSignalMathOp3);
    _objSignalChannelStack6.SetSrcNode3(_objSignalMathOp4);
    _objSignalChannelStack6.SetNumChannels(4);
    _objSignalChannelStack6.SetNumOutputs(1);
    _objSignalMathOp5.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp5.SetOperandANode(_objSignalOscillator0);
    _objSignalMathOp5.SetOperandB(_paramGain4);
    _objSignalMathOp5.SetNumChannels(1);
    _objSignalMathOp5.SetNumOutputs(1);
    _objSignalChannelStack7.SetSrcNode0(_objSignalChannelStack6);
    _objSignalChannelStack7.SetSrcNode1(_objSignalMathOp5);
    _objSignalChannelStack7.SetNumChannels(5);
    _objSignalChannelStack7.SetNumOutputs(1);
    _objSignalOutputDevice8.SetSrcNode(_objSignalChannelStack7);
    _objSignalOutputDevice8.SetDeviceNameFilter("HDK-1");
    _objSignalOutputDevice8.SetChannelOffset(0);
  }

  void DestroyObjects() {
    if (_objSignalOutputDevice8 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalOutputDevice8.GetXrpaId());
      _objSignalOutputDevice8 = null;
    }
    if (_objSignalChannelStack7 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack7.GetXrpaId());
      _objSignalChannelStack7 = null;
    }
    if (_objSignalMathOp5 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp5.GetXrpaId());
      _objSignalMathOp5 = null;
    }
    if (_objSignalChannelStack6 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack6.GetXrpaId());
      _objSignalChannelStack6 = null;
    }
    if (_objSignalMathOp4 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp4.GetXrpaId());
      _objSignalMathOp4 = null;
    }
    if (_objSignalMathOp3 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp3.GetXrpaId());
      _objSignalMathOp3 = null;
    }
    if (_objSignalMathOp2 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp2.GetXrpaId());
      _objSignalMathOp2 = null;
    }
    if (_objSignalMathOp1 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp1.GetXrpaId());
      _objSignalMathOp1 = null;
    }
    if (_objSignalOscillator0 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator0.GetXrpaId());
      _objSignalOscillator0 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace SignalProcessingDataStore
