using Patterns.Creational.Builder.Example_001.House.Hut;
using Patterns.Creational.Builder.Example_001.House.Hut.Parts;

namespace Patterns.Creational.Builder.Example_001.Company.Builders;

public class HutBuilder : AbstractBuilder
{
    public new HutBasement? Basement => base.Basement as HutBasement;

    public new List<HutStorey> Storeys
    {
        get
        {
            base.Storeys ??= new List<HutStorey>();
            return (List<HutStorey>)base.Storeys;
        }
    }

    public new HutRoof? Roof => base.Roof as HutRoof;

    public HutBuilder() =>
        StoreyCount = 1;

    public override void CreateBasement() =>
        base.Basement ??= new HutBasement();

    public override void CreateStorey()
    {
        if (Storeys.Count < StoreyCount)
            Storeys.Add(new HutStorey());
    }

    public override void CreateRoof() =>
        base.Roof ??= new HutRoof();

    protected override HutHouse CreateSpecificHouse() => new()
    {
        Basement = Basement!,
        Storeys = Storeys!,
        Roof = Roof!
    };

}