/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTSTest : MonoBehaviour, IXrpaDemo
{
    public TMPro.TMP_InputField input;

    private SpeakTextComponent _stc;
    private int _requestId = 0;

    void Start()
    {
        _stc = FindAnyObjectByType<SpeakTextComponent>();
        if (_stc == null)
        {
            _stc = gameObject.AddComponent<SpeakTextComponent>();
        }

        _stc.OnTtsResponse += OnTtsResponse;
        _stc.SendTextRequest("initializing", _requestId);
        _requestId++;
    }

    public void SendTextToSpeak()
    {
        Debug.Log("send request to speak \"" + input.text + "\" with ID " + _requestId);
        _stc.SendTextRequest(input.text, _requestId);
        _requestId++;
    }

    private void OnTtsResponse(ulong arg1, int arg2, bool arg3, string arg4, ulong arg5)
    {
        Debug.Log("got audio " + arg1 + " " + arg2 + " " + arg3 + " " + arg4 + " " + arg5);
    }

    public void StartDemo()
    {
        Debug.Log("Starting TTS Demo");
        _stc.SendTextRequest("starting speech demo", _requestId);
        /*if (_stc != null)
        {
            _stc.Run();
        }*/
    }

    public void StopDemo()
    {
        Debug.Log("Stopping TTS Demo");
        /*if (_stc != null)
        {
            _stc.Stop();
        }*/
    }
}
