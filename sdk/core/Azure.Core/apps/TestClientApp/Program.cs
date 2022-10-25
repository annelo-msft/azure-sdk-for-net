using System;
using Azure;
using Azure.Core;
using TestClientApp;


// Simple tests

// Array access
dynamic jsonData =
    new BinaryData("{ \"primitive\":\"Hello\", \"nested\": { \"nestedPrimitive\":true } , \"array\": [1, 2, 3] }")
    .ToDynamic();
//Console.WriteLine("Array values are: ");
//Console.WriteLine($"  {(int)jsonData.array[0]}");
//Console.WriteLine($"  {(int)jsonData.array[1]}");
//Console.WriteLine($"  {(int)jsonData.array[2]}");
//Console.WriteLine();

// Property access
Console.WriteLine("Property values are: ");
Console.WriteLine($"   primitive = {(string)jsonData.primitive}");
Console.WriteLine($"   nestedPrimitive = {(bool)jsonData.nested.nestedPrimitive}");
Console.WriteLine();


// End
Console.WriteLine("Done.");
Console.ReadLine();
