// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Buffers;
using System.ClientModel.Internal;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.ClientModel.Primitives;

public abstract class PipelineResponse : IDisposable
{
    // TODO(matell): The .NET Framework team plans to add BinaryData.Empty in dotnet/runtime#49670, and we can use it then.
    internal static readonly BinaryData s_emptyBinaryData = new(Array.Empty<byte>());

    private bool _isError = false;
    private bool _isBuffered = false;

    /// <summary>
    /// Gets the HTTP status code.
    /// </summary>
    public abstract int Status { get; }

    /// <summary>
    /// Gets the HTTP reason phrase.
    /// </summary>
    public abstract string ReasonPhrase { get; }

    public PipelineResponseHeaders Headers => GetHeadersCore();

    protected abstract PipelineResponseHeaders GetHeadersCore();

    internal bool BufferResponseRequested { get; set; }

    public virtual BinaryData Content { get => s_emptyBinaryData; }

    /// <summary>
    /// Gets the contents of HTTP response. Returns <c>null</c> for responses without content.
    /// </summary>
    public abstract Stream? ContentStream { get; set; }

    /// <summary>
    /// Indicates whether the status code of the returned response is considered
    /// an error code.
    /// </summary>
    // IsError must be virtual in order to maintain Azure.Core back-compatibility.
    public virtual bool IsError => _isError;

    // We have to have a separate method for setting IsError so that the IsError
    // setter doesn't become virtual when we make the getter virtual.
    internal void SetIsError(bool isError) => SetIsErrorCore(isError);

    protected virtual void SetIsErrorCore(bool isError) => _isError = isError;

    internal TimeSpan NetworkTimeout { get; set; } = ClientPipeline.DefaultNetworkTimeout;

    public abstract void Dispose();

    #region Response Buffering

    // Same value as Stream.CopyTo uses by default
    private const int DefaultCopyBufferSize = 81920;

    internal void SetContent(bool bufferResponse, CancellationToken userToken, CancellationTokenSource joinedTokenSource)
        => SetContentSyncOrAsync(bufferResponse, userToken, joinedTokenSource, async: false).EnsureCompleted();

    internal async Task SetContentAsync(bool bufferResponse, CancellationToken userToken, CancellationTokenSource joinedTokenSource)
        => await SetContentSyncOrAsync(bufferResponse, userToken, joinedTokenSource, async: true).ConfigureAwait(false);

    private async Task SetContentSyncOrAsync(bool bufferResponse, CancellationToken userToken, CancellationTokenSource joinedTokenSource, bool async)
    {
        if (ContentStream is null)
        {
            // Nothing to do
            return;
        }

        if (!bufferResponse)
        {
            // Don't buffer the response content, e.g. in order to return the
            // network stream to the end user of a client as part of a streaming
            // API.  In this case, we wrap the content stream in a read-timeout
            // stream, to respect the client's network timeout setting.
            if (NetworkTimeout != Timeout.InfiniteTimeSpan)
            {
                ContentStream = new ReadTimeoutStream(ContentStream, NetworkTimeout);
            }

            return;
        }

        // If cancellation is possible (whether due to network timeout or a user cancellation token being passed), then
        // register callback to dispose the stream on cancellation.
        if (NetworkTimeout != Timeout.InfiniteTimeSpan || userToken.CanBeCanceled)
        {
            joinedTokenSource.Token.Register(state => ((Stream?)state)?.Dispose(), ContentStream);
        }

        try
        {
            if (async)
            {
                await BufferContentAsync(joinedTokenSource).ConfigureAwait(false);
            }
            else
            {
                BufferContent(joinedTokenSource);
            }
        }
        // We dispose stream on timeout or user cancellation so catch and check if cancellation token was cancelled
        catch (Exception ex)
            when (ex is ObjectDisposedException
                      or IOException
                      or OperationCanceledException
                      or NotSupportedException)
        {
            CancellationHelper.ThrowIfCancellationRequestedOrTimeout(userToken, joinedTokenSource.Token, ex, NetworkTimeout);
            throw;
        }
    }

    internal void BufferContent(CancellationTokenSource? cts = default)
        => BufferContentSyncOrAsync(cts, async: false).EnsureCompleted();

    internal async Task BufferContentAsync(CancellationTokenSource? cts = default)
        => await BufferContentSyncOrAsync(cts, async: true).ConfigureAwait(false);

    private async Task BufferContentSyncOrAsync(CancellationTokenSource? cts, bool async)
    {
        Stream? responseContentStream = ContentStream;
        if (responseContentStream == null || _isBuffered)
        {
            // No need to buffer content.
            return;
        }

        MemoryStream bufferStream = new();

        if (async)
        {
            await CopyToAsync(responseContentStream, bufferStream, NetworkTimeout, cts ?? new CancellationTokenSource()).ConfigureAwait(false);
        }
        else
        {
            CopyTo(responseContentStream, bufferStream, NetworkTimeout, cts ?? new CancellationTokenSource());
        }

        responseContentStream.Dispose();
        bufferStream.Position = 0;
        ContentStream = bufferStream;

        _isBuffered = true;
    }

    private static async Task CopyToAsync(Stream source, Stream destination, TimeSpan timeout, CancellationTokenSource cancellationTokenSource)
    {
        byte[] buffer = ArrayPool<byte>.Shared.Rent(DefaultCopyBufferSize);
        try
        {
            while (true)
            {
                cancellationTokenSource.CancelAfter(timeout);
#pragma warning disable CA1835 // ReadAsync(Memory<>) overload is not available in all targets
                int bytesRead = await source.ReadAsync(buffer, 0, buffer.Length, cancellationTokenSource.Token).ConfigureAwait(false);
#pragma warning restore // ReadAsync(Memory<>) overload is not available in all targets
                if (bytesRead == 0)
                    break;
                await destination.WriteAsync(new ReadOnlyMemory<byte>(buffer, 0, bytesRead), cancellationTokenSource.Token).ConfigureAwait(false);
            }
        }
        finally
        {
            cancellationTokenSource.CancelAfter(Timeout.InfiniteTimeSpan);
            ArrayPool<byte>.Shared.Return(buffer);
        }
    }

    private static void CopyTo(Stream source, Stream destination, TimeSpan timeout, CancellationTokenSource cancellationTokenSource)
    {
        byte[] buffer = ArrayPool<byte>.Shared.Rent(DefaultCopyBufferSize);
        try
        {
            int read;
            while ((read = source.Read(buffer, 0, buffer.Length)) != 0)
            {
                cancellationTokenSource.Token.ThrowIfCancellationRequested();
                cancellationTokenSource.CancelAfter(timeout);
                destination.Write(buffer, 0, read);
            }
        }
        finally
        {
            cancellationTokenSource.CancelAfter(Timeout.InfiniteTimeSpan);
            ArrayPool<byte>.Shared.Return(buffer);
        }
    }

    private static Stream WrapNetworkStream(Stream contentStream, TimeSpan networkTimeout)
        => networkTimeout == Timeout.InfiniteTimeSpan ? contentStream
            : new ReadTimeoutStream(contentStream, networkTimeout);
    #endregion
}
