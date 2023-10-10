// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.ServiceModel.Rest.Core;

public abstract class PipelineRequest
{
    public abstract void SetMethod(string method);
    public abstract bool TryGetMethod(out string method);

    public abstract void SetUri(Uri uri);
    public abstract bool TryGetUri(out Uri uri);

    // TODO: Can we change this to BinaryData?
    public abstract RequestBody? Content { get; set; }

    public abstract MessageHeaders Headers { get; }
}