using Azure;
using Azure.Core;
using Azure.Core.Dynamic;
using Azure.Data.AppConfiguration;
using System.Text.Json;
using System.Text.Json.Nodes;

#nullable disable

namespace AppConfigToy
{
    public class DateTimeSample
    {
        private static ConfigurationClient client = Common.GetClient();

        public static void Run()
        {
            Response response = client.GetConfigurationSetting("FontColor", null, null, null, null, null);

            JsonDocument doc = JsonDocument.Parse(response.Content);
            JsonElement element = doc.RootElement.GetProperty("last_modified");
            string jdval = element.ToString();

            Stream s1 = new MemoryStream();
            Utf8JsonWriter w1 = new Utf8JsonWriter(s1);
            element.WriteTo(w1);
            w1.Flush();
            s1.Position = 0;

            JsonNode node = JsonNode.Parse(response.Content.ToStream());
            object nodeVal = node["last_modified"];
            string jnval = (string)node["last_modified"];

            Stream s2 = new MemoryStream();
            Utf8JsonWriter w2 = new Utf8JsonWriter(s2);
            node["last_modified"].WriteTo(w2);
            w2.Flush();
            s2.Position = 0;

            dynamic json = response.Content.ToDynamic();
            object jsonVal = json.last_modified;
            string djval = json.last_modified;

            Stream s3 = new MemoryStream();
            //Utf8JsonWriter w3 = new Utf8JsonWriter(s3);
            DynamicData.WriteTo(s3, json.last_modified);
            s3.Position = 0;
        }
    }
}
