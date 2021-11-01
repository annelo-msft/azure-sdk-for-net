// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class CustomSingleClassificationTaskParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("project-name");
            writer.WriteStringValue(ProjectName);
            writer.WritePropertyName("deployment-name");
            writer.WriteStringValue(DeploymentName);
            if (Optional.IsDefined(LoggingOptOut))
            {
                writer.WritePropertyName("loggingOptOut");
                writer.WriteBooleanValue(LoggingOptOut.Value);
            }
            writer.WriteEndObject();
        }
    }
}
