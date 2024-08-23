/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// This class just provides a convenient way to push
// values into the LoopingPatternComponent with sliders.
[RequireComponent(typeof(LoopingPatternComponent))]
public class LoopingPatternController : MonoBehaviour
{
    [Range(0f, 1f)]
    public float Gain0;

    [Range(0f, 1f)]
    public float Gain1;

    [Range(0f, 500f)]
    public float FundamentalFq;

    [Range(0f, 1f)]
    public float FundamentalAmp;

    [Range(0f, 15f)]
    public float LFOFq;

    [Range(0f, 1f)]
    public float LFOAmp;

    [Range(.1f, 2f)]
    public float PulseDuration;

    [Range(.1f, 2f)]
    public float PauseDuration;

    private LoopingPatternComponent _fx;

    // Start is called before the first frame update
    void Start()
    {
        _fx = GetComponent<LoopingPatternComponent>();
    }

    private void OnValidate()
    {
        if (_fx == null) return;
        _fx.Gain0 = Gain0;
        _fx.Gain1 = Gain1;
        _fx.FundamentalFq = FundamentalFq;
        _fx.FundamentalAmp = FundamentalAmp;
        _fx.LFOFq = LFOFq;
        _fx.LFOAmp = LFOAmp;
        _fx.PulseDuration = PulseDuration;
        _fx.PauseDuration = PauseDuration;
    }
}
