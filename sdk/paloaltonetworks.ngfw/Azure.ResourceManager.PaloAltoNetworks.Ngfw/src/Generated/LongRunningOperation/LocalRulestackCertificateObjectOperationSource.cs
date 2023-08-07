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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    internal class LocalRulestackCertificateObjectOperationSource : IOperationSource<LocalRulestackCertificateObjectResource>
    {
        private readonly ArmClient _client;

        internal LocalRulestackCertificateObjectOperationSource(ArmClient client)
        {
            _client = client;
        }

        LocalRulestackCertificateObjectResource IOperationSource<LocalRulestackCertificateObjectResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LocalRulestackCertificateObjectData.DeserializeLocalRulestackCertificateObjectData(document.RootElement);
            return new LocalRulestackCertificateObjectResource(_client, data);
        }

        async ValueTask<LocalRulestackCertificateObjectResource> IOperationSource<LocalRulestackCertificateObjectResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LocalRulestackCertificateObjectData.DeserializeLocalRulestackCertificateObjectData(document.RootElement);
            return new LocalRulestackCertificateObjectResource(_client, data);
        }
    }
}
