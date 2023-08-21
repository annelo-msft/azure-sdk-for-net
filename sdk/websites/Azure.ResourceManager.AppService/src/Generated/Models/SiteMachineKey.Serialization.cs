// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SiteMachineKey
    {
        internal static SiteMachineKey DeserializeSiteMachineKey(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> validation = default;
            Core.Optional<string> validationKey = default;
            Core.Optional<string> decryption = default;
            Core.Optional<string> decryptionKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validation"u8))
                {
                    validation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationKey"u8))
                {
                    validationKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("decryption"u8))
                {
                    decryption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("decryptionKey"u8))
                {
                    decryptionKey = property.Value.GetString();
                    continue;
                }
            }
            return new SiteMachineKey(validation.Value, validationKey.Value, decryption.Value, decryptionKey.Value);
        }
    }
}
