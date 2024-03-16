// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Sphere;
using Azure.ResourceManager.Sphere.Models;

namespace Azure.ResourceManager.Sphere.Samples
{
    public partial class Sample_SphereDeviceResource
    {
        // Devices_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DevicesGet()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/GetDevice.json
            // this example is just showing the usage of "Devices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereDeviceResource created on azure
            // for more information of creating SphereDeviceResource, please refer to the document of SphereDeviceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            string productName = "MyProduct1";
            string deviceGroupName = "myDeviceGroup1";
            string deviceName = "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            ResourceIdentifier sphereDeviceResourceId = SphereDeviceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName, productName, deviceGroupName, deviceName);
            SphereDeviceResource sphereDevice = client.GetSphereDeviceResource(sphereDeviceResourceId);

            // invoke the operation
            SphereDeviceResource result = await sphereDevice.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SphereDeviceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Devices_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DevicesUpdate()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/PatchDevice.json
            // this example is just showing the usage of "Devices_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereDeviceResource created on azure
            // for more information of creating SphereDeviceResource, please refer to the document of SphereDeviceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            string productName = "MyProduct1";
            string deviceGroupName = "MyDeviceGroup1";
            string deviceName = "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            ResourceIdentifier sphereDeviceResourceId = SphereDeviceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName, productName, deviceGroupName, deviceName);
            SphereDeviceResource sphereDevice = client.GetSphereDeviceResource(sphereDeviceResourceId);

            // invoke the operation
            SphereDevicePatch patch = new SphereDevicePatch();
            ArmOperation<SphereDeviceResource> lro = await sphereDevice.UpdateAsync(WaitUntil.Completed, patch);
            SphereDeviceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SphereDeviceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Devices_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DevicesDelete()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/DeleteDevice.json
            // this example is just showing the usage of "Devices_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereDeviceResource created on azure
            // for more information of creating SphereDeviceResource, please refer to the document of SphereDeviceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            string productName = "MyProductName1";
            string deviceGroupName = "DeviceGroupName1";
            string deviceName = "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            ResourceIdentifier sphereDeviceResourceId = SphereDeviceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName, productName, deviceGroupName, deviceName);
            SphereDeviceResource sphereDevice = client.GetSphereDeviceResource(sphereDeviceResourceId);

            // invoke the operation
            await sphereDevice.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Devices_GenerateCapabilityImage
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GenerateCapabilityImage_DevicesGenerateCapabilityImage()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/stable/2024-04-01/examples/PostGenerateDeviceCapabilityImage.json
            // this example is just showing the usage of "Devices_GenerateCapabilityImage" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereDeviceResource created on azure
            // for more information of creating SphereDeviceResource, please refer to the document of SphereDeviceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            string productName = "MyProduct1";
            string deviceGroupName = "myDeviceGroup1";
            string deviceName = "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            ResourceIdentifier sphereDeviceResourceId = SphereDeviceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName, productName, deviceGroupName, deviceName);
            SphereDeviceResource sphereDevice = client.GetSphereDeviceResource(sphereDeviceResourceId);

            // invoke the operation
            GenerateCapabilityImageContent content = new GenerateCapabilityImageContent(new SphereCapabilityType[]
            {
SphereCapabilityType.ApplicationDevelopment
            });
            ArmOperation<SignedCapabilityImageResponse> lro = await sphereDevice.GenerateCapabilityImageAsync(WaitUntil.Completed, content);
            SignedCapabilityImageResponse result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
