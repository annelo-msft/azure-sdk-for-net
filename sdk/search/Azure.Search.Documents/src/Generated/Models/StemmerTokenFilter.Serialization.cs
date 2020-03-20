// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class StemmerTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("language");
            writer.WriteStringValue(Language.ToSerialString());
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static StemmerTokenFilter DeserializeStemmerTokenFilter(JsonElement element)
        {
            StemmerTokenFilter result = new StemmerTokenFilter();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("language"))
                {
                    result.Language = property.Value.GetString().ToStemmerTokenFilterLanguage();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    result.ODataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
