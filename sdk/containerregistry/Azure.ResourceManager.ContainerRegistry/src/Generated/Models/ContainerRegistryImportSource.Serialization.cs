// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryImportSource : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Core.Optional.IsDefined(RegistryAddress))
            {
                writer.WritePropertyName("registryUri"u8);
                writer.WriteStringValue(RegistryAddress);
            }
            if (Core.Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials);
            }
            writer.WritePropertyName("sourceImage"u8);
            writer.WriteStringValue(SourceImage);
            writer.WriteEndObject();
        }
    }
}
