/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoSwitcher : MonoBehaviour
{
    // Dictionary to map enum values to GameObjects
    private Dictionary<DEMO, GameObject> demoPanels;

    public enum DEMO
    {
        WEBCAM,
        AUDIO_SYNTH,
        HDK_1,
        LLM,
        VISUAL_EMOTION,
        OCR
    }

    public void SetDemo(DEMO demo)
    {
        // Stop demos and deactivate all demo panels
        foreach (var panel in demoPanels.Values)
        {
            if (panel != null && panel.activeInHierarchy)
            {
                // Find and stop IXrpaDemo components before deactivating
                IXrpaDemo[] demos = panel.GetComponentsInChildren<IXrpaDemo>(true);
                foreach (var demoComponent in demos)
                {
                    demoComponent.StopDemo();
                }

                panel.SetActive(false);
            }
        }

        // Activate the requested demo panel and start its demo
        if (demoPanels.ContainsKey(demo) && demoPanels[demo] != null)
        {
            demoPanels[demo].SetActive(true);

            // Find and start IXrpaDemo components after activating
            IXrpaDemo[] demos = demoPanels[demo].GetComponentsInChildren<IXrpaDemo>(true);
            foreach (var demoComponent in demos)
            {
                demoComponent.StartDemo();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the dictionary
        demoPanels = new Dictionary<DEMO, GameObject>();

        // Find child objects by name and build the map
        demoPanels[DEMO.AUDIO_SYNTH] = FindChildByName("audioSynthPanel");
        demoPanels[DEMO.VISUAL_EMOTION] = FindChildByName("visualEmotionPanel");
        demoPanels[DEMO.WEBCAM] = FindChildByName("webcamPanel");
        demoPanels[DEMO.HDK_1] = FindChildByName("hdk1Panel");
        demoPanels[DEMO.LLM] = FindChildByName("llmPanel");
        demoPanels[DEMO.OCR] = FindChildByName("ocrPanel");

        SetDemo(DEMO.WEBCAM);
    }

    // Helper method to find a child GameObject by name
    private GameObject FindChildByName(string name)
    {
        Transform[] children = GetComponentsInChildren<Transform>(true);
        foreach (Transform child in children)
        {
            if (child.name == name && child.gameObject != this.gameObject)
            {
                return child.gameObject;
            }
        }
        return null;
    }
}
