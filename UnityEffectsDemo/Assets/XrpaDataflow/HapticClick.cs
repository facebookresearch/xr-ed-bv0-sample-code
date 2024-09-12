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

public class HapticClick : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramGainChannel0 = 1f;
  private float _paramGainChannel1 = 0f;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent3;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve0;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator1;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp2;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp4;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp5;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack6;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice7;

  public HapticClick(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing) {
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

  ~HapticClick() {
    Dispose(false);
  }

  public float GetGainChannel0() {
    return _paramGainChannel0;
  }

  public void SetGainChannel0(float GainChannel0) {
    _paramGainChannel0 = GainChannel0;
    if (_objSignalProcessingSignalMathOp4 != null) {
      _objSignalProcessingSignalMathOp4.SetOperandB(GainChannel0);
    }
  }

  public float GetGainChannel1() {
    return _paramGainChannel1;
  }

  public void SetGainChannel1(float GainChannel1) {
    _paramGainChannel1 = GainChannel1;
    if (_objSignalProcessingSignalMathOp5 != null) {
      _objSignalProcessingSignalMathOp5.SetOperandB(GainChannel1);
    }
  }

  void CreateObjects() {
    _objSignalProcessingSignalEvent3 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent3);
    _objSignalProcessingSignalCurve0 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve0);
    _objSignalProcessingSignalOscillator1 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator1);
    _objSignalProcessingSignalMathOp2 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp2);
    _objSignalProcessingSignalMathOp4 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp4);
    _objSignalProcessingSignalMathOp5 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp5);
    _objSignalProcessingSignalChannelStack6 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack6);
    _objSignalProcessingSignalOutputDevice7 = new SignalProcessingDataStore.OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalProcessingSignalOutputDevice7);
    _objSignalProcessingSignalCurve0.SetSoftCurve(true);
    _objSignalProcessingSignalCurve0.SetNumSegments(5);
    _objSignalProcessingSignalCurve0.SetStartValue(0f);
    _objSignalProcessingSignalCurve0.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve0.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve0.SetSegmentLength1(0.05f);
    _objSignalProcessingSignalCurve0.SetSegmentEndValue1(0.5f);
    _objSignalProcessingSignalCurve0.SetSegmentLength2(0.05f);
    _objSignalProcessingSignalCurve0.SetSegmentEndValue2(0.5f);
    _objSignalProcessingSignalCurve0.SetSegmentLength3(0.05f);
    _objSignalProcessingSignalCurve0.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve0.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve0.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve0.SetAutoStart(true);
    _objSignalProcessingSignalCurve0.SetAutoLoop(false);
    _objSignalProcessingSignalCurve0.SetNumOutputs(1);
    _objSignalProcessingSignalCurve0.SetOnDoneEvent(_objSignalProcessingSignalEvent3);
    _objSignalProcessingSignalOscillator1.SetNumChannels(1);
    _objSignalProcessingSignalOscillator1.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(3));
    _objSignalProcessingSignalOscillator1.SetFrequency(170f);
    _objSignalProcessingSignalOscillator1.SetPulseWidth(0.5f);
    _objSignalProcessingSignalOscillator1.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp2.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp2.SetOperandANode(_objSignalProcessingSignalOscillator1);
    _objSignalProcessingSignalMathOp2.SetOperandBNode(_objSignalProcessingSignalCurve0);
    _objSignalProcessingSignalMathOp2.SetNumChannels(1);
    _objSignalProcessingSignalMathOp2.SetNumOutputs(2);
    _objSignalProcessingSignalMathOp4.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp4.SetOperandANode(_objSignalProcessingSignalMathOp2);
    _objSignalProcessingSignalMathOp4.SetOperandB(_paramGainChannel0);
    _objSignalProcessingSignalMathOp4.SetNumChannels(1);
    _objSignalProcessingSignalMathOp4.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp5.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp5.SetOperandANode(_objSignalProcessingSignalMathOp2);
    _objSignalProcessingSignalMathOp5.SetOperandB(_paramGainChannel1);
    _objSignalProcessingSignalMathOp5.SetNumChannels(1);
    _objSignalProcessingSignalMathOp5.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack6.SetSrcNode0(_objSignalProcessingSignalMathOp4);
    _objSignalProcessingSignalChannelStack6.SetSrcNode1(_objSignalProcessingSignalMathOp5);
    _objSignalProcessingSignalChannelStack6.SetNumChannels(2);
    _objSignalProcessingSignalChannelStack6.SetNumOutputs(1);
    _objSignalProcessingSignalOutputDevice7.SetSrcNode(_objSignalProcessingSignalChannelStack6);
    _objSignalProcessingSignalOutputDevice7.SetDeviceNameFilter("BuzzDuino");
    _objSignalProcessingSignalOutputDevice7.SetChannelOffset(0);
    if (_objSignalProcessingSignalEvent3 != null) {
      _objSignalProcessingSignalEvent3.OnReceiveEvent((_, _) => Terminate());
    }
  }

  void DestroyObjects() {
    if (_objSignalProcessingSignalOutputDevice7 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalProcessingSignalOutputDevice7.GetXrpaId());
      _objSignalProcessingSignalOutputDevice7 = null;
    }
    if (_objSignalProcessingSignalChannelStack6 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack6.GetXrpaId());
      _objSignalProcessingSignalChannelStack6 = null;
    }
    if (_objSignalProcessingSignalMathOp5 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp5.GetXrpaId());
      _objSignalProcessingSignalMathOp5 = null;
    }
    if (_objSignalProcessingSignalMathOp4 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp4.GetXrpaId());
      _objSignalProcessingSignalMathOp4 = null;
    }
    if (_objSignalProcessingSignalMathOp2 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp2.GetXrpaId());
      _objSignalProcessingSignalMathOp2 = null;
    }
    if (_objSignalProcessingSignalOscillator1 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalProcessingSignalOscillator1.GetXrpaId());
      _objSignalProcessingSignalOscillator1 = null;
    }
    if (_objSignalProcessingSignalCurve0 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve0.GetXrpaId());
      _objSignalProcessingSignalCurve0 = null;
    }
    if (_objSignalProcessingSignalEvent3 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent3.GetXrpaId());
      _objSignalProcessingSignalEvent3 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace XrpaDataflow
