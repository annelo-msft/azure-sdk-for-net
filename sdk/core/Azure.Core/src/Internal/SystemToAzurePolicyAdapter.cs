// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.Pipeline;

namespace Azure.Core.Internal;

/// <summary>
/// Adapts an SCM policy to an Azure policy.  Enables adding an SCM policy to
/// an Azure pipeline.
/// </summary>
internal class SystemToAzurePolicyAdapter : HttpPipelinePolicy
{
    private readonly PipelinePolicy _systemPolicy;

    public SystemToAzurePolicyAdapter(PipelinePolicy systemPolicy)
    {
        _systemPolicy = systemPolicy;
    }

    public override void Process(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        => ProcessSyncOrAsync(message, pipeline, async: false).EnsureCompleted();

    public override ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        => ProcessSyncOrAsync(message, pipeline, async: true);

    private async ValueTask ProcessSyncOrAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline, bool async)
    {
        // Before send to transport
        PipelineMessage scmMessage = AzureToSystemMessageAdapter.FromAzureMessage(message);

        // We delegate calling ProcessNext to the SCM policy.  What it
        // does has to be adapted to work in our policy adapter.

        if (async)
        {
            // TODO: You are here.
            IReadOnlyList<PipelinePolicy> 
            await _systemPolicy.ProcessAsync(scmMessage, pipeline).ConfigureAwait(false);

            //await ProcessNextAsync(message, pipeline).ConfigureAwait(false);
        }
        else
        {
            _systemPolicy.Process(scmMessage, pipeline);
            //ProcessNext(message, pipeline);
        }

        // After sent via transport
    }

    public static SystemToAzurePolicyAdapter FromSystemPolicy(PipelinePolicy policy)
    {
        return new SystemToAzurePolicyAdapter(policy);
    }
}
