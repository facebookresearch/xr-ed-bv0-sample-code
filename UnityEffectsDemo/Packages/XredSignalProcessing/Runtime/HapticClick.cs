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

public class HapticClick : IDisposable {
  private SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramGainChannel0 = 1f;
  private float _paramGainChannel1 = 0f;
  private OutboundSignalEvent _objSignalEvent111;
  private OutboundSignalOscillator _objSignalOscillator109;
  private OutboundSignalCurve _objSignalCurve108;
  private OutboundSignalMathOp _objSignalMathOp110;
  private OutboundSignalMathOp _objSignalMathOp112;
  private OutboundSignalMathOp _objSignalMathOp113;
  private OutboundSignalChannelStack _objSignalChannelStack114;
  private OutboundSignalOutputDevice _objSignalOutputDevice115;

  public HapticClick(SignalProcessingDataStore datastore) {
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

  ~HapticClick() {
    Dispose(false);
  }

  public float GetGainChannel0() {
    return _paramGainChannel0;
  }

  public void SetGainChannel0(float GainChannel0) {
    _paramGainChannel0 = GainChannel0;
    if (_objSignalMathOp112 != null) {
      _objSignalMathOp112.SetOperandB(GainChannel0);
    }
  }

  public float GetGainChannel1() {
    return _paramGainChannel1;
  }

  public void SetGainChannel1(float GainChannel1) {
    _paramGainChannel1 = GainChannel1;
    if (_objSignalMathOp113 != null) {
      _objSignalMathOp113.SetOperandB(GainChannel1);
    }
  }

  void CreateObjects() {
    _objSignalEvent111 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent111);
    _objSignalOscillator109 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator109);
    _objSignalCurve108 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve108);
    _objSignalMathOp110 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp110);
    _objSignalMathOp112 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp112);
    _objSignalMathOp113 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp113);
    _objSignalChannelStack114 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack114);
    _objSignalOutputDevice115 = new OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalOutputDevice115);
    _objSignalOscillator109.SetNumChannels(1);
    _objSignalOscillator109.SetWaveformType((WaveformType)(uint)(3));
    _objSignalOscillator109.SetFrequency(170f);
    _objSignalOscillator109.SetPulseWidth(0.5f);
    _objSignalOscillator109.SetNumOutputs(1);
    _objSignalCurve108.SetSoftCurve(true);
    _objSignalCurve108.SetNumSegments(5);
    _objSignalCurve108.SetStartValue(0f);
    _objSignalCurve108.SetSegmentLength0(0f);
    _objSignalCurve108.SetSegmentEndValue0(0f);
    _objSignalCurve108.SetSegmentLength1(0.05f);
    _objSignalCurve108.SetSegmentEndValue1(0.5f);
    _objSignalCurve108.SetSegmentLength2(0.05f);
    _objSignalCurve108.SetSegmentEndValue2(0.5f);
    _objSignalCurve108.SetSegmentLength3(0.05f);
    _objSignalCurve108.SetSegmentEndValue3(0f);
    _objSignalCurve108.SetSegmentLength4(0f);
    _objSignalCurve108.SetSegmentEndValue4(0f);
    _objSignalCurve108.SetAutoStart(true);
    _objSignalCurve108.SetAutoLoop(false);
    _objSignalCurve108.SetNumOutputs(1);
    _objSignalCurve108.SetOnDoneEvent(_objSignalEvent111);
    _objSignalMathOp110.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp110.SetOperandANode(_objSignalOscillator109);
    _objSignalMathOp110.SetOperandBNode(_objSignalCurve108);
    _objSignalMathOp110.SetNumChannels(1);
    _objSignalMathOp110.SetNumOutputs(2);
    _objSignalMathOp112.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp112.SetOperandANode(_objSignalMathOp110);
    _objSignalMathOp112.SetOperandB(_paramGainChannel0);
    _objSignalMathOp112.SetNumChannels(1);
    _objSignalMathOp112.SetNumOutputs(1);
    _objSignalMathOp113.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp113.SetOperandANode(_objSignalMathOp110);
    _objSignalMathOp113.SetOperandB(_paramGainChannel1);
    _objSignalMathOp113.SetNumChannels(1);
    _objSignalMathOp113.SetNumOutputs(1);
    _objSignalChannelStack114.SetSrcNode0(_objSignalMathOp112);
    _objSignalChannelStack114.SetSrcNode1(_objSignalMathOp113);
    _objSignalChannelStack114.SetNumChannels(2);
    _objSignalChannelStack114.SetNumOutputs(1);
    _objSignalOutputDevice115.SetSrcNode(_objSignalChannelStack114);
    _objSignalOutputDevice115.SetDeviceNameFilter("BuzzDuino");
    _objSignalOutputDevice115.SetChannelOffset(0);
    if (_objSignalEvent111 != null) {
      _objSignalEvent111.OnReceiveEvent((_, _) => Terminate());
    }
  }

  void DestroyObjects() {
    if (_objSignalOutputDevice115 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalOutputDevice115.GetXrpaId());
      _objSignalOutputDevice115 = null;
    }
    if (_objSignalChannelStack114 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack114.GetXrpaId());
      _objSignalChannelStack114 = null;
    }
    if (_objSignalMathOp113 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp113.GetXrpaId());
      _objSignalMathOp113 = null;
    }
    if (_objSignalMathOp112 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp112.GetXrpaId());
      _objSignalMathOp112 = null;
    }
    if (_objSignalMathOp110 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp110.GetXrpaId());
      _objSignalMathOp110 = null;
    }
    if (_objSignalCurve108 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve108.GetXrpaId());
      _objSignalCurve108 = null;
    }
    if (_objSignalOscillator109 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator109.GetXrpaId());
      _objSignalOscillator109 = null;
    }
    if (_objSignalEvent111 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent111.GetXrpaId());
      _objSignalEvent111 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace SignalProcessingDataStore
