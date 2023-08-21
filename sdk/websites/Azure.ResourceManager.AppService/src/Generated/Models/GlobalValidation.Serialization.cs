// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class GlobalValidation : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(IsAuthenticationRequired))
            {
                writer.WritePropertyName("requireAuthentication"u8);
                writer.WriteBooleanValue(IsAuthenticationRequired.Value);
            }
            if (Core.Optional.IsDefined(UnauthenticatedClientAction))
            {
                writer.WritePropertyName("unauthenticatedClientAction"u8);
                writer.WriteStringValue(UnauthenticatedClientAction.Value.ToSerialString());
            }
            if (Core.Optional.IsDefined(RedirectToProvider))
            {
                writer.WritePropertyName("redirectToProvider"u8);
                writer.WriteStringValue(RedirectToProvider);
            }
            if (Core.Optional.IsCollectionDefined(ExcludedPaths))
            {
                writer.WritePropertyName("excludedPaths"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedPaths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static GlobalValidation DeserializeGlobalValidation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> requireAuthentication = default;
            Core.Optional<UnauthenticatedClientActionV2> unauthenticatedClientAction = default;
            Core.Optional<string> redirectToProvider = default;
            Core.Optional<IList<string>> excludedPaths = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requireAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requireAuthentication = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("unauthenticatedClientAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unauthenticatedClientAction = property.Value.GetString().ToUnauthenticatedClientActionV2();
                    continue;
                }
                if (property.NameEquals("redirectToProvider"u8))
                {
                    redirectToProvider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludedPaths"u8))
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
                    excludedPaths = array;
                    continue;
                }
            }
            return new GlobalValidation(Core.Optional.ToNullable(requireAuthentication), Core.Optional.ToNullable(unauthenticatedClientAction), redirectToProvider.Value, Core.Optional.ToList(excludedPaths));
        }
    }
}
