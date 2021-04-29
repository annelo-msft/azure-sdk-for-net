// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Temp.Rbac.Models
{
    public partial class AuthorizationRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("Subject");
            writer.WriteObjectValue(Subject);
            writer.WritePropertyName("Actions");
            writer.WriteStartArray();
            foreach (var item in Actions)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Resource))
            {
                writer.WritePropertyName("Resource");
                writer.WriteObjectValue(Resource);
            }
            writer.WriteEndObject();
        }
    }
}
