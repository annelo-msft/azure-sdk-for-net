// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.AI.FormRecognizer.Http;
using Azure.AI.FormRecognizer.Prediction;
using Azure.Core;

namespace Azure.AI.FormRecognizer
{
    /// <summary>
    /// The form layout client extracts text and layout information from a given document.
    /// </summary>
    internal class FormLayoutClient_internal : AnalyzeClient
    {
        private const string BaseLayoutPath = "/layout";

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="FormLayoutClient_internal"/> class using a key-based credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Your assigned subscription key, copied from https://portal.azure.com/</param>
        public FormLayoutClient_internal(Uri endpoint, CognitiveKeyCredential credential)
            : this(endpoint, credential, new FormLayoutClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormLayoutClient_internal"/> class using a subscription key credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Your assigned subscription key, copied from https://portal.azure.com/</param>
        /// <param name="options">Optional service parameters.</param>
        public FormLayoutClient_internal(Uri endpoint, CognitiveKeyCredential credential, FormLayoutClientOptions options)
            : this(endpoint, new FormAuthenticator(credential), options)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormLayoutClient_internal"/> class using an Azure Active Directory credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Azure Active Directory credential.</param>
        public FormLayoutClient_internal(Uri endpoint, TokenCredential credential)
            : this(endpoint, credential, new FormLayoutClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormLayoutClient_internal"/> class using an Azure Active Directory credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Azure Active Directory credential.</param>
        /// <param name="options">Optional service parameters.</param>
        public FormLayoutClient_internal(Uri endpoint, TokenCredential credential, FormLayoutClientOptions options)
            : this(endpoint, new FormAuthenticator(credential), options)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormLayoutClient_internal"/> class using a user-defined credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">User-defined credential.</param>
        public FormLayoutClient_internal(Uri endpoint, CognitiveHeaderCredential credential)
            : this(endpoint, credential, new FormLayoutClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormLayoutClient_internal"/> class using a user-defined credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">User-defined credential</param>
        /// <param name="options">Optional service parameters.</param>
        public FormLayoutClient_internal(Uri endpoint, CognitiveHeaderCredential credential, FormLayoutClientOptions options)
            : this(endpoint, new FormAuthenticator(credential), options)
        {
        }

        internal FormLayoutClient_internal(Uri endpoint, FormAuthenticator authenticator, FormLayoutClientOptions options)
            : base(FormHttpPipelineBuilder.Build(endpoint, authenticator, options), options.SerializationOptions, BaseLayoutPath)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormLayoutClient_internal"/> class for mocking.
        /// </summary>
        protected FormLayoutClient_internal()
        { }

        #endregion
    }

    /// <summary>
    /// Options for analyzing layout.
    /// </summary>
    internal struct AnalyzeLayoutOptions
    { }
}