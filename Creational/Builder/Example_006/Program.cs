using Patterns.Creational.Builder.Example_006.Builders;

namespace Patterns.Creational.Builder.Example_006;

internal class Program
{
    private static void Main()
    {
        var b = new PersonBuilder();
        var p = b
            .Called("Dmitri")
            .WorksAsA("Developer")
            .Build();

        Console.WriteLine(p);
    }
}