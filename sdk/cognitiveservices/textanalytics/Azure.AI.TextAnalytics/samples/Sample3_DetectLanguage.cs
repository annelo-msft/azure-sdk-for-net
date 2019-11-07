﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Testing;
using Azure.Identity;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace Azure.AI.TextAnalytics.Samples
{
    [LiveOnly]
    public partial class TextAnalyticsSamples
    {
        [Test]
        public void DetectLanguage()
        {
            string endpoint = Environment.GetEnvironmentVariable("TEXT_ANALYTICS_ENDPOINT");
            //string subscriptionKey = Environment.GetEnvironmentVariable("TEXT_ANALYTICS_SUBSCRIPTION_KEY");

            // Instantiate a client that will be used to call the service.
            //var client = new TextAnalyticsClient(new Uri(endpoint), subscriptionKey);
            var client = new TextAnalyticsClient(new Uri(endpoint), new DefaultAzureCredential());


            string spanishInput = "Este documento está en español.";

            Debug.WriteLine($"Detecting language for input: \"{spanishInput}\"");
            try
            {
                DetectedLanguage language = client.DetectLanguage(spanishInput);

                Debug.WriteLine($"Detected language {language.Name} with confidence {language.Score:0.00}.");




                string unknownLanguageInput = ":) :( :D";

                Debug.WriteLine($"Detecting language for input: \"{unknownLanguageInput}\"");
                language = client.DetectLanguage(unknownLanguageInput);

                Debug.WriteLine($"Detected language {language.Name} with confidence {language.Score:0.00}.");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
