/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using UnityEngine;
using UnityEngine.UI;
using LlmHubDataStore;

public class LlamaMCPTest : HasDemoUI, IXrpaDemo
{
    // Create your own key at https://llama.developer.meta.com/api-keys/
    public string apiKey = "your-api-key";
    public string systemPrompt;

    private XrpaDataflow.LlamaMCP _conversation;
    private int _msgId = 0;

    public override void SendPrompt(string text)
    {
        SendStatusUpdate($"Sending query...");

        if (_conversation == null)
        {
            _conversation = new XrpaDataflow.LlamaMCP(LlmHubDataStoreSubsystem.Instance.DataStore);
            _conversation.SetApiKey(apiKey);
            _conversation.OnResponse(GotResponse);
        }

        _conversation.SetSystemPrompt(systemPrompt);
        _conversation.SendChatMessage(text, null, _msgId++);
        SendConversationUpdate("You", Color.white, text);
    }

    private void GotResponse(ulong id, string msg, int i)
    {
        SendStatusUpdate($"Got response!");
        SendConversationUpdate("LLM", Color.cyan, msg);
    }

    public void StartDemo()
    {
        Debug.Log("Starting Llama MCP Demo");
        SendStatusUpdate("Demo started - ready for MCP queries");
    }

    public void StopDemo()
    {
        Debug.Log("Stopping Llama MCP Demo");
        SendStatusUpdate("Demo stopped");
        if (_conversation != null)
        {
            _conversation = null;
        }
    }
}
