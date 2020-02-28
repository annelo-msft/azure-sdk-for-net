// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Prediction;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary>
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public class CustomFormClient
#pragma warning restore SA1649 // File name should match first type name
    {
        private FormRecognizerClient_internal _formRecognizerClient;

        /// <summary>
        /// </summary>
        protected CustomFormClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient_internal"/> class using a key-based credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Your assigned subscription key, copied from https://portal.azure.com/</param>
#pragma warning disable AZC0007 // DO provide a minimal constructor that takes only the parameters required to connect to the service.
        public CustomFormClient(Uri endpoint, CognitiveKeyCredential credential)
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
        public CustomFormClient(Uri endpoint, CognitiveKeyCredential credential, FormRecognizerClientOptions options)
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
        public virtual LabeledTrainingOperation StartLabeledTraining(string source, TrainingFileFilter filter, CancellationToken cancellationToken = default)
        {
            var operation = _formRecognizerClient.StartTraining(new TrainingRequest()
            {
                Source = source,
                SourceFilter = filter,
                UseLabelFile = true
            });

            return new LabeledTrainingOperation(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken"></param>
        public virtual async Task<LabeledTrainingOperation> StartLabeledTrainingAsync(string source, TrainingFileFilter filter, CancellationToken cancellationToken = default)
        {
            var operation = await _formRecognizerClient.StartTrainingAsync(new TrainingRequest()
            {
                Source = source,
                SourceFilter = filter,
            }, cancellationToken).ConfigureAwait(false);

            return new LabeledTrainingOperation(operation);
        }

        #endregion Training

        #region Get model info methods
        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Pageable<ModelTrainingStatus> GetModelsTrainingStatus(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual AsyncPageable<ModelTrainingStatus> GetModelsTrainingStatusAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response<ModelsSummary> GetModelsSummary(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<Response<ModelsSummary>> GetModelsSummaryAsync(CancellationToken cancellationToken = default)
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
        public virtual Response<ExtractedLabeledForm> ExtractLabeledForm(string modelId, Stream stream, FormContentType? contentType = null, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //AnalyzeOperation op = _formRecognizerClient.GetModelReference(modelId).StartAnalyze(stream, contentType, includeRawPageExtractions, cancellationToken);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<Response<ExtractedLabeledForm>> ExtractLabeledFormAsync(string modelId, Stream stream, FormContentType? contentType = null, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();

            //AnalyzeOperation op = await _formRecognizerClient.GetModelReference(modelId).StartAnalyzeAsync(stream, contentType, includeRawPageExtractions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response<ExtractedLabeledForm> ExtractLabeledForm(string modelId, Uri uri, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //AnalyzeOperation op = _formRecognizerClient.GetModelReference(modelId).StartAnalyze(uri, includeRawPageExtractions, cancellationToken);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<Response<ExtractedLabeledForm>> ExtractLabeledFormAsync(string modelId, Uri uri, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();

            //AnalyzeOperation operation = await _formRecognizerClient.GetModelReference(modelId).StartAnalyzeAsync(uri, includeRawPageExtractions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response<ExtractedForm> ExtractForm(string modelId, Stream stream, FormContentType? contentType = null, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //AnalyzeOperation operation = _formRecognizerClient.GetModelReference(modelId).StartAnalyze(stream, contentType, includeRawPageExtractions, cancellationToken);
            //return new ExtractResult(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<Response<ExtractedForm>> ExtractFormAsync(string modelId, Stream stream, FormContentType? contentType = null, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();

            //AnalyzeOperation op = await _formRecognizerClient.GetModelReference(modelId).StartAnalyzeAsync(stream, contentType, includeRawPageExtractions, cancellationToken).ConfigureAwait(false);
            //return new ExtractResult(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response<ExtractedForm> ExtractForm(string modelId, Uri uri, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //AnalyzeOperation op = _formRecognizerClient.GetModelReference(modelId).StartAnalyze(uri, includeRawPageExtractions, cancellationToken);
            //return new ExtractResult(op);
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="includeRawPageExtractions"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<Response<ExtractedForm>> ExtractFormAsync(string modelId, Uri uri, bool includeRawPageExtractions = false, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();

            //AnalyzeOperation op = await _formRecognizerClient.GetModelReference(modelId).StartAnalyzeAsync(uri, includeRawPageExtractions, cancellationToken).ConfigureAwait(false);
            //return new ExtractResult(op);
        }
        #endregion Prediction
    }
}
