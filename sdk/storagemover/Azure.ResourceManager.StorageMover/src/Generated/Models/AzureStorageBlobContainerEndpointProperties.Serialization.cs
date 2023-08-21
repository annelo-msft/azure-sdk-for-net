// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageMover.Models
{
    public partial class AzureStorageBlobContainerEndpointProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageAccountResourceId"u8);
            writer.WriteStringValue(StorageAccountResourceId);
            writer.WritePropertyName("blobContainerName"u8);
            writer.WriteStringValue(BlobContainerName);
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static AzureStorageBlobContainerEndpointProperties DeserializeAzureStorageBlobContainerEndpointProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string storageAccountResourceId = default;
            string blobContainerName = default;
            EndpointType endpointType = default;
            Core.Optional<string> description = default;
            Core.Optional<StorageMoverProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountResourceId"u8))
                {
                    storageAccountResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobContainerName"u8))
                {
                    blobContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new StorageMoverProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new AzureStorageBlobContainerEndpointProperties(endpointType, description.Value, Core.Optional.ToNullable(provisioningState), storageAccountResourceId, blobContainerName);
        }
    }
}
