// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ExposureControlContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(FeatureName))
            {
                writer.WritePropertyName("featureName"u8);
                writer.WriteStringValue(FeatureName);
            }
            if (Core.Optional.IsDefined(FeatureType))
            {
                writer.WritePropertyName("featureType"u8);
                writer.WriteStringValue(FeatureType);
            }
            writer.WriteEndObject();
        }
    }
}
