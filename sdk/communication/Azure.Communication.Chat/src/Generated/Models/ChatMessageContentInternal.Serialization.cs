// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.Chat
{
    internal partial class ChatMessageContentInternal
    {
        internal static ChatMessageContentInternal DeserializeChatMessageContentInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> message = default;
            Core.Optional<string> topic = default;
            Core.Optional<IReadOnlyList<ChatParticipantInternal>> participants = default;
            Core.Optional<CommunicationIdentifierModel> initiatorCommunicationIdentifier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topic"u8))
                {
                    topic = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("participants"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChatParticipantInternal> array = new List<ChatParticipantInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatParticipantInternal.DeserializeChatParticipantInternal(item));
                    }
                    participants = array;
                    continue;
                }
                if (property.NameEquals("initiatorCommunicationIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initiatorCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
            }
            return new ChatMessageContentInternal(message.Value, topic.Value, Core.Optional.ToList(participants), initiatorCommunicationIdentifier.Value);
        }
    }
}
