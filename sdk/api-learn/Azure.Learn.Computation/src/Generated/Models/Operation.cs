// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Learn.Computation.Models
{
    /// <summary> The Operation. </summary>
    public partial class Operation
    {
        /// <summary> Initializes a new instance of Operation. </summary>
        internal Operation()
        {
        }

        /// <summary> Initializes a new instance of Operation. </summary>
        /// <param name="createdDateTime"> Date and time (UTC) when the operation was submitted. </param>
        /// <param name="percentComplete"> The completion state of the operation. </param>
        /// <param name="status"> The current status of the operation. </param>
        internal Operation(DateTimeOffset? createdDateTime, float? percentComplete, OperationStatus? status)
        {
            CreatedDateTime = createdDateTime;
            PercentComplete = percentComplete;
            Status = status;
        }

        /// <summary> Date and time (UTC) when the operation was submitted. </summary>
        public DateTimeOffset? CreatedDateTime { get; }
        /// <summary> The completion state of the operation. </summary>
        public float? PercentComplete { get; }
        /// <summary> The current status of the operation. </summary>
        public OperationStatus? Status { get; }
    }
}
