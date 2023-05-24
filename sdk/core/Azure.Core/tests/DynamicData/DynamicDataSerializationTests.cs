// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
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

            string expectedDateTimeString = DynamicJsonTests.FormatDateTime(model.DateTimeProperty);
            string expectedDateTimeOffsetString = DynamicJsonTests.FormatDateTimeOffset(model.DateTimeOffsetProperty);

            Assert.AreEqual(expectedDateTimeString, (string)value.Foo.DateTimeProperty);
            Assert.AreEqual(expectedDateTimeOffsetString, (string)value.Foo.DateTimeOffsetProperty);

            Assert.AreEqual(expectedDateTimeString, (string)value.Bar.DateTimeProperty);
            Assert.AreEqual(expectedDateTimeOffsetString, (string)value.Bar.DateTimeOffsetProperty);
        }

        #region Helpers
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
