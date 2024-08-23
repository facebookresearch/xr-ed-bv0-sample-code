/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(BG_AComponent), typeof(BG_BComponent), typeof(BG_CComponent))]
[RequireComponent(typeof(Pulse_AComponent), typeof(Pulse_BComponent), typeof(Pulse_CComponent))]
public class PatternController : MonoBehaviour
{
    private BG_AComponent _bgA;
    private BG_BComponent _bgB;
    private BG_CComponent _bgC;
    private Pulse_AComponent _pulseA;
    private Pulse_BComponent _pulseB;
    private Pulse_CComponent _pulseC;

    // Start is called before the first frame update
    void Start()
    {
        _bgA = GetComponent<BG_AComponent>();
        _bgB = GetComponent<BG_BComponent>();
        _bgC = GetComponent<BG_CComponent>();
        _pulseA = GetComponent<Pulse_AComponent>();
        _pulseB = GetComponent<Pulse_BComponent>();
        _pulseC = GetComponent<Pulse_CComponent>();
    }

    public void DoPulse(string pulsePattern)
    {
        switch (pulsePattern)
        {
            case "A":
                _pulseA.Run();
                break;
            case "B":
                _pulseB.Run();
                break;
            case "C":
                _pulseC.Run();
                break;
        }
    }

    public void UpdateGain0Value(float value)
    {
        _bgA.Gain0 = value;
        _bgB.Gain0 = value;
        _bgC.Gain0 = value;
        _pulseA.Gain0 = value;
        _pulseB.Gain0 = value;
        _pulseC.Gain0 = value;
    }
    public void UpdateGain1Value(float value)
    {
        _bgA.Gain1 = value;
        _bgB.Gain1 = value;
        _bgC.Gain1 = value;
        _pulseA.Gain1 = value;
        _pulseB.Gain1 = value;
        _pulseC.Gain1 = value;
    }

    public void UpdateGain2Value(float value)
    {
        _bgA.Gain2 = value;
        _bgB.Gain2 = value;
        _bgC.Gain2 = value;
        _pulseA.Gain2 = value;
        _pulseB.Gain2 = value;
        _pulseC.Gain2 = value;
    }

    public void UpdateGain3Value(float value)
    {
        _bgA.Gain3 = value;
        _bgB.Gain3 = value;
        _bgC.Gain3 = value;
        _pulseA.Gain3 = value;
        _pulseB.Gain3 = value;
        _pulseC.Gain3 = value;
    }

    public void UpdateGain4Value(float value)
    {
        _bgA.Gain4 = value;
        _bgB.Gain4 = value;
        _bgC.Gain4 = value;
        _pulseA.Gain4 = value;
        _pulseB.Gain4 = value;
        _pulseC.Gain4 = value;
    }

    public void SetBackground(string bgPattern)
    {
        switch (bgPattern)
        {
            case "A":
                _bgA.Run();
                _bgB.Stop();
                _bgC.Stop();
                break;
            case "B":
                _bgA.Stop();
                _bgB.Run();
                _bgC.Stop();
                break;
            case "C":
                _bgA.Stop();
                _bgB.Stop();
                _bgC.Run();
                break;
            default:
                _bgA.Stop();
                _bgB.Stop();
                _bgC.Stop();
                break;
        }
    }
}
