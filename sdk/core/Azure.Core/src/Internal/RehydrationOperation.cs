﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using System.Threading.Tasks;
using Azure.Core.Pipeline;

namespace Azure.Core
{
    internal class RehydrationOperation : Operation
    {
        private readonly NextLinkOperationImplementation _nextLinkOperation;
        private readonly OperationInternal _operation;

        public RehydrationOperation(HttpPipeline pipeline, RehydrationToken rehydrationToken, ClientOptions? options = null)
        {
            Argument.AssertNotNull(pipeline, nameof(pipeline));
            Argument.AssertNotNull(rehydrationToken, nameof(rehydrationToken));
            _nextLinkOperation = (NextLinkOperationImplementation)NextLinkOperationImplementation.Create(pipeline, rehydrationToken);
            var operationState = _nextLinkOperation.UpdateStateAsync(false, default).EnsureCompleted();
            _operation = operationState.HasCompleted
                ? _operation = new OperationInternal(operationState)
                : new OperationInternal(_nextLinkOperation, new ClientDiagnostics(options ?? ClientOptions.Default), operationState.RawResponse);
        }

        public override string Id => _nextLinkOperation.OperationId;

        public override RehydrationToken? GetRehydrationToken() => _nextLinkOperation.GetRehydrationToken();

        public override bool HasCompleted => _operation.HasCompleted;

        public override Response GetRawResponse() => _operation.RawResponse;

        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);
    }
}
