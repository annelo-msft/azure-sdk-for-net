// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;

namespace Azure.Core.Json
{
    internal struct MutableJsonChange
    {
        public string Path { get; set; }

        public int Index { get; set; }

        public object? Value { get; set; }

        /// <summary>
        /// The change invalidates the existing node's JsonElement
        /// due to changes in JsonValueKind or path structure.
        /// If this is true, Value holds a new JsonElement.
        /// </summary>
        public bool ReplacesJsonElement { get; set; }

        internal JsonElement AsJsonElement(JsonSerializerOptions options)
        {
            if (Value is JsonElement element)
            {
                return element;
            }

            byte[] bytes = JsonSerializer.SerializeToUtf8Bytes(Value, options);
            return JsonDocument.Parse(bytes).RootElement;
        }

        public override string ToString()
        {
            return $"Path={Path}; Value={Value}; ReplacesJsonElement={ReplacesJsonElement}";
        }
    }
}
