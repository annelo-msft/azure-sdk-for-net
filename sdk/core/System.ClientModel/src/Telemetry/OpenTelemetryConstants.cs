﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.ClientModel.Telemetry;

internal class OpenTelemetryConstants
{
    // follow OpenTelemetry GenAI semantic conventions:
    // https://github.com/open-telemetry/semantic-conventions/tree/v1.27.0/docs/gen-ai

    public const string ErrorTypeKey = "error.type";
    public const string ServerAddressKey = "server.address";
    public const string ServerPortKey = "server.port";

    //public const string GenAiClientOperationDurationMetricName = "gen_ai.client.operation.duration";
    //public const string GenAiClientTokenUsageMetricName = "gen_ai.client.token.usage";

    //public const string GenAiOperationNameKey = "gen_ai.operation.name";

    //public const string GenAiRequestMaxTokensKey = "gen_ai.request.max_tokens";
    //public const string GenAiRequestModelKey = "gen_ai.request.model";
    //public const string GenAiRequestTemperatureKey = "gen_ai.request.temperature";
    //public const string GenAiRequestTopPKey = "gen_ai.request.top_p";

    //public const string GenAiResponseIdKey = "gen_ai.response.id";
    //public const string GenAiResponseFinishReasonKey = "gen_ai.response.finish_reasons";
    //public const string GenAiResponseModelKey = "gen_ai.response.model";

    //public const string GenAiSystemKey = "gen_ai.system";
    //public const string GenAiSystemValue = "openai";

    //public const string GenAiTokenTypeKey = "gen_ai.token.type";

    //public const string GenAiUsageInputTokensKey = "gen_ai.usage.input_tokens";
    //public const string GenAiUsageOutputTokensKey = "gen_ai.usage.output_tokens";
}
