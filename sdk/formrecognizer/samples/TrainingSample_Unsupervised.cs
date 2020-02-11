// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Custom;
using System;
using System.Threading.Tasks;

namespace Azure.AI.FormRecognizer.Samples
{
    public class TrainingSample_Unsupervised
    {

        public static async Task Main(string[] args)
        {
            try
            {
                await Train();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static async Task Train()
        {
            string endpoint = Environment.GetEnvironmentVariable("FORM_RECOGNIZER_ENDPOINT");
            string subscriptionKey = Environment.GetEnvironmentVariable("FORM_RECOGNIZER_SUBSCRIPTION_KEY");

            var credential = new CognitiveKeyCredential(subscriptionKey);
            var client = new CustomRecognizerClient(new Uri(endpoint), credential, new FormRecognizerClientOptions());

            string trainingFilePath = "https://annelostorage01.blob.core.windows.net/container-formreco?sp=rl&st=2020-02-01T03:54:59Z&se=2020-02-02T03:54:59Z&sv=2019-02-02&sr=c&sig=%2FlZqrmWSI%2FZ%2B9TeWdJynZfGzQmLws9zz7NB5foEjPjg%3D";

            TrainingOperation op = await client.StartTrainingAsync(trainingFilePath, new TrainingFileFilter());

            Console.WriteLine($"Created model with id {op.Id}");

            Console.WriteLine("Waiting for completion...");

            await op.WaitForCompletionAsync(TimeSpan.FromSeconds(1));
            if (op.HasValue)
            {
                // TODO: How would this be used in a customer scenario?
                TrainingResult value = op.Value;

                Console.WriteLine($"Model Id is: {value.Model.ModelId}");
                Console.WriteLine($"Model Creation Time: {value.TrainingInfo.CompletionTime}");

                //// TODO: Is this relevant to unsupervised models?
                //Console.WriteLine($"Average model accuracy is: {value.AverageModelAccuracy}");

                Console.WriteLine("Identified fields in clusters: ");
                foreach (var cluster in value.Model.FormClusters)
                {
                    Console.WriteLine($"    Form Cluster : {cluster.FormClusterId}");
                    foreach (var fieldName in cluster.FieldNames)
                    {
                        Console.WriteLine($"        Field Name: {fieldName}");
                    }
                }

                //// TODO: Does this come back from unsupervised?  How is it different from the fields contained
                //// in the form clusters?
                //Console.WriteLine("Fields and accuracies: ");
                //foreach (var field in value.FieldAccuracies)
                //{
                //    Console.WriteLine($"Field: {field.FieldName}");
                //    Console.WriteLine($"Accuracy: {field.Accuracy}");
                //}

                Console.WriteLine("Document Training Results: ");
                foreach (var trainingInputResult in value.TrainingInputResults)
                {
                    Console.WriteLine($"Document Name: {trainingInputResult.DocumentName}");
                    Console.WriteLine($"Number of pages trained: {trainingInputResult.TotalTrainedPages}");
                    Console.WriteLine($"Training status for this document: {trainingInputResult.SuccessStatus}");

                    Console.WriteLine($"Document training errors: ");
                    foreach (var error in trainingInputResult.TrainingInputErrors)
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
