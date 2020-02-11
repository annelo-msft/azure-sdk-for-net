// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Azure.AI.FormRecognizer.Samples
{
    public class PredictionSample_CustomSupervised
    {
        //public static async Task Main(string[] args)
        //{
        //    try
        //    {
        //        await Analyze();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //}

        private static async Task Analyze()
        {
            string endpoint = Environment.GetEnvironmentVariable("FORM_RECOGNIZER_ENDPOINT");
            string subscriptionKey = Environment.GetEnvironmentVariable("FORM_RECOGNIZER_SUBSCRIPTION_KEY");

            var credential = new CognitiveKeyCredential(subscriptionKey);
            var client = new CustomRecognizerClient(new Uri(endpoint), credential, new FormRecognizerClientOptions());

            string modelId = "a36ff8a9-d7b3-4ee6-92d0-6e6eb73816c7";

            var filePath = @"C:\src\samples\cognitive\formrecognizer\sample_data\Test\Invoice_6.pdf";
            var stream = File.OpenRead(filePath);

            //var op = await client.GetModelReference(modelId).StartAnalyzeAsync(stream, null, includeTextDetails: false);

            ExtractPredefinedFieldFormResult result = await client.ExtractPredefinedFieldFormAsync(modelId, stream);

            // Print form fields
            foreach (var form in result.Forms)
            {
                Console.WriteLine($"In form found on pages {form.PageRange.StartPageNumber} - {form.PageRange.EndPageNumber}: ");

                foreach (var page in form.Pages)
                {

                    foreach (var field in page.Fields)
                    {
                        // TODO: Would it be better to implement ToString here, instead of making users write out "Text"?

                        // This is what unsupervised looked like:
                        // Console.WriteLine($"Found field {field.FieldName.Text} with value {field.FieldValue.Text}");

                        Console.WriteLine($"Found field {field.Name} with value {field.Value.Text}");
                    }
                }

            }

            // Print OCR Values
            foreach (var page in result.RawPages)
            {
                Console.WriteLine($"On page {page.PageNumber}: ");

                foreach (var line in page.Lines)
                {
                    Console.WriteLine($"Line text is {line.Text}, and composed of the words:");

                    foreach (var word in line.Words)
                    {
                        Console.WriteLine($"Word: {word.Text}, Confidence: {word.Confidence}");
                    }
                }


                //var keyText = op.Value.AnalyzeResult.PageResults[0].KeyValuePairs[0].Key.Text;
                //var valueText = op.Value.AnalyzeResult.PageResults[0].KeyValuePairs[0].Value.Text;

                //var fieldName = op.Value.AnalyzeResult.DocumentResults[0].Fields.Keys.First();
                //var fieldValue = op.Value.AnalyzeResult.DocumentResults[0].Fields[fieldName].Text;

                //Analysis analysis = op.Value;
                //var documentResults = analysis.AnalyzeResult.DocumentResults;
                //var pageResults = analysis.AnalyzeResult.PageResults;
                //var readResults = analysis.AnalyzeResult.ReadResults;
                ////readResults[0].
                ////pageResults[0].
                //documentResults[0].Fields["key"].

                ////foreach (var documentResult in documentResults)
                ////{
                ////}

                //// Console.WriteLine($"Status: {op.Value.Status}");
                //PrintResponse(op.GetRawResponse());
            }
        }

        private static void PrintResponse(Response response)
        {
            var mem = new MemoryStream();
            response.ContentStream.Position = 0;
            response.ContentStream.CopyTo(mem);
            var body = Encoding.UTF8.GetString(mem.ToArray());
            Console.WriteLine(body);
        }
    }
}
