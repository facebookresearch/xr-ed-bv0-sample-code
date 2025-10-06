/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestAudioTranscription : MonoBehaviour, IXrpaDemo
{
    public TextMeshProUGUI transcribedText;
    private TranscribeAudioFromMicComponent _audioTranscriber;
    void Start()
    {
        _audioTranscriber = GetComponent<TranscribeAudioFromMicComponent>();
        _audioTranscriber.OnTranscriptionResult += OnTranscriptionResult;
        _audioTranscriber.Run();
        Debug.Log("starting transcription");
        transcribedText.SetText("...waiting for transcription...");
    }

    private void OnTranscriptionResult(ulong msgTimestamp, string text, ulong audioTimestamp, bool success, string errorMessage)
    {
        if (!success)
        {
            Debug.Log("unsuccessful transcription " + errorMessage);
            return;
        }
        Debug.Log(text);
        transcribedText.SetText(text);
    }

    public void StartDemo()
    {
        if (_audioTranscriber != null)
        {
            //_audioTranscriber.Run();
            Debug.Log("starting transcription");
            transcribedText.SetText("...waiting for transcription...");
        }
    }

    public void StopDemo()
    {
        if (_audioTranscriber != null)
        {
            //_audioTranscriber.Stop();
            Debug.Log("stopping transcription");
            transcribedText.SetText("Transcription stopped");
        }
    }
}
