// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Maintenance window used to configure scheduled auto-upgrade for a Managed Cluster. </summary>
    public partial class ContainerServiceMaintenanceWindow
    {
        /// <summary> Initializes a new instance of ContainerServiceMaintenanceWindow. </summary>
        /// <param name="schedule"> Recurrence schedule for the maintenance window. </param>
        /// <param name="durationHours"> Length of maintenance window range from 4 to 24 hours. </param>
        /// <param name="startTime"> The start time of the maintenance window. Accepted values are from '00:00' to '23:59'. 'utcOffset' applies to this field. For example: '02:00' with 'utcOffset: +02:00' means UTC time '00:00'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schedule"/> or <paramref name="startTime"/> is null. </exception>
        public ContainerServiceMaintenanceWindow(ContainerServiceMaintenanceSchedule schedule, int durationHours, string startTime)
        {
            Argument.AssertNotNull(schedule, nameof(schedule));
            Argument.AssertNotNull(startTime, nameof(startTime));

            Schedule = schedule;
            DurationHours = durationHours;
            StartTime = startTime;
            NotAllowedDates = new Core.ChangeTrackingList<ContainerServiceDateSpan>();
        }

        /// <summary> Initializes a new instance of ContainerServiceMaintenanceWindow. </summary>
        /// <param name="schedule"> Recurrence schedule for the maintenance window. </param>
        /// <param name="durationHours"> Length of maintenance window range from 4 to 24 hours. </param>
        /// <param name="utcOffset"> The UTC offset in format +/-HH:mm. For example, '+05:30' for IST and '-07:00' for PST. If not specified, the default is '+00:00'. </param>
        /// <param name="startDate"> The date the maintenance window activates. If the current date is before this date, the maintenance window is inactive and will not be used for upgrades. If not specified, the maintenance window will be active right away. </param>
        /// <param name="startTime"> The start time of the maintenance window. Accepted values are from '00:00' to '23:59'. 'utcOffset' applies to this field. For example: '02:00' with 'utcOffset: +02:00' means UTC time '00:00'. </param>
        /// <param name="notAllowedDates"> Date ranges on which upgrade is not allowed. 'utcOffset' applies to this field. For example, with 'utcOffset: +02:00' and 'dateSpan' being '2022-12-23' to '2023-01-03', maintenance will be blocked from '2022-12-22 22:00' to '2023-01-03 22:00' in UTC time. </param>
        internal ContainerServiceMaintenanceWindow(ContainerServiceMaintenanceSchedule schedule, int durationHours, string utcOffset, string startDate, string startTime, IList<ContainerServiceDateSpan> notAllowedDates)
        {
            Schedule = schedule;
            DurationHours = durationHours;
            UtcOffset = utcOffset;
            StartDate = startDate;
            StartTime = startTime;
            NotAllowedDates = notAllowedDates;
        }

        /// <summary> Recurrence schedule for the maintenance window. </summary>
        public ContainerServiceMaintenanceSchedule Schedule { get; set; }
        /// <summary> Length of maintenance window range from 4 to 24 hours. </summary>
        public int DurationHours { get; set; }
        /// <summary> The UTC offset in format +/-HH:mm. For example, '+05:30' for IST and '-07:00' for PST. If not specified, the default is '+00:00'. </summary>
        public string UtcOffset { get; set; }
        /// <summary> The start time of the maintenance window. Accepted values are from '00:00' to '23:59'. 'utcOffset' applies to this field. For example: '02:00' with 'utcOffset: +02:00' means UTC time '00:00'. </summary>
        public string StartTime { get; set; }
        /// <summary> Date ranges on which upgrade is not allowed. 'utcOffset' applies to this field. For example, with 'utcOffset: +02:00' and 'dateSpan' being '2022-12-23' to '2023-01-03', maintenance will be blocked from '2022-12-22 22:00' to '2023-01-03 22:00' in UTC time. </summary>
        public IList<ContainerServiceDateSpan> NotAllowedDates { get; }
    }
}
