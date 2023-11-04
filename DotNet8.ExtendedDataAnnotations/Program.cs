using System.ComponentModel.DataAnnotations;


var model = new ViewModel
{
    Sample =0,
    Values = Array.Empty<int>(),
    Fruit = "orange",
    PizzaTopping = "pineapple",
    Data = "D@a",
};

ValidationContext context = new(model, null, null);
List<ValidationResult> results = [];

bool isValid = Validator.TryValidateObject(model, context, results, true);
Console.WriteLine("Is model valid? {0}", isValid);
foreach (var result in results)
{
    Console.WriteLine(result.ErrorMessage);
}


class ViewModel
{
    [Range(0d, 1d, MinimumIsExclusive = true, MaximumIsExclusive = true)]
    public required double Sample { get; init; }


    [Length(10, 20)]
    public required ICollection<int> Values { get; init; }


    [AllowedValues("apple", "banana", "mango")]
    public required string Fruit { get; init; }


    [DeniedValues("pineapple", "anchovy", "broccoli")]
    public required string PizzaTopping { get; init; }


    [Base64String]
    public required string Data { get; init; }
}