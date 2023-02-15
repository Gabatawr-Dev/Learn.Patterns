namespace Patterns.Creational.Singleton.Example_001;

public class Logger
{
    public static Logger Log { get; private set; } = new();

    private bool _inLog;

    private Logger()
    {
        Log = this;
        Write($"{nameof(Logger)} created!");
    }

    public Logger this[params object[] messages]
    {
        get
        {
            if (_inLog is false) ToggleState();
            foreach (var msg in messages)
                Console.WriteLine($"  {msg}");
            return Log;
        }
    }

    public void EndL()
    {
        if (_inLog)
            ToggleState();
    }

    public void WaitL(){}

    private void ToggleState()
    {
        _inLog = !_inLog;
        Console.WriteLine(_inLog ? $"log({DateTime.Now:dd.MM.yyyy, HH:mm:ss})\n" + '{' : '}');
    }

    public static void Write(params object[] messages) => 
        Log[messages].EndL();
}