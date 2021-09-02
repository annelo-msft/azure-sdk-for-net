// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class Platform : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Architecture))
            {
                writer.WritePropertyName("architecture");
                writer.WriteStringValue(Architecture);
            }
            if (Optional.IsDefined(Os))
            {
                writer.WritePropertyName("os");
                writer.WriteStringValue(Os);
            }
            if (Optional.IsDefined(OsVersion))
            {
                writer.WritePropertyName("os.version");
                writer.WriteStringValue(OsVersion);
            }
            if (Optional.IsCollectionDefined(OsFeatures))
            {
                writer.WritePropertyName("os.features");
                writer.WriteStartArray();
                foreach (var item in OsFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Variant))
            {
                writer.WritePropertyName("variant");
                writer.WriteStringValue(Variant);
            }
            if (Optional.IsCollectionDefined(Features))
            {
                writer.WritePropertyName("features");
                writer.WriteStartArray();
                foreach (var item in Features)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static Platform DeserializePlatform(JsonElement element)
        {
            Optional<string> architecture = default;
            Optional<string> os = default;
            Optional<string> osVersion = default;
            Optional<IList<string>> osFeatures = default;
            Optional<string> variant = default;
            Optional<IList<string>> features = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("architecture"))
                {
                    architecture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("os"))
                {
                    os = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("os.version"))
                {
                    osVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("os.features"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    osFeatures = array;
                    continue;
                }
                if (property.NameEquals("variant"))
                {
                    variant = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("features"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    features = array;
                    continue;
                }
            }
            return new Platform(architecture.Value, os.Value, osVersion.Value, Optional.ToList(osFeatures), variant.Value, Optional.ToList(features));
        }
    }
}
