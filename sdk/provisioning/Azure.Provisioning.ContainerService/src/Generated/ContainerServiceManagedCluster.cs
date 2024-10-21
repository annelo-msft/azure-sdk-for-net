// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// ContainerServiceManagedCluster.
/// </summary>
public partial class ContainerServiceManagedCluster : ProvisionableResource
{
    /// <summary>
    /// The name of the managed cluster resource.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The Azure Active Directory configuration.
    /// </summary>
    public BicepValue<ManagedClusterAadProfile> AadProfile { get => _aadProfile; set => _aadProfile.Assign(value); }
    private readonly BicepValue<ManagedClusterAadProfile> _aadProfile;

    /// <summary>
    /// The profile of managed cluster add-on.
    /// </summary>
    public BicepDictionary<ManagedClusterAddonProfile> AddonProfiles { get => _addonProfiles; set => _addonProfiles.Assign(value); }
    private readonly BicepDictionary<ManagedClusterAddonProfile> _addonProfiles;

    /// <summary>
    /// The agent pool properties.
    /// </summary>
    public BicepList<ManagedClusterAgentPoolProfile> AgentPoolProfiles { get => _agentPoolProfiles; set => _agentPoolProfiles.Assign(value); }
    private readonly BicepList<ManagedClusterAgentPoolProfile> _agentPoolProfiles;

    /// <summary>
    /// The access profile for managed cluster API server.
    /// </summary>
    public BicepValue<ManagedClusterApiServerAccessProfile> ApiServerAccessProfile { get => _apiServerAccessProfile; set => _apiServerAccessProfile.Assign(value); }
    private readonly BicepValue<ManagedClusterApiServerAccessProfile> _apiServerAccessProfile;

    /// <summary>
    /// Parameters to be applied to the cluster-autoscaler when enabled.
    /// </summary>
    public BicepValue<ManagedClusterAutoScalerProfile> AutoScalerProfile { get => _autoScalerProfile; set => _autoScalerProfile.Assign(value); }
    private readonly BicepValue<ManagedClusterAutoScalerProfile> _autoScalerProfile;

    /// <summary>
    /// The auto upgrade configuration.
    /// </summary>
    public BicepValue<ManagedClusterAutoUpgradeProfile> AutoUpgradeProfile { get => _autoUpgradeProfile; set => _autoUpgradeProfile.Assign(value); }
    private readonly BicepValue<ManagedClusterAutoUpgradeProfile> _autoUpgradeProfile;

    /// <summary>
    /// Metrics profile for the Azure Monitor managed service for Prometheus
    /// addon. Collect out-of-the-box Kubernetes infrastructure metrics to
    /// send to an Azure Monitor Workspace and configure additional scraping
    /// for custom targets. See aka.ms/AzureManagedPrometheus for an overview.
    /// </summary>
    public BicepValue<ManagedClusterMonitorProfileMetrics> AzureMonitorMetrics { get => _azureMonitorMetrics; set => _azureMonitorMetrics.Assign(value); }
    private readonly BicepValue<ManagedClusterMonitorProfileMetrics> _azureMonitorMetrics;

    /// <summary>
    /// The identity of the managed cluster, if configured.
    /// </summary>
    public BicepValue<ManagedClusterIdentity> ClusterIdentity { get => _clusterIdentity; set => _clusterIdentity.Assign(value); }
    private readonly BicepValue<ManagedClusterIdentity> _clusterIdentity;

    /// <summary>
    /// If set to true, getting static credentials will be disabled for this
    /// cluster. This must only be used on Managed Clusters that are AAD
    /// enabled. For more details see [disable local
    /// accounts](https://docs.microsoft.com/azure/aks/managed-aad#disable-local-accounts-preview).
    /// </summary>
    public BicepValue<bool> DisableLocalAccounts { get => _disableLocalAccounts; set => _disableLocalAccounts.Assign(value); }
    private readonly BicepValue<bool> _disableLocalAccounts;

