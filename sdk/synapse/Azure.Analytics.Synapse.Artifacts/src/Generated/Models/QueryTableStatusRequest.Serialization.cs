// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(QueryTableStatusRequestConverter))]
    public partial class QueryTableStatusRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxSegmentCount))
            {
                writer.WritePropertyName("maxSegmentCount"u8);
                writer.WriteNumberValue(MaxSegmentCount.Value);
            }
            if (Optional.IsDefined(ContinuationToken))
            {
                writer.WritePropertyName("continuationToken"u8);
                writer.WriteObjectValue(ContinuationToken);
            }
            writer.WriteEndObject();
        }

        internal partial class QueryTableStatusRequestConverter : JsonConverter<QueryTableStatusRequest>
        {
            public override void Write(Utf8JsonWriter writer, QueryTableStatusRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override QueryTableStatusRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
        }
    }
}
