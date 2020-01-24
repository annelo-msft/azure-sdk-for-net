// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Xunit;

// TestFramework:
// https://github.com/Azure/azure-sdk-for-net/blob/e6de379e53add4f5296ba9d191f5062d58e1759a/doc/dev/Track2TestFramework.md

namespace Azure.AI.FormRecognizer.Tests
{
    public class FormRecognizerClientTests
    {
        [Fact]
        public void Constructor_Throws_OnInvalidParams()
        {
            // Arrange
            // TODO: move these tests to CognitiveCredential / CognitiveEndpoint
            // var validEndpoint = new Uri("http://localhost");
            // var invalidEndpointNotAbsolute = new Uri("/", UriKind.Relative);
            // var validKey = "fake-key";
            // var invalidKeyEmpty = String.Empty;

            // Act / assert
            Assert.Throws<ArgumentNullException>(() => new FormRecognizerClient(default, default));
            Assert.Throws<ArgumentNullException>(() => new FormRecognizerClient(default));
        }

        [Fact]
        public void Constructor_Creates_Properties()
        {
            // Act
            var apiKey = "fake-key";
            var endpoint = new Uri("http://localhost");
            var credential = new CognitiveCredential(endpoint, apiKey);
            var client = new FormRecognizerClient(credential);

            // Assert
            Assert.NotNull(client.Custom);
            Assert.NotNull(client.Prebuilt);
            Assert.NotNull(client.Layout);
            Assert.Equal(credential, client.Credential);
        }
    }
}
