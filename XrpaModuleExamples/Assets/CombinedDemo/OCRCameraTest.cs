/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OCRCameraTest : MonoBehaviour, IXrpaDemo
{
    public RawImage imageToAnalyze;
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
        Texture2D testOCRImage = TextureUtils.RawImageToTexture2D(imageToAnalyze);

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


    private void OnResult(ulong arg1, string s, ulong arg3, bool arg4, string arg5)
    {
        string resultString = "";
        //resultString += (arg1 + "\n");
        resultString += (s + "\n");
        //resultString += (arg3 + " " + arg4 + " " + arg5);

        if (string.IsNullOrEmpty(resultString) || string.IsNullOrWhiteSpace(resultString))
            resultString = "<no legible text detected>";

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
