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

public class ContinuousWave : IDisposable {
  private SignalProcessingDataStore _datastoreSignalProcessing;
  private float _paramFundamentalAmp = 1f;
  private float _paramFundamentalFq = 170f;
  private float _paramLFOAmp = 1f;
  private float _paramLFOFq = 5f;
  private OutboundSignalOscillator _objSignalOscillator116;
  private OutboundSignalOscillator _objSignalOscillator118;
  private OutboundSignalMathOp _objSignalMathOp117;
  private OutboundSignalMathOp _objSignalMathOp119;
  private OutboundSignalEvent _objSignalEvent121;
  private OutboundSignalMathOp _objSignalMathOp122;
  private OutboundSignalCurve _objSignalCurve120;
  private OutboundSignalMathOp _objSignalMathOp124;
  private OutboundSignalMathOp _objSignalMathOp123;
  private OutboundSignalMathOp _objSignalMathOp125;
  private OutboundSignalChannelStack _objSignalChannelStack126;
  private OutboundSignalOutputDevice _objSignalOutputDevice127;

  public ContinuousWave(SignalProcessingDataStore datastore) {
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

  ~ContinuousWave() {
    Dispose(false);
  }

  public float GetFundamentalAmp() {
    return _paramFundamentalAmp;
  }

  public void SetFundamentalAmp(float FundamentalAmp) {
    _paramFundamentalAmp = FundamentalAmp;
    if (_objSignalMathOp117 != null) {
      _objSignalMathOp117.SetOperandB(FundamentalAmp);
    }
    if (_objSignalCurve120 != null) {
      _objSignalCurve120.SetSegmentEndValue1(FundamentalAmp);
    }
    if (_objSignalCurve120 != null) {
      _objSignalCurve120.SetSegmentEndValue2(FundamentalAmp);
    }
  }

  public float GetFundamentalFq() {
    return _paramFundamentalFq;
  }

  public void SetFundamentalFq(float FundamentalFq) {
    _paramFundamentalFq = FundamentalFq;
    if (_objSignalOscillator116 != null) {
      _objSignalOscillator116.SetFrequency(FundamentalFq);
    }
  }

  public float GetLFOAmp() {
    return _paramLFOAmp;
  }

  public void SetLFOAmp(float LFOAmp) {
    _paramLFOAmp = LFOAmp;
    if (_objSignalMathOp119 != null) {
      _objSignalMathOp119.SetOperandB(LFOAmp);
    }
  }

  public float GetLFOFq() {
    return _paramLFOFq;
  }

  public void SetLFOFq(float LFOFq) {
    _paramLFOFq = LFOFq;
    if (_objSignalOscillator118 != null) {
      _objSignalOscillator118.SetFrequency(LFOFq);
    }
  }

  void CreateObjects() {
    _objSignalOscillator116 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator116);
    _objSignalOscillator118 = new OutboundSignalOscillator(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOscillatorOut.AddObject(_objSignalOscillator118);
    _objSignalMathOp117 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp117);
    _objSignalMathOp119 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp119);
    _objSignalEvent121 = new OutboundSignalEvent(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalEventOut.AddObject(_objSignalEvent121);
    _objSignalMathOp122 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp122);
    _objSignalCurve120 = new OutboundSignalCurve(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalCurveOut.AddObject(_objSignalCurve120);
    _objSignalMathOp124 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp124);
    _objSignalMathOp123 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp123);
    _objSignalMathOp125 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp125);
    _objSignalChannelStack126 = new OutboundSignalChannelStack(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalChannelStackOut.AddObject(_objSignalChannelStack126);
    _objSignalOutputDevice127 = new OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalOutputDevice127);
    _objSignalOscillator116.SetNumChannels(1);
    _objSignalOscillator116.SetWaveformType((WaveformType)(uint)(3));
    _objSignalOscillator116.SetFrequency(_paramFundamentalFq);
    _objSignalOscillator116.SetPulseWidth(0.5f);
    _objSignalOscillator116.SetNumOutputs(1);
    _objSignalOscillator118.SetNumChannels(1);
    _objSignalOscillator118.SetWaveformType((WaveformType)(uint)(3));
    _objSignalOscillator118.SetFrequency(_paramLFOFq);
    _objSignalOscillator118.SetPulseWidth(0.5f);
    _objSignalOscillator118.SetNumOutputs(1);
    _objSignalMathOp117.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp117.SetOperandANode(_objSignalOscillator116);
    _objSignalMathOp117.SetOperandB(_paramFundamentalAmp);
    _objSignalMathOp117.SetNumChannels(1);
    _objSignalMathOp117.SetNumOutputs(2);
    _objSignalMathOp119.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp119.SetOperandANode(_objSignalOscillator118);
    _objSignalMathOp119.SetOperandB(_paramLFOAmp);
    _objSignalMathOp119.SetNumChannels(1);
    _objSignalMathOp119.SetNumOutputs(2);
    _objSignalMathOp122.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp122.SetOperandANode(_objSignalMathOp117);
    _objSignalMathOp122.SetOperandBNode(_objSignalMathOp119);
    _objSignalMathOp122.SetNumChannels(1);
    _objSignalMathOp122.SetNumOutputs(1);
    _objSignalCurve120.SetSoftCurve(true);
    _objSignalCurve120.SetNumSegments(5);
    _objSignalCurve120.SetStartValue(0f);
    _objSignalCurve120.SetSegmentLength0(0f);
    _objSignalCurve120.SetSegmentEndValue0(0f);
    _objSignalCurve120.SetSegmentLength1(0.005f);
    _objSignalCurve120.SetSegmentEndValue1(_paramFundamentalAmp);
    _objSignalCurve120.SetSegmentLength2(100f);
    _objSignalCurve120.SetSegmentEndValue2(_paramFundamentalAmp);
    _objSignalCurve120.SetSegmentLength3(0.005f);
    _objSignalCurve120.SetSegmentEndValue3(0f);
    _objSignalCurve120.SetSegmentLength4(0f);
    _objSignalCurve120.SetSegmentEndValue4(0f);
    _objSignalCurve120.SetAutoStart(true);
    _objSignalCurve120.SetAutoLoop(false);
    _objSignalCurve120.SetOnDoneEvent(_objSignalEvent121);
    _objSignalCurve120.SetNumOutputs(2);
    _objSignalMathOp124.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp124.SetOperandANode(_objSignalMathOp117);
    _objSignalMathOp124.SetOperandBNode(_objSignalMathOp119);
    _objSignalMathOp124.SetNumChannels(1);
    _objSignalMathOp124.SetNumOutputs(1);
    _objSignalMathOp123.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp123.SetOperandANode(_objSignalMathOp122);
    _objSignalMathOp123.SetOperandBNode(_objSignalCurve120);
    _objSignalMathOp123.SetNumChannels(1);
    _objSignalMathOp123.SetNumOutputs(1);
    _objSignalMathOp125.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp125.SetOperandANode(_objSignalMathOp124);
    _objSignalMathOp125.SetOperandBNode(_objSignalCurve120);
    _objSignalMathOp125.SetNumChannels(1);
    _objSignalMathOp125.SetNumOutputs(1);
    _objSignalChannelStack126.SetSrcNode0(_objSignalMathOp123);
    _objSignalChannelStack126.SetSrcNode1(_objSignalMathOp125);
    _objSignalChannelStack126.SetNumChannels(2);
    _objSignalChannelStack126.SetNumOutputs(1);
    _objSignalOutputDevice127.SetSrcNode(_objSignalChannelStack126);
    _objSignalOutputDevice127.SetDeviceNameFilter("BuzzDuino");
    _objSignalOutputDevice127.SetChannelOffset(0);
    if (_objSignalEvent121 != null) {
      _objSignalEvent121.OnReceiveEvent((_, _) => Terminate());
    }
  }

  void DestroyObjects() {
    if (_objSignalOutputDevice127 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalOutputDevice127.GetXrpaId());
      _objSignalOutputDevice127 = null;
    }
    if (_objSignalChannelStack126 != null) {
      _datastoreSignalProcessing.SignalChannelStackOut.RemoveObject(_objSignalChannelStack126.GetXrpaId());
      _objSignalChannelStack126 = null;
    }
    if (_objSignalMathOp125 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp125.GetXrpaId());
      _objSignalMathOp125 = null;
    }
    if (_objSignalMathOp123 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp123.GetXrpaId());
      _objSignalMathOp123 = null;
    }
    if (_objSignalMathOp124 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp124.GetXrpaId());
      _objSignalMathOp124 = null;
    }
    if (_objSignalCurve120 != null) {
      _datastoreSignalProcessing.SignalCurveOut.RemoveObject(_objSignalCurve120.GetXrpaId());
      _objSignalCurve120 = null;
    }
    if (_objSignalMathOp122 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp122.GetXrpaId());
      _objSignalMathOp122 = null;
    }
    if (_objSignalEvent121 != null) {
      _datastoreSignalProcessing.SignalEventOut.RemoveObject(_objSignalEvent121.GetXrpaId());
      _objSignalEvent121 = null;
    }
    if (_objSignalMathOp119 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp119.GetXrpaId());
      _objSignalMathOp119 = null;
    }
    if (_objSignalMathOp117 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp117.GetXrpaId());
      _objSignalMathOp117 = null;
    }
    if (_objSignalOscillator118 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator118.GetXrpaId());
      _objSignalOscillator118 = null;
    }
    if (_objSignalOscillator116 != null) {
      _datastoreSignalProcessing.SignalOscillatorOut.RemoveObject(_objSignalOscillator116.GetXrpaId());
      _objSignalOscillator116 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace SignalProcessingDataStore
