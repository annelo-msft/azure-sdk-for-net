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

        internal void WriteRootElementTo(Utf8JsonWriter writer)
        {
            bool changed = Changes.TryGetChange(Span<byte>.Empty, -1, out MutableJsonChange change);
            Utf8JsonReader reader = changed ? change.GetReader() : new Utf8JsonReader(_original.Span);

            Span<byte> utf8Path = stackalloc byte[DefaultMaxPathLength];
            WriteElement(utf8Path, 0, -1, ref reader, writer);
            //WriteElement(utf8Path, -1, ref reader, writer);

            writer.Flush();
        }

        // TODO: Make this work path as ReadOnlySpan<byte>
        internal void WriteElement(scoped ReadOnlySpan<byte> path, int pathLength, int highWaterMark, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.StartObject:
                        writer.WriteStartObject();
                        WriteObjectProperties(path, pathLength, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.StartArray:
                        writer.WriteStartArray();
                        WriteArrayValues(path, pathLength, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.String:
                        WriteString(path, pathLength, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.Number:
                        WriteNumber(path, pathLength, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.True:
                    case JsonTokenType.False:
                        WriteBoolean(path, pathLength, highWaterMark, reader.TokenType, ref reader, writer);
                        break;
                    case JsonTokenType.Null:
                        WriteNull(path, pathLength, highWaterMark, ref reader, writer);
                        break;
                }
            }
        }

        private void WriteArrayValues(scoped ReadOnlySpan<byte> path, int pathLength, int highWaterMark, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            int index = 0;

            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.StartObject:
                        path = ChangeTracker.PushIndex(path.Slice(0,pathLength), index, out pathLength).Span;
                        WriteObject(path, pathLength, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.StartArray:
                        path = ChangeTracker.PushIndex(path.Slice(0,pathLength), index, out pathLength).Span;
                        writer.WriteStartArray();
                        WriteArrayValues(path, pathLength, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.String:
                        path = ChangeTracker.PushIndex(path.Slice(0,pathLength), index, out pathLength).Span;
                        WriteString(path, pathLength, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.Number:
                        path = ChangeTracker.PushIndex(path.Slice(0,pathLength), index, out pathLength).Span;
                        WriteNumber(path, pathLength, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.True:
                    case JsonTokenType.False:
                        path = ChangeTracker.PushIndex(path.Slice(0,pathLength), index, out pathLength).Span;
                        WriteBoolean(path, pathLength, highWaterMark, reader.TokenType, ref reader, writer);
                        break;
                    case JsonTokenType.Null:
                        path = ChangeTracker.PushIndex(path.Slice(0,pathLength), index, out pathLength).Span;
                        WriteNull(path, pathLength, highWaterMark, ref reader, writer);
                        break;
                    case JsonTokenType.EndArray:
                        writer.WriteEndArray();
                        return;
                }

                path = ChangeTracker.PopIndex(path);
                index++;
            }
        }

        private void WriteObjectProperties(scoped ReadOnlySpan<byte> path, int pathLength, int highWaterMark, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.StartObject:
                        WriteObject(path, pathLength, highWaterMark, ref reader, writer);
                        path = ChangeTracker.PopProperty(path);
                        continue;
                    case JsonTokenType.StartArray:
                        writer.WriteStartArray();
                        WriteArrayValues(path, pathLength, highWaterMark, ref reader, writer);
                        path = ChangeTracker.PopProperty(path);
                        continue;
                    case JsonTokenType.PropertyName:
                        path = ChangeTracker.PushProperty(path.Slice(0,pathLength), reader.ValueSpan, out pathLength).Span;

                        writer.WritePropertyName(reader.ValueSpan);
                        //Debug.WriteLine($"Path: {path}, TokenStartIndex: {reader.TokenStartIndex}");
                        continue;
                    case JsonTokenType.String:
                        WriteString(path, pathLength, highWaterMark, ref reader, writer);
                        path = ChangeTracker.PopProperty(path);
                        continue;
                    case JsonTokenType.Number:
                        WriteNumber(path, pathLength, highWaterMark, ref reader, writer);
                        path = ChangeTracker.PopProperty(path);
                        continue;
                    case JsonTokenType.True:
                    case JsonTokenType.False:
                        WriteBoolean(path, pathLength, highWaterMark, reader.TokenType, ref reader, writer);
                        path = ChangeTracker.PopProperty(path);
                        continue;
                    case JsonTokenType.Null:
                        WriteNull(path, pathLength, highWaterMark, ref reader, writer);
                        path = ChangeTracker.PopProperty(path);
                        continue;
                    case JsonTokenType.EndObject:
                        writer.WriteEndObject();
                        return;
                }
            }
        }

        private void WriteObject(scoped ReadOnlySpan<byte> path, int pathLength, int highWaterMark, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            if (Changes.TryGetChange(path.Slice(0,pathLength), highWaterMark, out MutableJsonChange change))
            {
                WriteStructuralChange(path, pathLength, change, ref reader, writer);
                return;
            }

            writer.WriteStartObject();
            WriteObjectProperties(path, pathLength, highWaterMark, ref reader, writer);
        }

        private void WriteStructuralChange(scoped ReadOnlySpan<byte> path, int pathLength, MutableJsonChange change, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            Utf8JsonReader changedElementReader = change.GetReader();
            WriteElement(path, pathLength, change.Index, ref changedElementReader, writer);

            // Skip this element in the original json buffer.
            reader.Skip();
        }

        private void WriteString(scoped ReadOnlySpan<byte> path, int pathLength, int highWaterMark, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            if (Changes.TryGetChange(path.Slice(0,pathLength), highWaterMark, out MutableJsonChange change))
            {
                if (change.ReplacesJsonElement)
                {
                    WriteStructuralChange(path, pathLength, change, ref reader, writer);
                    return;
                }

                writer.WriteStringValue((string)change.Value!);
                return;
            }

            writer.WriteStringValue(reader.ValueSpan);
            return;
        }

        private void WriteNumber(scoped ReadOnlySpan<byte> path, int pathLength, int highWaterMark, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            if (Changes.TryGetChange(path.Slice(0,pathLength), highWaterMark, out MutableJsonChange change))
            {
                if (change.ReplacesJsonElement)
                {
                    WriteStructuralChange(path, pathLength, change, ref reader, writer);
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

        private void WriteBoolean(scoped ReadOnlySpan<byte> path, int pathLength, int highWaterMark, JsonTokenType token, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            if (Changes.TryGetChange(path.Slice(0,pathLength), highWaterMark, out MutableJsonChange change))
            {
                if (change.ReplacesJsonElement)
                {
                    WriteStructuralChange(path, pathLength, change, ref reader, writer);
                    return;
                }

                writer.WriteBooleanValue((bool)change.Value!);
                return;
            }

            writer.WriteBooleanValue(value: token == JsonTokenType.True);
        }

        private void WriteNull(scoped ReadOnlySpan<byte> path, int pathLength, int highWaterMark, ref Utf8JsonReader reader, Utf8JsonWriter writer)
        {
            if (Changes.TryGetChange(path.Slice(0,pathLength), highWaterMark, out MutableJsonChange change) && change.ReplacesJsonElement)
            {
                WriteStructuralChange(path, pathLength, change, ref reader, writer);
                return;
            }

            writer.WriteNullValue();
        }
    }
}
