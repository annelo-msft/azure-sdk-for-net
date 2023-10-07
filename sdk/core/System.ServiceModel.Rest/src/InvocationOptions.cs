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
public class InvocationOptions
{
    // Default is yes, buffer the response.
    private bool _bufferResponse = true;

    public ErrorBehavior ErrorBehavior { get; set; } = ErrorBehavior.Default;

    // Moving CancellationToken here because it's needed for Pipeline.Send
    public CancellationToken CancellationToken { get; set; } = DefaultCancellationToken;

    public static CancellationToken DefaultCancellationToken { get; set; } = CancellationToken.None;

    #region Transport options - TODO: move to a subtype type?

    // TODO: Can we throw if someone gives us Transport options and transport isn't
    // in the pipeline?

    // TODO: do these make more sense in Invocation or Pipeline?
    // Note: right now invocation is about things that have broader scope than
    // just the pipeline.Send operation, but pipeline.Send is part of the invocation.
    public virtual bool BufferResponse
    {
        get => _bufferResponse;
        set => _bufferResponse = value;
    }

    public virtual TimeSpan? NetworkTimeout { get; set; }

    #endregion
}
