/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Assign this to a scroll rect. Set the scrollRect and the Content panel.
// The layout will be automatically generated. 
public class ConversationListener : MonoBehaviour
{
    [Tooltip("The scroll rect that will contain the conversation messages")]
    public ScrollRect scrollRect;

    [Tooltip("The content transform where message elements will be added")]
    public RectTransform contentPanel;
    public int fontSize = 18;
    public int maxMessages = 100;

    private List<GameObject> _messageObjects = new List<GameObject>();

    private void Start()
    {
        if (scrollRect == null)
        {
            scrollRect = GetComponentInParent<ScrollRect>();
            if (scrollRect == null)
            {
                Debug.LogError("ConversationListener requires a ScrollRect component!");
            }
        }
        if (contentPanel == null && scrollRect != null)
        {
            contentPanel = scrollRect.content;
        }
        if (contentPanel == null)
        {
            Debug.LogError("ConversationListener requires a content panel reference!");
        }

        // You could also set up the layout elements manually in the editor, but it's easier to do it all in script.
        CreateLayout();

        // This works best if there's only one HasDemoUI per scene
        HasDemoUI[] queryTests = FindObjectsOfType<HasDemoUI>();
        foreach (var test in queryTests)
        {
            test.OnConversationUpdated += AddMessage;
        }
    }

    private void CreateLayout()
    {
        VerticalLayoutGroup layoutGroup = contentPanel.GetComponent<VerticalLayoutGroup>();
        if (layoutGroup == null)
        {
            layoutGroup = contentPanel.gameObject.AddComponent<VerticalLayoutGroup>();
            layoutGroup.childAlignment = TextAnchor.UpperLeft;
            layoutGroup.childControlHeight = true;
            layoutGroup.childControlWidth = true;
            layoutGroup.childForceExpandHeight = false;
            layoutGroup.childForceExpandWidth = true;
            layoutGroup.spacing = 0;
            layoutGroup.padding = new RectOffset(0, 0, 0, 0);
        }

        ContentSizeFitter sizeFitter = contentPanel.GetComponent<ContentSizeFitter>();
        if (sizeFitter == null)
        {
            sizeFitter = contentPanel.gameObject.AddComponent<ContentSizeFitter>();
            sizeFitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
            sizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        }

        RectTransform scrollRectTransform = scrollRect.GetComponent<RectTransform>();
        if (scrollRectTransform != null)
        {
            contentPanel.sizeDelta = new Vector2(0, contentPanel.sizeDelta.y);
        }
    }

    public void AddMessage(string sender, Color color, string text)
    {
        if (contentPanel == null)
        {
            Debug.LogError("ConversationListener is missing content panel reference!");
            return;
        }

        // Create a new GameObject for the message
        GameObject messageObj = new GameObject("Message");
        messageObj.transform.SetParent(contentPanel, false);

        // Add a RectTransform component
        RectTransform rectTransform = messageObj.AddComponent<RectTransform>();
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(1, 0);
        rectTransform.pivot = new Vector2(0.5f, 0);
        rectTransform.sizeDelta = new Vector2(0, fontSize * 1.5f);
        rectTransform.offsetMin = new Vector2(0, rectTransform.offsetMin.y);
        rectTransform.offsetMax = new Vector2(0, rectTransform.offsetMax.y);

        // Add a horizontal layout group to the message object
        HorizontalLayoutGroup horizontalLayout = messageObj.AddComponent<HorizontalLayoutGroup>();
        horizontalLayout.childAlignment = TextAnchor.MiddleLeft;
        horizontalLayout.childControlWidth = true;
        horizontalLayout.childControlHeight = true;
        horizontalLayout.childForceExpandWidth = true;
        horizontalLayout.childForceExpandHeight = false;
        horizontalLayout.padding = new RectOffset(5, 5, 5, 5);

        // Create a child GameObject for the text
        GameObject textObj = new GameObject("Message");
        textObj.transform.SetParent(messageObj.transform, false);

        // Add a TextMeshProUGUI component to the child
        TMP_Text textComponent = textObj.AddComponent<TextMeshProUGUI>();
        textComponent.fontSize = fontSize;
        textComponent.text = $"{sender}: {text}";
        textComponent.color = color;
        textComponent.alignment = TextAlignmentOptions.Left;
        textComponent.enableWordWrapping = true;
        textComponent.overflowMode = TextOverflowModes.Overflow;

        // Add a layout element to the text object
        LayoutElement textLayoutElement = textObj.AddComponent<LayoutElement>();
        textLayoutElement.flexibleWidth = 1;

        // Add a content size fitter to the message object
        ContentSizeFitter messageSizeFitter = messageObj.AddComponent<ContentSizeFitter>();
        messageSizeFitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
        messageSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

        // Add to our list of messages
        _messageObjects.Add(messageObj);

        // Trim old messages if we exceed the maximum
        if (_messageObjects.Count > maxMessages)
        {
            Destroy(_messageObjects[0]);
            _messageObjects.RemoveAt(0);
        }

        // Scroll to the bottom to show the new message
        Canvas.ForceUpdateCanvases();
        UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(contentPanel);
        scrollRect.normalizedPosition = new Vector2(0, 0);
    }

    private void OnDestroy()
    {
        // Unsubscribe from all conversation tests
        HasDemoUI[] queryTests = FindObjectsOfType<HasDemoUI>();
        foreach (var test in queryTests)
        {
            test.OnConversationUpdated -= AddMessage;
        }
    }
}
