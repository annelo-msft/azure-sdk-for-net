// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.Pipeline;

namespace Azure.Core.Internal;

internal class AzureToSystemPolicyAdapter : PipelinePolicy
{
    private readonly HttpPipelinePolicy _azurePolicy;

    public AzureToSystemPolicyAdapter(HttpPipelinePolicy azurePolicy)
    {
        _azurePolicy = azurePolicy;
    }

    public static AzureToSystemPolicyAdapter FromAzurePolicy(HttpPipelinePolicy policy)
    {
        return new AzureToSystemPolicyAdapter(policy);
    }

    public override void Process(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
    {
        throw new NotImplementedException();
    }

    public override ValueTask ProcessAsync(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
    {
        throw new NotImplementedException();
    }
}
