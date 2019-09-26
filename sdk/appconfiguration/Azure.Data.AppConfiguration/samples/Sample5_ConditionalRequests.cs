// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Testing;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace Azure.Data.AppConfiguration.Samples
{
    [LiveOnly]
    public partial class ConfigurationSamples
    {
        [Test]
        public void ConditionalRequests()
        {
            // Retrieve the connection string from the configuration store.
            // You can get the string from your Azure portal.
            var connectionString = Environment.GetEnvironmentVariable("APPCONFIGURATION_CONNECTION_STRING");

            // Instantiate a client that will be used to call the service.
            var client = new ConfigurationClient(connectionString);

            //// Create a Configuration Setting to be stored in the Configuration Store.
            //var setting = new ConfigurationSetting("some_key", "some_value");


            // Conditional Get - "get if modified"
            ConfigurationSetting settingToGet = new ConfigurationSetting("some_key", "some_value");

            Conditional<ConfigurationSetting> setting = client.GetConditionally(setting.Key, setting.Value, setting.ETag);
            if (setting.WasModifiedVersion)
            {
                settingToGet = setting.Value;
            }
            // settingToGet has most recent value.

            // Conditional Set - "set if unmodified"
            ConfigurationSetting settingToUpdate = client.Get("some_key", "some_label");      // Gets initial value & its ETag
            while (true)
            {
                settingToUpdate.Value = "New Value";
                
                Conditional<ConfigurationSetting> setting = await client.SetConditionally(settingToUpdate);    // Returns latest value with its ETag
                if (!setting.WasModifiedVersion)
                {
                    break;      // success case
                }
            }
            // settingToUpdate successfully updated



            // Retrieve a previously stored Configuration Setting by calling GetAsync.
            ConfigurationSetting gotSetting = client.Get("some_key");
            Debug.WriteLine(gotSetting.Value);

            // Delete the Configuration Setting from the Configuration Store when you don't need it anymore.
            client.Delete("some_key");
        }
    }
}
