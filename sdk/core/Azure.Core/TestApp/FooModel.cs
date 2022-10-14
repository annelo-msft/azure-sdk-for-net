// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;

namespace TestApp
{
    public class FooModel : IUtf8JsonDeserializable<FooModel>
    {
        void IUtf8JsonDeserializable<FooModel>.Read(ref Utf8JsonReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
