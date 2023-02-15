using Patterns.Creational.Builder.Example_001.Company.Builders;
using Patterns.Creational.Builder.Example_001.House.Hut;
using Patterns.Creational.Builder.Example_001.House.Skyscraper;

namespace Patterns.Creational.Builder.Example_001.Company;

public class Foreman
{

    private readonly List<AbstractBuilder> _builders;

    public Foreman(params AbstractBuilder[] builders) =>
        _builders = new(builders);

    public HutHouse? BuildHut()
    {
        var builder = _builders.OfType<HutBuilder>()
            .FirstOrDefault();
        if (builder == null) return null;

        builder.CreateBasement();
        builder.CreateStorey();
        builder.CreateRoof();

        return builder.CreateHouse() as HutHouse;
    }

    public SkyscraperHouse? BuildSkyscraper()
    {
        var builder = _builders.OfType<SkyscraperBuilder>()
            .FirstOrDefault();
        if (builder == null) return null;

        builder.CreateBasement();
        builder.CreateRoof();

        builder.CreateStorey();

        return builder.CreateHouse() as SkyscraperHouse;
    }
}