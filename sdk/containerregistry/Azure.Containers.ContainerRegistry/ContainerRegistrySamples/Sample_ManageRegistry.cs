using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Azure.Containers.ContainerRegistry;
using Azure.Identity;

namespace ContainerRegistrySamples
{
    public class Sample_ManageRegistry
    {
        public async Task ViewRepositories()
        {
            var client = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());

            AsyncPageable<string> repositories = client.GetRepositoryNamesAsync();
            await foreach (var repository in repositories)
            {
                Console.WriteLine($"Repository name is {repository}");
            }

            // TODO: Come up with a nice hero scenario to illustrate in samples
        }

        public async Task ViewManifestsInRepository()
        {
            var client = new ContainerRegistryRepositoryClient(new Uri("myacr.azurecr.io"), "hello-world", new DefaultAzureCredential());

            // TODO: I don't think we need name here, because we specified the image name as the repository in the constructor.  Is this correct?
            // TODO: This should be pageable
            // TODO: Pageable of what?  It's meta-data about the manifest, so let's call it ManifestInfo for now...
            client.GetManifests()

        }

        public async Task ViewTagsInRepository()
        {

        }
    }
}
