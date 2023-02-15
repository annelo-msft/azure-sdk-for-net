using System.Text.Json;
using Azure.Core.Dynamic;
using TryMutableJsonDocument;


MutableJsonDocument mcdoc = GetMutableJsonDocumentWithChanges();

using MemoryStream stream = new();
using Utf8JsonWriter writer = new(stream);
mcdoc.WriteTo(stream);


static MutableJsonDocument GetMutableJsonDocumentWithChanges()
{
    var mdoc = MutableJsonDocument.Parse(JsonSamples.DocumentSentiment);
    mdoc.RootElement.GetProperty("documents").GetIndexElement(0).GetProperty("sentences").GetIndexElement(1).GetProperty("sentiment").Set("positive");
    return mdoc;
}
