// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Text.Json;
using Azure.Core.Json;
using BenchmarkDotNet.Attributes;

namespace Azure.Core.Experimental.Perf.Benchmarks
{
    [MemoryDiagnoser]
    public class MutableJsonDataBenchmark
    {
        private JsonDocument _doc = JsonDocument.Parse(JsonSamples.DocumentSentiment);

        [Benchmark(Baseline = true)]
        public void DocumentSentiment_WriteTo_JsonDocument()
        {
            using MemoryStream stream = new();
            using Utf8JsonWriter writer = new(stream);
            _doc.WriteTo(writer);
        }

        private MutableJsonDocument _mdoc = MutableJsonDocument.Parse(JsonSamples.DocumentSentiment);

        [Benchmark]
        public void DocumentSentiment_WriteTo_MutableJsonDocument_NoChanges()
        {
            using MemoryStream stream = new();
            using Utf8JsonWriter writer = new(stream);
            _mdoc.WriteTo(writer);
        }

        private MutableJsonDocument _mcdoc = GetMutableJsonDocumentWithChanges();

        private static MutableJsonDocument GetMutableJsonDocumentWithChanges()
        {
            MutableJsonDocument mdoc = MutableJsonDocument.Parse(JsonSamples.DocumentSentiment);
            mdoc.RootElement.GetProperty("documents").GetIndexElement(0).GetProperty("sentences").GetIndexElement(1).GetProperty("sentiment").Set("positive");
            return mdoc;
        }

        [Benchmark]
        public void DocumentSentiment_WriteTo_MutableJsonDocument_ChangedValue()
        {
            using MemoryStream stream = new();
            using Utf8JsonWriter writer = new(stream);
            _mcdoc.WriteTo(writer);
        }
    }
}
