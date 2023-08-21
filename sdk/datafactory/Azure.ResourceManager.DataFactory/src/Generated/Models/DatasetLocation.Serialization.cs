// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DatasetLocation : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetLocationType);
            if (Core.Optional.IsDefined(FolderPath))
            {
                writer.WritePropertyName("folderPath"u8);
                JsonSerializer.Serialize(writer, FolderPath);
            }
            if (Core.Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName"u8);
                JsonSerializer.Serialize(writer, FileName);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static DatasetLocation DeserializeDatasetLocation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonS3CompatibleLocation": return AmazonS3CompatibleLocation.DeserializeAmazonS3CompatibleLocation(element);
                    case "AmazonS3Location": return AmazonS3Location.DeserializeAmazonS3Location(element);
                    case "AzureBlobFSLocation": return AzureBlobFSLocation.DeserializeAzureBlobFSLocation(element);
                    case "AzureBlobStorageLocation": return AzureBlobStorageLocation.DeserializeAzureBlobStorageLocation(element);
                    case "AzureDataLakeStoreLocation": return AzureDataLakeStoreLocation.DeserializeAzureDataLakeStoreLocation(element);
                    case "AzureFileStorageLocation": return AzureFileStorageLocation.DeserializeAzureFileStorageLocation(element);
                    case "FileServerLocation": return FileServerLocation.DeserializeFileServerLocation(element);
                    case "FtpServerLocation": return FtpServerLocation.DeserializeFtpServerLocation(element);
                    case "GoogleCloudStorageLocation": return GoogleCloudStorageLocation.DeserializeGoogleCloudStorageLocation(element);
                    case "HdfsLocation": return HdfsLocation.DeserializeHdfsLocation(element);
                    case "HttpServerLocation": return HttpServerLocation.DeserializeHttpServerLocation(element);
                    case "OracleCloudStorageLocation": return OracleCloudStorageLocation.DeserializeOracleCloudStorageLocation(element);
                    case "SftpLocation": return SftpLocation.DeserializeSftpLocation(element);
                }
            }
            return UnknownDatasetLocation.DeserializeUnknownDatasetLocation(element);
        }
    }
}
