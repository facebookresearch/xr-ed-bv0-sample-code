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

public class Pulse_A : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramFundamentalAmp = 1f;
  private float _paramFundamentalFq = 170f;
  private float _paramGain0 = 1f;
  private float _paramGain1 = 1f;
  private float _paramGain2 = 1f;
  private float _paramGain3 = 1f;
  private float _paramGain4 = 1f;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator0;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent3;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent6;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp1;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve2;
  private SignalProcessingDataStore.OutboundSignalEventCombiner _objSignalProcessingSignalEventCombiner4;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent7;
  private SignalProcessingDataStore.OutboundSignalMultiplexer _objSignalProcessingSignalMultiplexer5;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp8;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp10;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp12;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp14;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp9;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp11;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp13;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp15;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp16;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp17;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack18;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack19;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice20;

  public Pulse_A(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing) {
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

  ~Pulse_A() {
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
    if (_objSignalProcessingSignalMathOp8 != null) {
      _objSignalProcessingSignalMathOp8.SetOperandB(Gain0);
    }
  }

  public float GetGain1() {
    return _paramGain1;
  }

  public void SetGain1(float Gain1) {
    _paramGain1 = Gain1;
    if (_objSignalProcessingSignalMathOp10 != null) {
      _objSignalProcessingSignalMathOp10.SetOperandB(Gain1);
    }
  }

  public float GetGain2() {
    return _paramGain2;
  }

  public void SetGain2(float Gain2) {
    _paramGain2 = Gain2;
    if (_objSignalProcessingSignalMathOp12 != null) {
      _objSignalProcessingSignalMathOp12.SetOperandB(Gain2);
    }
  }

  public float GetGain3() {
    return _paramGain3;
  }

  public void SetGain3(float Gain3) {
    _paramGain3 = Gain3;
    if (_objSignalProcessingSignalMathOp14 != null) {
      _objSignalProcessingSignalMathOp14.SetOperandB(Gain3);
    }
  }

  public float GetGain4() {
    return _paramGain4;
  }

  public void SetGain4(float Gain4) {
    _paramGain4 = Gain4;
    if (_objSignalProcessingSignalMathOp16 != null) {
      _objSignalProcessingSignalMathOp16.SetOperandB(Gain4);
    }
  }

  void CreateObjects() {
    _objSignalProcessingSignalOscillator0 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalEvent3 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent3);
    _objSignalProcessingSignalEvent6 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent6);
    _objSignalProcessingSignalMathOp1 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalCurve2 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve2);
    _objSignalProcessingSignalEventCombiner4 = new SignalProcessingDataStore.OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalProcessingSignalEventCombiner4);
    _objSignalProcessingSignalEvent7 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent7);
    _objSignalProcessingSignalMultiplexer5 = new SignalProcessingDataStore.OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalProcessingSignalMultiplexer5);
    _objSignalProcessingSignalMathOp8 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp8);
    _objSignalProcessingSignalMathOp10 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp10);
    _objSignalProcessingSignalMathOp12 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp12);
    _objSignalProcessingSignalMathOp14 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp14);
    _objSignalProcessingSignalMathOp9 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp9);
    _objSignalProcessingSignalMathOp11 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp11);
    _objSignalProcessingSignalMathOp13 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp13);
    _objSignalProcessingSignalMathOp15 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp15);
    _objSignalProcessingSignalMathOp16 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp16);
    _objSignalProcessingSignalMathOp17 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp17);
    _objSignalProcessingSignalChannelStack18 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack18);
    _objSignalProcessingSignalChannelStack19 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack19);
    _objSignalProcessingSignalOutputDevice20 = new SignalProcessingDataStore.OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalProcessingSignalOutputDevice20);
    _objSignalProcessingSignalOscillator0.SetNumChannels(1);
    _objSignalProcessingSignalOscillator0.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(1));
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
    _objSignalProcessingSignalCurve2.SetSegmentEndValue1(1f);
    _objSignalProcessingSignalCurve2.SetSegmentLength2(0.01f);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue2(1f);
    _objSignalProcessingSignalCurve2.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve2.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve2.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve2.SetAutoStart(true);
    _objSignalProcessingSignalCurve2.SetAutoLoop(false);
    _objSignalProcessingSignalCurve2.SetOnDoneEvent(_objSignalProcessingSignalEvent3);
    _objSignalProcessingSignalCurve2.SetNumOutputs(1);
    _objSignalProcessingSignalEventCombiner4.SetSrcEvent0(_objSignalProcessingSignalEvent3);
    _objSignalProcessingSignalEventCombiner4.SetOnEvent(_objSignalProcessingSignalEvent6);
    _objSignalProcessingSignalMultiplexer5.SetSrcNode0(_objSignalProcessingSignalCurve2);
    _objSignalProcessingSignalMultiplexer5.SetIncrementEvent(_objSignalProcessingSignalEvent6);
    _objSignalProcessingSignalMultiplexer5.SetAutoStart(true);
    _objSignalProcessingSignalMultiplexer5.SetNumChannels(1);
    _objSignalProcessingSignalMultiplexer5.SetOnDoneEvent(_objSignalProcessingSignalEvent7);
    _objSignalProcessingSignalMultiplexer5.SetNumOutputs(5);
    _objSignalProcessingSignalMathOp8.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp8.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp8.SetOperandB(_paramGain0);
    _objSignalProcessingSignalMathOp8.SetNumChannels(1);
    _objSignalProcessingSignalMathOp8.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp10.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp10.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp10.SetOperandB(_paramGain1);
    _objSignalProcessingSignalMathOp10.SetNumChannels(1);
    _objSignalProcessingSignalMathOp10.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp12.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp12.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp12.SetOperandB(_paramGain2);
    _objSignalProcessingSignalMathOp12.SetNumChannels(1);
    _objSignalProcessingSignalMathOp12.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp14.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp14.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp14.SetOperandB(_paramGain3);
    _objSignalProcessingSignalMathOp14.SetNumChannels(1);
    _objSignalProcessingSignalMathOp14.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp9.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp9.SetOperandANode(_objSignalProcessingSignalMathOp8);
    _objSignalProcessingSignalMathOp9.SetOperandBNode(_objSignalProcessingSignalMultiplexer5);
    _objSignalProcessingSignalMathOp9.SetNumChannels(1);
    _objSignalProcessingSignalMathOp9.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp11.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp11.SetOperandANode(_objSignalProcessingSignalMathOp10);
    _objSignalProcessingSignalMathOp11.SetOperandBNode(_objSignalProcessingSignalMultiplexer5);
    _objSignalProcessingSignalMathOp11.SetNumChannels(1);
    _objSignalProcessingSignalMathOp11.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp13.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp13.SetOperandANode(_objSignalProcessingSignalMathOp12);
    _objSignalProcessingSignalMathOp13.SetOperandBNode(_objSignalProcessingSignalMultiplexer5);
    _objSignalProcessingSignalMathOp13.SetNumChannels(1);
    _objSignalProcessingSignalMathOp13.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp15.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp15.SetOperandANode(_objSignalProcessingSignalMathOp14);
    _objSignalProcessingSignalMathOp15.SetOperandBNode(_objSignalProcessingSignalMultiplexer5);
    _objSignalProcessingSignalMathOp15.SetNumChannels(1);
    _objSignalProcessingSignalMathOp15.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp16.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp16.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp16.SetOperandB(_paramGain4);
    _objSignalProcessingSignalMathOp16.SetNumChannels(1);
    _objSignalProcessingSignalMathOp16.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp17.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp17.SetOperandANode(_objSignalProcessingSignalMathOp16);
    _objSignalProcessingSignalMathOp17.SetOperandBNode(_objSignalProcessingSignalMultiplexer5);
    _objSignalProcessingSignalMathOp17.SetNumChannels(1);
    _objSignalProcessingSignalMathOp17.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack18.SetSrcNode0(_objSignalProcessingSignalMathOp9);
    _objSignalProcessingSignalChannelStack18.SetSrcNode1(_objSignalProcessingSignalMathOp11);
    _objSignalProcessingSignalChannelStack18.SetSrcNode2(_objSignalProcessingSignalMathOp13);
    _objSignalProcessingSignalChannelStack18.SetSrcNode3(_objSignalProcessingSignalMathOp15);
    _objSignalProcessingSignalChannelStack18.SetNumChannels(4);
    _objSignalProcessingSignalChannelStack18.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack19.SetSrcNode0(_objSignalProcessingSignalChannelStack18);
    _objSignalProcessingSignalChannelStack19.SetSrcNode1(_objSignalProcessingSignalMathOp17);
    _objSignalProcessingSignalChannelStack19.SetNumChannels(5);
    _objSignalProcessingSignalChannelStack19.SetNumOutputs(1);
    _objSignalProcessingSignalOutputDevice20.SetSrcNode(_objSignalProcessingSignalChannelStack19);
    _objSignalProcessingSignalOutputDevice20.SetDeviceNameFilter("HDK-1");
    _objSignalProcessingSignalOutputDevice20.SetChannelOffset(0);
    if (_objSignalProcessingSignalEvent7 != null) {
      _objSignalProcessingSignalEvent7.OnReceiveEvent((_, _) => Terminate());
    }
  }

  void DestroyObjects() {
    if (_objSignalProcessingSignalOutputDevice20 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalProcessingSignalOutputDevice20.GetXrpaId());
      _objSignalProcessingSignalOutputDevice20 = null;
    }
    if (_objSignalProcessingSignalChannelStack19 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack19.GetXrpaId());
      _objSignalProcessingSignalChannelStack19 = null;
    }
    if (_objSignalProcessingSignalChannelStack18 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack18.GetXrpaId());
      _objSignalProcessingSignalChannelStack18 = null;
    }
    if (_objSignalProcessingSignalMathOp17 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp17.GetXrpaId());
      _objSignalProcessingSignalMathOp17 = null;
    }
    if (_objSignalProcessingSignalMathOp16 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp16.GetXrpaId());
      _objSignalProcessingSignalMathOp16 = null;
    }
    if (_objSignalProcessingSignalMathOp15 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp15.GetXrpaId());
      _objSignalProcessingSignalMathOp15 = null;
    }
    if (_objSignalProcessingSignalMathOp13 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp13.GetXrpaId());
      _objSignalProcessingSignalMathOp13 = null;
    }
    if (_objSignalProcessingSignalMathOp11 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp11.GetXrpaId());
      _objSignalProcessingSignalMathOp11 = null;
    }
    if (_objSignalProcessingSignalMathOp9 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp9.GetXrpaId());
      _objSignalProcessingSignalMathOp9 = null;
    }
    if (_objSignalProcessingSignalMathOp14 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp14.GetXrpaId());
      _objSignalProcessingSignalMathOp14 = null;
    }
    if (_objSignalProcessingSignalMathOp12 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp12.GetXrpaId());
      _objSignalProcessingSignalMathOp12 = null;
    }
    if (_objSignalProcessingSignalMathOp10 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp10.GetXrpaId());
      _objSignalProcessingSignalMathOp10 = null;
    }
    if (_objSignalProcessingSignalMathOp8 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp8.GetXrpaId());
      _objSignalProcessingSignalMathOp8 = null;
    }
    if (_objSignalProcessingSignalMultiplexer5 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalProcessingSignalMultiplexer5.GetXrpaId());
      _objSignalProcessingSignalMultiplexer5 = null;
    }
    if (_objSignalProcessingSignalEvent7 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent7.GetXrpaId());
      _objSignalProcessingSignalEvent7 = null;
    }
    if (_objSignalProcessingSignalEventCombiner4 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalProcessingSignalEventCombiner4.GetXrpaId());
      _objSignalProcessingSignalEventCombiner4 = null;
    }
    if (_objSignalProcessingSignalCurve2 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve2.GetXrpaId());
      _objSignalProcessingSignalCurve2 = null;
    }
    if (_objSignalProcessingSignalMathOp1 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp1.GetXrpaId());
      _objSignalProcessingSignalMathOp1 = null;
    }
    if (_objSignalProcessingSignalEvent6 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent6.GetXrpaId());
      _objSignalProcessingSignalEvent6 = null;
    }
    if (_objSignalProcessingSignalEvent3 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent3.GetXrpaId());
      _objSignalProcessingSignalEvent3 = null;
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
