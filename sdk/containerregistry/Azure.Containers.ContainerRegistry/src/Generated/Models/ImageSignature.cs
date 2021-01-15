// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Containers.ContainerRegistry.Models
{
    /// <summary> Signature of a signed manifest. </summary>
    internal partial class ImageSignature
    {
        /// <summary> Initializes a new instance of ImageSignature. </summary>
        internal ImageSignature()
        {
        }

        /// <summary> A JSON web signature. </summary>
        public JWK Header { get; }
        /// <summary> A signature for the image manifest, signed by a libtrust private key. </summary>
        public string Signature { get; }
        /// <summary> The signed protected header. </summary>
        public string Protected { get; }
    }
}
