﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.Core.Json;
using Azure.Core.Serialization;

namespace Azure.Core.Tests.PatchModels
{
    public partial class SimplePatchModel : IModelJsonSerializable<SimplePatchModel>
    {
        SimplePatchModel IModelJsonSerializable<SimplePatchModel>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ValidateFormat(this, options.Format);

            return Deserialize(ref reader, options);
        }

        private static SimplePatchModel Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            MutableJsonDocument mdoc = MutableJsonDocument.Parse(ref reader);
            return new SimplePatchModel(mdoc.RootElement);
        }

        SimplePatchModel IModelSerializable<SimplePatchModel>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ValidateFormat(this, options.Format);

            return Deserialize(data, options);
        }

        private static SimplePatchModel Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            MutableJsonDocument mdoc = MutableJsonDocument.Parse(data);
            return new SimplePatchModel(mdoc.RootElement);
        }

        void IModelJsonSerializable<SimplePatchModel>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ValidateFormat(this, options.Format);

            switch (options.Format.ToString())
            {
                case "J":
                case "W":
                    _element.WriteTo(writer, "J");
                    break;
                case "P":
                    _element.WriteTo(writer, "P");
                    break;
                default:
                    // Exception was thrown by ValidateFormat.
                    break;
            }
        }

        BinaryData IModelSerializable<SimplePatchModel>.Serialize(ModelSerializerOptions options)
        {
            ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        public static explicit operator SimplePatchModel(Response response)
        {
            Argument.AssertNotNull(response, nameof(response));

            return Deserialize(response.Content, ModelSerializerOptions.DefaultWireOptions);
        }

        // TODO: Move this into the public interface as a separate PR
        public static void ValidateFormat<T>(IModelSerializable<T> model, ModelSerializerFormat format)
        {
            bool isValidPatchFormat = model is IModelJsonSerializable<T> && format == "P";
            if (!isValidPatchFormat)
            {
                ModelSerializerHelper.ValidateFormat(model, format);
            }
        }
    }
}
