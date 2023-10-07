﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;

namespace System.ServiceModel.Rest.Core.Pipeline;

public class MessagePipeline : Pipeline<PipelineMessage, InvocationOptions>
{
    private readonly ReadOnlyMemory<IPipelinePolicy<PipelineMessage>> _policies;
    private readonly PipelineTransport<PipelineMessage> _transport;

    public MessagePipeline(
        PipelineTransport<PipelineMessage> transport,
        ReadOnlyMemory<IPipelinePolicy<PipelineMessage>> policies)
    {
        _transport = transport;
        var larger = new IPipelinePolicy<PipelineMessage>[policies.Length + 1];
        policies.Span.CopyTo(larger);
        larger[policies.Length] = transport;
        _policies = larger;
    }

    private MessagePipeline(ReadOnlyMemory<IPipelinePolicy<PipelineMessage>> policies)
    {
        _transport = (PipelineTransport<PipelineMessage>)policies.Span[policies.Length - 1];
        _policies = policies;
    }

    public static MessagePipeline Create(
        PipelineOptions options,
        params IPipelinePolicy<PipelineMessage>[] perTryPolicies)
        => Create(options, perTryPolicies, ReadOnlySpan<IPipelinePolicy<PipelineMessage>>.Empty);

    public static MessagePipeline Create(
        PipelineOptions options,
        ReadOnlySpan<IPipelinePolicy<PipelineMessage>> perCallPolicies,
        ReadOnlySpan<IPipelinePolicy<PipelineMessage>> perTryPolicies)
    {
        int pipelineLength = perCallPolicies.Length + perTryPolicies.Length;

        if (options.PerTryPolicies != null)
        {
            pipelineLength += options.PerTryPolicies.Length;
        }

        if (options.PerCallPolicies != null)
        {
            pipelineLength += options.PerCallPolicies.Length;
        }

        pipelineLength += options.RetryPolicy is null ? 0 : 1;
        pipelineLength += options.LoggingPolicy is null ? 0 : 1;

        pipelineLength++; // for response buffering policy
        pipelineLength++; // for transport

        IPipelinePolicy<PipelineMessage>[] pipeline
            = new IPipelinePolicy<PipelineMessage>[pipelineLength];

        int index = 0;

        perCallPolicies.CopyTo(pipeline.AsSpan(index));
        index += perCallPolicies.Length;

        if (options.PerCallPolicies != null)
        {
            options.PerCallPolicies.CopyTo(pipeline.AsSpan());
            index += options.PerCallPolicies.Length;
        }

        if (options.RetryPolicy != null)
        {
            pipeline[index++] = options.RetryPolicy;
        }

        if (options.PerTryPolicies != null)
        {
            options.PerTryPolicies.CopyTo(pipeline.AsSpan(index));
            index += options.PerTryPolicies.Length;
        }

        perTryPolicies.CopyTo(pipeline.AsSpan(index));
        index += perTryPolicies.Length;

        if (options.LoggingPolicy != null)
        {
            pipeline[index++] = options.LoggingPolicy;
        }

        // TODO: add NetworkTimeout to RetryOptions
        // TODO: would it make sense for this to live on options instead?
        // TODO: stop hard-coding buffer response
        ResponseBufferingPolicy bufferingPolicy = new(TimeSpan.FromSeconds(100), true /*options.BufferResponse*/);
        pipeline[index++] = bufferingPolicy;

        if (options.Transport != null)
        {
            pipeline[index++] = options.Transport;
        }
        else
        {
            // Add default transport.
            // TODO: Note this adds an HTTP dependency we should be aware of.
            pipeline[index++] = HttpPipelineMessageTransport.Shared;
        }

        return new MessagePipeline(pipeline);
    }

    public override PipelineMessage CreateMessage(InvocationOptions options, ResponseErrorClassifier classifier)
    {
        return _transport.CreateMessage(options, classifier);
    }

    public override void Send(PipelineMessage message, InvocationOptions options)
    {
        IPipelineEnumerator enumerator = new MessagePipelineExecutor(message, options, _policies);
        enumerator.ProcessNext();

        message.Response.IsError = message.ResponseClassifier.IsErrorResponse(message);
    }

    public override async ValueTask SendAsync(PipelineMessage message, InvocationOptions options)
    {
        IPipelineEnumerator enumerator = new MessagePipelineExecutor(message, options, _policies);
        await enumerator.ProcessNextAsync().ConfigureAwait(false);

        message.Response.IsError = message.ResponseClassifier.IsErrorResponse(message);
    }

    internal struct MessagePipelineExecutor : IPipelineEnumerator
    {
        private PipelineMessage _message;
        private InvocationOptions _options;
        private ReadOnlyMemory<IPipelinePolicy<PipelineMessage>> _policies;

        public MessagePipelineExecutor(
            PipelineMessage message,
            InvocationOptions options,
            ReadOnlyMemory<IPipelinePolicy<PipelineMessage>> policies )
        {
            _message = message;
            _options = options;
            _policies = policies;
        }

        public int Length => _policies.Length;

        public bool ProcessNext()
        {
            var first = _policies.Span[0];
            _policies = _policies.Slice(1);
            first.Process(_message, this);
            return _policies.Length > 0;
        }

        public async ValueTask<bool> ProcessNextAsync()
        {
            var first = _policies.Span[0];
            _policies = _policies.Slice(1);
            await first.ProcessAsync(_message, this).ConfigureAwait(false);
            return _policies.Length > 0;
        }
    }
}
