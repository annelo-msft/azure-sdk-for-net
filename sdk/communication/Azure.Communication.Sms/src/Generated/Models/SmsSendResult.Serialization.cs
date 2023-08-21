// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Sms
{
    public partial class SmsSendResult
    {
        internal static SmsSendResult DeserializeSmsSendResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string to = default;
            Core.Optional<string> messageId = default;
            int httpStatusCode = default;
            Core.Optional<SmsSendResponseItemRepeatabilityResult> repeatabilityResult = default;
            bool successful = default;
            Core.Optional<string> errorMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("to"u8))
                {
                    to = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpStatusCode"u8))
                {
                    httpStatusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("repeatabilityResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    repeatabilityResult = new SmsSendResponseItemRepeatabilityResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("successful"u8))
                {
                    successful = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
            }
            return new SmsSendResult(to, messageId.Value, httpStatusCode, Core.Optional.ToNullable(repeatabilityResult), successful, errorMessage.Value);
        }
    }
}
