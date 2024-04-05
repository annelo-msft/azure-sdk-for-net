// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading.Tasks;

namespace System.ClientModel.Primitives;

#pragma warning disable 1591 // public XML comments
public class ClientLoggingPolicy : PipelinePolicy
{
    // TODO: implement freezing so global static is not mutable
    public static ClientLoggingPolicy Default { get; } = new ClientLoggingPolicy();

    public IList<string> LoggedHeaderNames { get; set; }

    public ClientLoggingPolicy()
    {
        LoggedHeaderNames = new List<string>();
    }

    public override void Process(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
    {
        foreach (var name in LoggedHeaderNames)
        {
            Console.WriteLine(name);
        }

        ProcessNext(message, pipeline, currentIndex);
    }

    public override async ValueTask ProcessAsync(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
    {
        foreach (var name in LoggedHeaderNames)
        {
            Console.WriteLine(name);
        }

        await ProcessNextAsync(message, pipeline, currentIndex).ConfigureAwait(false);
    }
}
#pragma warning restore 1591 // public XML comments
