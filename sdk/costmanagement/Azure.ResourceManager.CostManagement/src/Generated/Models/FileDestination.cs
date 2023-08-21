// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Destination of the view data. This is optional. Currently only CSV format is supported. </summary>
    internal partial class FileDestination
    {
        /// <summary> Initializes a new instance of FileDestination. </summary>
        public FileDestination()
        {
            FileFormats = new Core.ChangeTrackingList<ScheduledActionFileFormat>();
        }

        /// <summary> Initializes a new instance of FileDestination. </summary>
        /// <param name="fileFormats"> Destination of the view data. Currently only CSV format is supported. </param>
        internal FileDestination(IList<ScheduledActionFileFormat> fileFormats)
        {
            FileFormats = fileFormats;
        }

        /// <summary> Destination of the view data. Currently only CSV format is supported. </summary>
        public IList<ScheduledActionFileFormat> FileFormats { get; }
    }
}
