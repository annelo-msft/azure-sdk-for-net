// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using Azure.Core.Json;
using NUnit.Framework;

namespace Azure.Core.Experimental.Tests
{
    public class MutableJsonDocumentChangeTrackerTests
    {
        [Test]
        [TestCaseSource(nameof(PathCases))]
        public void CanGetChange(string path)
        {
            MutableJsonDocument.ChangeTracker changes = new();
            changes.AddChange(path, true);

            Assert.IsTrue(changes.TryGetChange(path, -1, out MutableJsonChange change));
            Assert.AreEqual(change.Value, true);
        }

        [Test]
        [TestCaseSource(nameof(PathCases))]
        public void CanGetChangeFromUtf8Path(string path)
        {
            MutableJsonDocument.ChangeTracker changes = new();
            ReadOnlyMemory<byte> utf8Path = MutableJsonDocument.StringToUtf8(path);
            changes.AddChange(utf8Path, true);

            Assert.IsTrue(changes.TryGetChange(utf8Path.Span, -1, out MutableJsonChange change));
            Assert.AreEqual(change.Value, true);
        }

        [Test]
        [TestCaseSource(nameof(DescendantCases))]
        public void CanDetectDescendantChangeUtf8(string ancestor, string descendant, bool expected)
        {
            MutableJsonDocument.ChangeTracker changes = new();

            ReadOnlyMemory<byte> utf8Ancestor = MutableJsonDocument.StringToUtf8(ancestor);
            ReadOnlyMemory<byte> utf8Descendant = MutableJsonDocument.StringToUtf8(descendant);

            changes.AddChange(utf8Descendant, true);

            Assert.AreEqual(expected, changes.DescendantChanged(utf8Ancestor.Span, -1));
        }

        [Test]
        [TestCaseSource(nameof(DescendantCases))]
        public void CanDetectAncestorChangeUtf8(string ancestor, string descendant, bool expected)
        {
            MutableJsonDocument.ChangeTracker changes = new();

            ReadOnlyMemory<byte> utf8Ancestor = MutableJsonDocument.StringToUtf8(ancestor);
            ReadOnlyMemory<byte> utf8Descendant = MutableJsonDocument.StringToUtf8(descendant);

            changes.AddChange(utf8Ancestor, true);

            Assert.AreEqual(expected, changes.AncestorChanged(utf8Descendant.Span, -1));
        }

        [Test]
        public void CanAddChangeAsSpanAndReadAsString()
        {
            MutableJsonDocument.ChangeTracker changes = new();

            string path = "Foo";

            ReadOnlyMemory<byte> utf8Path = MutableJsonDocument.StringToUtf8(path);
            changes.AddChange(utf8Path, true);

            Assert.IsTrue(changes.TryGetChange(path, -1, out MutableJsonChange change));
            Assert.AreEqual(change.Value, true);
        }

        [Test]
        public void CanAddChangeAsStringAndReadAsSpan()
        {
            MutableJsonDocument.ChangeTracker changes = new();

            string path = "Foo";

            ReadOnlyMemory<byte> utf8Path = MutableJsonDocument.StringToUtf8(path);

            changes.AddChange(path, true);

            Assert.IsTrue(changes.TryGetChange(utf8Path.Span, -1, out MutableJsonChange change));
            Assert.AreEqual(change.Value, true);
        }

        [Test]
        public void CanPushIndexUtf8()
        {
            ReadOnlySpan<byte> path = MutableJsonDocument.StringToUtf8("Foo").Span;
            ReadOnlySpan<byte> path0 = MutableJsonDocument.ChangeTracker.PushIndex(path, 0).Span;
            ReadOnlySpan<byte> expected = MutableJsonDocument.StringToUtf8("Foo.0").Span;

            Assert.IsTrue(expected.SequenceEqual(path0));
        }

