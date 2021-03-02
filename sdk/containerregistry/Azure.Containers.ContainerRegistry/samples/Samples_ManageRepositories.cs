using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Azure.Containers.ContainerRegistry;
using Azure.Identity;

namespace ContainerRegistrySamples
{
    public class Sample_ManageRepositories
    {
        public async Task ViewRepositories()
        {
            string registry = "myacr.azurecr.io";
            var client = new ContainerRegistryClient(new Uri(registry), new DefaultAzureCredential());

            Console.WriteLine("Registry contains the following repositories:");

            AsyncPageable<string> repositories = client.GetRepositoriesAsync();
            await foreach (var repository in repositories)
            {
                Console.WriteLine($"    {registry}/{repository}");
            }

            // TODO: Come up with a nice hero scenario to illustrate in samples
        }

        public async Task GetRepositoryProperties()
        {
            var client = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());

            RepositoryProperties repository = await client.GetRepositoryAsync("hello-world");

            Console.WriteLine($"Repository is {repository.Registry}/{repository.Name}");

            Console.WriteLine($"Repository {repository.Name} was created at {repository.CreatedTime}");
            Console.WriteLine($"Repository {repository.Name} was last updated at {repository.LastUpdateTime}");

            Console.WriteLine($"Repository {repository.Name} has {repository.ItemCount} items");
            Console.WriteLine($"Repository {repository.Name} has {repository.TagCount} tags");

            Console.WriteLine($"Repository {repository.Name} permissions are:");
            Console.WriteLine($"    CanList: {repository.Permissions.CanList}");
            Console.WriteLine($"    CanRead: {repository.Permissions.CanRead}");
            Console.WriteLine($"    CanWrite: {repository.Permissions.CanWrite}");
            Console.WriteLine($"    CanDelete: {repository.Permissions.CanDelete}");
        }

        public async Task SetRepositoryPermissions()
        {
            var client = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());

            await client.SetRepositoryPermissionsAsync("hello-world", new ContentPermissions()
            {
                CanList = true,
                CanRead = true,
                CanWrite = false,
                CanDelete = false
            });

        }

        public async Task DeleteRepository()
        {
            var client = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());

            // TODO: add error handling
            DeleteRepositoryResult result = await client.DeleteRepositoryAsync("hello-world");

            Console.WriteLine("Deleted repository hello-world.");
            Console.WriteLine($"    Deleted {result.DeletedItemDigests.Count} items:");
            Console.WriteLine($"    Deleted {result.DeletedTags.Count} tags.");
        }
    }
}
