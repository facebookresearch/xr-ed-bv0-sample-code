/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using LlmHubDataStore;
using UnityEngine;
using System;

// This test creates a converation between two LLMs
public class LlamaConversationTest : HasDemoUI, IXrpaDemo
{
    // Create your own key at https://llama.developer.meta.com/api-keys/
    public string apiKey = "your-api-key";
    public string agent1SystemPrompt = "You are inquisitive. Always respond with a question.";
    public string agent2SystemPrompt = "You like to show off your knowledge of science and math.";

    // The agents will talk to each other, but this is the initial push that gets the conversation going.
    public string lastThingSaid = "What are you interested in?";

    // These XrpaDataflow interfaces are automatically generated from the typescript in the js directory
    private XrpaDataflow.LlamaConversation _agent1;
    private XrpaDataflow.LlamaConversation _agent2;

    // Manage the conversation turn taking
    private int _msgId = 0;
    private int _stepsToGo = 0;
    private XrpaDataflow.LlamaConversation _sendToNext;


    // Advance the conversation between the two LLMs a set number of steps.
    public void AdvanceConversation(int nSteps)
    {
        _stepsToGo = nSteps;

        // Send status message about advancing conversation
        SendStatusUpdate($"advancing conversation {nSteps} steps");

        if (_agent1 == null)
        {
            _agent1 = new XrpaDataflow.LlamaConversation(LlmHubDataStoreSubsystem.Instance.DataStore);
            _agent1.SetApiKey(apiKey);
            _agent1.SetSystemPrompt(agent1SystemPrompt);
            _agent1.OnResponse(GotResponseFromAgent1);
        }
        if (_agent2 == null)
        {
            _agent2 = new XrpaDataflow.LlamaConversation(LlmHubDataStoreSubsystem.Instance.DataStore);
            _agent2.SetApiKey(apiKey);
            _agent2.SetSystemPrompt(agent2SystemPrompt);
            _agent2.OnResponse(GotResponseFromAgent2);
        }
        if (_sendToNext == null)
            _sendToNext = _agent2;
        _sendToNext.SendChatMessage(lastThingSaid, null, _msgId++);
    }

    private void GotResponseFromAgent1(ulong id, string msg, int i)
    {
        _sendToNext = _agent2;
        lastThingSaid = msg;
        SendConversationUpdate("Agent 1", Color.yellow, lastThingSaid);

        // send that response to agent 2
        if (_stepsToGo > 1)
        {
            _agent1.SetSystemPrompt(agent1SystemPrompt);
            _agent2.SetSystemPrompt(agent2SystemPrompt);
            _sendToNext.SendChatMessage(lastThingSaid, null, _msgId++);
        }

        _stepsToGo--;
        SendStatusUpdate($"{_stepsToGo} steps remaining");
    }

    private void GotResponseFromAgent2(ulong id, string msg, int i)
    {
        _sendToNext = _agent1;
        lastThingSaid = msg;
        SendConversationUpdate("Agent 2", Color.cyan, lastThingSaid);

        // send that response to agent 1
        if (_stepsToGo > 1)
        {
            _agent1.SetSystemPrompt(agent1SystemPrompt);
            _agent2.SetSystemPrompt(agent2SystemPrompt);
            _sendToNext.SendChatMessage(lastThingSaid, null, _msgId++);
        }

        _stepsToGo--;
        SendStatusUpdate($"{_stepsToGo} steps remaining");
    }

    public void StartDemo()
    {
        Debug.Log("Starting Llama Conversation Demo");
        SendStatusUpdate("Demo started - ready for conversation");
        AdvanceConversation(3);
    }

    public void StopDemo()
    {
        Debug.Log("Stopping Llama Conversation Demo");
        SendStatusUpdate("Demo stopped");
        _stepsToGo = 0;
        if (_agent1 != null)
        {
            _agent1 = null;
        }
        if (_agent2 != null)
        {
            _agent2 = null;
        }
    }
}
