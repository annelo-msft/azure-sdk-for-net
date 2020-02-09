// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Prediction;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.AI.FormRecognizer.Prebuilt
{
    /// <summary>
    /// </summary>
    public class LayoutRecognizerClient
    {
        private FormLayoutClient _formLayoutClient;

        /// <summary>
        /// </summary>
        protected LayoutRecognizerClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient"/> class using a key-based credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Your assigned subscription key, copied from https://portal.azure.com/</param>
#pragma warning disable AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        public LayoutRecognizerClient(Uri endpoint, CognitiveKeyCredential credential)
#pragma warning restore AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
            : this(endpoint, credential, new FormRecognizerClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient"/> class using a subscription key credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Your assigned subscription key, copied from https://portal.azure.com/</param>
        /// <param name="options">Optional service parameters.</param>
#pragma warning disable AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        public LayoutRecognizerClient(Uri endpoint, CognitiveKeyCredential credential, FormRecognizerClientOptions options)
#pragma warning restore AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        {
            var temp = options.Version;
            _formLayoutClient = new FormLayoutClient(endpoint, credential, new FormLayoutClientOptions());
        }

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual LayoutExtractionResult ExtractLayout(Stream stream, FormContentType? contentType = null, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation operation = _formLayoutClient.StartAnalyze(stream, contentType, includeTextDetails, cancellationToken);
            return new LayoutExtractionResult(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<LayoutExtractionResult> ExtractLayoutAsync(Stream stream, FormContentType? contentType = null, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formLayoutClient.StartAnalyzeAsync(stream, contentType, includeTextDetails, cancellationToken).ConfigureAwait(false);
            return new LayoutExtractionResult(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual LayoutExtractionResult ExtractLayout(Uri uri, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation operation = _formLayoutClient.StartAnalyze(uri, includeTextDetails, cancellationToken);
            return new LayoutExtractionResult(operation);
        }
        /// <summary>
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<LayoutExtractionResult> ExtractLayoutAsync(Uri uri, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formLayoutClient.StartAnalyzeAsync(uri, includeTextDetails, cancellationToken).ConfigureAwait(false);
            return new LayoutExtractionResult(op);
        }
    }
}
