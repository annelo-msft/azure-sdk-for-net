// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel.Primitives;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Core.Internal;

/// <summary>
/// Adapts an Azure message to an SCM message.  Enables flowing an Azure
/// message through an Azure pipeline that holds SCM policies.  This is because
/// an Azure pipeline flows an Azure message, and any reads or writes to the
/// Azure message that happen in an SCM policy need to happen via SCM APIs.
/// </summary>
internal class AzureToSystemResponseAdapter : PipelineResponse
{
    private readonly Response _azureResponse;

    public AzureToSystemResponseAdapter(Response response)
    {
        _azureResponse = response;
    }

    public override int Status => throw new NotImplementedException();

    public override string ReasonPhrase => throw new NotImplementedException();

    public override Stream? ContentStream { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override BinaryData Content => throw new NotImplementedException();

    protected override PipelineResponseHeaders HeadersCore => throw new NotImplementedException();

    public override BinaryData BufferContent(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public override ValueTask<BinaryData> BufferContentAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public override void Dispose()
    {
        throw new NotImplementedException();
    }

    public static AzureToSystemResponseAdapter FromAzureResponse(Response response)
    {
        return new AzureToSystemResponseAdapter(response);
    }
}
