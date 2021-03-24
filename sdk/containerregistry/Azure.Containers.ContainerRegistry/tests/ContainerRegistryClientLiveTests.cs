// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Containers.ContainerRegistry.Tests
{
    public class ContainerRegistryClientLiveTests : RecordedTestBase<ContainerRegistryTestEnvironment>
    {
        public ContainerRegistryClientLiveTests(bool isAsync) : base(isAsync, RecordedTestMode.Live)
        {
            Sanitizer = new ContainerRegistryRecordedTestSanitizer();
        }

        private ContainerRegistryClient CreateClient()
        {
            return InstrumentClient(new ContainerRegistryClient(
                new Uri(TestEnvironment.Endpoint),
                TestEnvironment.Credential,
                InstrumentClientOptions(new ContainerRegistryClientOptions())
            ));
        }

        [RecordedTest]
        public async Task CanGetRepositories()
        {
            var client = CreateClient();

            AsyncPageable<string> repositories = client.GetRepositoriesAsync();

            bool gotHelloWorld = false;

            await foreach (string repository in repositories)
            {
                if (repository.Contains("library/hello-world"))
                {
                    gotHelloWorld = true;
                    break;
                }
            }

            Assert.IsTrue(gotHelloWorld);
        }

        [RecordedTest]
        public async Task CanGetRepositoriesByPage()
        {
            var client = CreateClient();

            AsyncPageable<string> repositories = client.GetRepositoriesAsync();

            var pages = repositories.AsPages("v1", 2);

            await foreach (var page in pages)
            {
            }

            //Page<string> firstPage = pages.GetAsyncEnumerator().Current;

            //Assert.AreEqual(2, firstPage.Values.Count);
            //Assert.AreEqual("v2", firstPage.Values[0]);
            //Assert.AreEqual("v3", firstPage.Values[1]);
        }
    }
}
