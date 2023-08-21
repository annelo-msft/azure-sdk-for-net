// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SynapseServerSecurityAlertPolicyListResult
    {
        internal static SynapseServerSecurityAlertPolicyListResult DeserializeSynapseServerSecurityAlertPolicyListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<SynapseServerSecurityAlertPolicyData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseServerSecurityAlertPolicyData> array = new List<SynapseServerSecurityAlertPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseServerSecurityAlertPolicyData.DeserializeSynapseServerSecurityAlertPolicyData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SynapseServerSecurityAlertPolicyListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
