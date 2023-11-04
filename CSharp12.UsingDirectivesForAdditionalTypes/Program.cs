using MyConsole;
//using Console = System.Console;

using NullableGuid = System.Guid?;
using Ints = int[];
using ComplexNumber = (decimal Real, decimal Imaginary);

_ = DateTime.Parse("2023-01-01");


NullableGuid guid = Guid.Empty;
guid = null;


var doStuff = (Ints i) => Console.WriteLine(i.Length);
doStuff(new[] { 1, 2, 3 });


var complexNumber = new ComplexNumber
{
    Real = 1.0m,
    Imaginary = 2.0m
};

System.Console.WriteLine(
    $"{complexNumber.Real} + {complexNumber.Imaginary}i");



namespace MyConsole
{
    class Console {
        public static void Hug() { }
        public static void ThereThere() { }
    }
}