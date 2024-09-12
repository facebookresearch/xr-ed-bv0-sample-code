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

public class Pulse_B : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramFundamentalAmp = 1f;
  private float _paramFundamentalFq = 250f;
  private float _paramGain0 = 1f;
  private float _paramGain1 = 1f;
  private float _paramGain2 = 1f;
  private float _paramGain3 = 1f;
  private float _paramGain4 = 1f;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator0;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent5;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent6;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent7;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent10;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp1;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve2;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve3;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve4;
  private SignalProcessingDataStore.OutboundSignalEventCombiner _objSignalProcessingSignalEventCombiner8;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent11;
  private SignalProcessingDataStore.OutboundSignalMultiplexer _objSignalProcessingSignalMultiplexer9;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp12;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp14;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp16;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp18;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp13;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp15;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp17;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp19;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp20;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp21;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack22;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack23;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice24;

  public Pulse_B(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing) {
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

  ~Pulse_B() {
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

  public float GetGain0() {
    return _paramGain0;
  }

  public void SetGain0(float Gain0) {
    _paramGain0 = Gain0;
    if (_objSignalProcessingSignalMathOp12 != null) {
      _objSignalProcessingSignalMathOp12.SetOperandB(Gain0);
    }
  }

  public float GetGain1() {
    return _paramGain1;
  }

  public void SetGain1(float Gain1) {
    _paramGain1 = Gain1;
    if (_objSignalProcessingSignalMathOp14 != null) {
      _objSignalProcessingSignalMathOp14.SetOperandB(Gain1);
    }
  }

  public float GetGain2() {
    return _paramGain2;
  }

  public void SetGain2(float Gain2) {
    _paramGain2 = Gain2;
    if (_objSignalProcessingSignalMathOp16 != null) {
      _objSignalProcessingSignalMathOp16.SetOperandB(Gain2);
    }
  }

  public float GetGain3() {
    return _paramGain3;
  }

  public void SetGain3(float Gain3) {
    _paramGain3 = Gain3;
    if (_objSignalProcessingSignalMathOp18 != null) {
      _objSignalProcessingSignalMathOp18.SetOperandB(Gain3);
    }
  }

  public float GetGain4() {
    return _paramGain4;
  }

  public void SetGain4(float Gain4) {
    _paramGain4 = Gain4;
    if (_objSignalProcessingSignalMathOp20 != null) {
      _objSignalProcessingSignalMathOp20.SetOperandB(Gain4);
    }
  }

  void CreateObjects() {
    _objSignalProcessingSignalOscillator0 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalEvent5 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent5);
    _objSignalProcessingSignalEvent6 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent6);
    _objSignalProcessingSignalEvent7 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent7);
    _objSignalProcessingSignalEvent10 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent10);
    _objSignalProcessingSignalMathOp1 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalCurve2 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve2);
    _objSignalProcessingSignalCurve3 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve3);
    _objSignalProcessingSignalCurve4 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve4);
    _objSignalProcessingSignalEventCombiner8 = new SignalProcessingDataStore.OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalProcessingSignalEventCombiner8);
    _objSignalProcessingSignalEvent11 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent11);
    _objSignalProcessingSignalMultiplexer9 = new SignalProcessingDataStore.OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalProcessingSignalMultiplexer9);
    _objSignalProcessingSignalMathOp12 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp12);
    _objSignalProcessingSignalMathOp14 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp14);
    _objSignalProcessingSignalMathOp16 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp16);
    _objSignalProcessingSignalMathOp18 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp18);
    _objSignalProcessingSignalMathOp13 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp13);
    _objSignalProcessingSignalMathOp15 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp15);
    _objSignalProcessingSignalMathOp17 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp17);
    _objSignalProcessingSignalMathOp19 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp19);
    _objSignalProcessingSignalMathOp20 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp20);
    _objSignalProcessingSignalMathOp21 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp21);
    _objSignalProcessingSignalChannelStack22 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack22);
    _objSignalProcessingSignalChannelStack23 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack23);
    _objSignalProcessingSignalOutputDevice24 = new SignalProcessingDataStore.OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalProcessingSignalOutputDevice24);
    _objSignalProcessingSignalOscillator0.SetNumChannels(1);
    _objSignalProcessingSignalOscillator0.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(3));
    _objSignalProcessingSignalOscillator0.SetFrequency(_paramFundamentalFq);
    _objSignalProcessingSignalOscillator0.SetPulseWidth(0.5f);
    _objSignalProcessingSignalOscillator0.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp1.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp1.SetOperandANode(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalMathOp1.SetOperandB(_paramFundamentalAmp);
    _objSignalProcessingSignalMathOp1.SetNumChannels(1);
    _objSignalProcessingSignalMathOp1.SetNumOutputs(5);
    _objSignalProcessingSignalCurve2.SetSoftCurve(true);
    _objSignalProcessingSignalCurve2.SetNumSegments(5);
    _objSignalProcessingSignalCurve2.SetStartValue(0f);
    _objSignalProcessingSignalCurve2.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve2.SetSegmentLength1(0f);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue1(0.25f);
    _objSignalProcessingSignalCurve2.SetSegmentLength2(0.02f);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue2(0.25f);
    _objSignalProcessingSignalCurve2.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve2.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve2.SetAutoStart(true);
    _objSignalProcessingSignalCurve2.SetAutoLoop(false);
    _objSignalProcessingSignalCurve2.SetOnDoneEvent(_objSignalProcessingSignalEvent5);
    _objSignalProcessingSignalCurve2.SetNumOutputs(1);
    _objSignalProcessingSignalCurve3.SetSoftCurve(true);
    _objSignalProcessingSignalCurve3.SetNumSegments(5);
    _objSignalProcessingSignalCurve3.SetStartValue(0f);
    _objSignalProcessingSignalCurve3.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve3.SetSegmentLength1(0f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue1(0f);
    _objSignalProcessingSignalCurve3.SetSegmentLength2(0.08f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue2(0f);
    _objSignalProcessingSignalCurve3.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve3.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve3.SetAutoStart(false);
    _objSignalProcessingSignalCurve3.SetAutoLoop(false);
    _objSignalProcessingSignalCurve3.SetStartEvent(_objSignalProcessingSignalEvent5);
    _objSignalProcessingSignalCurve3.SetOnDoneEvent(_objSignalProcessingSignalEvent6);
    _objSignalProcessingSignalCurve3.SetNumOutputs(1);
    _objSignalProcessingSignalCurve4.SetSoftCurve(true);
    _objSignalProcessingSignalCurve4.SetNumSegments(5);
    _objSignalProcessingSignalCurve4.SetStartValue(0f);
    _objSignalProcessingSignalCurve4.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve4.SetSegmentLength1(0f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue1(1f);
    _objSignalProcessingSignalCurve4.SetSegmentLength2(0.01f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue2(1f);
    _objSignalProcessingSignalCurve4.SetSegmentLength3(0.02f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve4.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve4.SetAutoStart(false);
    _objSignalProcessingSignalCurve4.SetAutoLoop(false);
    _objSignalProcessingSignalCurve4.SetStartEvent(_objSignalProcessingSignalEvent6);
    _objSignalProcessingSignalCurve4.SetOnDoneEvent(_objSignalProcessingSignalEvent7);
    _objSignalProcessingSignalCurve4.SetNumOutputs(1);
    _objSignalProcessingSignalEventCombiner8.SetSrcEvent0(_objSignalProcessingSignalEvent5);
    _objSignalProcessingSignalEventCombiner8.SetSrcEvent1(_objSignalProcessingSignalEvent6);
    _objSignalProcessingSignalEventCombiner8.SetSrcEvent2(_objSignalProcessingSignalEvent7);
    _objSignalProcessingSignalEventCombiner8.SetOnEvent(_objSignalProcessingSignalEvent10);
    _objSignalProcessingSignalMultiplexer9.SetSrcNode0(_objSignalProcessingSignalCurve2);
    _objSignalProcessingSignalMultiplexer9.SetSrcNode1(_objSignalProcessingSignalCurve3);
    _objSignalProcessingSignalMultiplexer9.SetSrcNode2(_objSignalProcessingSignalCurve4);
    _objSignalProcessingSignalMultiplexer9.SetIncrementEvent(_objSignalProcessingSignalEvent10);
    _objSignalProcessingSignalMultiplexer9.SetAutoStart(true);
    _objSignalProcessingSignalMultiplexer9.SetNumChannels(1);
    _objSignalProcessingSignalMultiplexer9.SetOnDoneEvent(_objSignalProcessingSignalEvent11);
    _objSignalProcessingSignalMultiplexer9.SetNumOutputs(5);
    _objSignalProcessingSignalMathOp12.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp12.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp12.SetOperandB(_paramGain0);
    _objSignalProcessingSignalMathOp12.SetNumChannels(1);
    _objSignalProcessingSignalMathOp12.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp14.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp14.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp14.SetOperandB(_paramGain1);
    _objSignalProcessingSignalMathOp14.SetNumChannels(1);
    _objSignalProcessingSignalMathOp14.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp16.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp16.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp16.SetOperandB(_paramGain2);
    _objSignalProcessingSignalMathOp16.SetNumChannels(1);
    _objSignalProcessingSignalMathOp16.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp18.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp18.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp18.SetOperandB(_paramGain3);
    _objSignalProcessingSignalMathOp18.SetNumChannels(1);
    _objSignalProcessingSignalMathOp18.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp13.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp13.SetOperandANode(_objSignalProcessingSignalMathOp12);
    _objSignalProcessingSignalMathOp13.SetOperandBNode(_objSignalProcessingSignalMultiplexer9);
    _objSignalProcessingSignalMathOp13.SetNumChannels(1);
    _objSignalProcessingSignalMathOp13.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp15.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp15.SetOperandANode(_objSignalProcessingSignalMathOp14);
    _objSignalProcessingSignalMathOp15.SetOperandBNode(_objSignalProcessingSignalMultiplexer9);
    _objSignalProcessingSignalMathOp15.SetNumChannels(1);
    _objSignalProcessingSignalMathOp15.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp17.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp17.SetOperandANode(_objSignalProcessingSignalMathOp16);
    _objSignalProcessingSignalMathOp17.SetOperandBNode(_objSignalProcessingSignalMultiplexer9);
    _objSignalProcessingSignalMathOp17.SetNumChannels(1);
    _objSignalProcessingSignalMathOp17.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp19.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp19.SetOperandANode(_objSignalProcessingSignalMathOp18);
    _objSignalProcessingSignalMathOp19.SetOperandBNode(_objSignalProcessingSignalMultiplexer9);
    _objSignalProcessingSignalMathOp19.SetNumChannels(1);
    _objSignalProcessingSignalMathOp19.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp20.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp20.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp20.SetOperandB(_paramGain4);
    _objSignalProcessingSignalMathOp20.SetNumChannels(1);
    _objSignalProcessingSignalMathOp20.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp21.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp21.SetOperandANode(_objSignalProcessingSignalMathOp20);
    _objSignalProcessingSignalMathOp21.SetOperandBNode(_objSignalProcessingSignalMultiplexer9);
    _objSignalProcessingSignalMathOp21.SetNumChannels(1);
    _objSignalProcessingSignalMathOp21.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack22.SetSrcNode0(_objSignalProcessingSignalMathOp13);
    _objSignalProcessingSignalChannelStack22.SetSrcNode1(_objSignalProcessingSignalMathOp15);
    _objSignalProcessingSignalChannelStack22.SetSrcNode2(_objSignalProcessingSignalMathOp17);
    _objSignalProcessingSignalChannelStack22.SetSrcNode3(_objSignalProcessingSignalMathOp19);
    _objSignalProcessingSignalChannelStack22.SetNumChannels(4);
    _objSignalProcessingSignalChannelStack22.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack23.SetSrcNode0(_objSignalProcessingSignalChannelStack22);
    _objSignalProcessingSignalChannelStack23.SetSrcNode1(_objSignalProcessingSignalMathOp21);
    _objSignalProcessingSignalChannelStack23.SetNumChannels(5);
    _objSignalProcessingSignalChannelStack23.SetNumOutputs(1);
    _objSignalProcessingSignalOutputDevice24.SetSrcNode(_objSignalProcessingSignalChannelStack23);
    _objSignalProcessingSignalOutputDevice24.SetDeviceNameFilter("HDK-1");
    _objSignalProcessingSignalOutputDevice24.SetChannelOffset(0);
    if (_objSignalProcessingSignalEvent11 != null) {
      _objSignalProcessingSignalEvent11.OnReceiveEvent((_, _) => Terminate());
    }
  }

  void DestroyObjects() {
    if (_objSignalProcessingSignalOutputDevice24 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalProcessingSignalOutputDevice24.GetXrpaId());
      _objSignalProcessingSignalOutputDevice24 = null;
    }
    if (_objSignalProcessingSignalChannelStack23 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack23.GetXrpaId());
      _objSignalProcessingSignalChannelStack23 = null;
    }
    if (_objSignalProcessingSignalChannelStack22 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack22.GetXrpaId());
      _objSignalProcessingSignalChannelStack22 = null;
    }
    if (_objSignalProcessingSignalMathOp21 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp21.GetXrpaId());
      _objSignalProcessingSignalMathOp21 = null;
    }
    if (_objSignalProcessingSignalMathOp20 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp20.GetXrpaId());
      _objSignalProcessingSignalMathOp20 = null;
    }
    if (_objSignalProcessingSignalMathOp19 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp19.GetXrpaId());
      _objSignalProcessingSignalMathOp19 = null;
    }
    if (_objSignalProcessingSignalMathOp17 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp17.GetXrpaId());
      _objSignalProcessingSignalMathOp17 = null;
    }
    if (_objSignalProcessingSignalMathOp15 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp15.GetXrpaId());
      _objSignalProcessingSignalMathOp15 = null;
    }
    if (_objSignalProcessingSignalMathOp13 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp13.GetXrpaId());
      _objSignalProcessingSignalMathOp13 = null;
    }
    if (_objSignalProcessingSignalMathOp18 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp18.GetXrpaId());
      _objSignalProcessingSignalMathOp18 = null;
    }
    if (_objSignalProcessingSignalMathOp16 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp16.GetXrpaId());
      _objSignalProcessingSignalMathOp16 = null;
    }
    if (_objSignalProcessingSignalMathOp14 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp14.GetXrpaId());
      _objSignalProcessingSignalMathOp14 = null;
    }
    if (_objSignalProcessingSignalMathOp12 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp12.GetXrpaId());
      _objSignalProcessingSignalMathOp12 = null;
    }
    if (_objSignalProcessingSignalMultiplexer9 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalProcessingSignalMultiplexer9.GetXrpaId());
      _objSignalProcessingSignalMultiplexer9 = null;
    }
    if (_objSignalProcessingSignalEvent11 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent11.GetXrpaId());
      _objSignalProcessingSignalEvent11 = null;
    }
    if (_objSignalProcessingSignalEventCombiner8 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalProcessingSignalEventCombiner8.GetXrpaId());
      _objSignalProcessingSignalEventCombiner8 = null;
    }
    if (_objSignalProcessingSignalCurve4 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve4.GetXrpaId());
      _objSignalProcessingSignalCurve4 = null;
    }
    if (_objSignalProcessingSignalCurve3 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve3.GetXrpaId());
      _objSignalProcessingSignalCurve3 = null;
    }
    if (_objSignalProcessingSignalCurve2 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve2.GetXrpaId());
      _objSignalProcessingSignalCurve2 = null;
    }
    if (_objSignalProcessingSignalMathOp1 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp1.GetXrpaId());
      _objSignalProcessingSignalMathOp1 = null;
    }
    if (_objSignalProcessingSignalEvent10 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent10.GetXrpaId());
      _objSignalProcessingSignalEvent10 = null;
    }
    if (_objSignalProcessingSignalEvent7 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent7.GetXrpaId());
      _objSignalProcessingSignalEvent7 = null;
    }
    if (_objSignalProcessingSignalEvent6 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent6.GetXrpaId());
      _objSignalProcessingSignalEvent6 = null;
    }
    if (_objSignalProcessingSignalEvent5 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent5.GetXrpaId());
      _objSignalProcessingSignalEvent5 = null;
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
