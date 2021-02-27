// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Storage
{
    internal partial class TagAttributes
    {
        internal static TagAttributes DeserializeTagAttributes(JsonElement element)
        {
            Optional<string> registry = default;
            Optional<string> imageName = default;
            Optional<TagAttributesBase> tag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("registry"))
                {
                    registry = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageName"))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tag = TagAttributesBase.DeserializeTagAttributesBase(property.Value);
                    continue;
                }
            }
            return new TagAttributes(registry.Value, imageName.Value, tag.Value);
        }
    }
}
