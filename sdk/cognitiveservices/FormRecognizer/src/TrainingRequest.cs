// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer
{
    /// <summary>
    /// Hello world
    /// </summary>
    public struct TrainingRequest
    {
        /// <summary>
        /// Source.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Source Filter.
        /// </summary>
        public SourceFilter SourceFilter { get; set; }

        /// <summary>
        /// Include Label file.
        /// </summary>
        public bool UseLabelFile { get; set; }
    }
}