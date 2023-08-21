// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class LinkedIntegrationRuntime
    {
        internal static LinkedIntegrationRuntime DeserializeLinkedIntegrationRuntime(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<string> subscriptionId = default;
            Core.Optional<string> dataFactoryName = default;
            Core.Optional<AzureLocation> dataFactoryLocation = default;
            Core.Optional<DateTimeOffset> createTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFactoryName"u8))
                {
                    dataFactoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFactoryLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFactoryLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new LinkedIntegrationRuntime(name.Value, subscriptionId.Value, dataFactoryName.Value, Core.Optional.ToNullable(dataFactoryLocation), Core.Optional.ToNullable(createTime));
        }
    }
}
