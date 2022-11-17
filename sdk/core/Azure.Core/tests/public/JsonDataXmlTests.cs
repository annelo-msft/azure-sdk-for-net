// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Azure.Core.Tests.Public
{
    public class JsonDataXmlTests
    {
        private string _xmlReponse = "\"ResponseBody\": \"﻿<?xml version=\\\"1.0\\\" encoding=\\\"utf-8\\\"?><EnumerationResults ServiceEndpoint=\\\"https://seanmcccanary3.blob.core.windows.net/\\\" ContainerName=\\\"test-container-70039f49-545f-246e-f12f-d77359ad290a\\\"><Blobs><Blob><Name>test-blob-027e257e-78f0-ac5e-4a8b-e4743eb731b3</Name><VersionId>2021-02-17T18:42:32.4110539Z</VersionId><IsCurrentVersion>true</IsCurrentVersion><Properties><Creation-Time>Wed, 17 Feb 2021 18:42:32 GMT</Creation-Time><Last-Modified>Wed, 17 Feb 2021 18:42:32 GMT</Last-Modified><Etag>0x8D8D373C94114CB</Etag><Content-Length>0</Content-Length><Content-Type>application/octet-stream</Content-Type><Content-Encoding /><Content-Language /><Content-CRC64 /><Content-MD5 /><Cache-Control /><Content-Disposition /><BlobType>AppendBlob</BlobType><LeaseStatus>unlocked</LeaseStatus><LeaseState>available</LeaseState><ServerEncrypted>true</ServerEncrypted></Properties><OrMetadata /></Blob></Blobs><NextMarker /></EnumerationResults>\"";

        [Test]
        public void DynamicCanConvertToIEnumerableDynamic()
        {
            dynamic jsonData = new BinaryData("[1, null, \"s\"]").ToDynamic();
            int i = 0;
            foreach (var dynamicItem in jsonData)
            {
                switch (i)
                {
                    case 0:
                        Assert.AreEqual(1, (int)dynamicItem);
                        break;
                    case 1:
                        Assert.AreEqual(null, (string)dynamicItem);
                        break;
                    case 2:
                        Assert.AreEqual("s", (string)dynamicItem);
                        break;
                    default:
                        Assert.Fail();
                        break;
                }

                i++;
            }
            Assert.AreEqual(3, i);
        }
    }
}
