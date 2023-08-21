// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Structure of command payload. </summary>
    public partial class DataFlowDebugCommandPayload
    {
        /// <summary> Initializes a new instance of DataFlowDebugCommandPayload. </summary>
        /// <param name="streamName"> The stream name which is used for preview. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="streamName"/> is null. </exception>
        public DataFlowDebugCommandPayload(string streamName)
        {
            Argument.AssertNotNull(streamName, nameof(streamName));

            StreamName = streamName;
            Columns = new Core.ChangeTrackingList<string>();
        }

        /// <summary> The stream name which is used for preview. </summary>
        public string StreamName { get; }
        /// <summary> Row limits for preview response. </summary>
        public int? RowLimits { get; set; }
        /// <summary> Array of column names. </summary>
        public IList<string> Columns { get; }
        /// <summary> The expression which is used for preview. </summary>
        public string Expression { get; set; }
    }
}
