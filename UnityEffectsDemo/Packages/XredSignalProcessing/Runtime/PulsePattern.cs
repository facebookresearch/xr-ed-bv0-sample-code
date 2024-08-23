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

public class PulsePattern : IDisposable {
  private SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramFq = 170f;
  private float _paramPauseDuration = 0.25f;
  private float _paramPulseDuration = 0.5f;
  private float _paramSquareAmp = 1f;
  private OutboundSignalEvent _objSignalEvent176;
  private OutboundSignalEvent _objSignalEvent180;
  private OutboundSignalEvent _objSignalEvent179;
  private OutboundSignalOscillator _objSignalOscillator155;
  private OutboundSignalCurve _objSignalCurve175;
  private OutboundSignalEventCombiner _objSignalEventCombiner177;
  private OutboundSignalEvent _objSignalEvent187;
  private OutboundSignalEvent _objSignalEvent192;
  private OutboundSignalEvent _objSignalEvent188;
  private OutboundSignalEvent _objSignalEvent191;
  private OutboundSignalMathOp _objSignalMathOp156;
  private OutboundSignalMultiplexer _objSignalMultiplexer178;
  private OutboundSignalCurve _objSignalCurve185;
  private OutboundSignalCurve _objSignalCurve186;
  private OutboundSignalEventCombiner _objSignalEventCombiner189;
  private OutboundSignalMathOp _objSignalMathOp184;
  private OutboundSignalMultiplexer _objSignalMultiplexer190;
  private OutboundSignalMathOp _objSignalMathOp193;
  private OutboundSignalMathOp _objSignalMathOp194;
  private OutboundSignalChannelStack _objSignalChannelStack195;
  private OutboundSignalOutputDevice _objSignalOutputDevice196;

