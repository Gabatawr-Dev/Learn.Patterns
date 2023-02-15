using Patterns.Structural.Bridge.Example_001.Outputs;

namespace Patterns.Structural.Bridge.Example_001.Reports;

public enum ReportType
{
    Year, Month, Day
}

public abstract class AbstractReport
{
    public AbstractOutput? Output { get; set; }
    public ReportType Type { get; init; }

    protected AbstractReport(AbstractOutput? output = null) =>
        Output = output;

    public void Print()
    {
        Output?.Print(this);
        Console.WriteLine($"{(Output == null ? "Invalid output!" : $"{Type} report printed!")}\n");
    }
}