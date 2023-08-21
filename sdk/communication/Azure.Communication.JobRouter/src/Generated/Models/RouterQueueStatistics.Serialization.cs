// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    public partial class RouterQueueStatistics
    {
        internal static RouterQueueStatistics DeserializeRouterQueueStatistics(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string queueId = default;
            int length = default;
            Core.Optional<IReadOnlyDictionary<string, double>> estimatedWaitTimeMinutes = default;
            Core.Optional<double> longestJobWaitTimeMinutes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("estimatedWaitTimeMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, double> dictionary = new Dictionary<string, double>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetDouble());
                    }
                    estimatedWaitTimeMinutes = dictionary;
                    continue;
                }
                if (property.NameEquals("longestJobWaitTimeMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    longestJobWaitTimeMinutes = property.Value.GetDouble();
                    continue;
                }
            }
            return new RouterQueueStatistics(queueId, length, Core.Optional.ToDictionary(estimatedWaitTimeMinutes), Core.Optional.ToNullable(longestJobWaitTimeMinutes));
        }
    }
}
