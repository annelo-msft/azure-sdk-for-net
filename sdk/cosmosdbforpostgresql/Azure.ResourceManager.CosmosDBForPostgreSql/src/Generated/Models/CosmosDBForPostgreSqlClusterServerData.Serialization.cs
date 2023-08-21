// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDBForPostgreSql.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    public partial class CosmosDBForPostgreSqlClusterServerData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ServerEdition))
            {
                writer.WritePropertyName("serverEdition"u8);
                writer.WriteStringValue(ServerEdition);
            }
            if (Core.Optional.IsDefined(StorageQuotaInMb))
            {
                writer.WritePropertyName("storageQuotaInMb"u8);
                writer.WriteNumberValue(StorageQuotaInMb.Value);
            }
            if (Core.Optional.IsDefined(VCores))
            {
                writer.WritePropertyName("vCores"u8);
                writer.WriteNumberValue(VCores.Value);
            }
            if (Core.Optional.IsDefined(IsHAEnabled))
            {
                writer.WritePropertyName("enableHa"u8);
                writer.WriteBooleanValue(IsHAEnabled.Value);
            }
            if (Core.Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.Value.ToString());
            }
            if (Core.Optional.IsDefined(AvailabilityZone))
            {
                writer.WritePropertyName("availabilityZone"u8);
                writer.WriteStringValue(AvailabilityZone);
            }
            if (Core.Optional.IsDefined(PostgresqlVersion))
            {
                writer.WritePropertyName("postgresqlVersion"u8);
                writer.WriteStringValue(PostgresqlVersion);
            }
            if (Core.Optional.IsDefined(CitusVersion))
            {
                writer.WritePropertyName("citusVersion"u8);
                writer.WriteStringValue(CitusVersion);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CosmosDBForPostgreSqlClusterServerData DeserializeCosmosDBForPostgreSqlClusterServerData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> serverEdition = default;
            Core.Optional<int> storageQuotaInMb = default;
            Core.Optional<int> vCores = default;
            Core.Optional<bool> enableHa = default;
            Core.Optional<bool> enablePublicIPAccess = default;
            Core.Optional<bool> isReadOnly = default;
            Core.Optional<string> administratorLogin = default;
            Core.Optional<string> fullyQualifiedDomainName = default;
            Core.Optional<CosmosDBForPostgreSqlServerRole> role = default;
            Core.Optional<string> state = default;
            Core.Optional<string> haState = default;
            Core.Optional<string> availabilityZone = default;
            Core.Optional<string> postgresqlVersion = default;
            Core.Optional<string> citusVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serverEdition"u8))
                        {
                            serverEdition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageQuotaInMb"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageQuotaInMb = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("vCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vCores = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enableHa"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableHa = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enablePublicIpAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePublicIPAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isReadOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isReadOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("administratorLogin"u8))
                        {
                            administratorLogin = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fullyQualifiedDomainName"u8))
                        {
                            fullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("role"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            role = new CosmosDBForPostgreSqlServerRole(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("haState"u8))
                        {
                            haState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("availabilityZone"u8))
                        {
                            availabilityZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("postgresqlVersion"u8))
                        {
                            postgresqlVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("citusVersion"u8))
                        {
                            citusVersion = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CosmosDBForPostgreSqlClusterServerData(id, name, type, systemData.Value, serverEdition.Value, Core.Optional.ToNullable(storageQuotaInMb), Core.Optional.ToNullable(vCores), Core.Optional.ToNullable(enableHa), Core.Optional.ToNullable(enablePublicIPAccess), Core.Optional.ToNullable(isReadOnly), administratorLogin.Value, fullyQualifiedDomainName.Value, Core.Optional.ToNullable(role), state.Value, haState.Value, availabilityZone.Value, postgresqlVersion.Value, citusVersion.Value);
        }
    }
}
