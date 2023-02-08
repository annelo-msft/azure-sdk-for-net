// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Identity;
using Azure.Core.Dynamic;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Azure.Core.Samples
{
    public class DynamicJsonSamples
    {
        [Test]
        public async Task GetDynamicJson()
        {
            WidgetsClient client = new(new Uri("http://example.azure.com"), new DefaultAzureCredential());

            #region Snippet:GetDynamicJson
            Response response = await client.GetWidgetAsync("123");
            dynamic widget = response.Content.ToDynamic();
            #endregion
        }

        [Test]
        public async Task GetDynamicJsonProperty()
        {
            WidgetsClient client = new(new Uri("http://example.azure.com"), new DefaultAzureCredential());

            #region Snippet:GetDynamicJsonProperty
            Response response = await client.GetWidgetAsync("123");
            dynamic widget = response.Content.ToDynamic();
            string name = widget.Name;
            #endregion
        }

        [Test]
        public async Task SetWidgetAnonymousType()
        {
            WidgetsClient client = new(new Uri("http://example.azure.com"), new DefaultAzureCredential());

            #region Snippet:RoundTripAnonymousType
            Response response = client.GetWidget("123");
            dynamic widget = response.Content.ToDynamic();

            RequestContent update = RequestContent.Create(
                new
                {
                    Id = (string)widget.Id,
                    Name = "New Name"
                    // Required fields
                }
            );
            await client.SetWidgetAsync((string)widget.Id, update);
            #endregion
        }

        [Test]
        public async Task SetWidgetDynamicJson()
        {
            WidgetsClient client = new(new Uri("http://example.azure.com"), new DefaultAzureCredential());

            #region Snippet:RoundTripDynamicJson
            Response response = client.GetWidget("123");
            dynamic widget = response.Content.ToDynamic();

            widget.Name = "New Name";

            await client.SetWidgetAsync((string)widget.Id, widget);
            #endregion
        }
    }
}
