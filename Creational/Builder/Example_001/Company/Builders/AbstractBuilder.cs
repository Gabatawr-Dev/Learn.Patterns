using Patterns.Creational.Builder.Example_001.House.Abstract;
using Patterns.Creational.Builder.Example_001.House.Abstract.Parts;

namespace Patterns.Creational.Builder.Example_001.Company.Builders;

public abstract class AbstractBuilder
{
    public uint StoreyCount { get; init; }

    public IBasement? Basement { get; set; }
    public IEnumerable<IStorey>? Storeys { get; set; }
    public IRoof? Roof { get; set; }

    public abstract void CreateBasement();
    public abstract void CreateStorey();
    public abstract void CreateRoof();

    public AbstractHouse? CreateHouse()
    {
        if (Basement == null || Storeys?.Count() == StoreyCount || Roof == null)
            return null;

        var house = CreateSpecificHouse();
        ClearParts();
        return house;
    }

    protected abstract AbstractHouse CreateSpecificHouse();

    protected void ClearParts()
    {
        Basement = null;
        Storeys = null;
        Roof = null;
    }
}