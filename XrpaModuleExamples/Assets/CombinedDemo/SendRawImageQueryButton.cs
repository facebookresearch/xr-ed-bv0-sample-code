/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SendRawImageQueryButton : MonoBehaviour
{
    public TMP_InputField inputField;
    public RawImage rawImageInputElement;
    public LlamaLargeQueryTest targetOfMessage;

    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        if (inputField == null)
        {
            Debug.LogError("Input field reference is missing!");
            return;
        }

        if (targetOfMessage == null)
        {
            Debug.LogError("TargetOfMessage is missing!");
            return;
        }

        // Get the texture from RawImage and convert to readable Texture2D
        Texture rawTexture = rawImageInputElement.texture;
        Texture2D texture2D = null;

        if (rawTexture != null)
        {
            // Always create a new readable Texture2D regardless of the source type
            // Create a temporary RenderTexture to read the texture data
            RenderTexture tempRT = RenderTexture.GetTemporary(rawTexture.width, rawTexture.height, 0, RenderTextureFormat.ARGB32);
            Graphics.Blit(rawTexture, tempRT);

            // Create a new readable Texture2D
            texture2D = new Texture2D(rawTexture.width, rawTexture.height, TextureFormat.RGB24, false);
            RenderTexture.active = tempRT;
            texture2D.ReadPixels(new Rect(0, 0, rawTexture.width, rawTexture.height), 0, 0);
            texture2D.Apply();

            // Clean up
            RenderTexture.active = null;
            RenderTexture.ReleaseTemporary(tempRT);
        }

        targetOfMessage.SetImage(texture2D);
        targetOfMessage.SendPrompt(inputField.text);
    }
}
