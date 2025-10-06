/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AudioFromImage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerMoveHandler
{
    private Image imageComponent;
    private RectTransform rectTransform;
    private AudioSynthTest audioSynthTest;
    private bool isMouseOver = false;

    void Start()
    {
        // Get required components
        imageComponent = GetComponent<Image>();
        rectTransform = GetComponent<RectTransform>();
        audioSynthTest = FindObjectOfType<AudioSynthTest>();

        if (imageComponent == null)
        {
            Debug.LogError("AudioFromImage: No Image component found on this GameObject!");
            enabled = false;
            return;
        }

        if (audioSynthTest == null)
        {
            Debug.LogError("AudioFromImage: No AudioSynthTest component found in the scene!");
            enabled = false;
            return;
        }

        if (imageComponent.sprite == null)
        {
            Debug.LogError("AudioFromImage: No sprite assigned to the Image component!");
            enabled = false;
            return;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseOver = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseOver = false;
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        if (!isMouseOver) return;

        ProcessMouseInput(eventData.position);
    }

    private void ProcessMouseInput(Vector2 screenPosition)
    {
        // Convert screen position to local position within the RectTransform
        Vector2 localPosition;
        if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(
            rectTransform, screenPosition, null, out localPosition))
        {
            return;
        }

        // Get the rect bounds
        Rect rect = rectTransform.rect;

        // Normalize the local position to 0-1 range
        float normalizedX = Mathf.InverseLerp(rect.xMin, rect.xMax, localPosition.x);
        float normalizedY = Mathf.InverseLerp(rect.yMin, rect.yMax, localPosition.y);

        // Clamp to ensure we're within bounds
        normalizedX = Mathf.Clamp01(normalizedX);
        normalizedY = Mathf.Clamp01(normalizedY);

        // Get the sprite texture
        Sprite sprite = imageComponent.sprite;
        Texture2D texture = sprite.texture;

        // Convert normalized coordinates to texture coordinates
        int textureX = Mathf.FloorToInt(normalizedX * texture.width);
        int textureY = Mathf.FloorToInt(normalizedY * texture.height);

        // Clamp texture coordinates
        textureX = Mathf.Clamp(textureX, 0, texture.width - 1);
        textureY = Mathf.Clamp(textureY, 0, texture.height - 1);

        // Get the pixel color
        Color pixelColor = texture.GetPixel(textureX, textureY);

        // Convert to greyscale using standard luminance formula
        float greyscaleValue = 0.299f * pixelColor.r + 0.587f * pixelColor.g + 0.114f * pixelColor.b;

        // Pass the greyscale value to AudioSynthTest
        audioSynthTest.SetSliderValue(greyscaleValue);
    }
}
