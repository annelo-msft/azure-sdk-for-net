// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.IoT.DeviceUpdate.Models
{
    /// <summary> Operation metadata. </summary>
    public partial class UpdateOperation
    {
        /// <summary> Initializes a new instance of UpdateOperation. </summary>
        /// <param name="operationId"> Operation Id. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="lastActionDateTime"> Date and time in UTC when the operation status was last updated. </param>
        /// <param name="createdDateTime"> Date and time in UTC when the operation was created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        internal UpdateOperation(string operationId, OperationStatus status, DateTimeOffset lastActionDateTime, DateTimeOffset createdDateTime)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            OperationId = operationId;
            Status = status;
            LastActionDateTime = lastActionDateTime;
            CreatedDateTime = createdDateTime;
        }

        /// <summary> Initializes a new instance of UpdateOperation. </summary>
        /// <param name="operationId"> Operation Id. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="updateId"> The identity of update being imported or deleted. For import, this property will only be populated after import manifest is processed successfully. </param>
        /// <param name="resourceLocation"> Location of the imported update when operation is successful. </param>
        /// <param name="error"> Operation error encountered, if any. </param>
        /// <param name="traceId"> Operation correlation identity that can used by Microsoft Support for troubleshooting. </param>
        /// <param name="lastActionDateTime"> Date and time in UTC when the operation status was last updated. </param>
        /// <param name="createdDateTime"> Date and time in UTC when the operation was created. </param>
        /// <param name="etag"> Operation ETag. </param>
        internal UpdateOperation(string operationId, OperationStatus status, UpdateId updateId, string resourceLocation, Error error, string traceId, DateTimeOffset lastActionDateTime, DateTimeOffset createdDateTime, string etag)
        {
            OperationId = operationId;
            Status = status;
            UpdateId = updateId;
            ResourceLocation = resourceLocation;
            Error = error;
            TraceId = traceId;
            LastActionDateTime = lastActionDateTime;
            CreatedDateTime = createdDateTime;
            Etag = etag;
        }

        /// <summary> Operation Id. </summary>
        public string OperationId { get; }
        /// <summary> Operation status. </summary>
        public OperationStatus Status { get; }
        /// <summary> The identity of update being imported or deleted. For import, this property will only be populated after import manifest is processed successfully. </summary>
        public UpdateId UpdateId { get; }
        /// <summary> Location of the imported update when operation is successful. </summary>
        public string ResourceLocation { get; }
        /// <summary> Operation error encountered, if any. </summary>
        public Error Error { get; }
        /// <summary> Operation correlation identity that can used by Microsoft Support for troubleshooting. </summary>
        public string TraceId { get; }
        /// <summary> Date and time in UTC when the operation status was last updated. </summary>
        public DateTimeOffset LastActionDateTime { get; }
        /// <summary> Date and time in UTC when the operation was created. </summary>
        public DateTimeOffset CreatedDateTime { get; }
        /// <summary> Operation ETag. </summary>
        public string Etag { get; }
    }
}
