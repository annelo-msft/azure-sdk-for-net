// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Net.Http;

using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;

using Microsoft.Azure.Management.ContainerRegistry;
using NUnit.Framework;

namespace Azure.Containers.ContainerRegistry.Tests
{
    public abstract class ContainerRegistryTestBase : RecordedTestBase<ContainerRegistryTestEnvironment>
    {
        public ContainerRegistryTestBase(bool isAsync) : base(isAsync) { }

        public ContainerRegistryTestBase(bool isAsync, RecordedTestMode mode) : base(isAsync, mode) { }

        [SetUp]
        public void SetUp()
        {
            /// <see cref="ContainerRegistryManagementClient"/> and <see cref="HttpClient"/> are not fully compatible with the Azure.Core.TestFramework.
            /// We must disable the Client validation for tests to run.
            this.ValidateClientInstrumentation = false;
        }

        protected ContainerRegistryManagementClient GetContainerRegistryManagementClient()
        {
            var creds = TestEnvironment.GetServiceClientCredentials();
            var handler = new HttpPipelineMessageHandler(new HttpPipeline(Recording.CreateTransport(new HttpClientTransport())));
            var httpClient = new HttpClient(handler);

            var client = new ContainerRegistryManagementClient(credentials: creds, httpClient: httpClient, disposeHttpClient: true);
            client.SubscriptionId = TestEnvironment.SubscriptionId;
            return client;
        }
    }
}
