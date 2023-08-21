// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class AccountSasContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("signedServices"u8);
            writer.WriteStringValue(Services.ToString());
            writer.WritePropertyName("signedResourceTypes"u8);
            writer.WriteStringValue(ResourceTypes.ToString());
            writer.WritePropertyName("signedPermission"u8);
            writer.WriteStringValue(Permissions.ToString());
            if (Core.Optional.IsDefined(IPAddressOrRange))
            {
                writer.WritePropertyName("signedIp"u8);
                writer.WriteStringValue(IPAddressOrRange);
            }
            if (Core.Optional.IsDefined(Protocols))
            {
                writer.WritePropertyName("signedProtocol"u8);
                writer.WriteStringValue(Protocols.Value.ToSerialString());
            }
            if (Core.Optional.IsDefined(SharedAccessStartOn))
            {
                writer.WritePropertyName("signedStart"u8);
                writer.WriteStringValue(SharedAccessStartOn.Value, "O");
            }
            writer.WritePropertyName("signedExpiry"u8);
            writer.WriteStringValue(SharedAccessExpireOn, "O");
            if (Core.Optional.IsDefined(KeyToSign))
            {
                writer.WritePropertyName("keyToSign"u8);
                writer.WriteStringValue(KeyToSign);
            }
            writer.WriteEndObject();
        }
    }
}
