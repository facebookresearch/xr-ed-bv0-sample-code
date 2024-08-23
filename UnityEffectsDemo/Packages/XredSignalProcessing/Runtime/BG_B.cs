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

public class BG_B : IDisposable {
  private SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramGain0 = 1f;
  private float _paramGain1 = 1f;
  private float _paramGain2 = 1f;
  private float _paramGain3 = 1f;
  private float _paramGain4 = 1f;
  private OutboundSignalOscillator _objSignalOscillator9;
  private OutboundSignalMathOp _objSignalMathOp10;
  private OutboundSignalOscillator _objSignalOscillator11;
  private OutboundSignalMathOp _objSignalMathOp12;
  private OutboundSignalMathOp _objSignalMathOp13;
  private OutboundSignalMathOp _objSignalMathOp14;
  private OutboundSignalMathOp _objSignalMathOp15;
  private OutboundSignalMathOp _objSignalMathOp16;
  private OutboundSignalChannelStack _objSignalChannelStack18;
  private OutboundSignalMathOp _objSignalMathOp17;
  private OutboundSignalChannelStack _objSignalChannelStack19;
  private OutboundSignalOutputDevice _objSignalOutputDevice20;

  public BG_B(SignalProcessingDataStore datastore) {
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

  ~BG_B() {
    Dispose(false);
  }

  public float GetGain0() {
    return _paramGain0;
  }

  public void SetGain0(float Gain0) {
    _paramGain0 = Gain0;
    if (_objSignalMathOp13 != null) {
      _objSignalMathOp13.SetOperandB(Gain0);
    }
  }

  public float GetGain1() {
    return _paramGain1;
  }

  public void SetGain1(float Gain1) {
    _paramGain1 = Gain1;
    if (_objSignalMathOp14 != null) {
      _objSignalMathOp14.SetOperandB(Gain1);
    }
  }

  public float GetGain2() {
    return _paramGain2;
  }

  public void SetGain2(float Gain2) {
    _paramGain2 = Gain2;
    if (_objSignalMathOp15 != null) {
      _objSignalMathOp15.SetOperandB(Gain2);
    }
  }

  public float GetGain3() {
    return _paramGain3;
  }

  public void SetGain3(float Gain3) {
    _paramGain3 = Gain3;
    if (_objSignalMathOp16 != null) {
      _objSignalMathOp16.SetOperandB(Gain3);
    }
  }

  public float GetGain4() {
    return _paramGain4;
  }

  public void SetGain4(float Gain4) {
    _paramGain4 = Gain4;
    if (_objSignalMathOp17 != null) {
      _objSignalMathOp17.SetOperandB(Gain4);
    }
  }

  void CreateObjects() {
    _objSignalOscillator9 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator9);
    _objSignalMathOp10 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp10);
    _objSignalOscillator11 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator11);
    _objSignalMathOp12 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp12);
    _objSignalMathOp13 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp13);
    _objSignalMathOp14 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp14);
    _objSignalMathOp15 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp15);
    _objSignalMathOp16 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp16);
    _objSignalChannelStack18 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack18);
    _objSignalMathOp17 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp17);
    _objSignalChannelStack19 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack19);
    _objSignalOutputDevice20 = new OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalOutputDevice20);
    _objSignalOscillator9.SetNumChannels(1);
    _objSignalOscillator9.SetWaveformType((WaveformType)(uint)(3));
    _objSignalOscillator9.SetFrequency(200f);
    _objSignalOscillator9.SetPulseWidth(0.5f);
    _objSignalOscillator9.SetNumOutputs(1);
    _objSignalMathOp10.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp10.SetOperandANode(_objSignalOscillator9);
    _objSignalMathOp10.SetOperandB(0.09f);
    _objSignalMathOp10.SetNumChannels(1);
    _objSignalMathOp10.SetNumOutputs(1);
    _objSignalOscillator11.SetNumChannels(1);
    _objSignalOscillator11.SetWaveformType((WaveformType)(uint)(3));
    _objSignalOscillator11.SetFrequency(7f);
    _objSignalOscillator11.SetPulseWidth(0.5f);
    _objSignalOscillator11.SetNumOutputs(1);
    _objSignalMathOp12.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp12.SetOperandANode(_objSignalMathOp10);
    _objSignalMathOp12.SetOperandBNode(_objSignalOscillator11);
    _objSignalMathOp12.SetNumChannels(1);
    _objSignalMathOp12.SetNumOutputs(5);
    _objSignalMathOp13.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp13.SetOperandANode(_objSignalMathOp12);
    _objSignalMathOp13.SetOperandB(_paramGain0);
    _objSignalMathOp13.SetNumChannels(1);
    _objSignalMathOp13.SetNumOutputs(1);
    _objSignalMathOp14.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp14.SetOperandANode(_objSignalMathOp12);
    _objSignalMathOp14.SetOperandB(_paramGain1);
    _objSignalMathOp14.SetNumChannels(1);
    _objSignalMathOp14.SetNumOutputs(1);
    _objSignalMathOp15.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp15.SetOperandANode(_objSignalMathOp12);
    _objSignalMathOp15.SetOperandB(_paramGain2);
    _objSignalMathOp15.SetNumChannels(1);
    _objSignalMathOp15.SetNumOutputs(1);
    _objSignalMathOp16.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp16.SetOperandANode(_objSignalMathOp12);
    _objSignalMathOp16.SetOperandB(_paramGain3);
    _objSignalMathOp16.SetNumChannels(1);
    _objSignalMathOp16.SetNumOutputs(1);
    _objSignalChannelStack18.SetSrcNode0(_objSignalMathOp13);
    _objSignalChannelStack18.SetSrcNode1(_objSignalMathOp14);
    _objSignalChannelStack18.SetSrcNode2(_objSignalMathOp15);
    _objSignalChannelStack18.SetSrcNode3(_objSignalMathOp16);
    _objSignalChannelStack18.SetNumChannels(4);
    _objSignalChannelStack18.SetNumOutputs(1);
    _objSignalMathOp17.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp17.SetOperandANode(_objSignalMathOp12);
    _objSignalMathOp17.SetOperandB(_paramGain4);
    _objSignalMathOp17.SetNumChannels(1);
    _objSignalMathOp17.SetNumOutputs(1);
    _objSignalChannelStack19.SetSrcNode0(_objSignalChannelStack18);
    _objSignalChannelStack19.SetSrcNode1(_objSignalMathOp17);
    _objSignalChannelStack19.SetNumChannels(5);
    _objSignalChannelStack19.SetNumOutputs(1);
    _objSignalOutputDevice20.SetSrcNode(_objSignalChannelStack19);
    _objSignalOutputDevice20.SetDeviceNameFilter("HDK-1");
    _objSignalOutputDevice20.SetChannelOffset(0);
  }

  void DestroyObjects() {
    if (_objSignalOutputDevice20 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalOutputDevice20.GetXrpaId());
      _objSignalOutputDevice20 = null;
    }
    if (_objSignalChannelStack19 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack19.GetXrpaId());
      _objSignalChannelStack19 = null;
    }
    if (_objSignalMathOp17 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp17.GetXrpaId());
      _objSignalMathOp17 = null;
    }
    if (_objSignalChannelStack18 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack18.GetXrpaId());
      _objSignalChannelStack18 = null;
    }
    if (_objSignalMathOp16 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp16.GetXrpaId());
      _objSignalMathOp16 = null;
    }
    if (_objSignalMathOp15 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp15.GetXrpaId());
      _objSignalMathOp15 = null;
    }
    if (_objSignalMathOp14 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp14.GetXrpaId());
      _objSignalMathOp14 = null;
    }
    if (_objSignalMathOp13 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp13.GetXrpaId());
      _objSignalMathOp13 = null;
    }
    if (_objSignalMathOp12 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp12.GetXrpaId());
      _objSignalMathOp12 = null;
    }
    if (_objSignalOscillator11 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator11.GetXrpaId());
      _objSignalOscillator11 = null;
    }
    if (_objSignalMathOp10 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp10.GetXrpaId());
      _objSignalMathOp10 = null;
    }
    if (_objSignalOscillator9 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator9.GetXrpaId());
      _objSignalOscillator9 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace SignalProcessingDataStore
