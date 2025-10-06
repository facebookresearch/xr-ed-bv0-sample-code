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

public class CopyRawImage : MonoBehaviour
{
    public RawImage source;
    private RawImage _target;

    void Start()
    {
        _target = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        _target.texture = source.texture;
    }
}
