// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer;
using Azure.AI.FormRecognizer.Models;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.AI.FormRecognizer.Samples
{
    public class PredictionSample_Layout
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




            Azure.AI.FormRecognizer.Custom.














            string endpoint = Environment.GetEnvironmentVariable("FORM_RECOGNIZER_ENDPOINT");
            string subscriptionKey = Environment.GetEnvironmentVariable("FORM_RECOGNIZER_SUBSCRIPTION_KEY");

            var credential = new CognitiveKeyCredential(subscriptionKey);
            var client = new FormLayoutClient(new Uri(endpoint), credential, new FormRecognizerClientOptions());

            var filePath = @"C:\src\samples\cognitive\formrecognizer\sample_data\Test\Receipt_6.pdf";
            var stream = File.OpenRead(filePath);

            ExtractLayoutResult result = await client.ExtractLayoutAsync(stream);

            Console.WriteLine($"Form Inset Analysis found the following insets: ");

            foreach (var page in result.Pages)
            {

                foreach (var table in page.Tables)
                {
                    Console.WriteLine($"Table on page {page.PageNumber} has {table.RowCount} rows and {table.ColumnCount} columns, and values:");

                    foreach (var cell in table.Cells)
                    {
                        Console.WriteLine($"    ({cell.ColumnIndex}, {cell.RowIndex}): {cell.Text}");  // TODO: note, cell value not typed.
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
