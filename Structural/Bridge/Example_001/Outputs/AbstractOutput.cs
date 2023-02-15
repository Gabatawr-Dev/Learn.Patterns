using Patterns.Structural.Bridge.Example_001.Reports;

namespace Patterns.Structural.Bridge.Example_001.Outputs;

public abstract class AbstractOutput
{
    protected string Extension { get; init; }

    protected virtual void CreateHeader(AbstractReport report) =>
        Console.WriteLine($"Create header {Extension}");

    protected virtual void CreateBody(AbstractReport report) =>
        Console.WriteLine($"Create body {Extension}");

    protected virtual void CreateFooter(AbstractReport report) =>
        Console.WriteLine($"Create footer {Extension}");

    public virtual void Print(AbstractReport report)
    {
        Console.WriteLine($"Create {Extension}");

        CreateHeader(report);
        CreateBody(report);
        CreateFooter(report);

        Console.WriteLine($"Print {Extension}");
    }
}