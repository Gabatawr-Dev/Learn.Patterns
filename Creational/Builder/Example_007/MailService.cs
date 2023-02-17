using System.Text;

namespace Patterns.Creational.Builder.Example_007;

public class MailService
{
    private void SendEmailInternal(EmailBuilder.Email email) => 
        Console.WriteLine(email);

    public void SendEmail(Action<EmailBuilder> builder)
    {
        var email = new EmailBuilder.Email();
        builder(new EmailBuilder(email));
        SendEmailInternal(email);
    }

    public class EmailBuilder
    {
        private readonly Email _email;
        public EmailBuilder(Email email) =>
            _email = email;

        public EmailBuilder From(string from)
        {
            _email.From = from;
            return this;
        }

        public EmailBuilder To(string to)
        {
            _email.To = to;
            return this;
        }

        public EmailBuilder Subject(string subject)
        {
            _email.Subject = subject;
            return this;
        }

        public EmailBuilder Body(string body)
        {
            _email.Body = body;
            return this;
        }

        public class Email
        {
            public string? From, To, Subject, Body;

            public override string ToString()
            {
                var sb = new StringBuilder();
                const int pr = 14;

                sb.AppendLine($"{nameof(From).PadRight(pr)}: {From}");
                sb.AppendLine($"{nameof(To).PadRight(pr)}: {To}");
                sb.AppendLine($"{nameof(Subject).PadRight(pr)}: {Subject}");
                sb.AppendLine($"{nameof(Body).PadRight(pr)}: {Body}");

                return sb.ToString();
            }
        }
    }
}