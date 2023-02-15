using Patterns.Creational.Builder.Example_001.House.Abstract.Parts;

namespace Patterns.Creational.Builder.Example_001.House.Abstract;

public abstract class AbstractHouse
{
    public IRoof Roof { get; init; }
    public IEnumerable<IStorey> Storeys { get; init; }
    public IBasement Basement { get; init; }
}