// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.AI.FormRecognizer.Custom;
using Azure.AI.FormRecognizer.Models;

namespace Azure.AI.FormRecognizer.Serialization
{
    internal class TrainingResultJson
    {
        public static TrainingResult_internal Read(JsonElement root)
        {
            var trainingResult = TrainingResult_internal.Create();
            if (root.ValueKind == JsonValueKind.Object)
            {
                foreach (JsonProperty property in root.EnumerateObject())
                {
                    ReadPropertyValue(ref trainingResult, property);
                }
            }
            //if (trainingResult.TrainingDocuments == default)
            //{
            //    trainingResult.TrainingDocuments = Array.Empty<DocumentTrainingResult>();
            //}
            if (trainingResult.FieldAccuracies == default)
            {
                trainingResult.FieldAccuracies = Array.Empty<PredefinedFieldAccuracy>();
            }
            if (trainingResult.Errors == default)
            {
                trainingResult.Errors = Array.Empty<FormRecognizerError>();
            }
            return trainingResult;
        }

        private static void ReadPropertyValue(ref TrainingResult_internal trainingResult, JsonProperty property)
        {
            //if (property.NameEquals("trainingDocuments"))
            //{
            //    trainingResult.TrainingDocuments = ArrayJson.Read(property.Value, TrainingDocumentJson.Read);
            //}
            if (property.NameEquals("fields"))
            {
                trainingResult.FieldAccuracies = ArrayJson.Read(property.Value, TrainingFieldJson.Read);
            }
            else if (property.NameEquals("averageModelAccuracy"))
            {
                trainingResult.AverageModelAccuracy = property.Value.GetSingle();
            }
            else if (property.NameEquals("errors"))
            {
                trainingResult.Errors = ArrayJson.Read(property.Value, ErrorDetailsJson.Read);
            }
        }
    }
}