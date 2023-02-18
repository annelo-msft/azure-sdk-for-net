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
    public class ReadLargePayloadBenchmark
    {
        private JsonDocument _document = JsonDocument.Parse(JsonSamples.DocumentSentiment);

        [Benchmark(Baseline = true)]
        public string ReadJsonDocument()
        {
            // This should return the string "neutral".
            return _document.RootElement.GetProperty("documents")[0].GetProperty("sentences")[1].GetProperty("sentiment").GetString();
        }

#if NET6_0_OR_GREATER
        private JsonNode _node = JsonNode.Parse(JsonSamples.DocumentSentiment);

        [Benchmark]
        public string ReadJsonNode()
        {
            return (string)_node["documents"][0]["sentences"][1]["sentiment"];
        }
#endif

        private MutableJsonDocument _mutableJson = MutableJsonDocument.Parse(JsonSamples.DocumentSentiment);

        [Benchmark]
        public string ReadMutableJsonDocument()
        {
            return _mutableJson.RootElement.GetProperty("documents").GetIndexElement(0).GetProperty("sentences").GetIndexElement(1).GetProperty("sentiment").GetString();
        }

        private dynamic _dynamicJson = JsonSamples.DocumentSentiment.ToDynamic();

        [Benchmark]
        public string ReadDynamicJson()
        {
            return _dynamicJson.documents[0].sentences[1].sentiment;
        }
    }
}