  public PulsePattern(SignalProcessingDataStore datastore) {
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

  ~PulsePattern() {
    Dispose(false);
  }

  public float GetFq() {
    return _paramFq;
  }

  public void SetFq(float Fq) {
    _paramFq = Fq;
    if (_objSignalOscillator155 != null) {
      _objSignalOscillator155.SetFrequency(Fq);
    }
  }

  public float GetPauseDuration() {
    return _paramPauseDuration;
  }

  public void SetPauseDuration(float PauseDuration) {
    _paramPauseDuration = PauseDuration;
    if (_objSignalCurve186 != null) {
      _objSignalCurve186.SetSegmentLength2(PauseDuration);
    }
  }

  public float GetPulseDuration() {
    return _paramPulseDuration;
  }

  public void SetPulseDuration(float PulseDuration) {
    _paramPulseDuration = PulseDuration;
    if (_objSignalCurve185 != null) {
      _objSignalCurve185.SetSegmentLength2(PulseDuration);
    }
  }

  public float GetSquareAmp() {
    return _paramSquareAmp;
  }

  public void SetSquareAmp(float SquareAmp) {
    _paramSquareAmp = SquareAmp;
    if (_objSignalMathOp156 != null) {
      _objSignalMathOp156.SetOperandB(SquareAmp);
    }
    if (_objSignalCurve175 != null) {
      _objSignalCurve175.SetSegmentEndValue1(SquareAmp);
    }
    if (_objSignalCurve175 != null) {
      _objSignalCurve175.SetSegmentEndValue2(SquareAmp);
    }
  }

  void CreateObjects() {
    _objSignalEvent176 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent176);
    _objSignalEvent180 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent180);
    _objSignalEvent179 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent179);
    _objSignalOscillator155 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator155);
    _objSignalCurve175 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve175);
    _objSignalEventCombiner177 = new OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalEventCombiner177);
    _objSignalEvent187 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent187);
    _objSignalEvent192 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent192);
    _objSignalEvent188 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent188);
    _objSignalEvent191 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent191);
    _objSignalMathOp156 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp156);
    _objSignalMultiplexer178 = new OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalMultiplexer178);
    _objSignalCurve185 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve185);
    _objSignalCurve186 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve186);
    _objSignalEventCombiner189 = new OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalEventCombiner189);
    _objSignalMathOp184 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp184);
    _objSignalMultiplexer190 = new OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalMultiplexer190);
    _objSignalMathOp193 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp193);
    _objSignalMathOp194 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp194);
    _objSignalChannelStack195 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack195);
    _objSignalOutputDevice196 = new OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalOutputDevice196);
    _objSignalOscillator155.SetNumChannels(1);
    _objSignalOscillator155.SetWaveformType((WaveformType)(uint)(1));
    _objSignalOscillator155.SetFrequency(_paramFq);
    _objSignalOscillator155.SetPulseWidth(0.5f);
    _objSignalOscillator155.SetNumOutputs(1);
    _objSignalCurve175.SetSoftCurve(true);
    _objSignalCurve175.SetNumSegments(5);
    _objSignalCurve175.SetStartValue(0f);
    _objSignalCurve175.SetSegmentLength0(0f);
    _objSignalCurve175.SetSegmentEndValue0(0f);
    _objSignalCurve175.SetSegmentLength1(0f);
    _objSignalCurve175.SetSegmentEndValue1(_paramSquareAmp);
    _objSignalCurve175.SetSegmentLength2(60f);
    _objSignalCurve175.SetSegmentEndValue2(_paramSquareAmp);
    _objSignalCurve175.SetSegmentLength3(0f);
    _objSignalCurve175.SetSegmentEndValue3(0f);
    _objSignalCurve175.SetSegmentLength4(0f);
    _objSignalCurve175.SetSegmentEndValue4(0f);
    _objSignalCurve175.SetAutoStart(true);
    _objSignalCurve175.SetAutoLoop(false);
    _objSignalCurve175.SetOnDoneEvent(_objSignalEvent176);
    _objSignalCurve175.SetNumOutputs(1);
    _objSignalCurve175.SetStartEvent(_objSignalEvent180);
    _objSignalEventCombiner177.SetSrcEvent0(_objSignalEvent176);
    _objSignalEventCombiner177.SetOnEvent(_objSignalEvent179);
    _objSignalMathOp156.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp156.SetOperandANode(_objSignalOscillator155);
    _objSignalMathOp156.SetOperandB(_paramSquareAmp);
    _objSignalMathOp156.SetNumChannels(1);
    _objSignalMathOp156.SetNumOutputs(1);
    _objSignalMultiplexer178.SetSrcNode0(_objSignalCurve175);
    _objSignalMultiplexer178.SetIncrementEvent(_objSignalEvent179);
    _objSignalMultiplexer178.SetAutoStart(true);
    _objSignalMultiplexer178.SetNumChannels(1);
    _objSignalMultiplexer178.SetOnDoneEvent(_objSignalEvent180);
    _objSignalMultiplexer178.SetStartEvent(_objSignalEvent180);
    _objSignalMultiplexer178.SetNumOutputs(1);
    _objSignalCurve185.SetSoftCurve(true);
    _objSignalCurve185.SetNumSegments(5);
    _objSignalCurve185.SetStartValue(0f);
    _objSignalCurve185.SetSegmentLength0(0f);
    _objSignalCurve185.SetSegmentEndValue0(0f);
    _objSignalCurve185.SetSegmentLength1(0f);
    _objSignalCurve185.SetSegmentEndValue1(1f);
    _objSignalCurve185.SetSegmentLength2(_paramPulseDuration);
    _objSignalCurve185.SetSegmentEndValue2(1f);
    _objSignalCurve185.SetSegmentLength3(0f);
    _objSignalCurve185.SetSegmentEndValue3(0f);
    _objSignalCurve185.SetSegmentLength4(0f);
    _objSignalCurve185.SetSegmentEndValue4(0f);
    _objSignalCurve185.SetAutoStart(true);
    _objSignalCurve185.SetAutoLoop(false);
    _objSignalCurve185.SetOnDoneEvent(_objSignalEvent187);
    _objSignalCurve185.SetNumOutputs(1);
    _objSignalCurve185.SetStartEvent(_objSignalEvent192);
    _objSignalCurve186.SetSoftCurve(true);
    _objSignalCurve186.SetNumSegments(5);
    _objSignalCurve186.SetStartValue(0f);
    _objSignalCurve186.SetSegmentLength0(0f);
    _objSignalCurve186.SetSegmentEndValue0(0f);
    _objSignalCurve186.SetSegmentLength1(0f);
    _objSignalCurve186.SetSegmentEndValue1(0f);
    _objSignalCurve186.SetSegmentLength2(_paramPauseDuration);
    _objSignalCurve186.SetSegmentEndValue2(0f);
    _objSignalCurve186.SetSegmentLength3(0f);
    _objSignalCurve186.SetSegmentEndValue3(0f);
    _objSignalCurve186.SetSegmentLength4(0f);
    _objSignalCurve186.SetSegmentEndValue4(0f);
    _objSignalCurve186.SetAutoStart(false);
    _objSignalCurve186.SetAutoLoop(false);
    _objSignalCurve186.SetStartEvent(_objSignalEvent187);
    _objSignalCurve186.SetOnDoneEvent(_objSignalEvent188);
    _objSignalCurve186.SetNumOutputs(1);
    _objSignalEventCombiner189.SetSrcEvent0(_objSignalEvent187);
    _objSignalEventCombiner189.SetSrcEvent1(_objSignalEvent188);
    _objSignalEventCombiner189.SetOnEvent(_objSignalEvent191);
    _objSignalMathOp184.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp184.SetOperandANode(_objSignalMathOp156);
    _objSignalMathOp184.SetOperandBNode(_objSignalMultiplexer178);
    _objSignalMathOp184.SetNumChannels(1);
    _objSignalMathOp184.SetNumOutputs(2);
    _objSignalMultiplexer190.SetSrcNode0(_objSignalCurve185);
    _objSignalMultiplexer190.SetSrcNode1(_objSignalCurve186);
    _objSignalMultiplexer190.SetIncrementEvent(_objSignalEvent191);
    _objSignalMultiplexer190.SetAutoStart(true);
    _objSignalMultiplexer190.SetNumChannels(1);
    _objSignalMultiplexer190.SetOnDoneEvent(_objSignalEvent192);
    _objSignalMultiplexer190.SetStartEvent(_objSignalEvent192);
    _objSignalMultiplexer190.SetNumOutputs(2);
    _objSignalMathOp193.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp193.SetOperandANode(_objSignalMathOp184);
    _objSignalMathOp193.SetOperandBNode(_objSignalMultiplexer190);
    _objSignalMathOp193.SetNumChannels(1);
    _objSignalMathOp193.SetNumOutputs(1);
    _objSignalMathOp194.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp194.SetOperandANode(_objSignalMathOp184);
    _objSignalMathOp194.SetOperandBNode(_objSignalMultiplexer190);
    _objSignalMathOp194.SetNumChannels(1);
    _objSignalMathOp194.SetNumOutputs(1);
    _objSignalChannelStack195.SetSrcNode0(_objSignalMathOp193);
    _objSignalChannelStack195.SetSrcNode1(_objSignalMathOp194);
    _objSignalChannelStack195.SetNumChannels(2);
    _objSignalChannelStack195.SetNumOutputs(1);
    _objSignalOutputDevice196.SetSrcNode(_objSignalChannelStack195);
    _objSignalOutputDevice196.SetDeviceNameFilter("BuzzDuino");
    _objSignalOutputDevice196.SetChannelOffset(0);
  }

  void DestroyObjects() {
    if (_objSignalOutputDevice196 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalOutputDevice196.GetXrpaId());
      _objSignalOutputDevice196 = null;
    }
    if (_objSignalChannelStack195 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack195.GetXrpaId());
      _objSignalChannelStack195 = null;
    }
    if (_objSignalMathOp194 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp194.GetXrpaId());
      _objSignalMathOp194 = null;
    }
    if (_objSignalMathOp193 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp193.GetXrpaId());
      _objSignalMathOp193 = null;
    }
    if (_objSignalMultiplexer190 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalMultiplexer190.GetXrpaId());
      _objSignalMultiplexer190 = null;
    }
    if (_objSignalMathOp184 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp184.GetXrpaId());
      _objSignalMathOp184 = null;
    }
    if (_objSignalEventCombiner189 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalEventCombiner189.GetXrpaId());
      _objSignalEventCombiner189 = null;
    }
    if (_objSignalCurve186 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve186.GetXrpaId());
      _objSignalCurve186 = null;
    }
    if (_objSignalCurve185 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve185.GetXrpaId());
      _objSignalCurve185 = null;
    }
    if (_objSignalMultiplexer178 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalMultiplexer178.GetXrpaId());
      _objSignalMultiplexer178 = null;
    }
    if (_objSignalMathOp156 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp156.GetXrpaId());
      _objSignalMathOp156 = null;
    }
    if (_objSignalEvent191 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent191.GetXrpaId());
      _objSignalEvent191 = null;
    }
    if (_objSignalEvent188 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent188.GetXrpaId());
      _objSignalEvent188 = null;
    }
    if (_objSignalEvent192 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent192.GetXrpaId());
      _objSignalEvent192 = null;
    }
    if (_objSignalEvent187 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent187.GetXrpaId());
      _objSignalEvent187 = null;
    }
    if (_objSignalEventCombiner177 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalEventCombiner177.GetXrpaId());
      _objSignalEventCombiner177 = null;
    }
    if (_objSignalCurve175 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve175.GetXrpaId());
      _objSignalCurve175 = null;
    }
    if (_objSignalOscillator155 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator155.GetXrpaId());
      _objSignalOscillator155 = null;
    }
    if (_objSignalEvent179 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent179.GetXrpaId());
      _objSignalEvent179 = null;
    }
    if (_objSignalEvent180 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent180.GetXrpaId());
      _objSignalEvent180 = null;
    }
    if (_objSignalEvent176 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent176.GetXrpaId());
      _objSignalEvent176 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace SignalProcessingDataStore
