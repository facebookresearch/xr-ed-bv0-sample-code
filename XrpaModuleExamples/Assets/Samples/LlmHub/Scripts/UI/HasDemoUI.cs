/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using System;
using UnityEngine;

// Base class that lets all the demos use the same UI components.
public class HasDemoUI : MonoBehaviour
{
    // Update the UI objects that make it easy to see what's going on
    public event Action<string, Color, string> OnConversationUpdated;
    public event Action<string> OnStatusMessage;

    protected void SendStatusUpdate(string statusUpdate)
    {
        OnStatusMessage?.Invoke(statusUpdate);
    }

    protected void SendConversationUpdate(string sender, Color color, string lastThingSaid)
    {
        OnConversationUpdated?.Invoke(sender, color, lastThingSaid);
    }

    public virtual void SendPrompt(string text) { }
}
