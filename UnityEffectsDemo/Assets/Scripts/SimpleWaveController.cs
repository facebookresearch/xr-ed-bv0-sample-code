/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SimpleWaveComponent))]
public class SimpleWaveController : MonoBehaviour
{

    [Range(0f, 1f)]
    public float Amp;

    [Range(0f, 500f)]
    public float Fq;

    private SimpleWaveComponent _fx;

    // Start is called before the first frame update
    void Start()
    {
        _fx = GetComponent<SimpleWaveComponent>();
    }

    private void OnValidate()
    {
        if (_fx == null) return;
        _fx.Amp = Amp;
        _fx.Fq = Fq;
    }
}
