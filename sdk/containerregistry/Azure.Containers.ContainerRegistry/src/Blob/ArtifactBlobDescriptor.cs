﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Specialized
{
    [CodeGenModel("Descriptor")]
    public partial class ArtifactBlobDescriptor
    {
        /// <summary> Layer media type. </summary>
        public string MediaType { get; set; }
        /// <summary> Layer size. </summary>
        public long? Size { get; set; }
        /// <summary> Layer digest. </summary>
        public string Digest { get; set; }

        /// <summary> Specifies a list of URIs from which this object may be downloaded. </summary>
        internal IList<Uri> Urls { get; }

        /// <summary> Additional information provided through arbitrary metadata. </summary>
        //internal Annotations Annotations { get; }

        internal static string ComputeDigest(Stream stream)
        {
            // TODO: cache and dispose SHA256?
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute and print the hash values for each file in directory.
                try
                {
                    var position = stream.Position;
                    stream.Position = 0;
                    var hashValue = sha256.ComputeHash(stream);
                    stream.Position = position;
                    return "sha256:" + PrintByteArray(hashValue);
                }
                catch (IOException e)
                {
                    Console.WriteLine($"I/O Exception: {e.Message}");
                    throw;
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine($"Access Exception: {e.Message}");
                    throw;
                }
            }
        }

        // Display the byte array in a readable format.
        private static string PrintByteArray(byte[] array)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
#pragma warning disable CA1305 // Specify IFormatProvider
                builder.AppendFormat($"{array[i]:X2}");
#pragma warning restore CA1305 // Specify IFormatProvider
                //if ((i % 4) == 3)
                //    builder.AppendFormat(" ");
            }
#pragma warning disable CA1304 // Specify CultureInfo
            return builder.ToString().ToLower();
#pragma warning restore CA1304 // Specify CultureInfo
        }
    }
}
