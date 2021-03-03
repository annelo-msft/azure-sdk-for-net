// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Authentication
{
    internal class ContainerRegistryBlobStartUploadHeaders
    {
        private readonly Response _response;
        public ContainerRegistryBlobStartUploadHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Provided location for blob. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
        /// <summary> Range indicating the current progress of the upload. </summary>
        public string Range => _response.Headers.TryGetValue("Range", out string value) ? value : null;
        /// <summary> Identifies the docker upload uuid for the current request. </summary>
        public string DockerUploadUuid => _response.Headers.TryGetValue("Docker-Upload-UUID", out string value) ? value : null;
    }
}
