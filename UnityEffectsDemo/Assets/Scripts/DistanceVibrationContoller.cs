/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceVibrationContoller : MonoBehaviour
{
    public GameObject objectA;
    public GameObject objectB;
    public float distanceMax = 1f;

    private SimpleWaveComponent _simpleWaveComponent;
    // Start is called before the first frame update
    void Start()
    {
        _simpleWaveComponent = GetComponent<SimpleWaveComponent>();
        _simpleWaveComponent.Run();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(objectA.transform.position, objectB.transform.position);
        Debug.Log("distance between objects is " + distance);
        float pct = Mathf.Clamp(distance / distanceMax, 0, 1);

        // will lower the freqency as the objects get closer, with a minimum of 50hz
        _simpleWaveComponent.Fq = 800f - (800f * pct);

        // will fade to quieter as the objects get farther apart.
        _simpleWaveComponent.Amp = 1f - pct;
    }
}
