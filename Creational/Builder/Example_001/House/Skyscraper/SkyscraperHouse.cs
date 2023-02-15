using Patterns.Creational.Builder.Example_001.House.Abstract;
using Patterns.Creational.Builder.Example_001.House.Skyscraper.Parts;

namespace Patterns.Creational.Builder.Example_001.House.Skyscraper;

public class SkyscraperHouse : AbstractHouse
{
    public new SkyscraperRoof Roof
    {
        get => (SkyscraperRoof)base.Roof;
        init => base.Roof = value;
    }

    public new IEnumerable<SkyscraperStorey> Storeys
    {
        get => base.Storeys.OfType<SkyscraperStorey>();
        init => base.Storeys = value;
    }

    public new SkyscraperBasement Basement
    {
        get => (SkyscraperBasement)base.Basement;
        init => base.Basement = value;
    }
}