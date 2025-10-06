/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import { ProgramInput, ProgramOutput, SelfTerminateOn, String, XrpaDataflowProgram } from "@xrpa/xrpa-orchestrator";
import {ApiProvider, LlmConversation, LlmQuery, ModelSize} from "@xrpa/xred-perception-services";

export const LlamaConversation = XrpaDataflowProgram("LlamaConversation", () => {
  const conversation = LlmConversation({
    apiKey: ProgramInput("apiKey", String()),
    apiProvider: ApiProvider.LlamaAPI,
    modelSize: ModelSize.Large,
    sysPrompt: ProgramInput("SystemPrompt"),
    ChatMessage: ProgramInput("ChatMessage"),
  });

  ProgramOutput("Response", conversation.ChatResponse);
});
