// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class V1Manifest
    {
        internal static V1Manifest DeserializeV1Manifest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> architecture = default;
            Core.Optional<string> name = default;
            Core.Optional<string> tag = default;
            Core.Optional<IReadOnlyList<FsLayer>> fsLayers = default;
            Core.Optional<IReadOnlyList<History>> history = default;
            Core.Optional<IReadOnlyList<ImageSignature>> signatures = default;
            Core.Optional<int> schemaVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("architecture"u8))
                {
                    architecture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fsLayers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FsLayer> array = new List<FsLayer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FsLayer.DeserializeFsLayer(item));
                    }
                    fsLayers = array;
                    continue;
                }
                if (property.NameEquals("history"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<History> array = new List<History>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistry.History.DeserializeHistory(item));
                    }
                    history = array;
                    continue;
                }
                if (property.NameEquals("signatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ImageSignature> array = new List<ImageSignature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImageSignature.DeserializeImageSignature(item));
                    }
                    signatures = array;
                    continue;
                }
                if (property.NameEquals("schemaVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
            }
            return new V1Manifest(Core.Optional.ToNullable(schemaVersion), architecture.Value, name.Value, tag.Value, Core.Optional.ToList(fsLayers), Core.Optional.ToList(history), Core.Optional.ToList(signatures));
        }
    }
}
