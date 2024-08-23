/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import { SignalGraph } from "@xrpa/xred-signal-processing";

import { HapticClick } from "./HapticClick";
import { ContinuousWave } from "./ContinuousWave";
import { SimpleWave } from "./SimpleWave";
import { LoopingPattern } from "./LoopingPattern";
import { BG_A } from "./BG_A";
import { BG_B } from "./BG_B";
import { BG_C } from "./BG_C";
import { Pulse_A } from "./Pulse_A";
import { Pulse_B } from "./Pulse_B";
import { Pulse_C } from "./Pulse_C";
import { PulsePattern } from "./PulsePattern";
import { TestEffect1 } from "./TestEffect1";
import { TestEffect2 } from "./TestEffect2";
import { TestEffect3 } from "./TestEffect3";

export const UnityEffects: Record<string, SignalGraph> = {
    BG_A: BG_A(),
    BG_B: BG_B(),
    BG_C: BG_C(),
    Pulse_A: Pulse_A(),
    Pulse_B: Pulse_B(),
    Pulse_C: Pulse_C(),
    HapticClick: HapticClick(),
    ContinuousWave: ContinuousWave(),
    LoopingPattern: LoopingPattern(),
    PulsePattern : PulsePattern(),
    SimpleWave: SimpleWave(),
    TestEffect1: TestEffect1(),
    TestEffect2: TestEffect2(),
    TestEffect3: TestEffect3(),
};