// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;

namespace Azure.Core.Tests
{
    internal class ModelWithDateTime : IUtf8JsonSerializable
    {
        public string A { get; set; }
        public DateTimeOffset Property { get; set; }

        public ModelWithDateTime() { }

        private ModelWithDateTime(string a, DateTimeOffset property)
        {
            A = a;
            Property = property;
        }

        public void Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(A))
            {
                writer.WritePropertyName("a");
                writer.WriteStringValue(A);
            }
            if (Optional.IsDefined(Property))
            {
                writer.WritePropertyName("property");
                writer.WriteStringValue(Property, "O");
            }
            writer.WriteEndObject();
        }
    }
}
