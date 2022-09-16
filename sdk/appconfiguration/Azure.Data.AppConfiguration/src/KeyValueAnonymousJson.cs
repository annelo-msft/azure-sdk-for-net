// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Azure.Data.AppConfiguration
{
    [DebuggerDisplay("\\{ Key = {Key}, Value = {Value} }", Type = "<Anonymous Type>")]
    internal class KeyValueAnonymousJson : TypedJson
    {
        public string Key { get; set; }
        public string Value { get; set; }

        // TODO: Handle ToString, Equals, etc.
    }
}
