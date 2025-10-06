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
public class SendMessageButton : MonoBehaviour
{
    public TMP_InputField inputField;
    public HasDemoUI targetOfMessage;

    private Button button;

    // Start is called before the first frame update
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

        if (targetOfMessage == null)
        {
            Debug.LogError("TargetOfMessage is missing!");
            return;
        }
        targetOfMessage.SendPrompt(inputField.text);
    }
}

