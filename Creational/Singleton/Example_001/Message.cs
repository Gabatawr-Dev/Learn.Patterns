namespace Patterns.Creational.Singleton.Example_001;

public class Message
{
    private readonly string _msg;
    public Message(string msg) => _msg = msg;
    public override string ToString() => $"Message: {_msg}";
}