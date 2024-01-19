// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Omnichannel channel definition. </summary>
    public partial class Omnichannel : BotChannelProperties
    {
        /// <summary> Initializes a new instance of <see cref="Omnichannel"/>. </summary>
        public Omnichannel()
        {
            ChannelName = "Omnichannel";
        }

        /// <summary> Initializes a new instance of <see cref="Omnichannel"/>. </summary>
        /// <param name="channelName"> The channel name. </param>
        /// <param name="etag"> Entity Tag of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="location"> Specifies the location of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Omnichannel(string channelName, ETag? etag, string provisioningState, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(channelName, etag, provisioningState, location, serializedAdditionalRawData)
        {
            ChannelName = channelName ?? "Omnichannel";
        }
    }
}
