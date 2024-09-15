// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace System.ClientModel;

#pragma warning disable CS1591 // public XML comments
/// <summary>
/// Represents a collection of values returned from a cloud service operation.
/// The collection values may be returned by one or more service responses.
/// </summary>
public abstract class AsyncCollectionResult<T> : AsyncCollectionResult, IAsyncEnumerable<T>
{
    protected internal AsyncCollectionResult(CancellationToken cancellationToken)
        : base(cancellationToken)
    {
    }

    /// <inheritdoc/>
    public async IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default)
    {
        // If a user passes a CancellationToken parameter, we'll need to join
        // it with the one that was passed to the type constructor, which was
        // passed to the service method of the client that created the instance
        // of the AsyncCollectionResult<T>.
        CancellationTokenSource? cts = default;

        if (CancellationToken != CancellationToken.None &&
            cancellationToken != CancellationToken.None)
        {
            cts = CancellationTokenSource.CreateLinkedTokenSource(CancellationToken, cancellationToken);
            cancellationToken = cts.Token;
        }

        await foreach (ClientResult page in GetRawPagesAsync().ConfigureAwait(false).WithCancellation(cancellationToken))
        {
            await foreach (T value in GetValuesFromPageAsync(page).ConfigureAwait(false).WithCancellation(cancellationToken))
            {
                yield return value;
            }
        }

        cts?.Dispose();
    }

    /// <summary>
    /// Get a collection of the values returned in a page response.
    /// </summary>
    /// <param name="page"></param>
    /// <returns></returns>
    // TODO: Document that implementation should use CancellationToken from property
    protected abstract IAsyncEnumerable<T> GetValuesFromPageAsync(ClientResult page);
}
#pragma warning restore CS1591 // public XML comments
