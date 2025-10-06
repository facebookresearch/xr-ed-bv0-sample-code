/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using LlmHubDataStore;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LLMOCRTest : HasDemoUI, IXrpaDemo
{
    // Create your own key at https://llama.developer.meta.com/api-keys/
    public string apiKey = "your-api-key";
    public RawImage testImage;
    public string systemPrompt = "You are a helpful AI that transcribes text from images.";
    public TextMeshProUGUI statusText;

    private const string SCHEMA = "{\"type\":\"object\",\"properties\":{\"transcribed_text\":{\"type\":\"string\"},\"description\":{\"type\":\"string\"}},\"required\":[\"transcribed_text\",\"description\"],\"additionalProperties\":false}";

    private XrpaDataflow.LlamaLargeQuery _query;

    public void Start()
    {
        // You can use the same query object over and over, but it will not retain conversation history (use a Conversation for that).
        // You would want to create more than one XrpaDataflow query if you wanted to run multiple different prompts in parallel.
        _query = new XrpaDataflow.LlamaLargeQuery(LlmHubDataStoreSubsystem.Instance.DataStore);
        _query.SetApiKey(apiKey);
        _query.SetResultSchema(SCHEMA);
        _query.OnResponse(GotResponse);
    }

    public override void SendPrompt(string text)
    {
        SendStatusUpdate($"Sending query...");
        _query.SetSystemPrompt(systemPrompt);
        _query.SetImageData(TextureUtils.RawImageToTexture2D(testImage).EncodeToJPG());
        _query.SetChatMessage("Transcribe any text you see in this image");
        statusText.SetText("Llama is thinking...");
    }



    private void GotResponse(ulong timestamp, string msg, int i)
    {
        statusText.SetText(msg);
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
