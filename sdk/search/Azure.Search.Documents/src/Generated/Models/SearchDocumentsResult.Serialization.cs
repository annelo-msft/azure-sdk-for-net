// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Models
{
    internal partial class SearchDocumentsResult
    {
        internal static SearchDocumentsResult DeserializeSearchDocumentsResult(JsonElement element)
        {
            SearchDocumentsResult result = new SearchDocumentsResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("@search.coverage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Coverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@search.facets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Facets = new Dictionary<string, IList<FacetResult>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        IList<FacetResult> value = new List<FacetResult>();
                        foreach (var item in property0.Value.EnumerateArray())
                        {
                            value.Add(FacetResult.DeserializeFacetResult(item));
                        }
                        result.Facets.Add(property0.Name, value);
                    }
                    continue;
                }
                if (property.NameEquals("@search.nextPageParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.NextPageParameters = SearchOptions.DeserializeSearchOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Results.Add(SearchResult.DeserializeSearchResult(item));
                    }
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.NextLink = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
