// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class OrchestrationServiceStateContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("serviceName"u8);
            writer.WriteStringValue(ServiceName.ToString());
            writer.WritePropertyName("action"u8);
            writer.WriteStringValue(Action.ToString());
            writer.WriteEndObject();
        }
    }
}
