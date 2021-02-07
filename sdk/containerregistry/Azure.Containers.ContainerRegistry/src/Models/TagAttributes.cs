// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Models
{
    [CodeGenModel("TagAttributesBase")]
    public partial class TagAttributes
    {
        /// <summary> Tag created time. </summary>
        public DateTime CreatedTime { get; }
        /// <summary> Tag last update time. </summary>
        public DateTime LastUpdateTime { get; }

        [CodeGenMember("ChangeableAttributes")]
        public RegistryObjectPermissions Permissions { get; }
    }
}
