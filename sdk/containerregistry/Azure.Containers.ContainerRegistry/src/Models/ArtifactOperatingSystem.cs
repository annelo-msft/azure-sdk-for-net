// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The ArtifactOperatingSystem. </summary>
    public readonly partial struct ArtifactOperatingSystem : IEquatable<ArtifactOperatingSystem>
    {
        /// <summary> ios. </summary>
        [CodeGenMember("IOS")]
        public static ArtifactOperatingSystem iOS { get; } = new ArtifactOperatingSystem(iOSValue);
    }
}
