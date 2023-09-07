// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using NUnit.Framework;

namespace Azure.Core.Experimental.Tests
{
    public class VariantUsage
    {
        [Test]
        public void CanUseVariantAsString()
        {
            Variant variant = "hi";

            Assert.AreEqual("hi", (string)variant);

            Assert.IsTrue("hi" == (string)variant);
            Assert.IsTrue((string)variant == "hi");

            Assert.AreEqual("hi", $"{(string)variant}");
        }

        [Test]
        public void CanTestForNull()
        {
            Variant variant = Variant.Null;
            Assert.True(variant.IsNull);

            Assert.True(new Variant((object)null).IsNull);
        }

        [Test]
        public void CanCastNumerics()
        {
            Variant v = 3;

            Assert.AreEqual(typeof(int), v.Type);

            Assert.AreEqual(3L, v.As<long>());
            Assert.AreEqual(3L, (long)v);
        }

        [Test]
        public void NumericCastThrowsIfUnsupported()
        {
            Variant v = 3L;

            Assert.AreEqual(typeof(long), v.Type);

            Assert.Throws<InvalidCastException>(() => { int i = v.As<int>(); });
            Assert.Throws<InvalidCastException>(() => { int i = (int)v; });
        }
    }
}
