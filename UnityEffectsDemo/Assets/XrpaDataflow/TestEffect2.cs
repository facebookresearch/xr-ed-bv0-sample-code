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

public class TestEffect2 : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent1;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve0;
  private SignalProcessingDataStore.OutboundSignalOscillator _objSignalProcessingSignalOscillator2;
  private SignalProcessingDataStore.OutboundSignalDelay _objSignalProcessingSignalDelay7;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp3;
  private SignalProcessingDataStore.OutboundSignalFeedback _objSignalProcessingSignalFeedback4;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp6;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp5;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack8;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice9;

  public TestEffect2(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing) {
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

  ~TestEffect2() {
    Dispose(false);
  }

  void CreateObjects() {
    _objSignalProcessingSignalEvent1 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent1);
    _objSignalProcessingSignalCurve0 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve0);
    _objSignalProcessingSignalOscillator2 = new SignalProcessingDataStore.OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalProcessingSignalOscillator2);
    _objSignalProcessingSignalDelay7 = new SignalProcessingDataStore.OutboundSignalDelay(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalDelayOut.AddObject(_objSignalProcessingSignalDelay7);
    _objSignalProcessingSignalMathOp3 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalFeedback4 = new SignalProcessingDataStore.OutboundSignalFeedback(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalFeedbackOut.AddObject(_objSignalProcessingSignalFeedback4);
    _objSignalProcessingSignalMathOp6 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp6);
    _objSignalProcessingSignalMathOp5 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp5);
    _objSignalProcessingSignalChannelStack8 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack8);
    _objSignalProcessingSignalOutputDevice9 = new SignalProcessingDataStore.OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalProcessingSignalOutputDevice9);
    _objSignalProcessingSignalCurve0.SetSoftCurve(true);
    _objSignalProcessingSignalCurve0.SetNumSegments(5);
    _objSignalProcessingSignalCurve0.SetStartValue(0f);
    _objSignalProcessingSignalCurve0.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve0.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve0.SetSegmentLength1(0.25f);
    _objSignalProcessingSignalCurve0.SetSegmentEndValue1(1f);
    _objSignalProcessingSignalCurve0.SetSegmentLength2(0.5f);
    _objSignalProcessingSignalCurve0.SetSegmentEndValue2(1f);
    _objSignalProcessingSignalCurve0.SetSegmentLength3(0.25f);
    _objSignalProcessingSignalCurve0.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve0.SetSegmentLength4(4f);
    _objSignalProcessingSignalCurve0.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve0.SetAutoStart(true);
    _objSignalProcessingSignalCurve0.SetAutoLoop(false);
    _objSignalProcessingSignalCurve0.SetOnDoneEvent(_objSignalProcessingSignalEvent1);
    _objSignalProcessingSignalCurve0.SetStartEvent(_objSignalProcessingSignalEvent1);
    _objSignalProcessingSignalCurve0.SetNumOutputs(1);
    _objSignalProcessingSignalOscillator2.SetNumChannels(1);
    _objSignalProcessingSignalOscillator2.SetWaveformType((SignalProcessingDataStore.WaveformType)(uint)(3));
    _objSignalProcessingSignalOscillator2.SetFrequency(170f);
    _objSignalProcessingSignalOscillator2.SetPulseWidth(0.5f);
    _objSignalProcessingSignalOscillator2.SetNumOutputs(1);
    _objSignalProcessingSignalDelay7.SetSrcNode(_objSignalProcessingSignalMathOp6);
    _objSignalProcessingSignalDelay7.SetDelayTimeMs(500f);
    _objSignalProcessingSignalDelay7.SetNumChannels(1);
    _objSignalProcessingSignalDelay7.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp3.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp3.SetOperandANode(_objSignalProcessingSignalOscillator2);
    _objSignalProcessingSignalMathOp3.SetOperandBNode(_objSignalProcessingSignalCurve0);
    _objSignalProcessingSignalMathOp3.SetNumChannels(1);
    _objSignalProcessingSignalMathOp3.SetNumOutputs(2);
    _objSignalProcessingSignalFeedback4.SetNumOutputs(1);
    _objSignalProcessingSignalFeedback4.SetSrcNode(_objSignalProcessingSignalDelay7);
    _objSignalProcessingSignalFeedback4.SetNumChannels(1);
    _objSignalProcessingSignalMathOp6.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(0));
    _objSignalProcessingSignalMathOp6.SetOperandANode(_objSignalProcessingSignalMathOp5);
    _objSignalProcessingSignalMathOp6.SetOperandBNode(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalMathOp6.SetNumChannels(1);
    _objSignalProcessingSignalMathOp6.SetNumOutputs(2);
    _objSignalProcessingSignalMathOp5.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp5.SetOperandANode(_objSignalProcessingSignalFeedback4);
    _objSignalProcessingSignalMathOp5.SetOperandB(0.25f);
    _objSignalProcessingSignalMathOp5.SetNumChannels(0);
    _objSignalProcessingSignalMathOp5.SetNumOutputs(1);
    _objSignalProcessingSignalChannelStack8.SetSrcNode0(_objSignalProcessingSignalMathOp6);
    _objSignalProcessingSignalChannelStack8.SetSrcNode1(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalChannelStack8.SetNumChannels(2);
    _objSignalProcessingSignalChannelStack8.SetNumOutputs(1);
    _objSignalProcessingSignalOutputDevice9.SetSrcNode(_objSignalProcessingSignalChannelStack8);
    _objSignalProcessingSignalOutputDevice9.SetDeviceNameFilter("BuzzDuino");
    _objSignalProcessingSignalOutputDevice9.SetChannelOffset(0);
  }

  void DestroyObjects() {
    if (_objSignalProcessingSignalOutputDevice9 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalProcessingSignalOutputDevice9.GetXrpaId());
      _objSignalProcessingSignalOutputDevice9 = null;
    }
    if (_objSignalProcessingSignalChannelStack8 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack8.GetXrpaId());
      _objSignalProcessingSignalChannelStack8 = null;
    }
    if (_objSignalProcessingSignalMathOp5 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp5.GetXrpaId());
      _objSignalProcessingSignalMathOp5 = null;
    }
    if (_objSignalProcessingSignalMathOp6 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp6.GetXrpaId());
      _objSignalProcessingSignalMathOp6 = null;
    }
    if (_objSignalProcessingSignalFeedback4 != null) {
      _datastoreSignalProcessing.SignalFeedbackOut.RemoveObject(_objSignalProcessingSignalFeedback4.GetXrpaId());
      _objSignalProcessingSignalFeedback4 = null;
    }
    if (_objSignalProcessingSignalMathOp3 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp3.GetXrpaId());
      _objSignalProcessingSignalMathOp3 = null;
    }
    if (_objSignalProcessingSignalDelay7 != null) {
      _datastoreSignalProcessing.SignalDelayOut.RemoveObject(_objSignalProcessingSignalDelay7.GetXrpaId());
      _objSignalProcessingSignalDelay7 = null;
    }
    if (_objSignalProcessingSignalOscillator2 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalProcessingSignalOscillator2.GetXrpaId());
      _objSignalProcessingSignalOscillator2 = null;
    }
    if (_objSignalProcessingSignalCurve0 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve0.GetXrpaId());
      _objSignalProcessingSignalCurve0 = null;
    }
    if (_objSignalProcessingSignalEvent1 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent1.GetXrpaId());
      _objSignalProcessingSignalEvent1 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace XrpaDataflow
