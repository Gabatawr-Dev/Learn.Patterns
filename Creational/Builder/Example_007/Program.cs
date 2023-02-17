namespace Patterns.Creational.Builder.Example_007;

internal class Program
{
    private static void Main()
    {
        var ms = new MailService();
        ms.SendEmail(email => email
            .From("foo@bar.com")
            .To("bar@baz.com")
            .Subject("Test")
            .Body("Hello, how are you?"));
    }
}