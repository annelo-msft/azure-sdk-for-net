// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// For schedules like: &apos;recur every Monday&apos; or &apos;recur every 3
/// weeks on Wednesday&apos;.
/// </summary>
public partial class ContainerServiceMaintenanceWeeklySchedule : ProvisionableConstruct
{
    /// <summary>
    /// Specifies the number of weeks between each set of occurrences.
    /// </summary>
    public BicepValue<int> IntervalWeeks { get => _intervalWeeks; set => _intervalWeeks.Assign(value); }
    private readonly BicepValue<int> _intervalWeeks;

    /// <summary>
    /// Specifies on which day of the week the maintenance occurs.
    /// </summary>
    public BicepValue<ContainerServiceWeekDay> DayOfWeek { get => _dayOfWeek; set => _dayOfWeek.Assign(value); }
    private readonly BicepValue<ContainerServiceWeekDay> _dayOfWeek;

    /// <summary>
    /// Creates a new ContainerServiceMaintenanceWeeklySchedule.
    /// </summary>
    public ContainerServiceMaintenanceWeeklySchedule()
    {
        _intervalWeeks = BicepValue<int>.DefineProperty(this, "IntervalWeeks", ["intervalWeeks"]);
        _dayOfWeek = BicepValue<ContainerServiceWeekDay>.DefineProperty(this, "DayOfWeek", ["dayOfWeek"]);
    }
}
