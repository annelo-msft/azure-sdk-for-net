// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The job error items. </summary>
    public partial class DataBoxEdgeJobErrorItem
    {
        /// <summary> Initializes a new instance of DataBoxEdgeJobErrorItem. </summary>
        internal DataBoxEdgeJobErrorItem()
        {
            Recommendations = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DataBoxEdgeJobErrorItem. </summary>
        /// <param name="recommendations"> The recommended actions. </param>
        /// <param name="code"> The code intended for programmatic access. </param>
        /// <param name="message"> The message that describes the error in detail. </param>
        internal DataBoxEdgeJobErrorItem(IReadOnlyList<string> recommendations, string code, string message)
        {
            Recommendations = recommendations;
            Code = code;
            Message = message;
        }

        /// <summary> The recommended actions. </summary>
        public IReadOnlyList<string> Recommendations { get; }
        /// <summary> The code intended for programmatic access. </summary>
        public string Code { get; }
        /// <summary> The message that describes the error in detail. </summary>
        public string Message { get; }
    }
}
