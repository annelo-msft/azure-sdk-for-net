// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RetrieveBootDiagnosticsDataResult
    {
        internal static RetrieveBootDiagnosticsDataResult DeserializeRetrieveBootDiagnosticsDataResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<Uri> consoleScreenshotBlobUri = default;
            Core.Optional<Uri> serialConsoleLogBlobUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("consoleScreenshotBlobUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    consoleScreenshotBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serialConsoleLogBlobUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serialConsoleLogBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new RetrieveBootDiagnosticsDataResult(consoleScreenshotBlobUri.Value, serialConsoleLogBlobUri.Value);
        }
    }
}
