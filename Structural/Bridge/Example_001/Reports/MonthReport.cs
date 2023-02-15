using Patterns.Structural.Bridge.Example_001.Outputs;

namespace Patterns.Structural.Bridge.Example_001.Reports;

public class MonthReport : AbstractReport
{
    public MonthReport(AbstractOutput? output) : base(output) =>
        Type = ReportType.Month;
}