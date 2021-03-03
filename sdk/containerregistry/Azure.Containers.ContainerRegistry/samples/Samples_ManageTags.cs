using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Azure.Containers.ContainerRegistry;
using Azure.Identity;

namespace ContainerRegistrySamples
{
    public class Samples_ManageTags
    {
        public async Task ListTagsForItem()
        {
            var registryClient = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());
            var imageClient = registryClient.GetItemClient("hello-world", "latest");

            AsyncPageable<TagProperties> tags = imageClient.GetTagsAsync();
            await foreach (var tag in tags)
            {
                PrintTagProperties(tag);
            }
        }

        private void PrintTagProperties(TagProperties tag)
        {
            // Print Tag Info
            Console.WriteLine($"Item is {tag.Registry}/{tag.Repository}:{tag.Name}");
            
            Console.WriteLine($"Tag {tag.Repository}:{tag.Name} was created at {tag.CreatedTime}");
            Console.WriteLine($"Tag {tag.Repository}:{tag.Name} was last updated at {tag.LastUpdateTime}");

            // We won't IsSigned... content trust is being deprecated
            //Console.WriteLine($"Tag IsSigned is {tag.IsSigned}");

            Console.WriteLine($"Tag {tag.Repository}:{tag.Name} permissions are:");
            Console.WriteLine($"    CanList: {tag.Permissions.CanList}");
            Console.WriteLine($"    CanRead: {tag.Permissions.CanRead}");
            Console.WriteLine($"    CanWrite: {tag.Permissions.CanWrite}");
            Console.WriteLine($"    CanDelete: {tag.Permissions.CanDelete}");
        }

        public async Task ViewItemTagsOrderedByLastUpdateTime()
        {
            var imageClient = new RegistryItemClient(new Uri("myacr.azurecr.io"), "hello-world", "latest", new DefaultAzureCredential());
         
            AsyncPageable<TagProperties> tags = imageClient.GetTagsAsync(new GetTagOptions(orderBy: TagOrderBy.LastUpdateTimeDescending));

            // Note:
            // Set of orderby values can be found in the az acr client (see --orderby / Allowed values
            //PS C: \Users\annelo > az acr repository show - tags--help

            //Command
            //    az acr repository show - tags : Show tags for a repository in an Azure Container Registry.
            //  Arguments
            //--orderby:
            //            Order the items in the results. Default to alphabetical order of
            //                              names.Allowed values: time_asc, time_desc.
            // From Teja: you can only sort by last update time, not created time

            await foreach (TagProperties tag in tags)
            {
                Console.WriteLine($"Updated {tag.LastUpdateTime}: Tag: {tag.Name}");
            }
        }

        public async Task GetTagProperties()
        {
            // Qn: what is the story around why you would do this? To look at last update time or tag permissions.

            var imageClient = new RegistryItemClient(new Uri("myacr.azurecr.io"), "hello-world", "latest", new DefaultAzureCredential());

            TagProperties tagProperties = await imageClient.GetTagPropertiesAsync("latest");

            PrintTagProperties(tagProperties);
        }

        public async Task UpdateTagPermissions()
        {
            // Note: this isn't arbitrary SetProperties because we can only update the permissions component of the tag metadata - everything else is read-only

            var imageClient = new RegistryItemClient(new Uri("myacr.azurecr.io"), "hello-world", "latest", new DefaultAzureCredential());

            await imageClient.SetTagPermissionsAsync(new ContentPermissions()
            {
                CanList = true,
                CanRead = true,
                CanWrite = false,
                CanDelete = false
            });


            Console.WriteLine($"Updating {imageClient.Registry}/{imageClient.Repository}:{imageClient.Tag}");
            try
            {
                using FileStream fs = File.OpenRead(@"c:\path\to\image-manifest");
                //await imageClient.PushAsync(fs);
            }
            catch (RequestFailedException e)
            {
                Console.WriteLine($"Failed to push image.  Error was {e.Message}.");
            }
        }

        public async Task DeleteTag()
        {
            // TODO: does this just delete the tag but not the manifest or anything else?
            // Or is there more to this story?

            var imageClient = new RegistryItemClient(new Uri("myacr.azurecr.io"), "hello-world", "v3", new DefaultAzureCredential());

            await imageClient.UntagAsync("latest");

            // TODO: Write a story where we verify that this is gone.
        }

    }
}
