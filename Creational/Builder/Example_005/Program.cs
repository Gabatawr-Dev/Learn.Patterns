namespace Patterns.Creational.Builder.Example_005;

public class Program
{
    private static void Main()
    {
        var person = Person
            .New.Called("Dmitri")
                .WorksAsA("Quant")
                .Born(DateTime.UtcNow)
            .Build();

        Console.WriteLine(person);
    }
}