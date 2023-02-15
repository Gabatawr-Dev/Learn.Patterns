namespace Patterns.Creational.Builder.Example_002.Phone;

public abstract class AbstractPhoneBuilder
{
    public AbstractPhone Phone { get; protected init; }

    protected AbstractPhoneBuilder(AbstractPhone phone) => Phone = phone;

    public abstract void CreateBody();
    public abstract void CreateElectronics();
    public abstract void CreateOS();
    public abstract void CreateCase();
}