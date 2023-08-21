// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceHttpLogsConfig : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(FileSystem))
            {
                writer.WritePropertyName("fileSystem"u8);
                writer.WriteObjectValue(FileSystem);
            }
            if (Core.Optional.IsDefined(AzureBlobStorage))
            {
                writer.WritePropertyName("azureBlobStorage"u8);
                writer.WriteObjectValue(AzureBlobStorage);
            }
            writer.WriteEndObject();
        }

        internal static AppServiceHttpLogsConfig DeserializeAppServiceHttpLogsConfig(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<FileSystemHttpLogsConfig> fileSystem = default;
            Core.Optional<AppServiceBlobStorageHttpLogsConfig> azureBlobStorage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileSystem"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileSystem = FileSystemHttpLogsConfig.DeserializeFileSystemHttpLogsConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("azureBlobStorage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobStorage = AppServiceBlobStorageHttpLogsConfig.DeserializeAppServiceBlobStorageHttpLogsConfig(property.Value);
                    continue;
                }
            }
            return new AppServiceHttpLogsConfig(fileSystem.Value, azureBlobStorage.Value);
        }
    }
}
