// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Client.Models
{
    /// <summary> A representation of a textual item of thread message content. </summary>
    public partial class MessageTextContent : MessageContent
    {
        /// <summary> Initializes a new instance of <see cref="MessageTextContent"/>. </summary>
        /// <param name="internalDetails"> The text and associated annotations for this thread message content item. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="internalDetails"/> is null. </exception>
        public MessageTextContent(InternalMessageTextDetails internalDetails)
        {
            Argument.AssertNotNull(internalDetails, nameof(internalDetails));

            Type = "text";
            InternalDetails = internalDetails;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTextContent"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="internalDetails"> The text and associated annotations for this thread message content item. </param>
        internal MessageTextContent(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalMessageTextDetails internalDetails) : base(type, serializedAdditionalRawData)
        {
            InternalDetails = internalDetails;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTextContent"/> for deserialization. </summary>
        internal MessageTextContent()
        {
        }
    }
}
