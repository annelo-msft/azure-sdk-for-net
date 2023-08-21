// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppOpenIdConnectLogin : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(NameClaimType))
            {
                writer.WritePropertyName("nameClaimType"u8);
                writer.WriteStringValue(NameClaimType);
            }
            if (Core.Optional.IsCollectionDefined(Scopes))
            {
                writer.WritePropertyName("scopes"u8);
                writer.WriteStartArray();
                foreach (var item in Scopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppOpenIdConnectLogin DeserializeContainerAppOpenIdConnectLogin(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> nameClaimType = default;
            Core.Optional<IList<string>> scopes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameClaimType"u8))
                {
                    nameClaimType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scopes"u8))
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
                    scopes = array;
                    continue;
                }
            }
            return new ContainerAppOpenIdConnectLogin(nameClaimType.Value, Core.Optional.ToList(scopes));
        }
    }
}
