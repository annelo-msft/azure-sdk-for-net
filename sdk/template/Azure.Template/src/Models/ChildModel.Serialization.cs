// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.Template
{
    public partial class ChildModel : IUtf8JsonSerializable, IUtf8JsonDeserializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("qux");
            writer.WriteNumberValue(Qux);

            writer.WritePropertyName("thud");
            writer.WriteBooleanValue(Thud);

            writer.WriteEndObject();
        }

        internal static ChildModel Deserialize(ref Utf8JsonReader reader)
        {
            IUtf8JsonDeserializable model = new ChildModel();
            model.Read(ref reader);
            return (ChildModel)model;
        }

        void IUtf8JsonDeserializable.Read(ref Utf8JsonReader reader)
        {
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.StartObject:
                        break;

                    case JsonTokenType.EndObject:
                        return;

                    case JsonTokenType.StartArray:
                        break;

                    case JsonTokenType.EndArray:
                        break;

                    case JsonTokenType.PropertyName:
                        {
                            if (reader.ValueTextEquals("qux"))
                            {
                                reader.Skip();
                                Qux = reader.GetInt32();
                                continue;
                            }

                            if (reader.ValueTextEquals("thud"))
                            {
                                reader.Skip();
                                Thud = reader.GetBoolean();
                                continue;
                            }
                        }
                        break;

                    default:
                        throw new NotSupportedException("Not supported token type " + reader.TokenType);
                }
            }
        }
    }
}
