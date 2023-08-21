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
    public partial class SynapseSelfHostedIntegrationRuntimeStatus
    {
        internal static SynapseSelfHostedIntegrationRuntimeStatus DeserializeSynapseSelfHostedIntegrationRuntimeStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = default;
            Core.Optional<string> dataFactoryName = default;
            Core.Optional<SynapseIntegrationRuntimeState> state = default;
            Core.Optional<DateTimeOffset> createTime = default;
            Core.Optional<string> taskQueueId = default;
            Core.Optional<string> nodeCommunicationChannelEncryptionMode = default;
            Core.Optional<SynapseIntegrationRuntimeInternalChannelEncryptionMode> internalChannelEncryption = default;
            Core.Optional<string> version = default;
            Core.Optional<IReadOnlyList<SynapseSelfHostedIntegrationRuntimeNode>> nodes = default;
            Core.Optional<DateTimeOffset> scheduledUpdateDate = default;
            Core.Optional<string> updateDelayOffset = default;
            Core.Optional<string> localTimeZoneOffset = default;
            Core.Optional<IReadOnlyDictionary<string, string>> capabilities = default;
            Core.Optional<IReadOnlyList<string>> serviceUrls = default;
            Core.Optional<SynapseIntegrationRuntimeAutoUpdate> autoUpdate = default;
            Core.Optional<string> versionStatus = default;
            Core.Optional<IReadOnlyList<SynapseLinkedIntegrationRuntime>> links = default;
            Core.Optional<string> pushedVersion = default;
            Core.Optional<string> latestVersion = default;
            Core.Optional<DateTimeOffset> autoUpdateEta = default;
            Core.Optional<string> serviceRegion = default;
            Core.Optional<IReadOnlyList<string>> newerVersions = default;
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
                        if (property0.NameEquals("taskQueueId"u8))
                        {
                            taskQueueId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeCommunicationChannelEncryptionMode"u8))
                        {
                            nodeCommunicationChannelEncryptionMode = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("internalChannelEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            internalChannelEncryption = new SynapseIntegrationRuntimeInternalChannelEncryptionMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SynapseSelfHostedIntegrationRuntimeNode> array = new List<SynapseSelfHostedIntegrationRuntimeNode>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SynapseSelfHostedIntegrationRuntimeNode.DeserializeSynapseSelfHostedIntegrationRuntimeNode(item));
                            }
                            nodes = array;
                            continue;
                        }
                        if (property0.NameEquals("scheduledUpdateDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scheduledUpdateDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updateDelayOffset"u8))
                        {
                            updateDelayOffset = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("localTimeZoneOffset"u8))
                        {
                            localTimeZoneOffset = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("capabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            capabilities = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("serviceUrls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            serviceUrls = array;
                            continue;
                        }
                        if (property0.NameEquals("autoUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoUpdate = new SynapseIntegrationRuntimeAutoUpdate(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("versionStatus"u8))
                        {
                            versionStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("links"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SynapseLinkedIntegrationRuntime> array = new List<SynapseLinkedIntegrationRuntime>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SynapseLinkedIntegrationRuntime.DeserializeSynapseLinkedIntegrationRuntime(item));
                            }
                            links = array;
                            continue;
                        }
                        if (property0.NameEquals("pushedVersion"u8))
                        {
                            pushedVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("latestVersion"u8))
                        {
                            latestVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoUpdateETA"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoUpdateEta = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("serviceRegion"u8))
                        {
                            serviceRegion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("newerVersions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            newerVersions = array;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseSelfHostedIntegrationRuntimeStatus(type, dataFactoryName.Value, Core.Optional.ToNullable(state), additionalProperties, Core.Optional.ToNullable(createTime), taskQueueId.Value, nodeCommunicationChannelEncryptionMode.Value, Core.Optional.ToNullable(internalChannelEncryption), version.Value, Core.Optional.ToList(nodes), Core.Optional.ToNullable(scheduledUpdateDate), updateDelayOffset.Value, localTimeZoneOffset.Value, Core.Optional.ToDictionary(capabilities), Core.Optional.ToList(serviceUrls), Core.Optional.ToNullable(autoUpdate), versionStatus.Value, Core.Optional.ToList(links), pushedVersion.Value, latestVersion.Value, Core.Optional.ToNullable(autoUpdateEta), serviceRegion.Value, Core.Optional.ToList(newerVersions));
        }
    }
}
