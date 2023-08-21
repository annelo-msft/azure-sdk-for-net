// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class CSharpFunctionBinding : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FunctionBindingType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(DllPath))
            {
                writer.WritePropertyName("dllPath"u8);
                writer.WriteStringValue(DllPath);
            }
            if (Core.Optional.IsDefined(Class))
            {
                writer.WritePropertyName("class"u8);
                writer.WriteStringValue(Class);
            }
            if (Core.Optional.IsDefined(Method))
            {
                writer.WritePropertyName("method"u8);
                writer.WriteStringValue(Method);
            }
            if (Core.Optional.IsDefined(UpdateMode))
            {
                writer.WritePropertyName("updateMode"u8);
                writer.WriteStringValue(UpdateMode.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CSharpFunctionBinding DeserializeCSharpFunctionBinding(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Core.Optional<string> dllPath = default;
            Core.Optional<string> @class = default;
            Core.Optional<string> method = default;
            Core.Optional<StreamingJobFunctionUpdateMode> updateMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("dllPath"u8))
                        {
                            dllPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("class"u8))
                        {
                            @class = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("method"u8))
                        {
                            method = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("updateMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateMode = new StreamingJobFunctionUpdateMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CSharpFunctionBinding(type, dllPath.Value, @class.Value, method.Value, Core.Optional.ToNullable(updateMode));
        }
    }
}
