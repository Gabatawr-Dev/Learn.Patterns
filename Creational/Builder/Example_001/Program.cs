using Patterns.Creational.Builder.Example_001.Company;
using Patterns.Creational.Builder.Example_001.Company.Builders;

namespace Patterns.Creational.Builder.Example_001;

internal class Program
{
    static void Main(string[] args)
    {
        var foreman= new Foreman(new HutBuilder(), new SkyscraperBuilder());

        var hut = foreman.BuildHut();
        var skyscraper = foreman.BuildSkyscraper();
    }
}