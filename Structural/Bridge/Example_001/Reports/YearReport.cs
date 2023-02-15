using Patterns.Structural.Bridge.Example_001.Outputs;

namespace Patterns.Structural.Bridge.Example_001.Reports;

public class YearReport<T> : AbstractReport where T : AbstractOutput, new()
{
    public YearReport() : base(new T()) =>
        Type = ReportType.Year;
}