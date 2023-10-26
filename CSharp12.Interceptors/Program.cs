Console.WriteLine("Ultimate multiply!");
Console.WriteLine("-------------");
Console.WriteLine("by Semyon Weibull");

Console.WriteLine(Ultimate.Multiply(6, 9));

public static class Ultimate
{
    public static string Multiply(int a, int b)
    {
        return $"{a} + {b} = {a + b}";
    }
}

