using Patterns.Structural.Bridge.Example_001.Outputs;

namespace Patterns.Structural.Bridge.Example_001.Reports;

public class DayReport : AbstractReport
{
    public DayReport() =>
        Type = ReportType.Day;
}