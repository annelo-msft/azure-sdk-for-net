// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The result of a request to list events for a webhook. </summary>
    internal partial class ContainerRegistryWebhookEventListResult
    {
        /// <summary> Initializes a new instance of ContainerRegistryWebhookEventListResult. </summary>
        internal ContainerRegistryWebhookEventListResult()
        {
            Value = new Core.ChangeTrackingList<ContainerRegistryWebhookEvent>();
        }

        /// <summary> Initializes a new instance of ContainerRegistryWebhookEventListResult. </summary>
        /// <param name="value"> The list of events. Since this list may be incomplete, the nextLink field should be used to request the next list of events. </param>
        /// <param name="nextLink"> The URI that can be used to request the next list of events. </param>
        internal ContainerRegistryWebhookEventListResult(IReadOnlyList<ContainerRegistryWebhookEvent> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of events. Since this list may be incomplete, the nextLink field should be used to request the next list of events. </summary>
        public IReadOnlyList<ContainerRegistryWebhookEvent> Value { get; }
        /// <summary> The URI that can be used to request the next list of events. </summary>
        public string NextLink { get; }
    }
}
