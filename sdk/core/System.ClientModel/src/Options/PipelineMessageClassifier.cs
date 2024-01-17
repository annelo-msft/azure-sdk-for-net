// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.ClientModel.Primitives;

public abstract class PipelineMessageClassifier
{
    internal static PipelineMessageClassifier Default { get; } = new DefaultMessageClassifier();

    public static PipelineMessageClassifier Create(ReadOnlySpan<ushort> successStatusCodes)
        => new ResponseStatusClassifier(successStatusCodes);

    protected internal PipelineMessageClassifier() { }

    /// <summary>
    /// Specifies if the response contained in the <paramref name="message"/> is not successful.
    /// </summary>
    public abstract bool IsErrorResponse(PipelineMessage message);

    private class DefaultMessageClassifier : PipelineMessageClassifier
    {
        public override bool IsErrorResponse(PipelineMessage message)
        {
            if (message.Response is null)
            {
                throw new InvalidOperationException("IsError must be called on a message where the OutputMessage is populated.");
            }

            int statusKind = message.Response.Status / 100;
            return statusKind == 4 || statusKind == 5;
        }
    }
}
