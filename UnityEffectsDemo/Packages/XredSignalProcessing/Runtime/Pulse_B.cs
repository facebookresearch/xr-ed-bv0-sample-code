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

public class Pulse_B : IDisposable {
  private SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramFundamentalAmp = 1f;
  private float _paramFundamentalFq = 250f;
  private float _paramGain0 = 1f;
  private float _paramGain1 = 1f;
  private float _paramGain2 = 1f;
  private float _paramGain3 = 1f;
  private float _paramGain4 = 1f;
  private OutboundSignalOscillator _objSignalOscillator54;
  private OutboundSignalEvent _objSignalEvent59;
  private OutboundSignalEvent _objSignalEvent60;
  private OutboundSignalEvent _objSignalEvent61;
  private OutboundSignalEvent _objSignalEvent64;
  private OutboundSignalMathOp _objSignalMathOp55;
  private OutboundSignalCurve _objSignalCurve56;
  private OutboundSignalCurve _objSignalCurve57;
  private OutboundSignalCurve _objSignalCurve58;
  private OutboundSignalEventCombiner _objSignalEventCombiner62;
  private OutboundSignalEvent _objSignalEvent65;
  private OutboundSignalMathOp _objSignalMathOp66;
  private OutboundSignalMultiplexer _objSignalMultiplexer63;
  private OutboundSignalMathOp _objSignalMathOp68;
  private OutboundSignalMathOp _objSignalMathOp70;
  private OutboundSignalMathOp _objSignalMathOp72;
  private OutboundSignalMathOp _objSignalMathOp67;
  private OutboundSignalMathOp _objSignalMathOp69;
  private OutboundSignalMathOp _objSignalMathOp71;
  private OutboundSignalMathOp _objSignalMathOp73;
  private OutboundSignalMathOp _objSignalMathOp74;
  private OutboundSignalChannelStack _objSignalChannelStack76;
  private OutboundSignalMathOp _objSignalMathOp75;
  private OutboundSignalChannelStack _objSignalChannelStack77;
  private OutboundSignalOutputDevice _objSignalOutputDevice78;

