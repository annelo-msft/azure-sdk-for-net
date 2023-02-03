// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics;
using System.Text.Json;

namespace Azure.Core.Dynamic
{
    public partial class MutableJsonDocument
    {
        private const int DefaultMaxPathLength = 128;

        private ref struct WriteToState
        {
            public Span<byte> Path { get; set; }
            public int PathLength { get; set; }
            public int HighWaterMark;
            public Utf8JsonReader Reader { get; set; }
        }

        internal void WriteRootElementTo(Utf8JsonWriter writer)
        {
            // Check for changes at the root.
            bool changed = Changes.TryGetChange(Span<byte>.Empty, -1, out MutableJsonChange change);
            Utf8JsonReader reader = changed ? change.GetReader() : new Utf8JsonReader(_original.Span);

            Span<byte> utf8Path = stackalloc byte[DefaultMaxPathLength];
            WriteElement(utf8Path, 0, -1, ref reader, writer);

            writer.Flush();
        }

        // TODO: fully grok `scoped` keyword
        internal void WriteElement(scoped Span<byte> utf8Path, int pathLength, int highWaterMark, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.StartObject:
                        writer.WriteStartObject();
                        WriteObjectProperties(utf8Path, pathLength, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.StartArray:
                        writer.WriteStartArray();
                        WriteArrayValues(utf8Path, pathLength, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.String:
                        WriteString(utf8Path, pathLength, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.Number:
                        WriteNumber(utf8Path, pathLength, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.True:
                    case JsonTokenType.False:
                        WriteBoolean(utf8Path, pathLength, highWaterMark, reader.TokenType, ref reader, writer);
                        break;
                    case JsonTokenType.Null:
                        WriteNull(utf8Path, pathLength, highWaterMark, ref reader, writer);
                        break;
                }
            }
        }

        private void WriteArrayValues(ReadOnlySpan<byte> utf8Path, int highWaterMark, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            int index = 0;

            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.StartObject:
                        path = ChangeTracker.PushIndex(path, index);
                        WriteObject(utf8Path, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.StartArray:
                        path = ChangeTracker.PushIndex(path, index);
                        writer.WriteStartArray();
                        WriteArrayValues(utf8Path, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.String:
                        path = ChangeTracker.PushIndex(path, index);
                        WriteString(utf8Path, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.Number:
                        path = ChangeTracker.PushIndex(path, index);
                        WriteNumber(utf8Path, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.True:
                    case JsonTokenType.False:
                        path = ChangeTracker.PushIndex(path, index);
                        WriteBoolean(utf8Path, highWaterMark, reader.TokenType, ref reader, writer);
                        break;
                    case JsonTokenType.Null:
                        path = ChangeTracker.PushIndex(path, index);
                        WriteNull(utf8Path, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.EndArray:
                        writer.WriteEndArray();
                        return;
                }

                utf8Path = ChangeTracker.PopIndex(utf8Path);
                index++;
            }
        }

        private void WriteObjectProperties(Span<byte> utf8Path, int pathLength, int highWaterMark, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.StartObject:
                        WriteObject(utf8Path, pathLength, highWaterMark, ref reader, writer);
                        utf8Path = ChangeTracker.PopProperty(utf8Path);
                        continue;
                    case JsonTokenType.StartArray:
                        writer.WriteStartArray();
                        WriteArrayValues(utf8Path, highWaterMark, ref reader, writer);
                        utf8Path = ChangeTracker.PopProperty(utf8Path);
                        continue;
                    case JsonTokenType.PropertyName:
                        path = ChangeTracker.PushProperty(path, reader.ValueSpan);

                        writer.WritePropertyName(reader.ValueSpan);
                        Debug.WriteLine($"Path: {Utf8SpanToString(utf8Path)}, TokenStartIndex: {reader.TokenStartIndex}");
                        continue;
                    case JsonTokenType.String:
                        WriteString(utf8Path, highWaterMark, ref reader, writer);
                        utf8Path = ChangeTracker.PopProperty(utf8Path);
                        continue;
                    case JsonTokenType.Number:
                        WriteNumber(utf8Path, highWaterMark, ref reader, writer);
                        utf8Path = ChangeTracker.PopProperty(utf8Path);
                        continue;
                    case JsonTokenType.True:
                    case JsonTokenType.False:
                        WriteBoolean(utf8Path, highWaterMark, reader.TokenType, ref reader, writer);
                        utf8Path = ChangeTracker.PopProperty(utf8Path);
                        continue;
                    case JsonTokenType.Null:
                        WriteNull(utf8Path, highWaterMark, ref reader, writer);
                        utf8Path = ChangeTracker.PopProperty(utf8Path);
                        continue;
                    case JsonTokenType.EndObject:
                        writer.WriteEndObject();
                        return;
                }
            }
        }

        private void WriteObject(ReadOnlySpan<byte> utf8Path, int highWaterMark, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            if (Changes.TryGetChange(utf8Path, highWaterMark, out MutableJsonChange change))
            {
                WriteStructuralChange(utf8Path, change, ref reader, writer);
                return;
            }

            writer.WriteStartObject();
            WriteObjectProperties(utf8Path, highWaterMark, ref reader, writer);
        }

        private void WriteStructuralChange(ReadOnlySpan<byte> utf8Path, MutableJsonChange change, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            Utf8JsonReader changedElementReader = change.GetReader();
            WriteElement(utf8Path, change.Index, ref changedElementReader, writer);

            // Skip this element in the original json buffer.
            reader.Skip();
        }

        private void WriteString(ReadOnlySpan<byte> utf8Path, int highWaterMark, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            if (Changes.TryGetChange(utf8Path, highWaterMark, out MutableJsonChange change))
            {
                if (change.ReplacesJsonElement)
                {
                    WriteStructuralChange(utf8Path, change, ref reader, writer);
                    return;
                }

                writer.WriteStringValue((string)change.Value!);
                return;
            }

            writer.WriteStringValue(reader.ValueSpan);
            return;
        }

        private void WriteNumber(ReadOnlySpan<byte> utf8Path, int highWaterMark, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            if (Changes.TryGetChange(utf8Path, highWaterMark, out MutableJsonChange change))
            {
                if (change.ReplacesJsonElement)
                {
                    WriteStructuralChange(utf8Path, change, ref reader, writer);
                    return;
                }

                switch (change.Value)
                {
                    case long l:
                        writer.WriteNumberValue(l);
                        return;
                    case int i:
                        writer.WriteNumberValue(i);
                        return;
                    case double d:
                        writer.WriteNumberValue(d);
                        return;
                    case float f:
                        writer.WriteNumberValue(f);
                        return;
                    case JsonElement element:
                        if (element.TryGetInt64(out long el))
                        {
                            writer.WriteNumberValue(el);
                            return;
                        }
                        if (element.TryGetDouble(out double ed))
                        {
                            writer.WriteNumberValue(ed);
                            return;
                        }
                        throw new InvalidOperationException("Change doesn't store a number value.");
                    default:
                        throw new InvalidOperationException("Change doesn't store a number value.");
                }
            }

            if (reader.TryGetInt64(out long longValue))
            {
                writer.WriteNumberValue(longValue);
                return;
            }

            if (reader.TryGetDouble(out double doubleValue))
            {
                writer.WriteNumberValue(doubleValue);
                return;
            }

            throw new InvalidOperationException("Change doesn't store a number value.");
        }

        private void WriteBoolean(ReadOnlySpan<byte> utf8Path, int highWaterMark, JsonTokenType token, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            if (Changes.TryGetChange(utf8Path, highWaterMark, out MutableJsonChange change))
            {
                if (change.ReplacesJsonElement)
                {
                    WriteStructuralChange(utf8Path, change, ref reader, writer);
                    return;
                }

                writer.WriteBooleanValue((bool)change.Value!);
                return;
            }

            writer.WriteBooleanValue(value: token == JsonTokenType.True);
        }

        private void WriteNull(ReadOnlySpan<byte> utf8Path, int highWaterMark, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            if (Changes.TryGetChange(utf8Path, highWaterMark, out MutableJsonChange change) && change.ReplacesJsonElement)
            {
                WriteStructuralChange(utf8Path, change, ref reader, writer);
                return;
            }

            writer.WriteNullValue();
        }
    }
}
