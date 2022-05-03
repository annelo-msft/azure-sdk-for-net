// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate.Models
{
    public partial class Step
    {
        internal static Step DeserializeStep(JsonElement element)
        {
            Optional<StepType> type = default;
            Optional<string> description = default;
            Optional<string> handler = default;
            Optional<object> handlerProperties = default;
            Optional<IReadOnlyList<string>> files = default;
            Optional<UpdateId> updateId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new StepType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("handler"))
                {
                    handler = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("handlerProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    handlerProperties = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("files"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    files = array;
                    continue;
                }
                if (property.NameEquals("updateId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    updateId = UpdateId.DeserializeUpdateId(property.Value);
                    continue;
                }
            }
            return new Step(Optional.ToNullable(type), description.Value, handler.Value, handlerProperties.Value, Optional.ToList(files), updateId.Value);
        }
    }
}
