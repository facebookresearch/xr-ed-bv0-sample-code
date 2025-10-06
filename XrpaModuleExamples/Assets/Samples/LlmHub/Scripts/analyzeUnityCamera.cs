/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using LlmHubDataStore;
using UnityEngine;

public class analyzeUnityCamera : HasDemoUI
{
    // Create your own key at https://llama.developer.meta.com/api-keys/
    public string apiKey = "your-api-key";
    public string systemPrompt;
    public Camera cameraToAnalyze;

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

        // Capture the current frame from the camera and convert it to a Texture2D
        Texture2D capturedFrame = CaptureCamera();
        if (capturedFrame != null)
        {
            _query.SetImageData(capturedFrame.EncodeToJPG());
            _query.SetChatMessage(text);
            SendConversationUpdate("You", Color.white, text);

            // Clean up the temporary texture
            DestroyImmediate(capturedFrame);
        }
        else
        {
            SendStatusUpdate("Error: Could not capture camera frame. Make sure camera has a render texture assigned.");
        }
    }

    private Texture2D CaptureCamera()
    {
        // Use the camera's existing render texture
        RenderTexture cameraRT = cameraToAnalyze.targetTexture;

        if (cameraRT == null)
        {
            Debug.LogError("Camera does not have a render texture assigned!");
            return null;
        }

        // Read the pixels from the camera's RenderTexture into a Texture2D
        RenderTexture.active = cameraRT;
        Texture2D capturedTexture = new Texture2D(cameraRT.width, cameraRT.height, TextureFormat.RGB24, false);
        capturedTexture.ReadPixels(new Rect(0, 0, cameraRT.width, cameraRT.height), 0, 0);
        capturedTexture.Apply();
        RenderTexture.active = null;

        return capturedTexture;
    }

    private void GotResponse(ulong timestamp, string msg, int i)
    {
        SendStatusUpdate($"Got response!");
        SendConversationUpdate("LLM", Color.cyan, msg);
    }
}
