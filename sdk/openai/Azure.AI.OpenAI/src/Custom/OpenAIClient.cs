// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.AI.OpenAI.Custom;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.Dynamic;

namespace Azure.AI.OpenAI
{
    // Data plane generated client.
    /// <summary> Azure OpenAI APIs for completions and search. </summary>
    public partial class OpenAIClient
    {
        /// <summary> Return the completion for a given prompt. </summary>
        /// <param name="deploymentId"> Deployment id (also known as model name) to use for operations </param>
        /// <param name="prompt"> Input string prompt to create a prompt completion from a deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Completions>> GetCompletionsAsync(string deploymentId, string prompt, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentId, nameof(deploymentId));
            Argument.AssertNotNullOrEmpty(prompt, nameof(prompt));

            CompletionsOptions completionsOptions = new CompletionsOptions();
            completionsOptions.Prompt.Add(prompt);
            return await GetCompletionsAsync(deploymentId, completionsOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Return the completions for a given prompt. </summary>
        /// <param name="deploymentId"> Deployment id (also known as model name) to use for operations </param>
        /// <param name="prompt"> Input string prompt to create a prompt completion from a deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Completions> GetCompletions(string deploymentId, string prompt, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentId, nameof(deploymentId));
            Argument.AssertNotNullOrEmpty(prompt, nameof(prompt));

            CompletionsOptions completionsOptions = new CompletionsOptions();
            completionsOptions.Prompt.Add(prompt);
            return GetCompletions(deploymentId, completionsOptions, cancellationToken);
        }

        public virtual Response<StreamingCompletions> GetStreamingCompletions(
            string deploymentId,
            CompletionsOptions completionsOptions,
            CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentId, nameof(deploymentId));
            Argument.AssertNotNull(completionsOptions, nameof(completionsOptions));

            using DiagnosticScope scope = ClientDiagnostics.CreateScope(
                "OpenAIClient.GetStreamingCompletions");
            scope.Start();

            RequestContext context = FromCancellationToken(cancellationToken);

            MemoryStream stream = new();
            Utf8JsonWriter writer = new(stream);
            writer.WriteObjectValue(completionsOptions);
            writer.Flush();
            stream.Position = 0;

            MutableJsonDocument options = MutableJsonDocument.Parse(BinaryData.FromStream(stream));
            options.RootElement.SetProperty("stream", true);

            try
            {
                HttpMessage message = CreateGetCompletionsRequest(deploymentId, RequestContent.Create(options), context);
                message.BufferResponse = false;
                Response baseResponse = _pipeline.ProcessMessage(message, context, cancellationToken);
                return Response.FromValue(new StreamingCompletions(baseResponse), baseResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        public virtual Task<Response<StreamingCompletions>> GetStreamingCompletionsAsync(
            string deploymentId,
            CompletionsOptions completionsOptions,
            CancellationToken cancellationToken = default)
        {
            return Task.FromResult<Response<StreamingCompletions>>(null);
        }
    }
}
