// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StaticSiteTemplate : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(TemplateRepositoryUri))
            {
                writer.WritePropertyName("templateRepositoryUrl"u8);
                writer.WriteStringValue(TemplateRepositoryUri.AbsoluteUri);
            }
            if (Core.Optional.IsDefined(Owner))
            {
                writer.WritePropertyName("owner"u8);
                writer.WriteStringValue(Owner);
            }
            if (Core.Optional.IsDefined(RepositoryName))
            {
                writer.WritePropertyName("repositoryName"u8);
                writer.WriteStringValue(RepositoryName);
            }
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Core.Optional.IsDefined(IsPrivate))
            {
                writer.WritePropertyName("isPrivate"u8);
                writer.WriteBooleanValue(IsPrivate.Value);
            }
            writer.WriteEndObject();
        }

        internal static StaticSiteTemplate DeserializeStaticSiteTemplate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<Uri> templateRepositoryUrl = default;
            Core.Optional<string> owner = default;
            Core.Optional<string> repositoryName = default;
            Core.Optional<string> description = default;
            Core.Optional<bool> isPrivate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateRepositoryUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateRepositoryUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("owner"u8))
                {
                    owner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repositoryName"u8))
                {
                    repositoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPrivate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrivate = property.Value.GetBoolean();
                    continue;
                }
            }
            return new StaticSiteTemplate(templateRepositoryUrl.Value, owner.Value, repositoryName.Value, description.Value, Core.Optional.ToNullable(isPrivate));
        }
    }
}
