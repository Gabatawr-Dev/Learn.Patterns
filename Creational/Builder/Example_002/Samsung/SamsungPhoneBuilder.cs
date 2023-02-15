using Patterns.Creational.Builder.Example_002.Phone;

namespace Patterns.Creational.Builder.Example_002.Samsung;

public class SamsungPhoneBuilder : AbstractPhoneBuilder
{
    public SamsungPhoneBuilder() : base(new SamsungPhone()){}

    public override void CreateBody() => Phone.Data += "Model: super;\t";
    public override void CreateElectronics() => Phone.Data += "Power: medium;\t";
    public override void CreateOS() => Phone.Data += "OS: samOS;\t";
    public override void CreateCase() => Phone.Data += "Case: deluxe;\t";
}