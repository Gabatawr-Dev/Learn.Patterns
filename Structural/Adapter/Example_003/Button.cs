namespace Patterns.Structural.Adapter.Example_003;

public class Button
{
    private readonly ICommand _command;
    private readonly string _name;

    public Button(ICommand command, string name)
    {
        _command = command;
        _name = name;
    }

    public void Click() => _command.Execute();
    
    public void PrintMe() => 
        Console.WriteLine($"I am a button called {_name}");
}