namespace Patterns.Structural.Adapter.Example_003;

public interface ICommand
{
    void Execute();
}

public class SaveCommand : ICommand
{
    public void Execute() => 
        Console.WriteLine("Saving current file");
}

public class OpenCommand : ICommand
{
    public void Execute() => 
        Console.WriteLine("Opening a file");
}