// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="SharedGalleryImageResource" /> and their operations.
    /// Each <see cref="SharedGalleryImageResource" /> in the collection will belong to the same instance of <see cref="SharedGalleryResource" />.
    /// To get a <see cref="SharedGalleryImageCollection" /> instance call the GetSharedGalleryImages method from an instance of <see cref="SharedGalleryResource" />.
    /// </summary>
    public partial class SharedGalleryImageCollection : ArmCollection, IEnumerable<SharedGalleryImageResource>, IAsyncEnumerable<SharedGalleryImageResource>
    {
        private readonly ClientDiagnostics _sharedGalleryImageClientDiagnostics;
        private readonly SharedGalleryImagesRestOperations _sharedGalleryImageRestClient;

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryImageCollection"/> class for mocking. </summary>
        protected SharedGalleryImageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryImageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SharedGalleryImageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sharedGalleryImageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", SharedGalleryImageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SharedGalleryImageResource.ResourceType, out string sharedGalleryImageApiVersion);
            _sharedGalleryImageRestClient = new SharedGalleryImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sharedGalleryImageApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SharedGalleryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SharedGalleryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a shared gallery image by subscription id or tenant id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual async Task<Response<SharedGalleryImageResource>> GetAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageCollection.Get");
            scope.Start();
            try
            {
                var response = await _sharedGalleryImageRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, galleryImageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = SharedGalleryImageResource.CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, galleryImageName);
                return Response.FromValue(new SharedGalleryImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a shared gallery image by subscription id or tenant id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<SharedGalleryImageResource> Get(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageCollection.Get");
            scope.Start();
            try
            {
                var response = _sharedGalleryImageRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, galleryImageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = SharedGalleryImageResource.CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, galleryImageName);
                return Response.FromValue(new SharedGalleryImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List shared gallery images by subscription id or tenant id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SharedGalleryImageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SharedGalleryImageResource> GetAllAsync(SharedToValue? sharedTo = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sharedGalleryImageRestClient.CreateListRequest(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, sharedTo);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sharedGalleryImageRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, sharedTo);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SharedGalleryImageResource(Client, SharedGalleryImageData.DeserializeSharedGalleryImageData(e)), _sharedGalleryImageClientDiagnostics, Pipeline, "SharedGalleryImageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List shared gallery images by subscription id or tenant id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SharedGalleryImageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SharedGalleryImageResource> GetAll(SharedToValue? sharedTo = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sharedGalleryImageRestClient.CreateListRequest(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, sharedTo);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sharedGalleryImageRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, sharedTo);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SharedGalleryImageResource(Client, SharedGalleryImageData.DeserializeSharedGalleryImageData(e)), _sharedGalleryImageClientDiagnostics, Pipeline, "SharedGalleryImageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sharedGalleryImageRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, galleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<bool> Exists(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _sharedGalleryImageClientDiagnostics.CreateScope("SharedGalleryImageCollection.Exists");
            scope.Start();
            try
            {
                var response = _sharedGalleryImageRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, galleryImageName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SharedGalleryImageResource> IEnumerable<SharedGalleryImageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SharedGalleryImageResource> IAsyncEnumerable<SharedGalleryImageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
