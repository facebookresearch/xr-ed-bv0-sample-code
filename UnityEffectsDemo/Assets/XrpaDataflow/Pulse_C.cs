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

public class Pulse_C : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramFundamentalAmp = 1f;
  private float _paramFundamentalFq = 350f;
  private float _paramGain0 = 1f;
  private float _paramGain1 = 1f;
  private float _paramGain2 = 1f;
  private float _paramGain3 = 1f;
  private float _paramGain4 = 1f;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator0;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent7;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent8;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent9;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent10;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent11;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent14;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp1;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve2;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve3;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve4;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve5;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve6;
  private SignalProcessingDataStore.OutboundSignalEventCombiner _objSignalProcessingSignalEventCombiner12;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent15;
  private SignalProcessingDataStore.OutboundSignalMultiplexer _objSignalProcessingSignalMultiplexer13;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp16;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp18;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp20;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp22;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp17;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp19;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp21;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp23;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp24;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp25;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack26;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack27;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice28;

  public Pulse_C(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing) {
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

  ~Pulse_C() {
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
    if (_objSignalProcessingSignalMathOp16 != null) {
      _objSignalProcessingSignalMathOp16.SetOperandB(Gain0);
    }
  }

  public float GetGain1() {
    return _paramGain1;
  }

  public void SetGain1(float Gain1) {
    _paramGain1 = Gain1;
    if (_objSignalProcessingSignalMathOp18 != null) {
      _objSignalProcessingSignalMathOp18.SetOperandB(Gain1);
    }
  }

  public float GetGain2() {
    return _paramGain2;
  }

  public void SetGain2(float Gain2) {
    _paramGain2 = Gain2;
    if (_objSignalProcessingSignalMathOp20 != null) {
      _objSignalProcessingSignalMathOp20.SetOperandB(Gain2);
    }
  }

  public float GetGain3() {
    return _paramGain3;
  }

  public void SetGain3(float Gain3) {
    _paramGain3 = Gain3;
    if (_objSignalProcessingSignalMathOp22 != null) {
      _objSignalProcessingSignalMathOp22.SetOperandB(Gain3);
    }
  }

  public float GetGain4() {
    return _paramGain4;
  }

  public void SetGain4(float Gain4) {
    _paramGain4 = Gain4;
    if (_objSignalProcessingSignalMathOp24 != null) {
      _objSignalProcessingSignalMathOp24.SetOperandB(Gain4);
    }
  }

  void CreateObjects() {
    _objSignalProcessingSignalOscillator0 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalEvent7 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent7);
    _objSignalProcessingSignalEvent8 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent8);
    _objSignalProcessingSignalEvent9 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent9);
    _objSignalProcessingSignalEvent10 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent10);
    _objSignalProcessingSignalEvent11 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent11);
    _objSignalProcessingSignalEvent14 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent14);
    _objSignalProcessingSignalMathOp1 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalCurve2 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve2);
    _objSignalProcessingSignalCurve3 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve3);
    _objSignalProcessingSignalCurve4 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve4);
    _objSignalProcessingSignalCurve5 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve5);
    _objSignalProcessingSignalCurve6 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve6);
    _objSignalProcessingSignalEventCombiner12 = new SignalProcessingDataStore.OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalProcessingSignalEventCombiner12);
    _objSignalProcessingSignalEvent15 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent15);
    _objSignalProcessingSignalMultiplexer13 = new SignalProcessingDataStore.OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalProcessingSignalMultiplexer13);
    _objSignalProcessingSignalMathOp16 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp16);
    _objSignalProcessingSignalMathOp18 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp18);
    _objSignalProcessingSignalMathOp20 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp20);
    _objSignalProcessingSignalMathOp22 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp22);
    _objSignalProcessingSignalMathOp17 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp17);
    _objSignalProcessingSignalMathOp19 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp19);
    _objSignalProcessingSignalMathOp21 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp21);
    _objSignalProcessingSignalMathOp23 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp23);
    _objSignalProcessingSignalMathOp24 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp24);
    _objSignalProcessingSignalMathOp25 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp25);
    _objSignalProcessingSignalChannelStack26 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack26);
    _objSignalProcessingSignalChannelStack27 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack27);
    _objSignalProcessingSignalOutputDevice28 = new SignalProcessingDataStore.OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalProcessingSignalOutputDevice28);
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
    _objSignalProcessingSignalCurve2.SetSegmentLength1(0.01f);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue1(1f);
    _objSignalProcessingSignalCurve2.SetSegmentLength2(0.01f);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue2(1f);
    _objSignalProcessingSignalCurve2.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve2.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve2.SetAutoStart(true);
    _objSignalProcessingSignalCurve2.SetAutoLoop(false);
    _objSignalProcessingSignalCurve2.SetOnDoneEvent(_objSignalProcessingSignalEvent7);
    _objSignalProcessingSignalCurve2.SetNumOutputs(1);
    _objSignalProcessingSignalCurve3.SetSoftCurve(true);
    _objSignalProcessingSignalCurve3.SetNumSegments(5);
    _objSignalProcessingSignalCurve3.SetStartValue(0f);
    _objSignalProcessingSignalCurve3.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve3.SetSegmentLength1(0f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue1(0f);
    _objSignalProcessingSignalCurve3.SetSegmentLength2(0.05f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue2(0f);
    _objSignalProcessingSignalCurve3.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve3.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve3.SetAutoStart(false);
    _objSignalProcessingSignalCurve3.SetAutoLoop(false);
    _objSignalProcessingSignalCurve3.SetStartEvent(_objSignalProcessingSignalEvent7);
    _objSignalProcessingSignalCurve3.SetOnDoneEvent(_objSignalProcessingSignalEvent8);
    _objSignalProcessingSignalCurve3.SetNumOutputs(1);
    _objSignalProcessingSignalCurve4.SetSoftCurve(true);
    _objSignalProcessingSignalCurve4.SetNumSegments(5);
    _objSignalProcessingSignalCurve4.SetStartValue(0f);
    _objSignalProcessingSignalCurve4.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve4.SetSegmentLength1(0.01f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue1(0.8f);
    _objSignalProcessingSignalCurve4.SetSegmentLength2(0.01f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue2(0.8f);
    _objSignalProcessingSignalCurve4.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve4.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve4.SetAutoStart(false);
    _objSignalProcessingSignalCurve4.SetAutoLoop(false);
    _objSignalProcessingSignalCurve4.SetStartEvent(_objSignalProcessingSignalEvent8);
    _objSignalProcessingSignalCurve4.SetOnDoneEvent(_objSignalProcessingSignalEvent9);
    _objSignalProcessingSignalCurve4.SetNumOutputs(1);
    _objSignalProcessingSignalCurve5.SetSoftCurve(true);
    _objSignalProcessingSignalCurve5.SetNumSegments(5);
    _objSignalProcessingSignalCurve5.SetStartValue(0f);
    _objSignalProcessingSignalCurve5.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve5.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve5.SetSegmentLength1(0f);
    _objSignalProcessingSignalCurve5.SetSegmentEndValue1(0f);
    _objSignalProcessingSignalCurve5.SetSegmentLength2(0.05f);
    _objSignalProcessingSignalCurve5.SetSegmentEndValue2(0f);
    _objSignalProcessingSignalCurve5.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve5.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve5.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve5.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve5.SetAutoStart(false);
    _objSignalProcessingSignalCurve5.SetAutoLoop(false);
    _objSignalProcessingSignalCurve5.SetStartEvent(_objSignalProcessingSignalEvent9);
    _objSignalProcessingSignalCurve5.SetOnDoneEvent(_objSignalProcessingSignalEvent10);
    _objSignalProcessingSignalCurve5.SetNumOutputs(1);
    _objSignalProcessingSignalCurve6.SetSoftCurve(true);
    _objSignalProcessingSignalCurve6.SetNumSegments(5);
    _objSignalProcessingSignalCurve6.SetStartValue(0f);
    _objSignalProcessingSignalCurve6.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve6.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve6.SetSegmentLength1(0.01f);
    _objSignalProcessingSignalCurve6.SetSegmentEndValue1(0.6f);
    _objSignalProcessingSignalCurve6.SetSegmentLength2(0.01f);
    _objSignalProcessingSignalCurve6.SetSegmentEndValue2(0.6f);
    _objSignalProcessingSignalCurve6.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve6.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve6.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve6.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve6.SetAutoStart(false);
    _objSignalProcessingSignalCurve6.SetAutoLoop(false);
    _objSignalProcessingSignalCurve6.SetStartEvent(_objSignalProcessingSignalEvent10);
    _objSignalProcessingSignalCurve6.SetOnDoneEvent(_objSignalProcessingSignalEvent11);
    _objSignalProcessingSignalCurve6.SetNumOutputs(1);
    _objSignalProcessingSignalEventCombiner12.SetSrcEvent0(_objSignalProcessingSignalEvent7);
    _objSignalProcessingSignalEventCombiner12.SetSrcEvent1(_objSignalProcessingSignalEvent8);
    _objSignalProcessingSignalEventCombiner12.SetSrcEvent2(_objSignalProcessingSignalEvent9);
    _objSignalProcessingSignalEventCombiner12.SetSrcEvent3(_objSignalProcessingSignalEvent10);
    _objSignalProcessingSignalEventCombiner12.SetSrcEvent4(_objSignalProcessingSignalEvent11);
    _objSignalProcessingSignalEventCombiner12.SetOnEvent(_objSignalProcessingSignalEvent14);
    _objSignalProcessingSignalMultiplexer13.SetSrcNode0(_objSignalProcessingSignalCurve2);
    _objSignalProcessingSignalMultiplexer13.SetSrcNode1(_objSignalProcessingSignalCurve3);
    _objSignalProcessingSignalMultiplexer13.SetSrcNode2(_objSignalProcessingSignalCurve4);
    _objSignalProcessingSignalMultiplexer13.SetSrcNode3(_objSignalProcessingSignalCurve5);
    _objSignalProcessingSignalMultiplexer13.SetSrcNode4(_objSignalProcessingSignalCurve6);
    _objSignalProcessingSignalMultiplexer13.SetIncrementEvent(_objSignalProcessingSignalEvent14);
    _objSignalProcessingSignalMultiplexer13.SetAutoStart(true);
    _objSignalProcessingSignalMultiplexer13.SetNumChannels(1);
    _objSignalProcessingSignalMultiplexer13.SetOnDoneEvent(_objSignalProcessingSignalEvent15);
    _objSignalProcessingSignalMultiplexer13.SetNumOutputs(5);
    _objSignalProcessingSignalMathOp16.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp16.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp16.SetOperandB(_paramGain0);
    _objSignalProcessingSignalMathOp16.SetNumChannels(1);
    _objSignalProcessingSignalMathOp16.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp18.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp18.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp18.SetOperandB(_paramGain1);
    _objSignalProcessingSignalMathOp18.SetNumChannels(1);
    _objSignalProcessingSignalMathOp18.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp20.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp20.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp20.SetOperandB(_paramGain2);
    _objSignalProcessingSignalMathOp20.SetNumChannels(1);
    _objSignalProcessingSignalMathOp20.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp22.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp22.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp22.SetOperandB(_paramGain3);
    _objSignalProcessingSignalMathOp22.SetNumChannels(1);
    _objSignalProcessingSignalMathOp22.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp17.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp17.SetOperandANode(_objSignalProcessingSignalMathOp16);
    _objSignalProcessingSignalMathOp17.SetOperandBNode(_objSignalProcessingSignalMultiplexer13);
    _objSignalProcessingSignalMathOp17.SetNumChannels(1);
    _objSignalProcessingSignalMathOp17.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp19.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp19.SetOperandANode(_objSignalProcessingSignalMathOp18);
    _objSignalProcessingSignalMathOp19.SetOperandBNode(_objSignalProcessingSignalMultiplexer13);
    _objSignalProcessingSignalMathOp19.SetNumChannels(1);
    _objSignalProcessingSignalMathOp19.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp21.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp21.SetOperandANode(_objSignalProcessingSignalMathOp20);
    _objSignalProcessingSignalMathOp21.SetOperandBNode(_objSignalProcessingSignalMultiplexer13);
    _objSignalProcessingSignalMathOp21.SetNumChannels(1);
    _objSignalProcessingSignalMathOp21.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp23.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp23.SetOperandANode(_objSignalProcessingSignalMathOp22);
    _objSignalProcessingSignalMathOp23.SetOperandBNode(_objSignalProcessingSignalMultiplexer13);
    _objSignalProcessingSignalMathOp23.SetNumChannels(1);
    _objSignalProcessingSignalMathOp23.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp24.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp24.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp24.SetOperandB(_paramGain4);
    _objSignalProcessingSignalMathOp24.SetNumChannels(1);
    _objSignalProcessingSignalMathOp24.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp25.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp25.SetOperandANode(_objSignalProcessingSignalMathOp24);
    _objSignalProcessingSignalMathOp25.SetOperandBNode(_objSignalProcessingSignalMultiplexer13);
    _objSignalProcessingSignalMathOp25.SetNumChannels(1);
    _objSignalProcessingSignalMathOp25.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack26.SetSrcNode0(_objSignalProcessingSignalMathOp17);
    _objSignalProcessingSignalChannelStack26.SetSrcNode1(_objSignalProcessingSignalMathOp19);
    _objSignalProcessingSignalChannelStack26.SetSrcNode2(_objSignalProcessingSignalMathOp21);
    _objSignalProcessingSignalChannelStack26.SetSrcNode3(_objSignalProcessingSignalMathOp23);
    _objSignalProcessingSignalChannelStack26.SetNumChannels(4);
    _objSignalProcessingSignalChannelStack26.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack27.SetSrcNode0(_objSignalProcessingSignalChannelStack26);
    _objSignalProcessingSignalChannelStack27.SetSrcNode1(_objSignalProcessingSignalMathOp25);
    _objSignalProcessingSignalChannelStack27.SetNumChannels(5);
    _objSignalProcessingSignalChannelStack27.SetNumOutputs(1);
    _objSignalProcessingSignalOutputDevice28.SetSrcNode(_objSignalProcessingSignalChannelStack27);
    _objSignalProcessingSignalOutputDevice28.SetDeviceNameFilter("HDK-1");
    _objSignalProcessingSignalOutputDevice28.SetChannelOffset(0);
    if (_objSignalProcessingSignalEvent15 != null) {
      _objSignalProcessingSignalEvent15.OnReceiveEvent((_, _) => Terminate());
    }
  }

  void DestroyObjects() {
    if (_objSignalProcessingSignalOutputDevice28 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalProcessingSignalOutputDevice28.GetXrpaId());
      _objSignalProcessingSignalOutputDevice28 = null;
    }
    if (_objSignalProcessingSignalChannelStack27 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack27.GetXrpaId());
      _objSignalProcessingSignalChannelStack27 = null;
    }
    if (_objSignalProcessingSignalChannelStack26 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack26.GetXrpaId());
      _objSignalProcessingSignalChannelStack26 = null;
    }
    if (_objSignalProcessingSignalMathOp25 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp25.GetXrpaId());
      _objSignalProcessingSignalMathOp25 = null;
    }
    if (_objSignalProcessingSignalMathOp24 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp24.GetXrpaId());
      _objSignalProcessingSignalMathOp24 = null;
    }
    if (_objSignalProcessingSignalMathOp23 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp23.GetXrpaId());
      _objSignalProcessingSignalMathOp23 = null;
    }
    if (_objSignalProcessingSignalMathOp21 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp21.GetXrpaId());
      _objSignalProcessingSignalMathOp21 = null;
    }
    if (_objSignalProcessingSignalMathOp19 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp19.GetXrpaId());
      _objSignalProcessingSignalMathOp19 = null;
    }
    if (_objSignalProcessingSignalMathOp17 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp17.GetXrpaId());
      _objSignalProcessingSignalMathOp17 = null;
    }
    if (_objSignalProcessingSignalMathOp22 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp22.GetXrpaId());
      _objSignalProcessingSignalMathOp22 = null;
    }
    if (_objSignalProcessingSignalMathOp20 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp20.GetXrpaId());
      _objSignalProcessingSignalMathOp20 = null;
    }
    if (_objSignalProcessingSignalMathOp18 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp18.GetXrpaId());
      _objSignalProcessingSignalMathOp18 = null;
    }
    if (_objSignalProcessingSignalMathOp16 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp16.GetXrpaId());
      _objSignalProcessingSignalMathOp16 = null;
    }
    if (_objSignalProcessingSignalMultiplexer13 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalProcessingSignalMultiplexer13.GetXrpaId());
      _objSignalProcessingSignalMultiplexer13 = null;
    }
    if (_objSignalProcessingSignalEvent15 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent15.GetXrpaId());
      _objSignalProcessingSignalEvent15 = null;
    }
    if (_objSignalProcessingSignalEventCombiner12 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalProcessingSignalEventCombiner12.GetXrpaId());
      _objSignalProcessingSignalEventCombiner12 = null;
    }
    if (_objSignalProcessingSignalCurve6 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve6.GetXrpaId());
      _objSignalProcessingSignalCurve6 = null;
    }
    if (_objSignalProcessingSignalCurve5 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve5.GetXrpaId());
      _objSignalProcessingSignalCurve5 = null;
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
    if (_objSignalProcessingSignalEvent14 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent14.GetXrpaId());
      _objSignalProcessingSignalEvent14 = null;
    }
    if (_objSignalProcessingSignalEvent11 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent11.GetXrpaId());
      _objSignalProcessingSignalEvent11 = null;
    }
    if (_objSignalProcessingSignalEvent10 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent10.GetXrpaId());
      _objSignalProcessingSignalEvent10 = null;
    }
    if (_objSignalProcessingSignalEvent9 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent9.GetXrpaId());
      _objSignalProcessingSignalEvent9 = null;
    }
    if (_objSignalProcessingSignalEvent8 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent8.GetXrpaId());
      _objSignalProcessingSignalEvent8 = null;
    }
    if (_objSignalProcessingSignalEvent7 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent7.GetXrpaId());
      _objSignalProcessingSignalEvent7 = null;
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
