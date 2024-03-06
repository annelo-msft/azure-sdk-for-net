// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LibraryInfoConverter))]
    public partial class LibraryInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(ContainerName))
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (Optional.IsDefined(UploadedTimestamp))
            {
                writer.WritePropertyName("uploadedTimestamp"u8);
                writer.WriteStringValue(UploadedTimestamp.Value, "O");
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type);
            }
            writer.WriteEndObject();
        }

        internal static LibraryInfo DeserializeLibraryInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string path = default;
            string containerName = default;
            DateTimeOffset? uploadedTimestamp = default;
            string type = default;
            string provisioningStatus = default;
            string creatorId = default;
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
            return new LibraryInfo(
                name,
                path,
                containerName,
                uploadedTimestamp,
                type,
                provisioningStatus,
                creatorId);
        }

        internal partial class LibraryInfoConverter : JsonConverter<LibraryInfo>
        {
            public override void Write(Utf8JsonWriter writer, LibraryInfo model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LibraryInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLibraryInfo(document.RootElement);
            }
        }
    }
}
