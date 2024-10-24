// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningDataVersionCollectionGetAllOptions. </summary>
    public partial class MachineLearningDataVersionCollectionGetAllOptions
    {
        /// <summary> Initializes a new instance of MachineLearningDataVersionCollectionGetAllOptions. </summary>
        public MachineLearningDataVersionCollectionGetAllOptions()
        {
        }

        /// <summary> Please choose OrderBy value from ['createdtime', 'modifiedtime']. </summary>
        public string OrderBy { get; set; }
        /// <summary>
        /// Top count of results, top count cannot be greater than the page size.
        ///                               If topCount &gt; page size, results with be default page size count will be returned
        /// </summary>
        public int? Top { get; set; }
        /// <summary> Continuation token for pagination. </summary>
        public string Skip { get; set; }
        /// <summary> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </summary>
        public string Tags { get; set; }
        /// <summary> [ListViewType.ActiveOnly, ListViewType.ArchivedOnly, ListViewType.All]View type for including/excluding (for example) archived entities. </summary>
        public MachineLearningListViewType? ListViewType { get; set; }
        /// <summary> data stage. </summary>
        public string Stage { get; set; }
    }
}
