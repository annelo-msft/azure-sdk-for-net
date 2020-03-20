// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.FormRecognizer.Models;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Custom
{
    public partial class TrainingDocumentInfo
    {
        internal static TrainingDocumentInfo DeserializeTrainingDocumentInfo(JsonElement element)
        {
            TrainingDocumentInfo result = new TrainingDocumentInfo();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documentName"))
                {
                    result.DocumentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pages"))
                {
                    result.PageCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Errors.Add(FormRecognizerError.DeserializeFormRecognizerError(item));
                    }
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    result.Status = property.Value.GetString().ToTrainStatus();
                    continue;
                }
            }
            return result;
        }
    }
}
