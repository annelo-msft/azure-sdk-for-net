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

namespace Azure.ResourceManager.CustomerInsights
{
    internal class ConnectorResourceFormatOperationSource : Core.IOperationSource<ConnectorResourceFormatResource>
    {
        private readonly ArmClient _client;

        internal ConnectorResourceFormatOperationSource(ArmClient client)
        {
            _client = client;
        }

        ConnectorResourceFormatResource Core.IOperationSource<ConnectorResourceFormatResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ConnectorResourceFormatData.DeserializeConnectorResourceFormatData(document.RootElement);
            return new ConnectorResourceFormatResource(_client, data);
        }

        async ValueTask<ConnectorResourceFormatResource> Core.IOperationSource<ConnectorResourceFormatResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ConnectorResourceFormatData.DeserializeConnectorResourceFormatData(document.RootElement);
            return new ConnectorResourceFormatResource(_client, data);
        }
    }
}
