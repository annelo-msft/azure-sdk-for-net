// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;

namespace Azure.Core.Internal;

/// <summary>
/// Adapts an Azure message to an SCM message.  Enables flowing an Azure
/// message through an Azure pipeline that holds SCM policies.  This is because
/// an Azure pipeline flows an Azure message, and any reads or writes to the
/// Azure message that happen in an SCM policy need to happen via SCM APIs.
/// </summary>
internal class AzureToSystemMessageAdapter : PipelineMessage
{
    private readonly HttpMessage _azureMessage;

    public AzureToSystemMessageAdapter(HttpMessage message)
        : base(AzureToSystemRequestAdapter.FromAzureRequest(message.Request))
    {
        _azureMessage = message;
    }

    public static AzureToSystemMessageAdapter FromAzureMessage(HttpMessage message)
    {
        return new AzureToSystemMessageAdapter(message);
    }
}
