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

public class LoopingPattern : IDisposable {
  private SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramFundamentalAmp = 1f;
  private float _paramFundamentalFq = 170f;
  private float _paramGain0 = 1f;
  private float _paramGain1 = 1f;
  private float _paramLFOAmp = 1f;
  private float _paramLFOFq = 5f;
  private float _paramPauseDuration = 0.25f;
  private float _paramPulseDuration = 0.5f;
  private OutboundSignalOscillator _objSignalOscillator128;
  private OutboundSignalOscillator _objSignalOscillator130;
  private OutboundSignalEvent _objSignalEvent136;
  private OutboundSignalEvent _objSignalEvent141;
  private OutboundSignalEvent _objSignalEvent137;
  private OutboundSignalEvent _objSignalEvent140;
  private OutboundSignalMathOp _objSignalMathOp129;
  private OutboundSignalMathOp _objSignalMathOp131;
  private OutboundSignalCurve _objSignalCurve134;
  private OutboundSignalCurve _objSignalCurve135;
  private OutboundSignalEventCombiner _objSignalEventCombiner138;
  private OutboundSignalMathOp _objSignalMathOp132;
  private OutboundSignalMultiplexer _objSignalMultiplexer139;
  private OutboundSignalMathOp _objSignalMathOp143;
  private OutboundSignalMathOp _objSignalMathOp145;
  private OutboundSignalMathOp _objSignalMathOp144;
  private OutboundSignalMathOp _objSignalMathOp146;
  private OutboundSignalChannelStack _objSignalChannelStack147;
  private OutboundSignalEvent _objSignalEvent142;
  private OutboundSignalOutputDevice _objSignalOutputDevice148;

