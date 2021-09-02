// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Signature of a signed manifest. </summary>
    internal partial class ImageSignature
    {
        /// <summary> Initializes a new instance of ImageSignature. </summary>
        public ImageSignature()
        {
        }

        /// <summary> Initializes a new instance of ImageSignature. </summary>
        /// <param name="header"> A JSON web signature. </param>
        /// <param name="signature"> A signature for the image manifest, signed by a libtrust private key. </param>
        /// <param name="protected"> The signed protected header. </param>
        internal ImageSignature(JWK header, string signature, string @protected)
        {
            Header = header;
            Signature = signature;
            Protected = @protected;
        }

        /// <summary> A JSON web signature. </summary>
        public JWK Header { get; set; }
        /// <summary> A signature for the image manifest, signed by a libtrust private key. </summary>
        public string Signature { get; set; }
        /// <summary> The signed protected header. </summary>
        public string Protected { get; set; }
    }
}
