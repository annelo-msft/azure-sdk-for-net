// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.Dynamic;
using NUnit.Framework;

namespace Azure.Core.Experimental.Tests
{
    internal class MutableJsonElementTests
    {
        [Test]
        public void CanWriteBooleanProperty()
        {
            string json = @"
                {
                  ""Foo"" :  true,
                  ""Bar"" :  false
                }";

            MutableJsonDocument mjd = MutableJsonDocument.Parse(json);

            string value = WriteTo(mjd.RootElement);
            Assert.AreEqual(MutableJsonWriteToTests.RemoveWhiteSpace(json), MutableJsonWriteToTests.RemoveWhiteSpace(value));

            string trueValue = WriteTo(mjd.RootElement.GetProperty("Foo"));
            Assert.AreEqual(MutableJsonWriteToTests.RemoveWhiteSpace("true"), MutableJsonWriteToTests.RemoveWhiteSpace(trueValue));

            string falseValue = WriteTo(mjd.RootElement.GetProperty("Bar"));
            Assert.AreEqual(MutableJsonWriteToTests.RemoveWhiteSpace("false"), MutableJsonWriteToTests.RemoveWhiteSpace(falseValue));
        }

        internal static string WriteTo(MutableJsonElement element)
        {
            using MemoryStream stream = new();
            element.WriteTo(stream);
            stream.Position = 0;
            return BinaryData.FromStream(stream).ToString();
        }
    }
}
