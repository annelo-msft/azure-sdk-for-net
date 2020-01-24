﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core.Testing;
using NUnit.Framework;

namespace Azure.AI.TextAnalytics.Samples
{
    [LiveOnly]
    public partial class TextAnalyticsSamples
    {
        [Test]
        public void RecognizeEntities()
        {
            string endpoint = Environment.GetEnvironmentVariable("TEXT_ANALYTICS_ENDPOINT");
            string subscriptionKey = Environment.GetEnvironmentVariable("TEXT_ANALYTICS_SUBSCRIPTION_KEY");

            #region Snippet:TextAnalyticsSample4CreateClient
            var client = new TextAnalyticsClient(new Uri(endpoint), new TextAnalyticsSubscriptionKeyCredential(subscriptionKey));
            #endregion

            #region Snippet:RecognizeEntities
            string input = "Microsoft was founded by Bill Gates and Paul Allen.";

            IEnumerable<NamedEntity> entities = client.RecognizeEntities(input).Value;

            Console.WriteLine($"Recognized {entities.Count()} entities:");
            foreach (NamedEntity entity in entities)
            {
                Console.WriteLine($"Text: {entity.Text}, Type: {entity.Category}, SubType: {entity.SubCategory}, Score: {entity.Score}, Offset: {entity.Offset}, Length: {entity.Length}");
            }
            #endregion
        }
    }
}
