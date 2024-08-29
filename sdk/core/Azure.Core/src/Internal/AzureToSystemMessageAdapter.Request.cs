// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel;
using System.ClientModel.Primitives;

namespace Azure.Core.Internal;

/// <summary>
/// Adapts an Azure message to an SCM message.  Enables flowing an Azure
/// message through an Azure pipeline that holds SCM policies.  This is because
/// an Azure pipeline flows an Azure message, and any reads or writes to the
/// Azure message that happen in an SCM policy need to happen via SCM APIs.
/// </summary>
internal class AzureToSystemRequestAdapter : PipelineRequest
{
    private readonly Request _azureRequest;

    public AzureToSystemRequestAdapter(Request request)
    {
        _azureRequest = request;
    }

    protected override string MethodCore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    protected override Uri? UriCore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    protected override PipelineRequestHeaders HeadersCore => throw new NotImplementedException();

    protected override BinaryContent? ContentCore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void Dispose()
    {
        throw new NotImplementedException();
    }

    public static AzureToSystemRequestAdapter FromAzureRequest(Request request)
    {
        return new AzureToSystemRequestAdapter(request);
    }
}
