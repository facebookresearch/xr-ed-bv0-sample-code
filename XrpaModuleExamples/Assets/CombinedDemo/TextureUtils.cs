/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using UnityEngine;
using UnityEngine.UI;

public static class TextureUtils
{
    /// <summary>
    /// Converts a RawImage to a Texture2D by copying its texture content
    /// </summary>
    /// <param name="rawImage">The RawImage to capture</param>
    /// <returns>A new Texture2D containing the RawImage's texture data</returns>
    public static Texture2D RawImageToTexture2D(RawImage rawImage)
    {
        // Get the texture from the RawImage
        Texture sourceTexture = rawImage.texture;

        if (sourceTexture == null)
        {
            Debug.LogError("RawImage does not have a texture assigned!");
            return null;
        }

        // Create a temporary RenderTexture to copy the source texture
        RenderTexture tempRT = RenderTexture.GetTemporary(sourceTexture.width, sourceTexture.height, 0, RenderTextureFormat.ARGB32);

        // Copy the source texture to the temporary RenderTexture
        Graphics.Blit(sourceTexture, tempRT);

        // Set the temporary RenderTexture as active and read pixels
        RenderTexture previousActive = RenderTexture.active;
        RenderTexture.active = tempRT;

        Texture2D capturedTexture = new Texture2D(tempRT.width, tempRT.height, TextureFormat.RGB24, false);
        capturedTexture.ReadPixels(new Rect(0, 0, tempRT.width, tempRT.height), 0, 0);
        capturedTexture.Apply();

        // Restore previous active RenderTexture and release temporary one
        RenderTexture.active = previousActive;
        RenderTexture.ReleaseTemporary(tempRT);

        return capturedTexture;
    }
}
