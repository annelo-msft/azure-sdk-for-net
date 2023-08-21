// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    internal class GalleryApplicationOperationSource : Core.IOperationSource<GalleryApplicationResource>
    {
        private readonly ArmClient _client;

        internal GalleryApplicationOperationSource(ArmClient client)
        {
            _client = client;
        }

        GalleryApplicationResource Core.IOperationSource<GalleryApplicationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = GalleryApplicationData.DeserializeGalleryApplicationData(document.RootElement);
            return new GalleryApplicationResource(_client, data);
        }

        async ValueTask<GalleryApplicationResource> Core.IOperationSource<GalleryApplicationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = GalleryApplicationData.DeserializeGalleryApplicationData(document.RootElement);
            return new GalleryApplicationResource(_client, data);
        }
    }
}
