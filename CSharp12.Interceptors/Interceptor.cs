
using System.Runtime.CompilerServices;


namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    sealed class InterceptsLocationAttribute(string filePath, int line, int column) : Attribute
    {
    }
}

namespace Caveman
{
    public static class Scrabble
    {
        [InterceptsLocation("C:\\code\\DotNet8\\CSharp12.Interceptors\\Program.cs", 5, 28)]
        public static string InterceptedMyRandomMethod(int a, int b)
        {
            return $"{a} + {b} = 42";
        }
    }
}