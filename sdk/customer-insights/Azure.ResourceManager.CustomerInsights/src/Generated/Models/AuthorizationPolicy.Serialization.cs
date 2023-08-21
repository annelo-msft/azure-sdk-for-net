// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class AuthorizationPolicy
    {
        internal static AuthorizationPolicy DeserializeAuthorizationPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> policyName = default;
            IReadOnlyList<PermissionType> permissions = default;
            Core.Optional<string> primaryKey = default;
            Core.Optional<string> secondaryKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyName"u8))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("permissions"u8))
                {
                    List<PermissionType> array = new List<PermissionType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToPermissionType());
                    }
                    permissions = array;
                    continue;
                }
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
            }
            return new AuthorizationPolicy(policyName.Value, permissions, primaryKey.Value, secondaryKey.Value);
        }
    }
}
