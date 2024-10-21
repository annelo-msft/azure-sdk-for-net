// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// This defines the sku conversion status object for asynchronous sku
/// conversions.
/// </summary>
public partial class StorageAccountSkuConversionStatus : ProvisionableConstruct
{
    /// <summary>
    /// This property indicates the current sku conversion status.
    /// </summary>
    public BicepValue<StorageAccountSkuConversionState> SkuConversionStatus { get => _skuConversionStatus; }
    private readonly BicepValue<StorageAccountSkuConversionState> _skuConversionStatus;

    /// <summary>
    /// This property represents the target sku name to which the account sku
    /// is being converted asynchronously.
    /// </summary>
    public BicepValue<StorageSkuName> TargetSkuName { get => _targetSkuName; set => _targetSkuName.Assign(value); }
    private readonly BicepValue<StorageSkuName> _targetSkuName;

    /// <summary>
    /// This property represents the sku conversion start time.
    /// </summary>
    public BicepValue<DateTimeOffset> StartOn { get => _startOn; }
    private readonly BicepValue<DateTimeOffset> _startOn;

    /// <summary>
    /// This property represents the sku conversion end time.
    /// </summary>
    public BicepValue<DateTimeOffset> EndOn { get => _endOn; }
    private readonly BicepValue<DateTimeOffset> _endOn;

    /// <summary>
    /// Creates a new StorageAccountSkuConversionStatus.
    /// </summary>
    public StorageAccountSkuConversionStatus()
    {
        _skuConversionStatus = BicepValue<StorageAccountSkuConversionState>.DefineProperty(this, "SkuConversionStatus", ["skuConversionStatus"], isOutput: true);
        _targetSkuName = BicepValue<StorageSkuName>.DefineProperty(this, "TargetSkuName", ["targetSkuName"]);
        _startOn = BicepValue<DateTimeOffset>.DefineProperty(this, "StartOn", ["startTime"], isOutput: true);
        _endOn = BicepValue<DateTimeOffset>.DefineProperty(this, "EndOn", ["endTime"], isOutput: true);
    }
}