        [Test]
        public void CanPushIndexUtf8_NonAllocating()
        {
            int DefaultMaxPathLength = 128;
            Span<byte> pathBuffer = stackalloc byte[DefaultMaxPathLength];

            ReadOnlySpan<byte> foo = MutableJsonDocument.StringToUtf8("Foo").Span;
            ReadOnlySpan<byte> expected = MutableJsonDocument.StringToUtf8("Foo.0").Span;

            int pathLength = MutableJsonDocument.ChangeTracker.PushProperty(pathBuffer, 0, foo);
            pathLength = MutableJsonDocument.ChangeTracker.PushIndex(pathBuffer, pathLength, index: 0);

            ReadOnlySpan<byte> path = pathBuffer.Slice(0, pathLength);

            Assert.IsTrue(expected.SequenceEqual(path));
        }

        [Test]
        public void CanPushPropertyUtf8()
        {
            Span<byte> path = Span<byte>.Empty;

            ReadOnlySpan<byte> foo = MutableJsonDocument.StringToUtf8("Foo").Span;

            var pathFoo = MutableJsonDocument.ChangeTracker.PushProperty(path, foo).Span;

            ReadOnlySpan<byte> expected = MutableJsonDocument.StringToUtf8("Foo").Span;

            Assert.IsTrue(expected.SequenceEqual(pathFoo));
        }

        [Test]
        public void CanPushPropertyUtf8_NonAllocating()
        {
            int DefaultMaxPathLength = 128;
            Span<byte> pathBuffer = stackalloc byte[DefaultMaxPathLength];

            ReadOnlySpan<byte> foo = MutableJsonDocument.StringToUtf8("Foo").Span;

            int pathLength = MutableJsonDocument.ChangeTracker.PushProperty(pathBuffer, 0, foo);
            ReadOnlySpan<byte> path = pathBuffer.Slice(0, pathLength);

            ReadOnlySpan<byte> expected = MutableJsonDocument.StringToUtf8("Foo").Span;

            Assert.IsTrue(expected.SequenceEqual(path));
        }

        [Test]
        public void CanPopIndexUtf8()
        {
            ReadOnlySpan<byte> expected = MutableJsonDocument.StringToUtf8("Foo").Span;
            ReadOnlySpan<byte> path0 = MutableJsonDocument.StringToUtf8("Foo.0").Span;
            ReadOnlySpan<byte> path = MutableJsonDocument.ChangeTracker.PopIndex(path0);

            Assert.IsTrue(expected.SequenceEqual(path));
        }

        [Test]
        public void CanPopIndexUtf8_NonAllocating()
        {
            int DefaultMaxPathLength = 128;
            Span<byte> pathBuffer = stackalloc byte[DefaultMaxPathLength];

            ReadOnlySpan<byte> foo = MutableJsonDocument.StringToUtf8("Foo").Span;
            ReadOnlySpan<byte> foo0 = MutableJsonDocument.StringToUtf8("Foo.0").Span;

            int pathLength = MutableJsonDocument.ChangeTracker.PushProperty(pathBuffer, 0, foo);
            pathLength = MutableJsonDocument.ChangeTracker.PushIndex(pathBuffer, pathLength, index: 0);

            Assert.IsTrue(foo0.SequenceEqual(pathBuffer.Slice(0, pathLength)));

            pathLength = MutableJsonDocument.ChangeTracker.PopIndex(pathBuffer, pathLength);

            Assert.IsTrue(foo.SequenceEqual(pathBuffer.Slice(0, pathLength)));
        }

        public static IEnumerable<object[]> PathCases()
        {
            yield return new object[] { string.Empty };
            yield return new object[] { "path" };
            yield return new object[] { "0" };
            yield return new object[] { "path.0" };
            yield return new object[] { "root.child.child" };
            yield return new object[] { "root.child.0.child" };
        }

        public static IEnumerable<object[]> DescendantCases()
        {
            yield return new object[] { string.Empty, "path", true };
            yield return new object[] { "path", "path.0", true };
            yield return new object[] { "root.child", "root.child.child", true };
            yield return new object[] { "root", "root.child.child", true };
            yield return new object[] { "root", "root.child.0.child", true };
            yield return new object[] { "root.0", "root.0.child.0.child", true };
            yield return new object[] { "root.0", string.Empty, false };
        }
    }
}
