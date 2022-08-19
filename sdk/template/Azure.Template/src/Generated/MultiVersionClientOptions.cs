// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Template
{
    /// <summary> Client options for MultiVersionClient. </summary>
    public partial class MultiVersionClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2022_02_02;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2022-02-02". </summary>
            V2022_02_02 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of MultiVersionClientOptions. </summary>
        public MultiVersionClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2022_02_02 => "2022-02-02",
                _ => throw new NotSupportedException()
            };
        }
    }
}
