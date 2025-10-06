/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import { ProgramInput, ProgramOutput, String, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";
import { ApiProvider, LlmQuery, ModelSize } from "@xrpa/xred-perception-services";

export const LocalLLMQuery = XrpaDataflowProgram("LocalLLMQuery", () => {
  const queryResult = LlmQuery({
    apiKey: ProgramInput("apiKey", String()),
    apiProvider: ApiProvider.LocalLLM,
    modelSize: ModelSize.Small,
    sysPrompt: ProgramInput("SystemPrompt"),
    userPrompt: ProgramInput("ChatMessage"),
  });

  ProgramOutput("Response", queryResult.Response);
});
