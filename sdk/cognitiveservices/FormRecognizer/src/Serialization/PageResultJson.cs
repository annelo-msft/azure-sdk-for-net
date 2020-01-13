// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.AI.FormRecognizer.Models;

namespace Azure.AI.FormRecognizer.Serialization
{
    internal class PageResultJson
    {
        public static PageResult Read(JsonElement root)
        {
            var pageResult = PageResult.Create();
            foreach (JsonProperty property in root.EnumerateObject())
            {
                ReadPropertyValue(ref pageResult, property);
            }
            return pageResult;
        }

        private static void ReadPropertyValue(ref PageResult readResult, JsonProperty property)
        {
            if (property.NameEquals("page"))
            {
                readResult.Page = property.Value.GetInt32();
            }
            else if (property.NameEquals("clusterId"))
            {
                readResult.ClusterId = property.Value.GetInt32();
            }
            else if (property.NameEquals("keyValuePairs"))
            {
                readResult.KeyValuePairs = ArrayJson.Read(property.Value, KeyValuePairJson.Read);
            }
            else if (property.NameEquals("tables"))
            {
                readResult.Tables = ArrayJson.Read(property.Value, DataTableJson.Read);
            }
        }
    }
}