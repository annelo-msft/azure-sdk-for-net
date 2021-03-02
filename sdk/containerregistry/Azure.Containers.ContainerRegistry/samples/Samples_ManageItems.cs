using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Azure.Containers.ContainerRegistry;
using Azure.Identity;

namespace ContainerRegistrySamples
{
    public class Sample_ManageItems
    {
        public async Task ViewListOfManifestsInRepositoryAndInfoAboutThem()
        {
            var registryClient = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());

            Console.WriteLine($"Repository \"hello-world\" contains the following items:");

            AsyncPageable<ManifestProperties> items = registryClient.GetImagesAsync("hello-world");
            await foreach (var item in items)
            {
                PrintItemProperties(item);
            }
        }

        public async Task ListItemsOrderedByLastUpdateTime()
        {
            // TODO: Sample: List Manifests, orderby last update time
        }

        public async Task GetItemProperties()
        {
            var registryClient = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());
            
            // for one tagged image
            var ImageClient = registryClient.GetImageClient("hello-world", "latest");
            var itemProperties = await ImageClient.GetManifestPropertiesAsync();
            PrintItemProperties(itemProperties);

            // for an entire repository (this include digest into)
            AsyncPageable<ManifestProperties> images = registryClient.GetImagesAsync("hello-world");
            await foreach (var image in images)
            {
                PrintItemProperties(image);
            }
        }

        public async Task UpdateManifestPermissions()
        {
            var ImageClient = new ImageClient(new Uri("myacr.azurecr.io"), "hello-world", "latest", new DefaultAzureCredential());

            ContentPermissions permissions = new ContentPermissions()
            {
                CanList = true,
                CanRead = true,
                CanWrite = false,
                CanDelete = false
            };

            await ImageClient.SetTagPermissionsAsync(permissions);

            // TODO: show that trying to write to this manifest fails.  Also, what is the bigger story here?  
            // It seems like it would be a DevOps story, since this is about being able to push to a registry.
        }

        public async Task ViewImagesInManifestList()
        {
            // TODO: rewrite this for recursion correctly
            var itemClient = new ImageClient(new Uri("myacr.azurecr.io"), "redis", "latest");
            ManifestProperties manifestList = itemClient.GetManifestProperties();
            if (manifestList.Images.Count > 0)
            {
                // TODO: this should be items
                foreach (var image in manifestList.Images )
                {

                }
            }
        }

        private void PrintItemProperties(ManifestProperties itemProperties)
        {
            Console.WriteLine($"Item is {itemProperties.Registry}/{itemProperties.Name}:{itemProperties.Digest}");

            Console.WriteLine($"Item {itemProperties.Name}:{itemProperties.Digest} was created at {itemProperties.CreatedTime}");
            Console.WriteLine($"Item {itemProperties.Name}:{itemProperties.Digest} was last updated at {itemProperties.LastUpdateTime}");

            // TODO: is this the right unit on size?
            Console.WriteLine($"Item {itemProperties.Name}:{itemProperties.Digest} is {itemProperties.Size} bytes.");

            Console.WriteLine($"Item {itemProperties.Name}:{itemProperties.Digest} Platform CPU architecture is {itemProperties.CpuArchitecture}.");
            Console.WriteLine($"Item {itemProperties.Name}:{itemProperties.Digest} Platform OS is {itemProperties.OperatingSystem}.");

            Console.WriteLine($"Item {itemProperties.Name}:{itemProperties.Digest} has these tags:");
            foreach (string tag in itemProperties.Tags)
            {
                Console.WriteLine(tag);
            }

            Console.WriteLine($"Item {itemProperties.Name}:{itemProperties.Digest} permissions are:");
            Console.WriteLine($"    CanList: {itemProperties.Permissions.CanList}");
            Console.WriteLine($"    CanRead: {itemProperties.Permissions.CanRead}");
            Console.WriteLine($"    CanWrite: {itemProperties.Permissions.CanWrite}");
            Console.WriteLine($"    CanDelete: {itemProperties.Permissions.CanDelete}");
        }
    }
}
