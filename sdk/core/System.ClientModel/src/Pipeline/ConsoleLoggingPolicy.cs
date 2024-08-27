// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading.Tasks;

namespace System.ClientModel.Primitives;

// Simple proof of concept policy for testing Azure.Core 2.0 scenarios.

#pragma warning disable CS1591 // public XML comments
public class ConsoleLoggingPolicy : PipelinePolicy
{
    public override void Process(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
    {
        Console.WriteLine(message.Request.Method);

        ProcessNext(message, pipeline, currentIndex);

        Console.WriteLine(message.Response!.Status);
    }

    public override async ValueTask ProcessAsync(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
    {
        Console.WriteLine(message.Request.Method);

        await ProcessNextAsync(message, pipeline, currentIndex).ConfigureAwait(false);

        Console.WriteLine(message.Response!.Status);
    }
}
#pragma warning restore CS1591 // public XML comments
