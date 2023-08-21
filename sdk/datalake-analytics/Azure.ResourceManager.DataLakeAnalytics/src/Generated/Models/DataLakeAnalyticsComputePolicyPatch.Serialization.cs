// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    public partial class DataLakeAnalyticsComputePolicyPatch : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ObjectId))
            {
                writer.WritePropertyName("objectId"u8);
                writer.WriteStringValue(ObjectId.Value);
            }
            if (Core.Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("objectType"u8);
                writer.WriteStringValue(ObjectType.Value.ToString());
            }
            if (Core.Optional.IsDefined(MaxDegreeOfParallelismPerJob))
            {
                writer.WritePropertyName("maxDegreeOfParallelismPerJob"u8);
                writer.WriteNumberValue(MaxDegreeOfParallelismPerJob.Value);
            }
            if (Core.Optional.IsDefined(MinPriorityPerJob))
            {
                writer.WritePropertyName("minPriorityPerJob"u8);
                writer.WriteNumberValue(MinPriorityPerJob.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
