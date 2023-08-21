// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class AgentPoolUpgradeSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(MaxSurge))
            {
                writer.WritePropertyName("maxSurge"u8);
                writer.WriteStringValue(MaxSurge);
            }
            writer.WriteEndObject();
        }

        internal static AgentPoolUpgradeSettings DeserializeAgentPoolUpgradeSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> maxSurge = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxSurge"u8))
                {
                    maxSurge = property.Value.GetString();
                    continue;
                }
            }
            return new AgentPoolUpgradeSettings(maxSurge.Value);
        }
    }
}
