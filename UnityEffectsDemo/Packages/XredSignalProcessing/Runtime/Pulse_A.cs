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

public class Pulse_A : IDisposable {
  private SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramFundamentalAmp = 1f;
  private float _paramFundamentalFq = 170f;
  private float _paramGain0 = 1f;
  private float _paramGain1 = 1f;
  private float _paramGain2 = 1f;
  private float _paramGain3 = 1f;
  private float _paramGain4 = 1f;
  private OutboundSignalOscillator _objSignalOscillator33;
  private OutboundSignalEvent _objSignalEvent36;
  private OutboundSignalEvent _objSignalEvent39;
  private OutboundSignalMathOp _objSignalMathOp34;
  private OutboundSignalCurve _objSignalCurve35;
  private OutboundSignalEventCombiner _objSignalEventCombiner37;
  private OutboundSignalEvent _objSignalEvent40;
  private OutboundSignalMathOp _objSignalMathOp41;
  private OutboundSignalMultiplexer _objSignalMultiplexer38;
  private OutboundSignalMathOp _objSignalMathOp43;
  private OutboundSignalMathOp _objSignalMathOp45;
  private OutboundSignalMathOp _objSignalMathOp47;
  private OutboundSignalMathOp _objSignalMathOp42;
  private OutboundSignalMathOp _objSignalMathOp44;
  private OutboundSignalMathOp _objSignalMathOp46;
  private OutboundSignalMathOp _objSignalMathOp48;
  private OutboundSignalMathOp _objSignalMathOp49;
  private OutboundSignalChannelStack _objSignalChannelStack51;
  private OutboundSignalMathOp _objSignalMathOp50;
  private OutboundSignalChannelStack _objSignalChannelStack52;
  private OutboundSignalOutputDevice _objSignalOutputDevice53;

