using Patterns.Structural.Adapter.Example_002.AdapterLib;

namespace Patterns.Structural.Adapter.Example_002;

internal class Program
{
    static void Main(string[] args)
    {
        ILib lib = new USLib();

        Console.WriteLine(lib.Sum(1, 2));
        Console.WriteLine(lib.Div(2, 1));
        Console.WriteLine(lib.Rem(3, 2));
    }
}