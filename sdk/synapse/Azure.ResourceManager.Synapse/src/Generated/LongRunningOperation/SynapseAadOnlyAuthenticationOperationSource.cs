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

namespace Azure.ResourceManager.Synapse
{
    internal class SynapseAadOnlyAuthenticationOperationSource : Core.IOperationSource<SynapseAadOnlyAuthenticationResource>
    {
        private readonly ArmClient _client;

        internal SynapseAadOnlyAuthenticationOperationSource(ArmClient client)
        {
            _client = client;
        }

        SynapseAadOnlyAuthenticationResource Core.IOperationSource<SynapseAadOnlyAuthenticationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SynapseAadOnlyAuthenticationData.DeserializeSynapseAadOnlyAuthenticationData(document.RootElement);
            return new SynapseAadOnlyAuthenticationResource(_client, data);
        }

        async ValueTask<SynapseAadOnlyAuthenticationResource> Core.IOperationSource<SynapseAadOnlyAuthenticationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SynapseAadOnlyAuthenticationData.DeserializeSynapseAadOnlyAuthenticationData(document.RootElement);
            return new SynapseAadOnlyAuthenticationResource(_client, data);
        }
    }
}
