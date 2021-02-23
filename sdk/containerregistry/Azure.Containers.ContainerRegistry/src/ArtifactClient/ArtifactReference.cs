// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Containers.ContainerRegistry
{
    public class ArtifactReference
    {
        public ArtifactReference(string tag)
        {
            Tag = tag;
        }

        //public ArtifactReference(string digest)
        //{
        //    Digest = digest;
        //}

        public string Tag { get; internal set; }
        public string Digest { get; internal set; }
    }
}
