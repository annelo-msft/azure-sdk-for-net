// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class Repositories
    {
        internal static Repositories DeserializeRepositories(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<string>> repositories = default;
            Core.Optional<string> link = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("repositories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    repositories = array;
                    continue;
                }
                if (property.NameEquals("link"u8))
                {
                    link = property.Value.GetString();
                    continue;
                }
            }
            return new Repositories(Core.Optional.ToList(repositories), link.Value);
        }
    }
}
