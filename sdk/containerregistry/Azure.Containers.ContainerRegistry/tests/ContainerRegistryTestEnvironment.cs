// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using ARM = Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using Microsoft.Rest;

namespace Azure.Containers.ContainerRegistry.Tests
{
    public class ContainerRegistryTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("CONTAINERREGISTRY_ENDPOINT");
        public string UserName => GetRecordedVariable("CONTAINERREGISTRY_USERNAME", options => options.IsSecret());
        public string Password => GetRecordedVariable("CONTAINERREGISTRY_PASSWORD", options => options.IsSecret());
        public string Registry => GetRecordedVariable("CONTAINERREGISTRY_REGISTRY_NAME");

        public bool IsTestModeLive => this.Mode != RecordedTestMode.Playback;

        internal ServiceClientCredentials GetServiceClientCredentials()
        {
            if (this.IsTestModeLive)
            {
                return new AzureCredentials(
                    new ServicePrincipalLoginInformation
                    {
                        ClientId = this.ClientId,
                        ClientSecret = this.ClientSecret,
                    },
                    this.TenantId,
                    ARM.AzureEnvironment.AzureGlobalCloud);
            }
            else
            {
                return new TokenCredentials("testValue");
            }
        }
    }
}
