// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RunFilterParametersConverter))]
    public partial class RunFilterParameters : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ContinuationToken))
            {
                writer.WritePropertyName("continuationToken"u8);
                writer.WriteStringValue(ContinuationToken);
            }
            writer.WritePropertyName("lastUpdatedAfter"u8);
            writer.WriteStringValue(LastUpdatedAfter, "O");
            writer.WritePropertyName("lastUpdatedBefore"u8);
            writer.WriteStringValue(LastUpdatedBefore, "O");
            if (Core.Optional.IsCollectionDefined(Filters))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(OrderBy))
            {
                writer.WritePropertyName("orderBy"u8);
                writer.WriteStartArray();
                foreach (var item in OrderBy)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal partial class RunFilterParametersConverter : JsonConverter<RunFilterParameters>
        {
            public override void Write(Utf8JsonWriter writer, RunFilterParameters model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RunFilterParameters Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
        }
    }
}
