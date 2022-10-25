using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure;

namespace TestClientApp
{
    public class FormRecognizerTests
    {
        public void TestFormRecognizerCase()
        {
            #region FormRecognizer sample
            var data = new BinaryData(JsonSamples.FormRecognizerJson);
            dynamic json = data.ToDynamic();

            // Sentiment analysis per document
            Console.WriteLine("Documents:");
            foreach (dynamic doc in json.documents)
            {
                Console.WriteLine("  Document:");

                Console.WriteLine("     Id: " + (string)doc.id); // Unique, non-empty document identifier.
                Console.WriteLine("     Sentiment: " + (string)doc.sentiment); // Predicted sentiment for document (Negative, Neutral, Positive, or Mixed).

                // The sentiment confidence score between 0 and 1 for the document for all classes
                Console.WriteLine("     Confidence Scores:");
                Console.WriteLine("       Positive: " + (double)doc.confidenceScores.positive); // positive sentiment confidence scores between 0 and 1
                Console.WriteLine("       Neutral: " + (double)doc.confidenceScores.neutral); // neutral sentiment confidence scores between 0 and 1
                Console.WriteLine("       Negative: " + (double)doc.confidenceScores.negative); // negative sentiment confidence scores between 0 and 1

                // Sentence level sentiment analysis
                Console.WriteLine("     Sentences:");
                foreach (dynamic sentence in doc.sentences)
                {
                    Console.WriteLine("       Sentence:");
                    Console.WriteLine("         Sentiment:" + (string)sentence.sentiment); // The predicted Sentiment for the sentence
                    Console.WriteLine("         Offset:" + (int)sentence.offset); // The sentence offset from the start of the document
                    Console.WriteLine("         Length:" + (int)sentence.length); // The length of the sentence
                    Console.WriteLine("         Text:" + (string)sentence.text); // The sentence text.

                    // The sentiment confidence score between 0 and 1 for the sentence for all classes
                    Console.WriteLine("         Confidence Scores:");
                    Console.WriteLine("           Positive: " + (double)sentence.confidenceScores.positive); // positive sentiment confidence scores between 0 and 1
                    Console.WriteLine("           Neutral: " + (double)sentence.confidenceScores.neutral); // neutral sentiment confidence scores between 0 and 1
                    Console.WriteLine("           Negative: " + (double)sentence.confidenceScores.negative); // negative sentiment confidence scores between 0 and 1

                    // ...
                }

                // Warnings encountered while processing document.
                Console.WriteLine("     Warnings:");
                foreach (dynamic warning in doc.warnings)
                {
                    Console.WriteLine("       Warning:");
                    Console.WriteLine("         Code: " + (string)warning.code); // Error code.
                    Console.WriteLine("         Message: " + (string)warning.message); // Warning message.
                    Console.WriteLine("         Target: " + (string)warning.targetRef); // A JSON pointer reference indicating the target object.
                }
            }

            #endregion
        }
    }
}
