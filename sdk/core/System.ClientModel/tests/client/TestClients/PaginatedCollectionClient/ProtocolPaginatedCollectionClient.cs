// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using ClientModel.Tests.Paging;

namespace ClientModel.Tests.Collections;

// A mock client implementation that illustrates paging patterns for client
// endpoints that only have protocol methods.
public class ProtocolPaginatedCollectionClient
{
    private readonly ClientPipeline _pipeline;

    public ProtocolPaginatedCollectionClient(PaginatedCollectionClientOptions? options = default)
    {
        options ??= new();

        _pipeline = ClientPipeline.Create(options);
    }

    public virtual AsyncCollectionResult GetValuesAsync(
        int? pageSize = default,
        RequestOptions? options = default)
    {
        return new AsyncProtocolValueCollectionResult(pageSize, offset: default, options);
    }
    public virtual AsyncCollectionResult GetValuesAsync(
        ContinuationToken pageToken,
        RequestOptions? options = default)
    {
        ValueCollectionPageToken token = ValueCollectionPageToken.FromToken(pageToken);

        return new AsyncProtocolValueCollectionResult(token.PageSize, token.Offset, options);
    }
    public virtual CollectionResult GetValues(
        int? pageSize = default,
        RequestOptions? options = default)
    {
        return new ProtocolValueCollectionResult(pageSize, offset: default, options);
    }
    public virtual CollectionResult GetValues(
        ContinuationToken pageToken,
        RequestOptions? options = default)
    {
        ValueCollectionPageToken token = ValueCollectionPageToken.FromToken(pageToken);

        return new ProtocolValueCollectionResult(token.PageSize, token.Offset, options);
    }
}
