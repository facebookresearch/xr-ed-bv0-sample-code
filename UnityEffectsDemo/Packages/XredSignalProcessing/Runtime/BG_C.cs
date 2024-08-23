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

public class BG_C : IDisposable {
  private SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramGain0 = 1f;
  private float _paramGain1 = 1f;
  private float _paramGain2 = 1f;
  private float _paramGain3 = 1f;
  private float _paramGain4 = 1f;
  private OutboundSignalOscillator _objSignalOscillator21;
  private OutboundSignalMathOp _objSignalMathOp22;
  private OutboundSignalOscillator _objSignalOscillator23;
  private OutboundSignalMathOp _objSignalMathOp24;
  private OutboundSignalMathOp _objSignalMathOp25;
  private OutboundSignalMathOp _objSignalMathOp26;
  private OutboundSignalMathOp _objSignalMathOp27;
  private OutboundSignalMathOp _objSignalMathOp28;
  private OutboundSignalChannelStack _objSignalChannelStack30;
  private OutboundSignalMathOp _objSignalMathOp29;
  private OutboundSignalChannelStack _objSignalChannelStack31;
  private OutboundSignalOutputDevice _objSignalOutputDevice32;

  public BG_C(SignalProcessingDataStore datastore) {
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

  ~BG_C() {
    Dispose(false);
  }

  public float GetGain0() {
    return _paramGain0;
  }

  public void SetGain0(float Gain0) {
    _paramGain0 = Gain0;
    if (_objSignalMathOp25 != null) {
      _objSignalMathOp25.SetOperandB(Gain0);
    }
  }

  public float GetGain1() {
    return _paramGain1;
  }

  public void SetGain1(float Gain1) {
    _paramGain1 = Gain1;
    if (_objSignalMathOp26 != null) {
      _objSignalMathOp26.SetOperandB(Gain1);
    }
  }

  public float GetGain2() {
    return _paramGain2;
  }

  public void SetGain2(float Gain2) {
    _paramGain2 = Gain2;
    if (_objSignalMathOp27 != null) {
      _objSignalMathOp27.SetOperandB(Gain2);
    }
  }

  public float GetGain3() {
    return _paramGain3;
  }

  public void SetGain3(float Gain3) {
    _paramGain3 = Gain3;
    if (_objSignalMathOp28 != null) {
      _objSignalMathOp28.SetOperandB(Gain3);
    }
  }

  public float GetGain4() {
    return _paramGain4;
  }

  public void SetGain4(float Gain4) {
    _paramGain4 = Gain4;
    if (_objSignalMathOp29 != null) {
      _objSignalMathOp29.SetOperandB(Gain4);
    }
  }

  void CreateObjects() {
    _objSignalOscillator21 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator21);
    _objSignalMathOp22 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp22);
    _objSignalOscillator23 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator23);
    _objSignalMathOp24 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp24);
    _objSignalMathOp25 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp25);
    _objSignalMathOp26 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp26);
    _objSignalMathOp27 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp27);
    _objSignalMathOp28 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp28);
    _objSignalChannelStack30 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack30);
    _objSignalMathOp29 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp29);
    _objSignalChannelStack31 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack31);
    _objSignalOutputDevice32 = new OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalOutputDevice32);
    _objSignalOscillator21.SetNumChannels(1);
    _objSignalOscillator21.SetWaveformType((WaveformType)(uint)(2));
    _objSignalOscillator21.SetFrequency(350f);
    _objSignalOscillator21.SetPulseWidth(0.5f);
    _objSignalOscillator21.SetNumOutputs(1);
    _objSignalMathOp22.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp22.SetOperandANode(_objSignalOscillator21);
    _objSignalMathOp22.SetOperandB(0.2f);
    _objSignalMathOp22.SetNumChannels(1);
    _objSignalMathOp22.SetNumOutputs(1);
    _objSignalOscillator23.SetNumChannels(1);
    _objSignalOscillator23.SetWaveformType((WaveformType)(uint)(3));
    _objSignalOscillator23.SetFrequency(2f);
    _objSignalOscillator23.SetPulseWidth(0.5f);
    _objSignalOscillator23.SetNumOutputs(1);
    _objSignalMathOp24.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp24.SetOperandANode(_objSignalMathOp22);
    _objSignalMathOp24.SetOperandBNode(_objSignalOscillator23);
    _objSignalMathOp24.SetNumChannels(1);
    _objSignalMathOp24.SetNumOutputs(5);
    _objSignalMathOp25.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp25.SetOperandANode(_objSignalMathOp24);
    _objSignalMathOp25.SetOperandB(_paramGain0);
    _objSignalMathOp25.SetNumChannels(1);
    _objSignalMathOp25.SetNumOutputs(1);
    _objSignalMathOp26.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp26.SetOperandANode(_objSignalMathOp24);
    _objSignalMathOp26.SetOperandB(_paramGain1);
    _objSignalMathOp26.SetNumChannels(1);
    _objSignalMathOp26.SetNumOutputs(1);
    _objSignalMathOp27.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp27.SetOperandANode(_objSignalMathOp24);
    _objSignalMathOp27.SetOperandB(_paramGain2);
    _objSignalMathOp27.SetNumChannels(1);
    _objSignalMathOp27.SetNumOutputs(1);
    _objSignalMathOp28.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp28.SetOperandANode(_objSignalMathOp24);
    _objSignalMathOp28.SetOperandB(_paramGain3);
    _objSignalMathOp28.SetNumChannels(1);
    _objSignalMathOp28.SetNumOutputs(1);
    _objSignalChannelStack30.SetSrcNode0(_objSignalMathOp25);
    _objSignalChannelStack30.SetSrcNode1(_objSignalMathOp26);
    _objSignalChannelStack30.SetSrcNode2(_objSignalMathOp27);
    _objSignalChannelStack30.SetSrcNode3(_objSignalMathOp28);
    _objSignalChannelStack30.SetNumChannels(4);
    _objSignalChannelStack30.SetNumOutputs(1);
    _objSignalMathOp29.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp29.SetOperandANode(_objSignalMathOp24);
    _objSignalMathOp29.SetOperandB(_paramGain4);
    _objSignalMathOp29.SetNumChannels(1);
    _objSignalMathOp29.SetNumOutputs(1);
    _objSignalChannelStack31.SetSrcNode0(_objSignalChannelStack30);
    _objSignalChannelStack31.SetSrcNode1(_objSignalMathOp29);
    _objSignalChannelStack31.SetNumChannels(5);
    _objSignalChannelStack31.SetNumOutputs(1);
    _objSignalOutputDevice32.SetSrcNode(_objSignalChannelStack31);
    _objSignalOutputDevice32.SetDeviceNameFilter("HDK-1");
    _objSignalOutputDevice32.SetChannelOffset(0);
  }

  void DestroyObjects() {
    if (_objSignalOutputDevice32 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalOutputDevice32.GetXrpaId());
      _objSignalOutputDevice32 = null;
    }
    if (_objSignalChannelStack31 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack31.GetXrpaId());
      _objSignalChannelStack31 = null;
    }
    if (_objSignalMathOp29 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp29.GetXrpaId());
      _objSignalMathOp29 = null;
    }
    if (_objSignalChannelStack30 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack30.GetXrpaId());
      _objSignalChannelStack30 = null;
    }
    if (_objSignalMathOp28 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp28.GetXrpaId());
      _objSignalMathOp28 = null;
    }
    if (_objSignalMathOp27 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp27.GetXrpaId());
      _objSignalMathOp27 = null;
    }
    if (_objSignalMathOp26 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp26.GetXrpaId());
      _objSignalMathOp26 = null;
    }
    if (_objSignalMathOp25 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp25.GetXrpaId());
      _objSignalMathOp25 = null;
    }
    if (_objSignalMathOp24 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp24.GetXrpaId());
      _objSignalMathOp24 = null;
    }
    if (_objSignalOscillator23 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator23.GetXrpaId());
      _objSignalOscillator23 = null;
    }
    if (_objSignalMathOp22 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp22.GetXrpaId());
      _objSignalMathOp22 = null;
    }
    if (_objSignalOscillator21 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator21.GetXrpaId());
      _objSignalOscillator21 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace SignalProcessingDataStore
