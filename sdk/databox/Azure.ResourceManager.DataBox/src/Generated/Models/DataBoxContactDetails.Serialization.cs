// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxContactDetails : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("contactName"u8);
            writer.WriteStringValue(ContactName);
            writer.WritePropertyName("phone"u8);
            writer.WriteStringValue(Phone);
            if (Core.Optional.IsDefined(PhoneExtension))
            {
                writer.WritePropertyName("phoneExtension"u8);
                writer.WriteStringValue(PhoneExtension);
            }
            if (Core.Optional.IsDefined(Mobile))
            {
                writer.WritePropertyName("mobile"u8);
                writer.WriteStringValue(Mobile);
            }
            writer.WritePropertyName("emailList"u8);
            writer.WriteStartArray();
            foreach (var item in EmailList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Core.Optional.IsCollectionDefined(NotificationPreference))
            {
                writer.WritePropertyName("notificationPreference"u8);
                writer.WriteStartArray();
                foreach (var item in NotificationPreference)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static DataBoxContactDetails DeserializeDataBoxContactDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string contactName = default;
            string phone = default;
            Core.Optional<string> phoneExtension = default;
            Core.Optional<string> mobile = default;
            IList<string> emailList = default;
            Core.Optional<IList<NotificationPreference>> notificationPreference = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contactName"u8))
                {
                    contactName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"u8))
                {
                    phone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneExtension"u8))
                {
                    phoneExtension = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mobile"u8))
                {
                    mobile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("emailList"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    emailList = array;
                    continue;
                }
                if (property.NameEquals("notificationPreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NotificationPreference> array = new List<NotificationPreference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.NotificationPreference.DeserializeNotificationPreference(item));
                    }
                    notificationPreference = array;
                    continue;
                }
            }
            return new DataBoxContactDetails(contactName, phone, phoneExtension.Value, mobile.Value, emailList, Core.Optional.ToList(notificationPreference));
        }
    }
}
