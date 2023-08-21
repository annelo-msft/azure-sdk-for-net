// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class FunctionAppHostKeys
    {
        internal static FunctionAppHostKeys DeserializeFunctionAppHostKeys(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> masterKey = default;
            Core.Optional<IReadOnlyDictionary<string, string>> functionKeys = default;
            Core.Optional<IReadOnlyDictionary<string, string>> systemKeys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("masterKey"u8))
                {
                    masterKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("functionKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    functionKeys = dictionary;
                    continue;
                }
                if (property.NameEquals("systemKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    systemKeys = dictionary;
                    continue;
                }
            }
            return new FunctionAppHostKeys(masterKey.Value, Core.Optional.ToDictionary(functionKeys), Core.Optional.ToDictionary(systemKeys));
        }
    }
}
