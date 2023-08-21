// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class VideoEncoderConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Encoding))
            {
                writer.WritePropertyName("encoding"u8);
                writer.WriteStringValue(Encoding.Value.ToString());
            }
            if (Core.Optional.IsDefined(Quality))
            {
                writer.WritePropertyName("quality"u8);
                writer.WriteNumberValue(Quality.Value);
            }
            if (Core.Optional.IsDefined(Resolution))
            {
                writer.WritePropertyName("resolution"u8);
                writer.WriteObjectValue(Resolution);
            }
            if (Core.Optional.IsDefined(RateControl))
            {
                writer.WritePropertyName("rateControl"u8);
                writer.WriteObjectValue(RateControl);
            }
            if (Core.Optional.IsDefined(H264))
            {
                writer.WritePropertyName("h264"u8);
                writer.WriteObjectValue(H264);
            }
            if (Core.Optional.IsDefined(Mpeg4))
            {
                writer.WritePropertyName("mpeg4"u8);
                writer.WriteObjectValue(Mpeg4);
            }
            writer.WriteEndObject();
        }

        internal static VideoEncoderConfiguration DeserializeVideoEncoderConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<VideoEncoding> encoding = default;
            Core.Optional<float> quality = default;
            Core.Optional<VideoResolution> resolution = default;
            Core.Optional<RateControl> rateControl = default;
            Core.Optional<H264Configuration> h264 = default;
            Core.Optional<Mpeg4Configuration> mpeg4 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encoding"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encoding = new VideoEncoding(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("quality"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quality = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("resolution"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resolution = VideoResolution.DeserializeVideoResolution(property.Value);
                    continue;
                }
                if (property.NameEquals("rateControl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rateControl = RateControl.DeserializeRateControl(property.Value);
                    continue;
                }
                if (property.NameEquals("h264"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    h264 = H264Configuration.DeserializeH264Configuration(property.Value);
                    continue;
                }
                if (property.NameEquals("mpeg4"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mpeg4 = Mpeg4Configuration.DeserializeMpeg4Configuration(property.Value);
                    continue;
                }
            }
            return new VideoEncoderConfiguration(Core.Optional.ToNullable(encoding), Core.Optional.ToNullable(quality), resolution.Value, rateControl.Value, h264.Value, mpeg4.Value);
        }
    }
}
