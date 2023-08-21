// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class TeamsMeetingOutput : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("teamsJoinUrl"u8);
            writer.WriteStringValue(TeamsJoinUrl);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static TeamsMeetingOutput DeserializeTeamsMeetingOutput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string teamsJoinUrl = default;
            MediaOutputType kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("teamsJoinUrl"u8))
                {
                    teamsJoinUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new MediaOutputType(property.Value.GetString());
                    continue;
                }
            }
            return new TeamsMeetingOutput(kind, teamsJoinUrl);
        }
    }
}
