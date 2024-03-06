// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Communication.CallingServer
{
    /// <summary> The GetParticipantsResponse. </summary>
    internal partial class GetParticipantsResponseInternal
    {
        /// <summary> Initializes a new instance of <see cref="GetParticipantsResponseInternal"/>. </summary>
        internal GetParticipantsResponseInternal()
        {
            Values = new ChangeTrackingList<AcsCallParticipantInternal>();
        }

        /// <summary> Initializes a new instance of <see cref="GetParticipantsResponseInternal"/>. </summary>
        /// <param name="values"></param>
        /// <param name="nextLink"></param>
        internal GetParticipantsResponseInternal(IReadOnlyList<AcsCallParticipantInternal> values, string nextLink)
        {
            Values = values;
            NextLink = nextLink;
        }

        /// <summary> Gets the values. </summary>
        public IReadOnlyList<AcsCallParticipantInternal> Values { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
