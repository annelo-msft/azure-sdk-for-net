// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Learn.Computation.Models
{
    public partial class Operation
    {
        internal static Operation DeserializeOperation(JsonElement element)
        {
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<float> percentComplete = default;
            Optional<OperationStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createdDateTime"))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("percentComplete"))
                {
                    percentComplete = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new OperationStatus(property.Value.GetString());
                    continue;
                }
            }
            return new Operation(Optional.ToNullable(createdDateTime), Optional.ToNullable(percentComplete), Optional.ToNullable(status));
        }
    }
}