  public Pulse_B(SignalProcessingDataStore datastore) {
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

  ~Pulse_B() {
    Dispose(false);
  }

  public float GetFundamentalAmp() {
    return _paramFundamentalAmp;
  }

  public void SetFundamentalAmp(float FundamentalAmp) {
    _paramFundamentalAmp = FundamentalAmp;
    if (_objSignalMathOp55 != null) {
      _objSignalMathOp55.SetOperandB(FundamentalAmp);
    }
  }

  public float GetFundamentalFq() {
    return _paramFundamentalFq;
  }

  public void SetFundamentalFq(float FundamentalFq) {
    _paramFundamentalFq = FundamentalFq;
    if (_objSignalOscillator54 != null) {
      _objSignalOscillator54.SetFrequency(FundamentalFq);
    }
  }

  public float GetGain0() {
    return _paramGain0;
  }

  public void SetGain0(float Gain0) {
    _paramGain0 = Gain0;
    if (_objSignalMathOp66 != null) {
      _objSignalMathOp66.SetOperandB(Gain0);
    }
  }

  public float GetGain1() {
    return _paramGain1;
  }

  public void SetGain1(float Gain1) {
    _paramGain1 = Gain1;
    if (_objSignalMathOp68 != null) {
      _objSignalMathOp68.SetOperandB(Gain1);
    }
  }

  public float GetGain2() {
    return _paramGain2;
  }

  public void SetGain2(float Gain2) {
    _paramGain2 = Gain2;
    if (_objSignalMathOp70 != null) {
      _objSignalMathOp70.SetOperandB(Gain2);
    }
  }

  public float GetGain3() {
    return _paramGain3;
  }

  public void SetGain3(float Gain3) {
    _paramGain3 = Gain3;
    if (_objSignalMathOp72 != null) {
      _objSignalMathOp72.SetOperandB(Gain3);
    }
  }

  public float GetGain4() {
    return _paramGain4;
  }

  public void SetGain4(float Gain4) {
    _paramGain4 = Gain4;
    if (_objSignalMathOp74 != null) {
      _objSignalMathOp74.SetOperandB(Gain4);
    }
  }

  void CreateObjects() {
    _objSignalOscillator54 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator54);
    _objSignalEvent59 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent59);
    _objSignalEvent60 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent60);
    _objSignalEvent61 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent61);
    _objSignalEvent64 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent64);
    _objSignalMathOp55 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp55);
    _objSignalCurve56 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve56);
    _objSignalCurve57 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve57);
    _objSignalCurve58 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve58);
    _objSignalEventCombiner62 = new OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalEventCombiner62);
    _objSignalEvent65 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent65);
    _objSignalMathOp66 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp66);
    _objSignalMultiplexer63 = new OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalMultiplexer63);
    _objSignalMathOp68 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp68);
    _objSignalMathOp70 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp70);
    _objSignalMathOp72 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp72);
    _objSignalMathOp67 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp67);
    _objSignalMathOp69 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp69);
    _objSignalMathOp71 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp71);
    _objSignalMathOp73 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp73);
    _objSignalMathOp74 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp74);
    _objSignalChannelStack76 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack76);
    _objSignalMathOp75 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp75);
    _objSignalChannelStack77 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack77);
    _objSignalOutputDevice78 = new OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalOutputDevice78);
    _objSignalOscillator54.SetNumChannels(1);
    _objSignalOscillator54.SetWaveformType((WaveformType)(uint)(3));
    _objSignalOscillator54.SetFrequency(_paramFundamentalFq);
    _objSignalOscillator54.SetPulseWidth(0.5f);
    _objSignalOscillator54.SetNumOutputs(1);
    _objSignalMathOp55.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp55.SetOperandANode(_objSignalOscillator54);
    _objSignalMathOp55.SetOperandB(_paramFundamentalAmp);
    _objSignalMathOp55.SetNumChannels(1);
    _objSignalMathOp55.SetNumOutputs(5);
    _objSignalCurve56.SetSoftCurve(true);
    _objSignalCurve56.SetNumSegments(5);
    _objSignalCurve56.SetStartValue(0f);
    _objSignalCurve56.SetSegmentLength0(0f);
    _objSignalCurve56.SetSegmentEndValue0(0f);
    _objSignalCurve56.SetSegmentLength1(0f);
    _objSignalCurve56.SetSegmentEndValue1(0.25f);
    _objSignalCurve56.SetSegmentLength2(0.02f);
    _objSignalCurve56.SetSegmentEndValue2(0.25f);
    _objSignalCurve56.SetSegmentLength3(0f);
    _objSignalCurve56.SetSegmentEndValue3(0f);
    _objSignalCurve56.SetSegmentLength4(0f);
    _objSignalCurve56.SetSegmentEndValue4(0f);
    _objSignalCurve56.SetAutoStart(true);
    _objSignalCurve56.SetAutoLoop(false);
    _objSignalCurve56.SetOnDoneEvent(_objSignalEvent59);
    _objSignalCurve56.SetNumOutputs(1);
    _objSignalCurve57.SetSoftCurve(true);
    _objSignalCurve57.SetNumSegments(5);
    _objSignalCurve57.SetStartValue(0f);
    _objSignalCurve57.SetSegmentLength0(0f);
    _objSignalCurve57.SetSegmentEndValue0(0f);
    _objSignalCurve57.SetSegmentLength1(0f);
    _objSignalCurve57.SetSegmentEndValue1(0f);
    _objSignalCurve57.SetSegmentLength2(0.08f);
    _objSignalCurve57.SetSegmentEndValue2(0f);
    _objSignalCurve57.SetSegmentLength3(0f);
    _objSignalCurve57.SetSegmentEndValue3(0f);
    _objSignalCurve57.SetSegmentLength4(0f);
    _objSignalCurve57.SetSegmentEndValue4(0f);
    _objSignalCurve57.SetAutoStart(false);
    _objSignalCurve57.SetAutoLoop(false);
    _objSignalCurve57.SetStartEvent(_objSignalEvent59);
    _objSignalCurve57.SetOnDoneEvent(_objSignalEvent60);
    _objSignalCurve57.SetNumOutputs(1);
    _objSignalCurve58.SetSoftCurve(true);
    _objSignalCurve58.SetNumSegments(5);
    _objSignalCurve58.SetStartValue(0f);
    _objSignalCurve58.SetSegmentLength0(0f);
    _objSignalCurve58.SetSegmentEndValue0(0f);
    _objSignalCurve58.SetSegmentLength1(0f);
    _objSignalCurve58.SetSegmentEndValue1(1f);
    _objSignalCurve58.SetSegmentLength2(0.01f);
    _objSignalCurve58.SetSegmentEndValue2(1f);
    _objSignalCurve58.SetSegmentLength3(0.02f);
    _objSignalCurve58.SetSegmentEndValue3(0f);
    _objSignalCurve58.SetSegmentLength4(0f);
    _objSignalCurve58.SetSegmentEndValue4(0f);
    _objSignalCurve58.SetAutoStart(false);
    _objSignalCurve58.SetAutoLoop(false);
    _objSignalCurve58.SetStartEvent(_objSignalEvent60);
    _objSignalCurve58.SetOnDoneEvent(_objSignalEvent61);
    _objSignalCurve58.SetNumOutputs(1);
    _objSignalEventCombiner62.SetSrcEvent0(_objSignalEvent59);
    _objSignalEventCombiner62.SetSrcEvent1(_objSignalEvent60);
    _objSignalEventCombiner62.SetSrcEvent2(_objSignalEvent61);
    _objSignalEventCombiner62.SetOnEvent(_objSignalEvent64);
    _objSignalMathOp66.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp66.SetOperandANode(_objSignalMathOp55);
    _objSignalMathOp66.SetOperandB(_paramGain0);
    _objSignalMathOp66.SetNumChannels(1);
    _objSignalMathOp66.SetNumOutputs(1);
    _objSignalMultiplexer63.SetSrcNode0(_objSignalCurve56);
    _objSignalMultiplexer63.SetSrcNode1(_objSignalCurve57);
    _objSignalMultiplexer63.SetSrcNode2(_objSignalCurve58);
    _objSignalMultiplexer63.SetIncrementEvent(_objSignalEvent64);
    _objSignalMultiplexer63.SetAutoStart(true);
    _objSignalMultiplexer63.SetNumChannels(1);
    _objSignalMultiplexer63.SetOnDoneEvent(_objSignalEvent65);
    _objSignalMultiplexer63.SetNumOutputs(5);
    _objSignalMathOp68.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp68.SetOperandANode(_objSignalMathOp55);
    _objSignalMathOp68.SetOperandB(_paramGain1);
    _objSignalMathOp68.SetNumChannels(1);
    _objSignalMathOp68.SetNumOutputs(1);
    _objSignalMathOp70.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp70.SetOperandANode(_objSignalMathOp55);
    _objSignalMathOp70.SetOperandB(_paramGain2);
    _objSignalMathOp70.SetNumChannels(1);
    _objSignalMathOp70.SetNumOutputs(1);
    _objSignalMathOp72.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp72.SetOperandANode(_objSignalMathOp55);
    _objSignalMathOp72.SetOperandB(_paramGain3);
    _objSignalMathOp72.SetNumChannels(1);
    _objSignalMathOp72.SetNumOutputs(1);
    _objSignalMathOp67.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp67.SetOperandANode(_objSignalMathOp66);
    _objSignalMathOp67.SetOperandBNode(_objSignalMultiplexer63);
    _objSignalMathOp67.SetNumChannels(1);
    _objSignalMathOp67.SetNumOutputs(1);
    _objSignalMathOp69.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp69.SetOperandANode(_objSignalMathOp68);
    _objSignalMathOp69.SetOperandBNode(_objSignalMultiplexer63);
    _objSignalMathOp69.SetNumChannels(1);
    _objSignalMathOp69.SetNumOutputs(1);
    _objSignalMathOp71.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp71.SetOperandANode(_objSignalMathOp70);
    _objSignalMathOp71.SetOperandBNode(_objSignalMultiplexer63);
    _objSignalMathOp71.SetNumChannels(1);
    _objSignalMathOp71.SetNumOutputs(1);
    _objSignalMathOp73.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp73.SetOperandANode(_objSignalMathOp72);
    _objSignalMathOp73.SetOperandBNode(_objSignalMultiplexer63);
    _objSignalMathOp73.SetNumChannels(1);
    _objSignalMathOp73.SetNumOutputs(1);
    _objSignalMathOp74.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp74.SetOperandANode(_objSignalMathOp55);
    _objSignalMathOp74.SetOperandB(_paramGain4);
    _objSignalMathOp74.SetNumChannels(1);
    _objSignalMathOp74.SetNumOutputs(1);
    _objSignalChannelStack76.SetSrcNode0(_objSignalMathOp67);
    _objSignalChannelStack76.SetSrcNode1(_objSignalMathOp69);
    _objSignalChannelStack76.SetSrcNode2(_objSignalMathOp71);
    _objSignalChannelStack76.SetSrcNode3(_objSignalMathOp73);
    _objSignalChannelStack76.SetNumChannels(4);
    _objSignalChannelStack76.SetNumOutputs(1);
    _objSignalMathOp75.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp75.SetOperandANode(_objSignalMathOp74);
    _objSignalMathOp75.SetOperandBNode(_objSignalMultiplexer63);
    _objSignalMathOp75.SetNumChannels(1);
    _objSignalMathOp75.SetNumOutputs(1);
    _objSignalChannelStack77.SetSrcNode0(_objSignalChannelStack76);
    _objSignalChannelStack77.SetSrcNode1(_objSignalMathOp75);
    _objSignalChannelStack77.SetNumChannels(5);
    _objSignalChannelStack77.SetNumOutputs(1);
    _objSignalOutputDevice78.SetSrcNode(_objSignalChannelStack77);
    _objSignalOutputDevice78.SetDeviceNameFilter("HDK-1");
    _objSignalOutputDevice78.SetChannelOffset(0);
    if (_objSignalEvent65 != null) {
      _objSignalEvent65.OnReceiveEvent((_, _) => Terminate());
    }
  }

  void DestroyObjects() {
    if (_objSignalOutputDevice78 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalOutputDevice78.GetXrpaId());
      _objSignalOutputDevice78 = null;
    }
    if (_objSignalChannelStack77 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack77.GetXrpaId());
      _objSignalChannelStack77 = null;
    }
    if (_objSignalMathOp75 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp75.GetXrpaId());
      _objSignalMathOp75 = null;
    }
    if (_objSignalChannelStack76 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack76.GetXrpaId());
      _objSignalChannelStack76 = null;
    }
    if (_objSignalMathOp74 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp74.GetXrpaId());
      _objSignalMathOp74 = null;
    }
    if (_objSignalMathOp73 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp73.GetXrpaId());
      _objSignalMathOp73 = null;
    }
    if (_objSignalMathOp71 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp71.GetXrpaId());
      _objSignalMathOp71 = null;
    }
    if (_objSignalMathOp69 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp69.GetXrpaId());
      _objSignalMathOp69 = null;
    }
    if (_objSignalMathOp67 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp67.GetXrpaId());
      _objSignalMathOp67 = null;
    }
    if (_objSignalMathOp72 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp72.GetXrpaId());
      _objSignalMathOp72 = null;
    }
    if (_objSignalMathOp70 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp70.GetXrpaId());
      _objSignalMathOp70 = null;
    }
    if (_objSignalMathOp68 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp68.GetXrpaId());
      _objSignalMathOp68 = null;
    }
    if (_objSignalMultiplexer63 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalMultiplexer63.GetXrpaId());
      _objSignalMultiplexer63 = null;
    }
    if (_objSignalMathOp66 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp66.GetXrpaId());
      _objSignalMathOp66 = null;
    }
    if (_objSignalEvent65 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent65.GetXrpaId());
      _objSignalEvent65 = null;
    }
    if (_objSignalEventCombiner62 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalEventCombiner62.GetXrpaId());
      _objSignalEventCombiner62 = null;
    }
    if (_objSignalCurve58 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve58.GetXrpaId());
      _objSignalCurve58 = null;
    }
    if (_objSignalCurve57 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve57.GetXrpaId());
      _objSignalCurve57 = null;
    }
    if (_objSignalCurve56 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve56.GetXrpaId());
      _objSignalCurve56 = null;
    }
    if (_objSignalMathOp55 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp55.GetXrpaId());
      _objSignalMathOp55 = null;
    }
    if (_objSignalEvent64 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent64.GetXrpaId());
      _objSignalEvent64 = null;
    }
    if (_objSignalEvent61 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent61.GetXrpaId());
      _objSignalEvent61 = null;
    }
    if (_objSignalEvent60 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent60.GetXrpaId());
      _objSignalEvent60 = null;
    }
    if (_objSignalEvent59 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent59.GetXrpaId());
      _objSignalEvent59 = null;
    }
    if (_objSignalOscillator54 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator54.GetXrpaId());
      _objSignalOscillator54 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace SignalProcessingDataStore
