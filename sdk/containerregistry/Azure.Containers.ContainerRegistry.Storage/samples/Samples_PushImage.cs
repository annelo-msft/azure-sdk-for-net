using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Azure.Containers.ContainerRegistry;
using Azure.Containers.ContainerRegistry.Storage;
using Azure.Identity;

namespace ContainerRegistrySamples
{
    public class Samples_PushImage
    {
        public async Task PushImageFromDirectory_DockerV2Manifest()
        {
            ContainerRegistryResumableStorageClient client = new ContainerRegistryResumableStorageClient(new Uri("myacr.azurecr.io"), "hello-world", new DefaultAzureCredential());

            string directory = @"c:\path\to\image";

            if (!Directory.Exists(directory))
            {
                throw new Exception($"{directory} not found");
            }

            var manifestFilePath = Path.Join(directory, "manifest.json");

            if (!File.Exists(manifestFilePath))
            {
                throw new FileNotFoundException($"File not found.", manifestFilePath);
            }

            // _logger.LogInformation($"Reading {manifestFilePath}");
            DockerManifestV2 manifest = null;
            using (var fs = File.OpenRead(manifestFilePath))
            {
                manifest = DockerManifestV2.FromStream(fs);
            }

            if (manifest == null)
            {
                //_logger.LogWarning($"Malformed manifest {manifestFilePath}");
                // throw new DeserializationException - should be handled by the library.
            }
            // TODO: What is the right pattern for deserializing from file?  
            // We shouldn't ask users to handle stream readers and JsonSerializers directly

            // Upload the config file
            var configFilePath = Path.Join(directory, "config.json");
            if (!File.Exists(configFilePath!))
            {
                throw new FileNotFoundException($"File not found.", manifestFilePath);
            }

            //_logger.LogInformation($"Reading {configFilePath}");
            // Note: this is only used to compute the digest.  Let's instead have a blob.compute digest operation
            // since this is unneeded complexity at the moment, I think
            //var configFile = new FileInfo(configFilePath).ToDescriptor();
            using (var fs = File.OpenRead(configFilePath))
            {
                //_logger.LogInformation($"Uploading Config Blob: {configFilePath} {configFile.Digest}");
                CreateUploadResult upload = await client.CreateUploadAsync();
                UploadChunkResult uploadChunkResult = await client.UploadChunkAsync(upload, fs);
                CompleteUploadResult completeUploadResult = await client.CompleteUploadAsync(upload, ComputeDigest(fs));
                // TODO: Is ComputeDigest discoverable on ContentDescriptor?  Probably not ... think this through better.
                // TODO: Does digest need to be exposed?  Do we need to expose all three of these methods for the basic case?
                // TODO: Look at this alongside the chunked upload case.
            }

            // Upload each layer.
            foreach (var file in Directory.GetFiles(directory))
            {
                // TODO: would this also upload manifest and config again?
                // _logger.LogInformation($"Uploading Layer {file}");
                using (var fs = File.OpenRead(file))
                {
                    CreateUploadResult upload = await client.CreateUploadAsync();
                    UploadChunkResult uploadChunkResult = await client.UploadChunkAsync(upload, fs);
                    CompleteUploadResult completeUploadResult = await client.CompleteUploadAsync(upload, ComputeDigest(fs));
                }
            }

            // Put manifest
            // _logger.LogInformation("Uploading Manifest");
            // TODO: Is it a semantically different operation if I pass in a tag or a digest?
            // Note: this method will throw an exception if the content has been tampered with.
            await client.CreateManifestAsync("hello-world", manifest);
            
        }

        private string ComputeDigest(Stream stream)
        {
            throw new NotImplementedException();
        }

