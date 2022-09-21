// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable enable

using System.Text.Json;

namespace Azure.Template
{
    internal interface IUtf8JsonSerializable
    {
        void Write(Utf8JsonWriter writer);
    }
}
