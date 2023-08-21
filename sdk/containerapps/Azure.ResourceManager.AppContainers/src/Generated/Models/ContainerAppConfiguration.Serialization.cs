// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets"u8);
                writer.WriteStartArray();
                foreach (var item in Secrets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(ActiveRevisionsMode))
            {
                writer.WritePropertyName("activeRevisionsMode"u8);
                writer.WriteStringValue(ActiveRevisionsMode.Value.ToString());
            }
            if (Core.Optional.IsDefined(Ingress))
            {
                writer.WritePropertyName("ingress"u8);
                writer.WriteObjectValue(Ingress);
            }
            if (Core.Optional.IsCollectionDefined(Registries))
            {
                writer.WritePropertyName("registries"u8);
                writer.WriteStartArray();
                foreach (var item in Registries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(Dapr))
            {
                writer.WritePropertyName("dapr"u8);
                writer.WriteObjectValue(Dapr);
            }
            if (Core.Optional.IsDefined(MaxInactiveRevisions))
            {
                writer.WritePropertyName("maxInactiveRevisions"u8);
                writer.WriteNumberValue(MaxInactiveRevisions.Value);
            }
            if (Core.Optional.IsDefined(Service))
            {
                writer.WritePropertyName("service"u8);
                writer.WriteObjectValue(Service);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppConfiguration DeserializeContainerAppConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<ContainerAppWritableSecret>> secrets = default;
            Core.Optional<ContainerAppActiveRevisionsMode> activeRevisionsMode = default;
            Core.Optional<ContainerAppIngressConfiguration> ingress = default;
            Core.Optional<IList<ContainerAppRegistryCredentials>> registries = default;
            Core.Optional<ContainerAppDaprConfiguration> dapr = default;
            Core.Optional<int> maxInactiveRevisions = default;
            Core.Optional<Service> service = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppWritableSecret> array = new List<ContainerAppWritableSecret>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppWritableSecret.DeserializeContainerAppWritableSecret(item));
                    }
                    secrets = array;
                    continue;
                }
                if (property.NameEquals("activeRevisionsMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activeRevisionsMode = new ContainerAppActiveRevisionsMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ingress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingress = ContainerAppIngressConfiguration.DeserializeContainerAppIngressConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("registries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppRegistryCredentials> array = new List<ContainerAppRegistryCredentials>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppRegistryCredentials.DeserializeContainerAppRegistryCredentials(item));
                    }
                    registries = array;
                    continue;
                }
                if (property.NameEquals("dapr"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dapr = ContainerAppDaprConfiguration.DeserializeContainerAppDaprConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("maxInactiveRevisions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxInactiveRevisions = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("service"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    service = Service.DeserializeService(property.Value);
                    continue;
                }
            }
            return new ContainerAppConfiguration(Core.Optional.ToList(secrets), Core.Optional.ToNullable(activeRevisionsMode), ingress.Value, Core.Optional.ToList(registries), dapr.Value, Core.Optional.ToNullable(maxInactiveRevisions), service.Value);
        }
    }
}
