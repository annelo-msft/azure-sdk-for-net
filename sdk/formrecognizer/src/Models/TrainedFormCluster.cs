// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public readonly struct RecognizableForm
#pragma warning restore SA1649 // File name should match first type name
    {
        internal RecognizableForm(int formClusterId, IReadOnlyCollection<string> fieldNames)
        {
            RecognizableFormId = formClusterId;
            FieldNames = fieldNames;
        }

        /// <summary>
        /// Cluster Id
        /// </summary>
        public int RecognizableFormId { get; }

        /// <summary>
        /// Names of the fields extracted from forms in this cluster.
        /// </summary>
        public IReadOnlyCollection<string> FieldNames { get; }
    }
}
