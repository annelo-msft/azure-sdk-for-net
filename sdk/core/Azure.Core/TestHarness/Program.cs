using System.Text.Json;
using Azure.Core.Json;

ReadOnlyMemory<byte> utf8Json = """
    {
        "id": "abc"
    }
    """u8.ToArray();
;

MutableJsonDocument mdoc = MutableJsonDocument.Parse(utf8Json);

mdoc.RootElement.GetProperty("id").Set("xyz");

using Stream stream = new MemoryStream();
using Utf8JsonWriter writer = new(stream);
mdoc.WriteTo(writer);

//Console.WriteLine($"** id={mdoc.RootElement.GetProperty("id").GetString()}");
