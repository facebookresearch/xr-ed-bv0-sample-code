/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using UnityEngine;

public class PsychoPyWindowDisplay : MonoBehaviour
{
    private Texture2D _texture;
    public Renderer targetRenderer;

    void Start()
    {
        var win = GetComponent<PsychoPyWindowComponent>();
        if (win != null)
        {
            win.OnDisplay += HandleDisplayUpdate;
        }

        if (!targetRenderer)
        {
            targetRenderer = GetComponent<Renderer>();
        }
        _texture = new Texture2D(2, 2);
        targetRenderer.material.mainTexture = _texture;
    }

    void HandleDisplayUpdate(ulong timestamp, SensoryStimulusDataStore.Image image)
    {
        _texture.LoadImage(image.data);
    }
}
