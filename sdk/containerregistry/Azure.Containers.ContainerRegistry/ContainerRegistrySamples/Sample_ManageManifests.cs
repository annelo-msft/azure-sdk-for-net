//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;
//using Azure;
//using Azure.Containers.ContainerRegistry;
//using Azure.Identity;

//namespace ContainerRegistrySamples
//{
//    public class Sample_ManageManifests
//    {
//        public async Task ListManifets()
//        {
//            string registryName = "myacr.azurecr.io";
//            string repositoryName = "hello-world";


//            var client = new ContainerRegistryRepositoryClient(new Uri(registryName), repositoryName, new DefaultAzureCredential());

//            client.GetManifests();
            
            
//            // TODO: I don't think we need name here, because we specified the image name as the repository in the constructor.  Is this correct?
//            // TODO: This should be pageable
//            // TODO: Pageable of what?  It's meta-data about the manifest, so let's call it ManifestInfo for now...
//            AsyncPageable<ManifestAttributes> manifests = client.GetManifestsAsync();
//            await foreach (var manifest in manifests)
//            {
//                Console.WriteLine($"Manifest for {manifest.ArtifactName} is {manifest.ArtifactSize} bytes.");
//            }
//        }
//    }
//}
