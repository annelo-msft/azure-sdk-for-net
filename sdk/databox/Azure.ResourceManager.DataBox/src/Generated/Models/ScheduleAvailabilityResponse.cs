// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Schedule availability for given sku in a region. </summary>
    internal partial class ScheduleAvailabilityResponse
    {
        /// <summary> Initializes a new instance of ScheduleAvailabilityResponse. </summary>
        internal ScheduleAvailabilityResponse()
        {
            AvailableDates = new Core.ChangeTrackingList<DateTimeOffset>();
        }

        /// <summary> Initializes a new instance of ScheduleAvailabilityResponse. </summary>
        /// <param name="availableDates"> List of dates available to schedule. </param>
        internal ScheduleAvailabilityResponse(IReadOnlyList<DateTimeOffset> availableDates)
        {
            AvailableDates = availableDates;
        }

        /// <summary> List of dates available to schedule. </summary>
        public IReadOnlyList<DateTimeOffset> AvailableDates { get; }
    }
}
