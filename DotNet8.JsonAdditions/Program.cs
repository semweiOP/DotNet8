using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

var json = """
    {
        "Name":"John",
        "FirstName":"Doe",
        "Age":44
    }
    """;

var person1 = JsonSerializer.Deserialize<Person>(json);
Console.WriteLine(person1);

var serialized0 = JsonSerializer.Serialize(person1);
Console.WriteLine(serialized0);

////1.
//try
//{
//    var person2 = JsonSerializer.Deserialize<Person>(json, new JsonSerializerOptions
//    {
//        UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow
//    });
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


////2.
//// {"name":"John","first_name":"Doe"}
//var serialized1 = JsonSerializer.Serialize(person1, new JsonSerializerOptions
//{
//    PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
//});

//Console.WriteLine(serialized1);


////.3
//// {"NAME":"John","FIRST-NAME":"Doe"}
//var serialized2 = JsonSerializer.Serialize(person1, new JsonSerializerOptions
//{
//    PropertyNamingPolicy = JsonNamingPolicy.KebabCaseUpper
//});

//Console.WriteLine(serialized2);


////.4
//Changing some metadata properties
//var serialized3 = JsonSerializer.Serialize(person1, new JsonSerializerOptions
//{
//    TypeInfoResolver = MyContext.Default
//        //.WithAddedModifier(static typeInfo =>
//        //{
//        //    foreach (JsonPropertyInfo prop in typeInfo.Properties)
//        //        prop.Name = prop.Name.ToUpperInvariant();
//        //})
//});


//Console.WriteLine(serialized3);


record Person(string Name, string FirstName) ;


////.4
//Source generator
//[JsonSerializable(typeof(Person))]
//partial class MyContext : JsonSerializerContext
//{ }
