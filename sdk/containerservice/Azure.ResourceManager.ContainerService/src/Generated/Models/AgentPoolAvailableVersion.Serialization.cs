// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class AgentPoolAvailableVersion
    {
        internal static AgentPoolAvailableVersion DeserializeAgentPoolAvailableVersion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> @default = default;
            Core.Optional<string> kubernetesVersion = default;
            Core.Optional<bool> isPreview = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @default = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kubernetesVersion"u8))
                {
                    kubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPreview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AgentPoolAvailableVersion(Core.Optional.ToNullable(@default), kubernetesVersion.Value, Core.Optional.ToNullable(isPreview));
        }
    }
}
