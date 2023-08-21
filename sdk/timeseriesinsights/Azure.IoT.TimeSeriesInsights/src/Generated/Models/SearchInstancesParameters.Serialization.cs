// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class SearchInstancesParameters : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Recursive))
            {
                writer.WritePropertyName("recursive"u8);
                writer.WriteBooleanValue(Recursive.Value);
            }
            if (Core.Optional.IsDefined(Sort))
            {
                writer.WritePropertyName("sort"u8);
                writer.WriteObjectValue(Sort);
            }
            if (Core.Optional.IsDefined(Highlights))
            {
                writer.WritePropertyName("highlights"u8);
                writer.WriteBooleanValue(Highlights.Value);
            }
            if (Core.Optional.IsDefined(PageSize))
            {
                writer.WritePropertyName("pageSize"u8);
                writer.WriteNumberValue(PageSize.Value);
            }
            writer.WriteEndObject();
        }
    }
}
