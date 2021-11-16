﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure
{
    /// <summary>
    /// Options which can be used to control the behavior of a request sent by a client.
    /// </summary>
    public class RequestContext
    {
        internal List<(HttpPipelinePosition Position, HttpPipelinePolicy Policy)>? Policies { get; private set; }

        internal int PerCallPolicies { get; private set; }
        internal int PerRetryPolicies { get; private set; }
        internal int BeforeTransportPolicies { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestContext"/> class.
        /// </summary>
        public RequestContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestContext"/> class using the given <see cref="ErrorOptions"/>.
        /// </summary>
        /// <param name="options"></param>
        public static implicit operator RequestContext(ErrorOptions options) => new RequestContext { ErrorOptions = options };

        /// <summary>
        /// The token to check for cancellation.
        /// </summary>
        public CancellationToken CancellationToken { get; set; } = CancellationToken.None;

        /// <summary>
        /// Controls under what conditions the operation raises an exception if the underlying response indicates a failure.
        /// </summary>
        public ErrorOptions ErrorOptions { get; set; } = ErrorOptions.Default;

        /// <summary>
        /// </summary>
        /// <param name="policy"></param>
        /// <param name="position"></param>
        public void AddPolicy(HttpPipelinePolicy policy, HttpPipelinePosition position)
        {
            Policies ??= new();
            Policies.Add((position, policy));
        }
    }
}
