/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using LlmHubDataStore;
using UnityEngine;

public class LlamaSmallQueryTest : HasDemoUI, IXrpaDemo
{
    //https://llama.developer.meta.com/api-keys/?team_id=1751528729064939
    public string apiKey = "your-api-key";
    public string systemPrompt = "You are a robot. Make robot noises when you talk.";
    private XrpaDataflow.LlamaSmallQuery _query;

    public override void SendPrompt(string text)
    {
        SendStatusUpdate($"Sending query...");

        if (_query == null)
        {
            _query = new XrpaDataflow.LlamaSmallQuery(LlmHubDataStoreSubsystem.Instance.DataStore);
            _query.SetApiKey(apiKey);
            _query.OnResponse(GotResponse);
        }

        _query.SetSystemPrompt(systemPrompt);

        // Setting the chat message sends the prompt
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
        Debug.Log("Starting Llama Small Query Demo");
        SendStatusUpdate("Demo started - ready for queries");
    }

    public void StopDemo()
    {
        Debug.Log("Stopping Llama Small Query Demo");
        SendStatusUpdate("Demo stopped");
        if (_query != null)
        {
            _query = null;
        }
    }
}
