﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.Collections;
using System.Collections.Generic;

namespace System.ClientModel;

/// <summary>
/// Represents a collection of values returned from a cloud service operation.
/// The collection values may be returned by one or more service responses.
/// </summary>
public abstract class CollectionResult<T> : CollectionResult, IEnumerable<T>
{
    /// <summary>
    /// Create a new instance of <see cref="CollectionResult{T}"/>.
    /// </summary>
    /// <remarks>If no <see cref="PipelineResponse"/> is provided when the
    /// <see cref="ClientResult"/> instance is created, it is expected that
    /// a derived type will call <see cref="ClientResult.SetRawResponse(PipelineResponse)"/>
    /// prior to a user calling <see cref="ClientResult.GetRawResponse"/>.
    /// This constructor is indended for use by collection implementations that
    /// postpone sending a request until <see cref="GetEnumerator()"/>
    /// is called. Such implementations will typically be returned from client
    /// convenience methods so that callers of the methods don't need to
    /// dispose the return value. </remarks>
    protected internal CollectionResult() : base()
    {
    }

    /// <inheritdoc/>
    public IEnumerator<T> GetEnumerator()
    {
        foreach (ClientResult page in GetRawPages())
        {
            foreach (T value in GetValuesFromPage(page))
            {
                yield return value;
            }
        }
    }

    /// <summary>
    /// TBD.
    /// </summary>
    /// <returns></returns>
    public IEnumerable<PageResult<T>> GetPages()
    {
        foreach (ClientResult page in GetRawPages())
        {
            IEnumerable<T> values = GetValuesFromPage(page);
            ContinuationToken? continuationToken = GetContinuationToken(page);
            yield return new PageResult<T>(values, continuationToken, page.GetRawResponse());
        }
    }

    /// <summary>
    /// Get a collection of the values from a page response.
    /// </summary>
    /// <param name="page"></param>
    /// <returns></returns>
    protected abstract IEnumerable<T> GetValuesFromPage(ClientResult page);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
