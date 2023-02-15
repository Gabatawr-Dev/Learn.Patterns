using Patterns.Creational.Builder.Example_001.House.Abstract;
using Patterns.Creational.Builder.Example_001.House.Hut.Parts;

namespace Patterns.Creational.Builder.Example_001.House.Hut;

public class HutHouse : AbstractHouse
{
    public new HutRoof Roof
    {
        get => (HutRoof)base.Roof;
        init => base.Roof = value;
    }

    public new IEnumerable<HutStorey> Storeys
    {
        get => base.Storeys.OfType<HutStorey>();
        init => base.Storeys = value;
    }

    public new HutBasement Basement
    {
        get => (HutBasement)base.Basement;
        init => base.Basement = value;
    }
}