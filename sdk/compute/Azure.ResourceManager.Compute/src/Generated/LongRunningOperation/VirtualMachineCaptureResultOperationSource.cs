// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    internal class VirtualMachineCaptureResultOperationSource : Core.IOperationSource<VirtualMachineCaptureResult>
    {
        VirtualMachineCaptureResult Core.IOperationSource<VirtualMachineCaptureResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return VirtualMachineCaptureResult.DeserializeVirtualMachineCaptureResult(document.RootElement);
        }

        async ValueTask<VirtualMachineCaptureResult> Core.IOperationSource<VirtualMachineCaptureResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return VirtualMachineCaptureResult.DeserializeVirtualMachineCaptureResult(document.RootElement);
        }
    }
}
