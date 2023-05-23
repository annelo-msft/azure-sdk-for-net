// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.Samples;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Core.Tests
{
    public class Http3ClientTests
    {
        [Test]
        public void CanSendRequest()
        {
            Uri endpoint = new Uri("https://localhost:7033/");
            WidgetHttp3Client client = new WidgetHttp3Client(endpoint, new MockCredential());
            var widget = new
            {
                id = 102,
                name = "Second",
            };
            Response response = client.SetWidget(RequestContent.Create(widget));
        }
    }
}
