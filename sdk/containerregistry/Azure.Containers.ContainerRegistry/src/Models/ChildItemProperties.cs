// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Containers.ContainerRegistry
{
    public class ChildItemProperties
    {
        public ChildItemProperties (string digest, string cpuArchitecture, string operatingSystem)
        {
            Digest = digest;
            CpuArchitecture = cpuArchitecture;
            OperatingSystem = operatingSystem;
        }

        public string Digest { get; }
        
        public string CpuArchitecture { get; }

        public string OperatingSystem { get; }
    }
}
