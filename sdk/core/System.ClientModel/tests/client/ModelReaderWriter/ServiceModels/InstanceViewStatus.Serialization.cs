// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using ClientModel.Tests.ClientShared;
using System;
using System.ClientModel.Primitives;
using System.Globalization;
using System.Text.Json;

namespace ClientModel.Tests.Client.Models.ResourceManager.Compute
{
    public partial class InstanceViewStatus : IJsonModel<InstanceViewStatus>
    {
        void IJsonModel<InstanceViewStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (OptionalProperty.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (OptionalProperty.IsDefined(Level))
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level.Value.ToSerialString());
            }
            if (OptionalProperty.IsDefined(DisplayStatus))
            {
                writer.WritePropertyName("displayStatus"u8);
                writer.WriteStringValue(DisplayStatus);
            }
            if (OptionalProperty.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (OptionalProperty.IsDefined(Time))
            {
                writer.WritePropertyName("time"u8);
                writer.WriteStringValue(Time.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static InstanceViewStatus DeserializeInstanceViewStatus(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterHelper.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OptionalProperty<string> code = default;
            OptionalProperty<ComputeStatusLevelType> level = default;
            OptionalProperty<string> displayStatus = default;
            OptionalProperty<string> message = default;
            OptionalProperty<DateTimeOffset> time = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    level = property.Value.GetString().ToComputeStatusLevelType();
                    continue;
                }
                if (property.NameEquals("displayStatus"u8))
                {
                    displayStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("time"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    time = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new InstanceViewStatus(code.Value, OptionalProperty.ToNullable(level), displayStatus.Value, message.Value, OptionalProperty.ToNullable(time));
        }

        private struct InstanceViewStatusProperties
        {
            public OptionalProperty<string> Code { get; set; }
            public OptionalProperty<ComputeStatusLevelType> Level { get; set; }
            public OptionalProperty<string> DisplayStatus { get; set; }
            public OptionalProperty<string> Message { get; set; }
            public OptionalProperty<DateTimeOffset> Time { get; set; }
        }

        InstanceViewStatus IJsonModel<InstanceViewStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInstanceViewStatus(doc.RootElement, options);
        }

        private static void SetProperty(ReadOnlySpan<byte> propertyName, ref InstanceViewStatusProperties properties, ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            if (propertyName.SequenceEqual("code"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Code = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("level"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Level = reader.GetString().ToComputeStatusLevelType();
                return;
            }
            if (propertyName.SequenceEqual("displayStatus"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.DisplayStatus = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("message"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Message = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("time"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Time = DateTimeOffset.Parse(reader.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
                return;
            }
            reader.Skip();
        }

        InstanceViewStatus IPersistableModel<InstanceViewStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeInstanceViewStatus(doc.RootElement, options);
        }

        BinaryData IPersistableModel<InstanceViewStatus>.Write(ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.Write(this, options);
        }

        string IPersistableModel<InstanceViewStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
