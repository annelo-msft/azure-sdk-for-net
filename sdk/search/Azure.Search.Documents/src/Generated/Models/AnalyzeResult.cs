// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Documents.Models
{
    /// <summary> The result of testing an analyzer on text. </summary>
    public partial class AnalyzeResult
    {
        /// <summary> Initializes a new instance of AnalyzeResult. </summary>
        internal AnalyzeResult()
        {
        }

        /// <summary> Initializes a new instance of AnalyzeResult. </summary>
        /// <param name="tokens"> The list of tokens returned by the analyzer specified in the request. </param>
        internal AnalyzeResult(IList<TokenInfo> tokens)
        {
            Tokens = tokens;
        }

        /// <summary> The list of tokens returned by the analyzer specified in the request. </summary>
        public IList<TokenInfo> Tokens { get; internal set; } = new List<TokenInfo>();
    }
}
