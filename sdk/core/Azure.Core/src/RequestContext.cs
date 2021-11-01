// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure
{
    /// <summary>
    /// Options which can be used to control the behavior of a request sent by a client.
    /// </summary>
    public class RequestContext : RequestOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestContext"/> class.
        /// </summary>
        public RequestContext() : base()
        {
        }

        /// <summary>
        /// The token to check for cancellation.
        /// </summary>
        public CancellationToken CancellationToken { get; set; } = CancellationToken.None;
    }
}
