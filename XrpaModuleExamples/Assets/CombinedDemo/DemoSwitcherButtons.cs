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
using System;
using System.Linq;

public class DemoSwitcherButtons : MonoBehaviour
{
    [SerializeField] private GameObject buttonPrefab;
    private DemoSwitcher demoSwitcher;

    // Start is called before the first frame update
    void Start()
    {
        // Find the DemoSwitcher component
        demoSwitcher = FindObjectOfType<DemoSwitcher>();
        if (demoSwitcher == null)
        {
            Debug.LogError("DemoSwitcher not found in scene!");
            return;
        }

        CreateButtons();
    }

    private void CreateButtons()
    {
        // Get all enum values
        DemoSwitcher.DEMO[] demoOptions = (DemoSwitcher.DEMO[])Enum.GetValues(typeof(DemoSwitcher.DEMO));
        int totalButtons = demoOptions.Length;

        // Calculate the height percentage for each button
        float buttonHeightPercentage = 1.0f / totalButtons;

        for (int i = 0; i < totalButtons; i++)
        {
            DemoSwitcher.DEMO currentDemo = demoOptions[i];

            // Create button GameObject
            GameObject buttonObj = CreateButtonObject(currentDemo.ToString(), i, buttonHeightPercentage);

            // Get the Button component and set up the click event
            Button button = buttonObj.GetComponent<Button>();
            if (button != null)
            {
                // Capture the current demo value for the lambda
                DemoSwitcher.DEMO capturedDemo = currentDemo;
                button.onClick.AddListener(() => OnButtonClicked(capturedDemo));
            }
        }
    }

    private GameObject CreateButtonObject(string buttonText, int index, float heightPercentage)
    {
        // Create button GameObject
        GameObject buttonObj = new GameObject($"Button_{buttonText}");
        buttonObj.transform.SetParent(transform, false);

        // Add RectTransform
        RectTransform rectTransform = buttonObj.AddComponent<RectTransform>();

        // Set anchors to stretch horizontally and position vertically based on index
        rectTransform.anchorMin = new Vector2(0, 1 - (index + 1) * heightPercentage);
        rectTransform.anchorMax = new Vector2(1, 1 - index * heightPercentage);
        rectTransform.offsetMin = Vector2.zero;
        rectTransform.offsetMax = Vector2.zero;

        // Add Image component for button background
        Image image = buttonObj.AddComponent<Image>();
        image.color = Color.white;

        // Add Button component
        Button button = buttonObj.AddComponent<Button>();

        // Create text child object
        GameObject textObj = new GameObject("Text");
        textObj.transform.SetParent(buttonObj.transform, false);

        RectTransform textRect = textObj.AddComponent<RectTransform>();
        textRect.anchorMin = Vector2.zero;
        textRect.anchorMax = Vector2.one;
        textRect.offsetMin = Vector2.zero;
        textRect.offsetMax = Vector2.zero;

        // Add Text component
        Text text = textObj.AddComponent<Text>();
        text.text = FormatButtonText(buttonText);
        text.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        text.fontSize = 14;
        text.color = Color.black;
        text.alignment = TextAnchor.MiddleCenter;

        return buttonObj;
    }

    private string FormatButtonText(string enumName)
    {
        // Convert enum name to more readable format
        // e.g., "AUDIO_SYNTH" becomes "Audio Synth"
        return enumName.Replace("_", " ").ToLower()
            .Replace(" ", " ").Trim()
            .Split(' ')
            .Select(word => char.ToUpper(word[0]) + word.Substring(1))
            .Aggregate((a, b) => a + " " + b);
    }

    private void OnButtonClicked(DemoSwitcher.DEMO demo)
    {
        if (demoSwitcher != null)
        {
            demoSwitcher.SetDemo(demo);
        }
    }
}
