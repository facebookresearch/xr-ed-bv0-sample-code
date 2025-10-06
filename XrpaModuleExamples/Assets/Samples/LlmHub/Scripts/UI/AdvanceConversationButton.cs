/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Button))]
public class AdvanceConversationButton : MonoBehaviour
{
    public TMP_InputField inputField;
    public LlamaConversationTest conversationTest;

    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        if (inputField == null)
        {
            Debug.LogError("Input field reference is missing!");
            return;
        }

        if (conversationTest == null)
        {
            Debug.LogError("LlamaConversationTest reference is missing!");
            return;
        }

        if (int.TryParse(inputField.text, out int steps))
        {
            conversationTest.AdvanceConversation(steps);
        }
        else
        {
            Debug.LogError("Invalid input! Please enter a valid integer.");
        }
    }
}
