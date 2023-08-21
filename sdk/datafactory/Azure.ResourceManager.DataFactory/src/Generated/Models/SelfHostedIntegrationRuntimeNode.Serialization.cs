// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SelfHostedIntegrationRuntimeNode
    {
        internal static SelfHostedIntegrationRuntimeNode DeserializeSelfHostedIntegrationRuntimeNode(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> nodeName = default;
            Core.Optional<string> machineName = default;
            Core.Optional<Uri> hostServiceUri = default;
            Core.Optional<SelfHostedIntegrationRuntimeNodeStatus> status = default;
            Core.Optional<IReadOnlyDictionary<string, string>> capabilities = default;
            Core.Optional<string> versionStatus = default;
            Core.Optional<string> version = default;
            Core.Optional<DateTimeOffset> registerTime = default;
            Core.Optional<DateTimeOffset> lastConnectTime = default;
            Core.Optional<DateTimeOffset> expiryTime = default;
            Core.Optional<DateTimeOffset> lastStartTime = default;
            Core.Optional<DateTimeOffset> lastStopTime = default;
            Core.Optional<IntegrationRuntimeUpdateResult> lastUpdateResult = default;
            Core.Optional<DateTimeOffset> lastStartUpdateTime = default;
            Core.Optional<DateTimeOffset> lastEndUpdateTime = default;
            Core.Optional<bool> isActiveDispatcher = default;
            Core.Optional<int> concurrentJobsLimit = default;
            Core.Optional<int> maxConcurrentJobs = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeName"u8))
                {
                    nodeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SelfHostedIntegrationRuntimeNodeStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    capabilities = dictionary;
                    continue;
                }
                if (property.NameEquals("versionStatus"u8))
                {
                    versionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registerTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastConnectTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastConnectTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastStopTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStopTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateResult = new IntegrationRuntimeUpdateResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastStartUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStartUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastEndUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastEndUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isActiveDispatcher"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isActiveDispatcher = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("concurrentJobsLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    concurrentJobsLimit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConcurrentJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentJobs = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SelfHostedIntegrationRuntimeNode(nodeName.Value, machineName.Value, hostServiceUri.Value, Core.Optional.ToNullable(status), Core.Optional.ToDictionary(capabilities), versionStatus.Value, version.Value, Core.Optional.ToNullable(registerTime), Core.Optional.ToNullable(lastConnectTime), Core.Optional.ToNullable(expiryTime), Core.Optional.ToNullable(lastStartTime), Core.Optional.ToNullable(lastStopTime), Core.Optional.ToNullable(lastUpdateResult), Core.Optional.ToNullable(lastStartUpdateTime), Core.Optional.ToNullable(lastEndUpdateTime), Core.Optional.ToNullable(isActiveDispatcher), Core.Optional.ToNullable(concurrentJobsLimit), Core.Optional.ToNullable(maxConcurrentJobs), additionalProperties);
        }
    }
}
