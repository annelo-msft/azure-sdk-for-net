// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.Collections;
using System.Collections.Generic;

namespace System.ClientModel;

#pragma warning disable CS1591 // public XML comments
public class PageResult<T> : ClientResult, IEnumerable<T>
{
    private readonly IEnumerable<T> _values;

    public PageResult(IEnumerable<T> values,
        ContinuationToken? nextPageToken,
        PipelineResponse response) : base(response)
    {
        _values = values;
        this.NextPageToken = nextPageToken;
    }

    public ContinuationToken? NextPageToken { get; }

    public IEnumerator<T> GetEnumerator()
        => _values.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
#pragma warning restore CS1591 // public XML comments
