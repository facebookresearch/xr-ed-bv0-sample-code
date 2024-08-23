/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using SignalOutputDataStore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    void Start()
    {
        var device = GetComponent<SignalOutputDeviceComponent>();
        device.OnInputEvent += OnClick;
    }

    void OnClick(int timestamp, InputEventType type, int channelIdx)
    {
        if (type == InputEventType.Press)
        {
            var haptic = GetComponent<HapticClickComponent>();
            haptic.GainChannel0 = 1 - channelIdx;
            haptic.GainChannel1 = channelIdx;
            haptic.Spawn();
        }
    }
}
