/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using LlmHubDataStore;
using UnityEngine;

public class LocalLLMTest : HasDemoUI, IXrpaDemo
{
    private XrpaDataflow.LocalLLMQuery _query;
    public string systemPrompt = "You are a character in an Oscar Wilde play.";

    public override void SendPrompt(string text)
    {
        SendStatusUpdate($"Sending query...");

        // Clean up if we are calling this multiple times
        if (_query == null)
        {
            _query = new XrpaDataflow.LocalLLMQuery(LlmHubDataStoreSubsystem.Instance.DataStore);
            _query.SetApiKey("not-needed-for-a-local-model");
            _query.OnResponse(GotResponse);
        }

        _query.SetSystemPrompt(systemPrompt);

        // The query is triggered when this is set
        _query.SetChatMessage(text);
        SendConversationUpdate("You", Color.white, text);
    }

    private void GotResponse(ulong timestamp, string msg, int i)
    {
        SendStatusUpdate($"Got response!");
        SendConversationUpdate("LLM", Color.cyan, msg);
    }

    public void StartDemo()
    {
        Debug.Log("Starting Local LLM Demo");
        SendStatusUpdate("Demo started - ready for local queries");
    }

    public void StopDemo()
    {
        Debug.Log("Stopping Local LLM Demo");
        SendStatusUpdate("Demo stopped");
        if (_query != null)
        {
            _query = null;
        }
    }
}
