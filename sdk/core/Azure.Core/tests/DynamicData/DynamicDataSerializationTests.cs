// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Text.Json;
using Azure.Core.Dynamic;
using NUnit.Framework;

namespace Azure.Core.Tests
{
    public class DynamicDataSerializationTests
    {
        [Test]
        public void CanRoundTripSerialize()
        {
            dynamic orig = new BinaryData(
                """
                {
                    "property" : "hello"
                }
                """).ToDynamicFromJson();

            void validate(dynamic d)
            {
                Assert.IsTrue(d.property == "hello");

                int count = 0;
                foreach (dynamic item in d)
                {
                    count++;
                }

                Assert.IsTrue(count == 1);
            }

            validate(orig);

            dynamic roundTrip = JsonSerializer.Deserialize<DynamicData>(JsonSerializer.Serialize(orig, orig.GetType()));

            validate(roundTrip);
        }

        [Test]
        public void DynamicSerializerOptionsApplyToPocoModels()
        {
            dynamic value = BinaryData.FromString("""{ "foo": null }""").ToDynamicFromJson(
                DynamicCaseMapping.PascalToCamel,
                DynamicDateTimeHandling.Rfc3339);

            DateTimeModel model = DateTimeModel.GetInstance();

            // Existing property
            value.Foo = model;

            // Added property
            value.Bar = model;

            string expectedDateTimeString = DynamicJsonTests.FormatDateTime(model.DateTimeProperty);
            string expectedDateTimeOffsetString = DynamicJsonTests.FormatDateTimeOffset(model.DateTimeOffsetProperty);

            Assert.AreEqual(expectedDateTimeString, (string)value.Foo.DateTimeProperty);
            Assert.AreEqual(expectedDateTimeOffsetString, (string)value.Foo.DateTimeOffsetProperty);

            Assert.AreEqual(expectedDateTimeString, (string)value.Bar.DateTimeProperty);
            Assert.AreEqual(expectedDateTimeOffsetString, (string)value.Bar.DateTimeOffsetProperty);
        }

        [Test]
        public void DynamicSetsUseJsonSerializer()
        {
            // IUtf8JsonSerializable.Write() is not used

            string json = """{ "foo": null }""";
            dynamic value = BinaryData.FromString(json).ToDynamicFromJson();

            AzureUtf8JsonSerializableModel model = new AzureUtf8JsonSerializableModel();
            model.Property = "hello";

            // Existing property
            value.Foo = model;

            // Added property
            value.Bar = model;

            Assert.AreEqual("hello", (string)value.Foo.Property);
            Assert.AreEqual("hello", (string)value.Bar.Property);

            // ... if it was, the value would be different.
            using MemoryStream stream = new();
            using (Utf8JsonWriter writer = new(stream))
            {
                ((IUtf8JsonSerializable)model).Write(writer);
            }
            stream.Position = 0;
            dynamic azureModelValue = BinaryData.FromStream(stream).ToDynamicFromJson();

            Assert.AreEqual("azurehello", (string)azureModelValue.azureProperty);
        }

        [Test]
        public void DynamicSerializerOptionsOverrideIUtf8JsonSerializableWrite()
        {
            string json = """{ "foo": null }""";
            dynamic value = BinaryData.FromString(json).ToDynamicFromJson(
                DynamicCaseMapping.PascalToCamel,
                DynamicDateTimeHandling.UnixTime);

            AzureDateTimeModel model = AzureDateTimeModel.GetInstance();

            // Existing property
            value.Foo = model;

            // Added property
            value.Bar = model;

            // Unix time is used instead of formatting in IUtf8JsonSerializable.Write()
            Assert.AreEqual(ToUnixTime(model.DateTimeProperty), (long)value.Foo.DateTimeProperty);
            Assert.AreEqual(ToUnixTime(model.DateTimeOffsetProperty), (long)value.Foo.DateTimeOffsetProperty);

            Assert.AreEqual(ToUnixTime(model.DateTimeProperty), (long)value.Bar.DateTimeProperty);
            Assert.AreEqual(ToUnixTime(model.DateTimeOffsetProperty), (long)value.Bar.DateTimeOffsetProperty);
        }

