using Patterns.Creational.Builder.Example_002.Phone;

namespace Patterns.Creational.Builder.Example_002;

public class Factory
{
    public AbstractPhoneBuilder PhoneBuilder { get; set; }
    public Factory(AbstractPhoneBuilder phoneBuilder) => PhoneBuilder = phoneBuilder;

    public AbstractPhone CreatePhoneWithoutCase()
    {
        PhoneBuilder.CreateBody();
        PhoneBuilder.CreateElectronics();
        PhoneBuilder.CreateOS();

        return PhoneBuilder.Phone;
    }

    public AbstractPhone CreatePhoneWithoutOS()
    {
        PhoneBuilder.CreateBody();
        PhoneBuilder.CreateElectronics();
        PhoneBuilder.CreateCase();

        return PhoneBuilder.Phone;
    }

    public AbstractPhone CreatePhoneBoxOnly()
    {
        PhoneBuilder.CreateBody();
        PhoneBuilder.CreateElectronics();

        return PhoneBuilder.Phone;
    }
    public AbstractPhone CreatePhoneFull()
    {
        PhoneBuilder.CreateBody();
        PhoneBuilder.CreateElectronics();
        PhoneBuilder.CreateOS();
        PhoneBuilder.CreateCase();

        return PhoneBuilder.Phone;
    }
}