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
    internal class KpiResourceFormatOperationSource : Core.IOperationSource<KpiResourceFormatResource>
    {
        private readonly ArmClient _client;

        internal KpiResourceFormatOperationSource(ArmClient client)
        {
            _client = client;
        }

        KpiResourceFormatResource Core.IOperationSource<KpiResourceFormatResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = KpiResourceFormatData.DeserializeKpiResourceFormatData(document.RootElement);
            return new KpiResourceFormatResource(_client, data);
        }

        async ValueTask<KpiResourceFormatResource> Core.IOperationSource<KpiResourceFormatResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = KpiResourceFormatData.DeserializeKpiResourceFormatData(document.RootElement);
            return new KpiResourceFormatResource(_client, data);
        }
    }
}
