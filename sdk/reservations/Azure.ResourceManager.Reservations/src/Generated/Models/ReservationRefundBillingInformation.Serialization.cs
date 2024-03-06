// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Reservations;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationRefundBillingInformation : IUtf8JsonSerializable, IJsonModel<ReservationRefundBillingInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationRefundBillingInformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReservationRefundBillingInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationRefundBillingInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationRefundBillingInformation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BillingPlan))
            {
                writer.WritePropertyName("billingPlan"u8);
                writer.WriteStringValue(BillingPlan.Value.ToString());
            }
            if (Optional.IsDefined(CompletedTransactions))
            {
                writer.WritePropertyName("completedTransactions"u8);
                writer.WriteNumberValue(CompletedTransactions.Value);
            }
            if (Optional.IsDefined(TotalTransactions))
            {
                writer.WritePropertyName("totalTransactions"u8);
                writer.WriteNumberValue(TotalTransactions.Value);
            }
            if (Optional.IsDefined(BillingCurrencyTotalPaidAmount))
            {
                writer.WritePropertyName("billingCurrencyTotalPaidAmount"u8);
                writer.WriteObjectValue(BillingCurrencyTotalPaidAmount);
            }
            if (Optional.IsDefined(BillingCurrencyProratedAmount))
            {
                writer.WritePropertyName("billingCurrencyProratedAmount"u8);
                writer.WriteObjectValue(BillingCurrencyProratedAmount);
            }
            if (Optional.IsDefined(BillingCurrencyRemainingCommitmentAmount))
            {
                writer.WritePropertyName("billingCurrencyRemainingCommitmentAmount"u8);
                writer.WriteObjectValue(BillingCurrencyRemainingCommitmentAmount);
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

        ReservationRefundBillingInformation IJsonModel<ReservationRefundBillingInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationRefundBillingInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationRefundBillingInformation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationRefundBillingInformation(document.RootElement, options);
        }

        internal static ReservationRefundBillingInformation DeserializeReservationRefundBillingInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ReservationBillingPlan? billingPlan = default;
            int? completedTransactions = default;
            int? totalTransactions = default;
            PurchasePrice billingCurrencyTotalPaidAmount = default;
            PurchasePrice billingCurrencyProratedAmount = default;
            PurchasePrice billingCurrencyRemainingCommitmentAmount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingPlan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingPlan = new ReservationBillingPlan(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("completedTransactions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    completedTransactions = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalTransactions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalTransactions = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("billingCurrencyTotalPaidAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyTotalPaidAmount = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("billingCurrencyProratedAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyProratedAmount = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("billingCurrencyRemainingCommitmentAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyRemainingCommitmentAmount = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReservationRefundBillingInformation(
                billingPlan,
                completedTransactions,
                totalTransactions,
                billingCurrencyTotalPaidAmount,
                billingCurrencyProratedAmount,
                billingCurrencyRemainingCommitmentAmount,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationRefundBillingInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationRefundBillingInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReservationRefundBillingInformation)} does not support '{options.Format}' format.");
            }
        }

        ReservationRefundBillingInformation IPersistableModel<ReservationRefundBillingInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationRefundBillingInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationRefundBillingInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationRefundBillingInformation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationRefundBillingInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
