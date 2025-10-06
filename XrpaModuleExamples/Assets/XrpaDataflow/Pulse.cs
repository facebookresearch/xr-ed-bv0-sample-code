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

public class Pulse : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramFundamentalAmp = 1f;
  private float _paramFundamentalFq = 170f;
  private float _paramHoldTime = 0.2f;
  private float _paramRampDownTime = 0.2f;
  private float _paramRampUpTime = 0.2f;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent3;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent6;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator0;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve2;
  private SignalProcessingDataStore.OutboundSignalEventCombiner _objSignalProcessingSignalEventCombiner4;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent7;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp1;
  private SignalProcessingDataStore.OutboundSignalMultiplexer _objSignalProcessingSignalMultiplexer5;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp8;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice9;

  public Pulse(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing) {
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

  ~Pulse() {
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

  public float GetHoldTime() {
    return _paramHoldTime;
  }

  public void SetHoldTime(float holdTime) {
    _paramHoldTime = holdTime;
    if (_objSignalProcessingSignalCurve2 != null) {
      _objSignalProcessingSignalCurve2.SetSegmentLength2(holdTime);
    }
  }

  public float GetRampDownTime() {
    return _paramRampDownTime;
  }

  public void SetRampDownTime(float rampDownTime) {
    _paramRampDownTime = rampDownTime;
    if (_objSignalProcessingSignalCurve2 != null) {
      _objSignalProcessingSignalCurve2.SetSegmentLength3(rampDownTime);
    }
  }

  public float GetRampUpTime() {
    return _paramRampUpTime;
  }

  public void SetRampUpTime(float rampUpTime) {
    _paramRampUpTime = rampUpTime;
    if (_objSignalProcessingSignalCurve2 != null) {
      _objSignalProcessingSignalCurve2.SetSegmentLength1(rampUpTime);
    }
  }

  void CreateObjects() {
    _objSignalProcessingSignalEvent3 = _datastoreSignalProcessing.SignalEvent.CreateObject();
    _objSignalProcessingSignalEvent6 = _datastoreSignalProcessing.SignalEvent.CreateObject();
    _objSignalProcessingSignalOscillator0 = _datastoreSignalProcessing.SignalOscillator.CreateObject();
    _objSignalProcessingSignalCurve2 = _datastoreSignalProcessing.SignalCurve.CreateObject();
    _objSignalProcessingSignalEventCombiner4 = _datastoreSignalProcessing.SignalEventCombiner.CreateObject();
    _objSignalProcessingSignalEvent7 = _datastoreSignalProcessing.SignalEvent.CreateObject();
    _objSignalProcessingSignalMathOp1 = _datastoreSignalProcessing.SignalMathOp.CreateObject();
    _objSignalProcessingSignalMultiplexer5 = _datastoreSignalProcessing.SignalMultiplexer.CreateObject();
    _objSignalProcessingSignalMathOp8 = _datastoreSignalProcessing.SignalMathOp.CreateObject();
    _objSignalProcessingSignalOutputDevice9 = _datastoreSignalProcessing.SignalOutputDevice.CreateObject();
    _objSignalProcessingSignalOscillator0.SetNumChannels(1);
    _objSignalProcessingSignalOscillator0.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(3));
    _objSignalProcessingSignalOscillator0.SetFrequency(_paramFundamentalFq);
    _objSignalProcessingSignalOscillator0.SetPulseWidth(0.5f);
    _objSignalProcessingSignalOscillator0.SetNumOutputs(1);
    _objSignalProcessingSignalCurve2.SetSoftCurve(true);
    _objSignalProcessingSignalCurve2.SetNumSegments(5);
    _objSignalProcessingSignalCurve2.SetStartValue(0f);
    _objSignalProcessingSignalCurve2.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve2.SetSegmentLength1(_paramRampUpTime);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue1(1f);
    _objSignalProcessingSignalCurve2.SetSegmentLength2(_paramHoldTime);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue2(1f);
    _objSignalProcessingSignalCurve2.SetSegmentLength3(_paramRampDownTime);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve2.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve2.SetAutoStart(true);
    _objSignalProcessingSignalCurve2.SetAutoLoop(false);
    _objSignalProcessingSignalCurve2.SetOnDoneEvent(_objSignalProcessingSignalEvent3.GetXrpaId());
    _objSignalProcessingSignalCurve2.SetNumOutputs(1);
    _objSignalProcessingSignalEventCombiner4.SetSrcEvent0(_objSignalProcessingSignalEvent3.GetXrpaId());
    _objSignalProcessingSignalEventCombiner4.SetOnEvent(_objSignalProcessingSignalEvent6.GetXrpaId());
    _objSignalProcessingSignalMathOp1.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp1.SetOperandANode(_objSignalProcessingSignalOscillator0.GetXrpaId());
    _objSignalProcessingSignalMathOp1.SetOperandB(_paramFundamentalAmp);
    _objSignalProcessingSignalMathOp1.SetNumChannels(1);
    _objSignalProcessingSignalMathOp1.SetNumOutputs(1);
    _objSignalProcessingSignalMultiplexer5.SetSrcNode0(_objSignalProcessingSignalCurve2.GetXrpaId());
    _objSignalProcessingSignalMultiplexer5.SetIncrementEvent(_objSignalProcessingSignalEvent6.GetXrpaId());
    _objSignalProcessingSignalMultiplexer5.SetAutoStart(true);
    _objSignalProcessingSignalMultiplexer5.SetNumChannels(1);
    _objSignalProcessingSignalMultiplexer5.SetOnDoneEvent(_objSignalProcessingSignalEvent7.GetXrpaId());
    _objSignalProcessingSignalMultiplexer5.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp8.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp8.SetOperandANode(_objSignalProcessingSignalMathOp1.GetXrpaId());
    _objSignalProcessingSignalMathOp8.SetOperandBNode(_objSignalProcessingSignalMultiplexer5.GetXrpaId());
    _objSignalProcessingSignalMathOp8.SetNumChannels(1);
    _objSignalProcessingSignalMathOp8.SetNumOutputs(1);
    _objSignalProcessingSignalOutputDevice9.SetSrcNode(_objSignalProcessingSignalMathOp8.GetXrpaId());
    _objSignalProcessingSignalOutputDevice9.SetOutputToSystemAudio(true);
    _objSignalProcessingSignalOutputDevice9.SetChannelOffset(0);
    if (_objSignalProcessingSignalEvent7 != null) {
      _objSignalProcessingSignalEvent7.OnReceiveEvent((_, _) => Terminate());
    }
  }

  void DestroyObjects() {
    if (_objSignalProcessingSignalOutputDevice9 != null) {
      _datastoreSignalProcessing.SignalOutputDevice.RemoveObject(_objSignalProcessingSignalOutputDevice9.GetXrpaId());
      _objSignalProcessingSignalOutputDevice9 = null;
    }
    if (_objSignalProcessingSignalMathOp8 != null) {
      _datastoreSignalProcessing.SignalMathOp.RemoveObject(_objSignalProcessingSignalMathOp8.GetXrpaId());
      _objSignalProcessingSignalMathOp8 = null;
    }
    if (_objSignalProcessingSignalMultiplexer5 != null) {
      _datastoreSignalProcessing.SignalMultiplexer.RemoveObject(_objSignalProcessingSignalMultiplexer5.GetXrpaId());
      _objSignalProcessingSignalMultiplexer5 = null;
    }
    if (_objSignalProcessingSignalMathOp1 != null) {
      _datastoreSignalProcessing.SignalMathOp.RemoveObject(_objSignalProcessingSignalMathOp1.GetXrpaId());
      _objSignalProcessingSignalMathOp1 = null;
    }
    if (_objSignalProcessingSignalEvent7 != null) {
      _datastoreSignalProcessing.SignalEvent.RemoveObject(_objSignalProcessingSignalEvent7.GetXrpaId());
      _objSignalProcessingSignalEvent7 = null;
    }
    if (_objSignalProcessingSignalEventCombiner4 != null) {
      _datastoreSignalProcessing.SignalEventCombiner.RemoveObject(_objSignalProcessingSignalEventCombiner4.GetXrpaId());
      _objSignalProcessingSignalEventCombiner4 = null;
    }
    if (_objSignalProcessingSignalCurve2 != null) {
      _datastoreSignalProcessing.SignalCurve.RemoveObject(_objSignalProcessingSignalCurve2.GetXrpaId());
      _objSignalProcessingSignalCurve2 = null;
    }
    if (_objSignalProcessingSignalOscillator0 != null) {
      _datastoreSignalProcessing.SignalOscillator.RemoveObject(_objSignalProcessingSignalOscillator0.GetXrpaId());
      _objSignalProcessingSignalOscillator0 = null;
    }
    if (_objSignalProcessingSignalEvent6 != null) {
      _datastoreSignalProcessing.SignalEvent.RemoveObject(_objSignalProcessingSignalEvent6.GetXrpaId());
      _objSignalProcessingSignalEvent6 = null;
    }
    if (_objSignalProcessingSignalEvent3 != null) {
      _datastoreSignalProcessing.SignalEvent.RemoveObject(_objSignalProcessingSignalEvent3.GetXrpaId());
      _objSignalProcessingSignalEvent3 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace XrpaDataflow
