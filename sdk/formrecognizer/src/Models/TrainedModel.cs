// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public readonly struct CustomModel
#pragma warning restore SA1649 // File name should match first type name
    {
        internal CustomModel(string modelId, RecognizableForm[] formClusters)
        {
            ModelId = modelId;
            RecognizableForms = formClusters;
        }

        /// <summary>
        /// Model Id.
        /// </summary>
        public string ModelId { get; }

        /// <summary>
        /// Keys extracted by the custom model.
        /// </summary>
        // TODO: Question - will this be populated for supervised models?
        // If not, we should probably break FRCustomModel into supervised and unsupervised custom models.s
        public IReadOnlyList<RecognizableForm> RecognizableForms { get; }


    }
}