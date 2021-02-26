// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal class ContainerRegistryBlobMountBlobHeaders
    {
        private readonly Response _response;
        public ContainerRegistryBlobMountBlobHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Provided location for blob. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
        /// <summary> Identifies the docker upload uuid for the current request. </summary>
        public string DockerUploadUuid => _response.Headers.TryGetValue("Docker-Upload-UUID", out string value) ? value : null;
        /// <summary> Digest of the targeted content for the request. </summary>
        public string DockerContentDigest => _response.Headers.TryGetValue("Docker-Content-Digest", out string value) ? value : null;
    }
}
