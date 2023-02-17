namespace Patterns.Creational.Builder.Example_005.Builders;

/// <summary><i> 2 in the chain of inheritance </i></summary>
public class PersonJobBuilder<TSelf> : PersonInfoBuilder<TSelf>
    where TSelf : PersonJobBuilder<TSelf>
{
    public TSelf WorksAsA(string position)
    {
        Person.Position = position;
        return (TSelf)this;
    }
}