namespace Patterns.Creational.Builder.Example_006.Builders;

public sealed class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
{
    public PersonBuilder Called(string name) =>
        Do(p => p.Name = name);
}