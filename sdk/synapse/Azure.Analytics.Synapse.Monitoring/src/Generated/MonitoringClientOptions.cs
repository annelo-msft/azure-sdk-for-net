// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Analytics.Synapse.Monitoring
{
    /// <summary> Client options for MonitoringClient. </summary>
    public partial class MonitoringClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2020_12_01;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2020-12-01". </summary>
            V2020_12_01 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of MonitoringClientOptions. </summary>
        public MonitoringClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2020_12_01 => "2020-12-01",
                _ => throw new NotSupportedException()
            };
        }
    }
}
