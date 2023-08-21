// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryImportImageContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("source"u8);
            writer.WriteObjectValue(Source);
            if (Core.Optional.IsCollectionDefined(TargetTags))
            {
                writer.WritePropertyName("targetTags"u8);
                writer.WriteStartArray();
                foreach (var item in TargetTags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(UntaggedTargetRepositories))
            {
                writer.WritePropertyName("untaggedTargetRepositories"u8);
                writer.WriteStartArray();
                foreach (var item in UntaggedTargetRepositories)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