  public LoopingPattern(SignalProcessingDataStore datastore) {
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

  ~LoopingPattern() {
    Dispose(false);
  }

  public float GetFundamentalAmp() {
    return _paramFundamentalAmp;
  }

  public void SetFundamentalAmp(float FundamentalAmp) {
    _paramFundamentalAmp = FundamentalAmp;
    if (_objSignalMathOp129 != null) {
      _objSignalMathOp129.SetOperandB(FundamentalAmp);
    }
    if (_objSignalCurve134 != null) {
      _objSignalCurve134.SetSegmentEndValue1(FundamentalAmp);
    }
    if (_objSignalCurve134 != null) {
      _objSignalCurve134.SetSegmentEndValue2(FundamentalAmp);
    }
  }

  public float GetFundamentalFq() {
    return _paramFundamentalFq;
  }

  public void SetFundamentalFq(float FundamentalFq) {
    _paramFundamentalFq = FundamentalFq;
    if (_objSignalOscillator128 != null) {
      _objSignalOscillator128.SetFrequency(FundamentalFq);
    }
  }

  public float GetGain0() {
    return _paramGain0;
  }

  public void SetGain0(float Gain0) {
    _paramGain0 = Gain0;
    if (_objSignalMathOp144 != null) {
      _objSignalMathOp144.SetOperandB(Gain0);
    }
  }

  public float GetGain1() {
    return _paramGain1;
  }

  public void SetGain1(float Gain1) {
    _paramGain1 = Gain1;
    if (_objSignalMathOp146 != null) {
      _objSignalMathOp146.SetOperandB(Gain1);
    }
  }

  public float GetLFOAmp() {
    return _paramLFOAmp;
  }

  public void SetLFOAmp(float LFOAmp) {
    _paramLFOAmp = LFOAmp;
    if (_objSignalMathOp131 != null) {
      _objSignalMathOp131.SetOperandB(LFOAmp);
    }
  }

  public float GetLFOFq() {
    return _paramLFOFq;
  }

  public void SetLFOFq(float LFOFq) {
    _paramLFOFq = LFOFq;
    if (_objSignalOscillator130 != null) {
      _objSignalOscillator130.SetFrequency(LFOFq);
    }
  }

  public float GetPauseDuration() {
    return _paramPauseDuration;
  }

  public void SetPauseDuration(float PauseDuration) {
    _paramPauseDuration = PauseDuration;
    if (_objSignalCurve135 != null) {
      _objSignalCurve135.SetSegmentLength2(PauseDuration);
    }
  }

  public float GetPulseDuration() {
    return _paramPulseDuration;
  }

  public void SetPulseDuration(float PulseDuration) {
    _paramPulseDuration = PulseDuration;
    if (_objSignalCurve134 != null) {
      _objSignalCurve134.SetSegmentLength2(PulseDuration);
    }
  }

  void CreateObjects() {
    _objSignalOscillator128 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator128);
    _objSignalOscillator130 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator130);
    _objSignalEvent136 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent136);
    _objSignalEvent141 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent141);
    _objSignalEvent137 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent137);
    _objSignalEvent140 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent140);
    _objSignalMathOp129 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp129);
    _objSignalMathOp131 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp131);
    _objSignalCurve134 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve134);
    _objSignalCurve135 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve135);
    _objSignalEventCombiner138 = new OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalEventCombiner138);
    _objSignalMathOp132 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp132);
    _objSignalMultiplexer139 = new OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalMultiplexer139);
    _objSignalMathOp143 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp143);
    _objSignalMathOp145 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp145);
    _objSignalMathOp144 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp144);
    _objSignalMathOp146 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp146);
    _objSignalChannelStack147 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack147);
    _objSignalEvent142 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent142);
    _objSignalOutputDevice148 = new OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalOutputDevice148);
    _objSignalOscillator128.SetNumChannels(1);
    _objSignalOscillator128.SetWaveformType((WaveformType)(uint)(3));
    _objSignalOscillator128.SetFrequency(_paramFundamentalFq);
    _objSignalOscillator128.SetPulseWidth(0.5f);
    _objSignalOscillator128.SetNumOutputs(1);
    _objSignalOscillator130.SetNumChannels(1);
    _objSignalOscillator130.SetWaveformType((WaveformType)(uint)(3));
    _objSignalOscillator130.SetFrequency(_paramLFOFq);
    _objSignalOscillator130.SetPulseWidth(0.5f);
    _objSignalOscillator130.SetNumOutputs(1);
    _objSignalMathOp129.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp129.SetOperandANode(_objSignalOscillator128);
    _objSignalMathOp129.SetOperandB(_paramFundamentalAmp);
    _objSignalMathOp129.SetNumChannels(1);
    _objSignalMathOp129.SetNumOutputs(1);
    _objSignalMathOp131.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp131.SetOperandANode(_objSignalOscillator130);
    _objSignalMathOp131.SetOperandB(_paramLFOAmp);
    _objSignalMathOp131.SetNumChannels(1);
    _objSignalMathOp131.SetNumOutputs(1);
    _objSignalCurve134.SetSoftCurve(true);
    _objSignalCurve134.SetNumSegments(5);
    _objSignalCurve134.SetStartValue(0f);
    _objSignalCurve134.SetSegmentLength0(0f);
    _objSignalCurve134.SetSegmentEndValue0(0f);
    _objSignalCurve134.SetSegmentLength1(0f);
    _objSignalCurve134.SetSegmentEndValue1(_paramFundamentalAmp);
    _objSignalCurve134.SetSegmentLength2(_paramPulseDuration);
    _objSignalCurve134.SetSegmentEndValue2(_paramFundamentalAmp);
    _objSignalCurve134.SetSegmentLength3(0f);
    _objSignalCurve134.SetSegmentEndValue3(0f);
    _objSignalCurve134.SetSegmentLength4(0f);
    _objSignalCurve134.SetSegmentEndValue4(0f);
    _objSignalCurve134.SetAutoStart(true);
    _objSignalCurve134.SetAutoLoop(false);
    _objSignalCurve134.SetOnDoneEvent(_objSignalEvent136);
    _objSignalCurve134.SetNumOutputs(1);
    _objSignalCurve134.SetStartEvent(_objSignalEvent141);
    _objSignalCurve135.SetSoftCurve(true);
    _objSignalCurve135.SetNumSegments(5);
    _objSignalCurve135.SetStartValue(0f);
    _objSignalCurve135.SetSegmentLength0(0f);
    _objSignalCurve135.SetSegmentEndValue0(0f);
    _objSignalCurve135.SetSegmentLength1(0f);
    _objSignalCurve135.SetSegmentEndValue1(0f);
    _objSignalCurve135.SetSegmentLength2(_paramPauseDuration);
    _objSignalCurve135.SetSegmentEndValue2(0f);
    _objSignalCurve135.SetSegmentLength3(0f);
    _objSignalCurve135.SetSegmentEndValue3(0f);
    _objSignalCurve135.SetSegmentLength4(0f);
    _objSignalCurve135.SetSegmentEndValue4(0f);
    _objSignalCurve135.SetAutoStart(false);
    _objSignalCurve135.SetAutoLoop(false);
    _objSignalCurve135.SetStartEvent(_objSignalEvent136);
    _objSignalCurve135.SetOnDoneEvent(_objSignalEvent137);
    _objSignalCurve135.SetNumOutputs(1);
    _objSignalEventCombiner138.SetSrcEvent0(_objSignalEvent136);
    _objSignalEventCombiner138.SetSrcEvent1(_objSignalEvent137);
    _objSignalEventCombiner138.SetOnEvent(_objSignalEvent140);
    _objSignalMathOp132.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp132.SetOperandANode(_objSignalMathOp129);
    _objSignalMathOp132.SetOperandBNode(_objSignalMathOp131);
    _objSignalMathOp132.SetNumChannels(1);
    _objSignalMathOp132.SetNumOutputs(2);
    _objSignalMultiplexer139.SetSrcNode0(_objSignalCurve134);
    _objSignalMultiplexer139.SetSrcNode1(_objSignalCurve135);
    _objSignalMultiplexer139.SetIncrementEvent(_objSignalEvent140);
    _objSignalMultiplexer139.SetAutoStart(true);
    _objSignalMultiplexer139.SetNumChannels(1);
    _objSignalMultiplexer139.SetOnDoneEvent(_objSignalEvent141);
    _objSignalMultiplexer139.SetStartEvent(_objSignalEvent141);
    _objSignalMultiplexer139.SetNumOutputs(2);
    _objSignalMathOp143.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp143.SetOperandANode(_objSignalMathOp132);
    _objSignalMathOp143.SetOperandBNode(_objSignalMultiplexer139);
    _objSignalMathOp143.SetNumChannels(1);
    _objSignalMathOp143.SetNumOutputs(1);
    _objSignalMathOp145.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp145.SetOperandANode(_objSignalMathOp132);
    _objSignalMathOp145.SetOperandBNode(_objSignalMultiplexer139);
    _objSignalMathOp145.SetNumChannels(1);
    _objSignalMathOp145.SetNumOutputs(1);
    _objSignalMathOp144.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp144.SetOperandANode(_objSignalMathOp143);
    _objSignalMathOp144.SetOperandB(_paramGain0);
    _objSignalMathOp144.SetNumChannels(1);
    _objSignalMathOp144.SetNumOutputs(1);
    _objSignalMathOp146.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp146.SetOperandANode(_objSignalMathOp145);
    _objSignalMathOp146.SetOperandB(_paramGain1);
    _objSignalMathOp146.SetNumChannels(1);
    _objSignalMathOp146.SetNumOutputs(1);
    _objSignalChannelStack147.SetSrcNode0(_objSignalMathOp144);
    _objSignalChannelStack147.SetSrcNode1(_objSignalMathOp146);
    _objSignalChannelStack147.SetNumChannels(2);
    _objSignalChannelStack147.SetNumOutputs(1);
    _objSignalOutputDevice148.SetSrcNode(_objSignalChannelStack147);
    _objSignalOutputDevice148.SetDeviceNameFilter("BuzzDuino");
    _objSignalOutputDevice148.SetChannelOffset(0);
    if (_objSignalEvent142 != null) {
      _objSignalEvent142.OnReceiveEvent((_, _) => Terminate());
    }
  }

  void DestroyObjects() {
    if (_objSignalOutputDevice148 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalOutputDevice148.GetXrpaId());
      _objSignalOutputDevice148 = null;
    }
    if (_objSignalEvent142 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent142.GetXrpaId());
      _objSignalEvent142 = null;
    }
    if (_objSignalChannelStack147 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack147.GetXrpaId());
      _objSignalChannelStack147 = null;
    }
    if (_objSignalMathOp146 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp146.GetXrpaId());
      _objSignalMathOp146 = null;
    }
    if (_objSignalMathOp144 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp144.GetXrpaId());
      _objSignalMathOp144 = null;
    }
    if (_objSignalMathOp145 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp145.GetXrpaId());
      _objSignalMathOp145 = null;
    }
    if (_objSignalMathOp143 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp143.GetXrpaId());
      _objSignalMathOp143 = null;
    }
    if (_objSignalMultiplexer139 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalMultiplexer139.GetXrpaId());
      _objSignalMultiplexer139 = null;
    }
    if (_objSignalMathOp132 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp132.GetXrpaId());
      _objSignalMathOp132 = null;
    }
    if (_objSignalEventCombiner138 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalEventCombiner138.GetXrpaId());
      _objSignalEventCombiner138 = null;
    }
    if (_objSignalCurve135 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve135.GetXrpaId());
      _objSignalCurve135 = null;
    }
    if (_objSignalCurve134 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve134.GetXrpaId());
      _objSignalCurve134 = null;
    }
    if (_objSignalMathOp131 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp131.GetXrpaId());
      _objSignalMathOp131 = null;
    }
    if (_objSignalMathOp129 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp129.GetXrpaId());
      _objSignalMathOp129 = null;
    }
    if (_objSignalEvent140 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent140.GetXrpaId());
      _objSignalEvent140 = null;
    }
    if (_objSignalEvent137 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent137.GetXrpaId());
      _objSignalEvent137 = null;
    }
    if (_objSignalEvent141 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent141.GetXrpaId());
      _objSignalEvent141 = null;
    }
    if (_objSignalEvent136 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent136.GetXrpaId());
      _objSignalEvent136 = null;
    }
    if (_objSignalOscillator130 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator130.GetXrpaId());
      _objSignalOscillator130 = null;
    }
    if (_objSignalOscillator128 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator128.GetXrpaId());
      _objSignalOscillator128 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace SignalProcessingDataStore
