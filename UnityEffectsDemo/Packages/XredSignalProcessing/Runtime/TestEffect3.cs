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

public class TestEffect3 : IDisposable {
  private SignalProcessingDataStore _datastoreSignalProcessing;
  private OutboundSignalParametricEqualizer _objSignalParametricEqualizer228;
  private OutboundSignalDelay _objSignalDelay229;
  private OutboundSignalFeedback _objSignalFeedback224;
  private OutboundSignalSourceFile _objSignalSourceFile223;
  private OutboundSignalMathOp _objSignalMathOp226;
  private OutboundSignalParametricEqualizer _objSignalParametricEqualizer225;
  private OutboundSignalMathOp _objSignalMathOp227;
  private OutboundSignalOutputDevice _objSignalOutputDevice230;

  public TestEffect3(SignalProcessingDataStore datastore) {
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

  ~TestEffect3() {
    Dispose(false);
  }

  void CreateObjects() {
    _objSignalParametricEqualizer228 = new OutboundSignalParametricEqualizer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalParametricEqualizerOut.AddObject(_objSignalParametricEqualizer228);
    _objSignalDelay229 = new OutboundSignalDelay(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalDelayOut.AddObject(_objSignalDelay229);
    _objSignalFeedback224 = new OutboundSignalFeedback(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalFeedbackOut.AddObject(_objSignalFeedback224);
    _objSignalSourceFile223 = new OutboundSignalSourceFile(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalSourceFileOut.AddObject(_objSignalSourceFile223);
    _objSignalMathOp226 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp226);
    _objSignalParametricEqualizer225 = new OutboundSignalParametricEqualizer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalParametricEqualizerOut.AddObject(_objSignalParametricEqualizer225);
    _objSignalMathOp227 = new OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalMathOp227);
    _objSignalOutputDevice230 = new OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalOutputDevice230);
    _objSignalParametricEqualizer228.SetSrcNode(_objSignalMathOp227);
    _objSignalParametricEqualizer228.SetFilterType0((FilterType)(uint)(4));
    _objSignalParametricEqualizer228.SetFrequency0(500f);
    _objSignalParametricEqualizer228.SetQuality0(1f);
    _objSignalParametricEqualizer228.SetGain0(0f);
    _objSignalParametricEqualizer228.SetFilterType1((FilterType)(uint)(0));
    _objSignalParametricEqualizer228.SetFrequency1(50f);
    _objSignalParametricEqualizer228.SetQuality1(0.7076f);
    _objSignalParametricEqualizer228.SetGain1(0f);
    _objSignalParametricEqualizer228.SetFilterType2((FilterType)(uint)(0));
    _objSignalParametricEqualizer228.SetFrequency2(50f);
    _objSignalParametricEqualizer228.SetQuality2(0.7076f);
    _objSignalParametricEqualizer228.SetGain2(0f);
    _objSignalParametricEqualizer228.SetFilterType3((FilterType)(uint)(0));
    _objSignalParametricEqualizer228.SetFrequency3(50f);
    _objSignalParametricEqualizer228.SetQuality3(0.7076f);
    _objSignalParametricEqualizer228.SetGain3(0f);
    _objSignalParametricEqualizer228.SetFilterType4((FilterType)(uint)(0));
    _objSignalParametricEqualizer228.SetFrequency4(50f);
    _objSignalParametricEqualizer228.SetQuality4(0.7076f);
    _objSignalParametricEqualizer228.SetGain4(0f);
    _objSignalParametricEqualizer228.SetGainAdjust(0f);
    _objSignalParametricEqualizer228.SetNumChannels(2);
    _objSignalParametricEqualizer228.SetNumOutputs(1);
    _objSignalDelay229.SetSrcNode(_objSignalParametricEqualizer228);
    _objSignalDelay229.SetDelayTimeMs(250f);
    _objSignalDelay229.SetNumChannels(2);
    _objSignalDelay229.SetNumOutputs(1);
    _objSignalFeedback224.SetNumOutputs(1);
    _objSignalFeedback224.SetSrcNode(_objSignalDelay229);
    _objSignalFeedback224.SetNumChannels(2);
    _objSignalSourceFile223.SetFilePath("C:\\Users\\lillithompson\\Documents\\GitHub\\UnityEffectsDemo\\js\\effects\\test.wav");
    _objSignalSourceFile223.SetAutoPlay(true);
    _objSignalSourceFile223.SetNumOutputs(1);
    _objSignalMathOp226.SetOperation((MathOperation)(uint)(1));
    _objSignalMathOp226.SetOperandANode(_objSignalFeedback224);
    _objSignalMathOp226.SetOperandB(0.25f);
    _objSignalMathOp226.SetNumChannels(0);
    _objSignalMathOp226.SetNumOutputs(1);
    _objSignalParametricEqualizer225.SetSrcNode(_objSignalSourceFile223);
    _objSignalParametricEqualizer225.SetFilterType0((FilterType)(uint)(5));
    _objSignalParametricEqualizer225.SetFrequency0(1000f);
    _objSignalParametricEqualizer225.SetQuality0(1f);
    _objSignalParametricEqualizer225.SetGain0(0f);
    _objSignalParametricEqualizer225.SetFilterType1((FilterType)(uint)(0));
    _objSignalParametricEqualizer225.SetFrequency1(50f);
    _objSignalParametricEqualizer225.SetQuality1(0.7076f);
    _objSignalParametricEqualizer225.SetGain1(0f);
    _objSignalParametricEqualizer225.SetFilterType2((FilterType)(uint)(0));
    _objSignalParametricEqualizer225.SetFrequency2(50f);
    _objSignalParametricEqualizer225.SetQuality2(0.7076f);
    _objSignalParametricEqualizer225.SetGain2(0f);
    _objSignalParametricEqualizer225.SetFilterType3((FilterType)(uint)(0));
    _objSignalParametricEqualizer225.SetFrequency3(50f);
    _objSignalParametricEqualizer225.SetQuality3(0.7076f);
    _objSignalParametricEqualizer225.SetGain3(0f);
    _objSignalParametricEqualizer225.SetFilterType4((FilterType)(uint)(0));
    _objSignalParametricEqualizer225.SetFrequency4(50f);
    _objSignalParametricEqualizer225.SetQuality4(0.7076f);
    _objSignalParametricEqualizer225.SetGain4(0f);
    _objSignalParametricEqualizer225.SetGainAdjust(0f);
    _objSignalParametricEqualizer225.SetNumChannels(2);
    _objSignalParametricEqualizer225.SetNumOutputs(1);
    _objSignalMathOp227.SetOperation((MathOperation)(uint)(0));
    _objSignalMathOp227.SetOperandANode(_objSignalMathOp226);
    _objSignalMathOp227.SetOperandBNode(_objSignalParametricEqualizer225);
    _objSignalMathOp227.SetNumChannels(2);
    _objSignalMathOp227.SetNumOutputs(2);
    _objSignalOutputDevice230.SetSrcNode(_objSignalMathOp227);
    _objSignalOutputDevice230.SetDeviceNameFilter("Headphones");
    _objSignalOutputDevice230.SetChannelOffset(0);
  }

  void DestroyObjects() {
    if (_objSignalOutputDevice230 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalOutputDevice230.GetXrpaId());
      _objSignalOutputDevice230 = null;
    }
    if (_objSignalMathOp227 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp227.GetXrpaId());
      _objSignalMathOp227 = null;
    }
    if (_objSignalParametricEqualizer225 != null) {
      _datastoreSignalProcessing.SignalParametricEqualizerOut.RemoveObject(_objSignalParametricEqualizer225.GetXrpaId());
      _objSignalParametricEqualizer225 = null;
    }
    if (_objSignalMathOp226 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalMathOp226.GetXrpaId());
      _objSignalMathOp226 = null;
    }
    if (_objSignalSourceFile223 != null) {
      _datastoreSignalProcessing.SignalSourceFileOut.RemoveObject(_objSignalSourceFile223.GetXrpaId());
      _objSignalSourceFile223 = null;
    }
    if (_objSignalFeedback224 != null) {
      _datastoreSignalProcessing.SignalFeedbackOut.RemoveObject(_objSignalFeedback224.GetXrpaId());
      _objSignalFeedback224 = null;
    }
    if (_objSignalDelay229 != null) {
      _datastoreSignalProcessing.SignalDelayOut.RemoveObject(_objSignalDelay229.GetXrpaId());
      _objSignalDelay229 = null;
    }
    if (_objSignalParametricEqualizer228 != null) {
      _datastoreSignalProcessing.SignalParametricEqualizerOut.RemoveObject(_objSignalParametricEqualizer228.GetXrpaId());
      _objSignalParametricEqualizer228 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace SignalProcessingDataStore
