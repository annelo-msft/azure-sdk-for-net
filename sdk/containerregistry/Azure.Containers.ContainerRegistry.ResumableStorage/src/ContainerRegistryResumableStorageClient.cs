// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Containers.ContainerRegistry.ResumableStorage
{
    /// <summary> The RepositoryStorageClient service client. </summary>
    public partial class ContainerRegistryResumableStorageClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;

        internal ContainerRegistryBlobRestClient RestClient { get; }

        // TODO: Update swagger to put these methods all in once place automatically through code gen, e.g. GetManifest and CreateManifest
        internal ContainerRegistryRepositoryRestClient RepositoryRestClient { get; }

        // Name of the image (including the namespace).
        private string _repositoryName;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRegistryClient"/>.
        /// </summary>
        public ContainerRegistryResumableStorageClient(Uri endpoint, string repositoryName, TokenCredential credential) : this(endpoint, repositoryName, credential, new ContainerRegistryClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRegistryClient"/>.
        /// </summary>
        public ContainerRegistryResumableStorageClient(Uri endpoint, string repositoryName, TokenCredential credential, ContainerRegistryClientOptions options)
        {
            _repositoryName = repositoryName;
        }

        public ContainerRegistryResumableStorageClient(Uri endpoint, string repositoryName, ContainerRegistryUserCredential credential) : this(endpoint, repositoryName, credential, new ContainerRegistryClientOptions())
        {
        }

        public ContainerRegistryResumableStorageClient(Uri endpoint, string repositoryName, ContainerRegistryUserCredential credential, ContainerRegistryClientOptions options)
        {
            _repositoryName = repositoryName;
        }

        public ContainerRegistryResumableStorageClient(Uri endpoint, string repositoryName) : this(endpoint, repositoryName, new ContainerRegistryClientOptions())
        {
        }

        public ContainerRegistryResumableStorageClient(Uri endpoint, string repositoryName, ContainerRegistryClientOptions options)
        {
            _repositoryName = repositoryName;
        }

        /// <summary> Initializes a new instance of ContainerRegistryBlobClient for mocking. </summary>
        protected ContainerRegistryResumableStorageClient()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryBlobClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> Registry login URL. </param>
        internal ContainerRegistryResumableStorageClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url)
        {
            RestClient = new ContainerRegistryBlobRestClient(clientDiagnostics, pipeline, url);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        // TODO: Confirm in FDG that IEnumerable is how to model this input collection
        /// <summary> Get the manifest identified by `name` and `reference` where `reference` can be a tag or digest. </summary>        
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ImageManifest>> GetManifestAsync(string reference, IEnumerable<ManifestMediaType> acceptMediaTypes = null, CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();
            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.GetManifest");
            //scope.Start();

            //// <param name="acceptMediaType"> Accept header string delimited by comma. For example, application/vnd.docker.distribution.manifest.v2+json. </param>
            ////TODO: pull media types from collection and create comma-delimited string.
            //string accept = string.Empty; // = CreateCommaDelimitedString(acceptMediaTypes)
            //// TODO: what is default behavior if accept it null/list is empty?

            //try
            //{
            //    return await RepositoryRestClient.GetManifestAsync(_repositoryName, tagOrDigest, accept, cancellationToken).ConfigureAwait(false);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        /// <summary> Get the manifest identified by `name` and `reference` where `reference` can be a tag or digest. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ImageManifest> GetManifest(string reference, IEnumerable<ManifestMediaType> acceptMediaTypes = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.GetManifest");
            //scope.Start();

            //// <param name="acceptMediaType"> Accept header string delimited by comma. For example, application/vnd.docker.distribution.manifest.v2+json. </param>
            ////TODO: pull media types from collection and create comma-delimited string.
            //string accept = string.Empty; // = CreateCommaDelimitedString(acceptMediaTypes)
            //// TODO: what is default behavior if accept it null/list is empty?
            //try
            //{
            //    return RepositoryRestClient.GetManifest(_repositoryName, tagOrDigest, accept, cancellationToken);
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        /// <summary> Put the manifest identified by tag. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CreateManifestResult>> CreateManifestAsync(string tag, ImageManifest manifest, CancellationToken cancellationToken = default)
        {
            // TODO: How should we handle the accept header?  This feels like part of the polymorphic/strong-typing story around manifests
            ///// <param name="payload"> Manifest body, can take v1 or v2 values depending on accept header. </param>

            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.CreateManifest");
            scope.Start();
            try
            {
                ResponseWithHeaders<object, ContainerRegistryRepositoryCreateManifestHeaders> response = await RepositoryRestClient.CreateManifestAsync(_repositoryName, tag, manifest, cancellationToken).ConfigureAwait(false);

                // TODO: Validate Digest here:
                // throw new InvalidDigestException, or other "content tampered" exception here.

                return Response.FromValue(
                    new CreateManifestResult(
                        response.Headers.DockerContentDigest,
                        response.Headers.Location,
                        response.Headers.ContentLength.Value), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put the manifest identified by tag. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CreateManifestResult> CreateManifest(string tag, ImageManifest manifest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.CreateManifest");
            scope.Start();
            try
            {
                ResponseWithHeaders<object, ContainerRegistryRepositoryCreateManifestHeaders> response = RepositoryRestClient.CreateManifest(_repositoryName, tag, manifest, cancellationToken);

                // TODO: Validate Digest here:
                // throw new InvalidDigestException, or other "content tampered" exception here.

                return Response.FromValue(
                    new CreateManifestResult(
                        response.Headers.DockerContentDigest,
                        response.Headers.Location,
                        response.Headers.ContentLength.Value), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put the manifest identified by digest. </summary>

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CreateManifestResult>> CreateManifestAsync(ImageManifest manifest, CancellationToken cancellationToken = default)
        {
            // TODO: How should we handle the accept header?  This feels like part of the polymorphic/strong-typing story around manifests
            ///// <param name="payload"> Manifest body, can take v1 or v2 values depending on accept header. </param>

            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.CreateManifest");
            scope.Start();
            try
            {
                ResponseWithHeaders<object, ContainerRegistryRepositoryCreateManifestHeaders> response = await RepositoryRestClient.CreateManifestAsync(_repositoryName, manifest.Digest, manifest, cancellationToken).ConfigureAwait(false);

                // TODO: Validate Digest here:
                // throw new InvalidDigestException, or other "content tampered" exception here.

                return Response.FromValue(
                    new CreateManifestResult(
                        response.Headers.DockerContentDigest,
                        response.Headers.Location,
                        response.Headers.ContentLength.Value), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put the manifest identified by `name` and `reference` where `reference` can be a tag or digest. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CreateManifestResult> CreateManifest(ImageManifest manifest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryRepositoryClient.CreateManifest");
            scope.Start();
            try
            {
                ResponseWithHeaders<object, ContainerRegistryRepositoryCreateManifestHeaders> response = RepositoryRestClient.CreateManifest(_repositoryName, manifest.Digest, manifest, cancellationToken);

                // TODO: Validate Digest here:
                // throw new InvalidDigestException, or other "content tampered" exception here.

                return Response.FromValue(
                    new CreateManifestResult(
                        response.Headers.DockerContentDigest,
                        response.Headers.Location,
                        response.Headers.ContentLength.Value), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve the blob from the registry identified by digest. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Stream>> GetBlobAsync(string digest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.GetBlob");
            scope.Start();
            try
            {
                return await RestClient.GetBlobAsync(_repositoryName, digest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve the blob from the registry identified by digest. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Stream> GetBlob(string digest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.GetBlob");
            scope.Start();
            try
            {
                return RestClient.GetBlob(_repositoryName, digest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Same as GET, except only the headers are returned. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckBlobExistsAsync(string digest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.CheckBlobExists");
            scope.Start();
            try
            {
                return (await RestClient.CheckBlobExistsAsync(_repositoryName, digest, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Same as GET, except only the headers are returned. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckBlobExists(string digest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.CheckBlobExists");
            scope.Start();
            try
            {
                return RestClient.CheckBlobExists(_repositoryName, digest, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes an already uploaded blob. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Stream>> DeleteBlobAsync(string digest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.DeleteBlob");
            scope.Start();
            try
            {
                return await RestClient.DeleteBlobAsync(_repositoryName, digest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes an already uploaded blob. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Stream> DeleteBlob(string digest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.DeleteBlob");
            scope.Start();
            try
            {
                return RestClient.DeleteBlob(_repositoryName, digest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Mount a blob identified by the `mount` parameter from another repository. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> MountBlobAsync(string sourceRepository, string blobDigest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.MountBlob");
            scope.Start();
            try
            {
                return (await RestClient.MountBlobAsync(_repositoryName, sourceRepository, blobDigest, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Mount a blob identified by the `mount` parameter from another repository. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response MountBlob(string sourceRepository, string blobDigest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.MountBlob");
            scope.Start();
            try
            {
                return RestClient.MountBlob(_repositoryName, sourceRepository, blobDigest, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve status of upload identified by uuid. The primary purpose of this endpoint is to resolve the current status of a resumable upload. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<UploadStatus>> GetUploadStatusAsync(string location, CancellationToken cancellationToken = default)
        {
            await Task.Delay(0, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();
            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.GetUploadStatus");
            //scope.Start();
            //try
            //{
            //    return (await RestClient.GetUploadStatusAsync(location, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        /// <summary> Retrieve status of upload identified by uuid. The primary purpose of this endpoint is to resolve the current status of a resumable upload. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<UploadStatus> GetUploadStatus(string location, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();

            //using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.GetUploadStatus");
            //scope.Start();
            //try
            //{
            //    return RestClient.GetUploadStatus(location, cancellationToken).GetRawResponse();
            //}
            //catch (Exception e)
            //{
            //    scope.Failed(e);
            //    throw;
            //}
        }

        //// See sample UploadBlobInOneRequest_Monolithic
        // NOTE: Not in swagger.
        //public virtual Response Upload(string digest, Stream value, CancellationToken cancellationToken = default)
        //{
        //    using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.Upload");
        //    scope.Start();
        //    try
        //    {
        //        return RestClient.(uploadDetails.BlobLocation.ToString(), value, cancellationToken).GetRawResponse();
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        /// <summary> Upload a stream of data without completing the upload. </summary>
        /// <param name="value"> Raw data of blob. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<UploadChunkResult>> UploadChunkAsync(CreateUploadResult uploadDetails, Stream value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.UploadChunk");
            scope.Start();
            try
            {
                ResponseWithHeaders<ContainerRegistryBlobUploadChunkHeaders> response = await RestClient.UploadChunkAsync(uploadDetails.Location.ToString(), value, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(
                    new UploadChunkResult(
                        response.Headers.Location.ToString(),
                        ParseHttpRange(response.Headers.Range),
                        new Guid(response.Headers.DockerUploadUuid)), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Upload a stream of data without completing the upload. </summary>
        /// <param name="value"> Raw data of blob. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CreateUploadResult> UploadChunk(CreateUploadResult uploadDetails, Stream value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.UploadChunk");
            scope.Start();
            try
            {
                ResponseWithHeaders<ContainerRegistryBlobUploadChunkHeaders> response = RestClient.UploadChunk(uploadDetails.Location.ToString(), value, cancellationToken);
                return Response.FromValue(
                   new CreateUploadResult(
                       response.Headers.Location.ToString(),
                       ParseHttpRange(response.Headers.Range),
                       new Guid(response.Headers.DockerUploadUuid)), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Complete the upload, providing all the data in the body, if necessary. A request without a body will just complete the upload with previously uploaded content. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CompleteUploadResult>> CompleteUploadAsync(CreateUploadResult uploadDetails, string digest, CancellationToken cancellationToken = default)
        {
            // /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>

            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.CompleteUpload");
            scope.Start();
            try
            {
                ResponseWithHeaders<ContainerRegistryBlobCompleteUploadHeaders> response = await RestClient.CompleteUploadAsync(digest, uploadDetails.Location.ToString(), null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(
                    new CompleteUploadResult(
                        response.Headers.Location.ToString(),
                        ParseHttpRange(response.Headers.Range),
                        response.Headers.DockerContentDigest), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Complete the upload, providing all the data in the body, if necessary. A request without a body will just complete the upload with previously uploaded content. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CompleteUploadResult> CompleteUpload(CreateUploadResult uploadDetails, string digest, CancellationToken cancellationToken = default)
        {
            // /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>

            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.CompleteUpload");
            scope.Start();
            try
            {
                // TODO: in this method call, we're validating that value is not null, but it is actually an optional 
                // parameter and should not be validated as null is a correct value.  How can we reflect this in the swagger?

                ResponseWithHeaders<ContainerRegistryBlobCompleteUploadHeaders> response = RestClient.CompleteUpload(digest, uploadDetails.Location.ToString(), null, cancellationToken);
                return Response.FromValue(
                    new CompleteUploadResult(
                        response.Headers.Location.ToString(),
                        ParseHttpRange(response.Headers.Range),
                        response.Headers.DockerContentDigest), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Complete the upload, providing all the data in the body, if necessary. A request without a body will just complete the upload with previously uploaded content. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>        
        /// <param name="value"> Raw data of final blob. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CompleteUploadResult>> CompleteUploadAsync(CreateUploadResult uploadDetails, string digest, Stream value, CancellationToken cancellationToken = default)
        {
            // /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>

            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.CompleteUpload");
            scope.Start();
            try
            {
                ResponseWithHeaders<ContainerRegistryBlobCompleteUploadHeaders> response = await RestClient.CompleteUploadAsync(digest, uploadDetails.Location.ToString(), value, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(
                    new CompleteUploadResult(
                        response.Headers.Location.ToString(),
                        ParseHttpRange(response.Headers.Range),
                        response.Headers.DockerContentDigest), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private HttpRange ParseHttpRange(string rangeHeaderValue)
        {
            throw new NotImplementedException();
        }

        /// <summary> Complete the upload, providing all the data in the body, if necessary. A request without a body will just complete the upload with previously uploaded content. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="value"> Raw data of final blob. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CompleteUploadResult> CompleteUpload(CreateUploadResult uploadDetails, string digest, Stream value, CancellationToken cancellationToken = default)
        {
            // /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>

            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.CompleteUpload");
            scope.Start();
            try
            {
                // TODO: in this method call, we're validating that value is not null, but it is actually an optional 
                // parameter and should not be validated as null is a correct value.  How can we reflect this in the swagger?

                ResponseWithHeaders<ContainerRegistryBlobCompleteUploadHeaders> response = RestClient.CompleteUpload(digest, uploadDetails.Location.ToString(), value, cancellationToken);
                return Response.FromValue(
                    new CompleteUploadResult(
                        response.Headers.Location.ToString(),
                        ParseHttpRange(response.Headers.Range),
                        response.Headers.DockerContentDigest), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel outstanding upload processes, releasing associated resources. If this is not called, the unfinished uploads will eventually timeout. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelUploadAsync(string location, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.CancelUpload");
            scope.Start();
            try
            {
                return await RestClient.CancelUploadAsync(location, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel outstanding upload processes, releasing associated resources. If this is not called, the unfinished uploads will eventually timeout. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CancelUpload(string location, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.CancelUpload");
            scope.Start();
            try
            {
                return RestClient.CancelUpload(location, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // TODO: Naming here - usually Create takes an instance of the resource to create - we're asking the service to create 
        // one for us from scratch - like getting a ticket we'll use elsewhere.  Do we have a pattern for this elsewhere?
        /// <summary> Initiate a resumable blob upload with an empty request body. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CreateUploadResult>> CreateUploadAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.StartUpload");
            scope.Start();
            try
            {
                // Note: content length header has got to be 0 in order to start the upload
                // See: Initiate Resumable Blob Upload
                // in: https://docs.docker.com/registry/spec/api/#initiate-blob-upload
                // TODO: doesn't look like we're doing this - does the service support not setting the header if the body has no content?
                ResponseWithHeaders<ContainerRegistryBlobStartUploadHeaders> response = await RestClient.StartUploadAsync(_repositoryName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CreateUploadResult(
                    response.Headers.Location,
                    ParseHttpRange(response.Headers.Range),
                    new Guid(response.Headers.DockerUploadUuid)), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Initiate a resumable blob upload with an empty request body. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CreateUploadResult> CreateUpload(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.StartUpload");
            scope.Start();
            try
            {
                ResponseWithHeaders<ContainerRegistryBlobStartUploadHeaders> response = RestClient.StartUpload(_repositoryName, cancellationToken);
                return Response.FromValue(new CreateUploadResult(
                    response.Headers.Location,
                    ParseHttpRange(response.Headers.Range),
                    new Guid(response.Headers.DockerUploadUuid)), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve the blob from the registry identified by `digest`. This endpoint may also support RFC7233 compliant range requests. Support can be detected by issuing a HEAD request. If the header `Accept-Range: bytes` is returned, range requests can be used to fetch partial content. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="range"> Format : bytes=&lt;start&gt;-&lt;end&gt;,  HTTP Range header specifying blob chunk. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Stream>> GetChunkAsync(string digest, HttpRange range, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.GetChunk");
            scope.Start();
            try
            {
                // TODO: may need to add extension method ToString() to HttpRange
                return await RestClient.GetChunkAsync(_repositoryName, digest, range.ToString(), cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve the blob from the registry identified by `digest`. This endpoint may also support RFC7233 compliant range requests. Support can be detected by issuing a HEAD request. If the header `Accept-Range: bytes` is returned, range requests can be used to fetch partial content. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="range"> Format : bytes=&lt;start&gt;-&lt;end&gt;,  HTTP Range header specifying blob chunk. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Stream> GetChunk(string digest, HttpRange range, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.GetChunk");
            scope.Start();
            try
            {
                return RestClient.GetChunk(_repositoryName, digest, range.ToString(), cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Same as GET, except only the headers are returned. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="range"> Format : bytes=&lt;start&gt;-&lt;end&gt;,  HTTP Range header specifying blob chunk. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckChunkExistsAsync(string digest, HttpRange range, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.CheckChunkExists");
            scope.Start();
            try
            {
                return (await RestClient.CheckChunkExistsAsync(_repositoryName, digest, range.ToString(), cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Same as GET, except only the headers are returned. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="range"> Format : bytes=&lt;start&gt;-&lt;end&gt;,  HTTP Range header specifying blob chunk. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckChunkExists(string digest, HttpRange range, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ContainerRegistryBlobClient.CheckChunkExists");
            scope.Start();
            try
            {
                return RestClient.CheckChunkExists(_repositoryName, digest, range.ToString(), cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
