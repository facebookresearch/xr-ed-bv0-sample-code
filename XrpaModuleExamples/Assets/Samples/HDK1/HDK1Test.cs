/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HDK1Test : MonoBehaviour, IXrpaDemo
{
    public Button startButton;
    public Slider vt0Gain;
    public Slider vt1Gain;
    public Slider vt2Gain;
    public Slider vt3Gain;
    public Slider vt4Gain;

    private GainWaveComponent _hdk1Wave;
    private bool _isPlaying = false;
    void Start()
    {
        _hdk1Wave = GetComponent<GainWaveComponent>();
        TogglePlaying();
    }

    public void FixedUpdate()
    {
        _hdk1Wave.Gain0 = vt0Gain.value;
        _hdk1Wave.Gain1 = vt1Gain.value;
        _hdk1Wave.Gain2 = vt2Gain.value;
        _hdk1Wave.Gain3 = vt3Gain.value;
        _hdk1Wave.Gain4 = vt4Gain.value;
    }

    public void TogglePlaying()
    {
        if (_isPlaying)
        {
            StopPlaying();
        }
        else
        {
            StartPlaying();
        }
    }

    private void StartPlaying()
    {
        _isPlaying = true;
        _hdk1Wave.Run();
        startButton.GetComponentInChildren<TextMeshProUGUI>().SetText("Stop");
        Debug.Log("Starting signal at " + Time.time);
    }

    private void StopPlaying()
    {
        _isPlaying = false;
        _hdk1Wave.Stop();
        startButton.GetComponentInChildren<TextMeshProUGUI>().SetText("Play");
        Debug.Log("Stopping signal at " + Time.time);
    }


    public void StartDemo()
    {
        if (!_isPlaying)
        {
            StartPlaying();
        }
    }

    public void StopDemo()
    {
        if (_isPlaying)
        {
            StopPlaying();
        }
    }
}
