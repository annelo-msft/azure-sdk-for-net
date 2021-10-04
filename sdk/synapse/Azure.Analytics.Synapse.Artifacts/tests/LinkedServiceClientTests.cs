// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Synapse.Artifacts.Tests
{
    public class LinkedServiceClientTests : ClientTestBase
    {
        public LinkedServiceClientTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public void CanSerializeLinkedServiceResource()
        {
            // Arrange
            string resourceName = "MyKeyVault";

            // Act - Deserialize
            var linkedService = JsonSerializer.Deserialize<LinkedServiceResource>(@"{
                'name': 'MyKeyVault',
                'properties': {
                'annotations': [],
                'type': 'AzureKeyVault',
                'typeProperties': {
                    'baseUrl': 'https://myvault.vault.azure.net/'
                }
                }
            }".Replace("'", "\""));

            // Assert - Deserialize succeeded
            Assert.AreEqual(resourceName, linkedService.Name);

            // Act - Serialize
            var serialized = JsonSerializer.Serialize(linkedService);

            // Assert - Serialize succeeded
            var linkedServiceJson = JsonDocument.Parse(serialized);
            Assert.AreEqual("AzureKeyVault", linkedServiceJson.RootElement.GetProperty("type").GetString());
            Assert.AreEqual(resourceName, linkedServiceJson.RootElement.GetProperty("name").GetString());
        }
    }
}
