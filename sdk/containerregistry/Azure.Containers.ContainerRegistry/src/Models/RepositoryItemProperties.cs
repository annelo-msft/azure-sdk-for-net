// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    [CodeGenModel("ManifestAttributes")]
    public partial class RepositoryItemProperties
    {
        [CodeGenMember("ImageName")]
        public string Name { get; }

        [CodeGenMember("Registry")]
        public string RegistryName { get; }

        public string ManifestDigest { get { return Attributes.Digest; } }

        // TODO: Why is this nullable?  does it need to be?
        // TODO: Size in Bytes?
        public long? Size { get { return Attributes.ImageSize.Value; } }

        // TODO: Why is this nullable?  does it need to be?
        public DateTimeOffset? CreatedTime { get { return Attributes.CreatedTime.Value; } }

        // TODO: Why is this nullable?  does it need to be?
        public DateTimeOffset? LastUpdateTime { get { return Attributes.LastUpdateTime.Value; } }

        public string CpuArchitecture { get { return Attributes.Architecture; } }

        public string OperatingSystem { get { return Attributes.Os; } }

        internal string ManifestMediaType { get { return Attributes.MediaType; } }

        internal string ConfigMediaType { get { return Attributes.ConfigMediaType; } }

        public IReadOnlyList<string> Tags { get { return Attributes.Tags; } }

        public ContentPermissions Permissions { get { return Attributes.ChangeableAttributes; } }

        /// <summary> Manifest attributes. </summary>
        internal ManifestAttributesBase Attributes { get; }
    }
}
