// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> Object that includes an array of CommunicationServices and a possible link for next set. </summary>
    public partial class CommunicationServiceResourceList
    {
        /// <summary> Initializes a new instance of CommunicationServiceResourceList. </summary>
        internal CommunicationServiceResourceList()
        {
            Value = new ChangeTrackingList<CommunicationServiceResource>();
        }

        /// <summary> Initializes a new instance of CommunicationServiceResourceList. </summary>
        /// <param name="value"> List of CommunicationService. </param>
        /// <param name="nextLink">
        /// The URL the client should use to fetch the next page (per server side paging).
        /// 
        /// It&apos;s null for now, added for future use.
        /// </param>
        internal CommunicationServiceResourceList(IReadOnlyList<CommunicationServiceResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of CommunicationService. </summary>
        public IReadOnlyList<CommunicationServiceResource> Value { get; }
        /// <summary>
        /// The URL the client should use to fetch the next page (per server side paging).
        /// 
        /// It&apos;s null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
