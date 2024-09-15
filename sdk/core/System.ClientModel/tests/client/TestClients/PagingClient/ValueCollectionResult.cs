// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClientModel.Tests.Paging;

/// <summary>
/// Protocol-layer paginated collection
/// </summary>
internal class ValueCollectionResult : CollectionResult
{
    private readonly ClientPipeline _pipeline;
    private readonly Uri _endpoint;
    private readonly RequestOptions? _options;

    // Initial values
    private readonly string? _order;
    private readonly int? _pageSize;
    private readonly int? _offset;

    public ValueCollectionResult(ClientPipeline pipeline, Uri endpoint,
        RequestOptions? options,
        string? order, int? pageSize, int? offset)
        : base(options?.CancellationToken ?? CancellationToken.None)
    {
        _pipeline = pipeline;
        _endpoint = endpoint;
        _options = options;

        _order = order;
        _pageSize = pageSize;
        _offset = offset;
    }

    public override ContinuationToken? GetContinuationToken(ClientResult page)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<ClientResult> GetRawPages()
    {
        throw new NotImplementedException();
    }
}
