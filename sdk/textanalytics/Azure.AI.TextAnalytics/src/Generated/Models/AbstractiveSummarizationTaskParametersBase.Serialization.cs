// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AbstractiveSummarizationTaskParametersBase : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(SentenceCount))
            {
                writer.WritePropertyName("sentenceCount"u8);
                writer.WriteNumberValue(SentenceCount.Value);
            }
            if (Core.Optional.IsDefined(StringIndexType))
            {
                writer.WritePropertyName("stringIndexType"u8);
                writer.WriteStringValue(StringIndexType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AbstractiveSummarizationTaskParametersBase DeserializeAbstractiveSummarizationTaskParametersBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<int> sentenceCount = default;
            Core.Optional<StringIndexType> stringIndexType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sentenceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sentenceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stringIndexType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stringIndexType = new StringIndexType(property.Value.GetString());
                    continue;
                }
            }
            return new AbstractiveSummarizationTaskParametersBase(Core.Optional.ToNullable(sentenceCount), Core.Optional.ToNullable(stringIndexType));
        }
    }
}
