/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class ConversationStatusListener : MonoBehaviour
{
    private TMP_Text statusText;

    private void Start()
    {
        // Get the TMP_Text component
        statusText = GetComponent<TMP_Text>();
        if (statusText == null)
        {
            Debug.LogError("ConversationStatusListener requires a TMP_Text component!");
            return;
        }

        // Clear the initial text
        statusText.text = "";

        // Find and subscribe to any HasDemoUI in the scene
        HasDemoUI[] demoConversation = FindObjectsOfType<HasDemoUI>();
        foreach (var test in demoConversation)
        {
            test.OnStatusMessage += UpdateStatusText;
        }
    }

    private void UpdateStatusText(string message)
    {
        // Update the text with the status message
        statusText.text = message;
    }

    private void OnDestroy()
    {
        // Unsubscribe from all conversation tests
        HasDemoUI[] demoConversation = FindObjectsOfType<HasDemoUI>();
        foreach (var test in demoConversation)
        {
            test.OnStatusMessage -= UpdateStatusText;
        }
    }
}
