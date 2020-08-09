// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Learn.TrainingService
{
    public class ComputationClientOptions : ClientOptions
    {
        public ComputationClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version;
        }

        public enum ServiceVersion
        {
#pragma warning disable CA1707 // Identifiers should not contain underscores
            /// <summary>
            /// </summary>
            V1_0 = 1
#pragma warning restore CA1707
        }

        /// <summary>
        /// The Latest service version supported by this client library.
        /// </summary>
        internal const ServiceVersion LatestVersion = ServiceVersion.V1_0;

        /// <summary>
        /// Gets the <see cref="ServiceVersion"/> of the service API used when
        /// making requests.  For more, see
        /// <see href="https://docs.microsoft.com/azure/search/search-api-versions" />.
        /// </summary>
        public ServiceVersion Version { get; }
    }
}
