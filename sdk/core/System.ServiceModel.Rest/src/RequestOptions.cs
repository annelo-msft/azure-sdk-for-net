// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;

namespace System.ServiceModel.Rest;

/// <summary>
/// Controls the end-to-end duration of the service method call, including
/// the message being sent down the pipeline.
/// </summary>
// TODO: Make options freezable
// TODO: This was RequestOptions, I'm changing it for now, we can change it back if
// if we want.
public class InvocationOptions : PipelineOptions
{
    public CancellationToken CancellationToken { get; set; } = DefaultCancellationToken;

    public ErrorBehavior ErrorBehavior { get; set; } = ErrorBehavior.Default;

    public static CancellationToken DefaultCancellationToken { get; set; } = CancellationToken.None;
}
