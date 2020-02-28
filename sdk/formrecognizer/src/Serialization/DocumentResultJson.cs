// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.FormRecognizer.Custom;
using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Prediction;

namespace Azure.AI.FormRecognizer.Serialization
{
    internal class DocumentResultJson
    {
        public static ExtractedLabeledForm Read(JsonElement root)
        {
            var documentResult = ExtractedLabeledForm.Create();
            if (root.ValueKind == JsonValueKind.Object)
            {
                foreach (JsonProperty property in root.EnumerateObject())
                {
                    ReadPropertyValue(ref documentResult, property);
                }
            }
            //if (documentResult.FormFields == default)
            //{
            //    documentResult.FormFields = new Dictionary<string, FieldValue_internal>();
            //}
            return documentResult;
        }

#pragma warning disable CA1801
        private static void ReadPropertyValue(ref ExtractedLabeledForm documentResult, JsonProperty property)
#pragma warning restore CA1801
        {
            if (property.NameEquals("docType"))
            {
                //documentResult.FormType = property.Value.GetString();
            }
            else if (property.NameEquals("pageRange"))
            {
                var array = property.Value.EnumerateArray();
                var start = array.Current.GetInt32();
                array.MoveNext();
                var end = array.Current.GetInt32();
                //documentResult.FormPageRange = (start, end);
            }
            //else if (property.NameEquals("fields"))
            //{
            //    documentResult.FormFields = ObjectJson.Read(property.Value, FieldValueJson.Read);
            //}
        }
    }
}