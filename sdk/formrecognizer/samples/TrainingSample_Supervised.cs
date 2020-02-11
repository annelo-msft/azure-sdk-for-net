// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;
using System;
using System.Threading.Tasks;

namespace Azure.AI.FormRecognizer.Samples
{
    public class TrainingSample_Supervised
    {
        //public static async Task Main(string[] args)
        //{
        //    try
        //    {
        //        await Train();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //}

        private static async Task Train()
        {
            string endpoint = Environment.GetEnvironmentVariable("FORM_RECOGNIZER_ENDPOINT");
            string subscriptionKey = Environment.GetEnvironmentVariable("FORM_RECOGNIZER_SUBSCRIPTION_KEY");

            var credential = new CognitiveKeyCredential(subscriptionKey);
            var client = new CustomRecognizerClient(new Uri(endpoint), credential, new FormRecognizerClientOptions());

            string trainingFilePath = "https://annelostorage01.blob.core.windows.net/container-formreco?sp=rl&st=2020-02-01T03:54:59Z&se=2020-02-02T03:54:59Z&sv=2019-02-02&sr=c&sig=%2FlZqrmWSI%2FZ%2B9TeWdJynZfGzQmLws9zz7NB5foEjPjg%3D";

            TrainingWithLabelsOperation op = client.StartTrainingWithLabels(trainingFilePath, new TrainingFileFilter());

            Console.WriteLine($"Created model with id {op.Id}");

            Console.WriteLine("Waiting for completion...");

            await op.WaitForCompletionAsync(TimeSpan.FromSeconds(1), default);
            if (op.HasValue)
            {
                // TODO: How would this be used in a customer scenario?
                TrainingWithLabelsResult value = op.Value;

                Console.WriteLine($"Model Id is: {value.Model.ModelId}");
                Console.WriteLine($"Average model accuracy is: {value.Model.AverageFieldAccuracy}");
                Console.WriteLine($"Model Creation Time: {value.TrainingInfo.CompletionTime}");

                Console.WriteLine("Fields and accuracies: ");
                foreach (var field in value.Model.FieldAccuracies)
                {
                    Console.WriteLine($"Field: {field.FieldName}");
                    Console.WriteLine($"Accuracy: {field.Accuracy}");
                }

                Console.WriteLine("Document Training Results: ");
                foreach (var trainingInputResults in value.TrainingInputResults)
                {
                    Console.WriteLine($"Document Name: {trainingInputResults.DocumentName}");
                    Console.WriteLine($"Number of pages trained: {trainingInputResults.TotalTrainedPages}");

                    // TODO: What does it mean for one of the training documents to fail?
                    Console.WriteLine($"Training status for this document: {trainingInputResults.SuccessStatus}");

                    // TODO: What do these contain and how will they be used by customers?
                    Console.WriteLine($"Document training errors: ");
                    foreach (var error in trainingInputResults.TrainingInputErrors)
                    {
                        Console.WriteLine($"Error: {error.Code}; {error.Message}");
                    }
                }

            }
            else
            {
                Console.WriteLine("LRO did not return a value.");
            }
        }
    }
}
