using Azure;
using Azure.Core;
using Azure.Core.Dynamic;
using Azure.Core.TestFramework;

using TryDynamicJson;

// Create the JSON to return in the mock client responses.
MockClientOptions options = new()
{
    Transport = new MockTransport(

        // TODO: Return your own JSON values here!

        (MockRequest request) =>
        {
            if (request.Content == null)
            {
                return new MockResponse(200).SetContent("""{ "Id" : "123", "Name" : "Alice" }""");
            }

            // If content was passed in on that response, return that instead.
            MockResponse response = new(200)
            {
                ContentStream = new MemoryStream()
            };

            request.Content.WriteTo(response.ContentStream, CancellationToken.None);
            return response;
        }
    )
};

MockClient client = new MockClient(new Uri("https://example.azure.com"), new MockCredential(), options);

// Shows what it would look like to GET a value from a protocol method.
// Response.Content contains the JSON set in the first MockResponse.
Response response = await client.GetValueAsync();
dynamic value = response.Content.ToDynamic();

// Do something with the dynamic JSON
Console.WriteLine("ID: " + value.Id + ", Name: " + value.Name);


// Shows what it would look like to update and send the value back to the service.
// Response.Content contains the JSON set in value1.
value.Name = "Bob";

RequestContent content = RequestContent.Create((BinaryData)value);
response = await client.SetValueAsync(content);
value = response.Content.ToDynamic();

// Do something with the dynamic JSON
Console.WriteLine("ID: " + value.Id + ", Name: " + value.Name);
