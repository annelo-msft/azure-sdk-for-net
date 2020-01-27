// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Core;
using Azure.AI.FormRecognizer.Http;
using Azure.AI.FormRecognizer.Models;
using Azure.Core.Pipeline;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.AI.FormRecognizer
{
    /// <summary>
    /// The FormRecognizer client provides syncronous and asynchronous methods to manage custom forms,
    /// prebuilt models, and layout requests.
    /// </summary>
    public class FormRecognizerClient
    {
        private readonly CustomFormClient _customFormClient; // CustomFormClient + CustomFormModelClient
        private readonly PrebuiltFormClient _prebuiltFormClient; // ReceiptClient
        private readonly FormLayoutClient _layoutClient;
        private readonly FormHttpPolicy _authentication;
        private readonly CognitiveCredential _credential;

        /// <summary>
        /// Get the Cognitive Credential for this client.
        /// </summary>
        public virtual CognitiveCredential Credential => _credential;

        ///// <summary>
        ///// Access custom form models.
        ///// </summary>
        //public virtual CustomFormClient Custom => _customFormClient;

        ///// <summary>
        ///// Access the prebuilt models.
        ///// </summary>
        //public virtual PrebuiltFormClient Prebuilt => _prebuiltFormClient;

        ///// <summary>
        ///// Access form layout models.
        ///// </summary>
        //public virtual FormLayoutClient Layout => _layoutClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient"/> class for mocking.
        /// </summary>
        protected FormRecognizerClient()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient"/> class.
        /// </summary>
        /// <param name="endpoint">
        /// The assigned endpoint for your subscriptionKey. E.g. for `eastus`:
        ///
        /// ```csharp
        /// var endpoint = CognitiveEndpoint.EastUnitedStates;
        /// ```
        /// </param>
        /// <param name="subscriptionKey">Your assigned subscription key, copied from https://portal.azure.com/</param>
        public FormRecognizerClient(CognitiveEndpoint endpoint, string subscriptionKey)
            : this(new CognitiveCredential(endpoint, subscriptionKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient"/> class.
        /// </summary>
        /// <param name="endpoint">
        /// The assigned endpoint for your subscriptionKey. E.g. for `eastus`:
        ///
        /// ```csharp
        /// var endpoint = CognitiveEndpoint.EastUnitedStates;
        /// ```
        /// </param>
        /// <param name="subscriptionKey">Your assigned subscription key, copied from https://portal.azure.com/</param>
        /// <param name="options">Optional service parameters.</param>
        public FormRecognizerClient(CognitiveEndpoint endpoint, string subscriptionKey, FormRecognizerClientOptions options)
            : this(new CognitiveCredential(endpoint, subscriptionKey), options)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient"/> class.
        /// </summary>
        /// <param name="credential">A Cognitive Services credential object.</param>
        public FormRecognizerClient(CognitiveCredential credential)
        : this(credential, new FormRecognizerClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognizerClient"/> class with options.
        /// </summary>
        /// <param name="credential">A Cognitive Services credential object.</param>
        /// <param name="options">Optional service parameters.</param>
        public FormRecognizerClient(CognitiveCredential credential, FormRecognizerClientOptions options)
        {
            Throw.IfMissing(credential, nameof(credential));
            Throw.IfMissing(options, nameof(options));
            _credential = credential;
            _authentication = new FormHttpPolicy(credential, options.Version);
            var pipeline = HttpPipelineBuilder.Build(options, _authentication);

            _customFormClient = new CustomFormClient(pipeline, options);
            _prebuiltFormClient = new PrebuiltFormClient(pipeline, options);
            _layoutClient = new FormLayoutClient(pipeline, options);
        }

        #region Custom Form Client / Custom Form Model Client
        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual CustomFormPredictionOperation StartCustomFormPrediction(string modelId, Stream stream, FormContentType? contentType = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual CustomFormPredictionOperation StartCustomFormPrediction(string modelId, Uri uri, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="operationId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual CustomFormPredictionOperation StartCustomFormPrediction(string modelId, string operationId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<CustomFormPredictionOperation> StartCustomFormPredictionAsync(string modelId, Stream stream, FormContentType? contentType = null, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<CustomFormPredictionOperation> StartCustomFormPredictionAsync(string modelId, Uri uri, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously create and train a custom model.
        ///
        /// This method returns a <see cref="TrainingOperation" /> that can be used to track the status of the training
        /// operation, including waiting for its completion.
        ///
        /// ```csharp
        /// var op = await client.StartTrainAsync(new TrainingRequest { Source = "https://example.org/" });
        /// var requestId = op.Id;
        /// var model = await op.WaitForCompletionAsync();
        /// ```
        /// </summary>
        /// <param name="trainRequest">
        /// The request must include a `Source` parameter that is either an externally accessible Azure storage
        /// blob container Uri (preferably using a Shared Access Signature) or a valid path to a data folder in a locally
        /// mounted drive (local folders are only supported when accessing an endpoint that is a self-hosted container).
        ///
        /// All training data must be under the source folder or subfolders under it. Models are trained using documents
        /// matching any of the following file extensions:
        ///
        /// - `.pdf`
        /// - `.jpg` / `.jpeg`
        /// - `.png`
        /// - `.tiff` / `.tif`
        ///
        /// Any other files are ignored.
        /// </param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        public async virtual Task<TrainCustomModelOperation> StartTrainingCustomModelAsync(TrainingRequest trainRequest, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create and train a custom model.
        ///
        /// This method returns a <see cref="TrainingOperation" /> that can be used to track the status of the training
        /// operation, including waiting for its completion.
        ///
        /// ```csharp
        /// // Wait for completion is only available as an `async` method.
        /// var op = client.TrainAsync(new TrainingRequest { Source = "https://example.org/" });
        /// var requestId = op.Id;
        /// while (!op.HasCompleted)
        /// {
        ///     op.UpdateStatus()
        ///     Thread.Sleep(1000);
        /// }
        /// if (op.HasValue)
        /// {
        ///     var model = op.Value
        /// }
        /// ```
        /// </summary>
        /// <param name="trainRequest">
        /// The request must include a `Source` parameter that is either an externally accessible Azure storage
        /// blob container Uri (preferably using a Shared Access Signature) or a valid path to a data folder in a locally
        /// mounted drive (local folders are only supported when accessing an endpoint that is a self-hosted container).
        ///
        /// All training data must be under the source folder or subfolders under it. Models are trained using documents
        /// matching any of the following file extensions:
        ///
        /// - `.pdf`
        /// - `.jpg` / `.jpeg`
        /// - `.png`
        /// - `.tiff` / `.tif`
        ///
        /// Any other files are ignored.
        /// </param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        public virtual TrainCustomModelOperation StartTrainingCustomModel(TrainingRequest trainRequest, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a <see cref="TrainingOperation" /> status reference to an existhing training request.
        /// </summary>
        /// <param name="operationId">The operation id from a previous training request.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        public virtual TrainCustomModelOperation StartTrainingCustomModel(string operationId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously get information about all custom models.
        ///
        /// This method returns a <see cref="CustomModelsAsyncPageable" /> that can be used to asynchronously enumerate
        /// all models or list them page-by-page.
        ///
        /// ```csharp
        /// // Enumerate all models (may make multiple service calls):
        /// await foreach (var modelInfo in client.Custom.ListModelsAsync())
        /// {
        ///     Console.WriteLine(modelInfo.ModelId);
        /// }
        ///
        /// // Enumerate pages (may make multiple service calls):
        /// var pages = client.Custom.ListModelsAsync().AsPages();
        ///
        /// // Get individual pages (one service call per operation)
        /// var page1 = client.Custom.ListModelsAsync().GetPageAsync();
        /// var page2 = client.Custom.ListModelsAsync().GetPageAsync(page1.ContinuationToken);
        /// ```
        /// </summary>
        public virtual CustomModelsAsyncPageable GetTrainedCustomModelsAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get information about all custom models.
        ///
        /// This method returns a <see cref="ModelsPageable" /> that can be used to snchronously enumerate
        /// all models or list them page-by-page.
        ///
        /// ```csharp
        /// // Enumerate all models (may make multiple service calls):
        /// foreach (var modelInfo in client.Custom.ListModels())
        /// {
        ///     Console.WriteLine(modelInfo.ModelId);
        /// }
        ///
        /// // Enumerate pages (may make multiple service calls):
        /// var pages = client.Custom.ListModels().AsPages();
        ///
        /// // Get individual pages (one service call per operation)
        /// var page1 = client.Custom.ListModels().GetPage();
        /// var page2 = client.Custom.ListModels().GetPage(page1.ContinuationToken);
        /// ```
        /// </summary>
        public virtual ModelsPageable GetTrainedCustomModels(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously get summary of all models.
        /// </summary>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        public async virtual Task<Response<ModelsSummary>> GetSummaryAsync(CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get summary of all models.
        /// </summary>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        public virtual Response<ModelsSummary> GetSummary(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        #endregion Custom Form Client / Custom Form Model Client

        #region Prebuilt Form Client / Receipt Client
        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ReceiptPredictionOperation StartReceiptPrediction(string modelId, Stream stream, FormContentType? contentType = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ReceiptPredictionOperation StartReceiptPrediction(string modelId, Uri uri, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="operationId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual ReceiptPredictionOperation StartReceiptPrediction(string modelId, string operationId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<ReceiptPredictionOperation> StartReceiptPredictionAsync(string modelId, Stream stream, FormContentType? contentType = null, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<ReceiptPredictionOperation> StartReceiptPredictionAsync(string modelId, Uri uri, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        #endregion Prebuilt Form Client / Receipt Client

        #region Form Layout Client
        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual LayoutPredictionOperation StartLayoutPrediction(string modelId, Stream stream, FormContentType? contentType = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual LayoutPredictionOperation StartLayoutPrediction(string modelId, Uri uri, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="operationId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual LayoutPredictionOperation StartLayoutPrediction(string modelId, string operationId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="stream"></param>
        /// <param name="contentType"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<LayoutPredictionOperation> StartLayoutPredictionAsync(string modelId, Stream stream, FormContentType? contentType = null, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="uri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<LayoutPredictionOperation> StartLayoutPredictionAsync(string modelId, Uri uri, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => { }).ConfigureAwait(false);
            throw new NotImplementedException();
        }

        #endregion Form Layout Client
    }
}
