// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryIntegrationRuntimePatch : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(AutoUpdate))
            {
                writer.WritePropertyName("autoUpdate"u8);
                writer.WriteStringValue(AutoUpdate.Value.ToString());
            }
            if (Core.Optional.IsDefined(UpdateDelayOffset))
            {
                writer.WritePropertyName("updateDelayOffset"u8);
                writer.WriteStringValue(UpdateDelayOffset.Value, "P");
            }
            writer.WriteEndObject();
        }
    }
}
