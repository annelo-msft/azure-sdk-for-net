// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class RoleAssignmentResourceFormatData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStartObject();
                foreach (var item in DisplayName)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsCollectionDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStartObject();
                foreach (var item in Description)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.Value.ToSerialString());
            }
            if (Core.Optional.IsCollectionDefined(Principals))
            {
                writer.WritePropertyName("principals"u8);
                writer.WriteStartArray();
                foreach (var item in Principals)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(Profiles))
            {
                writer.WritePropertyName("profiles"u8);
                writer.WriteObjectValue(Profiles);
            }
            if (Core.Optional.IsDefined(Interactions))
            {
                writer.WritePropertyName("interactions"u8);
                writer.WriteObjectValue(Interactions);
            }
            if (Core.Optional.IsDefined(Links))
            {
                writer.WritePropertyName("links"u8);
                writer.WriteObjectValue(Links);
            }
            if (Core.Optional.IsDefined(Kpis))
            {
                writer.WritePropertyName("kpis"u8);
                writer.WriteObjectValue(Kpis);
            }
            if (Core.Optional.IsDefined(SasPolicies))
            {
                writer.WritePropertyName("sasPolicies"u8);
                writer.WriteObjectValue(SasPolicies);
            }
            if (Core.Optional.IsDefined(Connectors))
            {
                writer.WritePropertyName("connectors"u8);
                writer.WriteObjectValue(Connectors);
            }
            if (Core.Optional.IsDefined(Views))
            {
                writer.WritePropertyName("views"u8);
                writer.WriteObjectValue(Views);
            }
            if (Core.Optional.IsDefined(RelationshipLinks))
            {
                writer.WritePropertyName("relationshipLinks"u8);
                writer.WriteObjectValue(RelationshipLinks);
            }
            if (Core.Optional.IsDefined(Relationships))
            {
                writer.WritePropertyName("relationships"u8);
                writer.WriteObjectValue(Relationships);
            }
            if (Core.Optional.IsDefined(WidgetTypes))
            {
                writer.WritePropertyName("widgetTypes"u8);
                writer.WriteObjectValue(WidgetTypes);
            }
            if (Core.Optional.IsDefined(RoleAssignments))
            {
                writer.WritePropertyName("roleAssignments"u8);
                writer.WriteObjectValue(RoleAssignments);
            }
            if (Core.Optional.IsDefined(ConflationPolicies))
            {
                writer.WritePropertyName("conflationPolicies"u8);
                writer.WriteObjectValue(ConflationPolicies);
            }
            if (Core.Optional.IsDefined(Segments))
            {
                writer.WritePropertyName("segments"u8);
                writer.WriteObjectValue(Segments);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RoleAssignmentResourceFormatData DeserializeRoleAssignmentResourceFormatData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<Guid> tenantId = default;
            Core.Optional<string> assignmentName = default;
            Core.Optional<IDictionary<string, string>> displayName = default;
            Core.Optional<IDictionary<string, string>> description = default;
            Core.Optional<ProvisioningState> provisioningState = default;
            Core.Optional<RoleType> role = default;
            Core.Optional<IList<AssignmentPrincipal>> principals = default;
            Core.Optional<ResourceSetDescription> profiles = default;
            Core.Optional<ResourceSetDescription> interactions = default;
            Core.Optional<ResourceSetDescription> links = default;
            Core.Optional<ResourceSetDescription> kpis = default;
            Core.Optional<ResourceSetDescription> sasPolicies = default;
            Core.Optional<ResourceSetDescription> connectors = default;
            Core.Optional<ResourceSetDescription> views = default;
            Core.Optional<ResourceSetDescription> relationshipLinks = default;
            Core.Optional<ResourceSetDescription> relationships = default;
            Core.Optional<ResourceSetDescription> widgetTypes = default;
            Core.Optional<ResourceSetDescription> roleAssignments = default;
            Core.Optional<ResourceSetDescription> conflationPolicies = default;
            Core.Optional<ResourceSetDescription> segments = default;
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
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("assignmentName"u8))
                        {
                            assignmentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
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
                            displayName = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
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
                            description = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("role"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            role = property0.Value.GetString().ToRoleType();
                            continue;
                        }
                        if (property0.NameEquals("principals"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AssignmentPrincipal> array = new List<AssignmentPrincipal>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AssignmentPrincipal.DeserializeAssignmentPrincipal(item));
                            }
                            principals = array;
                            continue;
                        }
                        if (property0.NameEquals("profiles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            profiles = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("interactions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interactions = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("links"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            links = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("kpis"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            kpis = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sasPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sasPolicies = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("connectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectors = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("views"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            views = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("relationshipLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            relationshipLinks = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("relationships"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            relationships = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("widgetTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            widgetTypes = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("roleAssignments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleAssignments = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("conflationPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            conflationPolicies = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("segments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            segments = ResourceSetDescription.DeserializeResourceSetDescription(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RoleAssignmentResourceFormatData(id, name, type, systemData.Value, Core.Optional.ToNullable(tenantId), assignmentName.Value, Core.Optional.ToDictionary(displayName), Core.Optional.ToDictionary(description), Core.Optional.ToNullable(provisioningState), Core.Optional.ToNullable(role), Core.Optional.ToList(principals), profiles.Value, interactions.Value, links.Value, kpis.Value, sasPolicies.Value, connectors.Value, views.Value, relationshipLinks.Value, relationships.Value, widgetTypes.Value, roleAssignments.Value, conflationPolicies.Value, segments.Value);
        }
    }
}
