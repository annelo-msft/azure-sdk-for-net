// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Learn.TrainingService.Models;

namespace Azure.Learn.TrainingService
{
    public class ComputeNodeAdministrationClient
    {
        private ClientDiagnostics ClientDiagnostics { get; }
        private ComputeNodeAdministrationRestClient Protocol { get; }
        private HttpPipeline Pipeline { get; }

        public ComputeNodeAdministrationClient(Uri endpoint, string nodeName, TokenCredential credential) : this(endpoint, nodeName, credential, null)
        {
        }

        public ComputeNodeAdministrationClient(Uri endpoint, string nodeName, TokenCredential credential, ComputationClientOptions options)
        {
            options ??= new ComputationClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            //Pipeline = options.Build(credential);

            Protocol = new ComputeNodeAdministrationRestClient(ClientDiagnostics, Pipeline, nodeName, endpoint);
        }

        protected ComputeNodeAdministrationClient()
        {
        }

        public virtual async Task<Response<ComputeNode>> CreateAsync(string ifMatch = null, ComputeNode computeNode = null, CancellationToken cancellationToken = default)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="computeNode"> The ComputeNode to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ComputeNode> Create(string ifMatch = null, ComputeNode computeNode = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
