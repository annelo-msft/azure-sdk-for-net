// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Http;
using Azure.Core.Pipeline;

namespace Azure.Ai.Language.TextAnalytics
{
    /// <summary>
    /// The client to use for interacting with the Azure Configuration Store.
    /// </summary>
    public partial class TextAnalyticsClient
    {
        private readonly Uri _baseUri;
        private readonly HttpPipeline _pipeline;

        /// <summary>
        /// Protected constructor to allow mocking
        /// </summary>
        protected TextAnalyticsClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnalyticsClient"/>.
        /// </summary>
        /// <param name="connectionString">Connection string with authentication option and related parameters.</param>
        public TextAnalyticsClient(string connectionString)
            : this(connectionString, new TextAnalyticsClientOptions())
        {
        }

        /// <summary>
        /// Creates a <see cref="TextAnalyticsClient"/> that sends requests to the configuration store.
        /// </summary>
        /// <param name="connectionString">Connection string with authentication option and related parameters.</param>
        /// <param name="options">Options that allow to configure the management of the request sent to the configuration store.</param>
        public TextAnalyticsClient(string connectionString, TextAnalyticsClientOptions options)
        {
            if (connectionString == null)
                throw new ArgumentNullException(nameof(connectionString));
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            ParseConnectionString(connectionString, out _baseUri, out var credential, out var secret);

            _pipeline = HttpPipelineBuilder.Build(options);
        }

        public virtual async Task<Response<ConfigurationSetting>> DetectLanguageAsync(ConfigurationSetting setting, CancellationToken cancellationToken = default)
        {
        }

        public virtual Response<ConfigurationSetting> DetectLanguage(ConfigurationSetting setting, CancellationToken cancellationToken = default)
        {
        }

        public virtual AsyncCollection<ConfigurationSetting> DetectLanguagesAsync(IEnumerable<Document> documents, CancellationToken cancellationToken = default)
        {
            return PageResponseEnumerator.CreateAsyncEnumerable(nextLink => DetectLanguagesPageAsync(selector, nextLink, cancellationToken));
        }

        public virtual IEnumerable<Response<ConfigurationSetting>> DetectLanguages(SettingSelector selector, CancellationToken cancellationToken = default)
        {
            return PageResponseEnumerator.CreateEnumerable(nextLink => DetectLanguagesPage(selector, nextLink, cancellationToken));
        }

        private async Task<Page<ConfigurationSetting>> DetectLanguagesPageAsync(SettingSelector selector, string pageLink, CancellationToken cancellationToken = default)
        {
        }

        private Page<ConfigurationSetting> DetectLanguagesPage(SettingSelector selector, string pageLink, CancellationToken cancellationToken = default)
        {
        }
    }
}
