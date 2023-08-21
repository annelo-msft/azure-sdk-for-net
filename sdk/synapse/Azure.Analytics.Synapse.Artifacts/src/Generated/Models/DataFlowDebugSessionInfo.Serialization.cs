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
    [JsonConverter(typeof(DataFlowDebugSessionInfoConverter))]
    public partial class DataFlowDebugSessionInfo
    {
        internal static DataFlowDebugSessionInfo DeserializeDataFlowDebugSessionInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> dataFlowName = default;
            Core.Optional<string> computeType = default;
            Core.Optional<int> coreCount = default;
            Core.Optional<int> nodeCount = default;
            Core.Optional<string> integrationRuntimeName = default;
            Core.Optional<string> sessionId = default;
            Core.Optional<string> startTime = default;
            Core.Optional<int> timeToLiveInMinutes = default;
            Core.Optional<string> lastActivityTime = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataFlowName"u8))
                {
                    dataFlowName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("computeType"u8))
                {
                    computeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("coreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("integrationRuntimeName"u8))
                {
                    integrationRuntimeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeToLiveInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeToLiveInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastActivityTime"u8))
                {
                    lastActivityTime = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFlowDebugSessionInfo(dataFlowName.Value, computeType.Value, Core.Optional.ToNullable(coreCount), Core.Optional.ToNullable(nodeCount), integrationRuntimeName.Value, sessionId.Value, startTime.Value, Core.Optional.ToNullable(timeToLiveInMinutes), lastActivityTime.Value, additionalProperties);
        }

        internal partial class DataFlowDebugSessionInfoConverter : JsonConverter<DataFlowDebugSessionInfo>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowDebugSessionInfo model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override DataFlowDebugSessionInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowDebugSessionInfo(document.RootElement);
            }
        }
    }
}
