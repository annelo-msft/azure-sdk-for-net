// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Document
{
    public partial class TranslationTarget : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetUrl"u8);
            writer.WriteStringValue(TargetUri.AbsoluteUri);
            if (Core.Optional.IsDefined(CategoryId))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(CategoryId);
            }
            writer.WritePropertyName("language"u8);
            writer.WriteStringValue(LanguageCode);
            if (Core.Optional.IsCollectionDefined(Glossaries))
            {
                writer.WritePropertyName("glossaries"u8);
                writer.WriteStartArray();
                foreach (var item in Glossaries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(StorageSource))
            {
                writer.WritePropertyName("storageSource"u8);
                writer.WriteStringValue(StorageSource);
            }
            writer.WriteEndObject();
        }
    }
}