        [Test]
        public void DynamicSerializeBinaryDataModel()
        {
            string json = """{ "foo": null }""";
            dynamic value = BinaryData.FromString(json).ToDynamicFromJson();

            BinaryData b = BinaryData.FromString("b");

            BinaryDataModel model = new BinaryDataModel()
            {
                StringProperty = "a",
                BinaryDataProperty = b
            };

            // Existing property
            value.Foo = model;

            // Added property
            value.Bar = model;

            Assert.AreEqual("a", (string)value.Foo.StringProperty);
            CollectionAssert.AreEqual(b.ToArray(), ((BinaryData)value.Foo.BinaryDataProperty).ToArray());

            Assert.AreEqual("a", (string)value.Bar.StringProperty);
            CollectionAssert.AreEqual(b.ToArray(), ((BinaryData)value.Bar.BinaryDataProperty).ToArray());
        }

        #region Helpers
        internal static long ToUnixTime(DateTime d)
        {
            return ((DateTimeOffset)d).ToUnixTimeSeconds();
        }

        internal static long ToUnixTime(DateTimeOffset d)
        {
            return d.ToUnixTimeSeconds();
        }

#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()

        internal class DateTimeModel : IEquatable<DateTimeModel>
        {
            public static DateTimeModel GetInstance()
            {
                return new DateTimeModel()
                {
                    DateTimeProperty = DateTime.UtcNow,
                    DateTimeOffsetProperty = DateTimeOffset.UtcNow,
                };
            }

            public DateTime DateTimeProperty { get; set; }
            public DateTimeOffset DateTimeOffsetProperty { get; set; }

            public override bool Equals(object obj)
            {
                if (obj is not DateTimeModel other)
                {
                    return false;
                }

                return Equals(other);
            }

            public bool Equals(DateTimeModel other)
            {
                return DateTimeProperty == other.DateTimeProperty &&
                       DateTimeOffsetProperty == other.DateTimeOffsetProperty;
            }
        }

        internal class BinaryDataModel
        {
            public string StringProperty { get; set; }
            public BinaryData BinaryDataProperty { get; set; }
        }

        internal class AzureUtf8JsonSerializableModel : IUtf8JsonSerializable
        {
            public string Property { get; set; }

            void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("azureProperty");
                writer.WriteStringValue($"azure{Property}");
                writer.WriteEndObject();
            }
        }

        internal class AzureDateTimeModel : IUtf8JsonSerializable
        {
            public static AzureDateTimeModel GetInstance()
            {
                return new AzureDateTimeModel()
                {
                    DateTimeProperty = DateTime.UtcNow,
                    DateTimeOffsetProperty = DateTimeOffset.UtcNow,
                };
            }

            public DateTime DateTimeProperty { get; set; }
            public DateTimeOffset DateTimeOffsetProperty { get; set; }

            public void Write(Utf8JsonWriter writer)
            {
                writer.WriteStartObject();
                if (Optional.IsDefined(DateTimeProperty))
                {
                    writer.WritePropertyName("dateTimeProperty");
                    writer.WriteStringValue(DateTimeProperty, "O");
                }
                if (Optional.IsDefined(DateTimeOffsetProperty))
                {
                    writer.WritePropertyName("dateTimeOffsetProperty");
                    writer.WriteStringValue(DateTimeProperty, "O");
                }
                writer.WriteEndObject();
            }
        }

        internal class AzureUnixTimeModel : IEquatable<AzureUnixTimeModel>
        {
            public DateTime? Created { get; set; }

            internal AzureUnixTimeModel(int? created)
            {
                Created = DateTimeFromUnixEpoch(created.Value);
            }

            private static AzureUnixTimeModel DeserializeAzureUnixTimeModel(JsonElement element)
            {
                Optional<int?> created = default;

                foreach (var property in element.EnumerateObject())
                {
                    if (property.NameEquals("created"u8))
                    {
                        if (property.Value.ValueKind == JsonValueKind.Null)
                        {
                            created = null;
                            continue;
                        }
                        created = property.Value.GetInt32();
                        continue;
                    }
                }
                return new AzureUnixTimeModel(created);
            }

            private static readonly DateTime s_epochStartUtc = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            private static DateTime DateTimeFromUnixEpoch(long secondsAfterUnixEpoch)
                => s_epochStartUtc.AddSeconds(secondsAfterUnixEpoch);

            /// <summary> Deserializes the model from a raw response. </summary>
            /// <param name="response"> The response to deserialize the model from. </param>
            internal static AzureUnixTimeModel FromResponse(Response response)
            {
                using var document = JsonDocument.Parse(response.Content);
                return DeserializeAzureUnixTimeModel(document.RootElement);
            }

            public override bool Equals(object obj)
            {
                if (obj is not AzureUnixTimeModel other)
                {
                    return false;
                }

                return Equals(other);
            }

            public bool Equals(AzureUnixTimeModel other)
            {
                throw new NotImplementedException();
            }
        }

#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
        #endregion
    }
}
