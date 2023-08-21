// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppAzureActiveDirectoryLoginConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(LoginParameters))
            {
                writer.WritePropertyName("loginParameters"u8);
                writer.WriteStartArray();
                foreach (var item in LoginParameters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(IsWwwAuthenticationDisabled))
            {
                writer.WritePropertyName("disableWWWAuthenticate"u8);
                writer.WriteBooleanValue(IsWwwAuthenticationDisabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppAzureActiveDirectoryLoginConfiguration DeserializeContainerAppAzureActiveDirectoryLoginConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<string>> loginParameters = default;
            Core.Optional<bool> disableWWWAuthenticate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loginParameters"u8))
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
                    loginParameters = array;
                    continue;
                }
                if (property.NameEquals("disableWWWAuthenticate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableWWWAuthenticate = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ContainerAppAzureActiveDirectoryLoginConfiguration(Core.Optional.ToList(loginParameters), Core.Optional.ToNullable(disableWWWAuthenticate));
        }
    }
}
