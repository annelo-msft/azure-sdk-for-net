// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Net;

namespace Azure.Core
{
    /// <summary>
    /// </summary>
    public readonly struct RequestVersion : IEquatable<RequestVersion>
    {
        /// <summary>
        /// </summary>
        public Version Version { get; }

        /// <summary>
        /// HTTP 1.1.
        /// </summary>
        public static RequestVersion Http11 { get; } = new RequestVersion(HttpVersion.Version11);

        /// <summary>
        /// HTTP 3.0.
        /// </summary>
        public static RequestVersion Http30 { get; } = new RequestVersion(HttpVersion.Version11);

        /// <summary>
        /// </summary>
        /// <param name="version"></param>
        public RequestVersion(Version version)
        {
            Version = version;
        }

        /// <inheritdoc />
        public bool Equals(RequestVersion other)
        {
            return other.Version.Equals(Version);
        }

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj)
        {
            return obj is RequestVersion version && Equals(version);
        }

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return Version.GetHashCode();
        }
    }
}
