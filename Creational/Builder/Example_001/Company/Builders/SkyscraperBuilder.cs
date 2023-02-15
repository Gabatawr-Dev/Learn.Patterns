using Patterns.Creational.Builder.Example_001.House.Skyscraper;
using Patterns.Creational.Builder.Example_001.House.Skyscraper.Parts;

namespace Patterns.Creational.Builder.Example_001.Company.Builders;

public class SkyscraperBuilder : AbstractBuilder
{
    public new SkyscraperBasement? Basement => base.Basement as SkyscraperBasement;

    public new List<SkyscraperStorey> Storeys
    {
        get
        {
            base.Storeys ??= new List<SkyscraperStorey>();
            return (List<SkyscraperStorey>)base.Storeys;
        }
    }

    public new SkyscraperRoof? Roof => base.Roof as SkyscraperRoof;

    public SkyscraperBuilder() =>
        StoreyCount = 55;

    public override void CreateBasement() =>
        base.Basement ??= new SkyscraperBasement();

    public override void CreateStorey()
    {
        if (Storeys.Count < StoreyCount)
            Storeys.Add(new SkyscraperStorey());
    }

    public override void CreateRoof() =>
        base.Roof ??= new SkyscraperRoof();

    protected override SkyscraperHouse CreateSpecificHouse() => new()
    {
        Basement = Basement!,
        Storeys = Storeys,
        Roof = Roof!
    };

}