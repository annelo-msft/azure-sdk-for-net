// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class PipelineTopologySetRequest : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("pipelineTopology"u8);
            writer.WriteObjectValue(PipelineTopology);
            if (Core.Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            writer.WriteEndObject();
        }

        internal static PipelineTopologySetRequest DeserializePipelineTopologySetRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PipelineTopology pipelineTopology = default;
            string methodName = default;
            Core.Optional<string> apiVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelineTopology"u8))
                {
                    pipelineTopology = PipelineTopology.DeserializePipelineTopology(property.Value);
                    continue;
                }
                if (property.NameEquals("methodName"u8))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
            }
            return new PipelineTopologySetRequest(methodName, apiVersion.Value, pipelineTopology);
        }
    }
}
