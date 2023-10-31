// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Net;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;

namespace Maps;

public class IPAddressCountryPair : IJsonModel<IPAddressCountryPair>
{
    internal IPAddressCountryPair(CountryRegion countryRegion, IPAddress ipAddress)
    {
        CountryRegion = countryRegion;
        IpAddress = ipAddress;
    }

    public CountryRegion CountryRegion { get; }

    public IPAddress IpAddress { get; }

    internal static IPAddressCountryPair FromResponse(MessageResponse response)
    {
        // Read JSON from response.Body and return IPAddressCountryPair
    }

    public IPAddressCountryPair Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        // Read JSON values and return IPAddressCountryPair
    }

    public IPAddressCountryPair Read(BinaryData data, ModelReaderWriterOptions options)
    {
        // Read JSON from BinaryData and return IPAddressCountryPair
    }

    public void Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        // Write JSON representing model to Utf8JsonWriter
    }

    public BinaryData Write(ModelReaderWriterOptions options)
    {
        // Write JSON representing model to returned BinaryData value
    }
}
