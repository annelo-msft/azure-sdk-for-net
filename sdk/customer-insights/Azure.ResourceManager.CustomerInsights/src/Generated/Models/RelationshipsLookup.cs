// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The definition of suggested relationship for the type. </summary>
    public partial class RelationshipsLookup
    {
        /// <summary> Initializes a new instance of RelationshipsLookup. </summary>
        internal RelationshipsLookup()
        {
            ProfilePropertyReferences = new Core.ChangeTrackingList<ParticipantProfilePropertyReference>();
            RelatedProfilePropertyReferences = new Core.ChangeTrackingList<ParticipantProfilePropertyReference>();
        }

        /// <summary> Initializes a new instance of RelationshipsLookup. </summary>
        /// <param name="profileName"> The relationship profile. </param>
        /// <param name="profilePropertyReferences"> The property references for the profile type. </param>
        /// <param name="relatedProfileName"> The related profile. </param>
        /// <param name="relatedProfilePropertyReferences"> The property references for the related profile type. </param>
        /// <param name="existingRelationshipName"> The name of existing Relationship. </param>
        internal RelationshipsLookup(string profileName, IReadOnlyList<ParticipantProfilePropertyReference> profilePropertyReferences, string relatedProfileName, IReadOnlyList<ParticipantProfilePropertyReference> relatedProfilePropertyReferences, string existingRelationshipName)
        {
            ProfileName = profileName;
            ProfilePropertyReferences = profilePropertyReferences;
            RelatedProfileName = relatedProfileName;
            RelatedProfilePropertyReferences = relatedProfilePropertyReferences;
            ExistingRelationshipName = existingRelationshipName;
        }

        /// <summary> The relationship profile. </summary>
        public string ProfileName { get; }
        /// <summary> The property references for the profile type. </summary>
        public IReadOnlyList<ParticipantProfilePropertyReference> ProfilePropertyReferences { get; }
        /// <summary> The related profile. </summary>
        public string RelatedProfileName { get; }
        /// <summary> The property references for the related profile type. </summary>
        public IReadOnlyList<ParticipantProfilePropertyReference> RelatedProfilePropertyReferences { get; }
        /// <summary> The name of existing Relationship. </summary>
        public string ExistingRelationshipName { get; }
    }
}
