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

public class TestEffect3 : IDisposable {
  private SignalProcessingDataStore.SignalProcessingDataStore _datastoreSignalProcessing;
  private SignalProcessingDataStore.OutboundSignalSourceFile _objSignalProcessingSignalSourceFile0;
  private SignalProcessingDataStore.OutboundSignalParametricEqualizer _objSignalProcessingSignalParametricEqualizer5;
  private SignalProcessingDataStore.OutboundSignalParametricEqualizer _objSignalProcessingSignalParametricEqualizer2;
  private SignalProcessingDataStore.OutboundSignalFeedback _objSignalProcessingSignalFeedback1;
  private SignalProcessingDataStore.OutboundSignalDelay _objSignalProcessingSignalDelay6;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp4;
  private SignalProcessingDataStore.OutboundSignalMathOp _objSignalProcessingSignalMathOp3;
  private SignalProcessingDataStore.OutboundSignalOutputDevice _objSignalProcessingSignalOutputDevice7;

  public TestEffect3(SignalProcessingDataStore.SignalProcessingDataStore datastoreSignalProcessing) {
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

  ~TestEffect3() {
    Dispose(false);
  }

  void CreateObjects() {
    _objSignalProcessingSignalSourceFile0 = new SignalProcessingDataStore.OutboundSignalSourceFile(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalSourceFileOut.AddObject(_objSignalProcessingSignalSourceFile0);
    _objSignalProcessingSignalParametricEqualizer5 = new SignalProcessingDataStore.OutboundSignalParametricEqualizer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalParametricEqualizerOut.AddObject(_objSignalProcessingSignalParametricEqualizer5);
    _objSignalProcessingSignalParametricEqualizer2 = new SignalProcessingDataStore.OutboundSignalParametricEqualizer(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalParametricEqualizerOut.AddObject(_objSignalProcessingSignalParametricEqualizer2);
    _objSignalProcessingSignalFeedback1 = new SignalProcessingDataStore.OutboundSignalFeedback(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalFeedbackOut.AddObject(_objSignalProcessingSignalFeedback1);
    _objSignalProcessingSignalDelay6 = new SignalProcessingDataStore.OutboundSignalDelay(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalDelayOut.AddObject(_objSignalProcessingSignalDelay6);
    _objSignalProcessingSignalMathOp4 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp4);
    _objSignalProcessingSignalMathOp3 = new SignalProcessingDataStore.OutboundSignalMathOp(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalMathOpOut.AddObject(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalOutputDevice7 = new SignalProcessingDataStore.OutboundSignalOutputDevice(new Xrpa.DSIdentifier(System.Guid.NewGuid()));
    _datastoreSignalProcessing.SignalOutputDeviceOut.AddObject(_objSignalProcessingSignalOutputDevice7);
    _objSignalProcessingSignalSourceFile0.SetFilePath("C:\\open\\fbsource\\arvr\\projects\\xred\\xr-ed-bv0-sample-code\\UnityEffectsDemo\\js\\effects\\test.wav");
    _objSignalProcessingSignalSourceFile0.SetAutoPlay(true);
    _objSignalProcessingSignalSourceFile0.SetNumOutputs(1);
    _objSignalProcessingSignalParametricEqualizer5.SetSrcNode(_objSignalProcessingSignalMathOp4);
    _objSignalProcessingSignalParametricEqualizer5.SetFilterType0((SignalProcessingDataStore.FilterType)(uint)(4));
    _objSignalProcessingSignalParametricEqualizer5.SetFrequency0(500f);
    _objSignalProcessingSignalParametricEqualizer5.SetQuality0(1f);
    _objSignalProcessingSignalParametricEqualizer5.SetGain0(0f);
    _objSignalProcessingSignalParametricEqualizer5.SetFilterType1((SignalProcessingDataStore.FilterType)(uint)(0));
    _objSignalProcessingSignalParametricEqualizer5.SetFrequency1(50f);
    _objSignalProcessingSignalParametricEqualizer5.SetQuality1(0.7076f);
    _objSignalProcessingSignalParametricEqualizer5.SetGain1(0f);
    _objSignalProcessingSignalParametricEqualizer5.SetFilterType2((SignalProcessingDataStore.FilterType)(uint)(0));
    _objSignalProcessingSignalParametricEqualizer5.SetFrequency2(50f);
    _objSignalProcessingSignalParametricEqualizer5.SetQuality2(0.7076f);
    _objSignalProcessingSignalParametricEqualizer5.SetGain2(0f);
    _objSignalProcessingSignalParametricEqualizer5.SetFilterType3((SignalProcessingDataStore.FilterType)(uint)(0));
    _objSignalProcessingSignalParametricEqualizer5.SetFrequency3(50f);
    _objSignalProcessingSignalParametricEqualizer5.SetQuality3(0.7076f);
    _objSignalProcessingSignalParametricEqualizer5.SetGain3(0f);
    _objSignalProcessingSignalParametricEqualizer5.SetFilterType4((SignalProcessingDataStore.FilterType)(uint)(0));
    _objSignalProcessingSignalParametricEqualizer5.SetFrequency4(50f);
    _objSignalProcessingSignalParametricEqualizer5.SetQuality4(0.7076f);
    _objSignalProcessingSignalParametricEqualizer5.SetGain4(0f);
    _objSignalProcessingSignalParametricEqualizer5.SetGainAdjust(0f);
    _objSignalProcessingSignalParametricEqualizer5.SetNumChannels(2);
    _objSignalProcessingSignalParametricEqualizer5.SetNumOutputs(1);
    _objSignalProcessingSignalParametricEqualizer2.SetSrcNode(_objSignalProcessingSignalSourceFile0);
    _objSignalProcessingSignalParametricEqualizer2.SetFilterType0((SignalProcessingDataStore.FilterType)(uint)(5));
    _objSignalProcessingSignalParametricEqualizer2.SetFrequency0(1000f);
    _objSignalProcessingSignalParametricEqualizer2.SetQuality0(1f);
    _objSignalProcessingSignalParametricEqualizer2.SetGain0(0f);
    _objSignalProcessingSignalParametricEqualizer2.SetFilterType1((SignalProcessingDataStore.FilterType)(uint)(0));
    _objSignalProcessingSignalParametricEqualizer2.SetFrequency1(50f);
    _objSignalProcessingSignalParametricEqualizer2.SetQuality1(0.7076f);
    _objSignalProcessingSignalParametricEqualizer2.SetGain1(0f);
    _objSignalProcessingSignalParametricEqualizer2.SetFilterType2((SignalProcessingDataStore.FilterType)(uint)(0));
    _objSignalProcessingSignalParametricEqualizer2.SetFrequency2(50f);
    _objSignalProcessingSignalParametricEqualizer2.SetQuality2(0.7076f);
    _objSignalProcessingSignalParametricEqualizer2.SetGain2(0f);
    _objSignalProcessingSignalParametricEqualizer2.SetFilterType3((SignalProcessingDataStore.FilterType)(uint)(0));
    _objSignalProcessingSignalParametricEqualizer2.SetFrequency3(50f);
    _objSignalProcessingSignalParametricEqualizer2.SetQuality3(0.7076f);
    _objSignalProcessingSignalParametricEqualizer2.SetGain3(0f);
    _objSignalProcessingSignalParametricEqualizer2.SetFilterType4((SignalProcessingDataStore.FilterType)(uint)(0));
    _objSignalProcessingSignalParametricEqualizer2.SetFrequency4(50f);
    _objSignalProcessingSignalParametricEqualizer2.SetQuality4(0.7076f);
    _objSignalProcessingSignalParametricEqualizer2.SetGain4(0f);
    _objSignalProcessingSignalParametricEqualizer2.SetGainAdjust(0f);
    _objSignalProcessingSignalParametricEqualizer2.SetNumChannels(2);
    _objSignalProcessingSignalParametricEqualizer2.SetNumOutputs(1);
    _objSignalProcessingSignalFeedback1.SetNumOutputs(1);
    _objSignalProcessingSignalFeedback1.SetSrcNode(_objSignalProcessingSignalDelay6);
    _objSignalProcessingSignalFeedback1.SetNumChannels(2);
    _objSignalProcessingSignalDelay6.SetSrcNode(_objSignalProcessingSignalParametricEqualizer5);
    _objSignalProcessingSignalDelay6.SetDelayTimeMs(250f);
    _objSignalProcessingSignalDelay6.SetNumChannels(2);
    _objSignalProcessingSignalDelay6.SetNumOutputs(1);
    _objSignalProcessingSignalMathOp4.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(0));
    _objSignalProcessingSignalMathOp4.SetOperandANode(_objSignalProcessingSignalMathOp3);
    _objSignalProcessingSignalMathOp4.SetOperandBNode(_objSignalProcessingSignalParametricEqualizer2);
    _objSignalProcessingSignalMathOp4.SetNumChannels(2);
    _objSignalProcessingSignalMathOp4.SetNumOutputs(2);
    _objSignalProcessingSignalMathOp3.SetOperation((SignalProcessingDataStore.MathOperation)(uint)(1));
    _objSignalProcessingSignalMathOp3.SetOperandANode(_objSignalProcessingSignalFeedback1);
    _objSignalProcessingSignalMathOp3.SetOperandB(0.25f);
    _objSignalProcessingSignalMathOp3.SetNumChannels(0);
    _objSignalProcessingSignalMathOp3.SetNumOutputs(1);
    _objSignalProcessingSignalOutputDevice7.SetSrcNode(_objSignalProcessingSignalMathOp4);
    _objSignalProcessingSignalOutputDevice7.SetDeviceNameFilter("Headphones");
    _objSignalProcessingSignalOutputDevice7.SetChannelOffset(0);
  }

  void DestroyObjects() {
    if (_objSignalProcessingSignalOutputDevice7 != null) {
      _datastoreSignalProcessing.SignalOutputDeviceOut.RemoveObject(_objSignalProcessingSignalOutputDevice7.GetXrpaId());
      _objSignalProcessingSignalOutputDevice7 = null;
    }
    if (_objSignalProcessingSignalMathOp3 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp3.GetXrpaId());
      _objSignalProcessingSignalMathOp3 = null;
    }
    if (_objSignalProcessingSignalMathOp4 != null) {
      _datastoreSignalProcessing.SignalMathOpOut.RemoveObject(_objSignalProcessingSignalMathOp4.GetXrpaId());
      _objSignalProcessingSignalMathOp4 = null;
    }
    if (_objSignalProcessingSignalDelay6 != null) {
      _datastoreSignalProcessing.SignalDelayOut.RemoveObject(_objSignalProcessingSignalDelay6.GetXrpaId());
      _objSignalProcessingSignalDelay6 = null;
    }
    if (_objSignalProcessingSignalFeedback1 != null) {
      _datastoreSignalProcessing.SignalFeedbackOut.RemoveObject(_objSignalProcessingSignalFeedback1.GetXrpaId());
      _objSignalProcessingSignalFeedback1 = null;
    }
    if (_objSignalProcessingSignalParametricEqualizer2 != null) {
      _datastoreSignalProcessing.SignalParametricEqualizerOut.RemoveObject(_objSignalProcessingSignalParametricEqualizer2.GetXrpaId());
      _objSignalProcessingSignalParametricEqualizer2 = null;
    }
    if (_objSignalProcessingSignalParametricEqualizer5 != null) {
      _datastoreSignalProcessing.SignalParametricEqualizerOut.RemoveObject(_objSignalProcessingSignalParametricEqualizer5.GetXrpaId());
      _objSignalProcessingSignalParametricEqualizer5 = null;
    }
    if (_objSignalProcessingSignalSourceFile0 != null) {
      _datastoreSignalProcessing.SignalSourceFileOut.RemoveObject(_objSignalProcessingSignalSourceFile0.GetXrpaId());
      _objSignalProcessingSignalSourceFile0 = null;
    }
  }

  public void Terminate() {
    DestroyObjects();
  }
}

} // namespace XrpaDataflow
