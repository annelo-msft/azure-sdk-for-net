// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.AI.FormRecognizer.Custom;
using Azure.AI.FormRecognizer.Models;

namespace Azure.AI.FormRecognizer.Serialization
{
    internal class TrainingDocumentJson
    {
        public static TrainingDocumentInfo Read(JsonElement root)
        {
            var trainingDocument = TrainingDocumentInfo.Create();
            if (root.ValueKind == JsonValueKind.Object)
            {
                foreach (JsonProperty property in root.EnumerateObject())
                {
                    ReadPropertyValue(ref trainingDocument, property);
                }
            }
            //if (trainingDocument.Errors == default)
            //{
            //    trainingDocument.Errors = Array.Empty<FormRecognizerError>();
            //}
            return trainingDocument;
        }

#pragma warning disable CA1801
        private static void ReadPropertyValue(ref TrainingDocumentInfo trainingDocument, JsonProperty property)
#pragma warning restore CA1801
        {
            //if (property.NameEquals("documentName"))
            //{
            //    trainingDocument.DocumentName = property.Value.GetString();
            //}
            //else if (property.NameEquals("pages"))
            //{
            //    trainingDocument.TotalTrainedPages = property.Value.GetInt32();
            //}
            //else if (property.NameEquals("errors"))
            //{
            //    trainingDocument.Errors = ArrayJson.Read(property.Value, ErrorDetailsJson.Read);
            //}
            //else if (property.NameEquals("status"))
            //{
            //    trainingDocument.Status = EnumJson.Read<TrainingInputSuccessStatus>(property.Value);
            //}
        }
    }
}