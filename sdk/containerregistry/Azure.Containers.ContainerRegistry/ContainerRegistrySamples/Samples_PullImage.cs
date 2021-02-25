using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Azure.Containers.ContainerRegistry;
using Azure.Containers.ContainerRegistry.Authentication;
using Azure.Containers.ContainerRegistry.Models;
using Azure.Containers.ContainerRegistry.Storage;
using Azure.Containers.ContainerRegistry.Storage.Models;
using Azure.Identity;

namespace ContainerRegistrySamples
{
    public class Samples_PullImage
    {
        public async Task PullWithAnonymousAccess()
        {
            //ContainerRegistryClient registryClient = new ContainerRegistryClient(
            //    new Uri("myacr.azurecr.io") 
            //    /* Note: No Credentials! */);

            //RepositoryClient repositoryClient = registryClient.GetRepositoryClient("hello-world");
            //ArtifactClient artifactClient = repositoryClient.GetArtifactClient(new ArtifactReference("latest"));
        }

        public async Task AnonymousPullDockerCLI()
        {
            ContainerRegistryStsClient stsClient = new ContainerRegistryStsClient(
               new Uri("myacr.azurecr.io")
               /* Note: No Credentials! */);

            Process loginCmd = Process.Start("docker.exe",
               arguments: $"login {stsClient.Endpoint} --username 00000000-0000-0000-0000-000000000000 --password {stsClient.GetAccessToken()}");
            loginCmd.WaitForExit();

            Process pushCmd = Process.Start("docker.exe",
               arguments: $"pull {stsClient.Endpoint}/hello-world:v1");
            loginCmd.WaitForExit();
        }
    }
}
