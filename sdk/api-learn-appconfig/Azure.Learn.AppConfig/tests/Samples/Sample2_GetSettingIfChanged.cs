// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Identity;
using Azure.Learn.AppConfig;
using Azure.Learn.AppConfig.Models;
using NUnit.Framework;

namespace Azure.Template.Tests.Samples
{
    public class Sample2_GetSettingIfChanged : SamplesBase<AppConfigClientTestEnvironment>
    {
        [Test]
        public async Task GetConfigurationSetting()
        {
            string endpoint = "http://example.azconfig.io";

            ServiceClient client = new ServiceClient(endpoint, new DefaultAzureCredential());

            Dictionary<string, KeyValue> settingCache = new Dictionary<string, KeyValue>();

            await UpdateCacheAsync(client, settingCache);
            WriteToConsole(settingCache);

            for (int i= 0; i < 4; i++)
            {
                await UpdateCacheAsync(client, settingCache);
                WriteToConsole(settingCache);

                Thread.Sleep(2000);
            }

            Console.ReadLine();
        }

        public async Task UpdateCacheAsync(ServiceClient client, Dictionary<string, KeyValue> settingCache)
        {
            settingCache["FontColor"] = await client.GetKeyValueAsync("FontColor", null, null, null, settingCache["FontColor"].Etag);
            settingCache["GreetingText"] = await client.GetKeyValueAsync("GreetingText", null, null, null, settingCache["FontColor"].Etag););
        }

        public void WriteToConsole(Dictionary<string, KeyValue> settingCache)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), settingCache["FontColor"].Value);
            Console.WriteLine(settingCache["GreetingText"].Value);
        }
    }
}
