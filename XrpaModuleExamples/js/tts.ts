/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import { ProgramInput, ProgramOutput, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";
import { TtsRequest } from "@xrpa/xred-text-to-speech";
import { OutputToSystemAudio, SignalStream, StackChannels } from "@xrpa/xred-signal-processing";


export const SpeakText = XrpaDataflowProgram("SpeakText", () => {
    const ttsRequest = TtsRequest({
        TextRequest: ProgramInput("TextRequest"),
    });

    ProgramOutput("TtsResponse", ttsRequest.TtsResponse);

    const audioStream = SignalStream({
        signal: ttsRequest.audio.signal,
        numChannels: 1,
    });
    OutputToSystemAudio({
        source: StackChannels(audioStream, audioStream),
    });
});
