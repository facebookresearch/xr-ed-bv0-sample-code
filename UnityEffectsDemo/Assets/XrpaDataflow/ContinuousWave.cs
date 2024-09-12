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

public class ContinuousWave : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramFundamentalAmp = 1f;
  private float _paramFundamentalFq = 170f;
  private float _paramGainChannel0 = 1f;
  private float _paramGainChannel1 = 1f;
  private float _paramLFOAmp = 1f;
  private float _paramLFOFq = 5f;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator0;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator2;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp1;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp3;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent5;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve4;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp6;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp8;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp7;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp9;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack10;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice11;

  public ContinuousWave(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing) {
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

  ~ContinuousWave() {
    Dispose(false);
  }

  public float GetFundamentalAmp() {
    return _paramFundamentalAmp;
  }

  public void SetFundamentalAmp(float FundamentalAmp) {
    _paramFundamentalAmp = FundamentalAmp;
    if (_objSignalProcessingSignalMathOp1 != null) {
      _objSignalProcessingSignalMathOp1.SetOperandB(FundamentalAmp);
    }
    if (_objSignalProcessingSignalCurve4 != null) {
      _objSignalProcessingSignalCurve4.SetSegmentEndValue1(FundamentalAmp);
    }
    if (_objSignalProcessingSignalCurve4 != null) {
      _objSignalProcessingSignalCurve4.SetSegmentEndValue2(FundamentalAmp);
    }
  }

  public float GetFundamentalFq() {
    return _paramFundamentalFq;
  }

  public void SetFundamentalFq(float FundamentalFq) {
    _paramFundamentalFq = FundamentalFq;
    if (_objSignalProcessingSignalOscillator0 != null) {
      _objSignalProcessingSignalOscillator0.SetFrequency(FundamentalFq);
    }
  }

  public float GetGainChannel0() {
    return _paramGainChannel0;
  }

  public void SetGainChannel0(float GainChannel0) {
    _paramGainChannel0 = GainChannel0;
  }

  public float GetGainChannel1() {
    return _paramGainChannel1;
  }

  public void SetGainChannel1(float GainChannel1) {
    _paramGainChannel1 = GainChannel1;
  }

  public float GetLFOAmp() {
    return _paramLFOAmp;
  }

  public void SetLFOAmp(float LFOAmp) {
    _paramLFOAmp = LFOAmp;
    if (_objSignalProcessingSignalMathOp3 != null) {
      _objSignalProcessingSignalMathOp3.SetOperandB(LFOAmp);
    }
  }

  public float GetLFOFq() {
    return _paramLFOFq;
  }

  public void SetLFOFq(float LFOFq) {
    _paramLFOFq = LFOFq;
    if (_objSignalProcessingSignalOscillator2 != null) {
      _objSignalProcessingSignalOscillator2.SetFrequency(LFOFq);
    }
  }

  void CreateObjects() {
    _objSignalProcessingSignalOscillator0 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalOscillator2 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator2);
    _objSignalProcessingSignalMathOp1 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp3 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalEvent5 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent5);
    _objSignalProcessingSignalCurve4 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve4);
    _objSignalProcessingSignalMathOp6 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp6);
    _objSignalProcessingSignalMathOp8 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp8);
    _objSignalProcessingSignalMathOp7 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp7);
    _objSignalProcessingSignalMathOp9 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp9);
    _objSignalProcessingSignalChannelStack10 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack10);
    _objSignalProcessingSignalOutputDevice11 = new SignalProcessingDataStore.OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalProcessingSignalOutputDevice11);
    _objSignalProcessingSignalOscillator0.SetNumChannels(1);
    _objSignalProcessingSignalOscillator0.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(3));
    _objSignalProcessingSignalOscillator0.SetFrequency(_paramFundamentalFq);
    _objSignalProcessingSignalOscillator0.SetPulseWidth(0.5f);
    _objSignalProcessingSignalOscillator0.SetNumOutputs(1);
    _objSignalProcessingSignalOscillator2.SetNumChannels(1);
    _objSignalProcessingSignalOscillator2.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(3));
    _objSignalProcessingSignalOscillator2.SetFrequency(_paramLFOFq);
    _objSignalProcessingSignalOscillator2.SetPulseWidth(0.5f);
    _objSignalProcessingSignalOscillator2.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp1.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp1.SetOperandANode(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalMathOp1.SetOperandB(_paramFundamentalAmp);
    _objSignalProcessingSignalMathOp1.SetNumChannels(1);
    _objSignalProcessingSignalMathOp1.SetNumOutputs(2);
    _objSignalProcessingSignalMathOp3.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp3.SetOperandANode(_objSignalProcessingSignalOscillator2);
    _objSignalProcessingSignalMathOp3.SetOperandB(_paramLFOAmp);
    _objSignalProcessingSignalMathOp3.SetNumChannels(1);
    _objSignalProcessingSignalMathOp3.SetNumOutputs(2);
    _objSignalProcessingSignalCurve4.SetSoftCurve(true);
    _objSignalProcessingSignalCurve4.SetNumSegments(5);
    _objSignalProcessingSignalCurve4.SetStartValue(0f);
    _objSignalProcessingSignalCurve4.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve4.SetSegmentLength1(0.005f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue1(_paramFundamentalAmp);
    _objSignalProcessingSignalCurve4.SetSegmentLength2(100f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue2(_paramFundamentalAmp);
    _objSignalProcessingSignalCurve4.SetSegmentLength3(0.005f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve4.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve4.SetAutoStart(true);
    _objSignalProcessingSignalCurve4.SetAutoLoop(false);
    _objSignalProcessingSignalCurve4.SetOnDoneEvent(_objSignalProcessingSignalEvent5);
    _objSignalProcessingSignalCurve4.SetNumOutputs(2);
    _objSignalProcessingSignalMathOp6.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp6.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp6.SetOperandBNode(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalMathOp6.SetNumChannels(1);
    _objSignalProcessingSignalMathOp6.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp8.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp8.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp8.SetOperandBNode(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalMathOp8.SetNumChannels(1);
    _objSignalProcessingSignalMathOp8.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp7.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp7.SetOperandANode(_objSignalProcessingSignalMathOp6);
    _objSignalProcessingSignalMathOp7.SetOperandBNode(_objSignalProcessingSignalCurve4);
    _objSignalProcessingSignalMathOp7.SetNumChannels(1);
    _objSignalProcessingSignalMathOp7.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp9.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp9.SetOperandANode(_objSignalProcessingSignalMathOp8);
    _objSignalProcessingSignalMathOp9.SetOperandBNode(_objSignalProcessingSignalCurve4);
    _objSignalProcessingSignalMathOp9.SetNumChannels(1);
    _objSignalProcessingSignalMathOp9.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack10.SetSrcNode0(_objSignalProcessingSignalMathOp7);
    _objSignalProcessingSignalChannelStack10.SetSrcNode1(_objSignalProcessingSignalMathOp9);
    _objSignalProcessingSignalChannelStack10.SetNumChannels(2);
    _objSignalProcessingSignalChannelStack10.SetNumOutputs(1);
    _objSignalProcessingSignalOutputDevice11.SetSrcNode(_objSignalProcessingSignalChannelStack10);
    _objSignalProcessingSignalOutputDevice11.SetDeviceNameFilter("BuzzDuino");
    _objSignalProcessingSignalOutputDevice11.SetChannelOffset(0);
    if (_objSignalProcessingSignalEvent5 != null) {
      _objSignalProcessingSignalEvent5.OnReceiveEvent((_, _) => Terminate());
    }
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
    if (_objSignalProcessingSignalMathOp9 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp9.GetXrpaId());
      _objSignalProcessingSignalMathOp9 = null;
    }
    if (_objSignalProcessingSignalMathOp7 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp7.GetXrpaId());
      _objSignalProcessingSignalMathOp7 = null;
    }
    if (_objSignalProcessingSignalMathOp8 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp8.GetXrpaId());
      _objSignalProcessingSignalMathOp8 = null;
    }
    if (_objSignalProcessingSignalMathOp6 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp6.GetXrpaId());
      _objSignalProcessingSignalMathOp6 = null;
    }
    if (_objSignalProcessingSignalCurve4 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve4.GetXrpaId());
      _objSignalProcessingSignalCurve4 = null;
    }
    if (_objSignalProcessingSignalEvent5 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent5.GetXrpaId());
      _objSignalProcessingSignalEvent5 = null;
    }
    if (_objSignalProcessingSignalMathOp3 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp3.GetXrpaId());
      _objSignalProcessingSignalMathOp3 = null;
    }
    if (_objSignalProcessingSignalMathOp1 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp1.GetXrpaId());
      _objSignalProcessingSignalMathOp1 = null;
    }
    if (_objSignalProcessingSignalOscillator2 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalProcessingSignalOscillator2.GetXrpaId());
      _objSignalProcessingSignalOscillator2 = null;
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
