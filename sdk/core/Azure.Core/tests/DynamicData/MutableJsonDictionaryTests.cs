// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Core.Json;
using NUnit.Framework;

namespace Azure.Core.Tests
{
    internal class MutableJsonDictionaryTests
    {
        [Test]
        public void DictionaryContainsKey()
        {
            string json = """
                {
                  "a": "aa",
                  "b": "bb"
                }
                """;

            MutableJsonElement element = MutableJsonDocument.Parse(json).RootElement;
            IDictionary<string, string> dict = new MutableJsonDictionary<string>(element);

            Assert.IsTrue(dict.Contains(new KeyValuePair<string, string>("a", "aa")));
            Assert.IsFalse(dict.Contains(new KeyValuePair<string, string>("a", "cc")));

            Assert.IsTrue(dict.Contains(new KeyValuePair<string, string>("b", "bb")));
            Assert.IsFalse(dict.Contains(new KeyValuePair<string, string>("b", "cc")));
        }

        [Test]
        public void CanAddValue()
        {
            string json = """
                {
                  "a": "aa"
                }
                """;

            MutableJsonElement element = MutableJsonDocument.Parse(json).RootElement;
            IDictionary<string, string> dict = new MutableJsonDictionary<string>(element);

            Assert.Throws<ArgumentException>(() => dict.Add("a", "new"));

            dict.Add("b", "bb");

            Assert.IsTrue(dict.Contains(new KeyValuePair<string, string>("a", "aa")));
            Assert.IsTrue(dict.Contains(new KeyValuePair<string, string>("b", "bb")));
        }

        [Test]
        public void CanClear()
        {
            string json = """
                {
                  "a": "aa",
                  "b": "bb"
                }
                """;

            MutableJsonElement element = MutableJsonDocument.Parse(json).RootElement;
            IDictionary<string, string> dict = new MutableJsonDictionary<string>(element);

            Assert.AreEqual(dict.Count, 2);

            dict.Clear();

            Assert.AreEqual(dict.Count, 0);

            Assert.IsFalse(dict.TryGetValue("a", out _));
            Assert.IsFalse(dict.TryGetValue("b", out _));
        }

        [Test]
        public void CanCopyTo()
        {
            string json = """
                {
                  "a": "aa",
                  "b": "bb"
                }
                """;

            MutableJsonElement element = MutableJsonDocument.Parse(json).RootElement;
            IDictionary<string, string> dict = new MutableJsonDictionary<string>(element);

            KeyValuePair<string, string>[] array = new KeyValuePair<string, string>[dict.Count];
            dict.CopyTo(array, 0);

            int i = 0;
            foreach (KeyValuePair<string, string> pair in dict)
            {
                Assert.AreEqual(pair.Key, array[i].Key);
                Assert.AreEqual(pair.Value, array[i++].Value);
            }

            Assert.AreEqual(2, i);
        }

        [Test]
        public void CanCopyToOffset()
        {
            Dictionary<string, string> bclDict = new();
            bclDict["0"] = "aa";
            bclDict["1"] = "bb";
            bclDict["2"] = "cc";
            bclDict["3"] = "dd";

            KeyValuePair<string, string>[] expected = new KeyValuePair<string, string>[6];
            ICollection<KeyValuePair<string, string>> collection = bclDict;
            collection.CopyTo(expected, 2);

            string json = """
                {
                  "0": "aa",
                  "1": "bb",
                  "2": "cc",
                  "3": "dd"
                }
                """;

            MutableJsonElement element = MutableJsonDocument.Parse(json).RootElement;
            IDictionary<string, string> dict = new MutableJsonDictionary<string>(element);

            KeyValuePair<string, string>[] array = new KeyValuePair<string, string>[6];
            dict.CopyTo(array, 2);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i].Key, array[i].Key);
                Assert.AreEqual(expected[i].Value, array[i++].Value);
            }
        }

        [Test]
        public void CanGetCount()
        {
            string json = """
                {
                  "a": "aa",
                  "b": "bb"
                }
                """;

            MutableJsonElement element = MutableJsonDocument.Parse(json).RootElement;
            IDictionary<string, string> dict = new MutableJsonDictionary<string>(element);

            Assert.AreEqual(2, dict.Count);

            dict.Add("c", "cc");

            Assert.AreEqual(3, dict.Count);
        }

        [Test]
        public void CanGetViaIndexer()
        {
            string json = """
                {
                  "a": "aa",
                  "b": "bb"
                }
                """;

            MutableJsonElement element = MutableJsonDocument.Parse(json).RootElement;
            MutableJsonDictionary<string> dict = new(element);

            Assert.AreEqual("aa", dict["a"]);
            Assert.AreEqual("bb", dict["b"]);
        }

        [Test]
        public void CanSetViaIndexer()
        {
            string json = """
                {
                  "a": "aa",
                  "b": "bb"
                }
                """;

            MutableJsonElement element = MutableJsonDocument.Parse(json).RootElement;
            MutableJsonDictionary<string> dict = new(element);

            dict["a"] = "a2";
            dict["b"] = "b2";

            Assert.AreEqual("a2", dict["a"]);
            Assert.AreEqual("b2", dict["b"]);
        }

        [Test]
        public void CanEnumerate()
        {
            string json = """
                {
                  "a": 1,
                  "b": 2
                }
                """;

            MutableJsonElement element = MutableJsonDocument.Parse(json).RootElement;
            MutableJsonDictionary<int> dict = new(element);

            int i = 1;
            foreach (KeyValuePair<string, int> pair in dict)
            {
                Assert.AreEqual(pair.Value, i++);
            }

            Assert.AreEqual(3, i);
        }

        [Test]
        public void CanRemove()
        {
            string json = """
                {
                  "a": "aa",
                  "b": "bb"
                }
                """;

            MutableJsonElement element = MutableJsonDocument.Parse(json).RootElement;
            IDictionary<string, string> dict = new MutableJsonDictionary<string>(element);

            Assert.AreEqual(2, dict.Count);

            dict.Remove("a");

            Assert.AreEqual(1, dict.Count);

            Assert.Throws<KeyNotFoundException>(() => { string _ = dict["a"]; });
            Assert.AreEqual("bb", dict["b"]);
        }

        [Test]
        public void CanTryGetValue()
        {
            string json = """
                {
                  "a": 1,
                  "b": 2
                }
                """;

            MutableJsonElement element = MutableJsonDocument.Parse(json).RootElement;
            MutableJsonDictionary<int> dict = new(element);

            Assert.IsTrue(dict.TryGetValue("a", out int a));
            Assert.AreEqual(1, a);

            Assert.IsTrue(dict.TryGetValue("b", out int b));
            Assert.AreEqual(2, b);

            Assert.IsFalse(dict.TryGetValue("c", out int _));
        }

        #region Helpers

        #endregion
    }
}
