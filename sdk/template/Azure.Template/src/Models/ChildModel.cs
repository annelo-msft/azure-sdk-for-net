// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Azure.Template
{
    public partial class ChildModel
    {
        internal ChildModel() { }

        public int Qux { get; internal set; }

        public bool Thud { get; internal set; }

        //internal IDictionary<string, JsonNode> UnknownProperties { get; set; }
    }
}
