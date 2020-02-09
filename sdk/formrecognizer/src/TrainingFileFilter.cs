﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary>
    /// Training request source filter.
    /// </summary>
    public class TrainingFileFilter
    {
        /// <summary>
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="includeSubFolders"></param>
        public TrainingFileFilter(string prefix = "", bool includeSubFolders = false)
        {
            Prefix = prefix;
            IncludeSubFolders = includeSubFolders;
        }

        /// <summary>
        /// A case-sensitive prefix string to filter documents in the source path for training. For example, when using an Azure storage container URI, use the prefix to restrict sub folders for training.
        /// </summary>
        public string Prefix { get; internal set; }

        /// <summary>
        /// A flag to indicate if subfolders within the set of prefix folders will also need to be included when searching for content to be preprocessed.
        /// </summary>
        public bool IncludeSubFolders { get; internal set; }
    }
}