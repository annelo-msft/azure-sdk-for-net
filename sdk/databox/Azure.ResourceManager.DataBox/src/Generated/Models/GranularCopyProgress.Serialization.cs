// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class GranularCopyProgress
    {
        internal static GranularCopyProgress DeserializeGranularCopyProgress(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> storageAccountName = default;
            Core.Optional<DataBoxJobTransferType> transferType = default;
            Core.Optional<DataAccountType> dataAccountType = default;
            Core.Optional<ResourceIdentifier> accountId = default;
            Core.Optional<long> bytesProcessed = default;
            Core.Optional<long> totalBytesToProcess = default;
            Core.Optional<long> filesProcessed = default;
            Core.Optional<long> totalFilesToProcess = default;
            Core.Optional<long> invalidFilesProcessed = default;
            Core.Optional<long> invalidFileBytesUploaded = default;
            Core.Optional<long> renamedContainerCount = default;
            Core.Optional<long> filesErroredOut = default;
            Core.Optional<long> directoriesErroredOut = default;
            Core.Optional<long> invalidDirectoriesProcessed = default;
            Core.Optional<bool> isEnumerationInProgress = default;
            Core.Optional<ResponseError> error = default;
            Core.Optional<IReadOnlyList<CustomerResolutionCode>> actions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountName"u8))
                {
                    storageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transferType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferType = property.Value.GetString().ToDataBoxJobTransferType();
                    continue;
                }
                if (property.NameEquals("dataAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataAccountType = property.Value.GetString().ToDataAccountType();
                    continue;
                }
                if (property.NameEquals("accountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bytesProcessed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bytesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalBytesToProcess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalBytesToProcess = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("filesProcessed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalFilesToProcess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalFilesToProcess = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("invalidFilesProcessed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invalidFilesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("invalidFileBytesUploaded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invalidFileBytesUploaded = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("renamedContainerCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    renamedContainerCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("filesErroredOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filesErroredOut = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("directoriesErroredOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    directoriesErroredOut = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("invalidDirectoriesProcessed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invalidDirectoriesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("isEnumerationInProgress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEnumerationInProgress = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomerResolutionCode> array = new List<CustomerResolutionCode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToCustomerResolutionCode());
                    }
                    actions = array;
                    continue;
                }
            }
            return new GranularCopyProgress(storageAccountName.Value, Core.Optional.ToNullable(transferType), Core.Optional.ToNullable(dataAccountType), accountId.Value, Core.Optional.ToNullable(bytesProcessed), Core.Optional.ToNullable(totalBytesToProcess), Core.Optional.ToNullable(filesProcessed), Core.Optional.ToNullable(totalFilesToProcess), Core.Optional.ToNullable(invalidFilesProcessed), Core.Optional.ToNullable(invalidFileBytesUploaded), Core.Optional.ToNullable(renamedContainerCount), Core.Optional.ToNullable(filesErroredOut), Core.Optional.ToNullable(directoriesErroredOut), Core.Optional.ToNullable(invalidDirectoriesProcessed), Core.Optional.ToNullable(isEnumerationInProgress), error.Value, Core.Optional.ToList(actions));
        }
    }
}
