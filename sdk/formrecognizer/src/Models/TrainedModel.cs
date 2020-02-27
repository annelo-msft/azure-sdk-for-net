// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public readonly struct TrainedModel
    {
        internal TrainedModel(string modelId, TrainedFormCluster[] formClusters)
        {
            ModelId = modelId;
            FormClusters = formClusters;
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
        public TrainedFormCluster[] FormClusters { get; }
    }
}