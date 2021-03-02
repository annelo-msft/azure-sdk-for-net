// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    [CodeGenModel("ManifestAttributes")]
    public partial class ManifestProperties
    {
        [CodeGenMember("ImageName")]
        public string Name { get; }

        public string Digest { get { return Attributes.Digest; } }

        // Qn: Why is this nullable?  does it need to be?  Yes, it's null if the value is not known.
        public long? Size { get { return Attributes.ImageSize.Value; } }

        public DateTimeOffset? CreatedTime { get { return Attributes.CreatedTime; } }

        public DateTimeOffset? LastUpdateTime { get { return Attributes.LastUpdateTime; } }

        public string CpuArchitecture { get { return Attributes.Architecture; } }

        public string OperatingSystem { get { return Attributes.Os; } }

        public IReadOnlyList<ManifestProperties> Images { get; }

        internal string ManifestMediaType { get { return Attributes.MediaType; } }

        internal string ConfigMediaType { get { return Attributes.ConfigMediaType; } }

        public IReadOnlyList<string> Tags { get { return Attributes.Tags; } }

        public ContentPermissions Permissions { get { return Attributes.ChangeableAttributes; } }

        /// <summary> Manifest attributes. </summary>
        internal ManifestAttributesBase Attributes { get; }
    }
}
