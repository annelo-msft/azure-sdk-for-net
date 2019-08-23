// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Pipeline;

namespace Azure.Ai.Language.TextAnalytics
{
    /// <summary>
    /// Options that allow to configure the management of the request sent to the service
    /// </summary>
    public class TextAnalyticsClientOptions : ClientOptions
    {
        /// <summary>
        /// The latest service version supported by this client library.
        /// </summary>
        internal const ServiceVersion LatestVersion = ServiceVersion.Default;

        /// <summary>
        /// The versions of App Config Service supported by this client library.
        /// </summary>
        public enum ServiceVersion
        {
            /// <summary>
            /// Uses the latest service version
            /// </summary>
            // TODO: use correct versions
            Default = 0
        }

        /// <summary>
        /// Gets the <see cref="ServiceVersion"/> of the service API used when
        /// making requests.
        /// </summary>
        public ServiceVersion Version { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnalyticsClientOptions"/>
        /// class.
        /// </summary>
        /// <param name="version">
        /// The <see cref="ServiceVersion"/> of the service API used when
        /// making requests.
        /// </param>
        public TextAnalyticsClientOptions(ServiceVersion version = ServiceVersion.Default)
        {
            this.Version = version;
        }
    }
}
