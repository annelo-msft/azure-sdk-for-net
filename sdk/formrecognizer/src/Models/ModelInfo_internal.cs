// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.AI.FormRecognizer.Custom;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Model Info.
    /// </summary>
    internal class ModelInfo_internal
    {
        /// <summary>
        /// Model Id.
        /// </summary>
        public string ModelId { get; internal set; }

        /// <summary>
        /// Model status.
        /// </summary>
        public TrainingStatus Status { get; internal set; }

        /// <summary>
        /// Date and time when the model was created.
        /// </summary>
        public DateTimeOffset CreatedOn { get; internal set; }

        /// <summary>
        /// Date and time when the status was last updated.
        /// </summary>
        public DateTimeOffset LastUpdatedOn { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo_internal"/> class.
        /// </summary>
        protected ModelInfo_internal() { }

        internal static ModelInfo_internal Create() => new ModelInfo_internal();
    }
}