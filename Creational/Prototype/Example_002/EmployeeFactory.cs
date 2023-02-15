namespace Patterns.Creational.Prototype.Example_002;

public class EmployeeFactory
{
    private static readonly Contact _main = new()
    {
        WorkAddress = new Address { City = "London", Street = "221B Baker St" }
    };

    private static readonly Contact _aux = new()
    {
        WorkAddress = new Address { City = "London", Street = "250 Baker St" }
    };

    private static Contact NewEmployee(string name, int suite, Contact prototype)
    {
        var res = prototype.DeepCopy()!;
        res.Name = name;
        res.WorkAddress!.Suite = suite;
        return res;
    }

    public static Contact NewMainOfficeEmployee(string name, int suite) =>
        NewEmployee(name, suite, _main);

    public static Contact NewAuxOfficeEmployee(string name, int suite) =>
        NewEmployee(name, suite, _aux);
}