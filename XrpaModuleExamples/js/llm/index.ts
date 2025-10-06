/**
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

import { LlamaConversation } from "./LlamaConversation";
import { LlamaLargeQuery } from "./LlamaLargeQuery";
import { LlamaMCP } from "./LlamaMCP";
import { LlamaSmallQuery } from "./LlamaSmallQuery";
import { LocalLLMQuery } from "./LocalLLMQuery";
import { LlamaLargeConversation } from "./LlamaLargeConversation";

export const LlmPrograms = [
  LlamaConversation,
  LlamaLargeQuery,
  LlamaMCP,
  LlamaSmallQuery,
  LocalLLMQuery,
  LlamaLargeConversation,
];
