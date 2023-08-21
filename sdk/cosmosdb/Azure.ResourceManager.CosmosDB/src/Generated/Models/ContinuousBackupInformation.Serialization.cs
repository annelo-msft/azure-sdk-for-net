// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class ContinuousBackupInformation
    {
        internal static ContinuousBackupInformation DeserializeContinuousBackupInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DateTimeOffset> latestRestorableTimestamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("latestRestorableTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latestRestorableTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ContinuousBackupInformation(Core.Optional.ToNullable(latestRestorableTimestamp));
        }
    }
}
