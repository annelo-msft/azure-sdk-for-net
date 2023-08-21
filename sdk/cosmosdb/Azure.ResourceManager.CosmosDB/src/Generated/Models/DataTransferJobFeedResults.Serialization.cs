// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class DataTransferJobFeedResults
    {
        internal static DataTransferJobFeedResults DeserializeDataTransferJobFeedResults(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<DataTransferJobGetResultData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataTransferJobGetResultData> array = new List<DataTransferJobGetResultData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataTransferJobGetResultData.DeserializeDataTransferJobGetResultData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DataTransferJobFeedResults(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
