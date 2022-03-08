// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Test.LoadTest.Tests
{
    public class LoadTestClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("LoadTest_ENDPOINT");

        // Add other client paramters here as above.
    }
}
