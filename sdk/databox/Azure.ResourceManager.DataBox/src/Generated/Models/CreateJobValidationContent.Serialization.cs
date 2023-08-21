// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class CreateJobValidationContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("validationCategory"u8);
            writer.WriteStringValue(ValidationCategory.ToString());
            writer.WritePropertyName("individualRequestDetails"u8);
            writer.WriteStartArray();
            foreach (var item in IndividualRequestDetails)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}
