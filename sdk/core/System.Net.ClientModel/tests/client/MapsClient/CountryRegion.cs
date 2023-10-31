// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;

namespace Maps;

public class CountryRegion : IJsonModel<CountryRegion>
{
    internal CountryRegion(string isoCode)
    {
        IsoCode = isoCode;
    }

    public string IsoCode { get; }

    public CountryRegion Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
    {
        // Read JSON values and return CountryRegion
    }

    public CountryRegion Read(BinaryData data, ModelReaderWriterOptions options)
    {
        // Read JSON from BinaryData and return CountryRegion
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
