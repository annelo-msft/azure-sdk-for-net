// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Prediction;
using Azure.AI.FormRecognizer.Custom;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.AI.FormRecognizer
{
    /// <summary>
    /// </summary>
    public class CustomRecognizerClient
    {
        private FormRecognizerClient_internal _formRecognizerClient;

        /// <summary>
        /// </summary>
        protected CustomRecognizerClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient_internal"/> class using a key-based credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Your assigned subscription key, copied from https://portal.azure.com/</param>
#pragma warning disable AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        public CustomRecognizerClient(Uri endpoint, CognitiveKeyCredential credential)
#pragma warning restore AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
            : this(endpoint, credential, new FormRecognizerClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient_internal"/> class using a subscription key credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Your assigned subscription key, copied from https://portal.azure.com/</param>
        /// <param name="options">Optional service parameters.</param>
#pragma warning disable AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        public CustomRecognizerClient(Uri endpoint, CognitiveKeyCredential credential, FormRecognizerClientOptions options)
#pragma warning restore AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        {
            var temp = options.Version;
            _formRecognizerClient = new FormRecognizerClient_internal(endpoint, credential, options);
        }

        #region Training

        /// <summary>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken"></param>
        public virtual TrainingOperation StartTraining(string source, TrainingFileFilter filter, CancellationToken cancellationToken = default)
        {
            var operation = _formRecognizerClient.StartTraining(new TrainingRequest()
            {
                Source = source,
                SourceFilter = filter,
            });

            return new TrainingOperation(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken"></param>
        public virtual async Task<TrainingOperation> StartTrainingAsync(string source, TrainingFileFilter filter, CancellationToken cancellationToken = default)
        {
            var operation = await _formRecognizerClient.StartTrainingAsync(new TrainingRequest()
            {
                Source = source,
                SourceFilter = filter,
            }, cancellationToken).ConfigureAwait(false);

            return new TrainingOperation(operation);
        }

        // TODO: Would it be good to provide an overload that lets you pass labels programmatically?  Probably not worth the cost -
        // wait for customers to ask.
        // TODO: Rename "source" param to something more descriptive?
        /// <summary>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken"></param>
        public virtual TrainingWithLabelsOperation StartTrainingWithLabels(string source, TrainingFileFilter filter, CancellationToken cancellationToken = default)
        {
            var operation = _formRecognizerClient.StartTraining(new TrainingRequest()
            {
                Source = source,
                SourceFilter = filter,
                UseLabelFile = true
            });

            return new TrainingWithLabelsOperation(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken"></param>
        public virtual async Task<TrainingWithLabelsOperation> StartTrainingWithLabelsAsync(string source, TrainingFileFilter filter, CancellationToken cancellationToken = default)
        {
            var operation = await _formRecognizerClient.StartTrainingAsync(new TrainingRequest()
            {
                Source = source,
                SourceFilter = filter,
            }, cancellationToken).ConfigureAwait(false);

            return new TrainingWithLabelsOperation(operation);
        }

        #endregion Training

        #region Get model info methods
        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Pageable<ModelTrainingInfo> GetModelsTrainingInfo(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual AsyncPageable<ModelTrainingInfo> GetModelsTrainingInfoAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response<ModelCollectionInfo> GetModelCollectionInfo(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<Response<ModelCollectionInfo>> GetModelCollectionInfoAsync(CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response DeleteModel(string modelId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<Response> DeleteModelAsync(string modelId, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();
        }
        #endregion Get model info methods

        #region Prediction

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ExtractPredefinedFieldFormResult ExtractPredefinedFieldForm(string modelId, Stream stream, FormContentType? contentType = null, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = _formRecognizerClient.GetModelReference(modelId).StartAnalyze(stream, contentType, includeRawPageExtractions, cancellationToken);
            return new ExtractPredefinedFieldFormResult(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<ExtractPredefinedFieldFormResult> ExtractPredefinedFieldFormAsync(string modelId, Stream stream, FormContentType? contentType = null, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formRecognizerClient.GetModelReference(modelId).StartAnalyzeAsync(stream, contentType, includeRawPageExtractions, cancellationToken).ConfigureAwait(false);
            return new ExtractPredefinedFieldFormResult(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ExtractPredefinedFieldFormResult ExtractPredefinedFieldForm(string modelId, Uri uri, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = _formRecognizerClient.GetModelReference(modelId).StartAnalyze(uri, includeRawPageExtractions, cancellationToken);
            return new ExtractPredefinedFieldFormResult(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<ExtractPredefinedFieldFormResult> ExtractPredefinedFieldFormAsync(string modelId, Uri uri, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation operation = await _formRecognizerClient.GetModelReference(modelId).StartAnalyzeAsync(uri, includeRawPageExtractions, cancellationToken).ConfigureAwait(false);
            return new ExtractPredefinedFieldFormResult(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ExtractFormResult ExtractForm(string modelId, Stream stream, FormContentType? contentType = null, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation operation = _formRecognizerClient.GetModelReference(modelId).StartAnalyze(stream, contentType, includeRawPageExtractions, cancellationToken);
            return new ExtractFormResult(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<ExtractFormResult> ExtractFormAsync(string modelId, Stream stream, FormContentType? contentType = null, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formRecognizerClient.GetModelReference(modelId).StartAnalyzeAsync(stream, contentType, includeRawPageExtractions, cancellationToken).ConfigureAwait(false);
            return new ExtractFormResult(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ExtractFormResult ExtractForm(string modelId, Uri uri, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = _formRecognizerClient.GetModelReference(modelId).StartAnalyze(uri, includeRawPageExtractions, cancellationToken);
            return new ExtractFormResult(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<ExtractFormResult> ExtractFormAsync(string modelId, Uri uri, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            AnalyzeOperation op = await _formRecognizerClient.GetModelReference(modelId).StartAnalyzeAsync(uri, includeRawPageExtractions, cancellationToken).ConfigureAwait(false);
            return new ExtractFormResult(op);
        }
        #endregion Prediction
    }
}
