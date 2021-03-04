using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Azure.Containers.ContainerRegistry;
using Azure.Identity;

namespace ContainerRegistrySamples
{
    public class Sample_ManageItems
    {
        public async Task ViewListOfImagesInRepositoryAndInfoAboutThem()
        {
            var registryClient = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());
            var repositoryClient = registryClient.GetRepositoryClient("hello-world");

            Console.WriteLine($"Repository \"hello-world\" contains the following images:");

            var images = repositoryClient.GetImagesAsync();

            await foreach (var image in images)
            {
                PrintImageProperties(image);
            }
        }

        public async Task ListItemsOrderedByLastUpdateTime()
        {
            // TODO: Sample: List Manifests, orderby last update time
        }

        public async Task GetImageInfo()
        {
            var registryClient = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());
            
            // for one tagged image
            var repositoryClient = registryClient.GetRepositoryClient("hello-world");
            var imageProperties = await repositoryClient.GetImagePropertiesAsync("latest");
            PrintImageProperties(imageProperties);

            // for an entire repository (this include digest into)
            AsyncPageable<ImageProperties> images = repositoryClient.GetImagesAsync();
            await foreach (var image in images)
            {
                PrintImageProperties(image);
            }
        }

        public async Task UpdateManifestPermissions()
        {
            var repositoryClient = new RepositoryClient(new Uri("myacr.azurecr.io"), "hello-world", new DefaultAzureCredential());

            ContentPermissions permissions = new ContentPermissions()
            {
                CanList = true,
                CanRead = true,
                CanWrite = false,
                CanDelete = false
            };

            await repositoryClient.SetTagPermissionsAsync("latest", permissions);

            // TODO: show that trying to write to this manifest fails.  Also, what is the bigger story here?  
            // It seems like it would be a DevOps story, since this is about being able to push to a registry.
        }

        public async Task SelectImageInManifestList()
        {
            // scenario is:  When a user runs a docker pull or a docker run command,
            // the Docker engine does the work of selecting which image to pull 
            // based on the operating system and architecture on which it is running. 
            // As a result, a project’s users no longer have to worry about finding
            // the name of the image that will work for their platform. 
            // https://developer.ibm.com/components/ibm-power/tutorials/createmulti-architecture-docker-images/

            // Assuming the manifest list is one level deep to simplify this example
            var repositoryClient = new RepositoryClient(new Uri("myacr.azurecr.io"), "multi-arch-image");
            ImageProperties manifestList = await repositoryClient.GetImagePropertiesAsync("latest");
            if (manifestList.Images.Count > 0)
            {
                foreach (ImageProperties image in manifestList.Images )
                {
                    Console.WriteLine($"Image {image.Registry}/{image.Repository}:{image.Digest}");
                    Console.WriteLine($"  supports architecture/OS ${image.CpuArchitecture}/{image.OperatingSystem}");
                }
            }

            // Find the digest corresponding to the linux / amd64 platform
            ImageProperties amd64image = manifestList.Images.Where(i => i.OperatingSystem == "linux" && i.CpuArchitecture == "amd64").FirstOrDefault();
        }

        private void PrintImageProperties(ImageProperties imageProperties)
        {
            Console.WriteLine($"Item is {imageProperties.Registry}/{imageProperties.Repository}:{imageProperties.Digest}");

            Console.WriteLine($"Item {imageProperties.Repository}:{imageProperties.Digest} was created at {imageProperties.CreatedTime}");
            Console.WriteLine($"Item {imageProperties.Repository}:{imageProperties.Digest} was last updated at {imageProperties.LastUpdateTime}");

            // TODO: is this the right unit on size?
            Console.WriteLine($"Item {imageProperties.Repository}:{imageProperties.Digest} is {imageProperties.Size} bytes.");

            Console.WriteLine($"Item {imageProperties.Repository}:{imageProperties.Digest} Platform CPU architecture is {imageProperties.CpuArchitecture}.");
            Console.WriteLine($"Item {imageProperties.Repository}:{imageProperties.Digest} Platform OS is {imageProperties.OperatingSystem}.");

            Console.WriteLine($"Item {imageProperties.Repository}:{imageProperties.Digest} has these tags:");
            foreach (string tag in imageProperties.Tags)
            {
                Console.WriteLine(tag);
            }

            Console.WriteLine($"Item {imageProperties.Repository}:{imageProperties.Digest} permissions are:");
            Console.WriteLine($"    CanList: {imageProperties.ManifestPermissions.CanList}");
            Console.WriteLine($"    CanRead: {imageProperties.ManifestPermissions.CanRead}");
            Console.WriteLine($"    CanWrite: {imageProperties.ManifestPermissions.CanWrite}");
            Console.WriteLine($"    CanDelete: {imageProperties.ManifestPermissions.CanDelete}");
        }
    }
}
