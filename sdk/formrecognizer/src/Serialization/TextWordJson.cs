// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Prediction;

namespace Azure.AI.FormRecognizer.Serialization
{
    internal class TextWordJson
    {
        public static RawExtractedWord Read(JsonElement root)
        {
            var textWord = RawExtractedWord.Create();
            if (root.ValueKind == JsonValueKind.Object)
            {
                foreach (JsonProperty property in root.EnumerateObject())
                {
                    ReadPropertyValue(ref textWord, property);
                }
            }
            return textWord;
        }

#pragma warning disable CA1801
        private static void ReadPropertyValue(ref RawExtractedWord textWord, JsonProperty property)
        {
#pragma warning restore CA1801
            //if (property.NameEquals("text"))
            //{
            //    TextElementJson.ReadText(textWord, property.Value);
            //}
            //else if (property.NameEquals("boundingBox"))
            //{
            //    TextElementJson.ReadBoundingBox(textWord, property.Value);
            //}
            if (property.NameEquals("confidence"))
            {
                //textWord.Confidence = property.Value.GetSingle();
            }
        }
    }
}