// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapSupportedSku
    {
        internal static SapSupportedSku DeserializeSapSupportedSku(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> vmSku = default;
            Core.Optional<bool> isAppServerCertified = default;
            Core.Optional<bool> isDatabaseCertified = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSku"u8))
                {
                    vmSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAppServerCertified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAppServerCertified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDatabaseCertified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDatabaseCertified = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SapSupportedSku(vmSku.Value, Core.Optional.ToNullable(isAppServerCertified), Core.Optional.ToNullable(isDatabaseCertified));
        }
    }
}
