﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.AI.FormRecognizer.Prediction
{
    /// <summary>
    /// </summary>
    internal class FormRecognizerAnalysisClient
    {
        private FormRecognizerClient_internal _formRecognizerClient;
        private FormReceiptClient _formReceiptClient;
        private FormLayoutClient_internal _formLayoutClient;

        /// <summary>
        /// </summary>
        protected FormRecognizerAnalysisClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient_internal"/> class using a key-based credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Your assigned subscription key, copied from https://portal.azure.com/</param>
        public FormRecognizerAnalysisClient(Uri endpoint, CognitiveKeyCredential credential)
            : this(endpoint, credential, new FormRecognizerAnalysisClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient_internal"/> class using a subscription key credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Your assigned subscription key, copied from https://portal.azure.com/</param>
        /// <param name="options">Optional service parameters.</param>
        public FormRecognizerAnalysisClient(Uri endpoint, CognitiveKeyCredential credential, FormRecognizerAnalysisClientOptions options)
        {
            var temp = options.Version;
            _formRecognizerClient = new FormRecognizerClient_internal(endpoint, credential, new FormRecognizerClientOptions());
            _formReceiptClient = new FormReceiptClient(endpoint, credential);
            _formLayoutClient = new FormLayoutClient_internal(endpoint, credential);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual CustomSupervisedAnalysisOperation StartCustomSupervisedAnalysis(string modelId, Stream stream, FormContentType? contentType = null, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = _formRecognizerClient.GetModelReference(modelId).StartAnalyze(stream, contentType, includeTextDetails, cancellationToken);
            return new CustomSupervisedAnalysisOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<CustomSupervisedAnalysisOperation> StartCustomSupervisedAnalysisAsync(string modelId, Stream stream, FormContentType? contentType = null, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formRecognizerClient.GetModelReference(modelId).StartAnalyzeAsync(stream, contentType, includeTextDetails, cancellationToken).ConfigureAwait(false);
            return new CustomSupervisedAnalysisOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual CustomSupervisedAnalysisOperation StartCustomSupervisedAnalysis(string modelId, Uri uri, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = _formRecognizerClient.GetModelReference(modelId).StartAnalyze(uri, includeTextDetails, cancellationToken);
            return new CustomSupervisedAnalysisOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<CustomSupervisedAnalysisOperation> StartCustomSupervisedAnalysisAsync(string modelId, Uri uri, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formRecognizerClient.GetModelReference(modelId).StartAnalyzeAsync(uri, includeTextDetails, cancellationToken).ConfigureAwait(false);
            return new CustomSupervisedAnalysisOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual CustomSupervisedAnalysisOperation StartCustomSupervisedAnalysis(string operationId, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = _formRecognizerClient.GetModelReference("").StartAnalyze(operationId, cancellationToken);
            return new CustomSupervisedAnalysisOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual CustomUnsupervisedAnalysisOperation StartCustomUnsupervisedAnalysis(string modelId, Stream stream, FormContentType? contentType = null, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = _formRecognizerClient.GetModelReference(modelId).StartAnalyze(stream, contentType, includeTextDetails, cancellationToken);
            return new CustomUnsupervisedAnalysisOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<CustomUnsupervisedAnalysisOperation> StartCustomUnsupervisedAnalysisAsync(string modelId, Stream stream, FormContentType? contentType = null, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formRecognizerClient.GetModelReference(modelId).StartAnalyzeAsync(stream, contentType, includeTextDetails, cancellationToken).ConfigureAwait(false);
            return new CustomUnsupervisedAnalysisOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual CustomUnsupervisedAnalysisOperation StartCustomUnsupervisedAnalysis(string modelId, Uri uri, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = _formRecognizerClient.GetModelReference(modelId).StartAnalyze(uri, includeTextDetails, cancellationToken);
            return new CustomUnsupervisedAnalysisOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<CustomUnsupervisedAnalysisOperation> StartCustomUnsupervisedAnalysisAsync(string modelId, Uri uri, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formRecognizerClient.GetModelReference(modelId).StartAnalyzeAsync(uri, includeTextDetails, cancellationToken).ConfigureAwait(false);
            return new CustomUnsupervisedAnalysisOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual CustomUnsupervisedAnalysisOperation StartCustomUnsupervisedAnalysis(string operationId, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = _formRecognizerClient.GetModelReference("").StartAnalyze(operationId, cancellationToken);
            return new CustomUnsupervisedAnalysisOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ReceiptAnalysisOperation StartReceiptAnalysis(Stream stream, FormContentType? contentType = null, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = _formReceiptClient.StartAnalyze(stream, contentType, includeTextDetails, cancellationToken);
            return new ReceiptAnalysisOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ReceiptAnalysisOperation StartReceiptAnalysis(Uri uri, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = _formReceiptClient.StartAnalyze(uri, includeTextDetails, cancellationToken);
            return new ReceiptAnalysisOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ReceiptAnalysisOperation StartReceiptAnalysis(string operationId, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = _formReceiptClient.StartAnalyze(operationId, cancellationToken);
            return new ReceiptAnalysisOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<ReceiptAnalysisOperation> StartReceiptAnalysisAsync(Stream stream, FormContentType? contentType = null, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formReceiptClient.StartAnalyzeAsync(stream, contentType, includeTextDetails, cancellationToken).ConfigureAwait(false);
            return new ReceiptAnalysisOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<ReceiptAnalysisOperation> StartReceiptAnalysisAsync(Uri uri, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formReceiptClient.StartAnalyzeAsync(uri, includeTextDetails, cancellationToken).ConfigureAwait(false);
            return new ReceiptAnalysisOperation(op);
        }


        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual LayoutExtractionOperation StartLayoutExtraction(Stream stream, FormContentType? contentType = null, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation operation = _formLayoutClient.StartAnalyze(stream, contentType, includeTextDetails, cancellationToken);
            return new LayoutExtractionOperation(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual LayoutExtractionOperation StartLayoutExtraction(Uri uri, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation operation = _formLayoutClient.StartAnalyze(uri, includeTextDetails, cancellationToken);
            return new LayoutExtractionOperation(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual LayoutExtractionOperation StartLayoutExtraction(string operationId, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation operation = _formLayoutClient.StartAnalyze(operationId, cancellationToken);
            return new LayoutExtractionOperation(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<LayoutExtractionOperation> StartLayoutExtractionAsync(Stream stream, FormContentType? contentType = null, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formReceiptClient.StartAnalyzeAsync(stream, contentType, includeTextDetails, cancellationToken).ConfigureAwait(false);
            return new LayoutExtractionOperation(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="includeTextDetails"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<LayoutExtractionOperation> StartLayoutExtractionAsync(Uri uri, bool includeTextDetails = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formReceiptClient.StartAnalyzeAsync(uri, includeTextDetails, cancellationToken).ConfigureAwait(false);
            return new LayoutExtractionOperation(op);
        }

    }
}
