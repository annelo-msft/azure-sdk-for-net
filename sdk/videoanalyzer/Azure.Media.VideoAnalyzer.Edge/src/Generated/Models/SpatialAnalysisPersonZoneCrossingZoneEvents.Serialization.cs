// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisPersonZoneCrossingZoneEvents : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("zone"u8);
            writer.WriteObjectValue(Zone);
            if (Core.Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SpatialAnalysisPersonZoneCrossingZoneEvents DeserializeSpatialAnalysisPersonZoneCrossingZoneEvents(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NamedPolygonBase zone = default;
            Core.Optional<IList<SpatialAnalysisPersonZoneCrossingEvent>> events = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zone"u8))
                {
                    zone = NamedPolygonBase.DeserializeNamedPolygonBase(property.Value);
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SpatialAnalysisPersonZoneCrossingEvent> array = new List<SpatialAnalysisPersonZoneCrossingEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialAnalysisPersonZoneCrossingEvent.DeserializeSpatialAnalysisPersonZoneCrossingEvent(item));
                    }
                    events = array;
                    continue;
                }
            }
            return new SpatialAnalysisPersonZoneCrossingZoneEvents(zone, Core.Optional.ToList(events));
        }
    }
}
