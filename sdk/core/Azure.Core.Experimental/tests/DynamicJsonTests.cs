// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.Dynamic;
using NUnit.Framework;

namespace Azure.Core.Experimental.Tests
{
    public class DynamicJsonTests
    {
        [Test]
        public void CanGetIntProperty()
        {
            dynamic jsonData = GetDynamicJson(@"
                {
                  ""Foo"" : 1
                }");

            int value = jsonData.Foo;

            Assert.AreEqual(1, value);
        }

        [Test]
        public void CanGetNestedIntProperty()
        {
            dynamic jsonData = GetDynamicJson(@"
                {
                  ""Foo"" : {
                    ""Bar"" : 1
                  }
                }");

            int value = jsonData.Foo.Bar;

            Assert.AreEqual(1, value);
        }

        [Test]
        public void CanSetIntProperty()
        {
            dynamic jsonData = GetDynamicJson(@"
                {
                  ""Foo"" : 1
                }");

            jsonData.Foo = 2;

            Assert.AreEqual(2, (int)jsonData.Foo);
        }

        [Test]
        public void CanSetNestedIntProperty()
        {
            dynamic jsonData = GetDynamicJson(@"
                {
                  ""Foo"" : {
                    ""Bar"" : 1
                  }
                }");

            jsonData.Foo.Bar = 2;

            Assert.AreEqual(2, (int)jsonData.Foo.Bar);
        }

        // TODO: Add tests for property get and set for supported types.
        // Do this with fewer tests via NUnit features.

        #region Helpers
        internal static dynamic GetDynamicJson(string json)
        {
            return new BinaryData(json).ToDynamic();
        }
        #endregion
    }
}
