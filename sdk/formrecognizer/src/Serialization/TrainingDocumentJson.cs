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
        public static TrainingInputResult Read(JsonElement root)
        {
            var trainingDocument = TrainingInputResult.Create();
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

        private static void ReadPropertyValue(ref TrainingInputResult trainingDocument, JsonProperty property)
        {
            if (property.NameEquals("documentName"))
            {
                trainingDocument.DocumentName = property.Value.GetString();
            }
            else if (property.NameEquals("pages"))
            {
                trainingDocument.TotalTrainedPages = property.Value.GetInt32();
            }
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