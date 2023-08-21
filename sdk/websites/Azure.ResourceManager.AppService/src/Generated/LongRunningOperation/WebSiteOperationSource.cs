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

namespace Azure.ResourceManager.AppService
{
    internal class WebSiteOperationSource : Core.IOperationSource<WebSiteResource>
    {
        private readonly ArmClient _client;

        internal WebSiteOperationSource(ArmClient client)
        {
            _client = client;
        }

        WebSiteResource Core.IOperationSource<WebSiteResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = WebSiteData.DeserializeWebSiteData(document.RootElement);
            return new WebSiteResource(_client, data);
        }

        async ValueTask<WebSiteResource> Core.IOperationSource<WebSiteResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = WebSiteData.DeserializeWebSiteData(document.RootElement);
            return new WebSiteResource(_client, data);
        }
    }
}
