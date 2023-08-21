// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeIotRole : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(HostPlatform))
            {
                writer.WritePropertyName("hostPlatform"u8);
                writer.WriteStringValue(HostPlatform.Value.ToString());
            }
            if (Core.Optional.IsDefined(IotDeviceDetails))
            {
                writer.WritePropertyName("ioTDeviceDetails"u8);
                writer.WriteObjectValue(IotDeviceDetails);
            }
            if (Core.Optional.IsDefined(IotEdgeDeviceDetails))
            {
                writer.WritePropertyName("ioTEdgeDeviceDetails"u8);
                writer.WriteObjectValue(IotEdgeDeviceDetails);
            }
            if (Core.Optional.IsCollectionDefined(ShareMappings))
            {
                writer.WritePropertyName("shareMappings"u8);
                writer.WriteStartArray();
                foreach (var item in ShareMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(IotEdgeAgentInfo))
            {
                writer.WritePropertyName("ioTEdgeAgentInfo"u8);
                writer.WriteObjectValue(IotEdgeAgentInfo);
            }
            if (Core.Optional.IsDefined(ComputeResource))
            {
                writer.WritePropertyName("computeResource"u8);
                writer.WriteObjectValue(ComputeResource);
            }
            if (Core.Optional.IsDefined(RoleStatus))
            {
                writer.WritePropertyName("roleStatus"u8);
                writer.WriteStringValue(RoleStatus.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static EdgeIotRole DeserializeEdgeIotRole(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxEdgeRoleType kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<DataBoxEdgeOSPlatformType> hostPlatform = default;
            Core.Optional<EdgeIotDeviceInfo> iotDeviceDetails = default;
            Core.Optional<EdgeIotDeviceInfo> iotEdgeDeviceDetails = default;
            Core.Optional<IList<DataBoxEdgeMountPointMap>> shareMappings = default;
            Core.Optional<IotEdgeAgentInfo> iotEdgeAgentInfo = default;
            Core.Optional<HostPlatformType> hostPlatformType = default;
            Core.Optional<EdgeComputeResourceInfo> computeResource = default;
            Core.Optional<DataBoxEdgeRoleStatus> roleStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new DataBoxEdgeRoleType(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("hostPlatform"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostPlatform = new DataBoxEdgeOSPlatformType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ioTDeviceDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iotDeviceDetails = EdgeIotDeviceInfo.DeserializeEdgeIotDeviceInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ioTEdgeDeviceDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iotEdgeDeviceDetails = EdgeIotDeviceInfo.DeserializeEdgeIotDeviceInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("shareMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeMountPointMap> array = new List<DataBoxEdgeMountPointMap>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeMountPointMap.DeserializeDataBoxEdgeMountPointMap(item));
                            }
                            shareMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("ioTEdgeAgentInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iotEdgeAgentInfo = IotEdgeAgentInfo.DeserializeIotEdgeAgentInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostPlatformType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostPlatformType = new HostPlatformType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("computeResource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeResource = EdgeComputeResourceInfo.DeserializeEdgeComputeResourceInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("roleStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleStatus = new DataBoxEdgeRoleStatus(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new EdgeIotRole(id, name, type, systemData.Value, kind, Core.Optional.ToNullable(hostPlatform), iotDeviceDetails.Value, iotEdgeDeviceDetails.Value, Core.Optional.ToList(shareMappings), iotEdgeAgentInfo.Value, Core.Optional.ToNullable(hostPlatformType), computeResource.Value, Core.Optional.ToNullable(roleStatus));
        }
    }
}
