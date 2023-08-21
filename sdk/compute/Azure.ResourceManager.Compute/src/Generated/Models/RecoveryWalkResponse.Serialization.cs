// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RecoveryWalkResponse
    {
        internal static RecoveryWalkResponse DeserializeRecoveryWalkResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> walkPerformed = default;
            Core.Optional<int> nextPlatformUpdateDomain = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("walkPerformed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    walkPerformed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nextPlatformUpdateDomain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextPlatformUpdateDomain = property.Value.GetInt32();
                    continue;
                }
            }
            return new RecoveryWalkResponse(Core.Optional.ToNullable(walkPerformed), Core.Optional.ToNullable(nextPlatformUpdateDomain));
        }
    }
}
