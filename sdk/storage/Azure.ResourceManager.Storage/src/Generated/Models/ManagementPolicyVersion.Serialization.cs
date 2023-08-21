// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ManagementPolicyVersion : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(TierToCool))
            {
                writer.WritePropertyName("tierToCool"u8);
                writer.WriteObjectValue(TierToCool);
            }
            if (Core.Optional.IsDefined(TierToArchive))
            {
                writer.WritePropertyName("tierToArchive"u8);
                writer.WriteObjectValue(TierToArchive);
            }
            if (Core.Optional.IsDefined(TierToCold))
            {
                writer.WritePropertyName("tierToCold"u8);
                writer.WriteObjectValue(TierToCold);
            }
            if (Core.Optional.IsDefined(TierToHot))
            {
                writer.WritePropertyName("tierToHot"u8);
                writer.WriteObjectValue(TierToHot);
            }
            if (Core.Optional.IsDefined(Delete))
            {
                writer.WritePropertyName("delete"u8);
                writer.WriteObjectValue(Delete);
            }
            writer.WriteEndObject();
        }

        internal static ManagementPolicyVersion DeserializeManagementPolicyVersion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DateAfterCreation> tierToCool = default;
            Core.Optional<DateAfterCreation> tierToArchive = default;
            Core.Optional<DateAfterCreation> tierToCold = default;
            Core.Optional<DateAfterCreation> tierToHot = default;
            Core.Optional<DateAfterCreation> delete = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tierToCool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToCool = DateAfterCreation.DeserializeDateAfterCreation(property.Value);
                    continue;
                }
                if (property.NameEquals("tierToArchive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToArchive = DateAfterCreation.DeserializeDateAfterCreation(property.Value);
                    continue;
                }
                if (property.NameEquals("tierToCold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToCold = DateAfterCreation.DeserializeDateAfterCreation(property.Value);
                    continue;
                }
                if (property.NameEquals("tierToHot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToHot = DateAfterCreation.DeserializeDateAfterCreation(property.Value);
                    continue;
                }
                if (property.NameEquals("delete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delete = DateAfterCreation.DeserializeDateAfterCreation(property.Value);
                    continue;
                }
            }
            return new ManagementPolicyVersion(tierToCool.Value, tierToArchive.Value, tierToCold.Value, tierToHot.Value, delete.Value);
        }
    }
}
