using Patterns.Creational.Builder.Example_002.Apple;
using Patterns.Creational.Builder.Example_002.Samsung;

namespace Patterns.Creational.Builder.Example_002;

internal class Program
{
    static void Main(string[] args)
    {
        var factory = new Factory(new ApplePhoneBuilder());
        var phone = factory.CreatePhoneFull();
        Console.WriteLine(phone.Data);

        factory.PhoneBuilder = new SamsungPhoneBuilder();
        phone = factory.CreatePhoneWithoutCase();
        Console.WriteLine(phone.Data);
    }
}