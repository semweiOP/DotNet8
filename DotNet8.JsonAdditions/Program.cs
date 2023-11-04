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


//// {"name":"John","first_name":"Doe"}
//var serialized1 = JsonSerializer.Serialize(person1, new JsonSerializerOptions
//{
//    PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
//});

//Console.WriteLine(serialized1);


//// {"NAME":"John","FIRST-NAME":"Doe"}
//var serialized2 = JsonSerializer.Serialize(person1, new JsonSerializerOptions
//{
//    PropertyNamingPolicy = JsonNamingPolicy.KebabCaseUpper
//});

//Console.WriteLine(serialized2);


////Changing some metadata properties
//var serialized3 = JsonSerializer.Serialize(person1, new JsonSerializerOptions
//{
//    TypeInfoResolver = MyContext.Default
//        .WithAddedModifier(static typeInfo =>
//        {
//            foreach (JsonPropertyInfo prop in typeInfo.Properties)
//                prop.Name = prop.Name.ToUpperInvariant();
//        })
//});


//Console.WriteLine(serialized3);


record Person(string Name, string FirstName) ;


//record Person(string Name, string FirstName) : IDerived;

////Interface hierarchies
//internal interface IDerived: IBase
//{
//    string Name { get; }
//}

//internal interface IBase
//{
//   string FirstName { get; }
//}



////Source generator
//[JsonSerializable(typeof(Person))]
//partial class MyContext : JsonSerializerContext
//{ }
