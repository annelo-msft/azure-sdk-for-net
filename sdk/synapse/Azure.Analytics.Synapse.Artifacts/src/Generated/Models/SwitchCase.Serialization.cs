// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SwitchCaseConverter))]
    public partial class SwitchCase : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Core.Optional.IsCollectionDefined(Activities))
            {
                writer.WritePropertyName("activities"u8);
                writer.WriteStartArray();
                foreach (var item in Activities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SwitchCase DeserializeSwitchCase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> value = default;
            Core.Optional<IList<Activity>> activities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Activity> array = new List<Activity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Activity.DeserializeActivity(item));
                    }
                    activities = array;
                    continue;
                }
            }
            return new SwitchCase(value.Value, Core.Optional.ToList(activities));
        }

        internal partial class SwitchCaseConverter : JsonConverter<SwitchCase>
        {
            public override void Write(Utf8JsonWriter writer, SwitchCase model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SwitchCase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSwitchCase(document.RootElement);
            }
        }
    }
}
