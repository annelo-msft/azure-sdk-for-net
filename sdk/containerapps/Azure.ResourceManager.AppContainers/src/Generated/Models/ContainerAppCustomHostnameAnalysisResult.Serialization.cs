// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppCustomHostnameAnalysisResult
    {
        internal static ContainerAppCustomHostnameAnalysisResult DeserializeContainerAppCustomHostnameAnalysisResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> hostName = default;
            Core.Optional<bool> isHostnameAlreadyVerified = default;
            Core.Optional<ContainerAppDnsVerificationTestResult> customDomainVerificationTest = default;
            Core.Optional<ContainerAppCustomDomainVerificationFailureInfo> customDomainVerificationFailureInfo = default;
            Core.Optional<bool> hasConflictOnManagedEnvironment = default;
            Core.Optional<bool> conflictWithEnvironmentCustomDomain = default;
            Core.Optional<string> conflictingContainerAppResourceId = default;
            Core.Optional<IReadOnlyList<string>> cNameRecords = default;
            Core.Optional<IReadOnlyList<string>> txtRecords = default;
            Core.Optional<IReadOnlyList<string>> aRecords = default;
            Core.Optional<IReadOnlyList<string>> alternateCNameRecords = default;
            Core.Optional<IReadOnlyList<string>> alternateTxtRecords = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isHostnameAlreadyVerified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHostnameAlreadyVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customDomainVerificationTest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customDomainVerificationTest = property.Value.GetString().ToContainerAppDnsVerificationTestResult();
                    continue;
                }
                if (property.NameEquals("customDomainVerificationFailureInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customDomainVerificationFailureInfo = ContainerAppCustomDomainVerificationFailureInfo.DeserializeContainerAppCustomDomainVerificationFailureInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("hasConflictOnManagedEnvironment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasConflictOnManagedEnvironment = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("conflictWithEnvironmentCustomDomain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conflictWithEnvironmentCustomDomain = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("conflictingContainerAppResourceId"u8))
                {
                    conflictingContainerAppResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cNameRecords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    cNameRecords = array;
                    continue;
                }
                if (property.NameEquals("txtRecords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    txtRecords = array;
                    continue;
                }
                if (property.NameEquals("aRecords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    aRecords = array;
                    continue;
                }
                if (property.NameEquals("alternateCNameRecords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    alternateCNameRecords = array;
                    continue;
                }
                if (property.NameEquals("alternateTxtRecords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    alternateTxtRecords = array;
                    continue;
                }
            }
            return new ContainerAppCustomHostnameAnalysisResult(hostName.Value, Core.Optional.ToNullable(isHostnameAlreadyVerified), Core.Optional.ToNullable(customDomainVerificationTest), customDomainVerificationFailureInfo.Value, Core.Optional.ToNullable(hasConflictOnManagedEnvironment), Core.Optional.ToNullable(conflictWithEnvironmentCustomDomain), conflictingContainerAppResourceId.Value, Core.Optional.ToList(cNameRecords), Core.Optional.ToList(txtRecords), Core.Optional.ToList(aRecords), Core.Optional.ToList(alternateCNameRecords), Core.Optional.ToList(alternateTxtRecords));
        }
    }
}
