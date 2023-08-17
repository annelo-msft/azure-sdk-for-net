// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Core.Json
{
    public partial struct MutableJsonElement
    {
        internal void WriteTo(Utf8JsonWriter writer, string format)
        {
            switch (format)
            {
                case "J":
                    WriteTo(writer);
                    break;
                case "P":
                    WritePatch(writer);
                    break;
                default:
                    _root.AssertInvalidFormat(format);
                    break;
            }
        }
        internal void WriteTo(Utf8JsonWriter writer)
        {
            WriteElement(_path, _highWaterMark, _element, writer);
        }

        private void WriteElement(string path, int highWaterMark, JsonElement element, Utf8JsonWriter writer)
        {
            if (Changes.TryGetChange(path, highWaterMark, out MutableJsonChange change))
            {
                if (!WriteChangeOrGetElement(change, writer, out JsonElement changeElement))
                {
                    return;
                }

                element = changeElement;
                highWaterMark = change.Index;
            }

            if (Changes.DescendantChanged(path, highWaterMark))
            {
                switch (element.ValueKind)
                {
                    case JsonValueKind.Object:
                        WriteObject(path, highWaterMark, element, writer);
                        break;
                    case JsonValueKind.Array:
                        WriteArray(path, highWaterMark, element, writer);
                        break;
                    default:
                        throw new InvalidOperationException("Element doesn't have descendants.");
                }

                return;
            }

            element.WriteTo(writer);
        }

        private void WriteObject(string path, int highWaterMark, JsonElement element, Utf8JsonWriter writer)
        {
            writer.WriteStartObject();

            foreach (JsonProperty property in element.EnumerateObject())
            {
                string propertyPath = MutableJsonDocument.ChangeTracker.PushProperty(path, property.Name);
                if (!Changes.WasRemoved(propertyPath, highWaterMark))
                {
                    writer.WritePropertyName(property.Name);
                    WriteElement(propertyPath, highWaterMark, property.Value, writer);
                }
            }

            IEnumerable<MutableJsonChange> added = Changes.GetAddedProperties(path, highWaterMark);
            foreach (MutableJsonChange property in added)
            {
                string propertyName = property.AddedPropertyName!;
                string propertyPath = MutableJsonDocument.ChangeTracker.PushProperty(path, propertyName);

                writer.WritePropertyName(propertyName);
                if (WriteChangeOrGetElement(property, writer, out JsonElement changeElement))
                {
                    WriteElement(propertyPath, highWaterMark, changeElement, writer);
                }
            }

            writer.WriteEndObject();
        }

        private bool WriteChangeOrGetElement(MutableJsonChange change, Utf8JsonWriter writer, out JsonElement element)
        {
            element = default;

            switch (change.Value)
            {
                case bool b:
                    writer.WriteBooleanValue(b);
                    return false;
                case string s:
                    // TODO: Handle escaping
                    writer.WriteStringValue(s);
                    return false;
                case byte b:
                    writer.WriteNumberValue(b);
                    return false;
                case sbyte sb:
                    writer.WriteNumberValue(sb);
                    return false;
                case short sh:
                    writer.WriteNumberValue(sh);
                    return false;
                case ushort us:
                    writer.WriteNumberValue(us);
                    return false;
                case int i:
                    writer.WriteNumberValue(i);
                    return false;
                case uint u:
                    writer.WriteNumberValue(u);
                    return false;
                case long l:
                    writer.WriteNumberValue(l);
                    return false;
                case ulong ul:
                    writer.WriteNumberValue(ul);
                    return false;
                case float f:
                    writer.WriteNumberValue(f);
                    return false;
                case double d:
                    writer.WriteNumberValue(d);
                    return false;
                case decimal d:
                    writer.WriteNumberValue(d);
                    return false;
                case DateTime d:
                    // TODO
                    writer.WriteStringValue(d);
                    return false;
                case DateTimeOffset d:
                    // TODO
                    writer.WriteStringValue(d);
                    return false;
                case Guid g:
                    // TODO
                    writer.WriteStringValue(g);
                    return false;
                case null:
                    writer.WriteNullValue();
                    return false;
                case JsonElement e:
                    // TODO: Handle changes
                    element = e;
                    return true;
                default:
                    // Change can't have the type it has
                    // TODO
                    throw new InvalidOperationException();
            }
        }

        private void WriteArray(string path, int highWaterMark, JsonElement element, Utf8JsonWriter writer)
        {
            writer.WriteStartArray();

            int arrayIndex = 0;
            foreach (JsonElement arrayElement in element.EnumerateArray())
            {
                string arrayElementPath = MutableJsonDocument.ChangeTracker.PushIndex(path, arrayIndex++);
                WriteElement(arrayElementPath, highWaterMark, arrayElement, writer);
            }

            writer.WriteEndArray();
        }
    }
}
