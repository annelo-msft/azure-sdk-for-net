// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> An ARM resource with that can accept tags. </summary>
    public partial class CommunicationAcceptTags
    {
        /// <summary> Initializes a new instance of CommunicationAcceptTags. </summary>
        public CommunicationAcceptTags()
        {
            Tags = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Tags of the service which is a list of key value pairs that describe the resource. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
