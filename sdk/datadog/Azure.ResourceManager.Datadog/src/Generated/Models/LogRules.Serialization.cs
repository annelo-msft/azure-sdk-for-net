// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    public partial class LogRules : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(SendAadLogs))
            {
                writer.WritePropertyName("sendAadLogs"u8);
                writer.WriteBooleanValue(SendAadLogs.Value);
            }
            if (Core.Optional.IsDefined(SendSubscriptionLogs))
            {
                writer.WritePropertyName("sendSubscriptionLogs"u8);
                writer.WriteBooleanValue(SendSubscriptionLogs.Value);
            }
            if (Core.Optional.IsDefined(SendResourceLogs))
            {
                writer.WritePropertyName("sendResourceLogs"u8);
                writer.WriteBooleanValue(SendResourceLogs.Value);
            }
            if (Core.Optional.IsCollectionDefined(FilteringTags))
            {
                writer.WritePropertyName("filteringTags"u8);
                writer.WriteStartArray();
                foreach (var item in FilteringTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static LogRules DeserializeLogRules(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> sendAadLogs = default;
            Core.Optional<bool> sendSubscriptionLogs = default;
            Core.Optional<bool> sendResourceLogs = default;
            Core.Optional<IList<FilteringTag>> filteringTags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendAadLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendAadLogs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sendSubscriptionLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendSubscriptionLogs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sendResourceLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendResourceLogs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("filteringTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FilteringTag> array = new List<FilteringTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FilteringTag.DeserializeFilteringTag(item));
                    }
                    filteringTags = array;
                    continue;
                }
            }
            return new LogRules(Core.Optional.ToNullable(sendAadLogs), Core.Optional.ToNullable(sendSubscriptionLogs), Core.Optional.ToNullable(sendResourceLogs), Core.Optional.ToList(filteringTags));
        }
    }
}
