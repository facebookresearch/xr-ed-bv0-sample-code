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
using UnityEngine.UI;

public class AudioSynthTest : MonoBehaviour, IXrpaDemo
{
    public Slider fqSlider;
    public Button startButton;

    private BasicWaveComponent _wave;
    private PulseComponent _pulse;
    private bool _isPlaying = false;
    void Start()
    {
        _wave = GetComponent<BasicWaveComponent>();
        _pulse = GetComponent<PulseComponent>();
        TogglePlaying();
    }

    public void TogglePlaying()
    {
        if (_isPlaying)
        {
            _isPlaying = false;
            _wave.Stop();
            startButton.GetComponentInChildren<TextMeshProUGUI>().SetText("Play");
            Debug.Log("Stopping signal at " + Time.time);
        }
        else
        {
            _isPlaying = true;
            _wave.Run();
            startButton.GetComponentInChildren<TextMeshProUGUI>().SetText("Stop");
            Debug.Log("Starting signal at " + Time.time);
        }
    }

    public void PlayPulse()
    {
        _pulse.Run();
    }

    void Update()
    {
        _wave.Fq = (fqSlider.value * 800f) + 20;
    }

    public void SetSliderValue(float value)
    {
        fqSlider.value = value;
    }

    public void StartDemo()
    {
        if (!_isPlaying)
        {
            TogglePlaying();
        }
    }

    public void StopDemo()
    {
        if (_isPlaying)
        {
            TogglePlaying();
        }
    }
}
