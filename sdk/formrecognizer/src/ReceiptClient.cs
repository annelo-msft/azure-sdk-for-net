// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Prediction;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.AI.FormRecognizer
{
    /// <summary>
    /// </summary>
    public class ReceiptClient
    {
        private FormReceiptClient _formReceiptClient;

        /// <summary>
        /// </summary>
        protected ReceiptClient()
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Your assigned subscription key, copied from https://portal.azure.com/</param>
#pragma warning disable AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        public ReceiptClient(Uri endpoint, CognitiveKeyCredential credential)
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
        public ReceiptClient(Uri endpoint, CognitiveKeyCredential credential, FormRecognizerClientOptions options)
#pragma warning restore AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        {
            var temp = options.Version;
            _formReceiptClient = new FormReceiptClient(endpoint, credential, new FormReceiptClientOptions());
        }

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response<ExtractedReceipt> ExtractReceipt(Stream stream, FormContentType? contentType = null, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //AnalyzeOperation operation = _formReceiptClient.StartAnalyze(stream, contentType, includeRawPageExtractions, cancellationToken);
            //return new ExtractReceiptResult(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<Response<ExtractedReceipt>> ExtractReceiptAsync(Stream stream, FormContentType? contentType = null, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();
            //AnalyzeOperation op = await _formReceiptClient.StartAnalyzeAsync(stream, contentType, includeRawPageExtractions, cancellationToken).ConfigureAwait(false);
            //return new ExtractReceiptResult(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response<ExtractedReceipt> ExtractReceipt(Uri uri, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //AnalyzeOperation op = _formReceiptClient.StartAnalyze(uri, includeRawPageExtractions, cancellationToken);
            //return new ExtractReceiptResult(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<Response<ExtractedReceipt>> ExtractReceiptAsync(Uri uri, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();
            //AnalyzeOperation op = await _formReceiptClient.StartAnalyzeAsync(uri, includeRawPageExtractions, cancellationToken).ConfigureAwait(false);
            //return new ExtractReceiptResult(op);
        }
    }
}
