// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerHttpGet : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            writer.WritePropertyName("port"u8);
            writer.WriteNumberValue(Port);
            if (Core.Optional.IsDefined(Scheme))
            {
                writer.WritePropertyName("scheme"u8);
                writer.WriteStringValue(Scheme.Value.ToString());
            }
            if (Core.Optional.IsCollectionDefined(HttpHeaders))
            {
                writer.WritePropertyName("httpHeaders"u8);
                writer.WriteStartArray();
                foreach (var item in HttpHeaders)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ContainerHttpGet DeserializeContainerHttpGet(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> path = default;
            int port = default;
            Core.Optional<ContainerHttpGetScheme> scheme = default;
            Core.Optional<IList<ContainerHttpHeader>> httpHeaders = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scheme"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheme = new ContainerHttpGetScheme(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("httpHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerHttpHeader> array = new List<ContainerHttpHeader>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerHttpHeader.DeserializeContainerHttpHeader(item));
                    }
                    httpHeaders = array;
                    continue;
                }
            }
            return new ContainerHttpGet(path.Value, port, Core.Optional.ToNullable(scheme), Core.Optional.ToList(httpHeaders));
        }
    }
}
