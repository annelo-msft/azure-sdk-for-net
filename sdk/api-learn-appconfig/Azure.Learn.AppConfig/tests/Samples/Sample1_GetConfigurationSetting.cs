// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;
using Azure.Identity;
using Azure.Learn.AppConfig;
using Azure.Learn.AppConfig.Models;
using NUnit.Framework;

namespace Azure.Template.Tests.Samples
{
    public class Sample1_GetConfigurationSetting : SamplesBase<AppConfigClientTestEnvironment>
    {
        [Test]
        public void GetConfigurationSetting()
        {
            string endpoint = "http://example.azconfig.io";

            ServiceClient client = new ServiceClient(endpoint, new DefaultAzureCredential());

            KeyValue color = client.GetKeyValue("FontColor");
            KeyValue greeting = client.GetKeyValue("GreetingText");

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color.Value);
            Console.WriteLine(greeting.Value);
        }
    }
}
