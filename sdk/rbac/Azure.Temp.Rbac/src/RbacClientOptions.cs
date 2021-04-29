// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Temp.Rbac
{
    /// <summary>
    /// </summary>
    public class RbacClientOptions : ClientOptions
    {
        internal string Version { get; }

        /// <summary>
        /// </summary>
        public RbacClientOptions(ServiceVersion version = ServiceVersion.V1_0)
        {
            Version = version switch
            {
                ServiceVersion.V1_0 => "1.0",
                _ => throw new ArgumentException($"The service version {version} is not supported by this library.", nameof(version))
            };
        }

        /// <summary>
        /// </summary>
        public enum ServiceVersion
        {
            /// <summary>
            /// </summary>
#pragma warning disable CA1707 // Remove the underscores from member name
            V1_0 = 1
#pragma warning restore
        }
    }
}
