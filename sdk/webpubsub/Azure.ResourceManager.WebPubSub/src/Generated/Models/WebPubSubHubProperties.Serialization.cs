// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    public partial class WebPubSubHubProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(EventHandlers))
            {
                writer.WritePropertyName("eventHandlers"u8);
                writer.WriteStartArray();
                foreach (var item in EventHandlers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(AnonymousConnectPolicy))
            {
                writer.WritePropertyName("anonymousConnectPolicy"u8);
                writer.WriteStringValue(AnonymousConnectPolicy);
            }
            writer.WriteEndObject();
        }

        internal static WebPubSubHubProperties DeserializeWebPubSubHubProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<WebPubSubEventHandler>> eventHandlers = default;
            Core.Optional<string> anonymousConnectPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventHandlers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebPubSubEventHandler> array = new List<WebPubSubEventHandler>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebPubSubEventHandler.DeserializeWebPubSubEventHandler(item));
                    }
                    eventHandlers = array;
                    continue;
                }
                if (property.NameEquals("anonymousConnectPolicy"u8))
                {
                    anonymousConnectPolicy = property.Value.GetString();
                    continue;
                }
            }
            return new WebPubSubHubProperties(Core.Optional.ToList(eventHandlers), anonymousConnectPolicy.Value);
        }
    }
}
