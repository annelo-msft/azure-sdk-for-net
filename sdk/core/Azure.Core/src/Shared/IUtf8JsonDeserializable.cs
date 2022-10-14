// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Azure.Core
{
    internal interface IUtf8JsonDeserializable
    {
        void Read(ref Utf8JsonReader reader);
    }

    internal interface IUtf8JsonDeserializable<T> : IUtf8JsonDeserializable where T : new()
    {
        T To();
    }
}
