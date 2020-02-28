// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Prediction;

namespace Azure.AI.FormRecognizer.Serialization
{
    internal class TextLineJson
    {
        public static RawExtractedLine Read(JsonElement root)
        {
            var textLine = RawExtractedLine.Create();
            if (root.ValueKind == JsonValueKind.Object)
            {
                foreach (JsonProperty property in root.EnumerateObject())
                {
                    ReadPropertyValue(ref textLine, property);
                }
            }
            if (textLine.Words == default)
            {
                //textLine.Words = Array.Empty<ExtractedWord>();
            }
            return textLine;
        }

#pragma warning disable CA1801
        private static void ReadPropertyValue(ref RawExtractedLine textLine, JsonProperty property)
#pragma warning restore CA1801
        {
            //if (property.NameEquals("text"))
            //{
            //    TextElementJson.ReadText(textLine, property.Value);
            //}
            //else if (property.NameEquals("boundingBox"))
            //{
            //    TextElementJson.ReadBoundingBox(textLine, property.Value);
            //}
            if (property.NameEquals("language"))
            {
                //textLine.Language = property.Value.GetString();
            }
            else if (property.NameEquals("words"))
            {
                //textLine.Words = ArrayJson.Read(property.Value, TextWordJson.Read);
            }
        }
    }
}