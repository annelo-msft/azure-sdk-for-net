﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Azure.Containers.ContainerRegistry.Specialized
{
    public readonly struct ManifestMediaType : IEquatable<ManifestMediaType>
    {
        // TODO: Should a customer have to reason about these media types directly?
        public static readonly ManifestMediaType OciManifest = new ManifestMediaType("application/vnd.oci.image.manifest.v1+json");
        public static readonly ManifestMediaType OciIndex = new ManifestMediaType("application/vnd.oci.image.index.v1+json");
        public static readonly ManifestMediaType DockerManifestV1 = new ManifestMediaType("application/vnd.docker.container.image.v1+json");
        public static readonly ManifestMediaType DockerManifestV2 = new ManifestMediaType("application/vnd.docker.distribution.manifest.v2+json");
        public static readonly ManifestMediaType DockerManifestList = new ManifestMediaType("application/vnd.docker.distribution.manifest.list.v2+json");

        private readonly string _value;

        private ManifestMediaType(string mediaType)
        {
            _value = mediaType;
        }

        public static implicit operator ManifestMediaType(string mediaType) => new ManifestMediaType(mediaType);

        public static explicit operator string(ManifestMediaType mediaType) => mediaType._value;

        public static bool operator ==(ManifestMediaType left, ManifestMediaType right) => Equals(left, right);

        public static bool operator !=(ManifestMediaType left, ManifestMediaType right) => !Equals(left, right);

        public bool Equals(ManifestMediaType other) => _value == other._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManifestMediaType mediaType && Equals(mediaType);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => _value;
    }
}
