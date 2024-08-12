// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace System.ClientModel.Primitives;

#pragma warning disable CS1591
public struct ClientAccessToken
{
    /// <summary>
    /// Get the access token value.
    /// </summary>
    public string Token { get; }

    /// <summary>
    /// Gets the time when the provided token expires.
    /// </summary>
    public DateTimeOffset ExpiresOn { get; }

    /// <summary>
    /// Gets the time when the token should be refreshed.
    /// </summary>
    public DateTimeOffset? RefreshOn { get; }
}
#pragma warning restore CS1591
