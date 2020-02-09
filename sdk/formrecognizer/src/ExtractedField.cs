// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary>
    /// </summary>
    public class ExtractedField
    {
        // TODO: What is the value of label if this is only in unsupervised learning?
        // Or is this used for supervised learning as well?

        internal ExtractedField() { }

        // TODO: Label doesn't make sense on a field from an unsupervised model. Hint?
        /// <summary>
        /// A user defined label for the key/value pair entry.
        /// </summary>
        internal string Label { get; set; }

        /// <summary>
        /// </summary>
        public ExtractedText Name { get; internal set; }

        /// <summary>
        /// </summary>
        public ExtractedText Value { get; internal set; }

        // TODO: Should Confidence go on BoundedText?  Should it be ExtractedText?
        /// <summary>
        /// Confidence value.
        /// </summary>
        public float Confidence { get; internal set; }
    }
}