// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Text.Json;
using Azure;
using Azure.Core;

Console.WriteLine("Hello, World!");

dynamic json = new JsonData(new
{
    Foo = new
    {
        Bar = "hi",
        CreatedOn = DateTimeOffset.Now,
    }
});

Console.WriteLine(json.Foo);
Console.WriteLine(json.Foo.Bar);
Console.WriteLine(json);

//DateTimeOffset createdOn = (DateTimeOffset)json.Foo.CreatedOn;
DateTimeOffset createdOn = json.Foo.CreatedOn.To<DateTimeOffset>();
Console.WriteLine(createdOn);

//FooModel model = (FooModel)json;
//Console.WriteLine(model.Bar);

json = JsonData.FromString("5");

Console.WriteLine(((int)json) + 5);

json = JsonData.FromString("[1, 2, 3, 4, 5, 6]");

Console.WriteLine((int)json[5]);

// Cast to custom model: `var model = (FooModel)json.Foo`




Console.ReadLine();

public class FooModel
{
    public string Bar { get; set; }

    public DateTimeOffset CreatedOn { get; set; }
}

//public interface IFooModel
//{
//}
//
//public class FooModel : IFooModel
//{
//    public string Bar { get; set; }

//    private static FooModel FromJsonData(JsonData jsonData)
//    {
//        throw new NotImplementedException();
//    }

//    /// <summary>
//    /// Converts the value to a <see cref="double"/> or null.
//    /// </summary>
//    /// <param name="json">The value to convert.</param>

//    // This works
//    public static explicit operator FooModel?(JsonData json) => FromJsonData(json);
//}

//public interface IFooModel
//{
//}

