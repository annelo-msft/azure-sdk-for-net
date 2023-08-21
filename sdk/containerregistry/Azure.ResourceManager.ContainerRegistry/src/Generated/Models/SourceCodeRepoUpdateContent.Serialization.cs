// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class SourceCodeRepoUpdateContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(SourceControlType))
            {
                writer.WritePropertyName("sourceControlType"u8);
                writer.WriteStringValue(SourceControlType.Value.ToString());
            }
            if (Core.Optional.IsDefined(RepositoryUri))
            {
                writer.WritePropertyName("repositoryUrl"u8);
                writer.WriteStringValue(RepositoryUri.AbsoluteUri);
            }
            if (Core.Optional.IsDefined(Branch))
            {
                writer.WritePropertyName("branch"u8);
                writer.WriteStringValue(Branch);
            }
            if (Core.Optional.IsDefined(SourceControlAuthProperties))
            {
                writer.WritePropertyName("sourceControlAuthProperties"u8);
                writer.WriteObjectValue(SourceControlAuthProperties);
            }
            writer.WriteEndObject();
        }
    }
}
