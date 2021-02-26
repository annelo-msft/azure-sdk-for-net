﻿using System;
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
        public async Task ViewAllTagsForRepository()
        {
            var registryClient = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());
            var repositoryClient = registryClient.GetRepositoryClient("hello-world");

            // TODO: what is the story around tag signing?

            AsyncPageable<TagProperties> tags = repositoryClient.GetTagsAsync();
            await foreach (var tag in tags)
            {
                PrintTagAttributes(tag);
            }
        }

        private void PrintTagAttributes(TagProperties tag)
        {
            // Print Tag
            Console.WriteLine($"Tag repository and digest are {tag.ImageName}:{tag.Digest}");
            Console.WriteLine($"Tag registry is {tag.Registry}");

            Console.WriteLine($"Tag {tag.ImageName}:{tag.Name} was created at {tag.CreatedTime}");
            Console.WriteLine($"Tag {tag.ImageName}:{tag.Name} was last updated at {tag.LastUpdateTime}");

            // TODO: What is the story here? -- we won't expose this - content trust is being deprecated
            //Console.WriteLine($"Tag IsSigned is {tag.IsSigned}");

            Console.WriteLine($"Tag {tag.ImageName}:{tag.Name} permissions are:");
            Console.WriteLine($"    CanList: {tag.Permissions.CanList}");
            Console.WriteLine($"    CanRead: {tag.Permissions.CanRead}");
            Console.WriteLine($"    CanWrite: {tag.Permissions.CanWrite}");
            Console.WriteLine($"    CanDelete: {tag.Permissions.CanDelete}");
        }

        public async Task ViewAllTagsOrderedByLastUpdateTime()
        {
            var registryClient = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());
            var repositoryClient = registryClient.GetRepositoryClient("hello-world");

            AsyncPageable<TagProperties> tags = repositoryClient.GetTagsAsync(new GetTagOptions(orderBy: TagOrderBy.LastUpdateTimeDescending));

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

        public async Task ViewAllTagsForGivenDigest()
        {
            var registryClient = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());
            var repositoryClient = registryClient.GetRepositoryClient("hello-world");

            AsyncPageable<TagProperties> tags = repositoryClient.GetTagsAsync(new GetTagOptions(
                digest: "sha256:90659bf80b44ce6be8234e6ff90a1ac34acbeb826903b02cfa0da11c82cbc042"
                ));


            await foreach (TagProperties tag in tags)
            {
                Console.WriteLine($"Updated {tag.LastUpdateTime}: Tag: {tag.Name}");
            }
        }

        public async Task GetTagMetadata()
        {
            // TODO: what is the story around why you would do this?

            var registryClient = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());
            var repositoryClient = registryClient.GetRepositoryClient("hello-world");

            TagProperties tagAttributes = await repositoryClient.GetTagAsync("latest");

            PrintTagAttributes(tagAttributes);
        }

        public async Task UpdateTagPermissions()
        {
            // We can only update the permissions component of the tag metadata - everything else is read-only

            ContainerRegistryClient registryClient = new ContainerRegistryClient(
                new Uri("myacr.azurecr.io"),
                new ContainerRegistryUserCredential("username", "password"));
            RepositoryClient repositoryClient = registryClient.GetRepositoryClient("hello-world");
            TagClient tagClient = repositoryClient.GetTagClient("v3");
            
            ContentPermissions permissions = new ContentPermissions()
            {
                CanList = true,
                CanRead = true,
                CanWrite = false,
                CanDelete = false
            };

            await tagClient.SetPermissionsAsync(permissions);


            RepositoryItemClient imageClient = repositoryClient.GetArtifactClient(new ArtifactReference("v3"));
            Console.WriteLine($"Updating {imageClient.RepositoryName}:{imageClient.Reference.Tag}");
            try
            {
                using FileStream fs = File.OpenRead(@"c:\path\to\image-manifest");
                await imageClient.PushAsync(fs);
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

            var registryClient = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());
            var repositoryClient = registryClient.GetRepositoryClient("hello-world");

            await repositoryClient.DeleteTagAsync("latest");

            // TODO: Write a story where we verify that this is gone.
        }

    }
}
