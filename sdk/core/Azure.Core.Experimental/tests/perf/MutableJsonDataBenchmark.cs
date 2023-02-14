// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Text.Json;
using Azure.Core.Dynamic;
using BenchmarkDotNet.Attributes;

namespace Azure.Core.Experimental.Perf.Benchmarks
{
    [MemoryDiagnoser]
    public class MutableJsonDataBenchmark
    {
        // Initialize for first test.
        private JsonDocument _doc = JsonDocument.Parse(JsonSamples.DocumentSentiment);

        // Initialize for second test.
        private MutableJsonDocument _mdoc = MutableJsonDocument.Parse(JsonSamples.DocumentSentiment);

        // Initialize for third test.
        private MutableJsonDocument _mcdoc = GetMutableJsonDocumentWithChanges();

        private static MutableJsonDocument GetMutableJsonDocumentWithChanges()
        {
            var mdoc = MutableJsonDocument.Parse(JsonSamples.DocumentSentiment);
            mdoc.RootElement.GetProperty("documents").GetIndexElement(0).GetProperty("sentences").GetIndexElement(1).GetProperty("sentiment").Set("positive");
            return mdoc;
        }

        [Benchmark(Baseline = true)]
        public void DocumentSentiment_WriteTo_JsonDocument()
        {
            using MemoryStream stream = new();
            using Utf8JsonWriter writer = new(stream);
            _doc.WriteTo(writer);
        }

        [Benchmark]
        public void DocumentSentiment_WriteTo_JsonData_NoChanges()
        {
            using MemoryStream stream = new();
            using Utf8JsonWriter writer = new(stream);
            _mdoc.WriteTo(writer);
        }

        [Benchmark]
        public void DocumentSentiment_WriteTo_JsonData_ChangeValue()
        {
            using MemoryStream stream = new();
            using Utf8JsonWriter writer = new(stream);
            _mcdoc.WriteTo(writer);
        }

        //[Benchmark]
        //public void DocumentSentiment_WriteTo_JsonData_ChangeStructure()
        //{
        //    MutableJsonDocument jsonData = MutableJsonDocument.Parse(JsonSamples.DocumentSentiment);

        //    // Make a small change
        //    jsonData.RootElement.GetProperty("documents").GetIndexElement(0).GetProperty("sentences").GetIndexElement(1).GetProperty("sentiment").Set("positive");

        //    MemoryStream stream = new();
        //    jsonData.WriteTo(stream);
        //}
    }
}
