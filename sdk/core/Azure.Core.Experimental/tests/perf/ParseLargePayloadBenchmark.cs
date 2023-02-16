// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
#if NET6_0_OR_GREATER
using System.Text.Json.Nodes;
#endif
using Azure.Core.Dynamic;
using BenchmarkDotNet.Attributes;

namespace Azure.Core.Experimental.Perf.Benchmarks
{
    [MemoryDiagnoser]
    public class ParseLargePayloadBenchmark
    {
        [Benchmark(Baseline = true)]
        public void ParseJsonDocument() => JsonDocument.Parse(JsonSamples.DocumentSentiment);

#if NET6_0_OR_GREATER
        [Benchmark]
        public void ParseJsonNode() => JsonNode.Parse(JsonSamples.DocumentSentiment);
#endif

        [Benchmark]
        public void ParseMutableJsonDocument() => MutableJsonDocument.Parse(JsonSamples.DocumentSentiment);

        [Benchmark]
        public void ParseDynamicJson() => JsonSamples.DocumentSentiment.ToDynamic();
    }
}
