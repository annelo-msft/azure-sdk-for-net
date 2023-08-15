// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.Core.Json;
using Azure.Core.Serialization;

namespace Azure.Core.Tests.PatchModels
{
    internal abstract partial class PatchModel<T> : IModelJsonSerializable<T> where T : class
    {
        T IModelJsonSerializable<T>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ValidateFormat(this, options.Format);

            MutableJsonDocument mdoc = MutableJsonDocument.Parse(ref reader);
            return _constructor(mdoc.RootElement);
        }

        T IModelSerializable<T>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ValidateFormat(this, options.Format);

            MutableJsonDocument mdoc = MutableJsonDocument.Parse(data);
            return _constructor(mdoc.RootElement);
        }

        void IModelJsonSerializable<T>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        BinaryData IModelSerializable<T>.Serialize(ModelSerializerOptions options)
        {
            ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        public static explicit operator T(Response response)
        {
            Argument.AssertNotNull(response, nameof(response));

            return Deserialize(response.Content, ModelSerializerOptions.DefaultWireOptions);
        }

        // TODO: Move this into the public interface as a separate PR
        public static void ValidateFormat<U>(IModelSerializable<U> model, ModelSerializerFormat format)
        {
            bool isValidPatchFormat = model is IModelJsonSerializable<U> && format == "P";
            if (!isValidPatchFormat)
            {
                ModelSerializerHelper.ValidateFormat(model, format);
            }
        }
    }
}
