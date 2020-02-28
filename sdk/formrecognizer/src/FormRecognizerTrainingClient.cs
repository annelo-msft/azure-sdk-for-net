// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;
using Azure.AI.FormRecognizer.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.AI.FormRecognizer
{
    /// <summary>
    /// </summary>
    internal class FormRecognizerTrainingClient
    {
        private FormRecognizerClient_internal _formRecognizerClient;

        /// <summary>
        /// </summary>
        protected FormRecognizerTrainingClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient_internal"/> class using a key-based credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Your assigned subscription key, copied from https://portal.azure.com/</param>
        public FormRecognizerTrainingClient(Uri endpoint, CognitiveKeyCredential credential)
            : this(endpoint, credential, new FormRecognizerTrainingClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient_internal"/> class using a subscription key credential.
        /// </summary>
        /// <param name="endpoint">Endpoint.</param>
        /// <param name="credential">Your assigned subscription key, copied from https://portal.azure.com/</param>
        /// <param name="options">Optional service parameters.</param>
        public FormRecognizerTrainingClient(Uri endpoint, CognitiveKeyCredential credential, FormRecognizerTrainingClientOptions options)
        {
            var temp = options.Version;
            _formRecognizerClient = new FormRecognizerClient_internal(endpoint, credential, new FormRecognizerClientOptions());
        }

        /// <summary>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken"></param>
        public virtual TrainingOperation StartTrainingUnsupervisedModel(string source, TrainingFileFilter filter, CancellationToken cancellationToken = default)
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
        public virtual async Task<TrainingOperation> StartTrainingUnsupervisedModelAsync(string source, TrainingFileFilter filter, CancellationToken cancellationToken = default)
        {
            var operation = await _formRecognizerClient.StartTrainingAsync(new TrainingRequest()
            {
                Source = source,
                SourceFilter = filter,
            }, cancellationToken).ConfigureAwait(false);

            return new TrainingOperation(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual TrainingOperation StartTrainingUnsupervisedModel(string operationId, CancellationToken cancellationToken = default)
        {
            var operation = _formRecognizerClient.StartTraining(operationId, cancellationToken);
            return new TrainingOperation(operation);
        }

        // TODO: Would it be good to provide an overload that lets you pass labels programmatically?  Probably not worth the cost -
        // wait for customers to ask.
        // TODO: Rename "source" param to something more descriptive?
        /// <summary>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="filter"></param>
        /// <param name="labelFile"></param>
        /// <param name="cancellationToken"></param>
        public virtual LabeledTrainingOperation StartTrainingSupervisedModel(string source, TrainingFileFilter filter, string labelFile, CancellationToken cancellationToken = default)
        {
            var operation = _formRecognizerClient.StartTraining(new TrainingRequest()
            {
                Source = source,
                SourceFilter = filter,
                UseLabelFile = (labelFile != null) // TODO pass through.
            });

            return new LabeledTrainingOperation(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="filter"></param>
        /// <param name="labelFile"></param>
        /// <param name="cancellationToken"></param>
        public virtual async Task<LabeledTrainingOperation> StartTrainingSupervisedModelAsync(string source, TrainingFileFilter filter, string labelFile, CancellationToken cancellationToken = default)
        {
            var operation = await _formRecognizerClient.StartTrainingAsync(new TrainingRequest()
            {
                Source = source,
                SourceFilter = filter,
                UseLabelFile = (labelFile != null) // TODO pass through.
            }, cancellationToken).ConfigureAwait(false);

            return new LabeledTrainingOperation(operation);
        }

        /// <summary>
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual LabeledTrainingOperation StartTrainingSupervisedModel(string operationId, CancellationToken cancellationToken = default)
        {
            var operation = _formRecognizerClient.StartTraining(operationId, cancellationToken);
            return new LabeledTrainingOperation(operation);
        }
    }
}
