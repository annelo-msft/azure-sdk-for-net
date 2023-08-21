// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class GitHubActionConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(CodeConfiguration))
            {
                writer.WritePropertyName("codeConfiguration"u8);
                writer.WriteObjectValue(CodeConfiguration);
            }
            if (Core.Optional.IsDefined(ContainerConfiguration))
            {
                writer.WritePropertyName("containerConfiguration"u8);
                writer.WriteObjectValue(ContainerConfiguration);
            }
            if (Core.Optional.IsDefined(IsLinux))
            {
                writer.WritePropertyName("isLinux"u8);
                writer.WriteBooleanValue(IsLinux.Value);
            }
            if (Core.Optional.IsDefined(GenerateWorkflowFile))
            {
                writer.WritePropertyName("generateWorkflowFile"u8);
                writer.WriteBooleanValue(GenerateWorkflowFile.Value);
            }
            writer.WriteEndObject();
        }

        internal static GitHubActionConfiguration DeserializeGitHubActionConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<GitHubActionCodeConfiguration> codeConfiguration = default;
            Core.Optional<GitHubActionContainerConfiguration> containerConfiguration = default;
            Core.Optional<bool> isLinux = default;
            Core.Optional<bool> generateWorkflowFile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("codeConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    codeConfiguration = GitHubActionCodeConfiguration.DeserializeGitHubActionCodeConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("containerConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerConfiguration = GitHubActionContainerConfiguration.DeserializeGitHubActionContainerConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("isLinux"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLinux = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("generateWorkflowFile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    generateWorkflowFile = property.Value.GetBoolean();
                    continue;
                }
            }
            return new GitHubActionConfiguration(codeConfiguration.Value, containerConfiguration.Value, Core.Optional.ToNullable(isLinux), Core.Optional.ToNullable(generateWorkflowFile));
        }
    }
}
