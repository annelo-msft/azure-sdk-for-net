// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ScriptActivityScriptBlock : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            JsonSerializer.Serialize(writer, Text);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ScriptType.ToString());
            if (Core.Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ScriptActivityScriptBlock DeserializeScriptActivityScriptBlock(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> text = default;
            DataFactoryScriptType type = default;
            Core.Optional<IList<ScriptActivityParameter>> parameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new DataFactoryScriptType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScriptActivityParameter> array = new List<ScriptActivityParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScriptActivityParameter.DeserializeScriptActivityParameter(item));
                    }
                    parameters = array;
                    continue;
                }
            }
            return new ScriptActivityScriptBlock(text, type, Core.Optional.ToList(parameters));
        }
    }
}
