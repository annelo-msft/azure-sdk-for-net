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
            var repositoryClient = registryClient.GetRepositoryClient("hello-world");

            Console.WriteLine($"Repository \"hello-world\" contains the following items:");

            AsyncPageable<ManifestProperties> items = repositoryClient.GetItemsAsync();
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
            var repositoryClient = registryClient.GetRepositoryClient("hello-world");
            
            // By Tag
            var ImageClient = repositoryClient.GetItemClient("latest");
            var itemProperties = await ImageClient.GetPropertiesAsync();
            PrintItemProperties(itemProperties);

            // By Digest (although once you have it by tag or digest, it'll just work after that)
            ImageClient = repositoryClient.GetItemClient("<digest>");
            itemProperties = await ImageClient.GetPropertiesAsync();
            PrintItemProperties(itemProperties);
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

            await ImageClient.SetPermissionsAsync(permissions);

            // TODO: show that trying to write to this manifest fails.  Also, what is the bigger story here?  
            // It seems like it would be a DevOps story, since this is about being able to push to a registry.
        }

        public async Task HandleManifestList()
        {
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
