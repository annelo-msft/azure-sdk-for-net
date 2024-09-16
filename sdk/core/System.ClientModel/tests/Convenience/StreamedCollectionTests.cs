// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using ClientModel.Tests.Mocks;
using ClientModel.Tests.Paging;
using NUnit.Framework;

namespace System.ClientModel.Tests.Results;

/// <summary>
/// Scenario tests for sync and async page collections.
/// </summary>
public class StreamedCollectionTests
{
    // Tests:
    //  3. Convenience/Sync
    //    a. Can get values from response stream
    //    b. Response stream is disposed
    //  4. Convenience/Async
    //    a. Can get values from response stream
    //    b. Response stream is disposed
}
