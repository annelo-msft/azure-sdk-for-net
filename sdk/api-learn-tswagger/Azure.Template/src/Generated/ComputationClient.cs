// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace Azure.Learn.TrainingService
{
    /// <summary> The Computation service client. </summary>
    public partial class ComputationClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ComputationRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ComputationClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="nodeName"> The String to use. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="xMsClientRequestId"> Optional client-provided request id. </param>
        internal ComputationClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string nodeName, Uri endpoint = null, string xMsClientRequestId = null)
        {
            RestClient = new ComputationRestClient(clientDiagnostics, pipeline, nodeName, endpoint, xMsClientRequestId);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <param name="precision"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ComputePiAsync(int? precision = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputationClient.ComputePi");
            scope.Start();
            try
            {
                return (await RestClient.ComputePiAsync(precision, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="precision"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ComputePi(int? precision = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ComputationClient.ComputePi");
            scope.Start();
            try
            {
                return RestClient.ComputePi(precision, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
