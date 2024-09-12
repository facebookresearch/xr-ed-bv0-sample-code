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

public class LoopingPattern : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramFundamentalAmp = 1f;
  private float _paramFundamentalFq = 170f;
  private float _paramGain0 = 1f;
  private float _paramGain1 = 1f;
  private float _paramLFOAmp = 1f;
  private float _paramLFOFq = 5f;
  private float _paramPauseDuration = 0.25f;
  private float _paramPulseDuration = 0.5f;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator0;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator2;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent7;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent12;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent8;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent11;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp1;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp3;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve5;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve6;
  private SignalProcessingDataStore.OutboundSignalEventCombiner _objSignalProcessingSignalEventCombiner9;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp4;
  private SignalProcessingDataStore.OutboundSignalMultiplexer _objSignalProcessingSignalMultiplexer10;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp13;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp15;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp14;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp16;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack17;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice18;

  public LoopingPattern(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing) {
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

  ~LoopingPattern() {
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
    if (_objSignalProcessingSignalCurve5 != null) {
      _objSignalProcessingSignalCurve5.SetSegmentEndValue1(FundamentalAmp);
    }
    if (_objSignalProcessingSignalCurve5 != null) {
      _objSignalProcessingSignalCurve5.SetSegmentEndValue2(FundamentalAmp);
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

  public float GetGain0() {
    return _paramGain0;
  }

  public void SetGain0(float Gain0) {
    _paramGain0 = Gain0;
    if (_objSignalProcessingSignalMathOp14 != null) {
      _objSignalProcessingSignalMathOp14.SetOperandB(Gain0);
    }
  }

  public float GetGain1() {
    return _paramGain1;
  }

  public void SetGain1(float Gain1) {
    _paramGain1 = Gain1;
    if (_objSignalProcessingSignalMathOp16 != null) {
      _objSignalProcessingSignalMathOp16.SetOperandB(Gain1);
    }
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

  public float GetPauseDuration() {
    return _paramPauseDuration;
  }

  public void SetPauseDuration(float PauseDuration) {
    _paramPauseDuration = PauseDuration;
    if (_objSignalProcessingSignalCurve6 != null) {
      _objSignalProcessingSignalCurve6.SetSegmentLength2(PauseDuration);
    }
  }

  public float GetPulseDuration() {
    return _paramPulseDuration;
  }

  public void SetPulseDuration(float PulseDuration) {
    _paramPulseDuration = PulseDuration;
    if (_objSignalProcessingSignalCurve5 != null) {
      _objSignalProcessingSignalCurve5.SetSegmentLength2(PulseDuration);
    }
  }

  void CreateObjects() {
    _objSignalProcessingSignalOscillator0 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalOscillator2 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator2);
    _objSignalProcessingSignalEvent7 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent7);
    _objSignalProcessingSignalEvent12 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent12);
    _objSignalProcessingSignalEvent8 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent8);
    _objSignalProcessingSignalEvent11 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent11);
    _objSignalProcessingSignalMathOp1 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp3 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalCurve5 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve5);
    _objSignalProcessingSignalCurve6 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve6);
    _objSignalProcessingSignalEventCombiner9 = new SignalProcessingDataStore.OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalProcessingSignalEventCombiner9);
    _objSignalProcessingSignalMathOp4 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp4);
    _objSignalProcessingSignalMultiplexer10 = new SignalProcessingDataStore.OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalProcessingSignalMultiplexer10);
    _objSignalProcessingSignalMathOp13 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp13);
    _objSignalProcessingSignalMathOp15 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp15);
    _objSignalProcessingSignalMathOp14 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp14);
    _objSignalProcessingSignalMathOp16 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp16);
    _objSignalProcessingSignalChannelStack17 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack17);
    _objSignalProcessingSignalOutputDevice18 = new SignalProcessingDataStore.OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalProcessingSignalOutputDevice18);
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
    _objSignalProcessingSignalMathOp1.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp3.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp3.SetOperandANode(_objSignalProcessingSignalOscillator2);
    _objSignalProcessingSignalMathOp3.SetOperandB(_paramLFOAmp);
    _objSignalProcessingSignalMathOp3.SetNumChannels(1);
    _objSignalProcessingSignalMathOp3.SetNumOutputs(1);
    _objSignalProcessingSignalCurve5.SetSoftCurve(true);
    _objSignalProcessingSignalCurve5.SetNumSegments(5);
    _objSignalProcessingSignalCurve5.SetStartValue(0f);
    _objSignalProcessingSignalCurve5.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve5.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve5.SetSegmentLength1(0f);
    _objSignalProcessingSignalCurve5.SetSegmentEndValue1(_paramFundamentalAmp);
    _objSignalProcessingSignalCurve5.SetSegmentLength2(_paramPulseDuration);
    _objSignalProcessingSignalCurve5.SetSegmentEndValue2(_paramFundamentalAmp);
    _objSignalProcessingSignalCurve5.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve5.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve5.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve5.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve5.SetAutoStart(true);
    _objSignalProcessingSignalCurve5.SetAutoLoop(false);
    _objSignalProcessingSignalCurve5.SetOnDoneEvent(_objSignalProcessingSignalEvent7);
    _objSignalProcessingSignalCurve5.SetNumOutputs(1);
    _objSignalProcessingSignalCurve5.SetStartEvent(_objSignalProcessingSignalEvent12);
    _objSignalProcessingSignalCurve6.SetSoftCurve(true);
    _objSignalProcessingSignalCurve6.SetNumSegments(5);
    _objSignalProcessingSignalCurve6.SetStartValue(0f);
    _objSignalProcessingSignalCurve6.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve6.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve6.SetSegmentLength1(0f);
    _objSignalProcessingSignalCurve6.SetSegmentEndValue1(0f);
    _objSignalProcessingSignalCurve6.SetSegmentLength2(_paramPauseDuration);
    _objSignalProcessingSignalCurve6.SetSegmentEndValue2(0f);
    _objSignalProcessingSignalCurve6.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve6.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve6.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve6.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve6.SetAutoStart(false);
    _objSignalProcessingSignalCurve6.SetAutoLoop(false);
    _objSignalProcessingSignalCurve6.SetStartEvent(_objSignalProcessingSignalEvent7);
    _objSignalProcessingSignalCurve6.SetOnDoneEvent(_objSignalProcessingSignalEvent8);
    _objSignalProcessingSignalCurve6.SetNumOutputs(1);
    _objSignalProcessingSignalEventCombiner9.SetSrcEvent0(_objSignalProcessingSignalEvent7);
    _objSignalProcessingSignalEventCombiner9.SetSrcEvent1(_objSignalProcessingSignalEvent8);
    _objSignalProcessingSignalEventCombiner9.SetOnEvent(_objSignalProcessingSignalEvent11);
    _objSignalProcessingSignalMathOp4.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp4.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp4.SetOperandBNode(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalMathOp4.SetNumChannels(1);
    _objSignalProcessingSignalMathOp4.SetNumOutputs(2);
    _objSignalProcessingSignalMultiplexer10.SetSrcNode0(_objSignalProcessingSignalCurve5);
    _objSignalProcessingSignalMultiplexer10.SetSrcNode1(_objSignalProcessingSignalCurve6);
    _objSignalProcessingSignalMultiplexer10.SetIncrementEvent(_objSignalProcessingSignalEvent11);
    _objSignalProcessingSignalMultiplexer10.SetAutoStart(true);
    _objSignalProcessingSignalMultiplexer10.SetNumChannels(1);
    _objSignalProcessingSignalMultiplexer10.SetOnDoneEvent(_objSignalProcessingSignalEvent12);
    _objSignalProcessingSignalMultiplexer10.SetStartEvent(_objSignalProcessingSignalEvent12);
    _objSignalProcessingSignalMultiplexer10.SetNumOutputs(2);
    _objSignalProcessingSignalMathOp13.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp13.SetOperandANode(_objSignalProcessingSignalMathOp4);
    _objSignalProcessingSignalMathOp13.SetOperandBNode(_objSignalProcessingSignalMultiplexer10);
    _objSignalProcessingSignalMathOp13.SetNumChannels(1);
    _objSignalProcessingSignalMathOp13.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp15.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp15.SetOperandANode(_objSignalProcessingSignalMathOp4);
    _objSignalProcessingSignalMathOp15.SetOperandBNode(_objSignalProcessingSignalMultiplexer10);
    _objSignalProcessingSignalMathOp15.SetNumChannels(1);
    _objSignalProcessingSignalMathOp15.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp14.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp14.SetOperandANode(_objSignalProcessingSignalMathOp13);
    _objSignalProcessingSignalMathOp14.SetOperandB(_paramGain0);
    _objSignalProcessingSignalMathOp14.SetNumChannels(1);
    _objSignalProcessingSignalMathOp14.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp16.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp16.SetOperandANode(_objSignalProcessingSignalMathOp15);
    _objSignalProcessingSignalMathOp16.SetOperandB(_paramGain1);
    _objSignalProcessingSignalMathOp16.SetNumChannels(1);
    _objSignalProcessingSignalMathOp16.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack17.SetSrcNode0(_objSignalProcessingSignalMathOp14);
    _objSignalProcessingSignalChannelStack17.SetSrcNode1(_objSignalProcessingSignalMathOp16);
    _objSignalProcessingSignalChannelStack17.SetNumChannels(2);
    _objSignalProcessingSignalChannelStack17.SetNumOutputs(1);
    _objSignalProcessingSignalOutputDevice18.SetSrcNode(_objSignalProcessingSignalChannelStack17);
    _objSignalProcessingSignalOutputDevice18.SetDeviceNameFilter("BuzzDuino");
    _objSignalProcessingSignalOutputDevice18.SetChannelOffset(0);
  }

  void DestroyObjects() {
    if (_objSignalProcessingSignalOutputDevice18 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalProcessingSignalOutputDevice18.GetXrpaId());
      _objSignalProcessingSignalOutputDevice18 = null;
    }
    if (_objSignalProcessingSignalChannelStack17 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack17.GetXrpaId());
      _objSignalProcessingSignalChannelStack17 = null;
    }
    if (_objSignalProcessingSignalMathOp16 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp16.GetXrpaId());
      _objSignalProcessingSignalMathOp16 = null;
    }
    if (_objSignalProcessingSignalMathOp14 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp14.GetXrpaId());
      _objSignalProcessingSignalMathOp14 = null;
    }
    if (_objSignalProcessingSignalMathOp15 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp15.GetXrpaId());
      _objSignalProcessingSignalMathOp15 = null;
    }
    if (_objSignalProcessingSignalMathOp13 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp13.GetXrpaId());
      _objSignalProcessingSignalMathOp13 = null;
    }
    if (_objSignalProcessingSignalMultiplexer10 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalProcessingSignalMultiplexer10.GetXrpaId());
      _objSignalProcessingSignalMultiplexer10 = null;
    }
    if (_objSignalProcessingSignalMathOp4 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp4.GetXrpaId());
      _objSignalProcessingSignalMathOp4 = null;
    }
    if (_objSignalProcessingSignalEventCombiner9 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalProcessingSignalEventCombiner9.GetXrpaId());
      _objSignalProcessingSignalEventCombiner9 = null;
    }
    if (_objSignalProcessingSignalCurve6 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve6.GetXrpaId());
      _objSignalProcessingSignalCurve6 = null;
    }
    if (_objSignalProcessingSignalCurve5 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve5.GetXrpaId());
      _objSignalProcessingSignalCurve5 = null;
    }
    if (_objSignalProcessingSignalMathOp3 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp3.GetXrpaId());
      _objSignalProcessingSignalMathOp3 = null;
    }
    if (_objSignalProcessingSignalMathOp1 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp1.GetXrpaId());
      _objSignalProcessingSignalMathOp1 = null;
    }
    if (_objSignalProcessingSignalEvent11 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent11.GetXrpaId());
      _objSignalProcessingSignalEvent11 = null;
    }
    if (_objSignalProcessingSignalEvent8 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent8.GetXrpaId());
      _objSignalProcessingSignalEvent8 = null;
    }
    if (_objSignalProcessingSignalEvent12 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent12.GetXrpaId());
      _objSignalProcessingSignalEvent12 = null;
    }
    if (_objSignalProcessingSignalEvent7 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent7.GetXrpaId());
      _objSignalProcessingSignalEvent7 = null;
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
