// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class GenerateCertResult
    {
        internal static GenerateCertResult DeserializeGenerateCertResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> publicKey = default;
            Core.Optional<string> privateKey = default;
            Core.Optional<DateTimeOffset> expiryTimeInUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicKey"u8))
                {
                    publicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateKey"u8))
                {
                    privateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTimeInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new GenerateCertResult(publicKey.Value, privateKey.Value, Core.Optional.ToNullable(expiryTimeInUtc));
        }
    }
}
