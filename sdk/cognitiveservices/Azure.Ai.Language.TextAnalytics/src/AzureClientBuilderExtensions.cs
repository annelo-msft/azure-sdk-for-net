// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Extensions;

namespace Azure.Ai.Language.TextAnalytics
{
    /// <summary>
    /// Extension methods to add <see cref="TextAnalyticsClient"/> client to clients builder
    /// </summary>
    public static class AzureClientBuilderExtensions
    {
        /// <summary>
        /// Registers a <see cref="TextAnalyticsClient"/> instance with the provided <paramref name="connectionString"/>
        /// </summary>
        public static IAzureClientBuilder<TextAnalyticsClient, TextAnalyticsClientOptions> AddConfigurationClient<TBuilder>(this TBuilder builder, string connectionString)
            where TBuilder: IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<TextAnalyticsClient, TextAnalyticsClientOptions>(options => new TextAnalyticsClient(connectionString, options));
        }

        /// <summary>
        /// Registers a <see cref="TextAnalyticsClient"/> instance with connection options loaded from the provided <paramref name="configuration"/> instance.
        /// </summary>
        public static IAzureClientBuilder<TextAnalyticsClient, TextAnalyticsClientOptions> AddConfigurationClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
            where TBuilder: IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<TextAnalyticsClient, TextAnalyticsClientOptions>(configuration);
        }
    }
}
