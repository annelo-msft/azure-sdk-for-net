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
        // TODO: Add internal parameterless intialization constructor
        internal ChildModel() { }

        // TODO: Add internal setters so initialization doesn't need to allocate
        // a local that is then GC'ed.
        public int Qux { get; internal set; }

        public bool Thud { get; internal set; }
    }
}
