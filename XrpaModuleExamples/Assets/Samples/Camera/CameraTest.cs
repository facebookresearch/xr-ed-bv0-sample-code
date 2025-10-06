/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraTest : MonoBehaviour, IXrpaDemo
{
    public RawImage rawImage;
    private Texture2D _texture;
    private bool _textureAssigned = false;

    // Start is called before the first frame update
    void Start()
    {
        // Create texture with specific format for better performance
        _texture = new Texture2D(2, 2, TextureFormat.RGB24, false);
        CameraFeedComponent cam = FindAnyObjectByType<CameraFeedComponent>();
        if (cam == null)
        {
            cam = gameObject.AddComponent<CameraFeedComponent>();
        }
        cam.OnCameraImage += GotCameraImage;
    }

    private void GotCameraImage(ulong arg1, Xrpa.Image arg2)
    {
        if (arg2.data != null && arg2.data.Length > 0)
        {
            if (_texture.LoadImage(arg2.data, true))
            {
                if (!_textureAssigned)
                {
                    rawImage.texture = _texture;
                    _textureAssigned = true;
                }
            }
        }
    }

    private void OnDestroy()
    {
        if (_texture != null)
        {
            Destroy(_texture);
        }
    }

    public void StartDemo()
    {
        Debug.Log("Starting Camera Demo");
    }

    public void StopDemo()
    {
        Debug.Log("Stopping Camera Demo");
    }
}
