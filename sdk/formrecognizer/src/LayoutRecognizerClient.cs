// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Prebuilt;
using Azure.AI.FormRecognizer.Prediction;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.AI.FormRecognizer
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
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ExtractLayoutResult ExtractLayout(Stream stream, FormContentType? contentType = null, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation operation = _formLayoutClient.StartAnalyze(stream, contentType, includeRawPageExtractions, cancellationToken);
            return new ExtractLayoutResult(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<ExtractLayoutResult> ExtractLayoutAsync(Stream stream, FormContentType? contentType = null, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formLayoutClient.StartAnalyzeAsync(stream, contentType, includeRawPageExtractions, cancellationToken).ConfigureAwait(false);
            return new ExtractLayoutResult(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ExtractLayoutResult ExtractLayout(Uri uri, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation operation = _formLayoutClient.StartAnalyze(uri, includeRawPageExtractions, cancellationToken);
            return new ExtractLayoutResult(operation);
        }
        /// <summary>
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<ExtractLayoutResult> ExtractLayoutAsync(Uri uri, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formLayoutClient.StartAnalyzeAsync(uri, includeRawPageExtractions, cancellationToken).ConfigureAwait(false);
            return new ExtractLayoutResult(op);
        }
    }
}
