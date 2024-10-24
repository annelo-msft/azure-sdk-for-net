// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Reference to an asset via its path in a datastore. </summary>
    public partial class MachineLearningDataPathAssetReference : MachineLearningAssetReferenceBase
    {
        /// <summary> Initializes a new instance of MachineLearningDataPathAssetReference. </summary>
        public MachineLearningDataPathAssetReference()
        {
            ReferenceType = ReferenceType.DataPath;
        }

        /// <summary> Initializes a new instance of MachineLearningDataPathAssetReference. </summary>
        /// <param name="referenceType"> [Required] Specifies the type of asset reference. </param>
        /// <param name="datastoreId"> ARM resource ID of the datastore where the asset is located. </param>
        /// <param name="path"> The path of the file/directory in the datastore. </param>
        internal MachineLearningDataPathAssetReference(ReferenceType referenceType, string datastoreId, string path) : base(referenceType)
        {
            DatastoreId = datastoreId;
            Path = path;
            ReferenceType = referenceType;
        }

        /// <summary> ARM resource ID of the datastore where the asset is located. </summary>
        public string DatastoreId { get; set; }
        /// <summary> The path of the file/directory in the datastore. </summary>
        public string Path { get; set; }
    }
}
