// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class SharingProfile : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Permission))
            {
                writer.WritePropertyName("permissions"u8);
                writer.WriteStringValue(Permission.Value.ToString());
            }
            if (Core.Optional.IsDefined(CommunityGalleryInfo))
            {
                writer.WritePropertyName("communityGalleryInfo"u8);
                writer.WriteObjectValue(CommunityGalleryInfo);
            }
            writer.WriteEndObject();
        }

        internal static SharingProfile DeserializeSharingProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<GallerySharingPermissionType> permissions = default;
            Core.Optional<IReadOnlyList<SharingProfileGroup>> groups = default;
            Core.Optional<CommunityGalleryInfo> communityGalleryInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("permissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    permissions = new GallerySharingPermissionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("groups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SharingProfileGroup> array = new List<SharingProfileGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SharingProfileGroup.DeserializeSharingProfileGroup(item));
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("communityGalleryInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    communityGalleryInfo = CommunityGalleryInfo.DeserializeCommunityGalleryInfo(property.Value);
                    continue;
                }
            }
            return new SharingProfile(Core.Optional.ToNullable(permissions), Core.Optional.ToList(groups), communityGalleryInfo.Value);
        }
    }
}
