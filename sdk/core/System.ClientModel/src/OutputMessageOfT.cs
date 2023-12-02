// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.ComponentModel;

namespace System.ClientModel;

public abstract class OutputMessage<T> : OptionalOutputMessage<T>
{
    protected OutputMessage(T value, PipelineResponse response)
        : base(value, response) { }

    public override T Value => base.Value!;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool HasValue => true;
}
