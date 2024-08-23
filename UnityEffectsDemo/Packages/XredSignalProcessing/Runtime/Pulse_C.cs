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

public class Pulse_C : IDisposable {
  private SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramFundamentalAmp = 1f;
  private float _paramFundamentalFq = 350f;
  private float _paramGain0 = 1f;
  private float _paramGain1 = 1f;
  private float _paramGain2 = 1f;
  private float _paramGain3 = 1f;
  private float _paramGain4 = 1f;
  private OutboundSignalOscillator _objSignalOscillator79;
  private OutboundSignalEvent _objSignalEvent86;
  private OutboundSignalEvent _objSignalEvent87;
  private OutboundSignalEvent _objSignalEvent88;
  private OutboundSignalEvent _objSignalEvent89;
  private OutboundSignalEvent _objSignalEvent90;
  private OutboundSignalEvent _objSignalEvent93;
  private OutboundSignalMathOp _objSignalMathOp80;
  private OutboundSignalCurve _objSignalCurve81;
  private OutboundSignalCurve _objSignalCurve82;
  private OutboundSignalCurve _objSignalCurve83;
  private OutboundSignalCurve _objSignalCurve84;
  private OutboundSignalCurve _objSignalCurve85;
  private OutboundSignalEventCombiner _objSignalEventCombiner91;
  private OutboundSignalEvent _objSignalEvent94;
  private OutboundSignalMathOp _objSignalMathOp95;
  private OutboundSignalMultiplexer _objSignalMultiplexer92;
  private OutboundSignalMathOp _objSignalMathOp97;
  private OutboundSignalMathOp _objSignalMathOp99;
  private OutboundSignalMathOp _objSignalMathOp101;
  private OutboundSignalMathOp _objSignalMathOp96;
  private OutboundSignalMathOp _objSignalMathOp98;
  private OutboundSignalMathOp _objSignalMathOp100;
  private OutboundSignalMathOp _objSignalMathOp102;
  private OutboundSignalMathOp _objSignalMathOp103;
  private OutboundSignalChannelStack _objSignalChannelStack105;
  private OutboundSignalMathOp _objSignalMathOp104;
  private OutboundSignalChannelStack _objSignalChannelStack106;
  private OutboundSignalOutputDevice _objSignalOutputDevice107;

