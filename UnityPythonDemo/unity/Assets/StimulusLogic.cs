/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StimulusLogic : MonoBehaviour
{
    void Start()
    {
        var stimulus = GetComponent<StimulusComponent>();
        if (stimulus != null)
        {
            Debug.Log("VisualDelay: " + stimulus.VisualDelay + ", AudioDelay: " + stimulus.AudioDelay);
            StartCoroutine(DelayedVisual(stimulus.VisualDelay));
            StartCoroutine(DelayedAudio(stimulus.AudioDelay));
        }
    }

    IEnumerator DelayedVisual(float delay)
    {
        yield return new WaitForSeconds(delay);
        var renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.enabled = true;
        }
    }

    IEnumerator DelayedAudio(float delay)
    {
        yield return new WaitForSeconds(delay);
        var audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("Sending user response");
            GetComponent<StimulusComponent>()?.SendUserResponse();
        }
    }
}
