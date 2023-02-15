namespace Patterns.Creational.Builder.Example_004.Builders;

public class PersonBuilder
{
    protected Person Person;
    public PersonBuilder() => Person = new Person();
    protected PersonBuilder(Person person) => Person = person;

    public PersonAddressBuilder Lives => new(Person);
    public PersonJobBuilder Works => new(Person);

    public Person Build()
    {
        Console.WriteLine("Building an instance of Person");
        return Person;
    }

    public static implicit operator Person(PersonBuilder pb) => 
        pb.Build();
}