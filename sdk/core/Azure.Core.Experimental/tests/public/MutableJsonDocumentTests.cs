// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading;
using Azure.Core.Dynamic;
using NUnit.Framework;

namespace Azure.Core.Experimental.Tests.Public
{
    public class MutableJsonDocumentTests
    {
        [Test]
        public void CanCreateRequestContent()
        {
            string json = @"
                {
                  ""Foo"" : ""foo""
                }";

            MutableJsonDocument mdoc = MutableJsonDocument.Parse(json);

            mdoc.RootElement.SetProperty("Bar", "bar");

            RequestContent content = RequestContent.Create(mdoc);

            MemoryStream stream = new();
            content.WriteTo(stream, CancellationToken.None);
            stream.Flush();
            stream.Position = 0;

            string value = BinaryData.FromStream(stream).ToString();
            Assert.IsTrue(value.Contains(@"""Bar"":""bar"""));
        }
    }
}
