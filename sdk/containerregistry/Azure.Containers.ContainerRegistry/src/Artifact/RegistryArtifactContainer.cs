// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary>
    /// </summary>
    public class RegistryArtifactContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics = new ClientDiagnostics(null);
        private readonly ContainerRegistryRestClient _restClient = new ContainerRegistryRestClient(null, null, null);

        private readonly Uri _registryEndpoint = new Uri(null);
        private readonly string _name = string.Empty;

        /// <summary>
        /// Gets the Registry Uri.
        /// </summary>
        public virtual Uri RegistryEndpoint => _registryEndpoint;

        /// <summary>
        /// Gets the name of the repository.
        /// </summary>
        public virtual string Name => _name;

        /// <summary>
        /// </summary>
        private RegistryArtifactContainer(Uri registryEndpoint, ClientDiagnostics clientDiagnostics, ContainerRegistryRestClient restClient)
        {
            _registryEndpoint = registryEndpoint;

            _clientDiagnostics = clientDiagnostics;
            _restClient = restClient;
        }

        /// <summary> List the manifests associated with this repository and the properties of each.
        /// This is useful for determining the collection of artifacts associated with this repository, as each artifact is uniquely identified by its manifest. </summary>
        /// <param name="orderBy"> Requested order of manifests in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Container Registry service.</exception>
        public virtual AsyncPageable<ArtifactManifestProperties> GetArtifactPropertiesCollectionAsync(ArtifactManifestOrderBy orderBy = ArtifactManifestOrderBy.None, CancellationToken cancellationToken = default)
        {
            async Task<Page<ArtifactManifestProperties>> FirstPageFunc(int? pageSizeHint)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(ContainerRepositoryOperations)}.{nameof(GetArtifactPropertiesCollection)}");
                scope.Start();
                try
                {
                    string order = orderBy == ArtifactManifestOrderBy.None ? null : orderBy.ToSerialString();
                    var response = await _restClient.GetManifestsAsync(Name, last: null, n: pageSizeHint, orderby: order, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.RegistryArtifacts, response.Headers.Link, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            async Task<Page<ArtifactManifestProperties>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(ContainerRepositoryOperations)}.{nameof(GetArtifactPropertiesCollection)}");
                scope.Start();
                try
                {
                    string order = orderBy == ArtifactManifestOrderBy.None ? null : orderBy.ToSerialString();
                    string uriReference = ContainerRegistryOperations.ParseUriReferenceFromLinkHeader(nextLink);
                    var response = await _restClient.GetManifestsNextPageAsync(uriReference, Name, last: null, n: null, orderby: order, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.RegistryArtifacts, response.Headers.Link, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List the manifests associated with this repository and the properties of each.
        /// This is useful for determining the collection of artifacts associated with this repository, as each artifact is uniquely identified by its manifest. </summary>
        /// <param name="orderBy"> Requested order of manifests in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">Thrown when a failure is returned by the Container Registry service.</exception>
        public virtual Pageable<ArtifactManifestProperties> GetArtifactPropertiesCollection(ArtifactManifestOrderBy orderBy = ArtifactManifestOrderBy.None, CancellationToken cancellationToken = default)
        {
            Page<ArtifactManifestProperties> FirstPageFunc(int? pageSizeHint)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(ContainerRepositoryOperations)}.{nameof(GetArtifactPropertiesCollection)}");
                scope.Start();
                try
                {
                    string order = orderBy == ArtifactManifestOrderBy.None ? null : orderBy.ToSerialString();
                    var response = _restClient.GetManifests(Name, last: null, n: pageSizeHint, orderby: order, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.RegistryArtifacts, response.Headers.Link, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            Page<ArtifactManifestProperties> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(ContainerRepositoryOperations)}.{nameof(GetArtifactPropertiesCollection)}");
                scope.Start();
                try
                {
                    string order = orderBy == ArtifactManifestOrderBy.None ? null : orderBy.ToSerialString();
                    string uriReference = ContainerRegistryOperations.ParseUriReferenceFromLinkHeader(nextLink);
                    var response = _restClient.GetManifestsNextPage(uriReference, Name, last: null, n: null, orderby: order, cancellationToken);
                    return Page.FromValues(response.Value.RegistryArtifacts, response.Headers.Link, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
