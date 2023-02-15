using Patterns.Creational.Builder.Example_004.Builders;

namespace Patterns.Creational.Builder.Example_004;

public class Program
{
    private static void Main()
    {
        var pb = new PersonBuilder();
        Person person = pb
            .Lives
                .At("123 London Road")
                .In("London")
                .WithPostcode("SW12BC")
            .Works
                .At("Fabrikam")
                .AsA("Engineer")
                .Earning(123000);

        Console.WriteLine(person);
    }
}