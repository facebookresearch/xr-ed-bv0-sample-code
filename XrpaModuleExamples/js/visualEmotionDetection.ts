/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import { ProgramInput, ProgramOutput, String, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";
import { VisualEmotionDetection, XredVisualEmotionDetectionInterface } from "@xrpa/xred-visual-emotion-detection";

export const DetectEmotion = XrpaDataflowProgram("DetectEmotion", () => {

    /*
    const moodDetection = VisualEmotionDetection({
        //jpegImageData: ProgramInput("ImageData"),
        apiKey: "key/eyJhY2NvdW50Ijp7ImlkIjoiNTBlODllMjctOGQyZC00OGY1LWJlNjktOGJiM2FhYTc5MDIyIn0sInByb2R1Y3QiOnsiaWQiOiJlMjE0MzU3YS04NTk3LTQ1OTQtYjQ1Zi01ZmFmZGIyZmRmZjMifSwicG9saWN5Ijp7ImlkIjoiZjczZGI5M2MtNWJjOS00MTlmLTkwYmQtYzI0NmM1NjVlNTZhIiwiZHVyYXRpb24iOjc3NzYwMDB9LCJ1c2VyIjp7ImlkIjoiNTAwMDdjOWEtZGZiNS00ZWE4LWI1MWMtODc0MmYyMDZiZDc1IiwiZW1haWwiOiJyb2JjYXZpbkBtZXRhLmNvbSJ9LCJsaWNlbnNlIjp7ImlkIjoiNzYyYThkMDAtMmZkNS00N2FiLWI4ZTktYWU4MzAwZGFhMzNhIiwiY3JlYXRlZCI6IjIwMjUtMDQtMTBUMTc6MTk6MTcuODU4WiIsImV4cGlyeSI6IjIwMjUtMDUtMTFUMDA6MDA6MDAuMDAwWiJ9fQ==.wniRJCQBmsoOvz12LWQAi33RiJ0TMTmfus7GRXdxPgMqpKlb1G_R1EV6oeaOaQgTAriN4QuD4Yb_YSKXjeSWBw==",
    });*/

    //ProgramOutput("emotionResult", moodDetection.emotionResult);
});
