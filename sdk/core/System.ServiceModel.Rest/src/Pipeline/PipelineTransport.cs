// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics;
using System.Threading.Tasks;

namespace System.ServiceModel.Rest.Core.Pipeline;

public abstract class PipelineTransport<TMessage> : IPipelinePolicy<TMessage>
{
    private TimeSpan _networkTimeout;

    public PipelineTransport(TimeSpan? networkTimeout = null)
    {
        // TODO: plumb through this default all the way
        _networkTimeout = networkTimeout ?? PipelineOptions.DefaultNetworkTimeout;
    }

    /// <summary>
    /// TBD: needed for inheritdoc.
    /// </summary>
    /// <param name="message"></param>
    public abstract void Process(TMessage message);

    /// <summary>
    /// TBD: needed for inheritdoc.
    /// </summary>
    /// <param name="message"></param>
    public abstract ValueTask ProcessAsync(TMessage message);

    /// <summary>
    /// TBD: needed for inheritdoc.
    /// </summary>
    public abstract TMessage CreateMessage();

    public void Process(TMessage message, IPipelineEnumerator pipeline)
    {
        Debug.Assert(pipeline.Length == 0);

        Process(message);
    }

    public async ValueTask ProcessAsync(TMessage message, IPipelineEnumerator pipeline)
    {
        Debug.Assert(pipeline.Length == 0);

        await ProcessAsync(message).ConfigureAwait(false);
    }

    #region Buffer Response Override

    public static void SetBufferResponse(PipelineMessage message, bool bufferResponse)
        => message.SetProperty(typeof(BufferResponsePropertyKey), bufferResponse);

    public static bool TryGetBufferResponse(PipelineMessage message, out bool bufferResponse)
    {
        if (message.TryGetProperty(typeof(BufferResponsePropertyKey), out object? value) &&
            value is bool doBuffer)
        {
            bufferResponse = doBuffer;
            return true;
        }

        bufferResponse = default;
        return false;
    }

    private struct BufferResponsePropertyKey { }

    #endregion

    #region Network Timeout Override

    public static void SetNetworkTimeout(PipelineMessage message, TimeSpan networkTimeout)
        => message.SetProperty(typeof(NetworkTimeoutPropertyKey), networkTimeout);

    public static bool TryGetNetworkTimeout(PipelineMessage message, out TimeSpan networkTimeout)
    {
        if (message.TryGetProperty(typeof(NetworkTimeoutPropertyKey), out object? value) &&
            value is TimeSpan timeout)
        {
            networkTimeout = timeout;
            return true;
        }

        networkTimeout = default;
        return false;
    }

    private struct NetworkTimeoutPropertyKey { }

    #endregion
}
