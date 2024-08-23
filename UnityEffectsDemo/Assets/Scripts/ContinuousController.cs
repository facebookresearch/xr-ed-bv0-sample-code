/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ContinuousWaveComponent))]
public class ContinuousController : MonoBehaviour
{
    [Range(0f, 500f)]
    public float FundamentalFq;

    [Range(0f, 1f)]
    public float FundamentalAmp;

    [Range(0f, 15f)]
    public float LFOFq;

    [Range(0f, 1f)]
    public float LFOAmp;

    private ContinuousWaveComponent _fx;

    void Start()
    {
        _fx = GetComponent<ContinuousWaveComponent>();
    }

    private void OnValidate()
    {
        if (_fx == null) return;

        _fx.FundamentalAmp = FundamentalAmp;
        _fx.FundamentalFq = FundamentalFq;
        _fx.LFOAmp = LFOAmp;
        _fx.LFOFq = LFOFq;
    }
}
