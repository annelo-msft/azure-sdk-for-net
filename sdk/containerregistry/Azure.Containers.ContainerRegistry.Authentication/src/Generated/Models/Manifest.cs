// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Containers.ContainerRegistry.Authentication
{
    /// <summary> Returns the requested manifest file. </summary>
    internal partial class Manifest
    {
        /// <summary> Initializes a new instance of Manifest. </summary>
        public Manifest()
        {
        }

        /// <summary> Initializes a new instance of Manifest. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        internal Manifest(int? schemaVersion)
        {
            SchemaVersion = schemaVersion;
        }

        /// <summary> Schema version. </summary>
        public int? SchemaVersion { get; set; }
    }
}
