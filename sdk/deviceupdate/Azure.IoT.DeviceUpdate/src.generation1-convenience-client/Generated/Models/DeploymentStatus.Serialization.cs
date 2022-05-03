// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate.Models
{
    public partial class DeploymentStatus
    {
        internal static DeploymentStatus DeserializeDeploymentStatus(JsonElement element)
        {
            DeploymentState deploymentState = default;
            Optional<int> totalDevices = default;
            Optional<int> devicesInProgressCount = default;
            Optional<int> devicesCompletedFailedCount = default;
            Optional<int> devicesCompletedSucceededCount = default;
            Optional<int> devicesCanceledCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentState"))
                {
                    deploymentState = new DeploymentState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalDevices"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalDevices = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("devicesInProgressCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    devicesInProgressCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("devicesCompletedFailedCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    devicesCompletedFailedCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("devicesCompletedSucceededCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    devicesCompletedSucceededCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("devicesCanceledCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    devicesCanceledCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new DeploymentStatus(deploymentState, Optional.ToNullable(totalDevices), Optional.ToNullable(devicesInProgressCount), Optional.ToNullable(devicesCompletedFailedCount), Optional.ToNullable(devicesCompletedSucceededCount), Optional.ToNullable(devicesCanceledCount));
        }
    }
}
