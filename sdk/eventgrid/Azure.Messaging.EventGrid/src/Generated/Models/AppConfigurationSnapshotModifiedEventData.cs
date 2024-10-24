// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.AppConfiguration.SnapshotModified event. </summary>
    public partial class AppConfigurationSnapshotModifiedEventData : AppConfigurationSnapshotEventData
    {
        /// <summary> Initializes a new instance of AppConfigurationSnapshotModifiedEventData. </summary>
        internal AppConfigurationSnapshotModifiedEventData()
        {
        }

        /// <summary> Initializes a new instance of AppConfigurationSnapshotModifiedEventData. </summary>
        /// <param name="name"> The name of the snapshot. </param>
        /// <param name="eTag"> The etag representing the new state of the snapshot. </param>
        /// <param name="syncToken"> The sync token representing the server state after the event. </param>
        internal AppConfigurationSnapshotModifiedEventData(string name, string eTag, string syncToken) : base(name, eTag, syncToken)
        {
        }
    }
}
