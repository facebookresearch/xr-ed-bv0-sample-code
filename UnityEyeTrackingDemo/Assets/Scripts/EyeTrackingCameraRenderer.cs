/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using EyeTrackingDataStore;
using UnityEngine;

public class EyeTrackingCameraRenderer : MonoBehaviour
{
    [SerializeField]
    private Color gazeCircleColor = Color.red;

    [SerializeField]
    private int gazeCircleRadius = 10;

    [Header("Debug Visualization")]
    [SerializeField]
    private bool showDebugVisualization = true;

    [SerializeField]
    private float gazeRayLength = 5f;

    [SerializeField]
    private float orientationAxisLength = 0.5f;

    [SerializeField]
    private Color gazeRayColor = Color.magenta;

    private Texture2D _texture;
    private MeshRenderer _meshRenderer;
    private EyeTrackingDeviceComponent _eyeTrackingDevice;
    private bool _textureAssigned = false;

    void Start()
    {
        _texture = new Texture2D(2, 2, TextureFormat.RGB24, false);

        _meshRenderer = GetComponent<MeshRenderer>();
        if (_meshRenderer == null)
        {
            Debug.LogError("EyeTrackingCameraRenderer: No MeshRenderer found on this GameObject.");
            return;
        }

        _eyeTrackingDevice = GetComponent<EyeTrackingDeviceComponent>();
        if (_eyeTrackingDevice == null)
        {
            Debug.LogError("EyeTrackingCameraRenderer: No EyeTrackingDeviceComponent found on this GameObject.");
            return;
        }

        _eyeTrackingDevice.OnSceneCamera += HandleSceneCamera;
        _eyeTrackingDevice.OnEyeEvent += HandleEyeEvent;
    }

    private void HandleEyeEvent(ulong msgTimestamp, EyeEventType eventType, ulong startTime, ulong endTime, Vector2 meanGaze, float amplitude, float maxVelocity)
    {
        Debug.Log($"[EyeEvent] Type: {eventType}, StartTime: {startTime}, EndTime: {endTime}, MeanGaze: {meanGaze}, Amplitude: {amplitude}, MaxVelocity: {maxVelocity}");
    }

    void Update()
    {
        if (!showDebugVisualization || _eyeTrackingDevice == null)
        {
            return;
        }

        Vector3 origin = transform.position;
        Quaternion headOrientation = _eyeTrackingDevice.HeadOrientation;
        Vector3 gazeDirection = _eyeTrackingDevice.GazeDirection;

        // Draw head orientation axes (RGB = XYZ = Right/Up/Forward)
        Vector3 forward = headOrientation * Vector3.forward;
        Vector3 up = headOrientation * Vector3.up;
        Vector3 right = headOrientation * Vector3.right;

        Debug.DrawRay(origin, right * orientationAxisLength, Color.red);
        Debug.DrawRay(origin, up * orientationAxisLength, Color.green);
        Debug.DrawRay(origin, forward * orientationAxisLength, Color.blue);

        // Draw world-space gaze direction (only if streaming gaze)
        if (_eyeTrackingDevice.StreamGaze)
        {
            Debug.DrawRay(origin, gazeDirection.normalized * gazeRayLength, gazeRayColor);
        }
    }

    private void HandleSceneCamera(ulong timestamp, Xrpa.Image image, Vector2 gazePosition)
    {
        if (image.data == null || image.data.Length == 0)
        {
            return;
        }

        if (!_texture.LoadImage(image.data, false))
        {
            return;
        }

        if (_eyeTrackingDevice.StreamGaze)
        {
            DrawGazeCircle(gazePosition);
        }

        _texture.Apply();

        if (!_textureAssigned)
        {
            _meshRenderer.material.mainTexture = _texture;
            _textureAssigned = true;
        }
    }

    private void DrawGazeCircle(Vector2 gazePosition)
    {
        int texWidth = _texture.width;
        int texHeight = _texture.height;

        int centerX = Mathf.RoundToInt(gazePosition.x);
        int centerY = texHeight - Mathf.RoundToInt(gazePosition.y);

        int radius = gazeCircleRadius;
        int thickness = 2;

        for (int y = -radius; y <= radius; y++)
        {
            for (int x = -radius; x <= radius; x++)
            {
                int distSq = x * x + y * y;
                int innerRadiusSq = (radius - thickness) * (radius - thickness);
                int outerRadiusSq = radius * radius;

                if (distSq <= outerRadiusSq && distSq >= innerRadiusSq)
                {
                    int px = centerX + x;
                    int py = centerY + y;

                    if (px >= 0 && px < texWidth && py >= 0 && py < texHeight)
                    {
                        _texture.SetPixel(px, py, gazeCircleColor);
                    }
                }
            }
        }
    }

    private void OnDestroy()
    {
        if (_eyeTrackingDevice != null)
        {
            _eyeTrackingDevice.OnSceneCamera -= HandleSceneCamera;
            _eyeTrackingDevice.OnEyeEvent -= HandleEyeEvent;
        }

        if (_texture != null)
        {
            Destroy(_texture);
        }
    }
}
