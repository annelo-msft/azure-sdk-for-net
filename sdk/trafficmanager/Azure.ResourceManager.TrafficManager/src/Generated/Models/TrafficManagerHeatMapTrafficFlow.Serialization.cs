// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.TrafficManager.Models
{
    public partial class TrafficManagerHeatMapTrafficFlow : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(SourceIP))
            {
                writer.WritePropertyName("sourceIp"u8);
                writer.WriteStringValue(SourceIP.ToString());
            }
            if (Core.Optional.IsDefined(Latitude))
            {
                writer.WritePropertyName("latitude"u8);
                writer.WriteNumberValue(Latitude.Value);
            }
            if (Core.Optional.IsDefined(Longitude))
            {
                writer.WritePropertyName("longitude"u8);
                writer.WriteNumberValue(Longitude.Value);
            }
            if (Core.Optional.IsCollectionDefined(QueryExperiences))
            {
                writer.WritePropertyName("queryExperiences"u8);
                writer.WriteStartArray();
                foreach (var item in QueryExperiences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static TrafficManagerHeatMapTrafficFlow DeserializeTrafficManagerHeatMapTrafficFlow(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IPAddress> sourceIP = default;
            Core.Optional<double> latitude = default;
            Core.Optional<double> longitude = default;
            Core.Optional<IList<TrafficManagerHeatMapQueryExperience>> queryExperiences = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceIp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceIP = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("latitude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latitude = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("longitude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    longitude = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("queryExperiences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TrafficManagerHeatMapQueryExperience> array = new List<TrafficManagerHeatMapQueryExperience>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrafficManagerHeatMapQueryExperience.DeserializeTrafficManagerHeatMapQueryExperience(item));
                    }
                    queryExperiences = array;
                    continue;
                }
            }
            return new TrafficManagerHeatMapTrafficFlow(sourceIP.Value, Core.Optional.ToNullable(latitude), Core.Optional.ToNullable(longitude), Core.Optional.ToList(queryExperiences));
        }
    }
}
