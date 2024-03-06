// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppLoginInfo : IUtf8JsonSerializable, IJsonModel<WebAppLoginInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebAppLoginInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebAppLoginInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppLoginInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppLoginInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Routes))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteObjectValue(Routes);
            }
            if (Optional.IsDefined(TokenStore))
            {
                writer.WritePropertyName("tokenStore"u8);
                writer.WriteObjectValue(TokenStore);
            }
            if (Optional.IsDefined(PreserveUrlFragmentsForLogins))
            {
                writer.WritePropertyName("preserveUrlFragmentsForLogins"u8);
                writer.WriteBooleanValue(PreserveUrlFragmentsForLogins.Value);
            }
            if (Optional.IsCollectionDefined(AllowedExternalRedirectUrls))
            {
                writer.WritePropertyName("allowedExternalRedirectUrls"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedExternalRedirectUrls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CookieExpiration))
            {
                writer.WritePropertyName("cookieExpiration"u8);
                writer.WriteObjectValue(CookieExpiration);
            }
            if (Optional.IsDefined(Nonce))
            {
                writer.WritePropertyName("nonce"u8);
                writer.WriteObjectValue(Nonce);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        WebAppLoginInfo IJsonModel<WebAppLoginInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppLoginInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppLoginInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAppLoginInfo(document.RootElement, options);
        }

        internal static WebAppLoginInfo DeserializeWebAppLoginInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LoginRoutes routes = default;
            AppServiceTokenStore tokenStore = default;
            bool? preserveUrlFragmentsForLogins = default;
            IList<string> allowedExternalRedirectUrls = default;
            WebAppCookieExpiration cookieExpiration = default;
            LoginFlowNonceSettings nonce = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routes = LoginRoutes.DeserializeLoginRoutes(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tokenStore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tokenStore = AppServiceTokenStore.DeserializeAppServiceTokenStore(property.Value, options);
                    continue;
                }
                if (property.NameEquals("preserveUrlFragmentsForLogins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveUrlFragmentsForLogins = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedExternalRedirectUrls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedExternalRedirectUrls = array;
                    continue;
                }
                if (property.NameEquals("cookieExpiration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cookieExpiration = WebAppCookieExpiration.DeserializeWebAppCookieExpiration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nonce"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nonce = LoginFlowNonceSettings.DeserializeLoginFlowNonceSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebAppLoginInfo(
                routes,
                tokenStore,
                preserveUrlFragmentsForLogins,
                allowedExternalRedirectUrls ?? new ChangeTrackingList<string>(),
                cookieExpiration,
                nonce,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebAppLoginInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppLoginInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebAppLoginInfo)} does not support '{options.Format}' format.");
            }
        }

        WebAppLoginInfo IPersistableModel<WebAppLoginInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppLoginInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebAppLoginInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebAppLoginInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebAppLoginInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
