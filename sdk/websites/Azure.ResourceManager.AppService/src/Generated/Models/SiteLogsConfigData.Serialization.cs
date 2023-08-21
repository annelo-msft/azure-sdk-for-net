// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class SiteLogsConfigData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ApplicationLogs))
            {
                writer.WritePropertyName("applicationLogs"u8);
                writer.WriteObjectValue(ApplicationLogs);
            }
            if (Core.Optional.IsDefined(HttpLogs))
            {
                writer.WritePropertyName("httpLogs"u8);
                writer.WriteObjectValue(HttpLogs);
            }
            if (Core.Optional.IsDefined(IsFailedRequestsTracing))
            {
                writer.WritePropertyName("failedRequestsTracing"u8);
                writer.WriteObjectValue(IsFailedRequestsTracing);
            }
            if (Core.Optional.IsDefined(IsDetailedErrorMessages))
            {
                writer.WritePropertyName("detailedErrorMessages"u8);
                writer.WriteObjectValue(IsDetailedErrorMessages);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SiteLogsConfigData DeserializeSiteLogsConfigData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<ApplicationLogsConfig> applicationLogs = default;
            Core.Optional<AppServiceHttpLogsConfig> httpLogs = default;
            Core.Optional<WebAppEnabledConfig> failedRequestsTracing = default;
            Core.Optional<WebAppEnabledConfig> detailedErrorMessages = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("applicationLogs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            applicationLogs = ApplicationLogsConfig.DeserializeApplicationLogsConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpLogs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpLogs = AppServiceHttpLogsConfig.DeserializeAppServiceHttpLogsConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("failedRequestsTracing"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            failedRequestsTracing = WebAppEnabledConfig.DeserializeWebAppEnabledConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("detailedErrorMessages"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedErrorMessages = WebAppEnabledConfig.DeserializeWebAppEnabledConfig(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SiteLogsConfigData(id, name, type, systemData.Value, applicationLogs.Value, httpLogs.Value, failedRequestsTracing.Value, detailedErrorMessages.Value, kind.Value);
        }
    }
}
