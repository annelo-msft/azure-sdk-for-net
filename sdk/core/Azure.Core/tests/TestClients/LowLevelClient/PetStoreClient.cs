// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.Experimental.Tests.Models;
using Azure.Core.Pipeline;

namespace Azure.Core.Experimental.Tests
{
    /// <summary> The PetStore service client. </summary>
    public partial class PetStoreClient
    {
        private HttpPipeline _pipeline { get; }
        private readonly string[] _authorizationScopes = { "https://example.azurepetshop.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private Uri _endpoint;
        private readonly string _apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;
        private ResponseClassifier _classifier200;

        /// <summary> Initializes a new instance of PetStoreClient for mocking. </summary>
        protected PetStoreClient()
        {
        }

        private ResponseClassifier Classifier200
        {
            get
            {
                if (_classifier200 == null)
                {
                    _classifier200 = new ResponseClassifier200();
                }
                return _classifier200;
            }
        }

        /// <summary> Initializes a new instance of PetStoreClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public PetStoreClient(Uri endpoint, TokenCredential credential, PetStoreClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new PetStoreClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            var authPolicy = new BearerTokenAuthenticationPolicy(_tokenCredential, _authorizationScopes);

            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { authPolicy }, null);
            this._endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Get a pet by its Id. </summary>
        /// <param name="id"> Id of pet to return. </param>
        /// <param name="context"> The request options. </param>
        public virtual async Task<Response> GetPetAsync(string id, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using HttpMessage message = CreateGetPetRequest(id, context);
            using var scope = _clientDiagnostics.CreateScope("PetStoreClient.GetPet");
            scope.Start();
            try
            {
                await _pipeline.SendAsync(message, context?.CancellationToken ?? default).ConfigureAwait(false);
                var errorOptions = context?.ErrorOptions ?? ErrorOptions.Default;

                if (errorOptions == ErrorOptions.NoThrow)
                {
                    return message.Response;
                }
                else
                {
                    if (!message.ResponseClassifier.IsErrorResponse(message))
                    {
                        return message.Response;
                    }
                    else
                    {
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a pet by its Id. </summary>
        /// <param name="id"> Id of pet to return. </param>
        /// <param name="options"> The request options. </param>
        public virtual Response GetPet(string id, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using HttpMessage message = CreateGetPetRequest(id, context);
            using var scope = _clientDiagnostics.CreateScope("PetStoreClient.GetPet");
            scope.Start();
            try
            {
                _pipeline.Send(message, context?.CancellationToken ?? default);
                var errorOptions = context?.ErrorOptions ?? ErrorOptions.Default;

                if (errorOptions == ErrorOptions.NoThrow)
                {
                    return message.Response;
                }
                else
                {
                    // This will change to message.Response.IsError in a later PR
                    if (!message.ResponseClassifier.IsErrorResponse(message))
                    {
                        return message.Response;
                    }
                    else
                    {
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetPet"/> and <see cref="GetPetAsync"/> operations. </summary>
        /// <param name="id"> Id of pet to return. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetPetRequest(string id, RequestContext context = null)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/pets/", false);
            uri.AppendPath(id, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            message.ResponseClassifier = Classifier200;
            return message;
        }

        private class ResponseClassifier200 : ResponseClassifier
        {
            public override bool IsErrorResponse(HttpMessage message)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return false;
                    default:
                        return true;
                }
            }
        }

        #region Prove LRO Grow-Up

        // Protocol method
        public virtual async Task<Operation<BinaryData>> ImportPetAsync(bool waitForCompletion, string species, RequestContext context = null)
        {
            using var scope = _clientDiagnostics.CreateScope("DeviceManagementClient.ImportDevices");
            scope.Start();
            try
            {
                using HttpMessage message = CreateImportPetRequest(species, context);
                return await LowLevelOperationHelpers.ProcessMessageAsync(_pipeline, message, _clientDiagnostics, "DeviceManagementClient.ImportDevices", OperationFinalStateVia.Location, context, waitForCompletion).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Grow-up method
        public virtual async Task<Operation<Pet>> ImportPetAsync(bool waitForCompletion, string species, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeviceManagementClient.ImportDevices");
            scope.Start();
            try
            {
                using HttpMessage message = CreateImportPetRequest(species, quantity, context);
                return await LowLevelOperationHelpers.ProcessMessageAsync(_pipeline, message, _clientDiagnostics, "DeviceManagementClient.ImportDevices", OperationFinalStateVia.Location, context, waitForCompletion).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateImportPetRequest(string species, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_endpoint.ToString(), false);
            uri.AppendPath("/pets/import", false);
            uri.AppendQuery("species", species, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier202.Instance;
            return message;
        }

        private sealed class ResponseClassifier202 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier202();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    202 => false,
                    _ => true
                };
            }
        }
        #endregion
    }
}
