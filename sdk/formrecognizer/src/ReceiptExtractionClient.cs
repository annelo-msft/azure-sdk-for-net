﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Prediction;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.AI.FormRecognizer.Prebuilt
{
    /// <summary>
    /// </summary>
    public class ReceiptExtractionClient
    {
        private FormReceiptClient _formReceiptClient;

        /// <summary>
        /// </summary>
        protected ReceiptExtractionClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient"/> class using a key-based credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Your assigned subscription key, copied from https://portal.azure.com/</param>
#pragma warning disable AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        public ReceiptExtractionClient(Uri endpoint, CognitiveKeyCredential credential)
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
        public ReceiptExtractionClient(Uri endpoint, CognitiveKeyCredential credential, FormRecognizerClientOptions options)
#pragma warning restore AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        {
            var temp = options.Version;
            _formReceiptClient = new FormReceiptClient(endpoint, credential, new FormReceiptClientOptions());
        }

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ExtractReceiptResult ExtractReceipt(Stream stream, FormContentType? contentType = null, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation operation = _formReceiptClient.StartAnalyze(stream, contentType, includeTextDetails, cancellationToken);
            return new ExtractReceiptResult(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<ExtractReceiptResult> ExtractReceiptAsync(Stream stream, FormContentType? contentType = null, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formReceiptClient.StartAnalyzeAsync(stream, contentType, includeTextDetails, cancellationToken).ConfigureAwait(false);
            return new ExtractReceiptResult(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ExtractReceiptResult ExtractReceipt(Uri uri, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = _formReceiptClient.StartAnalyze(uri, includeTextDetails, cancellationToken);
            return new ExtractReceiptResult(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<ExtractReceiptResult> ExtractReceiptAsync(Uri uri, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formReceiptClient.StartAnalyzeAsync(uri, includeTextDetails, cancellationToken).ConfigureAwait(false);
            return new ExtractReceiptResult(op);
        }
    }
}
