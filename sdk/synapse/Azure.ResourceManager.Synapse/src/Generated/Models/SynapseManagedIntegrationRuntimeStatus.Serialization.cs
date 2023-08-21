// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseManagedIntegrationRuntimeStatus
    {
        internal static SynapseManagedIntegrationRuntimeStatus DeserializeSynapseManagedIntegrationRuntimeStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = default;
            Core.Optional<string> dataFactoryName = default;
            Core.Optional<SynapseIntegrationRuntimeState> state = default;
            Core.Optional<DateTimeOffset> createTime = default;
            Core.Optional<IReadOnlyList<SynapseManagedIntegrationRuntimeNode>> nodes = default;
            Core.Optional<IReadOnlyList<SynapseManagedIntegrationRuntimeError>> otherErrors = default;
            Core.Optional<SynapseManagedIntegrationRuntimeOperationResult> lastOperation = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataFactoryName"u8))
                {
                    dataFactoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new SynapseIntegrationRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("createTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("nodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SynapseManagedIntegrationRuntimeNode> array = new List<SynapseManagedIntegrationRuntimeNode>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SynapseManagedIntegrationRuntimeNode.DeserializeSynapseManagedIntegrationRuntimeNode(item));
                            }
                            nodes = array;
                            continue;
                        }
                        if (property0.NameEquals("otherErrors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SynapseManagedIntegrationRuntimeError> array = new List<SynapseManagedIntegrationRuntimeError>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SynapseManagedIntegrationRuntimeError.DeserializeSynapseManagedIntegrationRuntimeError(item));
                            }
                            otherErrors = array;
                            continue;
                        }
                        if (property0.NameEquals("lastOperation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastOperation = SynapseManagedIntegrationRuntimeOperationResult.DeserializeSynapseManagedIntegrationRuntimeOperationResult(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseManagedIntegrationRuntimeStatus(type, dataFactoryName.Value, Core.Optional.ToNullable(state), additionalProperties, Core.Optional.ToNullable(createTime), Core.Optional.ToList(nodes), Core.Optional.ToList(otherErrors), lastOperation.Value);
        }
    }
}
