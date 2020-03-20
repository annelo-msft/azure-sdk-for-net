// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class AnalyzeResult
    {
        internal static AnalyzeResult DeserializeAnalyzeResult(JsonElement element)
        {
            AnalyzeResult result = new AnalyzeResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tokens"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Tokens.Add(TokenInfo.DeserializeTokenInfo(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
