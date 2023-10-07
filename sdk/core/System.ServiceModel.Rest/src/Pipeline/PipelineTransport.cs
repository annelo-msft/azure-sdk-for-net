// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics;
using System.Threading.Tasks;

namespace System.ServiceModel.Rest.Core.Pipeline;

public abstract class PipelineTransport<TMessage, TOptions> : IPipelinePolicy<TMessage, TOptions>
{
    /// <summary>
    /// TBD: needed for inheritdoc.
    /// </summary>
    /// <param name="message"></param>
    /// <param name="options"></param>
    public abstract void Process(TMessage message, TOptions options);

    /// <summary>
    /// TBD: needed for inheritdoc.
    /// </summary>
    /// <param name="message"></param>
    /// /// <param name="options"></param>
    public abstract ValueTask ProcessAsync(TMessage message, TOptions options);

    /// <summary>
    /// TBD: needed for inheritdoc.
    /// </summary>
    public abstract TMessage CreateMessage(InvocationOptions options);

    // Note: if we were willing to constrain TMessage, we could make
    // SetResponse a method on message instead of the transport?
    //public abstract void SetResponse(TMessage message, PipelineResponse response);

    public void Process(TMessage message, TOptions options, IPipelineEnumerator pipeline)
    {
        Debug.Assert(pipeline.Length == 0);

        Process(message, options);
    }

    public async ValueTask ProcessAsync(TMessage message, TOptions options, IPipelineEnumerator pipeline)
    {
        Debug.Assert(pipeline.Length == 0);

        await ProcessAsync(message, options).ConfigureAwait(false);
    }
}
