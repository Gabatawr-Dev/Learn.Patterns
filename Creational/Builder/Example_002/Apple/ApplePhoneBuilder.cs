using Patterns.Creational.Builder.Example_002.Phone;

namespace Patterns.Creational.Builder.Example_002.Apple;

public class ApplePhoneBuilder : AbstractPhoneBuilder
{
    public ApplePhoneBuilder() : base(new ApplePhone()){}

    public override void CreateBody() => Phone.Data += "Model: pro;\t";
    public override void CreateElectronics() => Phone.Data += "Power: full;\t";
    public override void CreateOS() => Phone.Data += "OS: os11;\t";
    public override void CreateCase() => Phone.Data += "Case: premium;\t";
}