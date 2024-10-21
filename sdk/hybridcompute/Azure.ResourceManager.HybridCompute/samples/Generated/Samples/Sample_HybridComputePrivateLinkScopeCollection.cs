// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridCompute.Samples
{
    public partial class Sample_HybridComputePrivateLinkScopeCollection
    {
        // PrivateLinkScopeListByResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PrivateLinkScopeListByResourceGroup()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/stable/2024-07-10/examples/privateLinkScope/PrivateLinkScopes_ListByResourceGroup.json
            // this example is just showing the usage of "PrivateLinkScopes_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "86dc51d3-92ed-4d7e-947a-775ea79b4919";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HybridComputePrivateLinkScopeResource
            HybridComputePrivateLinkScopeCollection collection = resourceGroupResource.GetHybridComputePrivateLinkScopes();

            // invoke the operation and iterate over the result
            await foreach (HybridComputePrivateLinkScopeResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HybridComputePrivateLinkScopeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PrivateLinkScopeGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateLinkScopeGet()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/stable/2024-07-10/examples/privateLinkScope/PrivateLinkScopes_Get.json
            // this example is just showing the usage of "PrivateLinkScopes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "86dc51d3-92ed-4d7e-947a-775ea79b4919";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HybridComputePrivateLinkScopeResource
            HybridComputePrivateLinkScopeCollection collection = resourceGroupResource.GetHybridComputePrivateLinkScopes();

            // invoke the operation
            string scopeName = "my-privatelinkscope";
            HybridComputePrivateLinkScopeResource result = await collection.GetAsync(scopeName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridComputePrivateLinkScopeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateLinkScopeGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PrivateLinkScopeGet()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/stable/2024-07-10/examples/privateLinkScope/PrivateLinkScopes_Get.json
            // this example is just showing the usage of "PrivateLinkScopes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "86dc51d3-92ed-4d7e-947a-775ea79b4919";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HybridComputePrivateLinkScopeResource
            HybridComputePrivateLinkScopeCollection collection = resourceGroupResource.GetHybridComputePrivateLinkScopes();

            // invoke the operation
            string scopeName = "my-privatelinkscope";
            bool result = await collection.ExistsAsync(scopeName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PrivateLinkScopeGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PrivateLinkScopeGet()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/stable/2024-07-10/examples/privateLinkScope/PrivateLinkScopes_Get.json
            // this example is just showing the usage of "PrivateLinkScopes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "86dc51d3-92ed-4d7e-947a-775ea79b4919";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HybridComputePrivateLinkScopeResource
            HybridComputePrivateLinkScopeCollection collection = resourceGroupResource.GetHybridComputePrivateLinkScopes();

            // invoke the operation
            string scopeName = "my-privatelinkscope";
            NullableResponse<HybridComputePrivateLinkScopeResource> response = await collection.GetIfExistsAsync(scopeName);
            HybridComputePrivateLinkScopeResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HybridComputePrivateLinkScopeData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PrivateLinkScopeCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PrivateLinkScopeCreate()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/stable/2024-07-10/examples/privateLinkScope/PrivateLinkScopes_Create.json
            // this example is just showing the usage of "PrivateLinkScopes_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "86dc51d3-92ed-4d7e-947a-775ea79b4919";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HybridComputePrivateLinkScopeResource
            HybridComputePrivateLinkScopeCollection collection = resourceGroupResource.GetHybridComputePrivateLinkScopes();

            // invoke the operation
            string scopeName = "my-privatelinkscope";
            HybridComputePrivateLinkScopeData data = new HybridComputePrivateLinkScopeData(new AzureLocation("westus"));
            ArmOperation<HybridComputePrivateLinkScopeResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, scopeName, data);
            HybridComputePrivateLinkScopeResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridComputePrivateLinkScopeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateLinkScopeUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PrivateLinkScopeUpdate()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/stable/2024-07-10/examples/privateLinkScope/PrivateLinkScopes_Update.json
            // this example is just showing the usage of "PrivateLinkScopes_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "86dc51d3-92ed-4d7e-947a-775ea79b4919";
            string resourceGroupName = "my-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HybridComputePrivateLinkScopeResource
            HybridComputePrivateLinkScopeCollection collection = resourceGroupResource.GetHybridComputePrivateLinkScopes();

            // invoke the operation
            string scopeName = "my-privatelinkscope";
            HybridComputePrivateLinkScopeData data = new HybridComputePrivateLinkScopeData(new AzureLocation("westus"))
            {
                Tags =
{
["Tag1"] = "Value1",
},
            };
            ArmOperation<HybridComputePrivateLinkScopeResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, scopeName, data);
            HybridComputePrivateLinkScopeResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridComputePrivateLinkScopeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