        public async Task PushImageFromDirectory_DockerV2Manifest2()
        {
            ContainerRegistryResumableStorageClient client = new ContainerRegistryResumableStorageClient(new Uri("myacr.azurecr.io"), "hello-world", new DefaultAzureCredential());

            string directory = @"c:\path\to\image";

            if (!Directory.Exists(directory))
            {
                throw new Exception($"{directory} not found");
            }

            var manifestFilePath = Path.Join(directory, "manifest.json");
            var configFilePath = Path.Join(directory, "config.json");


            // Upload the config file
            if (!File.Exists(configFilePath!))
            {
                throw new FileNotFoundException($"File not found.", manifestFilePath);
            }

            using (var fs = File.OpenRead(configFilePath))
            {
                CreateUploadResult upload = await client.CreateUploadAsync();
                UploadChunkResult uploadChunkResult = await client.UploadChunkAsync(upload, fs);
                CompleteUploadResult completeUploadResult = await client.CompleteUploadAsync(upload, ComputeDigest(fs));
            }

            // Upload each layer.
            foreach (var file in Directory.GetFiles(directory))
            {
                if (file == manifestFilePath && file == configFilePath)
                {
                    continue;
                }

                using (var fs = File.OpenRead(file))
                {
                    CreateUploadResult upload = await client.CreateUploadAsync();
                    UploadChunkResult uploadChunkResult = await client.UploadChunkAsync(upload, fs);
                    CompleteUploadResult completeUploadResult = await client.CompleteUploadAsync(upload, ComputeDigest(fs));
                }
            }

            if (!File.Exists(manifestFilePath))
            {
                throw new FileNotFoundException($"File not found.", manifestFilePath);
            }

            DockerManifestV2 manifest = null;
            using (var fs = File.OpenRead(manifestFilePath))
            {
                manifest = DockerManifestV2.FromStream(fs);
            }

            // Finally, upload the manifest.
            await client.CreateManifestAsync(manifest);
        }

        public async Task PushImage_DockerV2Manifest()
        {
            ContainerRegistryResumableStorageClient client = new ContainerRegistryResumableStorageClient(new Uri("myacr.azurecr.io"), "hello-world", new DefaultAzureCredential());

            ContentDescriptor configDescriptor = new ContentDescriptor()
            {
                MediaType = (string)ConfigMediaType.DockerImageV1
            };

            using Stream configStream = configDescriptor.ToStream();
            configDescriptor.Size = configStream.Length;
            configDescriptor.Digest = ComputeDigest(configStream);

            CreateUploadResult upload = await client.CreateUploadAsync();
            UploadChunkResult uploadChunkResult = await client.UploadChunkAsync(upload, configStream);
            CompleteUploadResult completeUploadResult = await client.CompleteUploadAsync(upload, configDescriptor.Digest);

            string layerFile = @"path\to\layer";

            ContentDescriptor layerDescriptor = new ContentDescriptor()
            {
                // TODO: make an enum of these values
                MediaType = "application/vnd.docker.image.rootfs.diff.tar.gzip",
            };

            using (var fs = File.OpenRead(layerFile))
            {
                layerDescriptor.Size = fs.Length;
                layerDescriptor.Digest = ComputeDigest(fs);
                upload = await client.CreateUploadAsync();
                uploadChunkResult = await client.UploadChunkAsync(upload, fs);
                completeUploadResult = await client.CompleteUploadAsync(upload, ComputeDigest(fs));
            }

            DockerManifestV2 manifest = new DockerManifestV2()
            {
                ConfigDescriptor = configDescriptor,
                MediaType = ManifestMediaType.DockerManifestV2
            };
            
            manifest.Layers.Add(layerDescriptor);

            await client.CreateManifestAsync(manifest);
        }

        //public async Task PushImageViaDockerCli()
        //{
        //    // TODO: Make this look more like what our tests have
        //    string userName = Environment.GetEnvironmentVariable("ADMIN_USER_NAME");
        //    string password = Environment.GetEnvironmentVariable("ADMIN_PASSWORD");

        //    ContainerRegistryStsClient stsClient = new ContainerRegistryStsClient(new Uri("myacr.azurecr.io"), new ContainerRegistryUserCredential(userName, password));

        //    // TODO: validate this scenario is required, e.g.
        //    // What is the scenario where the Docker daemon isn't running in your environment, but the Docker CLI is provided?
        //    Process loginCmd = Process.Start("docker.exe", arguments: $"login {stsClient.Endpoint} --username 00000000-0000-0000-0000-000000000000 --password {stsClient.GetAccessToken()}");
        //    loginCmd.WaitForExit();

        //    Process pushCmd = Process.Start("docker.exe", arguments: $"push {stsClient.Endpoint}/hello-world:v1");
        //    loginCmd.WaitForExit();
        //}
    }
}
