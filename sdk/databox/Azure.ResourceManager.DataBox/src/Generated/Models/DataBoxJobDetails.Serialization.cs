// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxJobDetails : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(DevicePassword))
            {
                writer.WritePropertyName("devicePassword"u8);
                writer.WriteStringValue(DevicePassword);
            }
            writer.WritePropertyName("contactDetails"u8);
            writer.WriteObjectValue(ContactDetails);
            if (Core.Optional.IsDefined(ShippingAddress))
            {
                writer.WritePropertyName("shippingAddress"u8);
                writer.WriteObjectValue(ShippingAddress);
            }
            if (Core.Optional.IsCollectionDefined(DataImportDetails))
            {
                writer.WritePropertyName("dataImportDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DataImportDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(DataExportDetails))
            {
                writer.WritePropertyName("dataExportDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DataExportDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("jobDetailsType"u8);
            writer.WriteStringValue(JobDetailsType.ToSerialString());
            if (Core.Optional.IsDefined(Preferences))
            {
                writer.WritePropertyName("preferences"u8);
                writer.WriteObjectValue(Preferences);
            }
            if (Core.Optional.IsDefined(ReverseShippingDetails))
            {
                writer.WritePropertyName("reverseShippingDetails"u8);
                writer.WriteObjectValue(ReverseShippingDetails);
            }
            if (Core.Optional.IsDefined(KeyEncryptionKey))
            {
                writer.WritePropertyName("keyEncryptionKey"u8);
                writer.WriteObjectValue(KeyEncryptionKey);
            }
            if (Core.Optional.IsDefined(ExpectedDataSizeInTerabytes))
            {
                writer.WritePropertyName("expectedDataSizeInTeraBytes"u8);
                writer.WriteNumberValue(ExpectedDataSizeInTerabytes.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataBoxJobDetails DeserializeDataBoxJobDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<DataBoxCopyProgress>> copyProgress = default;
            Core.Optional<string> devicePassword = default;
            Core.Optional<IReadOnlyList<DataBoxJobStage>> jobStages = default;
            DataBoxContactDetails contactDetails = default;
            Core.Optional<DataBoxShippingAddress> shippingAddress = default;
            Core.Optional<PackageShippingDetails> deliveryPackage = default;
            Core.Optional<PackageShippingDetails> returnPackage = default;
            Core.Optional<IList<DataImportDetails>> dataImportDetails = default;
            Core.Optional<IList<DataExportDetails>> dataExportDetails = default;
            DataBoxOrderType jobDetailsType = default;
            Core.Optional<DataBoxOrderPreferences> preferences = default;
            Core.Optional<ReverseShippingDetails> reverseShippingDetails = default;
            Core.Optional<IReadOnlyList<CopyLogDetails>> copyLogDetails = default;
            Core.Optional<string> reverseShipmentLabelSasKey = default;
            Core.Optional<string> chainOfCustodySasKey = default;
            Core.Optional<DeviceErasureDetails> deviceErasureDetails = default;
            Core.Optional<DataBoxKeyEncryptionKey> keyEncryptionKey = default;
            Core.Optional<int> expectedDataSizeInTerabytes = default;
            Core.Optional<IReadOnlyList<CustomerResolutionCode>> actions = default;
            Core.Optional<LastMitigationActionOnJob> lastMitigationActionOnJob = default;
            Core.Optional<DataCenterAddressResult> dataCenterAddress = default;
            Core.Optional<DataCenterCode> dataCenterCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("copyProgress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxCopyProgress> array = new List<DataBoxCopyProgress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxCopyProgress.DeserializeDataBoxCopyProgress(item));
                    }
                    copyProgress = array;
                    continue;
                }
                if (property.NameEquals("devicePassword"u8))
                {
                    devicePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobStages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxJobStage> array = new List<DataBoxJobStage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxJobStage.DeserializeDataBoxJobStage(item));
                    }
                    jobStages = array;
                    continue;
                }
                if (property.NameEquals("contactDetails"u8))
                {
                    contactDetails = DataBoxContactDetails.DeserializeDataBoxContactDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("shippingAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shippingAddress = DataBoxShippingAddress.DeserializeDataBoxShippingAddress(property.Value);
                    continue;
                }
                if (property.NameEquals("deliveryPackage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deliveryPackage = PackageShippingDetails.DeserializePackageShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("returnPackage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    returnPackage = PackageShippingDetails.DeserializePackageShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("dataImportDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataImportDetails> array = new List<DataImportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataImportDetails.DeserializeDataImportDetails(item));
                    }
                    dataImportDetails = array;
                    continue;
                }
                if (property.NameEquals("dataExportDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataExportDetails> array = new List<DataExportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataExportDetails.DeserializeDataExportDetails(item));
                    }
                    dataExportDetails = array;
                    continue;
                }
                if (property.NameEquals("jobDetailsType"u8))
                {
                    jobDetailsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (property.NameEquals("preferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferences = DataBoxOrderPreferences.DeserializeDataBoxOrderPreferences(property.Value);
                    continue;
                }
                if (property.NameEquals("reverseShippingDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reverseShippingDetails = ReverseShippingDetails.DeserializeReverseShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("copyLogDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CopyLogDetails> array = new List<CopyLogDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.CopyLogDetails.DeserializeCopyLogDetails(item));
                    }
                    copyLogDetails = array;
                    continue;
                }
                if (property.NameEquals("reverseShipmentLabelSasKey"u8))
                {
                    reverseShipmentLabelSasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("chainOfCustodySasKey"u8))
                {
                    chainOfCustodySasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceErasureDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceErasureDetails = DeviceErasureDetails.DeserializeDeviceErasureDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("keyEncryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKey = DataBoxKeyEncryptionKey.DeserializeDataBoxKeyEncryptionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("expectedDataSizeInTeraBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expectedDataSizeInTerabytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomerResolutionCode> array = new List<CustomerResolutionCode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToCustomerResolutionCode());
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("lastMitigationActionOnJob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastMitigationActionOnJob = LastMitigationActionOnJob.DeserializeLastMitigationActionOnJob(property.Value);
                    continue;
                }
                if (property.NameEquals("datacenterAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterAddress = DataCenterAddressResult.DeserializeDataCenterAddressResult(property.Value);
                    continue;
                }
                if (property.NameEquals("dataCenterCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterCode = new DataCenterCode(property.Value.GetString());
                    continue;
                }
            }
            return new DataBoxJobDetails(Core.Optional.ToList(jobStages), contactDetails, shippingAddress.Value, deliveryPackage.Value, returnPackage.Value, Core.Optional.ToList(dataImportDetails), Core.Optional.ToList(dataExportDetails), jobDetailsType, preferences.Value, reverseShippingDetails.Value, Core.Optional.ToList(copyLogDetails), reverseShipmentLabelSasKey.Value, chainOfCustodySasKey.Value, deviceErasureDetails.Value, keyEncryptionKey.Value, Core.Optional.ToNullable(expectedDataSizeInTerabytes), Core.Optional.ToList(actions), lastMitigationActionOnJob.Value, dataCenterAddress.Value, Core.Optional.ToNullable(dataCenterCode), Core.Optional.ToList(copyProgress), devicePassword.Value);
        }
    }
}
