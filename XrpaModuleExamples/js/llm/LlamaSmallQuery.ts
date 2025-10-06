/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import {Count, ProgramInput, ProgramOutput, String, XrpaDataflowProgram} from "@xrpa/xrpa-orchestrator";
import { ApiProvider, LlmQuery, McpServerSet, ModelSize } from "@xrpa/xred-perception-services";

export const LlamaSmallQuery = XrpaDataflowProgram("LlamaSmallQuery", () => {
  const conversation = LlmQuery({
    apiKey: ProgramInput("apiKey", String()),
    apiProvider: ApiProvider.LlamaAPI,
    modelSize: ModelSize.Small,
    sysPrompt: ProgramInput("SystemPrompt"),
    userPrompt: ProgramInput("ChatMessage"),
  });

  ProgramOutput("Response", conversation.Response);
});
