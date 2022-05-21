// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Examples.DataPlane.Tests
{
    public class DataPlaneClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("DataPlane_ENDPOINT");

        // Add other client paramters here as above.
    }
}
