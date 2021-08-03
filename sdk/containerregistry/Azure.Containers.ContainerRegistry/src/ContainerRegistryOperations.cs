// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The Azure Container Registry service client. </summary>
    public partial class ContainerRegistryOperations
    {
        private readonly Uri _endpoint;
        private readonly string _registryName;
        private readonly HttpPipeline _pipeline;
        private readonly HttpPipeline _acrAuthPipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ContainerRegistryRestClient _restClient;
        private readonly AuthenticationRestClient _acrAuthClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRegistryOperations"/> for managing container images and artifacts,
        /// using anonymous access to the registry.  Only operations that support anonymous access are enabled.  Other service
        /// methods will throw <see cref="RequestFailedException"/> if called from this client.
        /// </summary>
        /// <param name="endpoint">The URI endpoint of the container registry.  This is likely to be similar
        /// to "https://{registry-name}.azurecr.io".</param>
        /// <exception cref="ArgumentNullException"> Thrown when the <paramref name="endpoint"/> is null. </exception>
        public ContainerRegistryOperations(Uri endpoint) : this(endpoint, new ContainerRegistryAnonymousAccessCredential(), new ContainerRegistryClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRegistryOperations"/> for managing container images and artifacts,
        /// using anonymous access to the registry.  Only operations that support anonymous access are enabled.  Other service
        /// methods will throw <see cref="RequestFailedException"/> if called from this client.
        /// </summary>
        /// <param name="endpoint">The URI endpoint of the container registry.  This is likely to be similar
        /// to "https://{registry-name}.azurecr.io".</param>
        /// <param name="options">Client configuration options for connecting to Azure Container Registry.</param>
        /// <exception cref="ArgumentNullException"> Thrown when the <paramref name="endpoint"/> is null. </exception>
        public ContainerRegistryOperations(Uri endpoint, ContainerRegistryClientOptions options) : this(endpoint, new ContainerRegistryAnonymousAccessCredential(), options)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRegistryOperations"/> for managing container images and artifacts.
        /// </summary>
        /// <param name="endpoint">The URI endpoint of the container registry.  This is likely to be similar
        /// to "https://{registry-name}.azurecr.io".</param>
        /// <param name="credential">The API key credential used to authenticate requests
        /// against the container registry.  </param>
        /// <exception cref="ArgumentNullException"> Thrown when the <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ContainerRegistryOperations(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new ContainerRegistryClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRegistryOperations"/> for managing container images and artifacts.
        /// </summary>
        /// <param name="endpoint">The URI endpoint of the container registry.  This is likely to be similar
        /// to "https://{registry-name}.azurecr.io".</param>
        /// <param name="credential">The API key credential used to authenticate requests
        /// against the container registry.  </param>
        /// <param name="options">Client configuration options for connecting to Azure Container Registry.</param>
        /// <exception cref="ArgumentNullException"> Thrown when the <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ContainerRegistryOperations(Uri endpoint, TokenCredential credential, ContainerRegistryClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(options, nameof(options));

            _endpoint = endpoint;
            _registryName = endpoint.Host.Split('.')[0];
            _clientDiagnostics = new ClientDiagnostics(options);

            _acrAuthPipeline = HttpPipelineBuilder.Build(options);
            _acrAuthClient = new AuthenticationRestClient(_clientDiagnostics, _acrAuthPipeline, endpoint.AbsoluteUri);

            _pipeline = HttpPipelineBuilder.Build(options, new ContainerRegistryChallengeAuthenticationPolicy(credential, options.AuthenticationScope, _acrAuthClient));
            _restClient = new ContainerRegistryRestClient(_clientDiagnostics, _pipeline, _endpoint.AbsoluteUri);
        }

        /// <summary> Initializes a new instance of RepositoryClient for mocking. </summary>
        protected ContainerRegistryOperations()
        {
        }

        /// <summary>
        /// Gets the registry service endpoint for this client.
        /// </summary>
        public virtual Uri Endpoint => _endpoint;

        internal static string ParseUriReferenceFromLinkHeader(string linkValue)
        {
            // Per the Docker v2 HTTP API spec, the Link header is an RFC5988
            // compliant rel='next' with URL to next result set, if available.
            // See: https://docs.docker.com/registry/spec/api/
            //
            // The URI reference can be obtained from link-value as follows:
            //   Link       = "Link" ":" #link-value
            //   link-value = "<" URI-Reference ">" * (";" link-param )
            // See: https://tools.ietf.org/html/rfc5988#section-5

            return linkValue?.Substring(1, linkValue.IndexOf('>') - 1);
        }

        /// <summary> Delete the repository identified by `repository` and all associated artifacts.</summary>
        /// <param name="repositoryName"> Repository name (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> Thrown when <paramref name="repositoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> Thrown when <paramref name="repositoryName"/> is empty. </exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Container Registry service.</exception>
        public virtual async Task<Response> DeleteRepositoryAsync(string repositoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repositoryName, nameof(repositoryName));

            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(ContainerRegistryOperations)}.{nameof(DeleteRepository)}");
            scope.Start();
            try
            {
                return await _restClient.DeleteRepositoryAsync(repositoryName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete the repository identified by `repository` and all associated artifacts.</summary>
        /// <param name="repositoryName"> Repository name (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> Thrown when <paramref name="repositoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> Thrown when <paramref name="repositoryName"/> is empty. </exception>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Container Registry service.</exception>
        public virtual Response DeleteRepository(string repositoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repositoryName, nameof(repositoryName));

            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(ContainerRegistryOperations)}.{nameof(DeleteRepository)}");
            scope.Start();
            try
            {
                return _restClient.DeleteRepository(repositoryName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a new <see cref="ContainerRepositoryOperations"/> object for calling service methods related to the repository specified by `repositoryName`.
        /// </summary>
        /// <param name="repositoryName"> The name of the repository to reference. </param>
        /// <returns> A new <see cref="ContainerRepositoryOperations"/> for the desired repository. </returns>
        /// <exception cref="ArgumentNullException"> Thrown when <paramref name="repositoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> Thrown when <paramref name="repositoryName"/> is empty. </exception>
        public virtual ContainerRepositoryOperations GetRepositoryClient(string repositoryName)
        {
            Argument.AssertNotNullOrEmpty(repositoryName, nameof(repositoryName));

            return new ContainerRepositoryOperations(
                _endpoint,
                repositoryName,
                _clientDiagnostics,
                _restClient);
        }

        /// <summary>
        /// Create a new <see cref="RegistryArtifactOperations"/> object for calling service methods related to the artifact specified by `repositoryName` and `tagOrDigest`.
        /// </summary>
        /// <param name="repositoryName"> The name of the repository to reference. </param>
        /// <param name="tagOrDigest"> Either a tag or a digest that uniquely identifies the artifact. </param>
        /// <returns> A new <see cref="RegistryArtifactOperations"/> for the desired repository. </returns>
        /// <exception cref="ArgumentNullException"> Thrown when <paramref name="repositoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> Thrown when <paramref name="repositoryName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> Thrown when <paramref name="tagOrDigest"/> is null. </exception>
        /// <exception cref="ArgumentException"> Thrown when <paramref name="tagOrDigest"/> is empty. </exception>
        public virtual RegistryArtifactOperations GetArtifactClient(string repositoryName, string tagOrDigest)
        {
            Argument.AssertNotNullOrEmpty(repositoryName, nameof(repositoryName));
            Argument.AssertNotNullOrEmpty(tagOrDigest, nameof(tagOrDigest));

            return new RegistryArtifactOperations(
                _endpoint,
                repositoryName,
                tagOrDigest,
                _clientDiagnostics,
                _restClient);
        }
    }
}
