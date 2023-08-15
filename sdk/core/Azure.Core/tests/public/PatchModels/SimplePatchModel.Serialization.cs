// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.Core.Json;
using Azure.Core.Serialization;

namespace Azure.Core.Tests.PatchModels
{
    public partial class SimplePatchModel : PatchModel<SimplePatchModel>, IModelJsonSerializable<SimplePatchModel>
    {
        private static SimplePatchModel DeserializeModel(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            MutableJsonDocument mdoc = MutableJsonDocument.Parse(ref reader);
            return new SimplePatchModel(mdoc.RootElement);
        }

        SimplePatchModel IModelJsonSerializable<SimplePatchModel>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ValidateFormat(this, options.Format);

            return Deserialize(ref reader, options);
        }

        private static SimplePatchModel DeserializeModel(BinaryData data, ModelSerializerOptions options)
        {
            MutableJsonDocument mdoc = MutableJsonDocument.Parse(data);
            return new SimplePatchModel(mdoc.RootElement);
        }

        SimplePatchModel IModelSerializable<SimplePatchModel>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ValidateFormat(this, options.Format);

            return Deserialize(data, options);
        }

        public static explicit operator SimplePatchModel(Response response)
        {
            Argument.AssertNotNull(response, nameof(response));

            return DeserializeModel(response.Content, ModelSerializerOptions.DefaultWireOptions);
        }

        public override SimplePatchModel Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            return DeserializeModel(ref reader, options);
        }

        public override SimplePatchModel Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            return DeserializeModel(data, options);
        }
    }
}
