// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// AgentPoolSnapshot.
/// </summary>
public partial class AgentPoolSnapshot : ProvisionableResource
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
    /// This is the ARM ID of the source object to be used to create the target
    /// object.
    /// </summary>
    public BicepValue<ResourceIdentifier> CreationDataSourceResourceId { get => _creationDataSourceResourceId; set => _creationDataSourceResourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _creationDataSourceResourceId;

    /// <summary>
    /// The type of a snapshot. The default is NodePool.
    /// </summary>
    public BicepValue<SnapshotType> SnapshotType { get => _snapshotType; set => _snapshotType.Assign(value); }
    private readonly BicepValue<SnapshotType> _snapshotType;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Whether to use a FIPS-enabled OS.
    /// </summary>
    public BicepValue<bool> EnableFips { get => _enableFips; }
    private readonly BicepValue<bool> _enableFips;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The version of Kubernetes.
    /// </summary>
    public BicepValue<string> KubernetesVersion { get => _kubernetesVersion; }
    private readonly BicepValue<string> _kubernetesVersion;

    /// <summary>
    /// The version of node image.
    /// </summary>
    public BicepValue<string> NodeImageVersion { get => _nodeImageVersion; }
    private readonly BicepValue<string> _nodeImageVersion;

    /// <summary>
    /// Specifies the OS SKU used by the agent pool. The default is Ubuntu if
    /// OSType is Linux. The default is Windows2019 when Kubernetes &lt;= 1.24
    /// or Windows2022 when Kubernetes &gt;= 1.25 if OSType is Windows.
    /// </summary>
    public BicepValue<ContainerServiceOSSku> OSSku { get => _oSSku; }
    private readonly BicepValue<ContainerServiceOSSku> _oSSku;

    /// <summary>
    /// The operating system type. The default is Linux.
    /// </summary>
    public BicepValue<ContainerServiceOSType> OSType { get => _oSType; }
    private readonly BicepValue<ContainerServiceOSType> _oSType;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// The size of the VM.
    /// </summary>
    public BicepValue<string> VmSize { get => _vmSize; }
    private readonly BicepValue<string> _vmSize;

    /// <summary>
    /// Creates a new AgentPoolSnapshot.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AgentPoolSnapshot resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AgentPoolSnapshot.</param>
    public AgentPoolSnapshot(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.ContainerService/snapshots", resourceVersion ?? "2024-08-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _creationDataSourceResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "CreationDataSourceResourceId", ["properties", "creationData", "sourceResourceId"]);
        _snapshotType = BicepValue<SnapshotType>.DefineProperty(this, "SnapshotType", ["properties", "snapshotType"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _enableFips = BicepValue<bool>.DefineProperty(this, "EnableFips", ["properties", "enableFIPS"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _kubernetesVersion = BicepValue<string>.DefineProperty(this, "KubernetesVersion", ["properties", "kubernetesVersion"], isOutput: true);
        _nodeImageVersion = BicepValue<string>.DefineProperty(this, "NodeImageVersion", ["properties", "nodeImageVersion"], isOutput: true);
        _oSSku = BicepValue<ContainerServiceOSSku>.DefineProperty(this, "OSSku", ["properties", "osSku"], isOutput: true);
        _oSType = BicepValue<ContainerServiceOSType>.DefineProperty(this, "OSType", ["properties", "osType"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _vmSize = BicepValue<string>.DefineProperty(this, "VmSize", ["properties", "vmSize"], isOutput: true);
    }

    /// <summary>
    /// Supported AgentPoolSnapshot resource versions.
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
    }

    /// <summary>
    /// Creates a reference to an existing AgentPoolSnapshot.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AgentPoolSnapshot resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AgentPoolSnapshot.</param>
    /// <returns>The existing AgentPoolSnapshot resource.</returns>
    public static AgentPoolSnapshot FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
