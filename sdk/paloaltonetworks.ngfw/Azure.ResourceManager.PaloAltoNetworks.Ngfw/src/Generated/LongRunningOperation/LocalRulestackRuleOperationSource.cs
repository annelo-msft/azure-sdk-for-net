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
    internal class LocalRulestackRuleOperationSource : IOperationSource<LocalRulestackRuleResource>
    {
        private readonly ArmClient _client;

        internal LocalRulestackRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        LocalRulestackRuleResource IOperationSource<LocalRulestackRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LocalRulestackRuleData.DeserializeLocalRulestackRuleData(document.RootElement);
            return new LocalRulestackRuleResource(_client, data);
        }

        async ValueTask<LocalRulestackRuleResource> IOperationSource<LocalRulestackRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LocalRulestackRuleData.DeserializeLocalRulestackRuleData(document.RootElement);
            return new LocalRulestackRuleResource(_client, data);
        }
    }
}
