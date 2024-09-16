// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel;
using System.Collections.Generic;
using System.Threading;

namespace ClientModel.Tests.Collections;

internal class AsyncValueCollectionResult : AsyncCollectionResult<ValueItem>
{
    public AsyncValueCollectionResult(CancellationToken cancellationToken)
        : base(cancellationToken)
    {
    }

    public override ContinuationToken? GetContinuationToken(ClientResult page)
    {
        throw new System.NotImplementedException();
    }

    public override IAsyncEnumerable<ClientResult> GetRawPagesAsync()
    {
        throw new System.NotImplementedException();
    }

    protected override IAsyncEnumerable<ValueItem> GetValuesFromPageAsync(ClientResult page)
    {
        throw new System.NotImplementedException();
    }
}
