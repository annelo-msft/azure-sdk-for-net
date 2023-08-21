// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.Translation.Document;
using Azure.Core;

namespace Azure.AI.Translation.Document.Models
{
    internal partial class DocumentsStatus
    {
        internal static DocumentsStatus DeserializeDocumentsStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DocumentStatusResult> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DocumentStatusResult> array = new List<DocumentStatusResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentStatusResult.DeserializeDocumentStatusResult(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DocumentsStatus(value, nextLink.Value);
        }
    }
}
