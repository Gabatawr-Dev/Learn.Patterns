namespace Patterns.Creational.Prototype.Example_002;

internal class Program
{
    static void Main(string[] args)
    {
        var john = EmployeeFactory.NewMainOfficeEmployee("John", 100);
        var jill = EmployeeFactory.NewAuxOfficeEmployee("Jill", 10);

        Console.WriteLine(john);
        Console.WriteLine(jill);
    }
}