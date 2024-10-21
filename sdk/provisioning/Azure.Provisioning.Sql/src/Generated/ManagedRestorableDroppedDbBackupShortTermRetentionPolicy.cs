// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// ManagedRestorableDroppedDbBackupShortTermRetentionPolicy.
/// </summary>
public partial class ManagedRestorableDroppedDbBackupShortTermRetentionPolicy : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The backup retention period in days. This is how many days
    /// Point-in-Time Restore will be supported.
    /// </summary>
    public BicepValue<int> RetentionDays { get => _retentionDays; set => _retentionDays.Assign(value); }
    private readonly BicepValue<int> _retentionDays;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new ManagedRestorableDroppedDbBackupShortTermRetentionPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// ManagedRestorableDroppedDbBackupShortTermRetentionPolicy resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedRestorableDroppedDbBackupShortTermRetentionPolicy.</param>
    public ManagedRestorableDroppedDbBackupShortTermRetentionPolicy(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/managedInstances/restorableDroppedDatabases/backupShortTermRetentionPolicies", resourceVersion)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _retentionDays = BicepValue<int>.DefineProperty(this, "RetentionDays", ["properties", "retentionDays"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Creates a reference to an existing
    /// ManagedRestorableDroppedDbBackupShortTermRetentionPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// ManagedRestorableDroppedDbBackupShortTermRetentionPolicy resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedRestorableDroppedDbBackupShortTermRetentionPolicy.</param>
    /// <returns>The existing ManagedRestorableDroppedDbBackupShortTermRetentionPolicy resource.</returns>
    public static ManagedRestorableDroppedDbBackupShortTermRetentionPolicy FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
