// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Models
{
    /// <summary> Represents an item- or document-level indexing error. </summary>
    public partial class ItemError
    {
        /// <summary> Initializes a new instance of ItemError. </summary>
        internal ItemError()
        {
        }

        /// <summary> Initializes a new instance of ItemError. </summary>
        /// <param name="key"> The key of the item for which indexing failed. </param>
        /// <param name="errorMessage"> The message describing the error that occurred while processing the item. </param>
        /// <param name="statusCode"> The status code indicating why the indexing operation failed. Possible values include: 400 for a malformed input document, 404 for document not found, 409 for a version conflict, 422 when the index is temporarily unavailable, or 503 for when the service is too busy. </param>
        /// <param name="name"> The name of the source at which the error originated. For example, this could refer to a particular skill in the attached skillset. This may not be always available. </param>
        /// <param name="details"> Additional, verbose details about the error to assist in debugging the indexer. This may not be always available. </param>
        /// <param name="documentationLink"> A link to a troubleshooting guide for these classes of errors. This may not be always available. </param>
        internal ItemError(string key, string errorMessage, int statusCode, string name, string details, string documentationLink)
        {
            Key = key;
            ErrorMessage = errorMessage;
            StatusCode = statusCode;
            Name = name;
            Details = details;
            DocumentationLink = documentationLink;
        }

        /// <summary> The key of the item for which indexing failed. </summary>
        public string Key { get; internal set; }
        /// <summary> The message describing the error that occurred while processing the item. </summary>
        public string ErrorMessage { get; internal set; }
        /// <summary> The status code indicating why the indexing operation failed. Possible values include: 400 for a malformed input document, 404 for document not found, 409 for a version conflict, 422 when the index is temporarily unavailable, or 503 for when the service is too busy. </summary>
        public int StatusCode { get; internal set; }
        /// <summary> The name of the source at which the error originated. For example, this could refer to a particular skill in the attached skillset. This may not be always available. </summary>
        public string Name { get; internal set; }
        /// <summary> Additional, verbose details about the error to assist in debugging the indexer. This may not be always available. </summary>
        public string Details { get; internal set; }
        /// <summary> A link to a troubleshooting guide for these classes of errors. This may not be always available. </summary>
        public string DocumentationLink { get; internal set; }
    }
}
