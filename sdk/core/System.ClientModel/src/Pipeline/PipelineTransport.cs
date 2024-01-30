// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Internal;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.ClientModel.Primitives;

public abstract class PipelineTransport : PipelinePolicy
{
    /// <summary>
    /// TBD: needed for inheritdoc.
    /// </summary>
    /// <param name="message"></param>
    public void Process(PipelineMessage message)
        => ProcessSyncOrAsync(message, async: false).EnsureCompleted();

    /// <summary>
    /// TBD: needed for inheritdoc.
    /// </summary>
    /// <param name="message"></param>
    public async ValueTask ProcessAsync(PipelineMessage message)
        => await ProcessSyncOrAsync(message, async: true).ConfigureAwait(false);

    private async ValueTask ProcessSyncOrAsync(PipelineMessage message, bool async)
    {
        Debug.Assert(message.NetworkTimeout is not null);

        TimeSpan invocationNetworkTimeout = (TimeSpan)message.NetworkTimeout!;

        CancellationToken oldToken = message.CancellationToken;
        using CancellationTokenSource cts = CancellationTokenSource.CreateLinkedTokenSource(oldToken);
        cts.CancelAfter(invocationNetworkTimeout);

        try
        {
            message.CancellationToken = cts.Token;
            if (async)
            {
                await ProcessCoreAsync(message).ConfigureAwait(false);
            }
        }
        catch (OperationCanceledException ex)
        {
            CancellationHelper.ThrowIfCancellationRequestedOrTimeout(oldToken, cts.Token, ex, invocationNetworkTimeout);
            throw;
        }
        finally
        {
            message.CancellationToken = oldToken;
            cts.CancelAfter(Timeout.Infinite);
        }

        if (message.Response is null)
        {
            throw new InvalidOperationException("Response was not set by transport.");
        }

        message.Response.SetIsError(ClassifyResponse(message));
        message.Response!.NetworkTimeout = invocationNetworkTimeout;

        Stream? responseContentStream = message.Response!.ContentStream;
        if (responseContentStream is null ||
            message.Response.TryGetBufferedContent(out var _))
        {
            // There is either no content on the response, or the content has already
            // been buffered.
            return;
        }

        if (!message.BufferResponse)
        {
            // Client has requested not to buffer the message response content.
            // If applicable, wrap it in a read-timeout stream.
            if (invocationNetworkTimeout != Timeout.InfiniteTimeSpan)
            {
                message.Response.ContentStream = new ReadTimeoutStream(responseContentStream, invocationNetworkTimeout);
            }

            return;
        }

        // If we got this far, buffer the response.

        // If cancellation is possible (whether due to network timeout or a user cancellation token being passed), then
        // register callback to dispose the stream on cancellation.
        if (invocationNetworkTimeout != Timeout.InfiniteTimeSpan || oldToken.CanBeCanceled)
        {
            cts.Token.Register(state => ((Stream?)state)?.Dispose(), responseContentStream);
        }

        try
        {
            if (async)
            {
                await message.Response.BufferContentAsync(invocationNetworkTimeout, cts).ConfigureAwait(false);
            }
            else
            {
                message.Response.BufferContent(invocationNetworkTimeout, cts);
            }
        }
        // We dispose stream on timeout or user cancellation so catch and check if cancellation token was cancelled
        catch (Exception ex)
            when (ex is ObjectDisposedException
                      or IOException
                      or OperationCanceledException
                      or NotSupportedException)
        {
            CancellationHelper.ThrowIfCancellationRequestedOrTimeout(oldToken, cts.Token, ex, invocationNetworkTimeout);
            throw;
        }
    }

    private static bool ClassifyResponse(PipelineMessage message)
    {
        if (!message.MessageClassifier.TryClassify(message, out bool isError))
        {
            bool classified = PipelineMessageClassifier.Default.TryClassify(message, out isError);

            Debug.Assert(classified);
        }

        return isError;
    }

    protected abstract void ProcessCore(PipelineMessage message);

    protected abstract ValueTask ProcessCoreAsync(PipelineMessage message);

    /// <summary>
    /// TBD: needed for inheritdoc.
    /// </summary>
    public PipelineMessage CreateMessage()
    {
        PipelineMessage message = CreateMessageCore();

        if (message.Request is null)
        {
            throw new InvalidOperationException("Request was not set on message.");
        }

        if (message.Response is not null)
        {
            throw new InvalidOperationException("Response should not be set before transport is invoked.");
        }

        return message;
    }

    protected abstract PipelineMessage CreateMessageCore();

    // These methods from PipelinePolicy just say "you've reached the end
    // of the line", i.e. they stop the invocation of the policy chain.
    public sealed override void Process(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
    {
        Process(message);

        Debug.Assert(++currentIndex == pipeline.Count);
    }

    public sealed override async ValueTask ProcessAsync(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
    {
        await ProcessAsync(message).ConfigureAwait(false);

        Debug.Assert(++currentIndex == pipeline.Count);
    }
}
