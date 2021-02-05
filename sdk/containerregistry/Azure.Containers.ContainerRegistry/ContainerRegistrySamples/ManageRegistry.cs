using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Azure.Containers.ContainerRegistry;
using Azure.Identity;

namespace ContainerRegistrySamples
{
    public class ManageRegistry
    {
        public async Task ViewRepositories()
        {
            var client = new ContainerRegistryClient(new Uri("myacr.azurecr.io"), new DefaultAzureCredential());
            var repositories = client.GetRepositories();

        }

        public async Task ViewManifestsInRepository()
        {

        }

        public async Task ViewTagsInRepository()
        {

        }
    }
}
