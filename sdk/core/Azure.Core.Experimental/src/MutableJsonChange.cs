// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text;
using System.Text.Json;

namespace Azure.Core.Dynamic
{
    internal readonly struct MutableJsonChange
    {
        // TODO: move to Memory<byte> ?
        public string Path { get; }

        public ReadOnlyMemory<byte> Utf8Path { get; }

        public int Index { get; }

        public object? Value { get; }

        /// <summary>
        /// The change invalidates the existing node's JsonElement
        /// due to changes in JsonValueKind or path structure.
        /// If this is true, Value holds a new JsonElement.
        /// </summary>
        public bool ReplacesJsonElement { get; }

        public MutableJsonChange(string path, int index, object? value, bool replacesJsonElement)
        {
            Path = path;
            Index = index;
            Value = value;
            ReplacesJsonElement = replacesJsonElement;

            Utf8Path = MutableJsonDocument.StringToUtf8(path);
        }

        public MutableJsonChange(ReadOnlyMemory<byte> utf8Path, int index, object? value, bool replacesJsonElement)
        {
            Utf8Path = utf8Path;
            Index = index;
            Value = value;
            ReplacesJsonElement = replacesJsonElement;

            Path = MutableJsonDocument.Utf8SpanToString(utf8Path.Span);
        }

        internal Utf8JsonReader GetReader()
        {
            if (!ReplacesJsonElement)
            {
                // This change doesn't represent a new node, so we shouldn't need a new reader.
                throw new InvalidOperationException("Unable to get Utf8JsonReader for this change.");
            }

            return MutableJsonElement.GetReaderForElement(AsJsonElement());
        }

        internal JsonElement AsJsonElement()
        {
            if (Value is JsonElement element)
            {
                return element;
            }

            byte[] bytes = JsonSerializer.SerializeToUtf8Bytes(Value);
            return JsonDocument.Parse(bytes).RootElement;
        }

        public override string ToString()
        {
            return $"Path={Path}; Value={Value}; ReplacesJsonElement={ReplacesJsonElement}";
        }
    }
}