    /// <summary>
    /// This is of the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{encryptionSetName}&apos;.
    /// </summary>
    public BicepValue<ResourceIdentifier> DiskEncryptionSetId { get => _diskEncryptionSetId; set => _diskEncryptionSetId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _diskEncryptionSetId;

    /// <summary>
    /// This cannot be updated once the Managed Cluster has been created.
    /// </summary>
    public BicepValue<string> DnsPrefix { get => _dnsPrefix; set => _dnsPrefix.Assign(value); }
    private readonly BicepValue<string> _dnsPrefix;

    /// <summary>
    /// (DEPRECATED) Whether to enable Kubernetes pod security policy
    /// (preview). PodSecurityPolicy was deprecated in Kubernetes v1.21, and
    /// removed from Kubernetes in v1.25. Learn more at https://aka.ms/k8s/psp
    /// and https://aka.ms/aks/psp.
    /// </summary>
    public BicepValue<bool> EnablePodSecurityPolicy { get => _enablePodSecurityPolicy; set => _enablePodSecurityPolicy.Assign(value); }
    private readonly BicepValue<bool> _enablePodSecurityPolicy;

    /// <summary>
    /// Whether to enable Kubernetes Role-Based Access Control.
    /// </summary>
    public BicepValue<bool> EnableRbac { get => _enableRbac; set => _enableRbac.Assign(value); }
    private readonly BicepValue<bool> _enableRbac;

    /// <summary>
    /// The extended location of the Virtual Machine.
    /// </summary>
    public BicepValue<ExtendedAzureLocation> ExtendedLocation { get => _extendedLocation; set => _extendedLocation.Assign(value); }
    private readonly BicepValue<ExtendedAzureLocation> _extendedLocation;

    /// <summary>
    /// This cannot be updated once the Managed Cluster has been created.
    /// </summary>
    public BicepValue<string> FqdnSubdomain { get => _fqdnSubdomain; set => _fqdnSubdomain.Assign(value); }
    private readonly BicepValue<string> _fqdnSubdomain;

    /// <summary>
    /// Configurations for provisioning the cluster with HTTP proxy servers.
    /// </summary>
    public BicepValue<ManagedClusterHttpProxyConfig> HttpProxyConfig { get => _httpProxyConfig; set => _httpProxyConfig.Assign(value); }
    private readonly BicepValue<ManagedClusterHttpProxyConfig> _httpProxyConfig;

    /// <summary>
    /// Identities associated with the cluster.
    /// </summary>
    public BicepDictionary<ContainerServiceUserAssignedIdentity> IdentityProfile { get => _identityProfile; set => _identityProfile.Assign(value); }
    private readonly BicepDictionary<ContainerServiceUserAssignedIdentity> _identityProfile;

    /// <summary>
    /// Both patch version &lt;major.minor.patch&gt; (e.g. 1.20.13) and
    /// &lt;major.minor&gt; (e.g. 1.20) are supported. When
    /// &lt;major.minor&gt; is specified, the latest supported GA patch
    /// version is chosen automatically. Updating the cluster with the same
    /// &lt;major.minor&gt; once it has been created (e.g. 1.14.x -&gt; 1.14)
    /// will not trigger an upgrade, even if a newer patch version is
    /// available. When you upgrade a supported AKS cluster, Kubernetes minor
    /// versions cannot be skipped. All upgrades must be performed
    /// sequentially by major version number. For example, upgrades between
    /// 1.14.x -&gt; 1.15.x or 1.15.x -&gt; 1.16.x are allowed, however 1.14.x
    /// -&gt; 1.16.x is not allowed. See [upgrading an AKS
    /// cluster](https://docs.microsoft.com/azure/aks/upgrade-cluster) for
    /// more details.
    /// </summary>
    public BicepValue<string> KubernetesVersion { get => _kubernetesVersion; set => _kubernetesVersion.Assign(value); }
    private readonly BicepValue<string> _kubernetesVersion;

    /// <summary>
    /// The profile for Linux VMs in the Managed Cluster.
    /// </summary>
    public BicepValue<ContainerServiceLinuxProfile> LinuxProfile { get => _linuxProfile; set => _linuxProfile.Assign(value); }
    private readonly BicepValue<ContainerServiceLinuxProfile> _linuxProfile;

    /// <summary>
    /// The network configuration profile.
    /// </summary>
    public BicepValue<ContainerServiceNetworkProfile> NetworkProfile { get => _networkProfile; set => _networkProfile.Assign(value); }
    private readonly BicepValue<ContainerServiceNetworkProfile> _networkProfile;

    /// <summary>
    /// The name of the resource group containing agent pool nodes.
    /// </summary>
    public BicepValue<string> NodeResourceGroup { get => _nodeResourceGroup; set => _nodeResourceGroup.Assign(value); }
    private readonly BicepValue<string> _nodeResourceGroup;

    /// <summary>
    /// The OIDC issuer profile of the Managed Cluster.
    /// </summary>
    public BicepValue<ManagedClusterOidcIssuerProfile> OidcIssuerProfile { get => _oidcIssuerProfile; set => _oidcIssuerProfile.Assign(value); }
    private readonly BicepValue<ManagedClusterOidcIssuerProfile> _oidcIssuerProfile;

    /// <summary>
    /// See [use AAD pod
    /// identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity)
    /// for more details on AAD pod identity integration.
    /// </summary>
    public BicepValue<ManagedClusterPodIdentityProfile> PodIdentityProfile { get => _podIdentityProfile; set => _podIdentityProfile.Assign(value); }
    private readonly BicepValue<ManagedClusterPodIdentityProfile> _podIdentityProfile;

    /// <summary>
    /// Private link resources associated with the cluster.
    /// </summary>
    public BicepList<ContainerServicePrivateLinkResourceData> PrivateLinkResources { get => _privateLinkResources; set => _privateLinkResources.Assign(value); }
    private readonly BicepList<ContainerServicePrivateLinkResourceData> _privateLinkResources;

    /// <summary>
    /// Allow or deny public network access for AKS.
    /// </summary>
    public BicepValue<ContainerServicePublicNetworkAccess> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<ContainerServicePublicNetworkAccess> _publicNetworkAccess;

    /// <summary>
    /// Security profile for the managed cluster.
    /// </summary>
    public BicepValue<ManagedClusterSecurityProfile> SecurityProfile { get => _securityProfile; set => _securityProfile.Assign(value); }
    private readonly BicepValue<ManagedClusterSecurityProfile> _securityProfile;

    /// <summary>
    /// Service mesh profile for a managed cluster.
    /// </summary>
    public BicepValue<ServiceMeshProfile> ServiceMeshProfile { get => _serviceMeshProfile; set => _serviceMeshProfile.Assign(value); }
    private readonly BicepValue<ServiceMeshProfile> _serviceMeshProfile;

    /// <summary>
    /// Information about a service principal identity for the cluster to use
    /// for manipulating Azure APIs.
    /// </summary>
    public BicepValue<ManagedClusterServicePrincipalProfile> ServicePrincipalProfile { get => _servicePrincipalProfile; set => _servicePrincipalProfile.Assign(value); }
    private readonly BicepValue<ManagedClusterServicePrincipalProfile> _servicePrincipalProfile;

    /// <summary>
    /// The managed cluster SKU.
    /// </summary>
    public BicepValue<ManagedClusterSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<ManagedClusterSku> _sku;

    /// <summary>
    /// Storage profile for the managed cluster.
    /// </summary>
    public BicepValue<ManagedClusterStorageProfile> StorageProfile { get => _storageProfile; set => _storageProfile.Assign(value); }
    private readonly BicepValue<ManagedClusterStorageProfile> _storageProfile;

    /// <summary>
    /// The support plan for the Managed Cluster. If unspecified, the default
    /// is &apos;KubernetesOfficial&apos;.
    /// </summary>
    public BicepValue<KubernetesSupportPlan> SupportPlan { get => _supportPlan; set => _supportPlan.Assign(value); }
    private readonly BicepValue<KubernetesSupportPlan> _supportPlan;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Settings for overrides.
    /// </summary>
    public BicepValue<UpgradeOverrideSettings> UpgradeOverrideSettings { get => _upgradeOverrideSettings; set => _upgradeOverrideSettings.Assign(value); }
    private readonly BicepValue<UpgradeOverrideSettings> _upgradeOverrideSettings;

    /// <summary>
    /// The profile for Windows VMs in the Managed Cluster.
    /// </summary>
    public BicepValue<ManagedClusterWindowsProfile> WindowsProfile { get => _windowsProfile; set => _windowsProfile.Assign(value); }
    private readonly BicepValue<ManagedClusterWindowsProfile> _windowsProfile;

    /// <summary>
    /// Workload Auto-scaler profile for the managed cluster.
    /// </summary>
    public BicepValue<ManagedClusterWorkloadAutoScalerProfile> WorkloadAutoScalerProfile { get => _workloadAutoScalerProfile; set => _workloadAutoScalerProfile.Assign(value); }
    private readonly BicepValue<ManagedClusterWorkloadAutoScalerProfile> _workloadAutoScalerProfile;

    /// <summary>
    /// The Azure Portal requires certain Cross-Origin Resource Sharing (CORS)
    /// headers to be sent in some responses, which Kubernetes APIServer
    /// doesn&apos;t handle by default. This special FQDN supports CORS,
    /// allowing the Azure Portal to function properly.
    /// </summary>
    public BicepValue<string> AzurePortalFqdn { get => _azurePortalFqdn; }
    private readonly BicepValue<string> _azurePortalFqdn;

    /// <summary>
    /// If kubernetesVersion was a fully specified version
    /// &lt;major.minor.patch&gt;, this field will be exactly equal to it. If
    /// kubernetesVersion was &lt;major.minor&gt;, this field will contain the
    /// full &lt;major.minor.patch&gt; version being used.
    /// </summary>
    public BicepValue<string> CurrentKubernetesVersion { get => _currentKubernetesVersion; }
    private readonly BicepValue<string> _currentKubernetesVersion;

    /// <summary>
    /// The FQDN of the master pool.
    /// </summary>
    public BicepValue<string> Fqdn { get => _fqdn; }
    private readonly BicepValue<string> _fqdn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The max number of agent pools for the managed cluster.
    /// </summary>
    public BicepValue<int> MaxAgentPools { get => _maxAgentPools; }
    private readonly BicepValue<int> _maxAgentPools;

    /// <summary>
    /// Tells whether the cluster is Running or Stopped.
    /// </summary>
    public BicepValue<ContainerServiceStateCode> PowerStateCode { get => _powerStateCode; }
    private readonly BicepValue<ContainerServiceStateCode> _powerStateCode;

    /// <summary>
    /// The FQDN of private cluster.
    /// </summary>
    public BicepValue<string> PrivateFqdn { get => _privateFqdn; }
    private readonly BicepValue<string> _privateFqdn;

    /// <summary>
    /// The current provisioning state.
    /// </summary>
    public BicepValue<string> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<string> _provisioningState;

    /// <summary>
    /// The resourceUID uniquely identifies ManagedClusters that reuse ARM
    /// ResourceIds (i.e: create, delete, create sequence).
    /// </summary>
    public BicepValue<ResourceIdentifier> ResourceId { get => _resourceId; }
    private readonly BicepValue<ResourceIdentifier> _resourceId;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new ContainerServiceManagedCluster.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerServiceManagedCluster
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerServiceManagedCluster.</param>
    public ContainerServiceManagedCluster(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.ContainerService/managedClusters", resourceVersion ?? "2024-08-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _aadProfile = BicepValue<ManagedClusterAadProfile>.DefineProperty(this, "AadProfile", ["properties", "aadProfile"]);
        _addonProfiles = BicepDictionary<ManagedClusterAddonProfile>.DefineProperty(this, "AddonProfiles", ["properties", "addonProfiles"]);
        _agentPoolProfiles = BicepList<ManagedClusterAgentPoolProfile>.DefineProperty(this, "AgentPoolProfiles", ["properties", "agentPoolProfiles"]);
        _apiServerAccessProfile = BicepValue<ManagedClusterApiServerAccessProfile>.DefineProperty(this, "ApiServerAccessProfile", ["properties", "apiServerAccessProfile"]);
        _autoScalerProfile = BicepValue<ManagedClusterAutoScalerProfile>.DefineProperty(this, "AutoScalerProfile", ["properties", "autoScalerProfile"]);
        _autoUpgradeProfile = BicepValue<ManagedClusterAutoUpgradeProfile>.DefineProperty(this, "AutoUpgradeProfile", ["properties", "autoUpgradeProfile"]);
        _azureMonitorMetrics = BicepValue<ManagedClusterMonitorProfileMetrics>.DefineProperty(this, "AzureMonitorMetrics", ["properties", "azureMonitorProfile", "metrics"]);
        _clusterIdentity = BicepValue<ManagedClusterIdentity>.DefineProperty(this, "ClusterIdentity", ["identity"]);
        _disableLocalAccounts = BicepValue<bool>.DefineProperty(this, "DisableLocalAccounts", ["properties", "disableLocalAccounts"]);
        _diskEncryptionSetId = BicepValue<ResourceIdentifier>.DefineProperty(this, "DiskEncryptionSetId", ["properties", "diskEncryptionSetID"]);
        _dnsPrefix = BicepValue<string>.DefineProperty(this, "DnsPrefix", ["properties", "dnsPrefix"]);
        _enablePodSecurityPolicy = BicepValue<bool>.DefineProperty(this, "EnablePodSecurityPolicy", ["properties", "enablePodSecurityPolicy"]);
        _enableRbac = BicepValue<bool>.DefineProperty(this, "EnableRbac", ["properties", "enableRBAC"]);
        _extendedLocation = BicepValue<ExtendedAzureLocation>.DefineProperty(this, "ExtendedLocation", ["extendedLocation"]);
        _fqdnSubdomain = BicepValue<string>.DefineProperty(this, "FqdnSubdomain", ["properties", "fqdnSubdomain"]);
        _httpProxyConfig = BicepValue<ManagedClusterHttpProxyConfig>.DefineProperty(this, "HttpProxyConfig", ["properties", "httpProxyConfig"]);
        _identityProfile = BicepDictionary<ContainerServiceUserAssignedIdentity>.DefineProperty(this, "IdentityProfile", ["properties", "identityProfile"]);
        _kubernetesVersion = BicepValue<string>.DefineProperty(this, "KubernetesVersion", ["properties", "kubernetesVersion"]);
        _linuxProfile = BicepValue<ContainerServiceLinuxProfile>.DefineProperty(this, "LinuxProfile", ["properties", "linuxProfile"]);
        _networkProfile = BicepValue<ContainerServiceNetworkProfile>.DefineProperty(this, "NetworkProfile", ["properties", "networkProfile"]);
        _nodeResourceGroup = BicepValue<string>.DefineProperty(this, "NodeResourceGroup", ["properties", "nodeResourceGroup"]);
        _oidcIssuerProfile = BicepValue<ManagedClusterOidcIssuerProfile>.DefineProperty(this, "OidcIssuerProfile", ["properties", "oidcIssuerProfile"]);
        _podIdentityProfile = BicepValue<ManagedClusterPodIdentityProfile>.DefineProperty(this, "PodIdentityProfile", ["properties", "podIdentityProfile"]);
        _privateLinkResources = BicepList<ContainerServicePrivateLinkResourceData>.DefineProperty(this, "PrivateLinkResources", ["properties", "privateLinkResources"]);
        _publicNetworkAccess = BicepValue<ContainerServicePublicNetworkAccess>.DefineProperty(this, "PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _securityProfile = BicepValue<ManagedClusterSecurityProfile>.DefineProperty(this, "SecurityProfile", ["properties", "securityProfile"]);
        _serviceMeshProfile = BicepValue<ServiceMeshProfile>.DefineProperty(this, "ServiceMeshProfile", ["properties", "serviceMeshProfile"]);
        _servicePrincipalProfile = BicepValue<ManagedClusterServicePrincipalProfile>.DefineProperty(this, "ServicePrincipalProfile", ["properties", "servicePrincipalProfile"]);
        _sku = BicepValue<ManagedClusterSku>.DefineProperty(this, "Sku", ["sku"]);
        _storageProfile = BicepValue<ManagedClusterStorageProfile>.DefineProperty(this, "StorageProfile", ["properties", "storageProfile"]);
        _supportPlan = BicepValue<KubernetesSupportPlan>.DefineProperty(this, "SupportPlan", ["properties", "supportPlan"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _upgradeOverrideSettings = BicepValue<UpgradeOverrideSettings>.DefineProperty(this, "UpgradeOverrideSettings", ["properties", "upgradeSettings", "overrideSettings"]);
        _windowsProfile = BicepValue<ManagedClusterWindowsProfile>.DefineProperty(this, "WindowsProfile", ["properties", "windowsProfile"]);
        _workloadAutoScalerProfile = BicepValue<ManagedClusterWorkloadAutoScalerProfile>.DefineProperty(this, "WorkloadAutoScalerProfile", ["properties", "workloadAutoScalerProfile"]);
        _azurePortalFqdn = BicepValue<string>.DefineProperty(this, "AzurePortalFqdn", ["properties", "azurePortalFQDN"], isOutput: true);
        _currentKubernetesVersion = BicepValue<string>.DefineProperty(this, "CurrentKubernetesVersion", ["properties", "currentKubernetesVersion"], isOutput: true);
        _fqdn = BicepValue<string>.DefineProperty(this, "Fqdn", ["properties", "fqdn"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _maxAgentPools = BicepValue<int>.DefineProperty(this, "MaxAgentPools", ["properties", "maxAgentPools"], isOutput: true);
        _powerStateCode = BicepValue<ContainerServiceStateCode>.DefineProperty(this, "PowerStateCode", ["properties", "powerState", "code"], isOutput: true);
        _privateFqdn = BicepValue<string>.DefineProperty(this, "PrivateFqdn", ["properties", "privateFQDN"], isOutput: true);
        _provisioningState = BicepValue<string>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _resourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "ResourceId", ["properties", "resourceUID"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported ContainerServiceManagedCluster resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-08-02-preview.
        /// </summary>
        public static readonly string V2024_08_02_preview = "2024-08-02-preview";

        /// <summary>
        /// 2024-08-01.
        /// </summary>
        public static readonly string V2024_08_01 = "2024-08-01";

        /// <summary>
        /// 2024-07-01.
        /// </summary>
        public static readonly string V2024_07_01 = "2024-07-01";

        /// <summary>
        /// 2024-06-01.
        /// </summary>
        public static readonly string V2024_06_01 = "2024-06-01";

        /// <summary>
        /// 2024-05-01.
        /// </summary>
        public static readonly string V2024_05_01 = "2024-05-01";

        /// <summary>
        /// 2024-02-01.
        /// </summary>
        public static readonly string V2024_02_01 = "2024-02-01";

        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2023-11-01.
        /// </summary>
        public static readonly string V2023_11_01 = "2023-11-01";

        /// <summary>
        /// 2023-10-01.
        /// </summary>
        public static readonly string V2023_10_01 = "2023-10-01";

        /// <summary>
        /// 2023-09-01.
        /// </summary>
        public static readonly string V2023_09_01 = "2023-09-01";

        /// <summary>
        /// 2023-08-01.
        /// </summary>
        public static readonly string V2023_08_01 = "2023-08-01";

        /// <summary>
        /// 2023-07-01.
        /// </summary>
        public static readonly string V2023_07_01 = "2023-07-01";

        /// <summary>
        /// 2023-06-01.
        /// </summary>
        public static readonly string V2023_06_01 = "2023-06-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-03-01.
        /// </summary>
        public static readonly string V2023_03_01 = "2023-03-01";

        /// <summary>
        /// 2023-02-01.
        /// </summary>
        public static readonly string V2023_02_01 = "2023-02-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-11-01.
        /// </summary>
        public static readonly string V2022_11_01 = "2022-11-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-08-01.
        /// </summary>
        public static readonly string V2022_08_01 = "2022-08-01";

        /// <summary>
        /// 2022-07-01.
        /// </summary>
        public static readonly string V2022_07_01 = "2022-07-01";

        /// <summary>
        /// 2022-06-01.
        /// </summary>
        public static readonly string V2022_06_01 = "2022-06-01";

        /// <summary>
        /// 2022-04-01.
        /// </summary>
        public static readonly string V2022_04_01 = "2022-04-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2022-02-01.
        /// </summary>
        public static readonly string V2022_02_01 = "2022-02-01";

        /// <summary>
        /// 2022-01-01.
        /// </summary>
        public static readonly string V2022_01_01 = "2022-01-01";

        /// <summary>
        /// 2021-10-01.
        /// </summary>
        public static readonly string V2021_10_01 = "2021-10-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2021-08-01.
        /// </summary>
        public static readonly string V2021_08_01 = "2021-08-01";

        /// <summary>
        /// 2021-07-01.
        /// </summary>
        public static readonly string V2021_07_01 = "2021-07-01";

        /// <summary>
        /// 2021-05-01.
        /// </summary>
        public static readonly string V2021_05_01 = "2021-05-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-11-01.
        /// </summary>
        public static readonly string V2020_11_01 = "2020-11-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-07-01.
        /// </summary>
        public static readonly string V2020_07_01 = "2020-07-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2020-04-01.
        /// </summary>
        public static readonly string V2020_04_01 = "2020-04-01";

        /// <summary>
        /// 2020-03-01.
        /// </summary>
        public static readonly string V2020_03_01 = "2020-03-01";

        /// <summary>
        /// 2020-02-01.
        /// </summary>
        public static readonly string V2020_02_01 = "2020-02-01";

        /// <summary>
        /// 2020-01-01.
        /// </summary>
        public static readonly string V2020_01_01 = "2020-01-01";

        /// <summary>
        /// 2019-11-01.
        /// </summary>
        public static readonly string V2019_11_01 = "2019-11-01";

        /// <summary>
        /// 2019-10-01.
        /// </summary>
        public static readonly string V2019_10_01 = "2019-10-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";

        /// <summary>
        /// 2019-04-01.
        /// </summary>
        public static readonly string V2019_04_01 = "2019-04-01";

        /// <summary>
        /// 2019-02-01.
        /// </summary>
        public static readonly string V2019_02_01 = "2019-02-01";

        /// <summary>
        /// 2018-03-31.
        /// </summary>
        public static readonly string V2018_03_31 = "2018-03-31";

        /// <summary>
        /// 2017-08-31.
        /// </summary>
        public static readonly string V2017_08_31 = "2017-08-31";
    }

    /// <summary>
    /// Creates a reference to an existing ContainerServiceManagedCluster.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerServiceManagedCluster
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerServiceManagedCluster.</param>
    /// <returns>The existing ContainerServiceManagedCluster resource.</returns>
    public static ContainerServiceManagedCluster FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ContainerServiceManagedCluster
    /// resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 63, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore);

    /// <summary>
    /// Creates a role assignment for a user-assigned identity that grants
    /// access to this ContainerServiceManagedCluster.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(ContainerServiceBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{BicepIdentifier}_{identity.BicepIdentifier}_{ContainerServiceBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Creates a role assignment for a principal that grants access to this
    /// ContainerServiceManagedCluster.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <param name="bicepIdentifierSuffix">Optional role assignment identifier name suffix.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(ContainerServiceBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId, string? bicepIdentifierSuffix = default) =>
        new($"{BicepIdentifier}_{ContainerServiceBuiltInRole.GetBuiltInRoleName(role)}{(bicepIdentifierSuffix is null ? "" : "_")}{bicepIdentifierSuffix}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
