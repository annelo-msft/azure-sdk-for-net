// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.DigitalTwins.Core
{
    /// <summary> Parameter group. </summary>
    public partial class DigitalTwinModelsDeleteOptions
    {
        /// <summary> Initializes a new instance of DigitalTwinModelsDeleteOptions. </summary>
        public DigitalTwinModelsDeleteOptions()
        {
        }

        /// <summary> Identifies the request in a distributed tracing system. </summary>
        public string Traceparent { get; set; }
        /// <summary> Provides vendor-specific trace identification information and is a companion to traceparent. </summary>
        public string Tracestate { get; set; }
    }
}
