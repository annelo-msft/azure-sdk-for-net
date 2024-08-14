// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core.Pipeline;

namespace Azure.Core.Operations;

#pragma warning disable CS1591 // public XML comments
public abstract class OperationImplementation
{
    private readonly ClientDiagnostics _diagnostics;
    private readonly IReadOnlyDictionary<string, string>? _scopeAttributes;
    private readonly DelayStrategy? _fallbackStrategy;
    private readonly AsyncLockWithValue<Response> _responseLock;

    private readonly string _waitForCompletionResponseScopeName;

    protected string UpdateStatusScopeName { get; }
    protected string WaitForCompletionScopeName { get; }

    public virtual Response GetRawResponse()
    {
        throw new NotImplementedException();
    }

    public bool HasCompleted { get; protected set; }


}
#pragma warning restore CS1591 // public XML comments
