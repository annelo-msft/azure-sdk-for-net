// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Custom
{
    // TODO: How is this different from OperationStatus?
    /// <summary>
    /// Model status.
    /// </summary>
#pragma warning disable CA1717 // plural enum
    public enum TrainingStatus
#pragma warning restore CA1717 // plural enum
    {
        /// <summary>Training.</summary>
        Training = 1,

        /// <summary>Ready.</summary>
        Ready = 2,

        /// <summary>Invalid.</summary>
        Invalid = 3,
    }
}