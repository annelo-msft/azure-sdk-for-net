// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class ExtractedSummarySentence : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            writer.WritePropertyName("rankScore"u8);
            writer.WriteNumberValue(RankScore);
            writer.WritePropertyName("offset"u8);
            writer.WriteNumberValue(Offset);
            writer.WritePropertyName("length"u8);
            writer.WriteNumberValue(Length);
            writer.WriteEndObject();
        }

        internal static ExtractedSummarySentence DeserializeExtractedSummarySentence(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            double rankScore = default;
            int offset = default;
            int length = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rankScore"u8))
                {
                    rankScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
            }
            return new ExtractedSummarySentence(text, rankScore, offset, length);
        }
    }
}
