// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Models;
using System;
using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// A set of predefined fields extracted from a form by a supervised learning model.
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public readonly struct ExtractedLabeledForm
#pragma warning restore SA1649 // File name should match first type name
    {
        internal ExtractedLabeledForm(string formType, PageRange pageRange, ExtractedLabeledPage[] pages)
        {
            FormType = formType;
            PageRange = pageRange;
            Pages = pages;
        }


        // TODO: Possible values include, receipt, layout, user-specified?
        /// <summary>
        /// Document type.
        /// </summary>
        public string FormType { get;  }

        /// <summary>
        /// First and last page number where the form is found within the input file.
        /// </summary>
        public PageRange PageRange { get;  }

        /// <summary>
        /// </summary>
        public IReadOnlyList<ExtractedLabeledPage> Pages { get; }

        internal static ExtractedLabeledForm Create() => new ExtractedLabeledForm();
    }
}