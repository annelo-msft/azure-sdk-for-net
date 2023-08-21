// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryGenerateCredentialsResult
    {
        internal static ContainerRegistryGenerateCredentialsResult DeserializeContainerRegistryGenerateCredentialsResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> username = default;
            Core.Optional<IReadOnlyList<ContainerRegistryTokenPassword>> passwords = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("passwords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryTokenPassword> array = new List<ContainerRegistryTokenPassword>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryTokenPassword.DeserializeContainerRegistryTokenPassword(item));
                    }
                    passwords = array;
                    continue;
                }
            }
            return new ContainerRegistryGenerateCredentialsResult(username.Value, Core.Optional.ToList(passwords));
        }
    }
}
