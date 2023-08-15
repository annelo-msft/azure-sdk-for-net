// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.Core.Serialization;

namespace Azure.Core.Tests.PatchModels
{
    internal abstract partial class PatchModel<T> : IModelJsonSerializable<T> where T : class
    {
        public abstract T Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options);
        public abstract T Deserialize(BinaryData data, ModelSerializerOptions options);

        BinaryData IModelSerializable<T>.Serialize(ModelSerializerOptions options)
        {
            ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
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

        // TODO: Move this into the public interface as a separate PR
        public static void ValidateFormat<TModel>(IModelSerializable<TModel> model, ModelSerializerFormat format)
        {
            bool isValidPatchFormat = model is IModelJsonSerializable<TModel> && format == "P";
            if (!isValidPatchFormat)
            {
                ModelSerializerHelper.ValidateFormat(model, format);
            }
        }
    }
}