  public Pulse_A(SignalProcessingDataStore datastore) {
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

  ~Pulse_A() {
    Dispose(false);
  }

  public float GetFundamentalAmp() {
    return _paramFundamentalAmp;
  }

  public void SetFundamentalAmp(float FundamentalAmp) {
    _paramFundamentalAmp = FundamentalAmp;
    if (_objSignalMathOp34 != null) {
      _objSignalMathOp34.SetOperandB(FundamentalAmp);
    }
  }

  public float GetFundamentalFq() {
    return _paramFundamentalFq;
  }

  public void SetFundamentalFq(float FundamentalFq) {
    _paramFundamentalFq = FundamentalFq;
    if (_objSignalOscillator33 != null) {
      _objSignalOscillator33.SetFrequency(FundamentalFq);
    }
  }

  public float GetGain0() {
    return _paramGain0;
  }

  public void SetGain0(float Gain0) {
    _paramGain0 = Gain0;
    if (_objSignalMathOp41 != null) {
      _objSignalMathOp41.SetOperandB(Gain0);
    }
  }

  public float GetGain1() {
    return _paramGain1;
  }

  public void SetGain1(float Gain1) {
    _paramGain1 = Gain1;
    if (_objSignalMathOp43 != null) {
      _objSignalMathOp43.SetOperandB(Gain1);
    }
  }

  public float GetGain2() {
    return _paramGain2;
  }

  public void SetGain2(float Gain2) {
    _paramGain2 = Gain2;
    if (_objSignalMathOp45 != null) {
      _objSignalMathOp45.SetOperandB(Gain2);
    }
  }

  public float GetGain3() {
    return _paramGain3;
  }

  public void SetGain3(float Gain3) {
    _paramGain3 = Gain3;
    if (_objSignalMathOp47 != null) {
      _objSignalMathOp47.SetOperandB(Gain3);
    }
  }

  public float GetGain4() {
    return _paramGain4;
  }

  public void SetGain4(float Gain4) {
    _paramGain4 = Gain4;
    if (_objSignalMathOp49 != null) {
      _objSignalMathOp49.SetOperandB(Gain4);
    }
  }

  void CreateObjects() {
    _objSignalOscillator33 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator33);
    _objSignalEvent36 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent36);
    _objSignalEvent39 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent39);
    _objSignalMathOp34 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp34);
    _objSignalCurve35 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve35);
    _objSignalEventCombiner37 = new OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalEventCombiner37);
    _objSignalEvent40 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent40);
    _objSignalMathOp41 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp41);
    _objSignalMultiplexer38 = new OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalMultiplexer38);
    _objSignalMathOp43 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp43);
    _objSignalMathOp45 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp45);
    _objSignalMathOp47 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp47);
    _objSignalMathOp42 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp42);
    _objSignalMathOp44 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp44);
    _objSignalMathOp46 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp46);
    _objSignalMathOp48 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp48);
    _objSignalMathOp49 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp49);
    _objSignalChannelStack51 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack51);
    _objSignalMathOp50 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp50);
    _objSignalChannelStack52 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack52);
    _objSignalOutputDevice53 = new OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalOutputDevice53);
    _objSignalOscillator33.SetNumChannels(1);
    _objSignalOscillator33.SetWaveformType((WaveformType)(uint)(1));
    _objSignalOscillator33.SetFrequency(_paramFundamentalFq);
    _objSignalOscillator33.SetPulseWidth(0.5f);
    _objSignalOscillator33.SetNumOutputs(1);
    _objSignalMathOp34.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp34.SetOperandANode(_objSignalOscillator33);
    _objSignalMathOp34.SetOperandB(_paramFundamentalAmp);
    _objSignalMathOp34.SetNumChannels(1);
    _objSignalMathOp34.SetNumOutputs(5);
    _objSignalCurve35.SetSoftCurve(true);
    _objSignalCurve35.SetNumSegments(5);
    _objSignalCurve35.SetStartValue(0f);
    _objSignalCurve35.SetSegmentLength0(0f);
    _objSignalCurve35.SetSegmentEndValue0(0f);
    _objSignalCurve35.SetSegmentLength1(0f);
    _objSignalCurve35.SetSegmentEndValue1(1f);
    _objSignalCurve35.SetSegmentLength2(0.01f);
    _objSignalCurve35.SetSegmentEndValue2(1f);
    _objSignalCurve35.SetSegmentLength3(0f);
    _objSignalCurve35.SetSegmentEndValue3(0f);
    _objSignalCurve35.SetSegmentLength4(0f);
    _objSignalCurve35.SetSegmentEndValue4(0f);
    _objSignalCurve35.SetAutoStart(true);
    _objSignalCurve35.SetAutoLoop(false);
    _objSignalCurve35.SetOnDoneEvent(_objSignalEvent36);
    _objSignalCurve35.SetNumOutputs(1);
    _objSignalEventCombiner37.SetSrcEvent0(_objSignalEvent36);
    _objSignalEventCombiner37.SetOnEvent(_objSignalEvent39);
    _objSignalMathOp41.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp41.SetOperandANode(_objSignalMathOp34);
    _objSignalMathOp41.SetOperandB(_paramGain0);
    _objSignalMathOp41.SetNumChannels(1);
    _objSignalMathOp41.SetNumOutputs(1);
    _objSignalMultiplexer38.SetSrcNode0(_objSignalCurve35);
    _objSignalMultiplexer38.SetIncrementEvent(_objSignalEvent39);
    _objSignalMultiplexer38.SetAutoStart(true);
    _objSignalMultiplexer38.SetNumChannels(1);
    _objSignalMultiplexer38.SetOnDoneEvent(_objSignalEvent40);
    _objSignalMultiplexer38.SetNumOutputs(5);
    _objSignalMathOp43.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp43.SetOperandANode(_objSignalMathOp34);
    _objSignalMathOp43.SetOperandB(_paramGain1);
    _objSignalMathOp43.SetNumChannels(1);
    _objSignalMathOp43.SetNumOutputs(1);
    _objSignalMathOp45.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp45.SetOperandANode(_objSignalMathOp34);
    _objSignalMathOp45.SetOperandB(_paramGain2);
    _objSignalMathOp45.SetNumChannels(1);
    _objSignalMathOp45.SetNumOutputs(1);
    _objSignalMathOp47.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp47.SetOperandANode(_objSignalMathOp34);
    _objSignalMathOp47.SetOperandB(_paramGain3);
    _objSignalMathOp47.SetNumChannels(1);
    _objSignalMathOp47.SetNumOutputs(1);
    _objSignalMathOp42.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp42.SetOperandANode(_objSignalMathOp41);
    _objSignalMathOp42.SetOperandBNode(_objSignalMultiplexer38);
    _objSignalMathOp42.SetNumChannels(1);
    _objSignalMathOp42.SetNumOutputs(1);
    _objSignalMathOp44.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp44.SetOperandANode(_objSignalMathOp43);
    _objSignalMathOp44.SetOperandBNode(_objSignalMultiplexer38);
    _objSignalMathOp44.SetNumChannels(1);
    _objSignalMathOp44.SetNumOutputs(1);
    _objSignalMathOp46.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp46.SetOperandANode(_objSignalMathOp45);
    _objSignalMathOp46.SetOperandBNode(_objSignalMultiplexer38);
    _objSignalMathOp46.SetNumChannels(1);
    _objSignalMathOp46.SetNumOutputs(1);
    _objSignalMathOp48.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp48.SetOperandANode(_objSignalMathOp47);
    _objSignalMathOp48.SetOperandBNode(_objSignalMultiplexer38);
    _objSignalMathOp48.SetNumChannels(1);
    _objSignalMathOp48.SetNumOutputs(1);
    _objSignalMathOp49.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp49.SetOperandANode(_objSignalMathOp34);
    _objSignalMathOp49.SetOperandB(_paramGain4);
    _objSignalMathOp49.SetNumChannels(1);
    _objSignalMathOp49.SetNumOutputs(1);
    _objSignalChannelStack51.SetSrcNode0(_objSignalMathOp42);
    _objSignalChannelStack51.SetSrcNode1(_objSignalMathOp44);
    _objSignalChannelStack51.SetSrcNode2(_objSignalMathOp46);
    _objSignalChannelStack51.SetSrcNode3(_objSignalMathOp48);
    _objSignalChannelStack51.SetNumChannels(4);
    _objSignalChannelStack51.SetNumOutputs(1);
    _objSignalMathOp50.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp50.SetOperandANode(_objSignalMathOp49);
    _objSignalMathOp50.SetOperandBNode(_objSignalMultiplexer38);
    _objSignalMathOp50.SetNumChannels(1);
    _objSignalMathOp50.SetNumOutputs(1);
    _objSignalChannelStack52.SetSrcNode0(_objSignalChannelStack51);
    _objSignalChannelStack52.SetSrcNode1(_objSignalMathOp50);
    _objSignalChannelStack52.SetNumChannels(5);
    _objSignalChannelStack52.SetNumOutputs(1);
    _objSignalOutputDevice53.SetSrcNode(_objSignalChannelStack52);
    _objSignalOutputDevice53.SetDeviceNameFilter("HDK-1");
    _objSignalOutputDevice53.SetChannelOffset(0);
    if (_objSignalEvent40 != null) {
      _objSignalEvent40.OnReceiveEvent((_, _) => Terminate());
    }
  }

  void DestroyObjects() {
    if (_objSignalOutputDevice53 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalOutputDevice53.GetXrpaId());
      _objSignalOutputDevice53 = null;
    }
    if (_objSignalChannelStack52 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack52.GetXrpaId());
      _objSignalChannelStack52 = null;
    }
    if (_objSignalMathOp50 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp50.GetXrpaId());
      _objSignalMathOp50 = null;
    }
    if (_objSignalChannelStack51 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack51.GetXrpaId());
      _objSignalChannelStack51 = null;
    }
    if (_objSignalMathOp49 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp49.GetXrpaId());
      _objSignalMathOp49 = null;
    }
    if (_objSignalMathOp48 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp48.GetXrpaId());
      _objSignalMathOp48 = null;
    }
    if (_objSignalMathOp46 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp46.GetXrpaId());
      _objSignalMathOp46 = null;
    }
    if (_objSignalMathOp44 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp44.GetXrpaId());
      _objSignalMathOp44 = null;
    }
    if (_objSignalMathOp42 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp42.GetXrpaId());
      _objSignalMathOp42 = null;
    }
    if (_objSignalMathOp47 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp47.GetXrpaId());
      _objSignalMathOp47 = null;
    }
    if (_objSignalMathOp45 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp45.GetXrpaId());
      _objSignalMathOp45 = null;
    }
    if (_objSignalMathOp43 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp43.GetXrpaId());
      _objSignalMathOp43 = null;
    }
    if (_objSignalMultiplexer38 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalMultiplexer38.GetXrpaId());
      _objSignalMultiplexer38 = null;
    }
    if (_objSignalMathOp41 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp41.GetXrpaId());
      _objSignalMathOp41 = null;
    }
    if (_objSignalEvent40 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent40.GetXrpaId());
      _objSignalEvent40 = null;
    }
    if (_objSignalEventCombiner37 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalEventCombiner37.GetXrpaId());
      _objSignalEventCombiner37 = null;
    }
    if (_objSignalCurve35 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve35.GetXrpaId());
      _objSignalCurve35 = null;
    }
    if (_objSignalMathOp34 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp34.GetXrpaId());
      _objSignalMathOp34 = null;
    }
    if (_objSignalEvent39 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent39.GetXrpaId());
      _objSignalEvent39 = null;
    }
    if (_objSignalEvent36 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent36.GetXrpaId());
      _objSignalEvent36 = null;
    }
    if (_objSignalOscillator33 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator33.GetXrpaId());
      _objSignalOscillator33 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace SignalProcessingDataStore
