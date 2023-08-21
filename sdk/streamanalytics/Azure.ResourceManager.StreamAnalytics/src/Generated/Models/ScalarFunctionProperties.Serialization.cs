// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class ScalarFunctionProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FunctionPropertiesType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs"u8);
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(Output))
            {
                writer.WritePropertyName("output"u8);
                writer.WriteObjectValue(Output);
            }
            if (Core.Optional.IsDefined(Binding))
            {
                writer.WritePropertyName("binding"u8);
                writer.WriteObjectValue(Binding);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ScalarFunctionProperties DeserializeScalarFunctionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Core.Optional<ETag> etag = default;
            Core.Optional<IList<StreamingJobFunctionInput>> inputs = default;
            Core.Optional<StreamingJobFunctionOutput> output = default;
            Core.Optional<StreamingJobFunctionBinding> binding = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("inputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StreamingJobFunctionInput> array = new List<StreamingJobFunctionInput>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StreamingJobFunctionInput.DeserializeStreamingJobFunctionInput(item));
                            }
                            inputs = array;
                            continue;
                        }
                        if (property0.NameEquals("output"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            output = StreamingJobFunctionOutput.DeserializeStreamingJobFunctionOutput(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("binding"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            binding = StreamingJobFunctionBinding.DeserializeStreamingJobFunctionBinding(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ScalarFunctionProperties(type, Core.Optional.ToNullable(etag), Core.Optional.ToList(inputs), output.Value, binding.Value);
        }
    }
}
