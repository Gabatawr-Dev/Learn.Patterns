namespace Patterns.Creational.Builder.Example_005.Builders;

/// <summary><i> 3 in the chain of inheritance </i></summary>
public class PersonBirthDateBuilder<TSelf> : PersonJobBuilder<TSelf>
    where TSelf : PersonBirthDateBuilder<TSelf>
{
    public TSelf Born(DateTime dateOfBirth)
    {
        Person.DateOfBirth = dateOfBirth;
        return (TSelf)this;
    }
}