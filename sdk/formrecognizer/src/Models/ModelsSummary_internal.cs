// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Models summary
    /// </summary>
    internal class ModelsSummary_internal
    {
        /// <summary>
        /// Count.
        /// </summary>
        public int Count { get; internal set; }

        /// <summary>
        /// Limit.
        /// </summary>
        public int Limit { get; internal set; }

        /// <summary>
        /// Last updated date.
        /// </summary>
        public DateTimeOffset LastUpdatedOn { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsSummary_internal"/> class.
        /// </summary>
        protected ModelsSummary_internal()
        { }

        internal static ModelsSummary_internal Create() => new ModelsSummary_internal();
    }
}