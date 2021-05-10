// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Changeable attributes. </summary>
    public partial class ManifestWriteableProperties
    {
        /// <summary> Quarantine state. </summary>
        [CodeGenMember("QuarantineState")]
        internal string QuarantineState { get; }
        /// <summary> Quarantine details. </summary>
        [CodeGenMember("QuarantineDetails")]
        internal string QuarantineDetails { get; }
    }
}
