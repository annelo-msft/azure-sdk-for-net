// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class BigDataPoolLibraryInfo : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Core.Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Core.Optional.IsDefined(ContainerName))
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (Core.Optional.IsDefined(UploadedOn))
            {
                writer.WritePropertyName("uploadedTimestamp"u8);
                writer.WriteStringValue(UploadedOn.Value, "O");
            }
            if (Core.Optional.IsDefined(LibraryInfoType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(LibraryInfoType);
            }
            writer.WriteEndObject();
        }

        internal static BigDataPoolLibraryInfo DeserializeBigDataPoolLibraryInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<string> path = default;
            Core.Optional<string> containerName = default;
            Core.Optional<DateTimeOffset> uploadedTimestamp = default;
            Core.Optional<string> type = default;
            Core.Optional<string> provisioningStatus = default;
            Core.Optional<string> creatorId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uploadedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uploadedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatus"u8))
                {
                    provisioningStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creatorId"u8))
                {
                    creatorId = property.Value.GetString();
                    continue;
                }
            }
            return new BigDataPoolLibraryInfo(name.Value, path.Value, containerName.Value, Core.Optional.ToNullable(uploadedTimestamp), type.Value, provisioningStatus.Value, creatorId.Value);
        }
    }
}
