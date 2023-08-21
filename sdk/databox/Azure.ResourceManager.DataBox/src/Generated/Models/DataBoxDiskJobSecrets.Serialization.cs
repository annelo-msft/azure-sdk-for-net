// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxDiskJobSecrets
    {
        internal static DataBoxDiskJobSecrets DeserializeDataBoxDiskJobSecrets(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<DataBoxDiskSecret>> diskSecrets = default;
            Core.Optional<string> passKey = default;
            Core.Optional<bool> isPasskeyUserDefined = default;
            DataBoxOrderType jobSecretsType = default;
            Core.Optional<DataCenterAccessSecurityCode> dcAccessSecurityCode = default;
            Core.Optional<ResponseError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskSecrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxDiskSecret> array = new List<DataBoxDiskSecret>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxDiskSecret.DeserializeDataBoxDiskSecret(item));
                    }
                    diskSecrets = array;
                    continue;
                }
                if (property.NameEquals("passKey"u8))
                {
                    passKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPasskeyUserDefined"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPasskeyUserDefined = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("jobSecretsType"u8))
                {
                    jobSecretsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (property.NameEquals("dcAccessSecurityCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dcAccessSecurityCode = DataCenterAccessSecurityCode.DeserializeDataCenterAccessSecurityCode(property.Value);
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
            }
            return new DataBoxDiskJobSecrets(jobSecretsType, dcAccessSecurityCode.Value, error.Value, Core.Optional.ToList(diskSecrets), passKey.Value, Core.Optional.ToNullable(isPasskeyUserDefined));
        }
    }
}
