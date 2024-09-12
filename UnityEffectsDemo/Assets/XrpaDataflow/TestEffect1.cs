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

public class TestEffect1 : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve0;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent5;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent6;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent9;
  private SignalProcessingDataStore.OutboundSignalDelay _objSignalProcessingSignalDelay1;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve3;
  private SignalProcessingDataStore.OutboundSignalCurve _objSignalProcessingSignalCurve4;
  private SignalProcessingDataStore.OutboundSignalEventCombiner _objSignalProcessingSignalEventCombiner7;
  private SignalProcessingDataStore.OutboundSignalEvent _objSignalProcessingSignalEvent10;
  private SignalProcessingDataStore.OutboundSignalChannelStack _objSignalProcessingSignalChannelStack2;
  private SignalProcessingDataStore.OutboundSignalMultiplexer _objSignalProcessingSignalMultiplexer8;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp11;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice12;

  public TestEffect1(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing) {
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

  ~TestEffect1() {
    Dispose(false);
  }

  void CreateObjects() {
    _objSignalProcessingSignalCurve0 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve0);
    _objSignalProcessingSignalEvent5 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent5);
    _objSignalProcessingSignalEvent6 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent6);
    _objSignalProcessingSignalEvent9 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent9);
    _objSignalProcessingSignalDelay1 = new SignalProcessingDataStore.OutboundSignalDelay(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalDelayOut.AddObject(_objSignalProcessingSignalDelay1);
    _objSignalProcessingSignalCurve3 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve3);
    _objSignalProcessingSignalCurve4 = new SignalProcessingDataStore.OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalProcessingSignalCurve4);
    _objSignalProcessingSignalEventCombiner7 = new SignalProcessingDataStore.OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalProcessingSignalEventCombiner7);
    _objSignalProcessingSignalEvent10 = new SignalProcessingDataStore.OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalProcessingSignalEvent10);
    _objSignalProcessingSignalChannelStack2 = new SignalProcessingDataStore.OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalProcessingSignalChannelStack2);
    _objSignalProcessingSignalMultiplexer8 = new SignalProcessingDataStore.OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalProcessingSignalMultiplexer8);
    _objSignalProcessingSignalMathOp11 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp11);
    _objSignalProcessingSignalOutputDevice12 = new SignalProcessingDataStore.OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalProcessingSignalOutputDevice12);
    _objSignalProcessingSignalCurve0.SetSoftCurve(false);
    _objSignalProcessingSignalCurve0.SetNumSegments(3);
    _objSignalProcessingSignalCurve0.SetStartValue(0f);
    _objSignalProcessingSignalCurve0.SetSegmentLength0(0.0049900000000000005f);
    _objSignalProcessingSignalCurve0.SetSegmentEndValue0(1f);
    _objSignalProcessingSignalCurve0.SetSegmentLength1(0.00001000000000000001f);
    _objSignalProcessingSignalCurve0.SetSegmentEndValue1(0f);
    _objSignalProcessingSignalCurve0.SetSegmentLength2(0.005f);
    _objSignalProcessingSignalCurve0.SetSegmentEndValue2(0f);
    _objSignalProcessingSignalCurve0.SetAutoStart(true);
    _objSignalProcessingSignalCurve0.SetAutoLoop(true);
    _objSignalProcessingSignalCurve0.SetNumOutputs(2);
    _objSignalProcessingSignalDelay1.SetSrcNode(_objSignalProcessingSignalCurve0);
    _objSignalProcessingSignalDelay1.SetDelayTimeMs(5f);
    _objSignalProcessingSignalDelay1.SetNumChannels(1);
    _objSignalProcessingSignalDelay1.SetNumOutputs(1);
    _objSignalProcessingSignalCurve3.SetSoftCurve(true);
    _objSignalProcessingSignalCurve3.SetNumSegments(5);
    _objSignalProcessingSignalCurve3.SetStartValue(0f);
    _objSignalProcessingSignalCurve3.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve3.SetSegmentLength1(0.5f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue1(1f);
    _objSignalProcessingSignalCurve3.SetSegmentLength2(2f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue2(1f);
    _objSignalProcessingSignalCurve3.SetSegmentLength3(1.5f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve3.SetSegmentLength4(0.5f);
    _objSignalProcessingSignalCurve3.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve3.SetAutoStart(true);
    _objSignalProcessingSignalCurve3.SetAutoLoop(false);
    _objSignalProcessingSignalCurve3.SetOnDoneEvent(_objSignalProcessingSignalEvent5);
    _objSignalProcessingSignalCurve3.SetNumOutputs(1);
    _objSignalProcessingSignalCurve4.SetSoftCurve(true);
    _objSignalProcessingSignalCurve4.SetNumSegments(5);
    _objSignalProcessingSignalCurve4.SetStartValue(0f);
    _objSignalProcessingSignalCurve4.SetSegmentLength0(0f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue0(0f);
    _objSignalProcessingSignalCurve4.SetSegmentLength1(1.5f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue1(1f);
    _objSignalProcessingSignalCurve4.SetSegmentLength2(0f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue2(1f);
    _objSignalProcessingSignalCurve4.SetSegmentLength3(1.5f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue3(0f);
    _objSignalProcessingSignalCurve4.SetSegmentLength4(0f);
    _objSignalProcessingSignalCurve4.SetSegmentEndValue4(0f);
    _objSignalProcessingSignalCurve4.SetAutoStart(false);
    _objSignalProcessingSignalCurve4.SetAutoLoop(false);
    _objSignalProcessingSignalCurve4.SetStartEvent(_objSignalProcessingSignalEvent5);
    _objSignalProcessingSignalCurve4.SetOnDoneEvent(_objSignalProcessingSignalEvent6);
    _objSignalProcessingSignalCurve4.SetNumOutputs(1);
    _objSignalProcessingSignalEventCombiner7.SetSrcEvent0(_objSignalProcessingSignalEvent5);
    _objSignalProcessingSignalEventCombiner7.SetSrcEvent1(_objSignalProcessingSignalEvent6);
    _objSignalProcessingSignalEventCombiner7.SetOnEvent(_objSignalProcessingSignalEvent9);
    _objSignalProcessingSignalChannelStack2.SetSrcNode0(_objSignalProcessingSignalCurve0);
    _objSignalProcessingSignalChannelStack2.SetSrcNode1(_objSignalProcessingSignalDelay1);
    _objSignalProcessingSignalChannelStack2.SetNumChannels(2);
    _objSignalProcessingSignalChannelStack2.SetNumOutputs(1);
    _objSignalProcessingSignalMultiplexer8.SetSrcNode0(_objSignalProcessingSignalCurve3);
    _objSignalProcessingSignalMultiplexer8.SetSrcNode1(_objSignalProcessingSignalCurve4);
    _objSignalProcessingSignalMultiplexer8.SetIncrementEvent(_objSignalProcessingSignalEvent9);
    _objSignalProcessingSignalMultiplexer8.SetAutoStart(true);
    _objSignalProcessingSignalMultiplexer8.SetNumChannels(1);
    _objSignalProcessingSignalMultiplexer8.SetOnDoneEvent(_objSignalProcessingSignalEvent10);
    _objSignalProcessingSignalMultiplexer8.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp11.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp11.SetOperandANode(_objSignalProcessingSignalChannelStack2);
    _objSignalProcessingSignalMathOp11.SetOperandBNode(_objSignalProcessingSignalMultiplexer8);
    _objSignalProcessingSignalMathOp11.SetNumChannels(2);
    _objSignalProcessingSignalMathOp11.SetNumOutputs(1);
    _objSignalProcessingSignalOutputDevice12.SetSrcNode(_objSignalProcessingSignalMathOp11);
    _objSignalProcessingSignalOutputDevice12.SetDeviceNameFilter("BuzzDuino");
    _objSignalProcessingSignalOutputDevice12.SetChannelOffset(0);
    if (_objSignalProcessingSignalEvent10 != null) {
      _objSignalProcessingSignalEvent10.OnReceiveEvent((_, _) => Terminate());
    }
  }

  void DestroyObjects() {
    if (_objSignalProcessingSignalOutputDevice12 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalProcessingSignalOutputDevice12.GetXrpaId());
      _objSignalProcessingSignalOutputDevice12 = null;
    }
    if (_objSignalProcessingSignalMathOp11 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp11.GetXrpaId());
      _objSignalProcessingSignalMathOp11 = null;
    }
    if (_objSignalProcessingSignalMultiplexer8 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalProcessingSignalMultiplexer8.GetXrpaId());
      _objSignalProcessingSignalMultiplexer8 = null;
    }
    if (_objSignalProcessingSignalChannelStack2 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalProcessingSignalChannelStack2.GetXrpaId());
      _objSignalProcessingSignalChannelStack2 = null;
    }
    if (_objSignalProcessingSignalEvent10 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent10.GetXrpaId());
      _objSignalProcessingSignalEvent10 = null;
    }
    if (_objSignalProcessingSignalEventCombiner7 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalProcessingSignalEventCombiner7.GetXrpaId());
      _objSignalProcessingSignalEventCombiner7 = null;
    }
    if (_objSignalProcessingSignalCurve4 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve4.GetXrpaId());
      _objSignalProcessingSignalCurve4 = null;
    }
    if (_objSignalProcessingSignalCurve3 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve3.GetXrpaId());
      _objSignalProcessingSignalCurve3 = null;
    }
    if (_objSignalProcessingSignalDelay1 != null) {
      _datastoreSignalProcessing.SignalDelayOut.RemoveObject(_objSignalProcessingSignalDelay1.GetXrpaId());
      _objSignalProcessingSignalDelay1 = null;
    }
    if (_objSignalProcessingSignalEvent9 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent9.GetXrpaId());
      _objSignalProcessingSignalEvent9 = null;
    }
    if (_objSignalProcessingSignalEvent6 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent6.GetXrpaId());
      _objSignalProcessingSignalEvent6 = null;
    }
    if (_objSignalProcessingSignalEvent5 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalProcessingSignalEvent5.GetXrpaId());
      _objSignalProcessingSignalEvent5 = null;
    }
    if (_objSignalProcessingSignalCurve0 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalProcessingSignalCurve0.GetXrpaId());
      _objSignalProcessingSignalCurve0 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace XrpaDataflow
