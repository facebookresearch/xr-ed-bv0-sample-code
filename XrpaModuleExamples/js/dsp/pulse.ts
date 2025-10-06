/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {
    Multiply,
    SineWave,
    TrapezoidCurve,
    Sequence,
    strContains,
    OutputToSystemAudio,
    DoneWhen,
} from "@xrpa/xred-signal-processing";
import { ProgramInput, Scalar, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";

export const Pulse = XrpaDataflowProgram("Pulse", () => {

    const fundamentalFq = ProgramInput("FundamentalFq", Scalar(170));
    const fundamentalAmp = ProgramInput("FundamentalAmp", Scalar(1));
    const rampUpTime = ProgramInput("rampUpTime", Scalar(.2));
    const holdTime = ProgramInput("holdTime", Scalar(.2));
    const rampDownTime = ProgramInput("rampDownTime", Scalar(.2));

    const waveform = SineWave({ frequency: fundamentalFq, amplitude: fundamentalAmp });

    const patternAmp = Sequence({
        elements: [
            TrapezoidCurve({
                softCurve: true,
                lowValue: 0,
                highValue: 1,
                highHoldTime: holdTime,
                rampUpTime: rampUpTime,
                rampDownTime: rampDownTime,
            }),
        ],
        loop: false
    });

    DoneWhen(patternAmp.onDone());

    OutputToSystemAudio({
        source: Multiply(waveform, patternAmp),
    });
});
