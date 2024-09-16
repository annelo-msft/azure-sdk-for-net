// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using ClientModel.Tests.Paging;

namespace ClientModel.Tests.Collections;

/// <summary>
/// Protocol-layer paginated collection
/// </summary>
internal class ProtocolValueCollectionResult : CollectionResult
{
    private readonly RequestOptions? _options;
    private readonly int? _pageSize;

    private readonly IEnumerable<ValueItemPage> _mockPagesData;

    public ProtocolValueCollectionResult(RequestOptions? options, int? pageSize)
        : base(options?.CancellationToken ?? default)
    {
        _options = options;
        _pageSize = pageSize;

        _mockPagesData = MockPageResponseData.GetPages();
    }

    public override ContinuationToken? GetContinuationToken(ClientResult page)
        => ValueCollectionPageToken.FromResponse(page, _pageSize);

    public override IEnumerable<ClientResult> GetRawPages()
    {
        foreach (ValueItemPage page in _mockPagesData)
        {
            PipelineResponse response = new MockPageResponse(page);
            yield return ClientResult.FromResponse(response);
        }
    }
}
