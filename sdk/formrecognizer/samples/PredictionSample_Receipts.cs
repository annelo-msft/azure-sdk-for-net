// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Prebuilt;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Azure.AI.FormRecognizer.Samples
{
    public class PredictionSample_Receipts
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
            var client = new ReceiptExtractionClient(new Uri(endpoint), credential, new FormRecognizerClientOptions());

            var filePath = @"C:\src\samples\cognitive\formrecognizer\sample_data\Test\Receipt_6.pdf";
            var stream = File.OpenRead(filePath);

            ExtractReceiptResult result = await client.ExtractReceiptAsync(stream, includeTextDetails: true);
            ExtractedReceipt receipt = result.Receipt;

            Console.WriteLine($"Receipt contained the following values: ");

            Console.WriteLine($"ReceiptType: {receipt.ReceiptType}");
            Console.WriteLine($"MerchantName: {receipt.MerchantName}");
            Console.WriteLine($"MerchantAddress: {receipt.MerchantAddress}");
            Console.WriteLine($"MerchantPhoneNumber: {receipt.MerchantPhoneNumber}");
            Console.WriteLine($"TransactionDate: {receipt.TransactionDate}");
            Console.WriteLine($"TransactionTime: {receipt.TransactionTime}");

            foreach (var item in receipt.Items)
            {
                Console.WriteLine($"    Item: [Name: {item.Name}, Quantity: {item.Quantity}, TotalPrice: {item.TotalPrice}");
            }

            Console.WriteLine($"Subtotal: {receipt.Subtotal}");
            Console.WriteLine($"Tax: {receipt.Tax}");
            Console.WriteLine($"Tip: {receipt.Tip}");
            Console.WriteLine($"Total: {receipt.Total}");

            // Print OCR Values
            foreach (var page in result.TextDetails)
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
