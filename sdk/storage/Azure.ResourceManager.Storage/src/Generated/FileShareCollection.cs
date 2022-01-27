// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing collection of FileShare and their operations over its parent. </summary>
    public partial class FileShareCollection : ArmCollection, IEnumerable<FileShare>, IAsyncEnumerable<FileShare>
    {
        private readonly ClientDiagnostics _fileShareClientDiagnostics;
        private readonly FileSharesRestOperations _fileShareRestClient;

        /// <summary> Initializes a new instance of the <see cref="FileShareCollection"/> class for mocking. </summary>
        protected FileShareCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FileShareCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FileShareCollection(ArmResource parent) : base(parent)
        {
            _fileShareClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Storage", FileShare.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(FileShare.ResourceType, out string fileShareApiVersion);
            _fileShareRestClient = new FileSharesRestOperations(_fileShareClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, fileShareApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FileService.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FileService.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a new share under the specified account as described by request body. The share resource includes metadata and properties for that share. It does not include a list of the files contained by the share. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="fileShare"> Properties of the file share to create. </param>
        /// <param name="expand"> Optional, used to expand the properties within share&apos;s properties. Valid values are: snapshots. Should be passed as a string with delimiter &apos;,&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> or <paramref name="fileShare"/> is null. </exception>
        public virtual FileShareCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string shareName, FileShareData fileShare, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareName, nameof(shareName));
            if (fileShare == null)
            {
                throw new ArgumentNullException(nameof(fileShare));
            }

            using var scope = _fileShareClientDiagnostics.CreateScope("FileShareCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _fileShareRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, shareName, fileShare, expand, cancellationToken);
                var operation = new FileShareCreateOrUpdateOperation(ArmClient, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new share under the specified account as described by request body. The share resource includes metadata and properties for that share. It does not include a list of the files contained by the share. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="fileShare"> Properties of the file share to create. </param>
        /// <param name="expand"> Optional, used to expand the properties within share&apos;s properties. Valid values are: snapshots. Should be passed as a string with delimiter &apos;,&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> or <paramref name="fileShare"/> is null. </exception>
        public async virtual Task<FileShareCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string shareName, FileShareData fileShare, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareName, nameof(shareName));
            if (fileShare == null)
            {
                throw new ArgumentNullException(nameof(fileShare));
            }

            using var scope = _fileShareClientDiagnostics.CreateScope("FileShareCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _fileShareRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, shareName, fileShare, expand, cancellationToken).ConfigureAwait(false);
                var operation = new FileShareCreateOrUpdateOperation(ArmClient, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets properties of a specified share. </summary>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="expand"> Optional, used to expand the properties within share&apos;s properties. Valid values are: stats. Should be passed as a string with delimiter &apos;,&apos;. </param>
        /// <param name="xMsSnapshot"> Optional, used to retrieve properties of a snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> is null. </exception>
        public virtual Response<FileShare> Get(string shareName, string expand = null, string xMsSnapshot = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareName, nameof(shareName));

            using var scope = _fileShareClientDiagnostics.CreateScope("FileShareCollection.Get");
            scope.Start();
            try
            {
                var response = _fileShareRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, shareName, expand, xMsSnapshot, cancellationToken);
                if (response.Value == null)
                    throw _fileShareClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FileShare(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets properties of a specified share. </summary>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="expand"> Optional, used to expand the properties within share&apos;s properties. Valid values are: stats. Should be passed as a string with delimiter &apos;,&apos;. </param>
        /// <param name="xMsSnapshot"> Optional, used to retrieve properties of a snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> is null. </exception>
        public async virtual Task<Response<FileShare>> GetAsync(string shareName, string expand = null, string xMsSnapshot = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareName, nameof(shareName));

            using var scope = _fileShareClientDiagnostics.CreateScope("FileShareCollection.Get");
            scope.Start();
            try
            {
                var response = await _fileShareRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, shareName, expand, xMsSnapshot, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _fileShareClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FileShare(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="expand"> Optional, used to expand the properties within share&apos;s properties. Valid values are: stats. Should be passed as a string with delimiter &apos;,&apos;. </param>
        /// <param name="xMsSnapshot"> Optional, used to retrieve properties of a snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> is null. </exception>
        public virtual Response<FileShare> GetIfExists(string shareName, string expand = null, string xMsSnapshot = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareName, nameof(shareName));

            using var scope = _fileShareClientDiagnostics.CreateScope("FileShareCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _fileShareRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, shareName, expand, xMsSnapshot, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<FileShare>(null, response.GetRawResponse());
                return Response.FromValue(new FileShare(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="expand"> Optional, used to expand the properties within share&apos;s properties. Valid values are: stats. Should be passed as a string with delimiter &apos;,&apos;. </param>
        /// <param name="xMsSnapshot"> Optional, used to retrieve properties of a snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> is null. </exception>
        public async virtual Task<Response<FileShare>> GetIfExistsAsync(string shareName, string expand = null, string xMsSnapshot = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareName, nameof(shareName));

            using var scope = _fileShareClientDiagnostics.CreateScope("FileShareCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _fileShareRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, shareName, expand, xMsSnapshot, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<FileShare>(null, response.GetRawResponse());
                return Response.FromValue(new FileShare(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="expand"> Optional, used to expand the properties within share&apos;s properties. Valid values are: stats. Should be passed as a string with delimiter &apos;,&apos;. </param>
        /// <param name="xMsSnapshot"> Optional, used to retrieve properties of a snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> is null. </exception>
        public virtual Response<bool> Exists(string shareName, string expand = null, string xMsSnapshot = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareName, nameof(shareName));

            using var scope = _fileShareClientDiagnostics.CreateScope("FileShareCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(shareName, expand, xMsSnapshot, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="shareName"> The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="expand"> Optional, used to expand the properties within share&apos;s properties. Valid values are: stats. Should be passed as a string with delimiter &apos;,&apos;. </param>
        /// <param name="xMsSnapshot"> Optional, used to retrieve properties of a snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="shareName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string shareName, string expand = null, string xMsSnapshot = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(shareName, nameof(shareName));

            using var scope = _fileShareClientDiagnostics.CreateScope("FileShareCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(shareName, expand, xMsSnapshot, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all shares. </summary>
        /// <param name="maxpagesize"> Optional. Specified maximum number of shares that can be included in the list. </param>
        /// <param name="filter"> Optional. When specified, only share names starting with the filter will be listed. </param>
        /// <param name="expand"> Optional, used to expand the properties within share&apos;s properties. Valid values are: deleted, snapshots. Should be passed as a string with delimiter &apos;,&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FileShare" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FileShare> GetAll(string maxpagesize = null, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Page<FileShare> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _fileShareClientDiagnostics.CreateScope("FileShareCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _fileShareRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, maxpagesize, filter, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FileShare(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FileShare> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _fileShareClientDiagnostics.CreateScope("FileShareCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _fileShareRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, maxpagesize, filter, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FileShare(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all shares. </summary>
        /// <param name="maxpagesize"> Optional. Specified maximum number of shares that can be included in the list. </param>
        /// <param name="filter"> Optional. When specified, only share names starting with the filter will be listed. </param>
        /// <param name="expand"> Optional, used to expand the properties within share&apos;s properties. Valid values are: deleted, snapshots. Should be passed as a string with delimiter &apos;,&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FileShare" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FileShare> GetAllAsync(string maxpagesize = null, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<FileShare>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _fileShareClientDiagnostics.CreateScope("FileShareCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _fileShareRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, maxpagesize, filter, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FileShare(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FileShare>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _fileShareClientDiagnostics.CreateScope("FileShareCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _fileShareRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, maxpagesize, filter, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FileShare(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<FileShare> IEnumerable<FileShare>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FileShare> IAsyncEnumerable<FileShare>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
