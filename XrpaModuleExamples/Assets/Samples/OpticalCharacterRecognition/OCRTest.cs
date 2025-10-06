/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using TMPro;
using UnityEngine;

public class OCRTest : MonoBehaviour, IXrpaDemo
{
    public Camera cameraToAnalyze;
    public TextMeshProUGUI statusText;

    private OpticalCharacterRecognitionComponent _ocr;

    private int _triggerid = 1;

    void Start()
    {
        // Send to OCR component on button press
        _ocr = FindAnyObjectByType<OpticalCharacterRecognitionComponent>();
        if (_ocr == null)
        {
            _ocr = gameObject.AddComponent<OpticalCharacterRecognitionComponent>();
        }
        _ocr.OnOcrResult += OnResult;
    }

    public void SendImage()
    {
        Texture2D testOCRImage = CaptureCamera();

        // Convert Texture2D to byte array
        byte[] imageData = testOCRImage.EncodeToJPG();

        // Create Xrpa.Image from the byte data
        Xrpa.Image xrpaImage = new Xrpa.Image
        {
            data = imageData,
            width = testOCRImage.width,
            height = testOCRImage.height,
            format = Xrpa.ImageFormat.RGB8
        };

        // Send the image to OCR
        _ocr.SendImageInput(xrpaImage);
        _ocr.TriggerId = _triggerid;
        statusText.SetText("Sent camera image with trigger ID " + _triggerid);
        _triggerid++;
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

    private void OnResult(ulong arg1, string s, ulong arg3, bool arg4, string arg5)
    {
        string resultString = "";
        resultString += (arg1 + "\n");
        resultString += (s + "\n");
        resultString += (arg3 + " " + arg4 + " " + arg5);

        statusText.SetText(resultString);
    }

    public void StartDemo()
    {
        Debug.Log("Starting OCR Demo");
        statusText.SetText("OCR Demo started - ready to analyze camera");
    }

    public void StopDemo()
    {
        Debug.Log("Stopping OCR Demo");
        statusText.SetText("OCR Demo stopped");
    }
}
