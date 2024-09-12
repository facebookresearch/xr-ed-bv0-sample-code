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

public class PulsePattern : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramFq = 170f;
  private float _paramPauseDuration = 0.25f;
  private float _paramPulseDuration = 0.5f;
  private float _paramSawAmp = 1f;
  private float _paramSinAmp = 1f;
  private float _paramSquareAmp = 1f;
  private float _paramTriAmp = 1f;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent27;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent31;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent30;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator6;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve26;
  private SignalProcessingDataStore.OutboundSignalEventCombiner _objSignalProcessingSignalEventCombiner28;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent38;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent43;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent39;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent42;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp7;
  private SignalProcessingDataStore.OutboundSignalMultiplexer _objSignalProcessingSignalMultiplexer29;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve36;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve37;
  private SignalProcessingDataStore.OutboundSignalEventCombiner _objSignalProcessingSignalEventCombiner40;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent9;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent13;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent12;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent15;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent19;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent18;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent21;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent25;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent24;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp35;
  private SignalProcessingDataStore.OutboundSignalMultiplexer _objSignalProcessingSignalMultiplexer41;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator0;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator2;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator4;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve8;
  private SignalProcessingDataStore.OutboundSignalEventCombiner _objSignalProcessingSignalEventCombiner10;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve14;
  private SignalProcessingDataStore.OutboundSignalEventCombiner _objSignalProcessingSignalEventCombiner16;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve20;
  private SignalProcessingDataStore.OutboundSignalEventCombiner _objSignalProcessingSignalEventCombiner22;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp44;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp45;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp1;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp3;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp5;
  private SignalProcessingDataStore.OutboundSignalMultiplexer _objSignalProcessingSignalMultiplexer11;
  private SignalProcessingDataStore.OutboundSignalMultiplexer _objSignalProcessingSignalMultiplexer17;
  private SignalProcessingDataStore.OutboundSignalMultiplexer _objSignalProcessingSignalMultiplexer23;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack46;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp32;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp33;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp34;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice47;

  public PulsePattern(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing) {
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

  ~PulsePattern() {
    Dispose(false);
  }

  public float GetFq() {
    return _paramFq;
  }

  public void SetFq(float Fq) {
    _paramFq = Fq;
    if (_objSignalProcessingSignalOscillator0 != null) {
      _objSignalProcessingSignalOscillator0.SetFrequency(Fq);
    }
    if (_objSignalProcessingSignalOscillator2 != null) {
      _objSignalProcessingSignalOscillator2.SetFrequency(Fq);
    }
    if (_objSignalProcessingSignalOscillator4 != null) {
      _objSignalProcessingSignalOscillator4.SetFrequency(Fq);
    }
    if (_objSignalProcessingSignalOscillator6 != null) {
      _objSignalProcessingSignalOscillator6.SetFrequency(Fq);
    }
  }

  public float GetPauseDuration() {
    return _paramPauseDuration;
  }

  public void SetPauseDuration(float PauseDuration) {
    _paramPauseDuration = PauseDuration;
    if (_objSignalProcessingSignalCurve37 != null) {
      _objSignalProcessingSignalCurve37.SetSegmentLength2(PauseDuration);
    }
  }

  public float GetPulseDuration() {
    return _paramPulseDuration;
  }

  public void SetPulseDuration(float PulseDuration) {
    _paramPulseDuration = PulseDuration;
    if (_objSignalProcessingSignalCurve36 != null) {
      _objSignalProcessingSignalCurve36.SetSegmentLength2(PulseDuration);
    }
  }

  public float GetSawAmp() {
    return _paramSawAmp;
  }

  public void SetSawAmp(float SawAmp) {
    _paramSawAmp = SawAmp;
    if (_objSignalProcessingSignalMathOp3 != null) {
      _objSignalProcessingSignalMathOp3.SetOperandB(SawAmp);
    }
    if (_objSignalProcessingSignalCurve14 != null) {
      _objSignalProcessingSignalCurve14.SetSegmentEndValue1(SawAmp);
    }
    if (_objSignalProcessingSignalCurve14 != null) {
      _objSignalProcessingSignalCurve14.SetSegmentEndValue2(SawAmp);
    }
  }

  public float GetSinAmp() {
    return _paramSinAmp;
  }

  public void SetSinAmp(float SinAmp) {
    _paramSinAmp = SinAmp;
    if (_objSignalProcessingSignalMathOp1 != null) {
      _objSignalProcessingSignalMathOp1.SetOperandB(SinAmp);
    }
    if (_objSignalProcessingSignalCurve8 != null) {
      _objSignalProcessingSignalCurve8.SetSegmentEndValue1(SinAmp);
    }
    if (_objSignalProcessingSignalCurve8 != null) {
      _objSignalProcessingSignalCurve8.SetSegmentEndValue2(SinAmp);
    }
  }

  public float GetSquareAmp() {
    return _paramSquareAmp;
  }

  public void SetSquareAmp(float SquareAmp) {
    _paramSquareAmp = SquareAmp;
    if (_objSignalProcessingSignalMathOp7 != null) {
      _objSignalProcessingSignalMathOp7.SetOperandB(SquareAmp);
    }
    if (_objSignalProcessingSignalCurve26 != null) {
      _objSignalProcessingSignalCurve26.SetSegmentEndValue1(SquareAmp);
    }
    if (_objSignalProcessingSignalCurve26 != null) {
      _objSignalProcessingSignalCurve26.SetSegmentEndValue2(SquareAmp);
    }
  }

  public float GetTriAmp() {
    return _paramTriAmp;
  }

  public void SetTriAmp(float TriAmp) {
    _paramTriAmp = TriAmp;
    if (_objSignalProcessingSignalMathOp5 != null) {
      _objSignalProcessingSignalMathOp5.SetOperandB(TriAmp);
    }
    if (_objSignalProcessingSignalCurve20 != null) {
      _objSignalProcessingSignalCurve20.SetSegmentEndValue1(TriAmp);
    }
    if (_objSignalProcessingSignalCurve20 != null) {
      _objSignalProcessingSignalCurve20.SetSegmentEndValue2(TriAmp);
    }
  }

  void CreateObjects() {
    _objSignalProcessingSignalEvent27 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent27);
    _objSignalProcessingSignalEvent31 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent31);
    _objSignalProcessingSignalEvent30 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent30);
    _objSignalProcessingSignalOscillator6 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator6);
    _objSignalProcessingSignalCurve26 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve26);
    _objSignalProcessingSignalEventCombiner28 = new SignalProcessingDataStore.OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalProcessingSignalEventCombiner28);
    _objSignalProcessingSignalEvent38 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent38);
    _objSignalProcessingSignalEvent43 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent43);
    _objSignalProcessingSignalEvent39 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent39);
    _objSignalProcessingSignalEvent42 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent42);
    _objSignalProcessingSignalMathOp7 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp7);
    _objSignalProcessingSignalMultiplexer29 = new SignalProcessingDataStore.OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalProcessingSignalMultiplexer29);
    _objSignalProcessingSignalCurve36 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve36);
    _objSignalProcessingSignalCurve37 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve37);
    _objSignalProcessingSignalEventCombiner40 = new SignalProcessingDataStore.OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalProcessingSignalEventCombiner40);
    _objSignalProcessingSignalEvent9 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent9);
    _objSignalProcessingSignalEvent13 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent13);
    _objSignalProcessingSignalEvent12 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent12);
    _objSignalProcessingSignalEvent15 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent15);
    _objSignalProcessingSignalEvent19 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent19);
    _objSignalProcessingSignalEvent18 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent18);
    _objSignalProcessingSignalEvent21 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent21);
    _objSignalProcessingSignalEvent25 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent25);
    _objSignalProcessingSignalEvent24 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent24);
    _objSignalProcessingSignalMathOp35 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp35);
    _objSignalProcessingSignalMultiplexer41 = new SignalProcessingDataStore.OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalProcessingSignalMultiplexer41);
    _objSignalProcessingSignalOscillator0 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalOscillator2 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator2);
    _objSignalProcessingSignalOscillator4 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator4);
    _objSignalProcessingSignalCurve8 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve8);
    _objSignalProcessingSignalEventCombiner10 = new SignalProcessingDataStore.OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalProcessingSignalEventCombiner10);
    _objSignalProcessingSignalCurve14 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve14);
    _objSignalProcessingSignalEventCombiner16 = new SignalProcessingDataStore.OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalProcessingSignalEventCombiner16);
    _objSignalProcessingSignalCurve20 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve20);
    _objSignalProcessingSignalEventCombiner22 = new SignalProcessingDataStore.OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalProcessingSignalEventCombiner22);
    _objSignalProcessingSignalMathOp44 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp44);
    _objSignalProcessingSignalMathOp45 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp45);
    _objSignalProcessingSignalMathOp1 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp3 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalMathOp5 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp5);
    _objSignalProcessingSignalMultiplexer11 = new SignalProcessingDataStore.OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalProcessingSignalMultiplexer11);
    _objSignalProcessingSignalMultiplexer17 = new SignalProcessingDataStore.OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalProcessingSignalMultiplexer17);
    _objSignalProcessingSignalMultiplexer23 = new SignalProcessingDataStore.OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalProcessingSignalMultiplexer23);
    _objSignalProcessingSignalChannelStack46 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack46);
    _objSignalProcessingSignalMathOp32 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp32);
    _objSignalProcessingSignalMathOp33 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp33);
    _objSignalProcessingSignalMathOp34 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp34);
    _objSignalProcessingSignalOutputDevice47 = new SignalProcessingDataStore.OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalProcessingSignalOutputDevice47);
    _objSignalProcessingSignalOscillator6.SetNumChannels(1);
    _objSignalProcessingSignalOscillator6.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(1));
    _objSignalProcessingSignalOscillator6.SetFrequency(_paramFq);
    _objSignalProcessingSignalOscillator6.SetPulseWidth(0.5f);
    _objSignalProcessingSignalOscillator6.SetNumOutputs(1);
    _objSignalProcessingSignalCurve26.SetSoftCurve(true);
    _objSignalProcessingSignalCurve26.SetNumSegments(5);
    _objSignalProcessingSignalCurve26.SetStartValue(0f);
    _objSignalProcessingSignalCurve26.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve26.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve26.SetSegmentLength1(0f);
    _objSignalProcessingSignalCurve26.SetSegmentEndValue1(_paramSquareAmp);
    _objSignalProcessingSignalCurve26.SetSegmentLength2(60f);
    _objSignalProcessingSignalCurve26.SetSegmentEndValue2(_paramSquareAmp);
    _objSignalProcessingSignalCurve26.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve26.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve26.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve26.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve26.SetAutoStart(true);
    _objSignalProcessingSignalCurve26.SetAutoLoop(false);
    _objSignalProcessingSignalCurve26.SetOnDoneEvent(_objSignalProcessingSignalEvent27);
    _objSignalProcessingSignalCurve26.SetNumOutputs(1);
    _objSignalProcessingSignalCurve26.SetStartEvent(_objSignalProcessingSignalEvent31);
    _objSignalProcessingSignalEventCombiner28.SetSrcEvent0(_objSignalProcessingSignalEvent27);
    _objSignalProcessingSignalEventCombiner28.SetOnEvent(_objSignalProcessingSignalEvent30);
    _objSignalProcessingSignalMathOp7.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp7.SetOperandANode(_objSignalProcessingSignalOscillator6);
    _objSignalProcessingSignalMathOp7.SetOperandB(_paramSquareAmp);
    _objSignalProcessingSignalMathOp7.SetNumChannels(1);
    _objSignalProcessingSignalMathOp7.SetNumOutputs(1);
    _objSignalProcessingSignalMultiplexer29.SetSrcNode0(_objSignalProcessingSignalCurve26);
    _objSignalProcessingSignalMultiplexer29.SetIncrementEvent(_objSignalProcessingSignalEvent30);
    _objSignalProcessingSignalMultiplexer29.SetAutoStart(true);
    _objSignalProcessingSignalMultiplexer29.SetNumChannels(1);
    _objSignalProcessingSignalMultiplexer29.SetOnDoneEvent(_objSignalProcessingSignalEvent31);
    _objSignalProcessingSignalMultiplexer29.SetStartEvent(_objSignalProcessingSignalEvent31);
    _objSignalProcessingSignalMultiplexer29.SetNumOutputs(1);
    _objSignalProcessingSignalCurve36.SetSoftCurve(true);
    _objSignalProcessingSignalCurve36.SetNumSegments(5);
    _objSignalProcessingSignalCurve36.SetStartValue(0f);
    _objSignalProcessingSignalCurve36.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve36.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve36.SetSegmentLength1(0f);
    _objSignalProcessingSignalCurve36.SetSegmentEndValue1(1f);
    _objSignalProcessingSignalCurve36.SetSegmentLength2(_paramPulseDuration);
    _objSignalProcessingSignalCurve36.SetSegmentEndValue2(1f);
    _objSignalProcessingSignalCurve36.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve36.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve36.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve36.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve36.SetAutoStart(true);
    _objSignalProcessingSignalCurve36.SetAutoLoop(false);
    _objSignalProcessingSignalCurve36.SetOnDoneEvent(_objSignalProcessingSignalEvent38);
    _objSignalProcessingSignalCurve36.SetNumOutputs(1);
    _objSignalProcessingSignalCurve36.SetStartEvent(_objSignalProcessingSignalEvent43);
    _objSignalProcessingSignalCurve37.SetSoftCurve(true);
    _objSignalProcessingSignalCurve37.SetNumSegments(5);
    _objSignalProcessingSignalCurve37.SetStartValue(0f);
    _objSignalProcessingSignalCurve37.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve37.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve37.SetSegmentLength1(0f);
    _objSignalProcessingSignalCurve37.SetSegmentEndValue1(0f);
    _objSignalProcessingSignalCurve37.SetSegmentLength2(_paramPauseDuration);
    _objSignalProcessingSignalCurve37.SetSegmentEndValue2(0f);
    _objSignalProcessingSignalCurve37.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve37.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve37.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve37.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve37.SetAutoStart(false);
    _objSignalProcessingSignalCurve37.SetAutoLoop(false);
    _objSignalProcessingSignalCurve37.SetStartEvent(_objSignalProcessingSignalEvent38);
    _objSignalProcessingSignalCurve37.SetOnDoneEvent(_objSignalProcessingSignalEvent39);
    _objSignalProcessingSignalCurve37.SetNumOutputs(1);
    _objSignalProcessingSignalEventCombiner40.SetSrcEvent0(_objSignalProcessingSignalEvent38);
    _objSignalProcessingSignalEventCombiner40.SetSrcEvent1(_objSignalProcessingSignalEvent39);
    _objSignalProcessingSignalEventCombiner40.SetOnEvent(_objSignalProcessingSignalEvent42);
    _objSignalProcessingSignalMathOp35.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp35.SetOperandANode(_objSignalProcessingSignalMathOp7);
    _objSignalProcessingSignalMathOp35.SetOperandBNode(_objSignalProcessingSignalMultiplexer29);
    _objSignalProcessingSignalMathOp35.SetNumChannels(1);
    _objSignalProcessingSignalMathOp35.SetNumOutputs(2);
    _objSignalProcessingSignalMultiplexer41.SetSrcNode0(_objSignalProcessingSignalCurve36);
    _objSignalProcessingSignalMultiplexer41.SetSrcNode1(_objSignalProcessingSignalCurve37);
    _objSignalProcessingSignalMultiplexer41.SetIncrementEvent(_objSignalProcessingSignalEvent42);
    _objSignalProcessingSignalMultiplexer41.SetAutoStart(true);
    _objSignalProcessingSignalMultiplexer41.SetNumChannels(1);
    _objSignalProcessingSignalMultiplexer41.SetOnDoneEvent(_objSignalProcessingSignalEvent43);
    _objSignalProcessingSignalMultiplexer41.SetStartEvent(_objSignalProcessingSignalEvent43);
    _objSignalProcessingSignalMultiplexer41.SetNumOutputs(2);
    _objSignalProcessingSignalOscillator0.SetNumChannels(1);
    _objSignalProcessingSignalOscillator0.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(3));
    _objSignalProcessingSignalOscillator0.SetFrequency(_paramFq);
    _objSignalProcessingSignalOscillator0.SetPulseWidth(0.5f);
    _objSignalProcessingSignalOscillator0.SetNumOutputs(1);
    _objSignalProcessingSignalOscillator2.SetNumChannels(1);
    _objSignalProcessingSignalOscillator2.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(0));
    _objSignalProcessingSignalOscillator2.SetFrequency(_paramFq);
    _objSignalProcessingSignalOscillator2.SetPulseWidth(0.5f);
    _objSignalProcessingSignalOscillator2.SetNumOutputs(1);
    _objSignalProcessingSignalOscillator4.SetNumChannels(1);
    _objSignalProcessingSignalOscillator4.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(2));
    _objSignalProcessingSignalOscillator4.SetFrequency(_paramFq);
    _objSignalProcessingSignalOscillator4.SetPulseWidth(0.5f);
    _objSignalProcessingSignalOscillator4.SetNumOutputs(1);
    _objSignalProcessingSignalCurve8.SetSoftCurve(true);
    _objSignalProcessingSignalCurve8.SetNumSegments(5);
    _objSignalProcessingSignalCurve8.SetStartValue(0f);
    _objSignalProcessingSignalCurve8.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve8.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve8.SetSegmentLength1(0f);
    _objSignalProcessingSignalCurve8.SetSegmentEndValue1(_paramSinAmp);
    _objSignalProcessingSignalCurve8.SetSegmentLength2(60f);
    _objSignalProcessingSignalCurve8.SetSegmentEndValue2(_paramSinAmp);
    _objSignalProcessingSignalCurve8.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve8.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve8.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve8.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve8.SetAutoStart(true);
    _objSignalProcessingSignalCurve8.SetAutoLoop(false);
    _objSignalProcessingSignalCurve8.SetOnDoneEvent(_objSignalProcessingSignalEvent9);
    _objSignalProcessingSignalCurve8.SetNumOutputs(1);
    _objSignalProcessingSignalCurve8.SetStartEvent(_objSignalProcessingSignalEvent13);
    _objSignalProcessingSignalEventCombiner10.SetSrcEvent0(_objSignalProcessingSignalEvent9);
    _objSignalProcessingSignalEventCombiner10.SetOnEvent(_objSignalProcessingSignalEvent12);
    _objSignalProcessingSignalCurve14.SetSoftCurve(true);
    _objSignalProcessingSignalCurve14.SetNumSegments(5);
    _objSignalProcessingSignalCurve14.SetStartValue(0f);
    _objSignalProcessingSignalCurve14.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve14.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve14.SetSegmentLength1(0f);
    _objSignalProcessingSignalCurve14.SetSegmentEndValue1(_paramSawAmp);
    _objSignalProcessingSignalCurve14.SetSegmentLength2(60f);
    _objSignalProcessingSignalCurve14.SetSegmentEndValue2(_paramSawAmp);
    _objSignalProcessingSignalCurve14.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve14.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve14.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve14.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve14.SetAutoStart(true);
    _objSignalProcessingSignalCurve14.SetAutoLoop(false);
    _objSignalProcessingSignalCurve14.SetOnDoneEvent(_objSignalProcessingSignalEvent15);
    _objSignalProcessingSignalCurve14.SetNumOutputs(1);
    _objSignalProcessingSignalCurve14.SetStartEvent(_objSignalProcessingSignalEvent19);
    _objSignalProcessingSignalEventCombiner16.SetSrcEvent0(_objSignalProcessingSignalEvent15);
    _objSignalProcessingSignalEventCombiner16.SetOnEvent(_objSignalProcessingSignalEvent18);
    _objSignalProcessingSignalCurve20.SetSoftCurve(true);
    _objSignalProcessingSignalCurve20.SetNumSegments(5);
    _objSignalProcessingSignalCurve20.SetStartValue(0f);
    _objSignalProcessingSignalCurve20.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve20.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve20.SetSegmentLength1(0f);
    _objSignalProcessingSignalCurve20.SetSegmentEndValue1(_paramTriAmp);
    _objSignalProcessingSignalCurve20.SetSegmentLength2(60f);
    _objSignalProcessingSignalCurve20.SetSegmentEndValue2(_paramTriAmp);
    _objSignalProcessingSignalCurve20.SetSegmentLength3(0f);
    _objSignalProcessingSignalCurve20.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve20.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve20.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve20.SetAutoStart(true);
    _objSignalProcessingSignalCurve20.SetAutoLoop(false);
    _objSignalProcessingSignalCurve20.SetOnDoneEvent(_objSignalProcessingSignalEvent21);
    _objSignalProcessingSignalCurve20.SetNumOutputs(1);
    _objSignalProcessingSignalCurve20.SetStartEvent(_objSignalProcessingSignalEvent25);
    _objSignalProcessingSignalEventCombiner22.SetSrcEvent0(_objSignalProcessingSignalEvent21);
    _objSignalProcessingSignalEventCombiner22.SetOnEvent(_objSignalProcessingSignalEvent24);
    _objSignalProcessingSignalMathOp44.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp44.SetOperandANode(_objSignalProcessingSignalMathOp35);
    _objSignalProcessingSignalMathOp44.SetOperandBNode(_objSignalProcessingSignalMultiplexer41);
    _objSignalProcessingSignalMathOp44.SetNumChannels(1);
    _objSignalProcessingSignalMathOp44.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp45.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp45.SetOperandANode(_objSignalProcessingSignalMathOp35);
    _objSignalProcessingSignalMathOp45.SetOperandBNode(_objSignalProcessingSignalMultiplexer41);
    _objSignalProcessingSignalMathOp45.SetNumChannels(1);
    _objSignalProcessingSignalMathOp45.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp1.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp1.SetOperandANode(_objSignalProcessingSignalOscillator0);
    _objSignalProcessingSignalMathOp1.SetOperandB(_paramSinAmp);
    _objSignalProcessingSignalMathOp1.SetNumChannels(1);
    _objSignalProcessingSignalMathOp1.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp3.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp3.SetOperandANode(_objSignalProcessingSignalOscillator2);
    _objSignalProcessingSignalMathOp3.SetOperandB(_paramSawAmp);
    _objSignalProcessingSignalMathOp3.SetNumChannels(1);
    _objSignalProcessingSignalMathOp3.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp5.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp5.SetOperandANode(_objSignalProcessingSignalOscillator4);
    _objSignalProcessingSignalMathOp5.SetOperandB(_paramTriAmp);
    _objSignalProcessingSignalMathOp5.SetNumChannels(1);
    _objSignalProcessingSignalMathOp5.SetNumOutputs(1);
    _objSignalProcessingSignalMultiplexer11.SetSrcNode0(_objSignalProcessingSignalCurve8);
    _objSignalProcessingSignalMultiplexer11.SetIncrementEvent(_objSignalProcessingSignalEvent12);
    _objSignalProcessingSignalMultiplexer11.SetAutoStart(true);
    _objSignalProcessingSignalMultiplexer11.SetNumChannels(1);
    _objSignalProcessingSignalMultiplexer11.SetOnDoneEvent(_objSignalProcessingSignalEvent13);
    _objSignalProcessingSignalMultiplexer11.SetStartEvent(_objSignalProcessingSignalEvent13);
    _objSignalProcessingSignalMultiplexer11.SetNumOutputs(1);
    _objSignalProcessingSignalMultiplexer17.SetSrcNode0(_objSignalProcessingSignalCurve14);
    _objSignalProcessingSignalMultiplexer17.SetIncrementEvent(_objSignalProcessingSignalEvent18);
    _objSignalProcessingSignalMultiplexer17.SetAutoStart(true);
    _objSignalProcessingSignalMultiplexer17.SetNumChannels(1);
    _objSignalProcessingSignalMultiplexer17.SetOnDoneEvent(_objSignalProcessingSignalEvent19);
    _objSignalProcessingSignalMultiplexer17.SetStartEvent(_objSignalProcessingSignalEvent19);
    _objSignalProcessingSignalMultiplexer17.SetNumOutputs(1);
    _objSignalProcessingSignalMultiplexer23.SetSrcNode0(_objSignalProcessingSignalCurve20);
    _objSignalProcessingSignalMultiplexer23.SetIncrementEvent(_objSignalProcessingSignalEvent24);
    _objSignalProcessingSignalMultiplexer23.SetAutoStart(true);
    _objSignalProcessingSignalMultiplexer23.SetNumChannels(1);
    _objSignalProcessingSignalMultiplexer23.SetOnDoneEvent(_objSignalProcessingSignalEvent25);
    _objSignalProcessingSignalMultiplexer23.SetStartEvent(_objSignalProcessingSignalEvent25);
    _objSignalProcessingSignalMultiplexer23.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack46.SetSrcNode0(_objSignalProcessingSignalMathOp44);
    _objSignalProcessingSignalChannelStack46.SetSrcNode1(_objSignalProcessingSignalMathOp45);
    _objSignalProcessingSignalChannelStack46.SetNumChannels(2);
    _objSignalProcessingSignalChannelStack46.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp32.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp32.SetOperandANode(_objSignalProcessingSignalMathOp1);
    _objSignalProcessingSignalMathOp32.SetOperandBNode(_objSignalProcessingSignalMultiplexer11);
    _objSignalProcessingSignalMathOp32.SetNumChannels(1);
    _objSignalProcessingSignalMathOp33.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp33.SetOperandANode(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalMathOp33.SetOperandBNode(_objSignalProcessingSignalMultiplexer17);
    _objSignalProcessingSignalMathOp33.SetNumChannels(1);
    _objSignalProcessingSignalMathOp34.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp34.SetOperandANode(_objSignalProcessingSignalMathOp5);
    _objSignalProcessingSignalMathOp34.SetOperandBNode(_objSignalProcessingSignalMultiplexer23);
    _objSignalProcessingSignalMathOp34.SetNumChannels(1);
    _objSignalProcessingSignalOutputDevice47.SetSrcNode(_objSignalProcessingSignalChannelStack46);
    _objSignalProcessingSignalOutputDevice47.SetDeviceNameFilter("BuzzDuino");
    _objSignalProcessingSignalOutputDevice47.SetChannelOffset(0);
  }

  void DestroyObjects() {
    if (_objSignalProcessingSignalOutputDevice47 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalProcessingSignalOutputDevice47.GetXrpaId());
      _objSignalProcessingSignalOutputDevice47 = null;
    }
    if (_objSignalProcessingSignalMathOp34 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp34.GetXrpaId());
      _objSignalProcessingSignalMathOp34 = null;
    }
    if (_objSignalProcessingSignalMathOp33 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp33.GetXrpaId());
      _objSignalProcessingSignalMathOp33 = null;
    }
    if (_objSignalProcessingSignalMathOp32 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp32.GetXrpaId());
      _objSignalProcessingSignalMathOp32 = null;
    }
    if (_objSignalProcessingSignalChannelStack46 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack46.GetXrpaId());
      _objSignalProcessingSignalChannelStack46 = null;
    }
    if (_objSignalProcessingSignalMultiplexer23 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalProcessingSignalMultiplexer23.GetXrpaId());
      _objSignalProcessingSignalMultiplexer23 = null;
    }
    if (_objSignalProcessingSignalMultiplexer17 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalProcessingSignalMultiplexer17.GetXrpaId());
      _objSignalProcessingSignalMultiplexer17 = null;
    }
    if (_objSignalProcessingSignalMultiplexer11 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalProcessingSignalMultiplexer11.GetXrpaId());
      _objSignalProcessingSignalMultiplexer11 = null;
    }
    if (_objSignalProcessingSignalMathOp5 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp5.GetXrpaId());
      _objSignalProcessingSignalMathOp5 = null;
    }
    if (_objSignalProcessingSignalMathOp3 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp3.GetXrpaId());
      _objSignalProcessingSignalMathOp3 = null;
    }
    if (_objSignalProcessingSignalMathOp1 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp1.GetXrpaId());
      _objSignalProcessingSignalMathOp1 = null;
    }
    if (_objSignalProcessingSignalMathOp45 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp45.GetXrpaId());
      _objSignalProcessingSignalMathOp45 = null;
    }
    if (_objSignalProcessingSignalMathOp44 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp44.GetXrpaId());
      _objSignalProcessingSignalMathOp44 = null;
    }
    if (_objSignalProcessingSignalEventCombiner22 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalProcessingSignalEventCombiner22.GetXrpaId());
      _objSignalProcessingSignalEventCombiner22 = null;
    }
    if (_objSignalProcessingSignalCurve20 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve20.GetXrpaId());
      _objSignalProcessingSignalCurve20 = null;
    }
    if (_objSignalProcessingSignalEventCombiner16 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalProcessingSignalEventCombiner16.GetXrpaId());
      _objSignalProcessingSignalEventCombiner16 = null;
    }
    if (_objSignalProcessingSignalCurve14 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve14.GetXrpaId());
      _objSignalProcessingSignalCurve14 = null;
    }
    if (_objSignalProcessingSignalEventCombiner10 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalProcessingSignalEventCombiner10.GetXrpaId());
      _objSignalProcessingSignalEventCombiner10 = null;
    }
    if (_objSignalProcessingSignalCurve8 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve8.GetXrpaId());
      _objSignalProcessingSignalCurve8 = null;
    }
    if (_objSignalProcessingSignalOscillator4 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalProcessingSignalOscillator4.GetXrpaId());
      _objSignalProcessingSignalOscillator4 = null;
    }
    if (_objSignalProcessingSignalOscillator2 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalProcessingSignalOscillator2.GetXrpaId());
      _objSignalProcessingSignalOscillator2 = null;
    }
    if (_objSignalProcessingSignalOscillator0 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalProcessingSignalOscillator0.GetXrpaId());
      _objSignalProcessingSignalOscillator0 = null;
    }
    if (_objSignalProcessingSignalMultiplexer41 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalProcessingSignalMultiplexer41.GetXrpaId());
      _objSignalProcessingSignalMultiplexer41 = null;
    }
    if (_objSignalProcessingSignalMathOp35 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp35.GetXrpaId());
      _objSignalProcessingSignalMathOp35 = null;
    }
    if (_objSignalProcessingSignalEvent24 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent24.GetXrpaId());
      _objSignalProcessingSignalEvent24 = null;
    }
    if (_objSignalProcessingSignalEvent25 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent25.GetXrpaId());
      _objSignalProcessingSignalEvent25 = null;
    }
    if (_objSignalProcessingSignalEvent21 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent21.GetXrpaId());
      _objSignalProcessingSignalEvent21 = null;
    }
    if (_objSignalProcessingSignalEvent18 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent18.GetXrpaId());
      _objSignalProcessingSignalEvent18 = null;
    }
    if (_objSignalProcessingSignalEvent19 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent19.GetXrpaId());
      _objSignalProcessingSignalEvent19 = null;
    }
    if (_objSignalProcessingSignalEvent15 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent15.GetXrpaId());
      _objSignalProcessingSignalEvent15 = null;
    }
    if (_objSignalProcessingSignalEvent12 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent12.GetXrpaId());
      _objSignalProcessingSignalEvent12 = null;
    }
    if (_objSignalProcessingSignalEvent13 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent13.GetXrpaId());
      _objSignalProcessingSignalEvent13 = null;
    }
    if (_objSignalProcessingSignalEvent9 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent9.GetXrpaId());
      _objSignalProcessingSignalEvent9 = null;
    }
    if (_objSignalProcessingSignalEventCombiner40 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalProcessingSignalEventCombiner40.GetXrpaId());
      _objSignalProcessingSignalEventCombiner40 = null;
    }
    if (_objSignalProcessingSignalCurve37 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve37.GetXrpaId());
      _objSignalProcessingSignalCurve37 = null;
    }
    if (_objSignalProcessingSignalCurve36 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve36.GetXrpaId());
      _objSignalProcessingSignalCurve36 = null;
    }
    if (_objSignalProcessingSignalMultiplexer29 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalProcessingSignalMultiplexer29.GetXrpaId());
      _objSignalProcessingSignalMultiplexer29 = null;
    }
    if (_objSignalProcessingSignalMathOp7 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp7.GetXrpaId());
      _objSignalProcessingSignalMathOp7 = null;
    }
    if (_objSignalProcessingSignalEvent42 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent42.GetXrpaId());
      _objSignalProcessingSignalEvent42 = null;
    }
    if (_objSignalProcessingSignalEvent39 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent39.GetXrpaId());
      _objSignalProcessingSignalEvent39 = null;
    }
    if (_objSignalProcessingSignalEvent43 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent43.GetXrpaId());
      _objSignalProcessingSignalEvent43 = null;
    }
    if (_objSignalProcessingSignalEvent38 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent38.GetXrpaId());
      _objSignalProcessingSignalEvent38 = null;
    }
    if (_objSignalProcessingSignalEventCombiner28 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalProcessingSignalEventCombiner28.GetXrpaId());
      _objSignalProcessingSignalEventCombiner28 = null;
    }
    if (_objSignalProcessingSignalCurve26 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve26.GetXrpaId());
      _objSignalProcessingSignalCurve26 = null;
    }
    if (_objSignalProcessingSignalOscillator6 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalProcessingSignalOscillator6.GetXrpaId());
      _objSignalProcessingSignalOscillator6 = null;
    }
    if (_objSignalProcessingSignalEvent30 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent30.GetXrpaId());
      _objSignalProcessingSignalEvent30 = null;
    }
    if (_objSignalProcessingSignalEvent31 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent31.GetXrpaId());
      _objSignalProcessingSignalEvent31 = null;
    }
    if (_objSignalProcessingSignalEvent27 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent27.GetXrpaId());
      _objSignalProcessingSignalEvent27 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace XrpaDataflow
