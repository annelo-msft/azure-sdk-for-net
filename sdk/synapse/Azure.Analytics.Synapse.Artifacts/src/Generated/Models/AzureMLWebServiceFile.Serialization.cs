// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AzureMLWebServiceFileConverter))]
    public partial class AzureMLWebServiceFile : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("filePath"u8);
            writer.WriteObjectValue(FilePath);
            writer.WritePropertyName("linkedServiceName"u8);
            writer.WriteObjectValue(LinkedServiceName);
            writer.WriteEndObject();
        }

        internal static AzureMLWebServiceFile DeserializeAzureMLWebServiceFile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object filePath = default;
            LinkedServiceReference linkedServiceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filePath"u8))
                {
                    filePath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("linkedServiceName"u8))
                {
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
            }
            return new AzureMLWebServiceFile(filePath, linkedServiceName);
        }

        internal partial class AzureMLWebServiceFileConverter : JsonConverter<AzureMLWebServiceFile>
        {
            public override void Write(Utf8JsonWriter writer, AzureMLWebServiceFile model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureMLWebServiceFile Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureMLWebServiceFile(document.RootElement);
            }
        }
    }
}
