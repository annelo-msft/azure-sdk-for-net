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
    public OperationImplementation(string id, Response response, bool hasCompleted)
    {
        Id = id;
        Response = response;
        HasCompleted = hasCompleted;
    }

    // TODO: implement update with lock for these properties

    public string Id { get; protected set; }

    public Response Response { get; protected set; }

    public bool HasCompleted { get; protected set; }


}
#pragma warning restore CS1591 // public XML comments
