namespace Patterns.Creational.Builder.Example_005.Builders;

/// <summary><i> 1 in the chain of inheritance </i></summary>
public class PersonInfoBuilder<TSelf> : PersonBuilder
    where TSelf : PersonInfoBuilder<TSelf>
{
    public TSelf Called(string name)
    {
        Person.Name = name;
        return (TSelf)this;
    }
}