// See https://aka.ms/new-console-template for more information
using System.Text;
using Azure;

Console.WriteLine("Hello, World!");

//dynamic json = JsonData.Parse(new BinaryData(new
//{
//    Foo = new
//    {
//        Bar = "hi"
//    }
//}));

//Console.WriteLine(json.Foo);
//Console.WriteLine(json.Foo.Bar);
//Console.WriteLine(json);

//var model = (FooModel)json;
//Console.WriteLine(model.Bar);

//dynamic json = JsonData.Parse("5");
//Console.WriteLine(((int)json) + 5);

//dynamic json = JsonData.Parse("[1, 2, 3, 4, 5, 6]");
//Console.WriteLine((int)json[5]);

// TODO:
// Cast to custom model: `var model = (FooModel)json.Foo`
dynamic json = JsonData.Parse(new BinaryData(new
{
    Foo = new
    {
        Bar = "hi"
    }
}));
dynamic foo = json.Foo;

FooModel model = (FooModel)foo;


Console.ReadLine();


public class FooModel
{
    public string Bar { get; set; }
}
