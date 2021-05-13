// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Storage.ConfidentialLedger
{
    /// <summary> The ConfidentialLedgerIdentityService service client. </summary>
    public partial class ConfidentialLedgerIdentityServiceClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://confidential-ledger.azure.com/.default" };
        private Uri identityServiceUri;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of ConfidentialLedgerIdentityServiceClient for mocking. </summary>
        protected ConfidentialLedgerIdentityServiceClient()
        {
        }

        /// <summary> Initializes a new instance of ConfidentialLedgerIdentityServiceClient. </summary>
        /// <param name="identityServiceUri"> The Identity Service URL, for example https://identity.accledger.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ConfidentialLedgerIdentityServiceClient(Uri identityServiceUri, TokenCredential credential, ConfidentialLedgerClientOptions options = null)
        {
            if (identityServiceUri == null)
            {
                throw new ArgumentNullException(nameof(identityServiceUri));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ConfidentialLedgerClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            var authPolicy = new BearerTokenAuthenticationPolicy(credential, AuthorizationScopes);
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { authPolicy, new LowLevelCallbackPolicy() });
            this.identityServiceUri = identityServiceUri;
            apiVersion = options.Version;
        }

        /// <summary> Gets identity information for a Confidential Ledger instance. </summary>
        /// <param name="ledgerId"> Id of the Confidential Ledger instance to get information for. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetLedgerIdentityAsync(string ledgerId, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateGetLedgerIdentityRequest(ledgerId, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerIdentityServiceClient.GetLedgerIdentity");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets identity information for a Confidential Ledger instance. </summary>
        /// <param name="ledgerId"> Id of the Confidential Ledger instance to get information for. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetLedgerIdentity(string ledgerId, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateGetLedgerIdentityRequest(ledgerId, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerIdentityServiceClient.GetLedgerIdentity");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetLedgerIdentity"/> and <see cref="GetLedgerIdentityAsync"/> operations. </summary>
        /// <param name="ledgerId"> Id of the Confidential Ledger instance to get information for. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateGetLedgerIdentityRequest(string ledgerId, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(identityServiceUri);
            uri.AppendPath("/ledgerIdentity/", false);
            uri.AppendPath(ledgerId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }
    }
}
