// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtProtectedDiskDetails
    {
        internal static VMwareCbtProtectedDiskDetails DeserializeVMwareCbtProtectedDiskDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> diskId = default;
            Optional<string> diskName = default;
            Optional<SiteRecoveryDiskAccountType> diskType = default;
            Optional<string> diskPath = default;
            Optional<string> isOSDisk = default;
            Optional<long> capacityInBytes = default;
            Optional<ResourceIdentifier> logStorageAccountId = default;
            Optional<string> logStorageAccountSasSecretName = default;
            Optional<ResourceIdentifier> diskEncryptionSetId = default;
            Optional<string> seedManagedDiskId = default;
            Optional<Uri> seedBlobUri = default;
            Optional<string> targetManagedDiskId = default;
            Optional<Uri> targetBlobUri = default;
            Optional<string> targetDiskName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskType = new SiteRecoveryDiskAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskPath"u8))
                {
                    diskPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isOSDisk"u8))
                {
                    isOSDisk = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("logStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logStorageAccountSasSecretName"u8))
                {
                    logStorageAccountSasSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("seedManagedDiskId"u8))
                {
                    seedManagedDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("seedBlobUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    seedBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetManagedDiskId"u8))
                {
                    targetManagedDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetBlobUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetDiskName"u8))
                {
                    targetDiskName = property.Value.GetString();
                    continue;
                }
            }
            return new VMwareCbtProtectedDiskDetails(diskId.Value, diskName.Value, Optional.ToNullable(diskType), diskPath.Value, isOSDisk.Value, Optional.ToNullable(capacityInBytes), logStorageAccountId.Value, logStorageAccountSasSecretName.Value, diskEncryptionSetId.Value, seedManagedDiskId.Value, seedBlobUri.Value, targetManagedDiskId.Value, targetBlobUri.Value, targetDiskName.Value);
        }
    }
}
