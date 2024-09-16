// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Threading;

namespace ClientModel.Tests.Collections;

internal class ValueCollectionResult : CollectionResult
{
    public ValueCollectionResult(CancellationToken cancellationToken)
        : base(cancellationToken)
    {
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
