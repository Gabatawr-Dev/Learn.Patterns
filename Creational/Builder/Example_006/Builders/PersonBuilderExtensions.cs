namespace Patterns.Creational.Builder.Example_006.Builders;

public static class PersonBuilderExtensions
{
    public static PersonBuilder WorksAsA(this PersonBuilder @this, string position)
    {
        @this.Do(p => p.Position = position);
        return @this;
    }
}