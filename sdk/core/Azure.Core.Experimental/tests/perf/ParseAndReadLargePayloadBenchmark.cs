// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
#if NET6_0_OR_GREATER
using System.Text.Json.Nodes;
#endif
using Azure.Core.Dynamic;
using Azure.Core.Json;
using BenchmarkDotNet.Attributes;

namespace Azure.Core.Experimental.Perf.Benchmarks
{
    [MemoryDiagnoser]
    public class ParseAndReadLargePayloadBenchmark
    {
        [Benchmark(Baseline = true)]
        public string ParseAndReadJsonDocument()
        {
            // This should return the string "neutral".
            var document = JsonDocument.Parse(JsonSamples.DocumentSentiment);
            return document.RootElement.GetProperty("documents")[0].GetProperty("sentences")[1].GetProperty("sentiment").GetString();
        }

#if NET6_0_OR_GREATER
        [Benchmark]
        public string ParseAndReadJsonNode()
        {
            JsonNode json = JsonNode.Parse(JsonSamples.DocumentSentiment);
            return (string)json["documents"][0]["sentences"][1]["sentiment"];
        }
#endif
        [Benchmark]
        public string ParseAndReadMutableJsonDocument()
        {
            MutableJsonDocument json = MutableJsonDocument.Parse(JsonSamples.DocumentSentiment);
            return json.RootElement.GetProperty("documents").GetIndexElement(0).GetProperty("sentences").GetIndexElement(1).GetProperty("sentiment").GetString();
        }

        [Benchmark]
        public string ParseAndReadDynamicJson()
        {
            var json = JsonSamples.DocumentSentiment.ToDynamic();
            return json.documents[0].sentences[1].sentiment;
        }
    }
}
