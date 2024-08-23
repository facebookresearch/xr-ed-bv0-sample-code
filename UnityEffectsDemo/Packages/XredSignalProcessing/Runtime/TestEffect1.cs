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

public class TestEffect1 : IDisposable {
  private SignalProcessingDataStore _datastoreSignalProcessing;
  private OutboundSignalCurve _objSignalCurve200;
  private OutboundSignalEvent _objSignalEvent205;
  private OutboundSignalEvent _objSignalEvent206;
  private OutboundSignalEvent _objSignalEvent209;
  private OutboundSignalDelay _objSignalDelay201;
  private OutboundSignalCurve _objSignalCurve203;
  private OutboundSignalCurve _objSignalCurve204;
  private OutboundSignalEventCombiner _objSignalEventCombiner207;
  private OutboundSignalEvent _objSignalEvent210;
  private OutboundSignalChannelStack _objSignalChannelStack202;
  private OutboundSignalMultiplexer _objSignalMultiplexer208;
  private OutboundSignalMathOp _objSignalMathOp211;
  private OutboundSignalOutputDevice _objSignalOutputDevice212;

  public TestEffect1(SignalProcessingDataStore datastore) {
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

  ~TestEffect1() {
    Dispose(false);
  }

  void CreateObjects() {
    _objSignalCurve200 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve200);
    _objSignalEvent205 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent205);
    _objSignalEvent206 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent206);
    _objSignalEvent209 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent209);
    _objSignalDelay201 = new OutboundSignalDelay(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalDelayOut.AddObject(_objSignalDelay201);
    _objSignalCurve203 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve203);
    _objSignalCurve204 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve204);
    _objSignalEventCombiner207 = new OutboundSignalEventCombiner(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventCombinerOut.AddObject(_objSignalEventCombiner207);
    _objSignalEvent210 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent210);
    _objSignalChannelStack202 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack202);
    _objSignalMultiplexer208 = new OutboundSignalMultiplexer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMultiplexerOut.AddObject(_objSignalMultiplexer208);
    _objSignalMathOp211 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp211);
    _objSignalOutputDevice212 = new OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalOutputDevice212);
    _objSignalCurve200.SetSoftCurve(false);
    _objSignalCurve200.SetNumSegments(3);
    _objSignalCurve200.SetStartValue(0f);
    _objSignalCurve200.SetSegmentLength0(0.0049900000000000005f);
    _objSignalCurve200.SetSegmentEndValue0(1f);
    _objSignalCurve200.SetSegmentLength1(0.00001000000000000001f);
    _objSignalCurve200.SetSegmentEndValue1(0f);
    _objSignalCurve200.SetSegmentLength2(0.005f);
    _objSignalCurve200.SetSegmentEndValue2(0f);
    _objSignalCurve200.SetAutoStart(true);
    _objSignalCurve200.SetAutoLoop(true);
    _objSignalCurve200.SetNumOutputs(2);
    _objSignalDelay201.SetSrcNode(_objSignalCurve200);
    _objSignalDelay201.SetDelayTimeMs(5f);
    _objSignalDelay201.SetNumChannels(1);
    _objSignalDelay201.SetNumOutputs(1);
    _objSignalCurve203.SetSoftCurve(true);
    _objSignalCurve203.SetNumSegments(5);
    _objSignalCurve203.SetStartValue(0f);
    _objSignalCurve203.SetSegmentLength0(0f);
    _objSignalCurve203.SetSegmentEndValue0(0f);
    _objSignalCurve203.SetSegmentLength1(0.5f);
    _objSignalCurve203.SetSegmentEndValue1(1f);
    _objSignalCurve203.SetSegmentLength2(2f);
    _objSignalCurve203.SetSegmentEndValue2(1f);
    _objSignalCurve203.SetSegmentLength3(1.5f);
    _objSignalCurve203.SetSegmentEndValue3(0f);
    _objSignalCurve203.SetSegmentLength4(0.5f);
    _objSignalCurve203.SetSegmentEndValue4(0f);
    _objSignalCurve203.SetAutoStart(true);
    _objSignalCurve203.SetAutoLoop(false);
    _objSignalCurve203.SetOnDoneEvent(_objSignalEvent205);
    _objSignalCurve203.SetNumOutputs(1);
    _objSignalCurve204.SetSoftCurve(true);
    _objSignalCurve204.SetNumSegments(5);
    _objSignalCurve204.SetStartValue(0f);
    _objSignalCurve204.SetSegmentLength0(0f);
    _objSignalCurve204.SetSegmentEndValue0(0f);
    _objSignalCurve204.SetSegmentLength1(1.5f);
    _objSignalCurve204.SetSegmentEndValue1(1f);
    _objSignalCurve204.SetSegmentLength2(0f);
    _objSignalCurve204.SetSegmentEndValue2(1f);
    _objSignalCurve204.SetSegmentLength3(1.5f);
    _objSignalCurve204.SetSegmentEndValue3(0f);
    _objSignalCurve204.SetSegmentLength4(0f);
    _objSignalCurve204.SetSegmentEndValue4(0f);
    _objSignalCurve204.SetAutoStart(false);
    _objSignalCurve204.SetAutoLoop(false);
    _objSignalCurve204.SetStartEvent(_objSignalEvent205);
    _objSignalCurve204.SetOnDoneEvent(_objSignalEvent206);
    _objSignalCurve204.SetNumOutputs(1);
    _objSignalEventCombiner207.SetSrcEvent0(_objSignalEvent205);
    _objSignalEventCombiner207.SetSrcEvent1(_objSignalEvent206);
    _objSignalEventCombiner207.SetOnEvent(_objSignalEvent209);
    _objSignalChannelStack202.SetSrcNode0(_objSignalCurve200);
    _objSignalChannelStack202.SetSrcNode1(_objSignalDelay201);
    _objSignalChannelStack202.SetNumChannels(2);
    _objSignalChannelStack202.SetNumOutputs(1);
    _objSignalMultiplexer208.SetSrcNode0(_objSignalCurve203);
    _objSignalMultiplexer208.SetSrcNode1(_objSignalCurve204);
    _objSignalMultiplexer208.SetIncrementEvent(_objSignalEvent209);
    _objSignalMultiplexer208.SetAutoStart(true);
    _objSignalMultiplexer208.SetNumChannels(1);
    _objSignalMultiplexer208.SetOnDoneEvent(_objSignalEvent210);
    _objSignalMultiplexer208.SetNumOutputs(1);
    _objSignalMathOp211.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp211.SetOperandANode(_objSignalChannelStack202);
    _objSignalMathOp211.SetOperandBNode(_objSignalMultiplexer208);
    _objSignalMathOp211.SetNumChannels(2);
    _objSignalMathOp211.SetNumOutputs(1);
    _objSignalOutputDevice212.SetSrcNode(_objSignalMathOp211);
    _objSignalOutputDevice212.SetDeviceNameFilter("BuzzDuino");
    _objSignalOutputDevice212.SetChannelOffset(0);
    if (_objSignalEvent210 != null) {
      _objSignalEvent210.OnReceiveEvent((_, _) => Terminate());
    }
  }

  void DestroyObjects() {
    if (_objSignalOutputDevice212 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalOutputDevice212.GetXrpaId());
      _objSignalOutputDevice212 = null;
    }
    if (_objSignalMathOp211 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp211.GetXrpaId());
      _objSignalMathOp211 = null;
    }
    if (_objSignalMultiplexer208 != null) {
      _datastoreSignalProcessing.SignalMultiplexerOut.RemoveObject(_objSignalMultiplexer208.GetXrpaId());
      _objSignalMultiplexer208 = null;
    }
    if (_objSignalChannelStack202 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack202.GetXrpaId());
      _objSignalChannelStack202 = null;
    }
    if (_objSignalEvent210 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent210.GetXrpaId());
      _objSignalEvent210 = null;
    }
    if (_objSignalEventCombiner207 != null) {
      _datastoreSignalProcessing.SignalEventCombinerOut.RemoveObject(_objSignalEventCombiner207.GetXrpaId());
      _objSignalEventCombiner207 = null;
    }
    if (_objSignalCurve204 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve204.GetXrpaId());
      _objSignalCurve204 = null;
    }
    if (_objSignalCurve203 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve203.GetXrpaId());
      _objSignalCurve203 = null;
    }
    if (_objSignalDelay201 != null) {
      _datastoreSignalProcessing.SignalDelayOut.RemoveObject(_objSignalDelay201.GetXrpaId());
      _objSignalDelay201 = null;
    }
    if (_objSignalEvent209 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent209.GetXrpaId());
      _objSignalEvent209 = null;
    }
    if (_objSignalEvent206 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent206.GetXrpaId());
      _objSignalEvent206 = null;
    }
    if (_objSignalEvent205 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent205.GetXrpaId());
      _objSignalEvent205 = null;
    }
    if (_objSignalCurve200 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve200.GetXrpaId());
      _objSignalCurve200 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace SignalProcessingDataStore
