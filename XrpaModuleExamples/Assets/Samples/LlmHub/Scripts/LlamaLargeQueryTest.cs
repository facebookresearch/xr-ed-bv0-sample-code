/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using LlmHubDataStore;
using UnityEngine;
using UnityEngine.UI;

public class LlamaLargeQueryTest : HasDemoUI, IXrpaDemo
{
    // Create your own key at https://llama.developer.meta.com/api-keys/
    public string apiKey = "your-api-key";
    public Texture2D testImage;
    public string systemPrompt;

    [Range(0, 1)]
    public float temperature = .6f;

    // This way of formatting a json schema is a pain, but it makes it easy to change the schema from a text input.
    public string resultSchema = "{\"type\":\"object\",\"properties\":{\"classification\":{\"type\":\"string\"},\"interestingFact\":{\"type\":\"string\"},\"description\":{\"type\":\"string\"}},\"required\":[\"classification\",\"interestingFact\",\"description\"],\"additionalProperties\":false}";

    private XrpaDataflow.LlamaLargeQuery _query;

    public void Start()
    {
        // You can use the same query object over and over, but it will not retain conversation history (use a Conversation for that).
        // You would want to create more than one XrpaDataflow query if you wanted to run multiple different prompts in parallel.
        _query = new XrpaDataflow.LlamaLargeQuery(LlmHubDataStoreSubsystem.Instance.DataStore);
        _query.SetApiKey(apiKey);
        _query.OnResponse(GotResponse);
    }

    public override void SendPrompt(string text)
    {
        SendStatusUpdate($"Sending query...");
        _query.SetSystemPrompt(systemPrompt);
        _query.SetTemperature(temperature);
        _query.SetImageData(testImage.EncodeToJPG());
        _query.SetResultSchema(resultSchema);
        _query.SetChatMessage(text);
        SendConversationUpdate("You", Color.white, text);
    }

    public void SetImage(Texture2D newImage)
    {
        testImage = newImage;
    }

    private void GotResponse(ulong timestamp, string msg, int i)
    {
        SendStatusUpdate($"Got response!");
        SendConversationUpdate("LLM", Color.cyan, msg);
    }

    public void StartDemo()
    {
        Debug.Log("Starting Llama Large Query Demo");
        SendStatusUpdate("Demo started - ready for queries with images");
    }

    public void StopDemo()
    {
        Debug.Log("Stopping Llama Large Query Demo");
        SendStatusUpdate("Demo stopped");
    }
}
