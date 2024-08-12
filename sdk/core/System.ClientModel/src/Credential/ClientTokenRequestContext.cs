// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace System.ClientModel.Primitives;

#pragma warning disable CS1591
public struct ClientTokenRequestContext
{
    /// <summary>
    /// The scopes required for the token.
    /// </summary>
    public string[] Scopes { get; }

    /// <summary>
    /// The client request id of the request requiring a token for authentication, if applicable.
    /// </summary>
    public string? ParentRequestId { get; }

    /// <summary>
    /// Additional claims to be included in the token. See <see href="https://openid.net/specs/openid-connect-core-1_0-final.html#ClaimsParameter">https://openid.net/specs/openid-connect-core-1_0-final.html#ClaimsParameter</see> for more information on format and content.
    /// </summary>
    public string? Claims { get; }

    /// <summary>
    /// The tenantId to be included in the token request.
    /// </summary>
    public string? TenantId { get; }

    /// <summary>
    /// Indicates whether to enable Continuous Access Evaluation (CAE) for the requested token.
    /// </summary>
    /// <remarks>
    /// If a resource API implements CAE and your application declares it can handle CAE, your app receives CAE tokens for that resource.
    /// For this reason, if you declare your app CAE ready, your application must handle the CAE claim challenge for all resource APIs that accept Microsoft Identity access tokens.
    /// If you don't handle CAE responses in these API calls, your app could end up in a loop retrying an API call with a token that is still in the returned lifespan of the token but has been revoked due to CAE.
    /// </remarks>
    public bool IsCaeEnabled { get; }
}
#pragma warning restore CS1591
