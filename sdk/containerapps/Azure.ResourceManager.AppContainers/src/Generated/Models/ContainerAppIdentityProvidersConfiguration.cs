// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of each of the identity providers used to configure ContainerApp Service Authentication/Authorization. </summary>
    public partial class ContainerAppIdentityProvidersConfiguration
    {
        /// <summary> Initializes a new instance of ContainerAppIdentityProvidersConfiguration. </summary>
        public ContainerAppIdentityProvidersConfiguration()
        {
            CustomOpenIdConnectProviders = new Core.ChangeTrackingDictionary<string, ContainerAppCustomOpenIdConnectProviderConfiguration>();
        }

        /// <summary> Initializes a new instance of ContainerAppIdentityProvidersConfiguration. </summary>
        /// <param name="azureActiveDirectory"> The configuration settings of the Azure Active directory provider. </param>
        /// <param name="facebook"> The configuration settings of the Facebook provider. </param>
        /// <param name="gitHub"> The configuration settings of the GitHub provider. </param>
        /// <param name="google"> The configuration settings of the Google provider. </param>
        /// <param name="twitter"> The configuration settings of the Twitter provider. </param>
        /// <param name="apple"> The configuration settings of the Apple provider. </param>
        /// <param name="azureStaticWebApps"> The configuration settings of the Azure Static Web Apps provider. </param>
        /// <param name="customOpenIdConnectProviders">
        /// The map of the name of the alias of each custom Open ID Connect provider to the
        /// configuration settings of the custom Open ID Connect provider.
        /// </param>
        internal ContainerAppIdentityProvidersConfiguration(ContainerAppAzureActiveDirectoryConfiguration azureActiveDirectory, ContainerAppFacebookConfiguration facebook, ContainerAppGitHubConfiguration gitHub, ContainerAppGoogleConfiguration google, ContainerAppTwitterConfiguration twitter, ContainerAppAppleConfiguration apple, ContainerAppAzureStaticWebAppsConfiguration azureStaticWebApps, IDictionary<string, ContainerAppCustomOpenIdConnectProviderConfiguration> customOpenIdConnectProviders)
        {
            AzureActiveDirectory = azureActiveDirectory;
            Facebook = facebook;
            GitHub = gitHub;
            Google = google;
            Twitter = twitter;
            Apple = apple;
            AzureStaticWebApps = azureStaticWebApps;
            CustomOpenIdConnectProviders = customOpenIdConnectProviders;
        }

        /// <summary> The configuration settings of the Azure Active directory provider. </summary>
        public ContainerAppAzureActiveDirectoryConfiguration AzureActiveDirectory { get; set; }
        /// <summary> The configuration settings of the Facebook provider. </summary>
        public ContainerAppFacebookConfiguration Facebook { get; set; }
        /// <summary> The configuration settings of the GitHub provider. </summary>
        public ContainerAppGitHubConfiguration GitHub { get; set; }
        /// <summary> The configuration settings of the Google provider. </summary>
        public ContainerAppGoogleConfiguration Google { get; set; }
        /// <summary> The configuration settings of the Twitter provider. </summary>
        public ContainerAppTwitterConfiguration Twitter { get; set; }
        /// <summary> The configuration settings of the Apple provider. </summary>
        public ContainerAppAppleConfiguration Apple { get; set; }
        /// <summary> The configuration settings of the Azure Static Web Apps provider. </summary>
        public ContainerAppAzureStaticWebAppsConfiguration AzureStaticWebApps { get; set; }
        /// <summary>
        /// The map of the name of the alias of each custom Open ID Connect provider to the
        /// configuration settings of the custom Open ID Connect provider.
        /// </summary>
        public IDictionary<string, ContainerAppCustomOpenIdConnectProviderConfiguration> CustomOpenIdConnectProviders { get; }
    }
}
