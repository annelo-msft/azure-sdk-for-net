// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ServiceModel.Rest;

namespace Azure.Core.Pipeline
{
    internal class HttpPipelineInvocationOptions : InvocationOptions
    {
        // Over time, we've been stashing what are essentially pipeline-invocation
        // options on the message.  This type adapts message into the options type
        // it really is.
        private readonly HttpMessage _message;

        public HttpPipelineInvocationOptions(HttpMessage message)
        {
            _message = message;
        }

        public override bool BufferResponse
        {
            get => _message.BufferResponse;
            set => _message.BufferResponse = value;
        }

        public override TimeSpan? NetworkTimeout
        {
            get => _message.NetworkTimeout;
            set => _message.NetworkTimeout = value;
        }
    }
}
