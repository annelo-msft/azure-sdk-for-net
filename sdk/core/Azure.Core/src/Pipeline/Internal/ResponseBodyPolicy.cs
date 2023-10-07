﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.ServiceModel.Rest.Core;
using System.ServiceModel.Rest.Core.Pipeline;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Core.Pipeline
{
    /// <summary>
    /// Pipeline policy to buffer response content or add a timeout to response content managed by the client
    /// </summary>
    internal class ResponseBodyPolicy : HttpPipelinePolicy
    {
        private readonly AzureCoreResponseBufferingPolicy _policy;

        public ResponseBodyPolicy(TimeSpan networkTimeout)
        {
            _policy = new AzureCoreResponseBufferingPolicy(networkTimeout);
        }

        public override async ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            AzureCorePipelineEnumerator executor = new AzureCorePipelineEnumerator(message, pipeline);

            try
            {
                // TODO: idea: if invocation options was an interface, message could just implement
                // it instead of using an adapter everywhere?  It would bake in the options, though.
                // TODO: Could we hide the options in the executor somehow?  How would that worok?
                HttpPipelineInvocationOptions options = new HttpPipelineInvocationOptions(message);
                await _policy.ProcessAsync(message, options, executor).ConfigureAwait(false);
            }
            catch (TaskCanceledException e)
            {
                // TODO: come back and clean this up.
                if (e.Message.Contains("The operation was cancelled because it exceeded the configured timeout"))
                {
                    string exceptionMessage = e.Message +
                        $"Network timeout can be adjusted in {nameof(ClientOptions)}.{nameof(ClientOptions.Retry)}.{nameof(RetryOptions.NetworkTimeout)}.";
#if NETCOREAPP2_1_OR_GREATER
                    throw new TaskCanceledException(exceptionMessage, e.InnerException, e.CancellationToken);
#else
                    throw new TaskCanceledException(exceptionMessage, e.InnerException);
#endif
                }
                else
                {
                    throw e;
                }
            }
        }

        public override void Process(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            AzureCorePipelineEnumerator executor = new AzureCorePipelineEnumerator(message, pipeline);

            try
            {
                HttpPipelineInvocationOptions options = new HttpPipelineInvocationOptions(message);
                _policy.Process(message, options, executor);
            }
            catch (TaskCanceledException e)
            {
                // TODO: come back and clean this up.
                if (e.Message.Contains("The operation was cancelled because it exceeded the configured timeout"))
                {
                    string exceptionMessage = e.Message +
                        $"Network timeout can be adjusted in {nameof(ClientOptions)}.{nameof(ClientOptions.Retry)}.{nameof(RetryOptions.NetworkTimeout)}.";
#if NETCOREAPP2_1_OR_GREATER
                    throw new TaskCanceledException(exceptionMessage, e.InnerException, e.CancellationToken);
#else
                    throw new TaskCanceledException(exceptionMessage, e.InnerException);
#endif
                }
                else
                {
                    throw e;
                }
            }
        }

        /// <summary>Throws a cancellation exception if cancellation has been requested via <paramref name="originalToken"/> or <paramref name="timeoutToken"/>.</summary>
        /// <param name="originalToken">The customer provided token.</param>
        /// <param name="timeoutToken">The linked token that is cancelled on timeout provided token.</param>
        /// <param name="inner">The inner exception to use.</param>
        /// <param name="timeout">The timeout used for the operation.</param>
#pragma warning disable CA1068 // Cancellation token has to be the last parameter
        internal static void ThrowIfCancellationRequestedOrTimeout(CancellationToken originalToken, CancellationToken timeoutToken, Exception? inner, TimeSpan timeout)
#pragma warning restore CA1068
        {
            CancellationHelper.ThrowIfCancellationRequested(originalToken);

            if (timeoutToken.IsCancellationRequested)
            {
                throw CancellationHelper.CreateOperationCanceledException(
                    inner,
                    timeoutToken,
                    $"The operation was cancelled because it exceeded the configured timeout of {timeout:g}. " +
                    $"Network timeout can be adjusted in {nameof(ClientOptions)}.{nameof(ClientOptions.Retry)}.{nameof(RetryOptions.NetworkTimeout)}.");
            }
        }
    }

#pragma warning disable SA1402 // File may only contain a single type
    internal class AzureCoreResponseBufferingPolicy : ResponseBufferingPolicy
#pragma warning restore SA1402 // File may only contain a single type
    {
        public AzureCoreResponseBufferingPolicy(TimeSpan networkTimeout)
            : base(networkTimeout, bufferResponse: true)
        {
        }

        protected override void SetReadTimeoutStream(PipelineMessage message, Stream responseContentStream, TimeSpan networkTimeout)
        {
            message.Response.ContentStream = new ReadTimeoutStream(responseContentStream, networkTimeout);
        }
    }
}
