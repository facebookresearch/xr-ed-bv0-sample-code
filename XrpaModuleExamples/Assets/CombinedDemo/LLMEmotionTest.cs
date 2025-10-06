/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LLMEmotionTest : HasDemoUI, IXrpaDemo
{
    // Create your own key at https://llama.developer.meta.com/api-keys/
    public string apiKey = "your-api-key";
    public RawImage testImage;
    public string systemPrompt = "You are an empathetic AI. When asked to describe an emotion do so in one word.";
    public TextMeshProUGUI statusText;

    private const string SCHEMA = "{\"type\":\"object\",\"properties\":{\"emotion\":{\"type\":\"string\"},\"description\":{\"type\":\"string\"}},\"required\":[\"emotion\",\"description\"],\"additionalProperties\":false}";

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
        _query.SetChatMessage("Tell me how this person is feeling");
        statusText.SetText("Llama is thinking...");
    }



    private void GotResponse(ulong timestamp, string msg, int i)
    {
        statusText.SetText(msg);
    }

    public void StartDemo()
    {
    }

    public void StopDemo()
    {
    }
}
