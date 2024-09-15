// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
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
        ClientResult page = GetFirstPage();
        yield return page;

        while (HasNextPage(page))
        {
            page = GetNextPage(page);
            yield return page;
        }
    }

    public ClientResult GetFirstPage()
    {
        using PipelineMessage message = _pipeline.CreateMessage();
        message.Request.Uri = _endpoint;

        _pipeline.Send(message);

        return ClientResult.FromResponse(message.Response!);
    }

    public ClientResult GetNextPage(ClientResult result)
    {
        using PipelineMessage message = _pipeline.CreateMessage();
        message.Request.Uri = _endpoint;

        _pipeline.Send(message);

        return ClientResult.FromResponse(message.Response!);
    }

    public static bool HasNextPage(ClientResult result)
    {
        Argument.AssertNotNull(result, nameof(result));

        PipelineResponse response = result.GetRawResponse();

        using JsonDocument doc = JsonDocument.Parse(response.Content);
        bool hasMore = doc.RootElement.GetProperty("has_more"u8).GetBoolean();

        return hasMore;
    }
}
