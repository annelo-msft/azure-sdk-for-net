// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Azure.Core.Tests.Public
{
    public class JsonDataRoundTripTests
    {
        private const string _settingJson =
            @"{
                  ""etag"": ""4f6dd610dd5e4deebc7fbaef685fb903"",
                  ""key"": ""FontColor"",
                  ""label"": ""Canary"",
                  ""content_type"": null,
                  ""value"": ""Blue"",
                  ""last_modified"": ""2017-12-05T02:41:26+00:00"",
                  ""locked"": ""false"",
                  ""tags"": {
                    ""t1"": ""value1"",
                    ""t2"": ""value2""
                }
             }";

        [Test]
        public void MergePreservesValues()
        {
            // ***
            // Round-trip: JsonData and Anonymous types
            // ***
            //var resourceData = await client.GetKeyValueAsync("FontColor");
            //RequestContent updated = RequestContent.Merge(current, patch:
            //    new
            //    {
            //        value = "updated value"
            //    });
            //dynamic keyValue = new JsonData(current.Content);
            //Response putResponse = await client.PutKeyValueAsync((string)keyValue.key, updated, ContentType.ApplicationJson);

            // Arrange
            dynamic resource = new BinaryData(_settingJson).ToDynamic();

            // Act
            RequestContent updatedResource = RequestContent.Merge(resource, patch:
                new
                {
                    value = "Red"
                });

            // Assert
            dynamic updated = GetBinaryData(updatedResource).ToDynamic();

            Assert.AreNotEqual(resource.Value, updated.value);
            Assert.AreEqual("Red", updated.value);

            Assert.AreEqual(resource.Key, updated.key);
            Assert.AreEqual(resource.Label, updated.label);
            Assert.AreEqual(resource.Last_Modified, updated.last_modified);
        }

        // Note: These are better factored as RequestContext Merge tests.
        [Test]
        public void MergeDeletesValue()
        {
            // Arrange
            dynamic resource = new BinaryData(_settingJson).ToDynamic();

            // Act
            RequestContent updatedResource = RequestContent.Merge(resource, patch:
                new
                {
                    last_modified = (string)null
                });

            // Assert
            dynamic updated = GetBinaryData(updatedResource).ToDynamic();

            Assert.IsNull(updated.last_modified);

            Assert.AreEqual(resource.Value, updated.value);
            Assert.AreEqual(resource.Key, updated.key);
            Assert.AreEqual(resource.Label, updated.label);
        }

        [Test]
        public void MergeMergesObjects()
        {
            // Arrange
            dynamic resource = new BinaryData(_settingJson).ToDynamic();

            // Act
            RequestContent updatedResource = RequestContent.Merge(resource, patch:
                new
                {
                    tags = new
                    {
                        t2 = "updated2"
                    }
                });

            // Assert
            dynamic updated = GetBinaryData(updatedResource).ToDynamic();

            Assert.AreEqual(resource.Tags.T1, updated.tags.t1);
            Assert.AreNotEqual(resource.Tags.T2, updated.tags.t2);
            Assert.AreEqual("updated2", updated.tags.t2);

            Assert.AreEqual(resource.Value, updated.value);
            Assert.AreEqual(resource.Key, updated.key);
            Assert.AreEqual(resource.Label, updated.label);
        }

        #region Helpers
        private static BinaryData GetBinaryData(RequestContent content)
        {
            using MemoryStream stream = new();
            content.WriteTo(stream, CancellationToken.None);
            return new BinaryData(stream.GetBuffer());
        }
        #endregion
    }
}
