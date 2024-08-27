// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable enable

using System;
using Azure.Core.TestFramework;
using Maps;
using NUnit.Framework;

namespace Azure.Core.Tests.Clients;

public class AzureClientTests
{
    [Test]
    public void CanCallProtocolMethod()
    {
        MapsClientOptions options = new();
        options.Transport = new MockTransport((request) => new MockResponse(200));

        Uri endpoint = new Uri("https://www.example.com");
        AzureKeyCredential credential = new AzureKeyCredential("MyMockKey");

        MapsClient client = new(endpoint, credential, options);
        Response response = client.GetCountryCode("127.0.0.1", new RequestContext());

        Assert.IsNotNull(response);
        Assert.AreEqual(200, response.Status);
    }
}
