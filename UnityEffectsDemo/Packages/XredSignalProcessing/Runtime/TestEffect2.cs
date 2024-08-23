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

public class TestEffect2 : IDisposable {
  private SignalProcessingDataStore _datastoreSignalProcessing;
  private OutboundSignalDelay _objSignalDelay220;
  private OutboundSignalEvent _objSignalEvent214;
  private OutboundSignalFeedback _objSignalFeedback217;
  private OutboundSignalOscillator _objSignalOscillator215;
  private OutboundSignalCurve _objSignalCurve213;
  private OutboundSignalMathOp _objSignalMathOp218;
  private OutboundSignalMathOp _objSignalMathOp216;
  private OutboundSignalMathOp _objSignalMathOp219;
  private OutboundSignalChannelStack _objSignalChannelStack221;
  private OutboundSignalOutputDevice _objSignalOutputDevice222;

  public TestEffect2(SignalProcessingDataStore datastore) {
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

  ~TestEffect2() {
    Dispose(false);
  }

  void CreateObjects() {
    _objSignalDelay220 = new OutboundSignalDelay(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalDelayOut.AddObject(_objSignalDelay220);
    _objSignalEvent214 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent214);
    _objSignalFeedback217 = new OutboundSignalFeedback(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalFeedbackOut.AddObject(_objSignalFeedback217);
    _objSignalOscillator215 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator215);
    _objSignalCurve213 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve213);
    _objSignalMathOp218 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp218);
    _objSignalMathOp216 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp216);
    _objSignalMathOp219 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp219);
    _objSignalChannelStack221 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack221);
    _objSignalOutputDevice222 = new OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalOutputDevice222);
    _objSignalDelay220.SetSrcNode(_objSignalMathOp219);
    _objSignalDelay220.SetDelayTimeMs(500f);
    _objSignalDelay220.SetNumChannels(1);
    _objSignalDelay220.SetNumOutputs(1);
    _objSignalFeedback217.SetNumOutputs(1);
    _objSignalFeedback217.SetSrcNode(_objSignalDelay220);
    _objSignalFeedback217.SetNumChannels(1);
    _objSignalOscillator215.SetNumChannels(1);
    _objSignalOscillator215.SetWaveformType((WaveformType)(uint)(3));
    _objSignalOscillator215.SetFrequency(170f);
    _objSignalOscillator215.SetPulseWidth(0.5f);
    _objSignalOscillator215.SetNumOutputs(1);
    _objSignalCurve213.SetSoftCurve(true);
    _objSignalCurve213.SetNumSegments(5);
    _objSignalCurve213.SetStartValue(0f);
    _objSignalCurve213.SetSegmentLength0(0f);
    _objSignalCurve213.SetSegmentEndValue0(0f);
    _objSignalCurve213.SetSegmentLength1(0.25f);
    _objSignalCurve213.SetSegmentEndValue1(1f);
    _objSignalCurve213.SetSegmentLength2(0.5f);
    _objSignalCurve213.SetSegmentEndValue2(1f);
    _objSignalCurve213.SetSegmentLength3(0.25f);
    _objSignalCurve213.SetSegmentEndValue3(0f);
    _objSignalCurve213.SetSegmentLength4(4f);
    _objSignalCurve213.SetSegmentEndValue4(0f);
    _objSignalCurve213.SetAutoStart(true);
    _objSignalCurve213.SetAutoLoop(false);
    _objSignalCurve213.SetOnDoneEvent(_objSignalEvent214);
    _objSignalCurve213.SetStartEvent(_objSignalEvent214);
    _objSignalCurve213.SetNumOutputs(1);
    _objSignalMathOp218.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp218.SetOperandANode(_objSignalFeedback217);
    _objSignalMathOp218.SetOperandB(0.25f);
    _objSignalMathOp218.SetNumChannels(0);
    _objSignalMathOp218.SetNumOutputs(1);
    _objSignalMathOp216.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp216.SetOperandANode(_objSignalOscillator215);
    _objSignalMathOp216.SetOperandBNode(_objSignalCurve213);
    _objSignalMathOp216.SetNumChannels(1);
    _objSignalMathOp216.SetNumOutputs(2);
    _objSignalMathOp219.SetOperation((MathOperation)(uint)(0));
    _objSignalMathOp219.SetOperandANode(_objSignalMathOp218);
    _objSignalMathOp219.SetOperandBNode(_objSignalMathOp216);
    _objSignalMathOp219.SetNumChannels(1);
    _objSignalMathOp219.SetNumOutputs(2);
    _objSignalChannelStack221.SetSrcNode0(_objSignalMathOp219);
    _objSignalChannelStack221.SetSrcNode1(_objSignalMathOp216);
    _objSignalChannelStack221.SetNumChannels(2);
    _objSignalChannelStack221.SetNumOutputs(1);
    _objSignalOutputDevice222.SetSrcNode(_objSignalChannelStack221);
    _objSignalOutputDevice222.SetDeviceNameFilter("BuzzDuino");
    _objSignalOutputDevice222.SetChannelOffset(0);
  }

  void DestroyObjects() {
    if (_objSignalOutputDevice222 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalOutputDevice222.GetXrpaId());
      _objSignalOutputDevice222 = null;
    }
    if (_objSignalChannelStack221 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack221.GetXrpaId());
      _objSignalChannelStack221 = null;
    }
    if (_objSignalMathOp219 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp219.GetXrpaId());
      _objSignalMathOp219 = null;
    }
    if (_objSignalMathOp216 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp216.GetXrpaId());
      _objSignalMathOp216 = null;
    }
    if (_objSignalMathOp218 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp218.GetXrpaId());
      _objSignalMathOp218 = null;
    }
    if (_objSignalCurve213 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve213.GetXrpaId());
      _objSignalCurve213 = null;
    }
    if (_objSignalOscillator215 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator215.GetXrpaId());
      _objSignalOscillator215 = null;
    }
    if (_objSignalFeedback217 != null) {
      _datastoreSignalProcessing.SignalFeedbackOut.RemoveObject(_objSignalFeedback217.GetXrpaId());
      _objSignalFeedback217 = null;
    }
    if (_objSignalEvent214 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent214.GetXrpaId());
      _objSignalEvent214 = null;
    }
    if (_objSignalDelay220 != null) {
      _datastoreSignalProcessing.SignalDelayOut.RemoveObject(_objSignalDelay220.GetXrpaId());
      _objSignalDelay220 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace SignalProcessingDataStore
