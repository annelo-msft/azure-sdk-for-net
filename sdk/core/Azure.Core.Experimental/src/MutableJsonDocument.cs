// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Buffers;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Core.Dynamic
{
    /// <summary>
    /// A mutable representation of a JSON value.
    /// </summary>
    [JsonConverter(typeof(JsonConverter))]
    public partial class MutableJsonDocument
    {
        internal static readonly JsonSerializerOptions DefaultJsonSerializerOptions = new JsonSerializerOptions();

        private readonly ReadOnlyMemory<byte> _original;
        private readonly JsonElement _originalElement;

        internal ChangeTracker Changes { get; } = new();

        /// <summary>
        /// Gets the root element of this JSON document.
        /// </summary>
        public MutableJsonElement RootElement
        {
            get
            {
                // TODO: hold static equivalent of string.Empty that is Memory<byte>
                if (Changes.TryGetChange(string.Empty, -1, out MutableJsonChange change))
                {
                    if (change.ReplacesJsonElement)
                    {
                        return new MutableJsonElement(this, change.AsJsonElement(), string.Empty, change.Index);
                    }
                }

                return new MutableJsonElement(this, _originalElement, string.Empty);
            }
        }

        /// <summary>
        /// Writes the document to the provided stream as a JSON value.
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="format"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void WriteTo(Stream stream, StandardFormat format = default)
        {
            // this is so we can add JSON Patch in the future
            if (format != default)
            {
                throw new ArgumentOutOfRangeException(nameof(format));
            }

            Utf8JsonWriter writer = new(stream);
            if (!Changes.HasChanges)
            {
                Write(stream, _original.Span);
                stream.Flush();
                return;
            }

            WriteRootElementTo(writer);
        }

        internal void WriteTo(Utf8JsonWriter writer)
        {
            if (!Changes.HasChanges)
            {
                _originalElement.WriteTo(writer);
                return;
            }

            WriteRootElementTo(writer);
        }

        private static void Write(Stream stream, ReadOnlySpan<byte> buffer)
        {
            byte[] sharedBuffer = ArrayPool<byte>.Shared.Rent(buffer.Length);
            try
            {
                buffer.CopyTo(sharedBuffer);
                stream.Write(sharedBuffer, 0, buffer.Length);
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(sharedBuffer);
            }
        }

        /// <summary>
        /// Parses a UTF-8 encoded string representing a single JSON value into a <see cref="MutableJsonDocument"/>.
        /// </summary>
        /// <param name="utf8Json">A UTF-8 encoded string representing a JSON value.</param>
        /// <returns>A <see cref="MutableJsonDocument"/> representation of the value.</returns>
        public static MutableJsonDocument Parse(BinaryData utf8Json)
        {
            var doc = JsonDocument.Parse(utf8Json);
            return new MutableJsonDocument(doc, utf8Json.ToMemory());
        }

        /// <summary>
        /// Parses test representing a single JSON value into a <see cref="MutableJsonDocument"/>.
        /// </summary>
        /// <param name="json">The JSON string.</param>
        /// <returns>A <see cref="MutableJsonDocument"/> representation of the value.</returns>
        public static MutableJsonDocument Parse(string json)
        {
            // TODO: Use System.Text.Unicode.UTF8 instead on .NET6 and above.
            byte[] utf8 = Encoding.UTF8.GetBytes(json);
            ReadOnlyMemory<byte> jsonMemory = utf8.AsMemory();
            return new MutableJsonDocument(JsonDocument.Parse(jsonMemory), jsonMemory);
        }

        internal MutableJsonDocument(JsonDocument jsonDocument, ReadOnlyMemory<byte> utf8Json) : this(jsonDocument.RootElement)
        {
            _original = utf8Json;
            _originalElement = jsonDocument.RootElement;
        }

        /// <summary>
        /// Creates a new JsonData object which represents the given object.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        internal MutableJsonDocument(object? value) : this(value, DefaultJsonSerializerOptions)
        {
        }

        /// <summary>
        /// Creates a new JsonData object which represents the given object.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="options">Options to control the conversion behavior.</param>
        /// <param name="type">The type of the value to convert. </param>
        internal MutableJsonDocument(object? value, JsonSerializerOptions options, Type? type = null)
        {
            // TODO: can we combine this with the JsonDocument constructor now?
            Debug.Assert(value is not JsonDocument);

            Type inputType = type ?? (value == null ? typeof(object) : value.GetType());

            // TODO: if this is passed a JsonElement, can we do better?
            _original = JsonSerializer.SerializeToUtf8Bytes(value, inputType, options);
            _originalElement = JsonDocument.Parse(_original).RootElement;
        }

        internal const byte Utf8Delimiter = (byte)'.';

        // TODO: Move into extensions
        internal static string Utf8SpanToString(ReadOnlySpan<byte> utf8)
        {
            // TODO: Don't use ToArray(), it makes an allocation.
            byte[] utf8Bytes = utf8.ToArray();
            return Encoding.UTF8.GetString(utf8Bytes);
        }

        internal static ReadOnlyMemory<byte> StringToUtf8(string value)
        {
            // Convert to Utf8 from Utf16
            // TODO: use System.Text.Unicode.UTF8 where available
            byte[] utf8Bytes = Encoding.UTF8.GetBytes(value);

            // Does this allocate?
            return utf8Bytes.AsMemory();
        }

        private class JsonConverter : JsonConverter<MutableJsonDocument>
        {
            public override MutableJsonDocument Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using JsonDocument document = JsonDocument.ParseValue(ref reader);
                return new MutableJsonDocument(document.RootElement);
            }

            public override void Write(Utf8JsonWriter writer, MutableJsonDocument value, JsonSerializerOptions options)
            {
                value.WriteTo(writer);
            }
        }
    }
}
