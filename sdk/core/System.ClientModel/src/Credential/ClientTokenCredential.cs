// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.ClientModel.Primitives;

#pragma warning disable CS1591
public abstract class ClientTokenCredential
{
    public abstract ValueTask<ClientAccessToken> GetTokenAsync(ClientTokenRequestContext requestContext, CancellationToken cancellationToken);

    public abstract ClientAccessToken GetToken(ClientTokenRequestContext requestContext, CancellationToken cancellationToken);
}
#pragma warning restore CS1591
