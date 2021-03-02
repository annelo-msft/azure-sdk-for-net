using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Azure.Containers.ContainerRegistry;
using Azure.Identity;
using System.Linq;

namespace ContainerRegistrySamples
{
    public class Sample_ManageRegistry
    {
        public async Task DeleteStaleImages()
        {
            // I would like to create a script that scans all my repositories on ACR, and delete all the old docker images, 
            // while only keep the latest three images

            // - list repositories
            // - list manifests by last update time
            // - delete manifest
            // - delete layer (TODO: ?)

            ContainerRegistryClient registryClient = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());
            
            AsyncPageable<string> repositories = registryClient.GetRepositoriesAsync();
            await foreach (var repository in repositories)
            {
                Console.WriteLine($"Repository name: {repository}");

                AsyncPageable<ManifestProperties> items = registryClient.GetImagesAsync(
                    repository,
                    new GetItemsOptions(orderBy: ImageOrderBy.LastUpdateTimeDescending)
                );

                int itemCount = 0;
                int itemsToKeep = 3;
                await foreach (ManifestProperties item in items)
                {
                    if (itemCount++ >= itemsToKeep)
                    { 
                        Console.WriteLine($"Deleting item with digest {item.Digest}.");
                        Console.WriteLine($"   This corresponds to the following tagged images: ");
                        foreach (var tagName in item.Tags)
                        {
                            Console.WriteLine($"        {item.Name}:{tagName}");
                        }
                        await registryClient.DeleteImageAsync(repository, item.Digest);
                    }

                    // This will delete the manifest, but not the item layers unless there are no remaining references to them
                }
            }
        }

        public async Task ViewRepositories()
        {
            var client = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());

            AsyncPageable<string> repositories = client.GetRepositoriesAsync();

            Console.WriteLine($"Registry contains these repositories:");
            await foreach (var repository in repositories)
            {
                Console.WriteLine($"    {repository}");
            }
        }

        public async Task ViewItemsInRepository()
        {
            //// TODO: I don't think we need name here, because we specified the image name as the repository in the constructor.  Is this correct?
            //// TODO: This should be pageable
            //// TODO: Pageable of what?  It's meta-data about the manifest, so let's call it ManifestInfo for now...
            //AsyncPageable<ManifestAttributes> manifests = client.GetManifestsAsync();
            //await foreach (var manifest in manifests)
            //{
            //    Console.WriteLine($"Manifest for {manifest.ArtifactName} is {manifest.ArtifactSize} bytes.");
            //}
        }

        public async Task ViewItemTags()
        {
            //var client = new ContainerRegistryRepositoryClient(new Uri("myacr.azurecr.io"), "hello-world", new DefaultAzureCredential());

            //// TODO: I don't think we need name here, because we specified the image name as the repository in the constructor.  Is this correct?
            //// TODO: This should be pageable
            //// TODO: Pageable of what?  It's meta-data about the manifest, so let's call it ManifestInfo for now...
            //AsyncPageable<TagAttributes> tags = client.GetTagsAsync();
            //await foreach (var tag in tags)
            //{
            //    Console.WriteLine($"Tag {tag.Name} was last updated on {tag.LastUpdateTime} bytes.");
            //}

            //// TODO: Order by last update time
            //// TODO: Get tags for digest
            //// Note: these should use GetTagsOptions()
        }
    }
}
