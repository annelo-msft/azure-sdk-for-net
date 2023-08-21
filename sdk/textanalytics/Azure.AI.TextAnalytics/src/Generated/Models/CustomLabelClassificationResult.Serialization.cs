// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class CustomLabelClassificationResult : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("documents"u8);
            writer.WriteStartArray();
            foreach (var item in Documents)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("errors"u8);
            writer.WriteStartArray();
            foreach (var item in Errors)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Core.Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics"u8);
                writer.WriteObjectValue(Statistics);
            }
            writer.WritePropertyName("projectName"u8);
            writer.WriteStringValue(ProjectName);
            writer.WritePropertyName("deploymentName"u8);
            writer.WriteStringValue(DeploymentName);
            writer.WriteEndObject();
        }

        internal static CustomLabelClassificationResult DeserializeCustomLabelClassificationResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<CustomLabelClassificationResultDocumentsItem> documents = default;
            IList<DocumentError> errors = default;
            Core.Optional<TextDocumentBatchStatistics> statistics = default;
            string projectName = default;
            string deploymentName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documents"u8))
                {
                    List<CustomLabelClassificationResultDocumentsItem> array = new List<CustomLabelClassificationResultDocumentsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomLabelClassificationResultDocumentsItem.DeserializeCustomLabelClassificationResultDocumentsItem(item));
                    }
                    documents = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    List<DocumentError> array = new List<DocumentError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentError.DeserializeDocumentError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("statistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statistics = TextDocumentBatchStatistics.DeserializeTextDocumentBatchStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("projectName"u8))
                {
                    projectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentName"u8))
                {
                    deploymentName = property.Value.GetString();
                    continue;
                }
            }
            return new CustomLabelClassificationResult(errors, statistics.Value, projectName, deploymentName, documents);
        }
    }
}