  public Pulse_C(SignalProcessingDataStore datastore) {
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

  ~Pulse_C() {
    Dispose(false);
  }

  public float GetFundamentalAmp() {
    return _paramFundamentalAmp;
  }

  public void SetFundamentalAmp(float FundamentalAmp) {
    _paramFundamentalAmp = FundamentalAmp;
    if (_objSignalMathOp80 != null) {
      _objSignalMathOp80.SetOperandB(FundamentalAmp);
    }
  }

  public float GetFundamentalFq() {
    return _paramFundamentalFq;
  }

  public void SetFundamentalFq(float FundamentalFq) {
    _paramFundamentalFq = FundamentalFq;
    if (_objSignalOscillator79 != null) {
      _objSignalOscillator79.SetFrequency(FundamentalFq);
    }
  }

  public float GetGain0() {
    return _paramGain0;
  }

  public void SetGain0(float Gain0) {
    _paramGain0 = Gain0;
    if (_objSignalMathOp95 != null) {
      _objSignalMathOp95.SetOperandB(Gain0);
    }
  }

  public float GetGain1() {
    return _paramGain1;
  }

  public void SetGain1(float Gain1) {
    _paramGain1 = Gain1;
    if (_objSignalMathOp97 != null) {
      _objSignalMathOp97.SetOperandB(Gain1);
    }
  }

  public float GetGain2() {
    return _paramGain2;
  }

  public void SetGain2(float Gain2) {
    _paramGain2 = Gain2;
    if (_objSignalMathOp99 != null) {
      _objSignalMathOp99.SetOperandB(Gain2);
    }
  }

  public float GetGain3() {
    return _paramGain3;
  }

  public void SetGain3(float Gain3) {
    _paramGain3 = Gain3;
    if (_objSignalMathOp101 != null) {
      _objSignalMathOp101.SetOperandB(Gain3);
    }
  }

  public float GetGain4() {
    return _paramGain4;
  }

  public void SetGain4(float Gain4) {
    _paramGain4 = Gain4;
    if (_objSignalMathOp103 != null) {
      _objSignalMathOp103.SetOperandB(Gain4);
    }
  }

  void CreateObjects() {
    _objSignalOscillator79 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator79);
    _objSignalEvent86 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent86);
    _objSignalEvent87 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent87);
    _objSignalEvent88 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent88);
    _objSignalEvent89 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent89);
    _objSignalEvent90 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent90);
    _objSignalEvent93 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent93);
    _objSignalMathOp80 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp80);
    _objSignalCurve81 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve81);
    _objSignalCurve82 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve82);
    _objSignalCurve83 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve83);
    _objSignalCurve84 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve84);
    _objSignalCurve85 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve85);
    _objSignalEventCombiner91 = new OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalEventCombiner91);
    _objSignalEvent94 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent94);
    _objSignalMathOp95 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp95);
    _objSignalMultiplexer92 = new OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalMultiplexer92);
    _objSignalMathOp97 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp97);
    _objSignalMathOp99 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp99);
    _objSignalMathOp101 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp101);
    _objSignalMathOp96 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp96);
    _objSignalMathOp98 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp98);
    _objSignalMathOp100 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp100);
    _objSignalMathOp102 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp102);
    _objSignalMathOp103 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp103);
    _objSignalChannelStack105 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack105);
    _objSignalMathOp104 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp104);
    _objSignalChannelStack106 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack106);
    _objSignalOutputDevice107 = new OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalOutputDevice107);
    _objSignalOscillator79.SetNumChannels(1);
    _objSignalOscillator79.SetWaveformType((WaveformType)(uint)(3));
    _objSignalOscillator79.SetFrequency(_paramFundamentalFq);
    _objSignalOscillator79.SetPulseWidth(0.5f);
    _objSignalOscillator79.SetNumOutputs(1);
    _objSignalMathOp80.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp80.SetOperandANode(_objSignalOscillator79);
    _objSignalMathOp80.SetOperandB(_paramFundamentalAmp);
    _objSignalMathOp80.SetNumChannels(1);
    _objSignalMathOp80.SetNumOutputs(5);
    _objSignalCurve81.SetSoftCurve(true);
    _objSignalCurve81.SetNumSegments(5);
    _objSignalCurve81.SetStartValue(0f);
    _objSignalCurve81.SetSegmentLength0(0f);
    _objSignalCurve81.SetSegmentEndValue0(0f);
    _objSignalCurve81.SetSegmentLength1(0.01f);
    _objSignalCurve81.SetSegmentEndValue1(1f);
    _objSignalCurve81.SetSegmentLength2(0.01f);
    _objSignalCurve81.SetSegmentEndValue2(1f);
    _objSignalCurve81.SetSegmentLength3(0f);
    _objSignalCurve81.SetSegmentEndValue3(0f);
    _objSignalCurve81.SetSegmentLength4(0f);
    _objSignalCurve81.SetSegmentEndValue4(0f);
    _objSignalCurve81.SetAutoStart(true);
    _objSignalCurve81.SetAutoLoop(false);
    _objSignalCurve81.SetOnDoneEvent(_objSignalEvent86);
    _objSignalCurve81.SetNumOutputs(1);
    _objSignalCurve82.SetSoftCurve(true);
    _objSignalCurve82.SetNumSegments(5);
    _objSignalCurve82.SetStartValue(0f);
    _objSignalCurve82.SetSegmentLength0(0f);
    _objSignalCurve82.SetSegmentEndValue0(0f);
    _objSignalCurve82.SetSegmentLength1(0f);
    _objSignalCurve82.SetSegmentEndValue1(0f);
    _objSignalCurve82.SetSegmentLength2(0.05f);
    _objSignalCurve82.SetSegmentEndValue2(0f);
    _objSignalCurve82.SetSegmentLength3(0f);
    _objSignalCurve82.SetSegmentEndValue3(0f);
    _objSignalCurve82.SetSegmentLength4(0f);
    _objSignalCurve82.SetSegmentEndValue4(0f);
    _objSignalCurve82.SetAutoStart(false);
    _objSignalCurve82.SetAutoLoop(false);
    _objSignalCurve82.SetStartEvent(_objSignalEvent86);
    _objSignalCurve82.SetOnDoneEvent(_objSignalEvent87);
    _objSignalCurve82.SetNumOutputs(1);
    _objSignalCurve83.SetSoftCurve(true);
    _objSignalCurve83.SetNumSegments(5);
    _objSignalCurve83.SetStartValue(0f);
    _objSignalCurve83.SetSegmentLength0(0f);
    _objSignalCurve83.SetSegmentEndValue0(0f);
    _objSignalCurve83.SetSegmentLength1(0.01f);
    _objSignalCurve83.SetSegmentEndValue1(0.8f);
    _objSignalCurve83.SetSegmentLength2(0.01f);
    _objSignalCurve83.SetSegmentEndValue2(0.8f);
    _objSignalCurve83.SetSegmentLength3(0f);
    _objSignalCurve83.SetSegmentEndValue3(0f);
    _objSignalCurve83.SetSegmentLength4(0f);
    _objSignalCurve83.SetSegmentEndValue4(0f);
    _objSignalCurve83.SetAutoStart(false);
    _objSignalCurve83.SetAutoLoop(false);
    _objSignalCurve83.SetStartEvent(_objSignalEvent87);
    _objSignalCurve83.SetOnDoneEvent(_objSignalEvent88);
    _objSignalCurve83.SetNumOutputs(1);
    _objSignalCurve84.SetSoftCurve(true);
    _objSignalCurve84.SetNumSegments(5);
    _objSignalCurve84.SetStartValue(0f);
    _objSignalCurve84.SetSegmentLength0(0f);
    _objSignalCurve84.SetSegmentEndValue0(0f);
    _objSignalCurve84.SetSegmentLength1(0f);
    _objSignalCurve84.SetSegmentEndValue1(0f);
    _objSignalCurve84.SetSegmentLength2(0.05f);
    _objSignalCurve84.SetSegmentEndValue2(0f);
    _objSignalCurve84.SetSegmentLength3(0f);
    _objSignalCurve84.SetSegmentEndValue3(0f);
    _objSignalCurve84.SetSegmentLength4(0f);
    _objSignalCurve84.SetSegmentEndValue4(0f);
    _objSignalCurve84.SetAutoStart(false);
    _objSignalCurve84.SetAutoLoop(false);
    _objSignalCurve84.SetStartEvent(_objSignalEvent88);
    _objSignalCurve84.SetOnDoneEvent(_objSignalEvent89);
    _objSignalCurve84.SetNumOutputs(1);
    _objSignalCurve85.SetSoftCurve(true);
    _objSignalCurve85.SetNumSegments(5);
    _objSignalCurve85.SetStartValue(0f);
    _objSignalCurve85.SetSegmentLength0(0f);
    _objSignalCurve85.SetSegmentEndValue0(0f);
    _objSignalCurve85.SetSegmentLength1(0.01f);
    _objSignalCurve85.SetSegmentEndValue1(0.6f);
    _objSignalCurve85.SetSegmentLength2(0.01f);
    _objSignalCurve85.SetSegmentEndValue2(0.6f);
    _objSignalCurve85.SetSegmentLength3(0f);
    _objSignalCurve85.SetSegmentEndValue3(0f);
    _objSignalCurve85.SetSegmentLength4(0f);
    _objSignalCurve85.SetSegmentEndValue4(0f);
    _objSignalCurve85.SetAutoStart(false);
    _objSignalCurve85.SetAutoLoop(false);
    _objSignalCurve85.SetStartEvent(_objSignalEvent89);
    _objSignalCurve85.SetOnDoneEvent(_objSignalEvent90);
    _objSignalCurve85.SetNumOutputs(1);
    _objSignalEventCombiner91.SetSrcEvent0(_objSignalEvent86);
    _objSignalEventCombiner91.SetSrcEvent1(_objSignalEvent87);
    _objSignalEventCombiner91.SetSrcEvent2(_objSignalEvent88);
    _objSignalEventCombiner91.SetSrcEvent3(_objSignalEvent89);
    _objSignalEventCombiner91.SetSrcEvent4(_objSignalEvent90);
    _objSignalEventCombiner91.SetOnEvent(_objSignalEvent93);
    _objSignalMathOp95.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp95.SetOperandANode(_objSignalMathOp80);
    _objSignalMathOp95.SetOperandB(_paramGain0);
    _objSignalMathOp95.SetNumChannels(1);
    _objSignalMathOp95.SetNumOutputs(1);
    _objSignalMultiplexer92.SetSrcNode0(_objSignalCurve81);
    _objSignalMultiplexer92.SetSrcNode1(_objSignalCurve82);
    _objSignalMultiplexer92.SetSrcNode2(_objSignalCurve83);
    _objSignalMultiplexer92.SetSrcNode3(_objSignalCurve84);
    _objSignalMultiplexer92.SetSrcNode4(_objSignalCurve85);
    _objSignalMultiplexer92.SetIncrementEvent(_objSignalEvent93);
    _objSignalMultiplexer92.SetAutoStart(true);
    _objSignalMultiplexer92.SetNumChannels(1);
    _objSignalMultiplexer92.SetOnDoneEvent(_objSignalEvent94);
    _objSignalMultiplexer92.SetNumOutputs(5);
    _objSignalMathOp97.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp97.SetOperandANode(_objSignalMathOp80);
    _objSignalMathOp97.SetOperandB(_paramGain1);
    _objSignalMathOp97.SetNumChannels(1);
    _objSignalMathOp97.SetNumOutputs(1);
    _objSignalMathOp99.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp99.SetOperandANode(_objSignalMathOp80);
    _objSignalMathOp99.SetOperandB(_paramGain2);
    _objSignalMathOp99.SetNumChannels(1);
    _objSignalMathOp99.SetNumOutputs(1);
    _objSignalMathOp101.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp101.SetOperandANode(_objSignalMathOp80);
    _objSignalMathOp101.SetOperandB(_paramGain3);
    _objSignalMathOp101.SetNumChannels(1);
    _objSignalMathOp101.SetNumOutputs(1);
    _objSignalMathOp96.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp96.SetOperandANode(_objSignalMathOp95);
    _objSignalMathOp96.SetOperandBNode(_objSignalMultiplexer92);
    _objSignalMathOp96.SetNumChannels(1);
    _objSignalMathOp96.SetNumOutputs(1);
    _objSignalMathOp98.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp98.SetOperandANode(_objSignalMathOp97);
    _objSignalMathOp98.SetOperandBNode(_objSignalMultiplexer92);
    _objSignalMathOp98.SetNumChannels(1);
    _objSignalMathOp98.SetNumOutputs(1);
    _objSignalMathOp100.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp100.SetOperandANode(_objSignalMathOp99);
    _objSignalMathOp100.SetOperandBNode(_objSignalMultiplexer92);
    _objSignalMathOp100.SetNumChannels(1);
    _objSignalMathOp100.SetNumOutputs(1);
    _objSignalMathOp102.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp102.SetOperandANode(_objSignalMathOp101);
    _objSignalMathOp102.SetOperandBNode(_objSignalMultiplexer92);
    _objSignalMathOp102.SetNumChannels(1);
    _objSignalMathOp102.SetNumOutputs(1);
    _objSignalMathOp103.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp103.SetOperandANode(_objSignalMathOp80);
    _objSignalMathOp103.SetOperandB(_paramGain4);
    _objSignalMathOp103.SetNumChannels(1);
    _objSignalMathOp103.SetNumOutputs(1);
    _objSignalChannelStack105.SetSrcNode0(_objSignalMathOp96);
    _objSignalChannelStack105.SetSrcNode1(_objSignalMathOp98);
    _objSignalChannelStack105.SetSrcNode2(_objSignalMathOp100);
    _objSignalChannelStack105.SetSrcNode3(_objSignalMathOp102);
    _objSignalChannelStack105.SetNumChannels(4);
    _objSignalChannelStack105.SetNumOutputs(1);
    _objSignalMathOp104.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp104.SetOperandANode(_objSignalMathOp103);
    _objSignalMathOp104.SetOperandBNode(_objSignalMultiplexer92);
    _objSignalMathOp104.SetNumChannels(1);
    _objSignalMathOp104.SetNumOutputs(1);
    _objSignalChannelStack106.SetSrcNode0(_objSignalChannelStack105);
    _objSignalChannelStack106.SetSrcNode1(_objSignalMathOp104);
    _objSignalChannelStack106.SetNumChannels(5);
    _objSignalChannelStack106.SetNumOutputs(1);
    _objSignalOutputDevice107.SetSrcNode(_objSignalChannelStack106);
    _objSignalOutputDevice107.SetDeviceNameFilter("HDK-1");
    _objSignalOutputDevice107.SetChannelOffset(0);
    if (_objSignalEvent94 != null) {
      _objSignalEvent94.OnReceiveEvent((_, _) => Terminate());
    }
  }

  void DestroyObjects() {
    if (_objSignalOutputDevice107 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalOutputDevice107.GetXrpaId());
      _objSignalOutputDevice107 = null;
    }
    if (_objSignalChannelStack106 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack106.GetXrpaId());
      _objSignalChannelStack106 = null;
    }
    if (_objSignalMathOp104 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp104.GetXrpaId());
      _objSignalMathOp104 = null;
    }
    if (_objSignalChannelStack105 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack105.GetXrpaId());
      _objSignalChannelStack105 = null;
    }
    if (_objSignalMathOp103 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp103.GetXrpaId());
      _objSignalMathOp103 = null;
    }
    if (_objSignalMathOp102 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp102.GetXrpaId());
      _objSignalMathOp102 = null;
    }
    if (_objSignalMathOp100 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp100.GetXrpaId());
      _objSignalMathOp100 = null;
    }
    if (_objSignalMathOp98 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp98.GetXrpaId());
      _objSignalMathOp98 = null;
    }
    if (_objSignalMathOp96 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp96.GetXrpaId());
      _objSignalMathOp96 = null;
    }
    if (_objSignalMathOp101 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp101.GetXrpaId());
      _objSignalMathOp101 = null;
    }
    if (_objSignalMathOp99 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp99.GetXrpaId());
      _objSignalMathOp99 = null;
    }
    if (_objSignalMathOp97 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp97.GetXrpaId());
      _objSignalMathOp97 = null;
    }
    if (_objSignalMultiplexer92 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalMultiplexer92.GetXrpaId());
      _objSignalMultiplexer92 = null;
    }
    if (_objSignalMathOp95 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp95.GetXrpaId());
      _objSignalMathOp95 = null;
    }
    if (_objSignalEvent94 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent94.GetXrpaId());
      _objSignalEvent94 = null;
    }
    if (_objSignalEventCombiner91 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalEventCombiner91.GetXrpaId());
      _objSignalEventCombiner91 = null;
    }
    if (_objSignalCurve85 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve85.GetXrpaId());
      _objSignalCurve85 = null;
    }
    if (_objSignalCurve84 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve84.GetXrpaId());
      _objSignalCurve84 = null;
    }
    if (_objSignalCurve83 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve83.GetXrpaId());
      _objSignalCurve83 = null;
    }
    if (_objSignalCurve82 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve82.GetXrpaId());
      _objSignalCurve82 = null;
    }
    if (_objSignalCurve81 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve81.GetXrpaId());
      _objSignalCurve81 = null;
    }
    if (_objSignalMathOp80 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp80.GetXrpaId());
      _objSignalMathOp80 = null;
    }
    if (_objSignalEvent93 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent93.GetXrpaId());
      _objSignalEvent93 = null;
    }
    if (_objSignalEvent90 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent90.GetXrpaId());
      _objSignalEvent90 = null;
    }
    if (_objSignalEvent89 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent89.GetXrpaId());
      _objSignalEvent89 = null;
    }
    if (_objSignalEvent88 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent88.GetXrpaId());
      _objSignalEvent88 = null;
    }
    if (_objSignalEvent87 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent87.GetXrpaId());
      _objSignalEvent87 = null;
    }
    if (_objSignalEvent86 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent86.GetXrpaId());
      _objSignalEvent86 = null;
    }
    if (_objSignalOscillator79 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator79.GetXrpaId());
      _objSignalOscillator79 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace SignalProcessingDataStore
